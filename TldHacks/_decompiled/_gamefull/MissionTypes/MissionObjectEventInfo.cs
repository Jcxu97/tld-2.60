using Cpp2ILInjected;

namespace MissionTypes;

[Token(Token = "0x2000D48")]
public class MissionObjectEventInfo
{
	[Token(Token = "0x4008346")]
	[FieldOffset(Offset = "0x10")]
	public string objectName;

	[Token(Token = "0x4008347")]
	[FieldOffset(Offset = "0x18")]
	public MissionObjectClass objectClass;

	[Token(Token = "0x4008348")]
	[FieldOffset(Offset = "0x20")]
	public string prefabType;

	[Token(Token = "0x600680C")]
	[Address(RVA = "0x105EBF0", Offset = "0x105D9F0", Length = "0xF9")]
	public MissionObjectEventInfo(MissionObjectIdentifier moi)
	{
	}

	[Token(Token = "0x600680D")]
	[Address(RVA = "0x105ECF0", Offset = "0x105DAF0", Length = "0xCA")]
	public MissionObjectEventInfo(string _prefabType)
	{
	}
}
