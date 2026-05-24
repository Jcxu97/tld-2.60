using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[RequireComponent(typeof(BaseAi))]
[Token(Token = "0x200017B")]
public class PackAnimal : MonoBehaviour
{
	[Token(Token = "0x4000DB0")]
	[FieldOffset(Offset = "0x20")]
	public bool m_CanBeLeader;

	[Token(Token = "0x4000DB1")]
	[FieldOffset(Offset = "0x21")]
	public bool m_ShouldStayWithinRadiusOfStartLocation;

	[Token(Token = "0x4000DB2")]
	[FieldOffset(Offset = "0x22")]
	public bool m_UsePackDetection;

	[Token(Token = "0x4000DB3")]
	[FieldOffset(Offset = "0x28")]
	public string m_GroupId;

	[Range(0.1f, 1000f)]
	[Token(Token = "0x4000DB4")]
	[FieldOffset(Offset = "0x30")]
	public float m_StayWithinRadius;

	[Range(0.1f, 1000f)]
	[Token(Token = "0x4000DB5")]
	[FieldOffset(Offset = "0x34")]
	public float m_StayWithinMinRadius;

	[Tooltip("Keep PackManager from spamming force attack testing every frame for performance considerations. base time + random(variance)")]
	[Range(0f, 3f)]
	[Token(Token = "0x4000DB6")]
	[FieldOffset(Offset = "0x38")]
	public float m_CheckForceAttackTime;

	[Range(0f, 3f)]
	[Token(Token = "0x4000DB7")]
	[FieldOffset(Offset = "0x3C")]
	public float m_CheckForceAttackTimeVariance;

	[HideInInspector]
	[Token(Token = "0x4000DB8")]
	[FieldOffset(Offset = "0x40")]
	public PackMode m_PackMode;

	[HideInInspector]
	[Token(Token = "0x4000DB9")]
	[FieldOffset(Offset = "0x48")]
	public BaseAi m_BaseAi;

	[HideInInspector]
	[Token(Token = "0x4000DBA")]
	[FieldOffset(Offset = "0x50")]
	public PackAnimal m_GroupLeader;

	[HideInInspector]
	[Token(Token = "0x4000DBB")]
	[FieldOffset(Offset = "0x58")]
	public Vector3 m_StartLocation;

	[HideInInspector]
	[Token(Token = "0x4000DBC")]
	[FieldOffset(Offset = "0x64")]
	public float m_HoldGroundTime;

	[HideInInspector]
	[Token(Token = "0x4000DBD")]
	[FieldOffset(Offset = "0x68")]
	public float m_PackReformDelayTimer;

	[HideInInspector]
	[Token(Token = "0x4000DBE")]
	[FieldOffset(Offset = "0x6C")]
	public float m_CheckForceAttackTimer;

	[HideInInspector]
	[Token(Token = "0x4000DBF")]
	[FieldOffset(Offset = "0x70")]
	public Vector3 m_LastAreaMarkupQueryLocation;

	[HideInInspector]
	[Token(Token = "0x4000DC0")]
	[FieldOffset(Offset = "0x80")]
	public List<AreaMarkup> m_AreaMarkupList;

	[Token(Token = "0x6000E74")]
	[Address(RVA = "0x5F12D0", Offset = "0x5F00D0", Length = "0x3F")]
	public void EnablePackBehavior(bool enable)
	{
	}

	[Token(Token = "0x6000E75")]
	[Address(RVA = "0x5F1310", Offset = "0x5F0110", Length = "0xBD")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x6000E76")]
	[Address(RVA = "0x5F13D0", Offset = "0x5F01D0", Length = "0x87")]
	public void Deserialize(string text)
	{
	}

	[Token(Token = "0x6000E77")]
	[Address(RVA = "0x5F1460", Offset = "0x5F0260", Length = "0x8C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000E78")]
	[Address(RVA = "0x5F14F0", Offset = "0x5F02F0", Length = "0x27B")]
	private void Start()
	{
	}

	[Token(Token = "0x6000E79")]
	[Address(RVA = "0x5F1770", Offset = "0x5F0570", Length = "0x105")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000E7A")]
	[Address(RVA = "0x5F1880", Offset = "0x5F0680", Length = "0x104")]
	public PackAnimal()
	{
	}
}
