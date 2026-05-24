using System;
using Cpp2ILInjected;
using UnityEngine;

namespace TLD.Gear;

[CreateAssetMenu(menuName = "The Long Dark/Gear/Powder Type", fileName = "POWDER_NewPowderType")]
[Token(Token = "0x200142F")]
public class PowderType : ScriptableObject
{
	[SerializeField]
	[Token(Token = "0x400933B")]
	[FieldOffset(Offset = "0x18")]
	private LocalizedString m_PowderName;

	[SerializeField]
	[Token(Token = "0x400933C")]
	[FieldOffset(Offset = "0x20")]
	private LocalizedString m_PowderDecription;

	[SerializeField]
	[Token(Token = "0x400933D")]
	[FieldOffset(Offset = "0x28")]
	private GearItemData m_DefaultContainer;

	[NonSerialized]
	[Token(Token = "0x400933E")]
	[FieldOffset(Offset = "0x30")]
	private Texture2D m_CachedInventoryIcon;

	[Token(Token = "0x17000B20")]
	public LocalizedString PowderName
	{
		[Token(Token = "0x60080CE")]
		[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000B21")]
	public LocalizedString PowderDescription
	{
		[Token(Token = "0x60080CF")]
		[Address(RVA = "0x40E110", Offset = "0x40CF10", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000B22")]
	public GearItemData DefaultContainer
	{
		[Token(Token = "0x60080D0")]
		[Address(RVA = "0x413AB0", Offset = "0x4128B0", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60080D1")]
	[Address(RVA = "0x120EBA0", Offset = "0x120D9A0", Length = "0x3CE")]
	public Texture2D GetInventoryIcon()
	{
		return null;
	}

	[Token(Token = "0x60080D2")]
	[Address(RVA = "0x4A22A0", Offset = "0x4A10A0", Length = "0x7")]
	public PowderType()
	{
	}
}
