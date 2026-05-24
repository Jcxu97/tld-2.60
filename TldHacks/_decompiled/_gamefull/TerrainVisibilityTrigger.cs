using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000902")]
public class TerrainVisibilityTrigger : MonoBehaviour
{
	[Token(Token = "0x4005E5A")]
	[FieldOffset(Offset = "0x20")]
	public List<Terrain> m_DisableTerrains;

	[Token(Token = "0x4005E5B")]
	private const int TERRAIN_VISIBILITY_TRIGGER_LAYER = 21;

	[Token(Token = "0x600525B")]
	[Address(RVA = "0xE48B20", Offset = "0xE47920", Length = "0xD2")]
	public void OnValidate()
	{
	}

	[Token(Token = "0x600525C")]
	[Address(RVA = "0xE48C00", Offset = "0xE47A00", Length = "0xAD")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x600525D")]
	[Address(RVA = "0xE48CB0", Offset = "0xE47AB0", Length = "0xAD")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x600525E")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public TerrainVisibilityTrigger()
	{
	}
}
