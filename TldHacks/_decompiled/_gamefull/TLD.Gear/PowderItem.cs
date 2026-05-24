using Cpp2ILInjected;
using TLD.IntBackedUnit;
using UnityEngine;

namespace TLD.Gear;

[Token(Token = "0x200142D")]
public class PowderItem : MonoBehaviour
{
	[Token(Token = "0x200142E")]
	private class SaveData
	{
		[Token(Token = "0x400933A")]
		[FieldOffset(Offset = "0x10")]
		public ItemWeight m_WeightKG;

		[Token(Token = "0x60080CD")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public SaveData()
		{
		}
	}

	[Token(Token = "0x4009337")]
	[FieldOffset(Offset = "0x20")]
	public PowderType m_Type;

	[Token(Token = "0x4009338")]
	[FieldOffset(Offset = "0x28")]
	public ItemWeight m_Weight;

	[Token(Token = "0x4009339")]
	[FieldOffset(Offset = "0x30")]
	public ItemWeight m_WeightLimit;

	[Token(Token = "0x60080C8")]
	[Address(RVA = "0x120E850", Offset = "0x120D650", Length = "0x136")]
	public ItemWeight AddPowder(ItemWeight amount)
	{
		return default(ItemWeight);
	}

	[Token(Token = "0x60080C9")]
	[Address(RVA = "0x120E990", Offset = "0x120D790", Length = "0xB8")]
	public ItemWeight RemovePowder(ItemWeight amount)
	{
		return default(ItemWeight);
	}

	[Token(Token = "0x60080CA")]
	[Address(RVA = "0x120EA50", Offset = "0x120D850", Length = "0x89")]
	public void Deserialize(string serialized)
	{
	}

	[Token(Token = "0x60080CB")]
	[Address(RVA = "0x120EAE0", Offset = "0x120D8E0", Length = "0xBF")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x60080CC")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public PowderItem()
	{
	}
}
