using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000717")]
public class BodyHarvestManager : MonoBehaviour
{
	[Token(Token = "0x4004B6E")]
	[FieldOffset(Offset = "0x20")]
	public float m_FrozenDecayConditionPerHour;

	[Token(Token = "0x4004B6F")]
	[FieldOffset(Offset = "0x24")]
	public float m_NumHoursToFreezeCarcass;

	[Token(Token = "0x4004B70")]
	[FieldOffset(Offset = "0x28")]
	public float m_RadiusToThawFromFire;

	[Token(Token = "0x4004B71")]
	[FieldOffset(Offset = "0x2C")]
	public float m_NumHoursToThawFrozenCarcass;

	[Token(Token = "0x4004B72")]
	private static List<BodyHarvest> m_BodyHarvestList;

	[Token(Token = "0x6003E43")]
	[Address(RVA = "0xC07700", Offset = "0xC06500", Length = "0x28E")]
	public static BodyHarvest GetBodyHarvestFromSerializedMissionId(string missionId)
	{
		return null;
	}

	[Token(Token = "0x6003E44")]
	[Address(RVA = "0xC07990", Offset = "0xC06790", Length = "0x4A8")]
	public static void DeleteAllActive()
	{
	}

	[Token(Token = "0x6003E45")]
	[Address(RVA = "0xC07E40", Offset = "0xC06C40", Length = "0x46E")]
	public static void Destroy(BodyHarvest bodyHarvest)
	{
	}

	[Token(Token = "0x6003E46")]
	[Address(RVA = "0xC082B0", Offset = "0xC070B0", Length = "0x734")]
	public static string Serialize()
	{
		return null;
	}

	[Token(Token = "0x6003E47")]
	[Address(RVA = "0xC089F0", Offset = "0xC077F0", Length = "0x8DA")]
	public static void Deserialize(string text)
	{
	}

	[Token(Token = "0x6003E48")]
	[Address(RVA = "0xC092D0", Offset = "0xC080D0", Length = "0xBD")]
	public static void AddBodyHarvest(BodyHarvest bh)
	{
	}

	[Token(Token = "0x6003E49")]
	[Address(RVA = "0xC09390", Offset = "0xC08190", Length = "0x93")]
	public static void Reset()
	{
	}

	[Token(Token = "0x6003E4A")]
	[Address(RVA = "0xC09430", Offset = "0xC08230", Length = "0x2AE")]
	public static void MaybeRestoreCorpseState(BodyHarvest bh)
	{
	}

	[Token(Token = "0x6003E4B")]
	[Address(RVA = "0xC096E0", Offset = "0xC084E0", Length = "0x127")]
	public static void MaybeRestoreCarcassSite(BodyHarvest bh)
	{
	}

	[Token(Token = "0x6003E4C")]
	[Address(RVA = "0xC09810", Offset = "0xC08610", Length = "0x21F")]
	private static BodyHarvest InstantiateBodyHarvestGameObject(BodyHarvestSaveData proxy)
	{
		return null;
	}

	[Token(Token = "0x6003E4D")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public BodyHarvestManager()
	{
	}
}
