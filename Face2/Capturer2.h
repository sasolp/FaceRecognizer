// Capturer2.h : Declaration of the CCapturer2

#pragma once
#include "resource.h"       // main symbols



#include "Face2_i.h"



#if defined(_WIN32_WCE) && !defined(_CE_DCOM) && !defined(_CE_ALLOW_SINGLE_THREADED_OBJECTS_IN_MTA)
#error "Single-threaded COM objects are not properly supported on Windows CE platform, such as the Windows Mobile platforms that do not include full DCOM support. Define _CE_ALLOW_SINGLE_THREADED_OBJECTS_IN_MTA to force ATL to support creating single-thread COM object's and allow use of it's single-threaded COM object implementations. The threading model in your rgs file was set to 'Free' as that is the only threading model supported in non DCOM Windows CE platforms."
#endif

using namespace ATL;


// CCapturer2

class ATL_NO_VTABLE CCapturer2 :
	public CComObjectRootEx<CComSingleThreadModel>,
	public CComCoClass<CCapturer2, &CLSID_Capturer2>,
	public ICapturer2
{
public:
	CCapturer2()
	{
	}

DECLARE_REGISTRY_RESOURCEID(IDR_CAPTURER2)

DECLARE_NOT_AGGREGATABLE(CCapturer2)

BEGIN_COM_MAP(CCapturer2)
	COM_INTERFACE_ENTRY(ICapturer2)
END_COM_MAP()



	DECLARE_PROTECT_FINAL_CONSTRUCT()

	HRESULT FinalConstruct()
	{
		return S_OK;
	}

	void FinalRelease()
	{
	}

public:
		cv::VideoCapture* cap;



	STDMETHOD(Capture)(int id);
};

OBJECT_ENTRY_AUTO(__uuidof(Capturer2), CCapturer2)
