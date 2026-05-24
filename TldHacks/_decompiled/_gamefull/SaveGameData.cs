using System.Collections.Generic;
using Cpp2ILInjected;

[Token(Token = "0x2000914")]
public class SaveGameData
{
	[Token(Token = "0x4005E96")]
	public static readonly int MAX_COMPRESS_DECOMPRESS_BUFFER_LEN;

	[Token(Token = "0x4005E97")]
	public static readonly int SAVE_OPERATION_TIMEOUT_SECONDS;

	[Token(Token = "0x4005E98")]
	public static byte[] m_CompressDecompressBuffer;

	[Token(Token = "0x4005E99")]
	public static SaveGameOperationData m_CurrentAsyncSaveGameOperation;

	[Token(Token = "0x4005E9A")]
	public static List<SaveGameOperationData> m_PendingSaveGameOperations;

	[Token(Token = "0x4005E9B")]
	private static List<string> m_LoadingPriorityPatterns;

	[Token(Token = "0x6005298")]
	[Address(RVA = "0xE4B570", Offset = "0xE4A370", Length = "0x120")]
	public static void DeleteData(string name)
	{
	}

	[Token(Token = "0x6005299")]
	[Address(RVA = "0xE4B6A0", Offset = "0xE4A4A0", Length = "0x45")]
	public static void InitializeUserProfile()
	{
	}

	[Token(Token = "0x600529A")]
	[Address(RVA = "0x430B50", Offset = "0x42F950", Length = "0x3")]
	public static bool ShouldValidateUserProfile()
	{
		return false;
	}

	[Token(Token = "0x600529B")]
	[Address(RVA = "0xE4B6F0", Offset = "0xE4A4F0", Length = "0x89")]
	public static bool IsValidationActive()
	{
		return false;
	}

	[Token(Token = "0x600529C")]
	[Address(RVA = "0xE4B780", Offset = "0xE4A580", Length = "0x45")]
	public static void ValidateUserProfile()
	{
	}

	[Token(Token = "0x600529D")]
	[Address(RVA = "0xE4B7D0", Offset = "0xE4A5D0", Length = "0xE8")]
	public static void LoadAllSaves()
	{
	}

	[Token(Token = "0x600529E")]
	[Address(RVA = "0xE4B910", Offset = "0xE4A710", Length = "0x120")]
	public static void LoadData(string name)
	{
	}

	[Token(Token = "0x600529F")]
	[Address(RVA = "0xE4BA40", Offset = "0xE4A840", Length = "0x322")]
	public static void SaveData(string name, string displayName, string data)
	{
	}

	[Token(Token = "0x60052A0")]
	[Address(RVA = "0xE4BD70", Offset = "0xE4AB70", Length = "0x100")]
	public static void DataExists(string name)
	{
	}

	[Token(Token = "0x60052A1")]
	[Address(RVA = "0xE4BE80", Offset = "0xE4AC80", Length = "0x5F8")]
	public static void SaveGameDataProcess()
	{
	}

	[Token(Token = "0x60052A2")]
	[Address(RVA = "0xE4C480", Offset = "0xE4B280", Length = "0xEE")]
	public static bool IsSaving()
	{
		return false;
	}

	[Token(Token = "0x60052A3")]
	[Address(RVA = "0xE4C570", Offset = "0xE4B370", Length = "0xD8")]
	public static bool IsAnyOperationPending()
	{
		return false;
	}

	[Token(Token = "0x60052A4")]
	[Address(RVA = "0xE4C650", Offset = "0xE4B450", Length = "0x13A")]
	public static int GetNumPendingOperations(SaveGameOperationType opType, string pattern)
	{
		return 0;
	}

	[Token(Token = "0x60052A5")]
	[Address(RVA = "0xE4C790", Offset = "0xE4B590", Length = "0xFB")]
	public static bool AsyncOperationInProgress(SaveGameOperationType opType, string pattern)
	{
		return false;
	}

