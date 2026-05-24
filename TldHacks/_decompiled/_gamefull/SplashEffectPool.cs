using System;
using Cpp2ILInjected;

[Token(Token = "0x20002E5")]
public class SplashEffectPool : EffectPool<SplashEffectType>
{
	[Serializable]
	[Token(Token = "0x20002E6")]
	public class SerializableSpawnGroup : SerializableSpawnGroupGeneric
	{
		[Token(Token = "0x6001840")]
		[Address(RVA = "0x6E3940", Offset = "0x6E2740", Length = "0x2A")]
		public SerializableSpawnGroup()
		{
		}
	}

	[Token(Token = "0x4001986")]
	[FieldOffset(Offset = "0x30")]
	public SerializableSpawnGroup[] m_EffectGroupsSerialized;

	[Token(Token = "0x600183D")]
	[Address(RVA = "0x457420", Offset = "0x456220", Length = "0x5")]
	protected override SerializableSpawnGroupGeneric[] GetSerializedGroups()
	{
		return null;
	}

	[Token(Token = "0x600183E")]
	[Address(RVA = "0x6E3890", Offset = "0x6E2690", Length = "0x3E")]
	protected override void InternalUpdate()
	{
	}

	[Token(Token = "0x600183F")]
	[Address(RVA = "0x6E38D0", Offset = "0x6E26D0", Length = "0x64")]
	public SplashEffectPool()
	{
	}
}
