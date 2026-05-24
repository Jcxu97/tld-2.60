using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200081D")]
public class MissionIlluminationArea : MonoBehaviour
{
	[Tooltip("Radius of light effect")]
	[Token(Token = "0x400557A")]
	[FieldOffset(Offset = "0x20")]
	public float m_Radius;

	[Token(Token = "0x400557B")]
	private static List<MissionIlluminationArea> s_RegisteredIlluminationAreas;

	[Token(Token = "0x6004B78")]
	[Address(RVA = "0xD559C0", Offset = "0xD547C0", Length = "0x28D")]
	public static bool IsInIlluminationArea(Vector3 pos)
	{
		return false;
	}

	[Token(Token = "0x6004B79")]
	[Address(RVA = "0xD55C50", Offset = "0xD54A50", Length = "0xBD")]
	public void Awake()
	{
	}

	[Token(Token = "0x6004B7A")]
	[Address(RVA = "0xD55D10", Offset = "0xD54B10", Length = "0x82")]
	public void OnDestroy()
	{
	}

	[Token(Token = "0x6004B7B")]
	[Address(RVA = "0xA1E430", Offset = "0xA1D230", Length = "0x4A")]
	public MissionIlluminationArea()
	{
	}
}
