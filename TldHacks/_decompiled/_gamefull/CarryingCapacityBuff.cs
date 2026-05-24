using System;
using Cpp2ILInjected;
using TLD.IntBackedUnit;
using UnityEngine;

[Token(Token = "0x200045D")]
public class CarryingCapacityBuff : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x200045E")]
	public class BuffValues
	{
		[Token(Token = "0x40027AA")]
		[FieldOffset(Offset = "0x10")]
		public ItemWeight m_MaxCarryCapacityBuff;

		[Token(Token = "0x6002111")]
		[Address(RVA = "0x80BB70", Offset = "0x80A970", Length = "0x75")]
		public void Add(BuffValues other)
		{
		}

		[Token(Token = "0x6002112")]
		[Address(RVA = "0x80BBF0", Offset = "0x80A9F0", Length = "0x5D")]
		public void Zero()
		{
		}

		[Token(Token = "0x6002113")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public BuffValues()
		{
		}
	}

	[Token(Token = "0x40027A6")]
	[FieldOffset(Offset = "0x20")]
	public BuffValues m_CarryingCapacityBuffValues;

	[Token(Token = "0x40027A7")]
	[FieldOffset(Offset = "0x28")]
	public bool m_IsWorn;

	[Token(Token = "0x40027A8")]
	[FieldOffset(Offset = "0x30")]
	public string m_SpecialInventoryOpenSound;

	[Token(Token = "0x40027A9")]
	[FieldOffset(Offset = "0x38")]
	public string m_SpecialInventoryCloseSound;

	[Token(Token = "0x6002110")]
	[Address(RVA = "0x80BB20", Offset = "0x80A920", Length = "0x47")]
	public CarryingCapacityBuff()
	{
	}
}
