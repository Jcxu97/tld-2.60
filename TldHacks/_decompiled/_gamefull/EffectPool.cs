using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20002D0")]
public abstract class EffectPool<T> : MonoBehaviour
{
	[Token(Token = "0x20002D1")]
	public struct EffectHandle
	{
		[Token(Token = "0x4001933")]
		[FieldOffset(Offset = "0x0")]
		private readonly int m_Value;

		[Token(Token = "0x4001934")]
		[FieldOffset(Offset = "0x0")]
		public readonly int m_PoolHashCode;

		[Token(Token = "0x4001935")]
		[FieldOffset(Offset = "0x0")]
		public readonly T m_EffectType;

		[Token(Token = "0x6001811")]
		[Address(RVA = "0x21FCCE0", Offset = "0x21FBAE0", Length = "0xB")]
		public EffectHandle(int id, int poolHashCode, T effectType)
		{
			m_Value = 0;
			m_PoolHashCode = 0;
			m_EffectType = default(T);
		}

		[Token(Token = "0x6001812")]
		[Address(RVA = "0x12BBC70", Offset = "0x12BAA70", Length = "0x3")]
		public override int GetHashCode()
		{
			return 0;
		}

		[Token(Token = "0x6001813")]
		[Address(RVA = "0x270AA10", Offset = "0x2709810", Length = "0x13")]
		public bool Equals(EffectHandle other)
		{
			return false;
		}

		[Token(Token = "0x6001814")]
		[Address(RVA = "0x270AA30", Offset = "0x2709830", Length = "0x149")]
		public override bool Equals(object obj)
		{
			return false;
		}

		[Token(Token = "0x6001815")]
		[Address(RVA = "0x270AB80", Offset = "0x2709980", Length = "0x61")]
		public static bool operator ==(EffectHandle a, EffectHandle b)
		{
			return false;
		}

		[Token(Token = "0x6001816")]
		[Address(RVA = "0x270ABF0", Offset = "0x27099F0", Length = "0x61")]
		public static bool operator !=(EffectHandle a, EffectHandle b)
		{
			return false;
		}
	}

	[Token(Token = "0x20002D2")]
	private class InstanceInfo
	{
		[Token(Token = "0x4001936")]
		[FieldOffset(Offset = "0x0")]
		public readonly EffectHandle m_InstanceHandle;

		[Token(Token = "0x4001937")]
		[FieldOffset(Offset = "0x0")]
		public GameObject m_Instance;

		[Token(Token = "0x4001938")]
		[FieldOffset(Offset = "0x0")]
		public bool m_IsActive;

		[Token(Token = "0x4001939")]
		[FieldOffset(Offset = "0x0")]
		public ParticleSystemInfo m_ParticleSystemInfo;

		[Token(Token = "0x6001817")]
		[Address(RVA = "0x1B21DA0", Offset = "0x1B20BA0", Length = "0x10")]
		public InstanceInfo(EffectHandle instanceHandle)
		{
		}
	}

	[Token(Token = "0x20002D3")]
	private struct ParticleSystemInfo
	{
		[Token(Token = "0x400193A")]
		[FieldOffset(Offset = "0x0")]
		public readonly EffectHandle m_EffectHandle;

		[Token(Token = "0x400193B")]
		[FieldOffset(Offset = "0x0")]
		public readonly bool m_IsLooping;

		[Token(Token = "0x400193C")]
		[FieldOffset(Offset = "0x0")]
		public readonly float m_Duration;

		[Token(Token = "0x400193D")]
		[FieldOffset(Offset = "0x0")]
		public readonly bool m_HasParticleSystem;

		[Token(Token = "0x400193E")]
		[FieldOffset(Offset = "0x0")]
		private readonly ParticleSystem[] m_ParticleSystems;

		[Token(Token = "0x6001818")]
		[Address(RVA = "0x1E68250", Offset = "0x1E67050", Length = "0x74")]
		public ParticleSystemInfo(EffectHandle effectHandle, bool hasParticleSystem, float duration, bool isLooping, ParticleSystem[] particleSystems)
		{
			m_EffectHandle = default(EffectHandle);
			m_IsLooping = false;
			m_Duration = 0f;
			m_HasParticleSystem = false;
			m_ParticleSystems = null;
		}

		[Token(Token = "0x6001819")]
		[Address(RVA = "0x1E682D0", Offset = "0x1E670D0", Length = "0x140")]
		public bool IsAlive()
		{
			return false;
		}
	}

