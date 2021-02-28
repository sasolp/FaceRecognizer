// dllmain.cpp : Implementation of DllMain.

#include "stdafx.h"
#include "resource.h"
#include "Face2_i.h"
#include "dllmain.h"
#include "compreg.h"
#include "xdlldata.h"

CFace2Module _AtlModule;

class CFace2App : public CWinApp
{
public:

// Overrides
	virtual BOOL InitInstance();
	virtual int ExitInstance();

	DECLARE_MESSAGE_MAP()
};

BEGIN_MESSAGE_MAP(CFace2App, CWinApp)
END_MESSAGE_MAP()

CFace2App theApp;

BOOL CFace2App::InitInstance()
{
#ifdef _MERGE_PROXYSTUB
	if (!PrxDllMain(m_hInstance, DLL_PROCESS_ATTACH, NULL))
		return FALSE;
#endif
	return CWinApp::InitInstance();
}

int CFace2App::ExitInstance()
{
	return CWinApp::ExitInstance();
}
