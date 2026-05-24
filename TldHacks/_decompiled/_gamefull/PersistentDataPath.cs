using Cpp2ILInjected;

[Token(Token = "0x20006FE")]
public class PersistentDataPath
{
	[Token(Token = "0x4004A37")]
	private const string SURVIVAL_PATH = "Survival";

	[Token(Token = "0x4004A38")]
	private const string NOSYNC_ADD = "NoSync";

	[Token(Token = "0x4004A39")]
	public static string m_PathSeparator;

	[Token(Token = "0x4004A3A")]
	public static string m_Path;

	[Token(Token = "0x4004A3B")]
	public static string m_PathNoSync;

	[Token(Token = "0x4004A3C")]
	public static string m_PathSurvival;

	[Token(Token = "0x4004A3D")]
	public static string m_PathNoSyncSurvival;

	[Token(Token = "0x6003D58")]
	[Address(RVA = "0xB93A00", Offset = "0xB92800", Length = "0x452")]
	public static void Init()
	{
	}

	[Token(Token = "0x6003D59")]
	[Address(RVA = "0xB93E60", Offset = "0xB92C60", Length = "0x106")]
	private static void CreatePersistentDataFolders()
	{
	}

	[Token(Token = "0x6003D5A")]
	[Address(RVA = "0xB93F70", Offset = "0xB92D70", Length = "0xE9")]
	private static string GetPersistentDataPath()
	{
		return null;
	}

	[Token(Token = "0x6003D5B")]
	[Address(RVA = "0xB93F70", Offset = "0xB92D70", Length = "0xE9")]
	private static string GetPersistentDataPathForHardDrive()
	{
		return null;
	}

	[Token(Token = "0x6003D5C")]
	[Address(RVA = "0xB94060", Offset = "0xB92E60", Length = "0x8D")]
	public static string GetBaseFolderPath()
	{
		return null;
	}

	[Token(Token = "0x6003D5D")]
	[Address(RVA = "0xB940F0", Offset = "0xB92EF0", Length = "0x31")]
	private static string GetPathModifier()
	{
		return null;
	}

	[Token(Token = "0x6003D5E")]
	[Address(RVA = "0xB94130", Offset = "0xB92F30", Length = "0xB5")]
	private static void TryCreateDir(string path)
	{
	}

	[Token(Token = "0x6003D5F")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public PersistentDataPath()
	{
	}
}
