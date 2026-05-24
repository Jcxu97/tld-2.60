using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20003CE")]
public class LightTOD : MonoBehaviour
{
	[Token(Token = "0x400226D")]
	[FieldOffset(Offset = "0x20")]
	public List<Light> m_DayLights;

	[Token(Token = "0x400226E")]
	[FieldOffset(Offset = "0x28")]
	public List<Light> m_NightLights;

	[Token(Token = "0x400226F")]
	[FieldOffset(Offset = "0x30")]
	private float m_TODMultiplier;

	[Token(Token = "0x4002270")]
	[FieldOffset(Offset = "0x34")]
	private float m_TONMultiplier;

	[Token(Token = "0x4002271")]
	[FieldOffset(Offset = "0x38")]
	private List<float> m_NightLightOriginal;

	[Token(Token = "0x4002272")]
	[FieldOffset(Offset = "0x40")]
	private List<float> m_DayLightOriginal;

	[Token(Token = "0x4002273")]
	[FieldOffset(Offset = "0x48")]
	private bool m_Initialized;

	[Token(Token = "0x6001DB8")]
	[Address(RVA = "0x7A97A0", Offset = "0x7A85A0", Length = "0x539")]
	private void Start()
	{
	}

	[Token(Token = "0x6001DB9")]
	[Address(RVA = "0x7A9CE0", Offset = "0x7A8AE0", Length = "0x16C")]
	private void Update()
	{
	}

	[Token(Token = "0x6001DBA")]
	[Address(RVA = "0x7A9E50", Offset = "0x7A8C50", Length = "0x2F2")]
	private void UpdateLights()
	{
	}

	[Token(Token = "0x6001DBB")]
	[Address(RVA = "0x7AA150", Offset = "0x7A8F50", Length = "0x14D")]
	private void UpdateTOD()
	{
	}

	[Token(Token = "0x6001DBC")]
	[Address(RVA = "0x7AA2A0", Offset = "0x7A90A0", Length = "0x1CA")]
	private List<Light> SanitizeList(List<Light> oldList)
	{
		return null;
	}

	[Token(Token = "0x6001DBD")]
	[Address(RVA = "0x7AA470", Offset = "0x7A9270", Length = "0x51")]
	public LightTOD()
	{
	}
}
