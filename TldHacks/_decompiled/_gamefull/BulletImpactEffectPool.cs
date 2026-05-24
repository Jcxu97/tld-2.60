using System;
using Cpp2ILInjected;

[Token(Token = "0x20002DC")]
public class BulletImpactEffectPool : EffectPool<BulletImpactEffectType>
{
	[Serializable]
	[Token(Token = "0x20002DD")]
	public class SerializableSpawnGroup : SerializableSpawnGroupGeneric
	{
		[Token(Token = "0x6001834")]
		[Address(RVA = "0x6E36A0", Offset = "0x6E24A0", Length = "0x2A")]
		public SerializableSpawnGroup()
		{
		}
	}

	[Token(Token = "0x400196B")]
	[FieldOffset(Offset = "0x30")]
	public SerializableSpawnGroup[] m_EffectGroupsSerialized;

	[Token(Token = "0x6001831")]
	[Address(RVA = "0x457420", Offset = "0x456220", Length = "0x5")]
	protected override SerializableSpawnGroupGeneric[] GetSerializedGroups()
	{
		return null;
	}

	[Token(Token = "0x6001832")]
	[Address(RVA = "0x6E35F0", Offset = "0x6E23F0", Length = "0x3E")]
	protected override void InternalUpdate()
	{
	}

	[Token(Token = "0x6001833")]
	[Address(RVA = "0x6E3630", Offset = "0x6E2430", Length = "0x64")]
	public BulletImpactEffectPool()
	{
	}
}
