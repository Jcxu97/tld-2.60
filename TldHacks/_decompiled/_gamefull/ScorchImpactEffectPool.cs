using System;
using Cpp2ILInjected;

[Token(Token = "0x20002E2")]
public class ScorchImpactEffectPool : EffectPool<ScorchImpactEffectType>
{
	[Serializable]
	[Token(Token = "0x20002E3")]
	public class SerializableSpawnGroup : SerializableSpawnGroupGeneric
	{
		[Token(Token = "0x600183C")]
		[Address(RVA = "0x6E3860", Offset = "0x6E2660", Length = "0x2A")]
		public SerializableSpawnGroup()
		{
		}
	}

	[Token(Token = "0x4001981")]
	[FieldOffset(Offset = "0x30")]
	public SerializableSpawnGroup[] m_EffectGroupsSerialized;

	[Token(Token = "0x6001839")]
	[Address(RVA = "0x457420", Offset = "0x456220", Length = "0x5")]
	protected override SerializableSpawnGroupGeneric[] GetSerializedGroups()
	{
		return null;
	}

	[Token(Token = "0x600183A")]
	[Address(RVA = "0x6E37B0", Offset = "0x6E25B0", Length = "0x3E")]
	protected override void InternalUpdate()
	{
	}

	[Token(Token = "0x600183B")]
	[Address(RVA = "0x6E37F0", Offset = "0x6E25F0", Length = "0x64")]
	public ScorchImpactEffectPool()
	{
	}
}
