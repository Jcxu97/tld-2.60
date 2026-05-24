using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.PDID;
using UnityEngine;

[Token(Token = "0x2000A1C")]
public class ObjectGuid : PdidObjectBase
{
	[SerializeField]
	[Token(Token = "0x400662A")]
	[FieldOffset(Offset = "0x30")]
	private string m_Guid;

	[SerializeField]
	[Token(Token = "0x400662B")]
	[FieldOffset(Offset = "0x38")]
	private List<string> m_HistoricalGuids;

	[Token(Token = "0x17000394")]
	public override string PDID
	{
		[Token(Token = "0x600588F")]
		[Address(RVA = "0x40E110", Offset = "0x40CF10", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000395")]
	public override string ID_Legacy
	{
		[Token(Token = "0x6005890")]
		[Address(RVA = "0x457420", Offset = "0x456220", Length = "0x5")]
		get
		{
			return null;
		}
		[Token(Token = "0x6005891")]
		[Address(RVA = "0x4B1CB0", Offset = "0x4B0AB0", Length = "0x52")]
		set
		{
		}
	}

	[Token(Token = "0x17000396")]
	public List<string> HistoricalGuids
	{
		[Token(Token = "0x6005894")]
		[Address(RVA = "0x4A7D50", Offset = "0x4A6B50", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6005892")]
	[Address(RVA = "0xEECFD0", Offset = "0xEEBDD0", Length = "0x5B")]
	public override string SanitizePrefabName()
	{
		return null;
	}

	[Token(Token = "0x6005893")]
	[Address(RVA = "0x457420", Offset = "0x456220", Length = "0x5")]
	public string GetLegacyID()
	{
		return null;
	}

	[Token(Token = "0x6005895")]
	[Address(RVA = "0xEED030", Offset = "0xEEBE30", Length = "0x8B")]
	public string MaybeRuntimeRegister()
	{
		return null;
	}

	[Token(Token = "0x6005896")]
	[Address(RVA = "0xEED0C0", Offset = "0xEEBEC0", Length = "0x51")]
	public void OnDestroy()
	{
	}

	[Token(Token = "0x6005897")]
	[Address(RVA = "0xEED120", Offset = "0xEEBF20", Length = "0xCA")]
	public static void MaybeAttachObjectGuidAndRegister(GameObject go, string guid)
	{
	}

	[Token(Token = "0x6005898")]
	[Address(RVA = "0xEED1F0", Offset = "0xEEBFF0", Length = "0xCA")]
	public static void MaybeAttachObjectGuidAddOrReplace(GameObject go, string guid)
	{
	}

	[Token(Token = "0x6005899")]
	[Address(RVA = "0xEED2C0", Offset = "0xEEC0C0", Length = "0xA")]
	public static string GetGuidFromGameObject(GameObject go)
	{
		return null;
	}

	[Token(Token = "0x600589A")]
	[Address(RVA = "0xEED2D0", Offset = "0xEEC0D0", Length = "0xE8")]
	public static string GetGuidFromGameObject(GameObject go, bool warnIfNoPDID)
	{
		return null;
	}

	[Token(Token = "0x600589B")]
	[Address(RVA = "0xEED3C0", Offset = "0xEEC1C0", Length = "0xE8")]
	public static string MaybeGetGuidFromGameObject(GameObject go)
	{
		return null;
	}

	[Token(Token = "0x600589C")]
	[Address(RVA = "0xEED4B0", Offset = "0xEEC2B0", Length = "0x107")]
	public static ObjectGuid GetObjectGuidFromGO(GameObject go)
	{
		return null;
	}

	[Token(Token = "0x600589D")]
	[Address(RVA = "0x40E110", Offset = "0x40CF10", Length = "0x5")]
	private string Get()
	{
		return null;
	}

	[Token(Token = "0x600589E")]
	[Address(RVA = "0xEED5C0", Offset = "0xEEC3C0", Length = "0xE3")]
	public ObjectGuid()
	{
	}
}
