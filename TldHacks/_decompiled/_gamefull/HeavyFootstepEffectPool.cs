using System;
using Cpp2ILInjected;

[Token(Token = "0x20002DF")]
public class HeavyFootstepEffectPool : EffectPool<HeavyFootstepEffectType>
{
	[Serializable]
	[Token(Token = "0x20002E0")]
	public class SerializableSpawnGroup : SerializableSpawnGroupGeneric
	{
		[Token(Token = "0x6001838")]
		[Address(RVA = "0x6E3780", Offset = "0x6E2580", Length = "0x2A")]
		public SerializableSpawnGroup()
		{
		}
	}

	[Token(Token = "0x4001976")]
	[FieldOffset(Offset = "0x30")]
	public SerializableSpawnGroup[] m_EffectGroupsSerialized;

	[Token(Token = "0x6001835")]
	[Address(RVA = "0x457420", Offset = "0x456220", Length = "0x5")]
	protected override SerializableSpawnGroupGeneric[] GetSerializedGroups()
	{
		return null;
	}

	[Token(Token = "0x6001836")]
	[Address(RVA = "0x6E36D0", Offset = "0x6E24D0", Length = "0x3E")]
	protected override void InternalUpdate()
	{
	}

	[Token(Token = "0x6001837")]
	[Address(RVA = "0x6E3710", Offset = "0x6E2510", Length = "0x64")]
	public HeavyFootstepEffectPool()
	{
	}
}
