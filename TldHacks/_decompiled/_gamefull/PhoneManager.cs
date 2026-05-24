using System.Collections.Generic;
using Cpp2ILInjected;

[Token(Token = "0x2000794")]
public class PhoneManager
{
	[Token(Token = "0x40050F6")]
	public static bool s_Debug;

	[Token(Token = "0x40050F7")]
	private static PhoneManagerSaveData s_PhoneManagerSaveData;

	[Token(Token = "0x40050F8")]
	private static List<Phone> s_Phones;

	[Token(Token = "0x60046B6")]
	[Address(RVA = "0xCAF9C0", Offset = "0xCAE7C0", Length = "0xBE")]
	public static void Add(Phone phone)
	{
	}

	[Token(Token = "0x60046B7")]
	[Address(RVA = "0xCAFA80", Offset = "0xCAE880", Length = "0x83")]
	public static void Remove(Phone phone)
	{
	}

	[Token(Token = "0x60046B8")]
	[Address(RVA = "0xCAFB10", Offset = "0xCAE910", Length = "0xF0")]
	public static void Reset()
	{
	}

	[Token(Token = "0x60046B9")]
	[Address(RVA = "0xCAFC10", Offset = "0xCAEA10", Length = "0xBC")]
	public static string Serialize()
	{
		return null;
	}

	[Token(Token = "0x60046BA")]
	[Address(RVA = "0xCAFCD0", Offset = "0xCAEAD0", Length = "0x127")]
	public static void Deserialize(string text)
	{
	}

	[Token(Token = "0x60046BB")]
	[Address(RVA = "0xCAFE00", Offset = "0xCAEC00", Length = "0x146")]
	public static bool IsConversationComplete(DTContainer dtContainer, int index)
	{
		return false;
	}

	[Token(Token = "0x60046BC")]
	[Address(RVA = "0xCAFF50", Offset = "0xCAED50", Length = "0x130")]
	public static bool IsSequenceComplete(DTContainer dtContainer)
	{
		return false;
	}

	[Token(Token = "0x60046BD")]
	[Address(RVA = "0xCB0090", Offset = "0xCAEE90", Length = "0x1E3")]
	private static DialogueSequenceProgressionInfo GetDialogueSequenceProgressionInfo(string uniqueId)
	{
		return null;
	}

	[Token(Token = "0x60046BE")]
	[Address(RVA = "0xCB0280", Offset = "0xCAF080", Length = "0x1E3")]
	private static PhoneSaveDataInfo GetPhoneSaveInfo(string missionId)
	{
		return null;
	}

	[Token(Token = "0x60046BF")]
	[Address(RVA = "0xCB0470", Offset = "0xCAF270", Length = "0x17F")]
	private static PhoneSaveDataInfo GetOrCreatePhoneSaveDataInfo(string missionId)
	{
		return null;
	}

	[Token(Token = "0x60046C0")]
	[Address(RVA = "0xCB05F0", Offset = "0xCAF3F0", Length = "0x186")]
	private static DialogueSequenceProgressionInfo GetOrCreateDialogueSequenceProgressionInfo(string uniqueId)
	{
		return null;
	}

	[Token(Token = "0x60046C1")]
	[Address(RVA = "0xCB0780", Offset = "0xCAF580", Length = "0x12E")]
	public static int GetCurrentDialogueTreeIndex(Phone phone)
	{
		return 0;
	}

	[Token(Token = "0x60046C2")]
	[Address(RVA = "0xCB08B0", Offset = "0xCAF6B0", Length = "0xF9")]
	public static void SelectNextDialogueTree(DTContainer dtContainer)
	{
	}

	[Token(Token = "0x60046C3")]
	[Address(RVA = "0xCB09B0", Offset = "0xCAF7B0", Length = "0xFD")]
	public static void ResetDialogueTreeIndex(DTContainer dtContainer)
	{
	}

	[Token(Token = "0x60046C4")]
	[Address(RVA = "0xCB0AB0", Offset = "0xCAF8B0", Length = "0x6A")]
	public static void StartRinging(string missionId)
	{
	}

	[Token(Token = "0x60046C5")]
	[Address(RVA = "0xCB0B20", Offset = "0xCAF920", Length = "0x63")]
	public static void StopRinging(string missionId)
	{
	}

	[Token(Token = "0x60046C6")]
	[Address(RVA = "0xCB0B90", Offset = "0xCAF990", Length = "0x6B")]
	public static bool HasPhoneStartedRinging(string missionId)
	{
		return false;
	}

	[Token(Token = "0x60046C7")]
	[Address(RVA = "0xCB0C00", Offset = "0xCAFA00", Length = "0x62")]
	public static void IncrementRingCycleCount(string missionId)
	{
	}

	[Token(Token = "0x60046C8")]
	[Address(RVA = "0xCB0C70", Offset = "0xCAFA70", Length = "0x6A")]
	public static int GetRingCycleCount(string missionId)
	{
		return 0;
	}

	[Token(Token = "0x60046C9")]
	[Address(RVA = "0xCB0CE0", Offset = "0xCAFAE0", Length = "0xAF6")]
	public static string GetDebugText()
	{
		return null;
	}

	[Token(Token = "0x60046CA")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public PhoneManager()
	{
	}
}
