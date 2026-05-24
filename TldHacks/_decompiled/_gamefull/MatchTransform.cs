using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20001A0")]
public class MatchTransform : MonoBehaviour
{
	[Token(Token = "0x4000EDD")]
	[FieldOffset(Offset = "0x20")]
	public GameObject m_Target;

	[Token(Token = "0x4000EDE")]
	private static List<MatchTransform> s_MatchTransformList;

	[Token(Token = "0x4000EDF")]
	private static List<MatchTransform> s_DeadWildlife;

	[Token(Token = "0x4000EE0")]
	private static int s_CollidersEnabledCount;

	[Token(Token = "0x4000EE1")]
	[FieldOffset(Offset = "0x28")]
	private BaseAi m_BaseAi;

	[Token(Token = "0x4000EE2")]
	[FieldOffset(Offset = "0x30")]
	private Collider m_Collider;

	[Token(Token = "0x4000EE3")]
	[FieldOffset(Offset = "0x38")]
	private Transform m_CachedThisTransform;

	[Token(Token = "0x4000EE4")]
	[FieldOffset(Offset = "0x40")]
	private Transform m_CachedTargetTransform;

	[Token(Token = "0x6000F6B")]
	[Address(RVA = "0x613410", Offset = "0x612210", Length = "0x27E")]
	public void Awake()
	{
	}

	[Token(Token = "0x6000F6C")]
	[Address(RVA = "0x613690", Offset = "0x612490", Length = "0xC7")]
	public void OnEnable()
	{
	}

	[Token(Token = "0x6000F6D")]
	[Address(RVA = "0x613760", Offset = "0x612560", Length = "0x82")]
	public void OnDisable()
	{
	}

	[Token(Token = "0x6000F6E")]
	[Address(RVA = "0x6137F0", Offset = "0x6125F0", Length = "0x52E")]
	private int DoLateUpdate()
	{
		return 0;
	}

	[Token(Token = "0x6000F6F")]
	[Address(RVA = "0x613D20", Offset = "0x612B20", Length = "0x1CC")]
	private void UpdateColliderState()
	{
	}

	[Token(Token = "0x6000F70")]
	[Address(RVA = "0x613EF0", Offset = "0x612CF0", Length = "0x499")]
	public static int LateUpdateAll()
	{
		return 0;
	}

	[Token(Token = "0x6000F71")]
	[Address(RVA = "0x614390", Offset = "0x613190", Length = "0x57")]
	public static bool AreColliderEnabled()
	{
		return false;
	}

	[Token(Token = "0x6000F72")]
	[Address(RVA = "0x6143F0", Offset = "0x6131F0", Length = "0x3C7")]
	public static void EnableCollidersForAllActive(bool enable)
	{
	}

	[Token(Token = "0x6000F73")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public MatchTransform()
	{
	}
}
