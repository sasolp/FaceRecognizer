// Capturer2.cpp : Implementation of CCapturer2

#include "stdafx.h"
#include <opencv2\world.hpp>

#include <opencv2\videoio.hpp>

using namespace std;
using namespace cv;

#include "Capturer2.h"


// CCapturer2



STDMETHODIMP CCapturer2::Capture(int id)
{
	AFX_MANAGE_STATE(AfxGetStaticModuleState());

	// TODO: Add your implementation code here
	//this->cap = new VideoCapture(id);
	VideoCapture v(id);
	return S_OK;
}
