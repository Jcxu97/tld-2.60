using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20004D3")]
public class SmashableItem : MonoBehaviour
{
	[Token(Token = "0x4002C2C")]
	[FieldOffset(Offset = "0x20")]
	public int m_MinPercentLoss;

	[Token(Token = "0x4002C2D")]
	[FieldOffset(Offset = "0x24")]
	public int m_MaxPercentLoss;

	[Token(Token = "0x4002C2E")]
	[FieldOffset(Offset = "0x28")]
	public int m_TimeToSmash;

	[Token(Token = "0x4002C2F")]
	[FieldOffset(Offset = "0x30")]
	public string m_SmashAudio;

	[HideInInspector]
	[Token(Token = "0x4002C30")]
	[FieldOffset(Offset = "0x38")]
	public bool m_HasBeenSmashed;

	[Token(Token = "0x4002C31")]
	private static SmashableItemSaveDataProxy m_SmashableItemSaveDataProxy;

	[Token(Token = "0x60024C5")]
	[Address(RVA = "0x86E050", Offset = "0x86CE50", Length = "0xE0")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x60024C6")]
	[Address(RVA = "0x86E140", Offset = "0x86CF40", Length = "0x169")]
	public void Deserialize(string text)
	{
	}

	[Token(Token = "0x60024C7")]
	[Address(RVA = "0x86E2B0", Offset = "0x86D0B0", Length = "0x107")]
	public bool NeedsToBeSmashedOpen()
	{
		return false;
	}

	[Token(Token = "0x60024C8")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public SmashableItem()
	{
	}
}
