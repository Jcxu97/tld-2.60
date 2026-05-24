using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000418")]
public class EntityWard : MonoBehaviour
{
	[Token(Token = "0x2000419")]
	public enum State
	{
		[Token(Token = "0x40024F2")]
		Awake,
		[Token(Token = "0x40024F3")]
		Done,
		[Token(Token = "0x40024F4")]
		Ward
	}

	[Serializable]
	[Token(Token = "0x200041A")]
	public struct EntityWardSaveData
	{
		[Token(Token = "0x40024F5")]
		[FieldOffset(Offset = "0x0")]
		public string m_Guid;

		[Token(Token = "0x40024F6")]
		[FieldOffset(Offset = "0x8")]
		public State m_State;

		[Token(Token = "0x40024F7")]
		[FieldOffset(Offset = "0xC")]
		public float m_TimeRemaining;
	}

	[Serializable]
	[Token(Token = "0x200041B")]
	public class EntityWardListContainer
	{
		[Token(Token = "0x40024F8")]
		[FieldOffset(Offset = "0x10")]
		public List<EntityWardSaveData> m_List;

		[Token(Token = "0x6001EF4")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public EntityWardListContainer()
		{
		}
	}

	[Token(Token = "0x40024E7")]
	[FieldOffset(Offset = "0x20")]
	public float m_TriggerRadius;

	[Token(Token = "0x40024E8")]
	[FieldOffset(Offset = "0x24")]
	public float m_WardRadius;

	[Token(Token = "0x40024E9")]
	[FieldOffset(Offset = "0x28")]
	public float m_WardDurationSeconds;

	[Token(Token = "0x40024EA")]
	[FieldOffset(Offset = "0x30")]
	public GameObject m_NormalCampfireObject;

	[Token(Token = "0x40024EB")]
	[FieldOffset(Offset = "0x38")]
	private string m_Guid;

	[Token(Token = "0x40024EC")]
	[FieldOffset(Offset = "0x40")]
	private State m_State;

	[Token(Token = "0x40024ED")]
	[FieldOffset(Offset = "0x44")]
	private float m_TimeRemaining;

	[Token(Token = "0x40024EE")]
	[FieldOffset(Offset = "0x48")]
	private Fire m_Fire;

	[Token(Token = "0x40024EF")]
	private static List<EntityWard> s_EntityWards;

	[Token(Token = "0x40024F0")]
	private static EntityWardListContainer s_EntityWardContainer;

	[Token(Token = "0x6001EE5")]
	[Address(RVA = "0x7CF640", Offset = "0x7CE440", Length = "0x80")]
	public float GetTimeRemainingPct()
	{
		return 0f;
	}

	[Token(Token = "0x6001EE6")]
	[Address(RVA = "0x7CF6C0", Offset = "0x7CE4C0", Length = "0x82")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6001EE7")]
	[Address(RVA = "0x7CF750", Offset = "0x7CE550", Length = "0x755")]
	private void Start()
	{
	}

	[Token(Token = "0x6001EE8")]
	[Address(RVA = "0x7CFEB0", Offset = "0x7CECB0", Length = "0x12B")]
	private void Update()
	{
	}

	[Token(Token = "0x6001EE9")]
	[Address(RVA = "0x7CFFE0", Offset = "0x7CEDE0", Length = "0x42D")]
	public static void DeserializeAll(string serialized)
	{
	}

	[Token(Token = "0x6001EEA")]
	[Address(RVA = "0x7D0410", Offset = "0x7CF210", Length = "0x1E4")]
	public static EntityWard FindByGuid(string guid)
	{
		return null;
	}

	[Token(Token = "0x6001EEB")]
	[Address(RVA = "0x7D0600", Offset = "0x7CF400", Length = "0xFB")]
	public static void Reset()
	{
	}

	[Token(Token = "0x6001EEC")]
	[Address(RVA = "0x7D0700", Offset = "0x7CF500", Length = "0x42E")]
	public static string SerializeAll()
	{
		return null;
	}

	[Token(Token = "0x6001EED")]
	[Address(RVA = "0x7D0B30", Offset = "0x7CF930", Length = "0x214")]
	private void DisableWard()
	{
	}

	[Token(Token = "0x6001EEE")]
	[Address(RVA = "0x7D0D50", Offset = "0x7CFB50", Length = "0x3F2")]
	private void UpdateAwake()
	{
	}

	[Token(Token = "0x6001EEF")]
	[Address(RVA = "0x7D1150", Offset = "0x7CFF50", Length = "0x1E8")]
	private void UpdateWard()
	{
	}

	[Token(Token = "0x6001EF0")]
	[Address(RVA = "0x7D1340", Offset = "0x7D0140", Length = "0x184")]
	private void Deserialize(EntityWardSaveData data)
	{
	}

	[Token(Token = "0x6001EF1")]
	[Address(RVA = "0x7D14D0", Offset = "0x7D02D0", Length = "0x8F")]
	private EntityWardSaveData Serialize()
	{
		return default(EntityWardSaveData);
	}

	[Token(Token = "0x6001EF2")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public EntityWard()
	{
	}
}
