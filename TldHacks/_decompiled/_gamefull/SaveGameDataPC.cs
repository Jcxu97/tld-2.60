using System.Collections.Generic;
using Cpp2ILInjected;

[Token(Token = "0x2000916")]
public class SaveGameDataPC
{
	[Token(Token = "0x2000917")]
	private enum ValidationStep
	{
		[Token(Token = "0x4005EA0")]
		Prepare,
		[Token(Token = "0x4005EA1")]
		Validate,
		[Token(Token = "0x4005EA2")]
		Cleanup,
		[Token(Token = "0x4005EA3")]
		Done
	}

	[Token(Token = "0x2000918")]
	private struct VersionedDataInfo
	{
		[Token(Token = "0x4005EA4")]
		[FieldOffset(Offset = "0x0")]
		public string m_Extension;

		[Token(Token = "0x4005EA5")]
		[FieldOffset(Offset = "0x8")]
		public string m_Path;

		[Token(Token = "0x4005EA6")]
		[FieldOffset(Offset = "0x10")]
		public int m_Revision;

		[Token(Token = "0x60052CE")]
		[Address(RVA = "0xE513B0", Offset = "0xE501B0", Length = "0x189")]
		public VersionedDataInfo(string path)
		{
			m_Extension = null;
			m_Path = null;
			m_Revision = 0;
		}
	}

	[Token(Token = "0x4005E9C")]
	private static ValidationStep s_ValidationStep;

	[Token(Token = "0x4005E9D")]
	private static readonly List<string> s_ValidationFiles;

	[Token(Token = "0x4005E9E")]
	private static int s_ValidationIndex;

	[Token(Token = "0x60052BD")]
	[Address(RVA = "0xE4F060", Offset = "0xE4DE60", Length = "0x76")]
	public static SaveGameOperationReturnValue DeleteData(string name)
	{
		return default(SaveGameOperationReturnValue);
	}

	[Token(Token = "0x60052BE")]
	[Address(RVA = "0xE4F0E0", Offset = "0xE4DEE0", Length = "0xFC")]
	public static SaveGameOperationReturnValue LoadData(string name)
	{
		return default(SaveGameOperationReturnValue);
	}

	[Token(Token = "0x60052BF")]
	[Address(RVA = "0xE4F1E0", Offset = "0xE4DFE0", Length = "0x1B7")]
	private static bool LoadDataFromPath(string path, out string data, out int compressedSizeBytes)
	{
		data = null;
		compressedSizeBytes = default(int);
		return false;
	}

	[Token(Token = "0x60052C0")]
	[Address(RVA = "0xE4F3A0", Offset = "0xE4E1A0", Length = "0x548")]
	public static SaveGameOperationReturnValue LoadAllSaves()
	{
		return default(SaveGameOperationReturnValue);
	}

	[Token(Token = "0x60052C1")]
	[Address(RVA = "0xE4F8F0", Offset = "0xE4E6F0", Length = "0xAB")]
	public static SaveGameOperationReturnValue SaveData(string name, string data)
	{
		return default(SaveGameOperationReturnValue);
	}

	[Token(Token = "0x60052C2")]
	[Address(RVA = "0xE4F9A0", Offset = "0xE4E7A0", Length = "0x369")]
	public static SaveGameOperationReturnValue DataExists(string name)
	{
		return default(SaveGameOperationReturnValue);
	}

	[Token(Token = "0x60052C3")]
	[Address(RVA = "0x4A2140", Offset = "0x4A0F40", Length = "0x3")]
	public static bool IsBusy()
	{
		return false;
	}

	[Token(Token = "0x60052C4")]
	[Address(RVA = "0xE4FD10", Offset = "0xE4EB10", Length = "0x33F")]
	private static int CompressAndWriteString(string pathAndFilename, string dataAsString)
	{
		return 0;
	}

	[Token(Token = "0x60052C5")]
	[Address(RVA = "0xE50050", Offset = "0xE4EE50", Length = "0x167")]
	private static string GetFullPath(string name)
	{
		return null;
	}

	[Token(Token = "0x60052C6")]
	[Address(RVA = "0xE501C0", Offset = "0xE4EFC0", Length = "0x4B2")]
	public static void InitializeUserProfile()
	{
	}

	[Token(Token = "0x60052C7")]
	[Address(RVA = "0xE50680", Offset = "0xE4F480", Length = "0xB8")]
	private static bool UpdateTargetFile(string targetFilePath, string folderSearchPath, string startsWith, int currentRevision)
	{
		return false;
	}

	[Token(Token = "0x60052C8")]
	[Address(RVA = "0xE50740", Offset = "0xE4F540", Length = "0x385")]
	private static bool TryFindCandidate(string folderSearchPath, string startsWith, int currentRevision, out VersionedDataInfo candidate)
	{
		candidate = default(VersionedDataInfo);
		return false;
	}

	[Token(Token = "0x60052C9")]
	[Address(RVA = "0xE50AD0", Offset = "0xE4F8D0", Length = "0x56")]
	public static bool IsValidationActive()
	{
		return false;
	}

	[Token(Token = "0x60052CA")]
	[Address(RVA = "0xE50B30", Offset = "0xE4F930", Length = "0x63B")]
	public static void ValidateUserProfile()
	{
	}

	[Token(Token = "0x60052CB")]
	[Address(RVA = "0xE51170", Offset = "0xE4FF70", Length = "0x14D")]
	private static void UpdateProfileAgainstFile(string path, int currentVersion)
	{
	}

	[Token(Token = "0x60052CC")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public SaveGameDataPC()
	{
	}
}
