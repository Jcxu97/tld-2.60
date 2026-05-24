using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.Gear;
using UnityEngine;

[Token(Token = "0x200021F")]
public class CraftingRequirementLocation : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000220")]
	public class Data
	{
		[Token(Token = "0x400131B")]
		[FieldOffset(Offset = "0x10")]
		public UISprite m_Icon;

		[Token(Token = "0x400131C")]
		[FieldOffset(Offset = "0x18")]
		public LocalizedString m_Name;

		[Token(Token = "0x400131D")]
		[FieldOffset(Offset = "0x20")]
		private Color m_IconTint;

		[Token(Token = "0x6001309")]
		[Address(RVA = "0x6633A0", Offset = "0x6621A0", Length = "0x6F")]
		public void Enable(Panel_Crafting panel, bool enable, bool requirementsMet)
		{
		}

		[Token(Token = "0x600130A")]
		[Address(RVA = "0x663410", Offset = "0x662210", Length = "0x22")]
		public void Setup()
		{
		}

		[Token(Token = "0x600130B")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public Data()
		{
		}
	}

	[Token(Token = "0x4001318")]
	[FieldOffset(Offset = "0x20")]
	public List<Data> m_DataSets;

	[Token(Token = "0x4001319")]
	[FieldOffset(Offset = "0x28")]
	public UILabel m_Display;

	[Token(Token = "0x400131A")]
	[FieldOffset(Offset = "0x30")]
	private Color m_DisplayTint;

	[Token(Token = "0x6001305")]
	[Address(RVA = "0x662B10", Offset = "0x661910", Length = "0x17A")]
	public void Awake()
	{
	}

	[Token(Token = "0x6001306")]
	[Address(RVA = "0x662C90", Offset = "0x661A90", Length = "0x97")]
	public void Disable()
	{
	}

	[Token(Token = "0x6001307")]
	[Address(RVA = "0x662D30", Offset = "0x661B30", Length = "0x577")]
	public void Enable(Panel_Crafting ownerPanel, BlueprintData bp)
	{
	}

	[Token(Token = "0x6001308")]
	[Address(RVA = "0x6632B0", Offset = "0x6620B0", Length = "0xE3")]
	public CraftingRequirementLocation()
	{
	}
}
