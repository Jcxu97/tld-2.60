using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.Gameplay;
using UnityEngine;

[Token(Token = "0x2000815")]
public class EnableObjectForXPMode : MonoBehaviour, IShouldDisableForCurrentMode
{
	[Token(Token = "0x4005552")]
	[FieldOffset(Offset = "0x20")]
	public List<ExperienceModeType> m_XPModesToEnable;

	[Token(Token = "0x4005553")]
	[FieldOffset(Offset = "0x28")]
	public bool m_HandleStoryModesSeparately;

	[Token(Token = "0x4005554")]
	[FieldOffset(Offset = "0x30")]
	public GameObject m_ObjectToEnable;

	[Token(Token = "0x6004B55")]
	[Address(RVA = "0xD51990", Offset = "0xD50790", Length = "0x159")]
	public void Update()
	{
	}

	[Token(Token = "0x6004B56")]
	[Address(RVA = "0xD51AF0", Offset = "0xD508F0", Length = "0x24D")]
	public bool ShouldDisableForCurrentMode()
	{
		return false;
	}

	[Token(Token = "0x6004B57")]
	[Address(RVA = "0x80BB20", Offset = "0x80A920", Length = "0x47")]
	public EnableObjectForXPMode()
	{
	}
}