	[Token(Token = "0x60052A6")]
	[Address(RVA = "0xE4C890", Offset = "0xE4B690", Length = "0x94")]
	public static void ClearLoadingPriorityPattern()
	{
	}

	[Token(Token = "0x60052A7")]
	[Address(RVA = "0xE4C930", Offset = "0xE4B730", Length = "0xBE")]
	public static void AddLoadingPriorityPattern(string pattern)
	{
	}

	[Token(Token = "0x60052A8")]
	[Address(RVA = "0xE4C9F0", Offset = "0xE4B7F0", Length = "0x18B")]
	private static bool DoesNameMatchPattern(string name)
	{
		return false;
	}

	[Token(Token = "0x60052A9")]
	[Address(RVA = "0xE4CB80", Offset = "0xE4B980", Length = "0x63")]
	private static SaveGameOperationReturnValue DoSaveOperation(SaveGameOperationData opData)
	{
		return default(SaveGameOperationReturnValue);
	}

	[Token(Token = "0x60052AA")]
	[Address(RVA = "0xE4CBF0", Offset = "0xE4B9F0", Length = "0x58")]
	private static SaveGameOperationReturnValue DoLoadOperation(SaveGameOperationData opData)
	{
		return default(SaveGameOperationReturnValue);
	}

	[Token(Token = "0x60052AB")]
	[Address(RVA = "0xE4CC50", Offset = "0xE4BA50", Length = "0x45")]
	private static SaveGameOperationReturnValue DoLoadAllOperation(SaveGameOperationData opData)
	{
		return default(SaveGameOperationReturnValue);
	}

	[Token(Token = "0x60052AC")]
	[Address(RVA = "0xE4CCA0", Offset = "0xE4BAA0", Length = "0x58")]
	private static SaveGameOperationReturnValue DoDeleteOperation(SaveGameOperationData opData)
	{
		return default(SaveGameOperationReturnValue);
	}

	[Token(Token = "0x60052AD")]
	[Address(RVA = "0xE4CD00", Offset = "0xE4BB00", Length = "0x58")]
	private static SaveGameOperationReturnValue DoExistsOperation(SaveGameOperationData opData)
	{
		return default(SaveGameOperationReturnValue);
	}

	[Token(Token = "0x60052AE")]
	[Address(RVA = "0xE4CD60", Offset = "0xE4BB60", Length = "0x164")]
	private static bool SaveGameOperationAlreadyPending(SaveGameOperationType operationType, string name)
	{
		return false;
	}

	[Token(Token = "0x60052AF")]
	[Address(RVA = "0xE4CED0", Offset = "0xE4BCD0", Length = "0x280")]
	private static SaveGameOperationData GetNextPendingSaveGameOperation()
	{
		return default(SaveGameOperationData);
	}

	[Token(Token = "0x60052B0")]
	[Address(RVA = "0xE4D160", Offset = "0xE4BF60", Length = "0x1AA")]
	private static void CullPendingSaveGameOperations(List<string> m_Whitelist)
	{
	}

	[Token(Token = "0x60052B1")]
	[Address(RVA = "0xE4D310", Offset = "0xE4C110", Length = "0x28F")]
	private static void MaybeDisplayErrorNotification(SaveGameOperationData opData, SaveGameOperationReturnValue returnValue)
	{
	}

	[Token(Token = "0x60052B2")]
	[Address(RVA = "0xE4D5A0", Offset = "0xE4C3A0", Length = "0xD6")]
	private static void UpdateCurrentAsyncOperationTime()
	{
	}

	[Token(Token = "0x60052B3")]
	[Address(RVA = "0xE4D680", Offset = "0xE4C480", Length = "0x12E")]
	public static void MarkCurrentAsyncOperationFinished()
	{
	}

	[Token(Token = "0x60052B4")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public SaveGameData()
	{
	}
}
