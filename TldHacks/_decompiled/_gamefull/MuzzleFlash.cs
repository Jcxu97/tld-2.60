using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20003DA")]
public class MuzzleFlash : MonoBehaviour
{
	[Token(Token = "0x40022C6")]
	[FieldOffset(Offset = "0x20")]
	public float m_AlphaOnFire;

	[Token(Token = "0x40022C7")]
	[FieldOffset(Offset = "0x24")]
	private Color m_DefaultColor;

	[Token(Token = "0x40022C8")]
	[FieldOffset(Offset = "0x34")]
	private float m_CurrentAlpha;

	[Token(Token = "0x40022C9")]
	[FieldOffset(Offset = "0x38")]
	private Renderer m_Renderer;

	[Token(Token = "0x6001DF1")]
	[Address(RVA = "0x7AF560", Offset = "0x7AE360", Length = "0xF3")]
	private void Start()
	{
	}

	[Token(Token = "0x6001DF2")]
	[Address(RVA = "0x7AF660", Offset = "0x7AE460", Length = "0x7")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6001DF3")]
	[Address(RVA = "0x7AF670", Offset = "0x7AE470", Length = "0x25D")]
	private void Update()
	{
	}

	[Token(Token = "0x6001DF4")]
	[Address(RVA = "0x7AF8D0", Offset = "0x7AE6D0", Length = "0x4A")]
	public MuzzleFlash()
	{
	}
}
