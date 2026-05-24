using System.ComponentModel;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20009C7")]
public class IndoorSpaceTrigger : MonoBehaviour
{
	[Token(Token = "0x4006387")]
	[FieldOffset(Offset = "0x20")]
	public bool m_AllowCampfires;

	[Token(Token = "0x4006388")]
	[FieldOffset(Offset = "0x21")]
	public bool m_UseOutdoorLighting;

	[Token(Token = "0x4006389")]
	[FieldOffset(Offset = "0x22")]
	public bool m_UseOutdoorTemperature;

	[Token(Token = "0x400638A")]
	[FieldOffset(Offset = "0x23")]
	public bool m_IgnoreHibernation;

	[Token(Token = "0x400638B")]
	[FieldOffset(Offset = "0x24")]
	public bool m_IgnoreCabinFever;

	[Token(Token = "0x400638C")]
	[FieldOffset(Offset = "0x25")]
	public bool m_DontCountAsInterior;

	[Token(Token = "0x400638D")]
	[FieldOffset(Offset = "0x26")]
	public bool m_CantSurvey;

	[Token(Token = "0x400638E")]
	[FieldOffset(Offset = "0x27")]
	public bool m_AllowDropTravois;

	[DefaultValue(true)]
	[Token(Token = "0x400638F")]
	[FieldOffset(Offset = "0x28")]
	public bool m_ValidSafehouse;

	[Range(-30f, 30f)]
	[Token(Token = "0x4006390")]
	[FieldOffset(Offset = "0x2C")]
	public float m_TemperatureDeltaCelsius;

	[Token(Token = "0x4006391")]
	[FieldOffset(Offset = "0x30")]
	public string m_TriggerID;

	[Token(Token = "0x6005680")]
	[Address(RVA = "0xEBA060", Offset = "0xEB8E60", Length = "0x42B")]
	private void OnTriggerEnter(Collider c)
	{
	}

	[Token(Token = "0x6005681")]
	[Address(RVA = "0xEBA490", Offset = "0xEB9290", Length = "0x574")]
	private void OnTriggerExit(Collider c)
	{
	}

	[Token(Token = "0x6005682")]
	[Address(RVA = "0xEBAA10", Offset = "0xEB9810", Length = "0x265")]
	private void HandlePlayerExitTrigger()
	{
	}

	[Token(Token = "0x6005683")]
	[Address(RVA = "0xEBAC80", Offset = "0xEB9A80", Length = "0x159")]
	private void HandleSnapPlayerIntoTrigger(Vector3 position)
	{
	}

	[Token(Token = "0x6005684")]
	[Address(RVA = "0x80BB20", Offset = "0x80A920", Length = "0x47")]
	public IndoorSpaceTrigger()
	{
	}
}
