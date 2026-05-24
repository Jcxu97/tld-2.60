using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;

[Token(Token = "0x2000919")]
public class SaveGameSlotHelper
{
	[Token(Token = "0x4005EA8")]
	private static List<SaveSlotInfo> m_StorySaveSlots;

	[Token(Token = "0x4005EA9")]
	private static List<SaveSlotInfo> m_SandboxSlots;

	[Token(Token = "0x4005EAA")]
	private static List<SaveSlotInfo> m_ChallengeSaveSlots;

	[Token(Token = "0x14000016")]
	public static event Action OnSaveGameSlotsUpdated
	{
		[CompilerGenerated]
		[Token(Token = "0x60052CF")]
		[Address(RVA = "0xE51540", Offset = "0xE50340", Length = "0x14F")]
		add
		{
		}
		[CompilerGenerated]
		[Token(Token = "0x60052D0")]
		[Address(RVA = "0xE51690", Offset = "0xE50490", Length = "0x14F")]
		remove
		{
		}
	}

	[Token(Token = "0x60052D1")]
	[Address(RVA = "0xE517E0", Offset = "0xE505E0", Length = "0x108")]
	public static void ClearSaveSlotsLists()
	{
	}

	[Token(Token = "0x60052D2")]
	[Address(RVA = "0xE518F0", Offset = "0xE506F0", Length = "0xFA")]
	public static void RefreshSaveSlots(SaveSlotType saveSlotType, bool forceRefresh = false)
	{
	}

	[Token(Token = "0x60052D3")]
	[Address(RVA = "0xE519F0", Offset = "0xE507F0", Length = "0x3E7")]
	private static void RefreshStorySaveSlots()
	{
	}

	[Token(Token = "0x60052D4")]
	[Address(RVA = "0xE51DE0", Offset = "0xE50BE0", Length = "0x350")]
	private static void RefreshSandboxSaveSlots()
	{
	}

	[Token(Token = "0x60052D5")]
	[Address(RVA = "0xE52140", Offset = "0xE50F40", Length = "0x350")]
	private static void RefreshChallengeSaveSlots()
	{
	}

	[Token(Token = "0x60052D6")]
	[Address(RVA = "0xE524A0", Offset = "0xE512A0", Length = "0x6C")]
	public static int GetNumSaveSlots(SaveSlotType saveSlotType)
	{
		return 0;
	}

	[Token(Token = "0x60052D7")]
	[Address(RVA = "0xE52510", Offset = "0xE51310", Length = "0x70")]
	public static bool HasSaveSlots(SaveSlotType saveSlotType)
	{
		return false;
	}

	[Token(Token = "0x60052D8")]
	[Address(RVA = "0xE52580", Offset = "0xE51380", Length = "0x9B")]
	public static SaveSlotInfo GetCurrentSaveSlotInfo()
	{
		return null;
	}

	[Token(Token = "0x60052D9")]
	[Address(RVA = "0xE52620", Offset = "0xE51420", Length = "0xBE")]
	public static SaveSlotInfo GetSaveSlotInfo(SaveSlotType saveSlotType, int index)
	{
		return null;
	}

	[Token(Token = "0x60052DA")]
	[Address(RVA = "0xE526E0", Offset = "0xE514E0", Length = "0x1BD")]
	public static SaveSlotInfo GetSaveSlotInfo(SaveSlotType saveSlotType, string saveName)
	{
		return null;
	}

	[Token(Token = "0x60052DB")]
	[Address(RVA = "0xE528A0", Offset = "0xE516A0", Length = "0x164")]
	public static void DeleteSaveSlotInfo(SaveSlotInfo ssi)
	{
	}

	[Token(Token = "0x60052DC")]
	[Address(RVA = "0xE52A10", Offset = "0xE51810", Length = "0xD0")]
	private static List<SaveSlotInfo> GetSaveSlotInfoList(SaveSlotType saveSlotType)
	{
		return null;
	}

	[Token(Token = "0x60052DD")]
	[Address(RVA = "0xE52AE0", Offset = "0xE518E0", Length = "0x8C")]
	private static void NotifySaveGameSlotsUpdated()
	{
	}

	[Token(Token = "0x60052DE")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public SaveGameSlotHelper()
	{
	}
}
