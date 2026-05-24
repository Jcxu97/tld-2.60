using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200024E")]
public class HoverTooltip : MonoBehaviour
{
	[Token(Token = "0x4001478")]
	[FieldOffset(Offset = "0x20")]
	public UIWidget m_TooltipWidget;

	[Token(Token = "0x4001479")]
	[FieldOffset(Offset = "0x28")]
	public float m_HoverTimeRequiredSecs;

	[Token(Token = "0x400147A")]
	[FieldOffset(Offset = "0x2C")]
	public float m_FadeInTimeSecs;

	[Token(Token = "0x400147B")]
	[FieldOffset(Offset = "0x30")]
	public float m_FadeOutTimeSecs;

	[Token(Token = "0x400147C")]
	[FieldOffset(Offset = "0x38")]
	private UIWidget m_Widget;

	[Token(Token = "0x400147D")]
	[FieldOffset(Offset = "0x40")]
	private bool m_IsHovering;

	[Token(Token = "0x400147E")]
	[FieldOffset(Offset = "0x44")]
	private float m_StartHoverTime;

	[Token(Token = "0x400147F")]
	[FieldOffset(Offset = "0x48")]
	private float m_EndHoverTime;

	[Token(Token = "0x4001480")]
	[FieldOffset(Offset = "0x4C")]
	private float m_AlphaOnEndHover;

	[Token(Token = "0x6001443")]
	[Address(RVA = "0x6810D0", Offset = "0x67FED0", Length = "0x21D")]
	private void Awake()
	{
	}

	[Token(Token = "0x6001444")]
	[Address(RVA = "0x6812F0", Offset = "0x6800F0", Length = "0x283")]
	private void Update()
	{
	}

	[Token(Token = "0x6001445")]
	[Address(RVA = "0x681580", Offset = "0x680380", Length = "0x34")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6001446")]
	[Address(RVA = "0x6815C0", Offset = "0x6803C0", Length = "0xBF")]
	public void OnHover(bool hover)
	{
	}

	[Token(Token = "0x6001447")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public HoverTooltip()
	{
	}
}
