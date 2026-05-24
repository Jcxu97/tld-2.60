using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000292")]
public class TimeWidget : MonoBehaviour
{
	[Token(Token = "0x4001738")]
	[FieldOffset(Offset = "0x20")]
	public UISprite m_ArrowSprite;

	[Token(Token = "0x4001739")]
	[FieldOffset(Offset = "0x28")]
	public UISprite m_MoonSprite;

	[Token(Token = "0x400173A")]
	[FieldOffset(Offset = "0x30")]
	public UISprite m_SunSprite;

	[Token(Token = "0x400173B")]
	[FieldOffset(Offset = "0x38")]
	private float m_SunRadius;

	[Token(Token = "0x400173C")]
	[FieldOffset(Offset = "0x3C")]
	private float m_MoonRadius;

	[Token(Token = "0x400173D")]
	[FieldOffset(Offset = "0x40")]
	private bool m_Initialized;

	[Token(Token = "0x600161C")]
	[Address(RVA = "0x6B0E20", Offset = "0x6AFC20", Length = "0x329")]
	private void Start()
	{
	}

	[Token(Token = "0x600161D")]
	[Address(RVA = "0x6B1150", Offset = "0x6AFF50", Length = "0x356")]
	public void Update()
	{
	}

	[Token(Token = "0x600161E")]
	[Address(RVA = "0x6B14B0", Offset = "0x6B02B0", Length = "0x50D")]
	private void UpdateIconPositions(float angleDegrees)
	{
	}

	[Token(Token = "0x600161F")]
	[Address(RVA = "0x6B19C0", Offset = "0x6B07C0", Length = "0xD6")]
	private void UpdateIconFill(UISprite sprite, Vector3 pos, float angleDegrees)
	{
	}

	[Token(Token = "0x6001620")]
	[Address(RVA = "0x6B1AA0", Offset = "0x6B08A0", Length = "0x5C")]
	private Vector3 GetPositionOnCircle(float radius, float angleDegrees)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6001621")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public TimeWidget()
	{
	}
}
