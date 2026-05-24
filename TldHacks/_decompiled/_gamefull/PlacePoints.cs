using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20003F2")]
public class PlacePoints : MonoBehaviour
{
	[Token(Token = "0x400235D")]
	[FieldOffset(Offset = "0x20")]
	public MinMax m_PrimaryFadeDistance;

	[Token(Token = "0x400235E")]
	[FieldOffset(Offset = "0x28")]
	public MinMax m_SecondaryFadeDistance;

	[Token(Token = "0x400235F")]
	[FieldOffset(Offset = "0x30")]
	public float m_FadeSpeed;

	[Token(Token = "0x4002360")]
	[FieldOffset(Offset = "0x34")]
	public float m_MaxAlpha;

	[Token(Token = "0x4002361")]
	[FieldOffset(Offset = "0x38")]
	public Renderer[] m_PlacePoints;

	[Token(Token = "0x4002362")]
	[FieldOffset(Offset = "0x40")]
	public bool m_ShowIfFireIsBurning;

	[Token(Token = "0x4002363")]
	[FieldOffset(Offset = "0x48")]
	public Fire m_AttachedFire;

	[Token(Token = "0x4002364")]
	[FieldOffset(Offset = "0x50")]
	private float m_CurrentFade;

	[Token(Token = "0x4002365")]
	[FieldOffset(Offset = "0x54")]
	private float m_DestinationFade;

	[Token(Token = "0x4002366")]
	[FieldOffset(Offset = "0x58")]
	private float m_Distance;

	[Token(Token = "0x6001E4E")]
	[Address(RVA = "0x7B9490", Offset = "0x7B8290", Length = "0x3CD")]
	private void Update()
	{
	}

	[Token(Token = "0x6001E4F")]
	[Address(RVA = "0x7B9860", Offset = "0x7B8660", Length = "0x559")]
	private void UpdateColors(Renderer placePoint, float fade)
	{
	}

	[Token(Token = "0x6001E50")]
	[Address(RVA = "0x7B9DC0", Offset = "0x7B8BC0", Length = "0x2B0")]
	private bool ShouldShow()
	{
		return false;
	}

	[Token(Token = "0x6001E51")]
	[Address(RVA = "0x7BA080", Offset = "0x7B8E80", Length = "0x51")]
	public PlacePoints()
	{
	}
}
