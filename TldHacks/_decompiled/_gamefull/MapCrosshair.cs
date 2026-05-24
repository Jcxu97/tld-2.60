using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200025A")]
public class MapCrosshair : MonoBehaviour
{
	[Token(Token = "0x200025B")]
	public enum CrosshairState
	{
		[Token(Token = "0x4001555")]
		Normal,
		[Token(Token = "0x4001556")]
		NormalHoverSmall,
		[Token(Token = "0x4001557")]
		NormalHoverBig,
		[Token(Token = "0x4001558")]
		NormalHoverArea,
		[Token(Token = "0x4001559")]
		Zoom,
		[Token(Token = "0x400155A")]
		ZoomHoverSmall,
		[Token(Token = "0x400155B")]
		ZoomHoverBig,
		[Token(Token = "0x400155C")]
		ZoomHoverArea
	}

	[Token(Token = "0x4001541")]
	[FieldOffset(Offset = "0x20")]
	public float m_SpacingNormal;

	[Token(Token = "0x4001542")]
	[FieldOffset(Offset = "0x24")]
	public float m_SpacingHoverSmall;

	[Token(Token = "0x4001543")]
	[FieldOffset(Offset = "0x28")]
	public float m_SpacingHoverBig;

	[Token(Token = "0x4001544")]
	[FieldOffset(Offset = "0x2C")]
	public float m_SpacingHoverArea;

	[Token(Token = "0x4001545")]
	[FieldOffset(Offset = "0x30")]
	public Transform m_SpriteLeft;

	[Token(Token = "0x4001546")]
	[FieldOffset(Offset = "0x38")]
	public Transform m_SpriteRight;

	[Token(Token = "0x4001547")]
	[FieldOffset(Offset = "0x40")]
	public Transform m_SpriteUp;

	[Token(Token = "0x4001548")]
	[FieldOffset(Offset = "0x48")]
	public Transform m_SpriteDown;

	[Token(Token = "0x4001549")]
	[FieldOffset(Offset = "0x50")]
	public float m_ScaleBegin;

	[Token(Token = "0x400154A")]
	[FieldOffset(Offset = "0x54")]
	public float m_ScaleEnd;

	[Token(Token = "0x400154B")]
	[FieldOffset(Offset = "0x58")]
	private CrosshairState m_State;

	[Token(Token = "0x400154C")]
	[FieldOffset(Offset = "0x60")]
	private TweenScale m_TweenScaleLeft;

	[Token(Token = "0x400154D")]
	[FieldOffset(Offset = "0x68")]
	private TweenScale m_TweenScaleRight;

	[Token(Token = "0x400154E")]
	[FieldOffset(Offset = "0x70")]
	private TweenScale m_TweenScaleUp;

	[Token(Token = "0x400154F")]
	[FieldOffset(Offset = "0x78")]
	private TweenScale m_TweenScaleDown;

	[Token(Token = "0x4001550")]
	[FieldOffset(Offset = "0x80")]
	private TweenPosition m_TweenPosLeft;

	[Token(Token = "0x4001551")]
	[FieldOffset(Offset = "0x88")]
	private TweenPosition m_TweenPosRight;

	[Token(Token = "0x4001552")]
	[FieldOffset(Offset = "0x90")]
	private TweenPosition m_TweenPosUp;

	[Token(Token = "0x4001553")]
	[FieldOffset(Offset = "0x98")]
	private TweenPosition m_TweenPosDown;

	[Token(Token = "0x60014C1")]
	[Address(RVA = "0x692310", Offset = "0x691110", Length = "0x39E")]
	private void Awake()
	{
	}

	[Token(Token = "0x60014C2")]
	[Address(RVA = "0x6926B0", Offset = "0x6914B0", Length = "0x60D")]
	public void ResetToNormal()
	{
	}

	[Token(Token = "0x60014C3")]
	[Address(RVA = "0x692CC0", Offset = "0x691AC0", Length = "0xA39")]
	public void SetState(CrosshairState newState)
	{
	}

	[Token(Token = "0x60014C4")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public MapCrosshair()
	{
	}
}
