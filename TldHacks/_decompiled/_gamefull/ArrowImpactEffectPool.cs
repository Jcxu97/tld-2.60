using System;
using Cpp2ILInjected;

[Token(Token = "0x20002D9")]
public class ArrowImpactEffectPool : EffectPool<ArrowImpactEffectType>
{
	[Serializable]
	[Token(Token = "0x20002DA")]
	public class SerializableSpawnGroup : SerializableSpawnGroupGeneric
	{
		[Token(Token = "0x6001830")]
		[Address(RVA = "0x6E35C0", Offset = "0x6E23C0", Length = "0x2A")]
		public SerializableSpawnGroup()
		{
		}
	}

	[Token(Token = "0x4001960")]
	[FieldOffset(Offset = "0x30")]
	public SerializableSpawnGroup[] m_EffectGroupsSerialized;

	[Token(Token = "0x600182D")]
	[Address(RVA = "0x457420", Offset = "0x456220", Length = "0x5")]
	protected override SerializableSpawnGroupGeneric[] GetSerializedGroups()
	{
		return null;
	}

	[Token(Token = "0x600182E")]
	[Address(RVA = "0x6E3510", Offset = "0x6E2310", Length = "0x3E")]
	protected override void InternalUpdate()
	{
	}

	[Token(Token = "0x600182F")]
	[Address(RVA = "0x6E3550", Offset = "0x6E2350", Length = "0x64")]
	public ArrowImpactEffectPool()
	{
	}
}
