using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20005B5")]
public class StickToGround : MonoBehaviour
{
	[Token(Token = "0x40034C1")]
	public static List<StickToGround> m_StickToGroundObjects;

	[Token(Token = "0x40034C2")]
	[FieldOffset(Offset = "0x20")]
	private bool m_StuckToGround;

	[Token(Token = "0x40034C3")]
	private static StickToGroundSaveData m_StickToGroundSaveData;

	[Token(Token = "0x6002C26")]
	[Address(RVA = "0x92EA50", Offset = "0x92D850", Length = "0x151")]
	private void Awake()
	{
	}

	[Token(Token = "0x6002C27")]
	[Address(RVA = "0x92EBB0", Offset = "0x92D9B0", Length = "0x82")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6002C28")]
	[Address(RVA = "0x92EC40", Offset = "0x92DA40", Length = "0x93")]
	public static void Reset()
	{
	}

	[Token(Token = "0x6002C29")]
	[Address(RVA = "0x92ECE0", Offset = "0x92DAE0", Length = "0x233")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x6002C2A")]
	[Address(RVA = "0x92EF20", Offset = "0x92DD20", Length = "0x3F4")]
	public static string SerializeAll()
	{
		return null;
	}

	[Token(Token = "0x6002C2B")]
	[Address(RVA = "0x92F320", Offset = "0x92E120", Length = "0x29A")]
	public static void DeserializeAll(string text)
	{
	}

	[Token(Token = "0x6002C2C")]
	[Address(RVA = "0x92F5C0", Offset = "0x92E3C0", Length = "0x5")]
	public void MarkAsStuckToGround()
	{
	}

	[Token(Token = "0x6002C2D")]
	[Address(RVA = "0x92F5D0", Offset = "0x92E3D0", Length = "0x2FB")]
	private static StickToGround FindByPosition(StickToGroundSaveData proxy)
	{
		return null;
	}

	[Token(Token = "0x6002C2E")]
	[Address(RVA = "0x92F8D0", Offset = "0x92E6D0", Length = "0x117")]
	private static StickToGround FindByGuid(string guid)
	{
		return null;
	}

	[Token(Token = "0x6002C2F")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public StickToGround()
	{
	}
}
