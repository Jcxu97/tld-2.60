using Cpp2ILInjected;
using TLD.UI;
using UnityEngine;

[Token(Token = "0x2000616")]
public class Panel_Camera : Panel_AutoReferenced
{
	[SerializeField]
	[Token(Token = "0x4003943")]
	[FieldOffset(Offset = "0x30")]
	private float m_CameraFadeInSeconds;

	[Token(Token = "0x600302B")]
	[Address(RVA = "0x4A2140", Offset = "0x4A0F40", Length = "0x3")]
	public override bool IsOverlayPanel()
	{
		return false;
	}

	[Token(Token = "0x600302C")]
	[Address(RVA = "0x9A1A50", Offset = "0x9A0850", Length = "0x7F")]
	public override void Enable(bool enable)
	{
	}

	[Token(Token = "0x600302D")]
	[Address(RVA = "0x9A1AD0", Offset = "0x9A08D0", Length = "0x4A")]
	public Panel_Camera()
	{
	}
}
