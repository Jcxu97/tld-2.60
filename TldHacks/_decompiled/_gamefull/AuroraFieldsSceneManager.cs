using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200070C")]
public class AuroraFieldsSceneManager
{
	[Token(Token = "0x200070D")]
	public class AuroraFieldsSceneManagerDataProxy
	{
		[Token(Token = "0x200070E")]
		public struct FieldContainerSerialized
		{
			[Token(Token = "0x4004AFE")]
			[FieldOffset(Offset = "0x0")]
			public string m_Name;

			[Token(Token = "0x4004AFF")]
			[FieldOffset(Offset = "0x8")]
			public string m_Guid;

			[Token(Token = "0x4004B00")]
			[FieldOffset(Offset = "0x10")]
			public string m_AuroraFieldSerialized;
		}

		[Token(Token = "0x4004AFD")]
		[FieldOffset(Offset = "0x10")]
		public List<FieldContainerSerialized> m_SerializedFields;

		[Token(Token = "0x6003DDE")]
		[Address(RVA = "0xBFB5C0", Offset = "0xBFA3C0", Length = "0xAD")]
		public AuroraFieldsSceneManagerDataProxy()
		{
		}
	}

	[Token(Token = "0x4004AF9")]
	[FieldOffset(Offset = "0x10")]
	public Dictionary<string, AuroraField> m_AuroraFieldsDictionary;

	[Token(Token = "0x4004AFA")]
	[FieldOffset(Offset = "0x18")]
	public List<AuroraField> m_RegisteredAuroraFields;

	[Token(Token = "0x4004AFB")]
	public static bool m_AllStaticFieldsEnabled;

	[Token(Token = "0x4004AFC")]
	private static AuroraFieldsSceneManagerDataProxy m_AuroraFieldsSceneManagerDataProxy;

	[Token(Token = "0x6003DCF")]
	[Address(RVA = "0xBF9B00", Offset = "0xBF8900", Length = "0x73B")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x6003DD0")]
	[Address(RVA = "0xBFA240", Offset = "0xBF9040", Length = "0x2C1")]
	public void Deserialize(string text)
	{
	}

	[Token(Token = "0x6003DD1")]
	[Address(RVA = "0xBFA510", Offset = "0xBF9310", Length = "0x286")]
	public AuroraField GetAuroraFieldByName(string name)
	{
		return null;
	}

	[Token(Token = "0x6003DD2")]
	[Address(RVA = "0xBFA7A0", Offset = "0xBF95A0", Length = "0x51")]
	public bool IsRegisteredAuroraField(AuroraField auroraField)
	{
		return false;
	}

	[Token(Token = "0x6003DD3")]
	[Address(RVA = "0xBFA800", Offset = "0xBF9600", Length = "0x239")]
	public void RegisterAuroraField(AuroraField auroraField)
	{
	}

	[Token(Token = "0x6003DD4")]
	[Address(RVA = "0xBFAA40", Offset = "0xBF9840", Length = "0x122")]
	public void UnRegisterAuroraField(AuroraField auroraField)
	{
	}

	[Token(Token = "0x6003DD5")]
	[Address(RVA = "0xBFAB70", Offset = "0xBF9970", Length = "0xBF")]
	public void Reset()
	{
	}

	[Token(Token = "0x6003DD6")]
	[Address(RVA = "0xBFAC30", Offset = "0xBF9A30", Length = "0xC9")]
	public void UpdateAuroraFields(bool active)
	{
	}

	[Token(Token = "0x6003DD7")]
	[Address(RVA = "0xBFAD00", Offset = "0xBF9B00", Length = "0xFB")]
	public AuroraField GetFieldContaining(Vector3 position)
	{
		return null;
	}

	[Token(Token = "0x6003DD8")]
	[Address(RVA = "0xBFAE00", Offset = "0xBF9C00", Length = "0x11B")]
	public AuroraField GetFieldContaining(Vector3 position, float radius)
	{
		return null;
	}

	[Token(Token = "0x6003DD9")]
	[Address(RVA = "0xBFAF20", Offset = "0xBF9D20", Length = "0x17C")]
	public AuroraField GetClosestActiveFieldDistance(out float distanceToField, Vector3 position)
	{
		distanceToField = default(float);
		return null;
	}

	[Token(Token = "0x6003DDA")]
	[Address(RVA = "0xBFB0A0", Offset = "0xBF9EA0", Length = "0x106")]
	public void EnableAllStaticFields(bool enabled)
	{
	}

	[Token(Token = "0x6003DDB")]
	[Address(RVA = "0xBFB1B0", Offset = "0xBF9FB0", Length = "0x12B")]
	public AuroraField GetPlayerSafeHaven()
	{
		return null;
	}

	[Token(Token = "0x6003DDC")]
	[Address(RVA = "0xBFB2E0", Offset = "0xBFA0E0", Length = "0x159")]
	public AuroraFieldsSceneManager()
	{
	}
}