	[Token(Token = "0x20002D4")]
	public class SerializableSpawnGroupGeneric
	{
		[Token(Token = "0x400193F")]
		[FieldOffset(Offset = "0x0")]
		public int m_InstancesCount;

		[Token(Token = "0x4001940")]
		[FieldOffset(Offset = "0x0")]
		public GameObject m_PrefabObject;

		[Token(Token = "0x4001941")]
		[FieldOffset(Offset = "0x0")]
		public T m_EffectType;

		[Token(Token = "0x600181A")]
		[Address(RVA = "0x4571E0", Offset = "0x455FE0", Length = "0x4")]
		public T GetEffectType()
		{
			return default(T);
		}

		[Token(Token = "0x600181B")]
		[Address(RVA = "0x40E0A0", Offset = "0x40CEA0", Length = "0x4")]
		public int GetInstancesCount()
		{
			return 0;
		}

		[Token(Token = "0x600181C")]
		[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
		public GameObject GetPrefabObject()
		{
			return null;
		}

		[Token(Token = "0x600181D")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public SerializableSpawnGroupGeneric()
		{
		}
	}

	[Token(Token = "0x20002D5")]
	private class SpawnGroup
	{
		[Token(Token = "0x4001942")]
		[FieldOffset(Offset = "0x0")]
		public List<InstanceInfo> m_Instances;

		[Token(Token = "0x4001943")]
		[FieldOffset(Offset = "0x0")]
		public int m_InstancesCount;

		[Token(Token = "0x4001944")]
		[FieldOffset(Offset = "0x0")]
		public readonly T m_EffectType;

		[Token(Token = "0x4001945")]
		[FieldOffset(Offset = "0x0")]
		public readonly int m_PoolHashCode;

		[Token(Token = "0x600181E")]
		[Address(RVA = "0x2042750", Offset = "0x2041550", Length = "0x8")]
		public SpawnGroup(T effectType, int poolHashCode)
		{
		}
	}

	[Token(Token = "0x400192E")]
	private const int MAX_INSTANCES_PER_SPAWNGROUP = 1000;

	[Token(Token = "0x400192F")]
	private const int INVALID_ID = -1;

	[Token(Token = "0x4001930")]
	private static readonly EffectHandle INVALID_HANDLE;

	[Token(Token = "0x4001931")]
	[FieldOffset(Offset = "0x0")]
	private List<SpawnGroup> m_EffectGroups;

	[Token(Token = "0x4001932")]
	[FieldOffset(Offset = "0x0")]
	private List<ParticleSystemInfo> m_WatchedEmitters;

	[Token(Token = "0x60017F7")]
	protected abstract SerializableSpawnGroupGeneric[] GetSerializedGroups();

	[Token(Token = "0x60017F8")]
	[Address(RVA = "0x270B430", Offset = "0x270A230", Length = "0x129")]
	public void LoadEffects()
	{
	}

	[Token(Token = "0x60017F9")]
	[Address(RVA = "0x270B560", Offset = "0x270A360", Length = "0x25A")]
	public void UnLoadEffects()
	{
	}

	[Token(Token = "0x60017FA")]
	[Address(RVA = "0x270B7C0", Offset = "0x270A5C0", Length = "0x52D")]
	public bool SpawnUntilParticlesDone(T effectType, Vector3 position, Quaternion rotation)
	{
		return false;
	}

	[Token(Token = "0x60017FB")]
	[Address(RVA = "0x270BCF0", Offset = "0x270AAF0", Length = "0x84")]
	public EffectHandle Spawn(T effectType, Vector3 position, Quaternion rotation)
	{
		return default(EffectHandle);
	}

	[Token(Token = "0x60017FC")]
	[Address(RVA = "0x270BD80", Offset = "0x270AB80", Length = "0x16D")]
	public void DeSpawn(EffectHandle effectHandle)
	{
	}

	[Token(Token = "0x60017FD")]
	[Address(RVA = "0x270BEF0", Offset = "0x270ACF0", Length = "0x101")]
	protected virtual void InternalUpdate()
	{
	}

	[Token(Token = "0x60017FE")]
	[Address(RVA = "0x270C000", Offset = "0x270AE00", Length = "0x11")]
	protected void Update()
	{
	}

	[Token(Token = "0x60017FF")]
	[Address(RVA = "0x270C020", Offset = "0x270AE20", Length = "0xF2")]
	private void UpdateWatchedEmitters()
	{
	}

	[Token(Token = "0x6001800")]
	[Address(RVA = "0x270C120", Offset = "0x270AF20", Length = "0x113")]
	private void RemoveWatchedEmitter(EffectHandle effectHandle)
	{
	}

	[Token(Token = "0x6001801")]
	[Address(RVA = "0x270C240", Offset = "0x270B040", Length = "0x9A")]
	private bool IsNonLoopingParticleEffect(T effectType)
	{
		return false;
	}

	[Token(Token = "0x6001802")]
	[Address(RVA = "0x270C2E0", Offset = "0x270B0E0", Length = "0x43A")]
	private EffectHandle ActivateInstance(T effectType, Vector3 position, Quaternion rotation)
	{
		return default(EffectHandle);
	}

	[Token(Token = "0x6001803")]
	[Address(RVA = "0x270C720", Offset = "0x270B520", Length = "0x438")]
	private void ReleaseInstance(EffectHandle effectHandle)
	{
	}

	[Token(Token = "0x6001804")]
	[Address(RVA = "0x270CB60", Offset = "0x270B960", Length = "0x12")]
	private int GetGroupIndexFromEffectHandle(EffectHandle id)
	{
		return 0;
	}

	[Token(Token = "0x6001805")]
	[Address(RVA = "0x270CB80", Offset = "0x270B980", Length = "0x22")]
	private int GetInstanceIndexFromEffectHandle(EffectHandle effectHandle)
	{
		return 0;
	}

	[Token(Token = "0x6001806")]
	[Address(RVA = "0x270CBB0", Offset = "0x270B9B0", Length = "0x1E")]
	private EffectHandle GetEffectHandleFromGroupAndInstanceIndex(int indexGroup, int indexInstance, int poolHashCode, T effectType)
	{
		return default(EffectHandle);
	}

	[Token(Token = "0x6001807")]
	[Address(RVA = "0x270CBD0", Offset = "0x270B9D0", Length = "0x237")]
	private InstanceInfo CreateInstanceInfo(EffectHandle instanceHandle, SerializableSpawnGroupGeneric serializableSpawnGroup)
	{
		return null;
	}

	[Token(Token = "0x6001808")]
	[Address(RVA = "0x270CE10", Offset = "0x270BC10", Length = "0x96")]
	private void DeleteInstanceInfo(InstanceInfo instanceInfo)
	{
	}

	[Token(Token = "0x6001809")]
	[Address(RVA = "0x270CEB0", Offset = "0x270BCB0", Length = "0xB5")]
	private InstanceInfo GetInstanceInfo(EffectHandle effectHandle, List<SpawnGroup> groups)
	{
		return null;
	}

	[Token(Token = "0x600180A")]
	[Address(RVA = "0x270CF70", Offset = "0x270BD70", Length = "0x177")]
	private InstanceInfo FindAvailableInstanceInfo(SpawnGroup spawnGroup, T effectType)
	{
		return null;
	}

	[Token(Token = "0x600180B")]
	[Address(RVA = "0x270D0F0", Offset = "0x270BEF0", Length = "0x316")]
	private ParticleSystemInfo ComputeParticleSystemInfo(InstanceInfo instanceInfo)
	{
		return default(ParticleSystemInfo);
	}

	[Token(Token = "0x600180C")]
	[Address(RVA = "0x270D410", Offset = "0x270C210", Length = "0x207")]
	private SpawnGroup CreateSpawnGroup(SerializableSpawnGroupGeneric serializableSpawnGroup, int poolHashCode, int groupIndex)
	{
		return null;
	}

	[Token(Token = "0x600180D")]
	[Address(RVA = "0x270D620", Offset = "0x270C420", Length = "0x1A8")]
	private void DeleteSpawnGroup(SpawnGroup spawnGroup)
	{
	}

	[Token(Token = "0x600180E")]
	[Address(RVA = "0x270D7D0", Offset = "0x270C5D0", Length = "0x12C")]
	private SpawnGroup GetSpawnGroup(T effectType, List<SpawnGroup> groups)
	{
		return null;
	}

	[Token(Token = "0x600180F")]
	[Address(RVA = "0x270D900", Offset = "0x270C700", Length = "0x1A4")]
	protected EffectPool()
	{
	}
}
