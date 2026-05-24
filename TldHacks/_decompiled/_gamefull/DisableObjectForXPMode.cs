using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.Gameplay;
using UnityEngine;

[Token(Token = "0x2000814")]
public class DisableObjectForXPMode : MonoBehaviour, IShouldDisableForCurrentMode
{
	[Token(Token = "0x4005550")]
	[FieldOffset(Offset = "0x20")]
	public List<ExperienceModeType> m_XPModesToDisable;

	[Token(Token = "0x4005551")]
	[FieldOffset(Offset = "0x28")]
	public bool m_HandleStoryModesSeparately;

	[Token(Token = "0x6004B51")]
	[Address(RVA = "0xD513E0", Offset = "0xD501E0", Length = "0x9D")]
	public void Update()
	{
	}

	[Token(Token = "0x6004B52")]
	[Address(RVA = "0xD51480", Offset = "0xD50280", Length = "0x3E1")]
	public bool ShouldDisableForCurrentMode()
	{
		return false;
	}

	[Token(Token = "0x6004B53")]
	[Address(RVA = "0xD51870", Offset = "0xD50670", Length = "0x116")]
	public static void RemoveDisabler(GameObject gameObject)
	{
	}

	[Token(Token = "0x6004B54")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public DisableObjectForXPMode()
	{
	}
}
