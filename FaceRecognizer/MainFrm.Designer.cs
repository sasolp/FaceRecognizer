namespace FaceRecognizer
{
    partial class MainFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.picFace = new System.Windows.Forms.PictureBox();
            this.rdFemale = new System.Windows.Forms.RadioButton();
            this.rdMale = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.gridPersons = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.rdCamera = new System.Windows.Forms.RadioButton();
            this.rdVideo = new System.Windows.Forms.RadioButton();
            this.rdFile = new System.Windows.Forms.RadioButton();
            this.grpFile = new System.Windows.Forms.GroupBox();
            this.button8 = new System.Windows.Forms.Button();
            this.txtSourceFile = new System.Windows.Forms.TextBox();
            this.button9 = new System.Windows.Forms.Button();
            this.grpVideo = new System.Windows.Forms.GroupBox();
            this.txtSourceVideo = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.grpCamera = new System.Windows.Forms.GroupBox();
            this.txtSourceCam = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.CameraTimer = new System.Windows.Forms.Timer(this.components);
            this.picTestSource = new System.Windows.Forms.PictureBox();
            this.button10 = new System.Windows.Forms.Button();
            this.lblRecognizedPerson = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.GarbageTimer = new System.Windows.Forms.Timer(this.components);
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.chkAcurateFaceDetection = new System.Windows.Forms.CheckBox();
            this.chkPicFromCam = new System.Windows.Forms.CheckBox();
            this.CaptureSingleShotTimer = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPersons)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.grpFile.SuspendLayout();
            this.grpVideo.SuspendLayout();
            this.grpCamera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTestSource)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabControl1.RightToLeftLayout = true;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(756, 562);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.gridPersons);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(748, 536);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "گالری";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkPicFromCam);
            this.groupBox1.Controls.Add(this.picFace);
            this.groupBox1.Controls.Add(this.rdFemale);
            this.groupBox1.Controls.Add(this.rdMale);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtAge);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(20, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(676, 163);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "فرد جدید";
            // 
            // picFace
            // 
            this.picFace.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picFace.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picFace.Location = new System.Drawing.Point(26, 22);
            this.picFace.Name = "picFace";
            this.picFace.Size = new System.Drawing.Size(147, 138);
            this.picFace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFace.TabIndex = 4;
            this.picFace.TabStop = false;
            this.picFace.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // rdFemale
            // 
            this.rdFemale.AutoSize = true;
            this.rdFemale.Location = new System.Drawing.Point(355, 95);
            this.rdFemale.Name = "rdFemale";
            this.rdFemale.Size = new System.Drawing.Size(37, 17);
            this.rdFemale.TabIndex = 3;
            this.rdFemale.Text = "زن";
            this.rdFemale.UseVisualStyleBackColor = true;
            // 
            // rdMale
            // 
            this.rdMale.AutoSize = true;
            this.rdMale.Checked = true;
            this.rdMale.Location = new System.Drawing.Point(352, 118);
            this.rdMale.Name = "rdMale";
            this.rdMale.Size = new System.Drawing.Size(40, 17);
            this.rdMale.TabIndex = 3;
            this.rdMale.TabStop = true;
            this.rdMale.Text = "مرد";
            this.rdMale.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(398, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "جنسیت:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(398, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "سن:";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(292, 64);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(100, 20);
            this.txtAge.TabIndex = 1;
            this.txtAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(398, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "نام:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(292, 35);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(484, 95);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(163, 32);
            this.button3.TabIndex = 0;
            this.button3.Text = "بروزرسانی گردد ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(484, 57);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(163, 32);
            this.button2.TabIndex = 0;
            this.button2.Text = "حذف گردد ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(484, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "اضافه گردد ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gridPersons
            // 
            this.gridPersons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPersons.Location = new System.Drawing.Point(3, 183);
            this.gridPersons.Name = "gridPersons";
            this.gridPersons.Size = new System.Drawing.Size(739, 349);
            this.gridPersons.TabIndex = 1;
            this.gridPersons.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.gridPersons.CurrentCellChanged += new System.EventHandler(this.gridPersons_CurrentCellChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.lblRecognizedPerson);
            this.tabPage2.Controls.Add(this.button8);
            this.tabPage2.Controls.Add(this.button10);
            this.tabPage2.Controls.Add(this.picTestSource);
            this.tabPage2.Controls.Add(this.rdCamera);
            this.tabPage2.Controls.Add(this.rdVideo);
            this.tabPage2.Controls.Add(this.rdFile);
            this.tabPage2.Controls.Add(this.grpFile);
            this.tabPage2.Controls.Add(this.grpVideo);
            this.tabPage2.Controls.Add(this.grpCamera);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(748, 536);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "شناسایی";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // rdCamera
            // 
            this.rdCamera.AutoSize = true;
            this.rdCamera.Location = new System.Drawing.Point(649, 6);
            this.rdCamera.Name = "rdCamera";
            this.rdCamera.Size = new System.Drawing.Size(56, 17);
            this.rdCamera.TabIndex = 2;
            this.rdCamera.TabStop = true;
            this.rdCamera.Text = "دوربین";
            this.rdCamera.UseVisualStyleBackColor = true;
            this.rdCamera.CheckedChanged += new System.EventHandler(this.rdCamera_CheckedChanged);
            // 
            // rdVideo
            // 
            this.rdVideo.AutoSize = true;
            this.rdVideo.Location = new System.Drawing.Point(655, 77);
            this.rdVideo.Name = "rdVideo";
            this.rdVideo.Size = new System.Drawing.Size(50, 17);
            this.rdVideo.TabIndex = 3;
            this.rdVideo.TabStop = true;
            this.rdVideo.Text = "ویدئو";
            this.rdVideo.UseVisualStyleBackColor = true;
            this.rdVideo.CheckedChanged += new System.EventHandler(this.rdCamera_CheckedChanged);
            // 
            // rdFile
            // 
            this.rdFile.AutoSize = true;
            this.rdFile.Location = new System.Drawing.Point(659, 144);
            this.rdFile.Name = "rdFile";
            this.rdFile.Size = new System.Drawing.Size(46, 17);
            this.rdFile.TabIndex = 4;
            this.rdFile.TabStop = true;
            this.rdFile.Text = "فایل";
            this.rdFile.UseVisualStyleBackColor = true;
            this.rdFile.CheckedChanged += new System.EventHandler(this.rdCamera_CheckedChanged);
            // 
            // grpFile
            // 
            this.grpFile.Controls.Add(this.txtSourceFile);
            this.grpFile.Controls.Add(this.button9);
            this.grpFile.Location = new System.Drawing.Point(46, 147);
            this.grpFile.Name = "grpFile";
            this.grpFile.Size = new System.Drawing.Size(662, 66);
            this.grpFile.TabIndex = 2;
            this.grpFile.TabStop = false;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(590, 380);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(118, 23);
            this.button8.TabIndex = 0;
            this.button8.Text = "شناسایی";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // txtSourceFile
            // 
            this.txtSourceFile.Location = new System.Drawing.Point(155, 28);
            this.txtSourceFile.Name = "txtSourceFile";
            this.txtSourceFile.Size = new System.Drawing.Size(377, 20);
            this.txtSourceFile.TabIndex = 1;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(538, 25);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(111, 23);
            this.button9.TabIndex = 0;
            this.button9.Text = "انتخاب تصویر ورودی";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button4_Click);
            // 
            // grpVideo
            // 
            this.grpVideo.Controls.Add(this.txtSourceVideo);
            this.grpVideo.Controls.Add(this.button7);
            this.grpVideo.Enabled = false;
            this.grpVideo.Location = new System.Drawing.Point(46, 79);
            this.grpVideo.Name = "grpVideo";
            this.grpVideo.Size = new System.Drawing.Size(662, 66);
            this.grpVideo.TabIndex = 2;
            this.grpVideo.TabStop = false;
            // 
            // txtSourceVideo
            // 
            this.txtSourceVideo.Location = new System.Drawing.Point(155, 28);
            this.txtSourceVideo.Name = "txtSourceVideo";
            this.txtSourceVideo.Size = new System.Drawing.Size(377, 20);
            this.txtSourceVideo.TabIndex = 1;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(538, 25);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(111, 23);
            this.button7.TabIndex = 0;
            this.button7.Text = "انتخاب ویدئو ورودی";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // grpCamera
            // 
            this.grpCamera.Controls.Add(this.txtSourceCam);
            this.grpCamera.Controls.Add(this.button4);
            this.grpCamera.Enabled = false;
            this.grpCamera.Location = new System.Drawing.Point(46, 10);
            this.grpCamera.Name = "grpCamera";
            this.grpCamera.Size = new System.Drawing.Size(662, 66);
            this.grpCamera.TabIndex = 2;
            this.grpCamera.TabStop = false;
            // 
            // txtSourceCam
            // 
            this.txtSourceCam.Location = new System.Drawing.Point(155, 28);
            this.txtSourceCam.Name = "txtSourceCam";
            this.txtSourceCam.Size = new System.Drawing.Size(377, 20);
            this.txtSourceCam.TabIndex = 1;
            this.txtSourceCam.Text = "0";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(538, 25);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(111, 23);
            this.button4.TabIndex = 0;
            this.button4.Text = "انتخاب دوربین ورودی";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // CameraTimer
            // 
            this.CameraTimer.Interval = 10;
            this.CameraTimer.Tick += new System.EventHandler(this.CameraTimer_Tick);
            // 
            // picTestSource
            // 
            this.picTestSource.Location = new System.Drawing.Point(176, 219);
            this.picTestSource.Name = "picTestSource";
            this.picTestSource.Size = new System.Drawing.Size(385, 306);
            this.picTestSource.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTestSource.TabIndex = 5;
            this.picTestSource.TabStop = false;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(590, 329);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(118, 23);
            this.button10.TabIndex = 0;
            this.button10.Text = "بارگیری ";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button5_Click);
            // 
            // lblRecognizedPerson
            // 
            this.lblRecognizedPerson.AutoSize = true;
            this.lblRecognizedPerson.Location = new System.Drawing.Point(46, 241);
            this.lblRecognizedPerson.Name = "lblRecognizedPerson";
            this.lblRecognizedPerson.Size = new System.Drawing.Size(0, 13);
            this.lblRecognizedPerson.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "فرد شناسایی شده:";
            // 
            // GarbageTimer
            // 
            this.GarbageTimer.Interval = 10000;
            this.GarbageTimer.Tick += new System.EventHandler(this.GarbageTimer_Tick);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.chkAcurateFaceDetection);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(748, 536);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "تنظیمات";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // chkAcurateFaceDetection
            // 
            this.chkAcurateFaceDetection.AutoSize = true;
            this.chkAcurateFaceDetection.Location = new System.Drawing.Point(621, 33);
            this.chkAcurateFaceDetection.Name = "chkAcurateFaceDetection";
            this.chkAcurateFaceDetection.Size = new System.Drawing.Size(101, 17);
            this.chkAcurateFaceDetection.TabIndex = 0;
            this.chkAcurateFaceDetection.Text = "چهره یابی دقیق";
            this.chkAcurateFaceDetection.UseVisualStyleBackColor = true;
            // 
            // chkPicFromCam
            // 
            this.chkPicFromCam.AutoSize = true;
            this.chkPicFromCam.Location = new System.Drawing.Point(26, 5);
            this.chkPicFromCam.Name = "chkPicFromCam";
            this.chkPicFromCam.Size = new System.Drawing.Size(149, 17);
            this.chkPicFromCam.TabIndex = 5;
            this.chkPicFromCam.Text = "گرفتن عکس بوسیله دوربین";
            this.chkPicFromCam.UseVisualStyleBackColor = true;
            this.chkPicFromCam.CheckedChanged += new System.EventHandler(this.chkPicFromCam_CheckedChanged);
            // 
            // CaptureSingleShotTimer
            // 
            this.CaptureSingleShotTimer.Tick += new System.EventHandler(this.CaptureSingleShotTimer_Tick);
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 562);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.Name = "MainFrm";
            this.Text = "تشخیص چهره";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPersons)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.grpFile.ResumeLayout(false);
            this.grpFile.PerformLayout();
            this.grpVideo.ResumeLayout(false);
            this.grpVideo.PerformLayout();
            this.grpCamera.ResumeLayout(false);
            this.grpCamera.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTestSource)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView gridPersons;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.RadioButton rdFemale;
        private System.Windows.Forms.RadioButton rdMale;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox picFace;
        private System.Windows.Forms.TextBox txtSourceCam;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox grpFile;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox txtSourceFile;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.GroupBox grpVideo;
        private System.Windows.Forms.TextBox txtSourceVideo;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.GroupBox grpCamera;
        private System.Windows.Forms.RadioButton rdCamera;
        private System.Windows.Forms.RadioButton rdVideo;
        private System.Windows.Forms.RadioButton rdFile;
        private System.Windows.Forms.Timer CameraTimer;
        private System.Windows.Forms.PictureBox picTestSource;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblRecognizedPerson;
        private System.Windows.Forms.Timer GarbageTimer;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.CheckBox chkAcurateFaceDetection;
        private System.Windows.Forms.CheckBox chkPicFromCam;
        private System.Windows.Forms.Timer CaptureSingleShotTimer;
    }
}

