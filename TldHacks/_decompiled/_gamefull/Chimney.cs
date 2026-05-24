using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000376")]
public class Chimney : MonoBehaviour
{
	[Token(Token = "0x4001EB4")]
	private const float CHIMNEY_MAX_DISTANCE = 10f;

	[Token(Token = "0x4001EB5")]
	[FieldOffset(Offset = "0x20")]
	public SmokeTrail m_SmokeTrail;

	[Token(Token = "0x4001EB6")]
	[FieldOffset(Offset = "0x28")]
	public float m_LifetimeGameMinutes;

	[HideInInspector]
	[Token(Token = "0x4001EB7")]
	[FieldOffset(Offset = "0x2C")]
	public bool m_RestoredFromGlobalData;

	[Token(Token = "0x4001EB8")]
	[FieldOffset(Offset = "0x2D")]
	private bool m_StartHasBeenCalled;

	[Token(Token = "0x4001EB9")]
	private static readonly List<Chimney> s_Chimneys;

	[Token(Token = "0x4001EBA")]
	private static readonly ChimneySaveData s_ChimneySaveData;

	[Token(Token = "0x6001BF7")]
	[Address(RVA = "0x76F320", Offset = "0x76E120", Length = "0xCD")]
	public void Start()
	{
	}

	[Token(Token = "0x6001BF8")]
	[Address(RVA = "0x76F3F0", Offset = "0x76E1F0", Length = "0x93")]
	public static void Reset()
	{
	}

	[Token(Token = "0x6001BF9")]
	[Address(RVA = "0x76F490", Offset = "0x76E290", Length = "0x21E")]
	private void Update()
	{
	}

	[Token(Token = "0x6001BFA")]
	[Address(RVA = "0x76F6B0", Offset = "0x76E4B0", Length = "0x1DA")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x6001BFB")]
	[Address(RVA = "0x76F890", Offset = "0x76E690", Length = "0x1EA")]
	public void Deserialize(string text)
	{
	}

	[Token(Token = "0x6001BFC")]
	[Address(RVA = "0x76FA80", Offset = "0x76E880", Length = "0x321")]
	public static string SerializeAll()
	{
		return null;
	}

	[Token(Token = "0x6001BFD")]
	[Address(RVA = "0x76FDB0", Offset = "0x76EBB0", Length = "0x1CA")]
	public static void DeserializeAll(string text)
	{
	}

	[Token(Token = "0x6001BFE")]
	[Address(RVA = "0x76FF80", Offset = "0x76ED80", Length = "0x64")]
	public static Chimney FindByGuid(string guid)
	{
		return null;
	}

	[Token(Token = "0x6001BFF")]
	[Address(RVA = "0x76FFF0", Offset = "0x76EDF0", Length = "0x355")]
	public static Chimney FindByPosition(Vector3 pos)
	{
		return null;
	}

	[Token(Token = "0x6001C00")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public Chimney()
	{
	}
}
