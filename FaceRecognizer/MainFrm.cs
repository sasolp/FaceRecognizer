using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlServerCe;
using System.Runtime.InteropServices;
namespace FaceRecognizer
{
    public partial class MainFrm : Form
    {
        
        [DllImport(@"Face2.dll", EntryPoint = "CalculateSSIM", SetLastError = true, ExactSpelling = true,
           CallingConvention = CallingConvention.StdCall)]
        private static extern double  CalculateSSIM(string file1, string file2, int blockSize);
        public MainFrm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar != 46))
            {
                e.Handled = true;
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            if (chkPicFromCam.Checked)
            {
                CaptureSingleShotTimer.Stop();
                string strTemp = System.IO.Path.GetTempFileName().Replace(".tmp", ".bmp");
                int x = -1, y = -1, w = -1, h = -1;

                capturer.NextFrame(strTemp, chkAcurateFaceDetection.Checked ? 1 : 0, out x, out y, out w, out h);

                if (w > 0 && h > 0)
                {
                    Image img = new Bitmap(strTemp);

                    Bitmap newImg = new Bitmap(w, h);
                    Graphics gr = Graphics.FromImage(newImg);
                    gr.DrawImage(img, new Rectangle(0, 0, w, h), new Rectangle(x, y, w, h), GraphicsUnit.Pixel);
                    string newPath = "Faces\\" + new Random().Next().ToString() + ".bmp";
                    img.Dispose();
                    img = null;
                    GC.Collect();
                    newImg.Save(newPath);
                    picFace.ImageLocation = newPath;

                    System.IO.File.Delete(strTemp.Replace(".bmp", ".tmp"));
                    System.IO.File.Delete(strTemp);
                }
                else
                {
                    MessageBox.Show("تصویر انتخاب شده فاقد چهره می باشد");
                }
            }
            else
            {
                of.Filter = "|*.jpeg;*.jpg;*.JPEG;*.JPG|*.bmp;*.BMP|*.png;.PNG|*.tiff;*.tif;*.TIFF;*.TIF|";
                if (of.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {

                    if (capturer == null)
                    {
                        capturer = new FaceLib.Capturer();
                    }
                    int x = -1, y = -1, w = -1, h = -1;


                    capturer.ExtractFace(of.FileName, chkAcurateFaceDetection.Checked ? 1 : 0, out x, out y, out w, out h);
                    if (w > 0 && h > 0)
                    {
                        Image img = new Bitmap(of.FileName);

                        Bitmap newImg = new Bitmap(w, h);
                        Graphics gr = Graphics.FromImage(newImg);
                        gr.DrawImage(img, new Rectangle(0, 0, w, h), new Rectangle(x, y, w, h), GraphicsUnit.Pixel);
                        string newPath = "Faces\\" + new Random().Next().ToString() + ".bmp";
                        newImg.Save(newPath);
                        picFace.ImageLocation = newPath;
                    }
                    else
                    {
                        MessageBox.Show("تصویر انتخاب شده فاقد چهره می باشد");
                    }
                }
            }
        }
        public SqlCeConnection sconn;
        SqlCeDataAdapter sda;
        SqlCeCommandBuilder cb;
        SqlCeCommand scommand;
        DataTable personTable;
        private void Form1_Load(object sender, EventArgs e)
        {
            // gridPersons.DataSource = 
            System.IO.Directory.CreateDirectory( System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\Faces");
            try
            {
                sconn = new SqlCeConnection("Data Source=" + System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) +
                                            @"\FaceDataBase.sdf;Persist Security Info=false;Password=sasol321;");                
                scommand = new SqlCeCommand("select * from Persons", sconn);

                sda = new SqlCeDataAdapter(scommand);
                cb = new SqlCeCommandBuilder(sda);
                sda.InsertCommand = cb.GetInsertCommand();
                sda.DeleteCommand = cb.GetDeleteCommand();
                sda.UpdateCommand = cb.GetUpdateCommand();
                personTable = new DataTable();

                //gridPersons.AutoGenerateColumns = true;                
                gridPersons.DataSource = personTable;
                sda.Fill(personTable);

                gridPersons.Columns[0].HeaderText = "شناسه";

                gridPersons.Columns[1].HeaderText = "نام";

                gridPersons.Columns[2].HeaderText = "سن";

                gridPersons.Columns[3].HeaderText = "جنسیت";

                gridPersons.Columns[4].HeaderText = "مسیر";
                gridPersons.Columns[5].HeaderText = "تصویر";
                ((DataGridViewImageColumn)gridPersons.Columns[5]).ImageLayout = DataGridViewImageCellLayout.Stretch;
                gridPersons.Columns[5].Width = 150;
                //gridPersons.Columns[4].Width = 100;
                for (int i = 0; i < gridPersons.Rows.Count; i++)
                {
                    gridPersons.Rows[i].Height = 150;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            capturer = new FaceLib.Capturer();

            faceExaminer = new FaceLib.FaceExaminer();
            faceTrainer = new FaceLib.FaceTrainer();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            object[] param = new object[6];
            if (txtName.Text == "")
            {
                MessageBox.Show("لطفا نام شخص را وارد نمایید");
                return;
            }

            if (picFace.ImageLocation == "")
            {
                MessageBox.Show("لطفا تصویر شخص را انتخاب نمایید");
                return;
            }
            if (personTable.Rows.Count >= 1)
            {
                param[0] = (int)(personTable.Rows[personTable.Rows.Count - 1].ItemArray[0]) + 1;
            }
            else
            {
                param[0] = 1;
            }
            param[1] = txtName.Text;
            if (txtAge.Text != "")
                param[2] = (int)(float.Parse(txtAge.Text));
            param[3] = rdMale.Checked;
            //param[4] = picFace.Image;

            if (picFace.ImageLocation != null && picFace.ImageLocation != "")
            {
                param[4] = picFace.ImageLocation;
                param[5] = System.IO.File.ReadAllBytes(picFace.ImageLocation);
            }
            else
            {
                string path = System.IO.Path.GetTempFileName();
                picFace.Image.Save(path);
                param[4] = path;
                param[5] = System.IO.File.ReadAllBytes(path);
                //System.IO.File.Delete(path);
            }
           // param[4] = System.IO.File.ReadAllBytes(picFace.ImageLocation);
            personTable.Rows.Add(param);
            sda.Update(personTable);
        }

        private void gridPersons_CurrentCellChanged(object sender, EventArgs e)
        {

            if (gridPersons.CurrentRow != null)
            {
                txtName.Text = gridPersons.CurrentRow.Cells[1].Value.ToString();
                txtAge.Text = gridPersons.CurrentRow.Cells[2].Value.ToString();
                rdMale.Checked = (bool)gridPersons.CurrentRow.Cells[3].Value;
                rdFemale.Checked = !rdMale.Checked;
                picFace.Image = Image.FromStream(new System.IO.MemoryStream((byte[])(gridPersons.CurrentRow.Cells[5].Value)));
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            //gridPersons.CurrentRow.Cells[1].Value = txtName.Text;
            personTable.Rows[gridPersons.CurrentRow.Index].SetField<string>(1, txtName.Text);
            personTable.Rows[gridPersons.CurrentRow.Index].SetField<string>(2, txtAge.Text);
            personTable.Rows[gridPersons.CurrentRow.Index].SetField<bool>(3, rdMale.Checked);
            if (picFace.ImageLocation != null && picFace.ImageLocation != "")
            {
                personTable.Rows[gridPersons.CurrentRow.Index].SetField<string>(4, picFace.ImageLocation);
                personTable.Rows[gridPersons.CurrentRow.Index].SetField<byte[]>(5, System.IO.File.ReadAllBytes(picFace.ImageLocation));
            }
            else
            {
                string path = System.IO.Path.GetTempFileName();
                picFace.Image.Save(path);
                personTable.Rows[gridPersons.CurrentRow.Index].SetField<string>(4, path);
                personTable.Rows[gridPersons.CurrentRow.Index].SetField<byte[]>(5, System.IO.File.ReadAllBytes(path));
                //System.IO.File.Delete(path);
            }
            sda.AcceptChangesDuringUpdate = true;
            sda.Update(personTable);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sda.AcceptChangesDuringUpdate = true;
            sda.AcceptChangesDuringFill = true;
            if (gridPersons.CurrentRow != null)
            personTable.Rows[gridPersons.CurrentRow.Index ].Delete();
            sda.Update(personTable);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "JPEG(*.jpg)|*.jpeg;*.jpg;*.JPEG;*.JPG|BitMaps(*.bmp)|*.bmp;*.BMP|Png|*.png;*.PNG|*.tiff;*.tif;*.TIFF;*.TIF|";
            if (of.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtSourceFile.Text = of.FileName;
                picTestSource.Image = Image.FromFile(txtSourceFile.Text);
            }
        }
        FaceLib.FaceTrainer faceTrainer;
        FaceLib.FaceExaminer faceExaminer;
        private void button5_Click(object sender, EventArgs e)
        {
            for (int i = 0 ; i < personTable.Rows.Count;i++ )
            {
                DataRow row = personTable.Rows[i]; 
                string path = (string)row.ItemArray[4];
                int id = (int)row.ItemArray[0];
                
                faceTrainer.AddImage(path, id);
            }
            faceTrainer.Train();
            
        }

        private void rdCamera_CheckedChanged(object sender, EventArgs e)
        {
            grpCamera.Enabled = rdCamera.Checked;
            grpFile.Enabled = rdFile.Checked;
            grpVideo.Enabled = rdVideo.Checked;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (rdVideo.Checked)
            {
                OpenFileDialog of = new OpenFileDialog();
                of.Filter = "AVI Files|*.avi|Video CD Files|*.dat;*.vcd*|MPEG-4 Files|*.mp4|MPEG Files|*.mpeg" +
                    "|MPEG Files|*.mpe|MPEG Files|*.mpg|Flash Video|*.flv|DIVx Video|*.divx" +
                    "|DVD Files|*.vob|3GP Mobile Video|*.3gp|MKV Files|*.mkv|Windows Media Video Files|*.wmv|Apple Video Files|*.mov";
                if (of.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    txtSourceVideo.Text = of.FileName;
                    if (capturer == null)
                    {
                        capturer = new FaceLib.Capturer();
                    }
                    if (System.IO.File.Exists(txtSourceVideo.Text))
                        capturer.CaptureVideo(txtSourceVideo.Text);
                    CameraTimer.Enabled = true;
                    CameraTimer.Start();

                }
            }
        }
        FaceLib.ICapturer capturer;
        private void button4_Click_1(object sender, EventArgs e)
        {
           // ATLFaceProcessLib.VideoCapturerClass v = new ATLFaceProcessLib.VideoCapturerClass();
            if(capturer == null)
                capturer = new FaceLib.Capturer();
            else
                capturer.ReleaseCapture();
            //Capturer c = new Capturer();
            int index = int.Parse(txtSourceCam.Text);
            capturer.Capture(index);
            CameraTimer.Enabled = true;
            CameraTimer.Start();
            GarbageTimer.Enabled = true;
            GarbageTimer.Start();
        }
        List<string> garbageFrames = new List<string>() ;
        private void CameraTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                string strTemp = System.IO.Path.GetTempFileName().Replace(".tmp", ".bmp");
                //sbyte[] arrPath = strTemp.ToArray<char>().ToArray<sbyte>();
                int x = -1, y = -1, w = -1, h = -1;
                garbageFrames.Add(strTemp);

                capturer.NextFrame(strTemp, chkAcurateFaceDetection.Checked?1:0, out x, out y, out w, out h);

                picTestSource.Image = Bitmap.FromFile( strTemp, true);
                if (h > 30 && w > 30)
                {
                    Bitmap bmp = new Bitmap(picTestSource.Image);
                    Graphics gr = Graphics.FromImage(bmp);
                    gr.DrawRectangle(new Pen(Brushes.Blue, 5), x, y, w, h);
                    picTestSource.Image = bmp;                    
                }
                int label = 0;
                if (faceExaminer != null)
                {
                    double confidence = 0.0;
                    faceExaminer.Examine(strTemp, chkAcurateFaceDetection.Checked?1:0, out label, out confidence);
                    bool bFound = false;                

                    foreach (DataRow row in personTable.Rows)
                    {
                        if (row.Field<int>(0) == label)
                        {
                            lblRecognizedPerson.Text = (string)row.ItemArray[1];
                            bFound = true;
                        }
                    }
                    if (!bFound)
                    {
                        lblRecognizedPerson.Text = "ناشناس";
                    }
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);              
            }
            

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (faceExaminer != null && txtSourceFile.Text != "" && System.IO.File.Exists(txtSourceFile.Text))
            {
                int label = -1;
                double confidence = 0.0;
                faceExaminer.Examine(txtSourceFile.Text, chkAcurateFaceDetection.Checked ? 1 : 0, out label, out confidence);
                bool bFound = false ;                
                foreach (DataRow row in personTable.Rows)
                {
                    if (row.Field<int>(0) == label)
                    {
                        lblRecognizedPerson.Text = (string)row.ItemArray[1];
                        bFound = true;
                    }
                }
                if (!bFound)
                {
                    lblRecognizedPerson.Text = "ناشناس";
                }
                
            }
        }

        private void GarbageTimer_Tick(object sender, EventArgs e)
        {
            string path;            
            for (int i = 0; i < garbageFrames.Count ; i++)
            {
                try
                {
                    path = garbageFrames[i];
                    System.IO.File.Delete(path.Replace(".bmp", ".tmp"));
                    System.IO.File.Delete(path);
                    garbageFrames.Remove(path);
                }
                catch (Exception ex)
                {

                } 
            }
                //string prevPath = picTestSource.ImageLocation;
                //if (picTestSource.Image != null)
                //{
                //    picTestSource.Image.Dispose();
                //    picTestSource.Image = null;
                //    GC.Collect();
                //}
                //picTestSource.ImageLocation = null;
               
            
        }

        private void chkPicFromCam_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPicFromCam.Checked)
            {
                capturer.Capture(0);
                System.Threading.Thread.Sleep(3000);
                CaptureSingleShotTimer.Enabled = true;
                CaptureSingleShotTimer.Start();
            }
            else
            {
                capturer.ReleaseCapture();
            }
        }

        private void CaptureSingleShotTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                string strTemp = System.IO.Path.GetTempFileName().Replace(".tmp", ".bmp");
                //sbyte[] arrPath = strTemp.ToArray<char>().ToArray<sbyte>();
                int x = -1, y = -1, w = -1, h = -1;
                garbageFrames.Add(strTemp);

                capturer.NextFrame(strTemp, chkAcurateFaceDetection.Checked ? 1 : 0, out x, out y, out w, out h);

                picFace.Image = Bitmap.FromFile(strTemp, true);
                if (h > 30 && w > 30)
                {
                    Bitmap bmp = new Bitmap(picFace.Image);
                    Graphics gr = Graphics.FromImage(bmp);
                    gr.DrawRectangle(new Pen(Brushes.Blue, 5), x, y, w, h);
                    picFace.Image = bmp;
                }
                
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);              
            }
            
        }

    }
}