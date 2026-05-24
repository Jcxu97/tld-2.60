using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000A0F")]
public class FrameDumper : MonoBehaviour
{
	[Token(Token = "0x40065F8")]
	[FieldOffset(Offset = "0x20")]
	public Material m_CopyImageMaterial;

	[Token(Token = "0x40065F9")]
	[FieldOffset(Offset = "0x28")]
	public Material m_CopyDepthMaterial;

	[Token(Token = "0x40065FA")]
	[FieldOffset(Offset = "0x30")]
	public Material m_CopyNormalsMaterial;

	[Token(Token = "0x40065FB")]
	public static int m_CaptureMode;

	[Token(Token = "0x40065FC")]
	public static FrameDumper m_Instance;

	[Token(Token = "0x40065FD")]
	public static string m_AnimToCaptureNext;

	[Token(Token = "0x40065FE")]
	private static string m_ShotDirectory;

	[Token(Token = "0x40065FF")]
	private static bool m_Dumping;

	[Token(Token = "0x4006600")]
	private static int m_CurrentImageIndex;

	[Token(Token = "0x4006601")]
	private static int m_CaptureFramerate;

	[Token(Token = "0x4006602")]
	private static float m_CaptureFarClip;

	[Token(Token = "0x4006603")]
	private static FrameDumpHelper m_CaptureHelper;

	[Token(Token = "0x4006604")]
	private static ThreadedImageWriter m_ImageWriter;

	[Token(Token = "0x4006605")]
	private static Camera m_WeaponCamera;

	[Token(Token = "0x4006606")]
	private static CameraClearFlags m_WeaponCameraClearFlags;

	[Token(Token = "0x6005850")]
	[Address(RVA = "0xEE47C0", Offset = "0xEE35C0", Length = "0x22F")]
	public void Start()
	{
	}

	[Token(Token = "0x6005851")]
	[Address(RVA = "0xEE49F0", Offset = "0xEE37F0", Length = "0x244")]
	public static void StartDumpingToDirectory(string directoryName)
	{
	}

	[Token(Token = "0x6005852")]
	[Address(RVA = "0xEE4C40", Offset = "0xEE3A40", Length = "0x3CF")]
	public static void Toggle()
	{
	}

	[Token(Token = "0x6005853")]
	[Address(RVA = "0xEE5010", Offset = "0xEE3E10", Length = "0x38F")]
	private void Update()
	{
	}

	[Token(Token = "0x6005854")]
	[Address(RVA = "0xEE53A0", Offset = "0xEE41A0", Length = "0x70")]
	public static void SetCaptureFramerate(int fps)
	{
	}

	[Token(Token = "0x6005855")]
	[Address(RVA = "0xEE5410", Offset = "0xEE4210", Length = "0x7C")]
	public static void SetCaptureFarClip(float farClip)
	{
	}

	[Token(Token = "0x6005856")]
	[Address(RVA = "0xEE5490", Offset = "0xEE4290", Length = "0x7C")]
	public static void SetCaptureMode(int mode)
	{
	}

	[Token(Token = "0x6005857")]
	[Address(RVA = "0xEE5510", Offset = "0xEE4310", Length = "0x2C9")]
	private void CreateHelpers()
	{
	}

	[Token(Token = "0x6005858")]
	[Address(RVA = "0xEE57E0", Offset = "0xEE45E0", Length = "0x37F")]
	private void DestroyHelpers()
	{
	}

	[Token(Token = "0x6005859")]
	[Address(RVA = "0xEE5B60", Offset = "0xEE4960", Length = "0xA70")]
	public void DumpFrame(RenderTexture image, RenderTexture depth, RenderTexture norm)
	{
	}

	[Token(Token = "0x600585A")]
	[Address(RVA = "0xEE65E0", Offset = "0xEE53E0", Length = "0x96")]
	private void DumpFrameSimple()
	{
	}

	[Token(Token = "0x600585B")]
	[Address(RVA = "0xEE6680", Offset = "0xEE5480", Length = "0x90")]
	private static string GetImageFilename()
	{
		return null;
	}

	[Token(Token = "0x600585C")]
	[Address(RVA = "0xEE6710", Offset = "0xEE5510", Length = "0x15B")]
	private static string GetShotDirectory()
	{
		return null;
	}

	[Token(Token = "0x600585D")]
	[Address(RVA = "0xEE6870", Offset = "0xEE5670", Length = "0x4F9")]
	private static void MaybeStartDumpingAnimation()
	{
	}

	[Token(Token = "0x600585E")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public FrameDumper()
	{
	}
}
