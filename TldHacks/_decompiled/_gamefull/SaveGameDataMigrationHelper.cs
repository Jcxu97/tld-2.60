using Cpp2ILInjected;
using TLD.SaveState;

[Token(Token = "0x2000915")]
public class SaveGameDataMigrationHelper
{
	[Token(Token = "0x60052B6")]
	[Address(RVA = "0xE4DA30", Offset = "0xE4C830", Length = "0xBBA")]
	public static void MigrateFullProfileStateToCurrent(ProfileState migratedProfileState)
	{
	}

	[Token(Token = "0x60052B7")]
	[Address(RVA = "0xE4E5F0", Offset = "0xE4D3F0", Length = "0x29")]
	public static void MigrateVersionedProfileStateToCurrent(ProfileState migratedProfileState)
	{
	}

	[Token(Token = "0x60052B8")]
	[Address(RVA = "0xE4E620", Offset = "0xE4D420", Length = "0x18A")]
	private static void UpdateProfileChallengeData(ProfileState migratedProfileState)
	{
	}

	[Token(Token = "0x60052B9")]
	[Address(RVA = "0xE4E7B0", Offset = "0xE4D5B0", Length = "0x3A1")]
	private static void MigrateBestTime(string key, float validationTime)
	{
	}

	[Token(Token = "0x60052BA")]
	[Address(RVA = "0xE4EB60", Offset = "0xE4D960", Length = "0x3DE")]
	private static void UpdateProfileBadges(ProfileState migratedProfileState)
	{
	}

	[Token(Token = "0x60052BB")]
	[Address(RVA = "0xE4EF40", Offset = "0xE4DD40", Length = "0x118")]
	private static void UpdateProfileFeatData(ProfileState validationState)
	{
	}

	[Token(Token = "0x60052BC")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public SaveGameDataMigrationHelper()
	{
	}
}
