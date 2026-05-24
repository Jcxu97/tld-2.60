using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000755")]
public class HeatSourceManager : MonoBehaviour
{
	[HideInInspector]
	[Token(Token = "0x4004E47")]
	[FieldOffset(Offset = "0x20")]
	public List<HeatSource> m_HeatSources;

	[Token(Token = "0x6004381")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public void Start()
	{
	}

	[Token(Token = "0x6004382")]
	[Address(RVA = "0xC58380", Offset = "0xC57180", Length = "0x1C6")]
	public float GetTemperatureIncrease(Vector3 position)
	{
		return 0f;
	}

	[Token(Token = "0x6004383")]
	[Address(RVA = "0xC58550", Offset = "0xC57350", Length = "0xBF")]
	public void AddHeatSource(HeatSource hs)
	{
	}

	[Token(Token = "0x6004384")]
	[Address(RVA = "0xC58610", Offset = "0xC57410", Length = "0x7F")]
	public void RemoveHeatSource(HeatSource hs)
	{
	}

	[Token(Token = "0x6004385")]
	[Address(RVA = "0xC58690", Offset = "0xC57490", Length = "0x3F4")]
	public HeatSource GetBestHeatSourceInRange()
	{
		return null;
	}

	[Token(Token = "0x6004386")]
	[Address(RVA = "0xC58A90", Offset = "0xC57890", Length = "0xE3")]
	public HeatSourceManager()
	{
	}
}
