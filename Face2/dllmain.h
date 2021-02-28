// dllmain.h : Declaration of module class.

class CFace2Module : public ATL::CAtlDllModuleT< CFace2Module >
{
public :
	DECLARE_LIBID(LIBID_Face2Lib)
	DECLARE_REGISTRY_APPID_RESOURCEID(IDR_FACE2, "{833C52B8-452E-49B2-9FA3-BF858371A34B}")
};

extern class CFace2Module _AtlModule;
