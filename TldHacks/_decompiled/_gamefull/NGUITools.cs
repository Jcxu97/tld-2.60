using System;
using System.Diagnostics;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20000BA")]
public static class NGUITools
{
	[Token(Token = "0x4000622")]
	private static AudioListener mListener;

	[Token(Token = "0x4000623")]
	private static bool mLoaded;

	[Token(Token = "0x4000624")]
	private static float mGlobalVolume;

	[Token(Token = "0x4000625")]
	private static float mLastTimestamp;

	[Token(Token = "0x4000626")]
	private static AudioClip mLastClip;

	[Token(Token = "0x4000627")]
	private static Vector3[] mSides;

	[Token(Token = "0x17000087")]
	public static float soundVolume
	{
		[Token(Token = "0x6000675")]
		[Address(RVA = "0xF88930", Offset = "0xF87730", Length = "0xE7")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6000676")]
		[Address(RVA = "0xF88A20", Offset = "0xF87820", Length = "0xBC")]
		set
		{
		}
	}

	[Token(Token = "0x17000088")]
	public static bool fileAccess
	{
		[Token(Token = "0x6000677")]
		[Address(RVA = "0x430B50", Offset = "0x42F950", Length = "0x3")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x17000089")]
	public static string clipboard
	{
		[Token(Token = "0x60006BA")]
		[Address(RVA = "0xF91100", Offset = "0xF8FF00", Length = "0x6D")]
		get
		{
			return null;
		}
		[Token(Token = "0x60006BB")]
		[Address(RVA = "0xF91170", Offset = "0xF8FF70", Length = "0xA5")]
		set
		{
		}
	}

	[Token(Token = "0x1700008A")]
	public static Vector2 screenSize
	{
		[Token(Token = "0x60006CC")]
		[Address(RVA = "0xF93700", Offset = "0xF92500", Length = "0xB1")]
		get
		{
			return default(Vector2);
		}
	}

	[Token(Token = "0x6000678")]
	[Address(RVA = "0xF88AE0", Offset = "0xF878E0", Length = "0x5A")]
	public static AudioSource PlaySound(AudioClip clip)
	{
		return null;
	}

	[Token(Token = "0x6000679")]
	[Address(RVA = "0xF88B40", Offset = "0xF87940", Length = "0x67")]
	public static AudioSource PlaySound(AudioClip clip, float volume)
	{
		return null;
	}

	[Token(Token = "0x600067A")]
	[Address(RVA = "0xF88BB0", Offset = "0xF879B0", Length = "0xAB7")]
	public static AudioSource PlaySound(AudioClip clip, float volume, float pitch)
	{
		return null;
	}

	[Token(Token = "0x600067B")]
	[Address(RVA = "0xF89670", Offset = "0xF88470", Length = "0x67")]
	public static int RandomRange(int min, int max)
	{
		return 0;
	}

	[Token(Token = "0x600067C")]
	[Address(RVA = "0xF896E0", Offset = "0xF884E0", Length = "0x51C")]
	public static string GetHierarchy(GameObject obj)
	{
		return null;
	}

	[Token(Token = "0x600067D")]
	[Address(RVA = "0x1958370", Offset = "0x1957170", Length = "0x58")]
	public static T[] FindActive<T>() where T : Component
	{
		return null;
	}

	[Token(Token = "0x600067E")]
	[Address(RVA = "0xF89C00", Offset = "0xF88A00", Length = "0x3BE")]
	public static Camera FindCameraForLayer(int layer)
	{
		return null;
	}

	[Token(Token = "0x600067F")]
	[Address(RVA = "0xF89FC0", Offset = "0xF88DC0", Length = "0x51")]
	public static void AddWidgetCollider(GameObject go)
	{
	}

	[Token(Token = "0x6000680")]
	[Address(RVA = "0xF8A020", Offset = "0xF88E20", Length = "0x68A")]
	public static void AddWidgetCollider(GameObject go, bool considerInactive)
	{
	}

	[Token(Token = "0x6000681")]
	[Address(RVA = "0xF8A6B0", Offset = "0xF894B0", Length = "0x51")]
	public static void UpdateWidgetCollider(GameObject go)
	{
	}

	[Token(Token = "0x6000682")]
	[Address(RVA = "0xF8A710", Offset = "0xF89510", Length = "0x2A3")]
	public static void UpdateWidgetCollider(GameObject go, bool considerInactive)
	{
	}

	[Token(Token = "0x6000683")]
	[Address(RVA = "0xF8A9C0", Offset = "0xF897C0", Length = "0x785")]
	public static void UpdateWidgetCollider(BoxCollider box, bool considerInactive)
	{
	}

	[Token(Token = "0x6000684")]
	[Address(RVA = "0xF8B150", Offset = "0xF89F50", Length = "0x327")]
	public static void UpdateWidgetCollider(BoxCollider2D box, bool considerInactive)
	{
	}

	[Token(Token = "0x6000685")]
	[Address(RVA = "0x1958900", Offset = "0x1957700", Length = "0x116")]
	public static string GetTypeName<T>()
	{
		return null;
	}

	[Token(Token = "0x6000686")]
	[Address(RVA = "0xF8B480", Offset = "0xF8A280", Length = "0x1A6")]
	public static string GetTypeName(UnityEngine.Object obj)
	{
		return null;
	}

	[Token(Token = "0x6000687")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public static void RegisterUndo(UnityEngine.Object obj, string name)
	{
	}

	[Token(Token = "0x6000688")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public static void SetDirty(UnityEngine.Object obj)
	{
	}

	[Token(Token = "0x6000689")]
	[Address(RVA = "0xF8B630", Offset = "0xF8A430", Length = "0x51")]
	public static GameObject AddChild(GameObject parent)
	{
		return null;
	}

	[Token(Token = "0x600068A")]
	[Address(RVA = "0xF8B690", Offset = "0xF8A490", Length = "0x3BF")]
	public static GameObject AddChild(GameObject parent, bool undo)
	{
		return null;
	}

	[Token(Token = "0x600068B")]
	[Address(RVA = "0xF8BA50", Offset = "0xF8A850", Length = "0x40E")]
	public static GameObject AddChild(GameObject parent, GameObject prefab)
	{
		return null;
	}

	[Token(Token = "0x600068C")]
	[Address(RVA = "0xF8BE60", Offset = "0xF8AC60", Length = "0x272")]
	public static int CalculateRaycastDepth(GameObject go)
	{
		return 0;
	}

	[Token(Token = "0x600068D")]
	[Address(RVA = "0xF8C0E0", Offset = "0xF8AEE0", Length = "0xBD")]
	public static int CalculateNextDepth(GameObject go)
	{
		return 0;
	}

	[Token(Token = "0x600068E")]
	[Address(RVA = "0xF8C1A0", Offset = "0xF8AFA0", Length = "0x364")]
	public static int CalculateNextDepth(GameObject go, bool ignoreChildrenWithColliders)
	{
		return 0;
	}

	[Token(Token = "0x600068F")]
	[Address(RVA = "0xF8C510", Offset = "0xF8B310", Length = "0x43D")]
	public static int AdjustDepth(GameObject go, int adjustment)
	{
		return 0;
	}

	[Token(Token = "0x6000690")]
	[Address(RVA = "0xF8C950", Offset = "0xF8B750", Length = "0xA1")]
	public static void BringForward(GameObject go)
	{
	}

	[Token(Token = "0x6000691")]
	[Address(RVA = "0xF8CA00", Offset = "0xF8B800", Length = "0xA1")]
	public static void PushBack(GameObject go)
	{
	}

	[Token(Token = "0x6000692")]
	[Address(RVA = "0xF8CAB0", Offset = "0xF8B8B0", Length = "0x4C")]
	public static void NormalizeDepths()
	{
	}

	[Token(Token = "0x6000693")]
	[Address(RVA = "0xF8CB00", Offset = "0xF8B900", Length = "0x65")]
	public static void NormalizeWidgetDepths()
	{
	}

	[Token(Token = "0x6000694")]
	[Address(RVA = "0xF8CB70", Offset = "0xF8B970", Length = "0x9D")]
	public static void NormalizeWidgetDepths(GameObject go)
	{
	}

	[Token(Token = "0x6000695")]
	[Address(RVA = "0xF8CC10", Offset = "0xF8BA10", Length = "0x1EB")]
	public static void NormalizeWidgetDepths(UIWidget[] list)
	{
	}

	[Token(Token = "0x6000696")]
	[Address(RVA = "0xF8CE00", Offset = "0xF8BC00", Length = "0x22C")]
	public static void NormalizePanelDepths()
	{
	}

	[Token(Token = "0x6000697")]
	[Address(RVA = "0xF8D030", Offset = "0xF8BE30", Length = "0x55")]
	public static UIPanel CreateUI(bool advanced3D)
	{
		return null;
	}

	[Token(Token = "0x6000698")]
	[Address(RVA = "0xF8D090", Offset = "0xF8BE90", Length = "0x60")]
	public static UIPanel CreateUI(bool advanced3D, int layer)
	{
		return null;
	}

	[Token(Token = "0x6000699")]
	[Address(RVA = "0xF8D0F0", Offset = "0xF8BEF0", Length = "0x148B")]
	public static UIPanel CreateUI(Transform trans, bool advanced3D, int layer)
	{
		return null;
	}

	[Token(Token = "0x600069A")]
	[Address(RVA = "0xF8E580", Offset = "0xF8D380", Length = "0x2E8")]
	public static void SetChildLayer(Transform t, int layer)
	{
	}

	[Token(Token = "0x600069B")]
	[Address(RVA = "0x19579F0", Offset = "0x19567F0", Length = "0xD0")]
	public static T AddChild<T>(GameObject parent) where T : Component
	{
		return null;
	}

	[Token(Token = "0x600069C")]
	[Address(RVA = "0x1957AD0", Offset = "0x19568D0", Length = "0xA9")]
	public static T AddChild<T>(GameObject parent, bool undo) where T : Component
	{
		return null;
	}

	[Token(Token = "0x600069D")]
	[Address(RVA = "0x1957C90", Offset = "0x1956A90", Length = "0xB7")]
	public static T AddWidget<T>(GameObject go) where T : UIWidget
	{
		return null;
	}

	[Token(Token = "0x600069E")]
	[Address(RVA = "0x1957D50", Offset = "0x1956B50", Length = "0xAD")]
	public static T AddWidget<T>(GameObject go, int depth) where T : UIWidget
	{
		return null;
	}

	[Token(Token = "0x600069F")]
	[Address(RVA = "0xF8E870", Offset = "0xF8D670", Length = "0x1A0")]
	public static UISprite AddSprite(GameObject go, UIAtlas atlas, string spriteName)
	{
		return null;
	}

	[Token(Token = "0x60006A0")]
	[Address(RVA = "0xF8EA20", Offset = "0xF8D820", Length = "0x1A7")]
	public static GameObject GetRoot(GameObject go)
	{
		return null;
	}

	[Token(Token = "0x60006A1")]
	[Address(RVA = "0x19583D0", Offset = "0x19571D0", Length = "0x43C")]
	public static T FindInParents<T>(GameObject go) where T : Component
	{
		return null;
	}

	[Token(Token = "0x60006A2")]
	[Address(RVA = "0x1958810", Offset = "0x1957610", Length = "0xEB")]
	public static T FindInParents<T>(Transform trans) where T : Component
	{
		return null;
	}

	[Token(Token = "0x60006A3")]
	[Address(RVA = "0xF8EBD0", Offset = "0xF8D9D0", Length = "0x28C")]
	public static void Destroy(UnityEngine.Object obj)
	{
	}

	[Token(Token = "0x60006A4")]
	[Address(RVA = "0xF8EE60", Offset = "0xF8DC60", Length = "0x145")]
	public static void DestroyImmediate(UnityEngine.Object obj)
	{
	}

	[Token(Token = "0x60006A5")]
	[Address(RVA = "0xF8EFB0", Offset = "0xF8DDB0", Length = "0xDB")]
	public static void Broadcast(string funcName)
	{
	}

	[Token(Token = "0x60006A6")]
	[Address(RVA = "0xF8F090", Offset = "0xF8DE90", Length = "0xDA")]
	public static void Broadcast(string funcName, object param)
	{
	}

	[Token(Token = "0x60006A7")]
	[Address(RVA = "0xF8F170", Offset = "0xF8DF70", Length = "0x292")]
	public static bool IsChild(Transform parent, Transform child)
	{
		return false;
	}

	[Token(Token = "0x60006A8")]
	[Address(RVA = "0xF8F410", Offset = "0xF8E210", Length = "0xAA")]
	private static void Activate(Transform t)
	{
	}

	[Token(Token = "0x60006A9")]
	[Address(RVA = "0xF8F4C0", Offset = "0xF8E2C0", Length = "0x1DB")]
	private static void Activate(Transform t, bool compatibilityMode)
	{
	}

	[Token(Token = "0x60006AA")]
	[Address(RVA = "0xF8F6A0", Offset = "0xF8E4A0", Length = "0x9F")]
	private static void Deactivate(Transform t)
	{
	}

	[Token(Token = "0x60006AB")]
	[Address(RVA = "0xF8F740", Offset = "0xF8E540", Length = "0x61")]
	public static void SetActive(GameObject go, bool state)
	{
	}

	[Token(Token = "0x60006AC")]
	[Address(RVA = "0xF8F7B0", Offset = "0xF8E5B0", Length = "0x160")]
	public static void SetActive(GameObject go, bool state, bool compatibilityMode)
	{
	}

	[DebuggerHidden]
	[DebuggerStepThrough]
	[Token(Token = "0x60006AD")]
	[Address(RVA = "0xF8F910", Offset = "0xF8E710", Length = "0x26A")]
	private static void CallCreatePanel(Transform t)
	{
	}

	[Token(Token = "0x60006AE")]
	[Address(RVA = "0xF8FB80", Offset = "0xF8E980", Length = "0x565")]
	public static void SetActiveChildren(GameObject go, bool state)
	{
	}

	[Obsolete("Use NGUITools.GetActive instead")]
	[Token(Token = "0x60006AF")]
	[Address(RVA = "0xF900F0", Offset = "0xF8EEF0", Length = "0xF0")]
	public static bool IsActive(Behaviour mb)
	{
		return false;
	}

	[DebuggerHidden]
	[DebuggerStepThrough]
	[Token(Token = "0x60006B0")]
	[Address(RVA = "0xF901F0", Offset = "0xF8EFF0", Length = "0xF0")]
	public static bool GetActive(Behaviour mb)
	{
		return false;
	}

	[DebuggerHidden]
	[DebuggerStepThrough]
	[Token(Token = "0x60006B1")]
	[Address(RVA = "0xF902F0", Offset = "0xF8F0F0", Length = "0xCE")]
	public static bool GetActive(GameObject go)
	{
		return false;
	}

	[DebuggerHidden]
	[DebuggerStepThrough]
	[Token(Token = "0x60006B2")]
	[Address(RVA = "0xF903C0", Offset = "0xF8F1C0", Length = "0x1A")]
	public static void SetActiveSelf(GameObject go, bool state)
	{
	}

	[Token(Token = "0x60006B3")]
	[Address(RVA = "0xF903E0", Offset = "0xF8F1E0", Length = "0x288")]
	public static void SetLayer(GameObject go, int layer)
	{
	}

	[Token(Token = "0x60006B4")]
	[Address(RVA = "0xF90670", Offset = "0xF8F470", Length = "0x7C")]
	public static Vector3 Round(Vector3 v)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60006B5")]
	[Address(RVA = "0xF906F0", Offset = "0xF8F4F0", Length = "0x6C0")]
	public static void MakePixelPerfect(Transform t)
	{
	}

	[Token(Token = "0x60006B6")]
	[Address(RVA = "0xF90DC0", Offset = "0xF8FBC0", Length = "0x17C")]
	public static bool Save(string fileName, byte[] bytes)
	{
		return false;
	}

	[Token(Token = "0x60006B7")]
	[Address(RVA = "0xF90F40", Offset = "0xF8FD40", Length = "0xBA")]
	public static byte[] Load(string fileName)
	{
		return null;
	}

	[Token(Token = "0x60006B8")]
	[Address(RVA = "0xF91000", Offset = "0xF8FE00", Length = "0x40")]
	public static Color ApplyPMA(Color c)
	{
		return default(Color);
	}

	[Token(Token = "0x60006B9")]
	[Address(RVA = "0xF91040", Offset = "0xF8FE40", Length = "0xB4")]
	public static void MarkParentAsChanged(GameObject go)
	{
	}

	[Obsolete("Use NGUIText.EncodeColor instead")]
	[Token(Token = "0x60006BC")]
	[Address(RVA = "0xF91220", Offset = "0xF90020", Length = "0x59")]
	public static string EncodeColor(Color c)
	{
		return null;
	}

	[Obsolete("Use NGUIText.ParseColor instead")]
	[Token(Token = "0x60006BD")]
	[Address(RVA = "0xF91280", Offset = "0xF90080", Length = "0x7A")]
	public static Color ParseColor(string text, int offset)
	{
		return default(Color);
	}

	[Obsolete("Use NGUIText.StripSymbols instead")]
	[Token(Token = "0x60006BE")]
	[Address(RVA = "0xF91300", Offset = "0xF90100", Length = "0x4E")]
	public static string StripSymbols(string text)
	{
		return null;
	}

	[Token(Token = "0x60006BF")]
	[Address(RVA = "0x1957B80", Offset = "0x1956980", Length = "0x10F")]
	public static T AddMissingComponent<T>(this GameObject go) where T : Component
	{
		return null;
	}

	[Token(Token = "0x60006C0")]
	[Address(RVA = "0xF91350", Offset = "0xF90150", Length = "0x182")]
	public static Vector3[] GetSides(this Camera cam)
	{
		return null;
	}

	[Token(Token = "0x60006C1")]
	[Address(RVA = "0xF914E0", Offset = "0xF902E0", Length = "0x62")]
	public static Vector3[] GetSides(this Camera cam, float depth)
	{
		return null;
	}

	[Token(Token = "0x60006C2")]
	[Address(RVA = "0xF91550", Offset = "0xF90350", Length = "0x192")]
	public static Vector3[] GetSides(this Camera cam, Transform relativeTo)
	{
		return null;
	}

	[Token(Token = "0x60006C3")]
	[Address(RVA = "0xF916F0", Offset = "0xF904F0", Length = "0xDA6")]
	public static Vector3[] GetSides(this Camera cam, float depth, Transform relativeTo)
	{
		return null;
	}

	[Token(Token = "0x60006C4")]
	[Address(RVA = "0xF924A0", Offset = "0xF912A0", Length = "0x182")]
	public static Vector3[] GetWorldCorners(this Camera cam)
	{
		return null;
	}

	[Token(Token = "0x60006C5")]
	[Address(RVA = "0xF92630", Offset = "0xF91430", Length = "0x62")]
	public static Vector3[] GetWorldCorners(this Camera cam, float depth)
	{
		return null;
	}

	[Token(Token = "0x60006C6")]
	[Address(RVA = "0xF926A0", Offset = "0xF914A0", Length = "0x192")]
	public static Vector3[] GetWorldCorners(this Camera cam, Transform relativeTo)
	{
		return null;
	}

	[Token(Token = "0x60006C7")]
	[Address(RVA = "0xF92840", Offset = "0xF91640", Length = "0xCA6")]
	public static Vector3[] GetWorldCorners(this Camera cam, float depth, Transform relativeTo)
	{
		return null;
	}

	[Token(Token = "0x60006C8")]
	[Address(RVA = "0xF934F0", Offset = "0xF922F0", Length = "0xFF")]
	public static string GetFuncName(object obj, string method)
	{
		return null;
	}

	[Token(Token = "0x60006C9")]
	[Address(RVA = "0x1957E00", Offset = "0x1956C00", Length = "0x182")]
	public static void Execute<T>(GameObject go, string funcName) where T : Component
	{
	}

	[Token(Token = "0x60006CA")]
	[Address(RVA = "0x1957F90", Offset = "0x1956D90", Length = "0x3DA")]
	public static void ExecuteAll<T>(GameObject root, string funcName) where T : Component
	{
	}

	[Token(Token = "0x60006CB")]
	[Address(RVA = "0xF935F0", Offset = "0xF923F0", Length = "0x107")]
	public static void ImmediatelyCreateDrawCalls(GameObject root)
	{
	}
}
