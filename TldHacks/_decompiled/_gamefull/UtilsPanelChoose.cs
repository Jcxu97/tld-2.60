using System;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20006EE")]
public class UtilsPanelChoose
{
	[Token(Token = "0x20006EF")]
	public enum DetailsType
	{
		[Token(Token = "0x40049CB")]
		Challenges,
		[Token(Token = "0x40049CC")]
		Sandbox,
		[Token(Token = "0x40049CD")]
		Story
	}

	[Serializable]
	[Token(Token = "0x20006F0")]
	public class DetailsObjets
	{
		[Token(Token = "0x40049CE")]
		[FieldOffset(Offset = "0x10")]
		public GameObject m_Details;

		[Token(Token = "0x40049CF")]
		[FieldOffset(Offset = "0x18")]
		public UILabel m_TitleLabel;

		[Token(Token = "0x40049D0")]
		[FieldOffset(Offset = "0x20")]
		public UILabel m_DateLabel;

		[Token(Token = "0x40049D1")]
		[FieldOffset(Offset = "0x28")]
		public UILabel m_SurvivorLabel;

		[Token(Token = "0x40049D2")]
		[FieldOffset(Offset = "0x30")]
		public UILabel m_ConditionLabel;

		[Token(Token = "0x40049D3")]
		[FieldOffset(Offset = "0x38")]
		public UILabel m_XPLabel;

		[Token(Token = "0x40049D4")]
		[FieldOffset(Offset = "0x40")]
		public UILabel m_SurvivedLabel;

		[Token(Token = "0x40049D5")]
		[FieldOffset(Offset = "0x48")]
		public UILabel m_ExploredLabel;

		[Token(Token = "0x40049D6")]
		[FieldOffset(Offset = "0x50")]
		public UILabel m_RegionLabel;

		[Token(Token = "0x40049D7")]
		[FieldOffset(Offset = "0x58")]
		public UILabel m_LocationLabel;

		[Token(Token = "0x40049D8")]
		[FieldOffset(Offset = "0x60")]
		public UISprite m_RegionSprite;

		[Token(Token = "0x40049D9")]
		[FieldOffset(Offset = "0x68")]
		public UITexture m_CenteredTexture;

		[Token(Token = "0x40049DA")]
		[FieldOffset(Offset = "0x70")]
		public UITexture m_BackgroundTexture;

		[Token(Token = "0x40049DB")]
		[FieldOffset(Offset = "0x78")]
		public UITexture m_ThumbnailTexture;

		[Token(Token = "0x40049DC")]
		[FieldOffset(Offset = "0x80")]
		public UILabel m_EpisodeProgressionLabel;

		[Token(Token = "0x40049DD")]
		[FieldOffset(Offset = "0x88")]
		public UILabel m_SaveVersionLabel;

		[Token(Token = "0x40049DE")]
		[FieldOffset(Offset = "0x90")]
		public GameObject m_SaveVersionObject;

		[Token(Token = "0x40049DF")]
		[FieldOffset(Offset = "0x98")]
		public UILabel m_SaveSizeLabel;

		[Token(Token = "0x6003CF5")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public DetailsObjets()
		{
		}
	}

	[Token(Token = "0x6003CEB")]
	[Address(RVA = "0xB85C80", Offset = "0xB84A80", Length = "0x7")]
	private static string GetRegionLargeTextureName(string locationName)
	{
		return null;
	}

	[Token(Token = "0x6003CEC")]
	[Address(RVA = "0xB85C90", Offset = "0xB84A90", Length = "0x8E7")]
	private static string GetRegionTextureName(string locationName)
	{
		return null;
	}

	[Token(Token = "0x6003CED")]
	[Address(RVA = "0xB86580", Offset = "0xB85380", Length = "0x4FF")]
	public static string GetRegionSaveSlotTextureName(string locationName)
	{
		return null;
	}

	[Token(Token = "0x6003CEE")]
	[Address(RVA = "0xB86A80", Offset = "0xB85880", Length = "0x11A3")]
	public static void RefreshDetails(SaveSlotInfo slotInfo, DetailsObjets details, DetailsType type)
	{
	}

	[Token(Token = "0x6003CEF")]
	[Address(RVA = "0xB87C30", Offset = "0xB86A30", Length = "0x467")]
	private static void GetLocationAndRegion(SaveSlotInfo slotInfo, out string location, out string region)
	{
		location = null;
		region = null;
	}

	[Token(Token = "0x6003CF0")]
	[Address(RVA = "0xB880A0", Offset = "0xB86EA0", Length = "0xCD")]
	private static string GetLargeRegionBackgroundName(SaveSlotInfo slotInfo)
	{
		return null;
	}

	[Token(Token = "0x6003CF1")]
	[Address(RVA = "0xB88170", Offset = "0xB86F70", Length = "0xCD")]
	private static string GetRegionSpriteName(SaveSlotInfo slotInfo)
	{
		return null;
	}

	[Token(Token = "0x6003CF2")]
	[Address(RVA = "0xB88240", Offset = "0xB87040", Length = "0x3F1")]
	public static void ProcessMenu(BasicMenu basicMenu, bool canRename, bool canDelete, Action onAutoBack, GameObject renameButton, Action onRename, GameObject deleteButton, Action onDelete)
	{
	}

	[Token(Token = "0x6003CF3")]
	[Address(RVA = "0xB88640", Offset = "0xB87440", Length = "0x209")]
	public static void UpdateButtonLegend(BasicMenu basicMenu, bool canLoad, bool canRename, bool canDelete, ButtonLegendContainer buttonLegendContainer)
	{
	}

	[Token(Token = "0x6003CF4")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public UtilsPanelChoose()
	{
	}
}
