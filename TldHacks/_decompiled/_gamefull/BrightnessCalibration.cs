using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20005C8")]
public class BrightnessCalibration : MonoBehaviour
{
	[SerializeField]
	[Token(Token = "0x4003566")]
	[FieldOffset(Offset = "0x20")]
	private GameObject[] m_EnableOnShow;

	[SerializeField]
	[Token(Token = "0x4003567")]
	[FieldOffset(Offset = "0x28")]
	private GameObject[] m_DisableOnShow;

	[Token(Token = "0x4003568")]
	private const float DAY_TIME = 0.7f;

	[Token(Token = "0x4003569")]
	private const float NIGHT_TIME = 0f;

	[Token(Token = "0x400356A")]
	private const float CAMERA_NUDGE = 0.2f;

	[Token(Token = "0x400356B")]
	private static bool s_IsShowing;

	[Token(Token = "0x400356C")]
	private static List<BrightnessCalibration> s_Instances;

	[Token(Token = "0x6002CC3")]
	[Address(RVA = "0x93BA60", Offset = "0x93A860", Length = "0x53")]
	public static bool IsShowing()
	{
		return false;
	}

	[Token(Token = "0x6002CC4")]
	[Address(RVA = "0x93BAC0", Offset = "0x93A8C0", Length = "0x24C")]
	public static void Show(bool isShown)
	{
	}

	[Token(Token = "0x6002CC5")]
	[Address(RVA = "0x93BD10", Offset = "0x93AB10", Length = "0x132")]
	public static void ForceNight()
	{
	}

	[Token(Token = "0x6002CC6")]
	[Address(RVA = "0x93BE50", Offset = "0x93AC50", Length = "0x137")]
	public static void ForceDay()
	{
	}

	[Token(Token = "0x6002CC7")]
	[Address(RVA = "0x93BF90", Offset = "0x93AD90", Length = "0x9")]
	public static float DayScreenRatio()
	{
		return 0f;
	}

	[Token(Token = "0x6002CC8")]
	[Address(RVA = "0x93BFA0", Offset = "0x93ADA0", Length = "0xD8")]
	private void Awake()
	{
	}

	[Token(Token = "0x6002CC9")]
	[Address(RVA = "0x93C080", Offset = "0x93AE80", Length = "0x11E")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6002CCA")]
	[Address(RVA = "0x93C1A0", Offset = "0x93AFA0", Length = "0x1FF")]
	private void SetVisibility(bool isShown)
	{
	}

	[Token(Token = "0x6002CCB")]
	[Address(RVA = "0x93C3A0", Offset = "0x93B1A0", Length = "0x12B")]
	private static void RefreshAmbientLightShaderValue()
	{
	}

	[Token(Token = "0x6002CCC")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public BrightnessCalibration()
	{
	}
}
