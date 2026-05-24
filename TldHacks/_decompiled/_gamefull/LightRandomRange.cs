using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20003CA")]
public class LightRandomRange : MonoBehaviour
{
	[Token(Token = "0x4002231")]
	[FieldOffset(Offset = "0x20")]
	public float m_IntervalSeconds;

	[Token(Token = "0x4002232")]
	[FieldOffset(Offset = "0x24")]
	public float m_Min;

	[Token(Token = "0x4002233")]
	[FieldOffset(Offset = "0x28")]
	public float m_Max;

	[Token(Token = "0x4002234")]
	[FieldOffset(Offset = "0x2C")]
	private float m_CurrentTime;

	[Token(Token = "0x4002235")]
	[FieldOffset(Offset = "0x30")]
	private float m_Destination;

	[Token(Token = "0x4002236")]
	[FieldOffset(Offset = "0x34")]
	private float m_LightRangeStart;

	[Token(Token = "0x4002237")]
	[FieldOffset(Offset = "0x38")]
	private Light m_Light;

	[Token(Token = "0x6001D99")]
	[Address(RVA = "0x7A70D0", Offset = "0x7A5ED0", Length = "0xBD")]
	private void Start()
	{
	}

	[Token(Token = "0x6001D9A")]
	[Address(RVA = "0x7A7190", Offset = "0x7A5F90", Length = "0x132")]
	private void Update()
	{
	}

	[Token(Token = "0x6001D9B")]
	[Address(RVA = "0x7A72D0", Offset = "0x7A60D0", Length = "0xEC")]
	public float GetRange()
	{
		return 0f;
	}

	[Token(Token = "0x6001D9C")]
	[Address(RVA = "0x787050", Offset = "0x785E50", Length = "0x51")]
	public LightRandomRange()
	{
	}
}
