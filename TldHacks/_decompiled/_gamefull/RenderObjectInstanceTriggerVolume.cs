using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20008F1")]
public class RenderObjectInstanceTriggerVolume : MonoBehaviour
{
	[Token(Token = "0x4005DB2")]
	[FieldOffset(Offset = "0x20")]
	public float m_Lod1Distance;

	[Token(Token = "0x4005DB3")]
	[FieldOffset(Offset = "0x24")]
	public float m_Lod2Distance;

	[Token(Token = "0x4005DB4")]
	[FieldOffset(Offset = "0x28")]
	public float m_CullDistance;

	[Token(Token = "0x4005DB5")]
	[FieldOffset(Offset = "0x30")]
	private List<RenderObjectInstance> m_InstancingScriptList;

	[Token(Token = "0x6005206")]
	[Address(RVA = "0xE3B100", Offset = "0xE39F00", Length = "0x63")]
	private void Awake()
	{
	}

	[Token(Token = "0x6005207")]
	[Address(RVA = "0xE3B170", Offset = "0xE39F70", Length = "0x133")]
	public void RegisterInstancingScript(RenderObjectInstance newRoi)
	{
	}

	[Token(Token = "0x6005208")]
	[Address(RVA = "0xE3B2B0", Offset = "0xE3A0B0", Length = "0x27B")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6005209")]
	[Address(RVA = "0xE3B530", Offset = "0xE3A330", Length = "0x233")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x600520A")]
	[Address(RVA = "0xE3B770", Offset = "0xE3A570", Length = "0x58")]
	public RenderObjectInstanceTriggerVolume()
	{
	}
}
