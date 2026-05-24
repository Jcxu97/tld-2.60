using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200023A")]
public class FrostbiteIndicator : MonoBehaviour
{
	[Token(Token = "0x40013BB")]
	[FieldOffset(Offset = "0x20")]
	public UISprite m_FullFrostbiteSprite;

	[Token(Token = "0x40013BC")]
	[FieldOffset(Offset = "0x28")]
	public UISprite m_RiskSprite;

	[Token(Token = "0x40013BD")]
	[FieldOffset(Offset = "0x30")]
	public UISprite m_FillSprite;

	[Token(Token = "0x40013BE")]
	[FieldOffset(Offset = "0x38")]
	public UILabel m_MultiplierLabel;

	[Token(Token = "0x40013BF")]
	[FieldOffset(Offset = "0x40")]
	public AfflictionBodyArea m_BodyLocation;

	[Token(Token = "0x40013C0")]
	[FieldOffset(Offset = "0x44")]
	private int m_NumInstances;

	[Token(Token = "0x40013C1")]
	[FieldOffset(Offset = "0x48")]
	private float m_RiskValue;

	[Token(Token = "0x60013B2")]
	[Address(RVA = "0x674AF0", Offset = "0x6738F0", Length = "0xFE")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60013B3")]
	[Address(RVA = "0x674BF0", Offset = "0x6739F0", Length = "0x1B9")]
	private void Update()
	{
	}

	[Token(Token = "0x60013B4")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public FrostbiteIndicator()
	{
	}
}
