using System;
using Cpp2ILInjected;
using UnityEngine;

[Serializable]
[CreateAssetMenu(menuName = "The Long Dark/Weather State/ Create a default weather state")]
[Token(Token = "0x200032B")]
public class WeatherStatesData : ScriptableObject
{
	[Token(Token = "0x4001C50")]
	[FieldOffset(Offset = "0x18")]
	public string m_StateJSONName;

	[Token(Token = "0x4001C51")]
	[FieldOffset(Offset = "0x20")]
	public WeatherStage m_WeatherStage;

	[Token(Token = "0x4001C52")]
	[FieldOffset(Offset = "0x28")]
	public TODStateData m_DawnColors;

	[Token(Token = "0x4001C53")]
	[FieldOffset(Offset = "0x30")]
	public TODStateData m_MorningColors;

	[Token(Token = "0x4001C54")]
	[FieldOffset(Offset = "0x38")]
	public TODStateData m_MiddayColors;

	[Token(Token = "0x4001C55")]
	[FieldOffset(Offset = "0x40")]
	public TODStateData m_AfternoonColors;

	[Token(Token = "0x4001C56")]
	[FieldOffset(Offset = "0x48")]
	public TODStateData m_DuskColors;

	[Token(Token = "0x4001C57")]
	[FieldOffset(Offset = "0x50")]
	public TODStateData m_NightColors;

	[Token(Token = "0x4001C58")]
	[FieldOffset(Offset = "0x58")]
	public float m_GrassTintScalar;

	[Token(Token = "0x6001A04")]
	[Address(RVA = "0x4A22A0", Offset = "0x4A10A0", Length = "0x7")]
	public WeatherStatesData()
	{
	}
}
