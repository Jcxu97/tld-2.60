using Cpp2ILInjected;
using TLD.UI.Generics;
using UnityEngine;

[Token(Token = "0x20007C8")]
public class ResolutionManager : MonoBehaviour
{
	[SerializeField]
	[Token(Token = "0x40053A5")]
	[FieldOffset(Offset = "0x20")]
	private PanelReference<Panel_OptionsMenu> m_OptionsMenu;

	[Token(Token = "0x40053A6")]
	[FieldOffset(Offset = "0x28")]
	private float m_ResetFullscreenTimer;

	[Token(Token = "0x40053A7")]
	[FieldOffset(Offset = "0x2C")]
	private bool m_ResetFullscreen;

	[Token(Token = "0x40053A8")]
	[FieldOffset(Offset = "0x30")]
	private int m_TargetWidth;

	[Token(Token = "0x40053A9")]
	[FieldOffset(Offset = "0x34")]
	private int m_TargetHeight;

	[Token(Token = "0x6004984")]
	[Address(RVA = "0xD20360", Offset = "0xD1F160", Length = "0x1C4")]
	private void Update()
	{
	}

	[Token(Token = "0x6004985")]
	[Address(RVA = "0xD20530", Offset = "0xD1F330", Length = "0x203")]
	private void ApplyResolution(bool fullScreen)
	{
	}

	[Token(Token = "0x6004986")]
	[Address(RVA = "0xD20740", Offset = "0xD1F540", Length = "0xFA")]
	public static void Initialize()
	{
	}

	[Token(Token = "0x6004987")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public ResolutionManager()
	{
	}
}
