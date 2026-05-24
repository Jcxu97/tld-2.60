using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000311")]
public class TextureInjector : MonoBehaviour
{
	[Token(Token = "0x4001AF5")]
	[FieldOffset(Offset = "0x20")]
	public Color m_ColourOverride;

	[Token(Token = "0x4001AF6")]
	[FieldOffset(Offset = "0x30")]
	public bool m_ForceColour;

	[Token(Token = "0x4001AF7")]
	[FieldOffset(Offset = "0x38")]
	public Texture2D m_AmbientOcclusionMap;

	[Token(Token = "0x4001AF8")]
	[FieldOffset(Offset = "0x40")]
	public float m_AmbientStrength;

	[Token(Token = "0x4001AF9")]
	[FieldOffset(Offset = "0x48")]
	public Texture2D m_NoiseOverlayMap;

	[Token(Token = "0x4001AFA")]
	[FieldOffset(Offset = "0x50")]
	public float m_NoiseStrength;

	[Token(Token = "0x4001AFB")]
	[FieldOffset(Offset = "0x54")]
	public Vector2 m_NoiseTiling;

	[Token(Token = "0x4001AFC")]
	[FieldOffset(Offset = "0x5C")]
	public bool m_ForceNoiseTiling;

	[Token(Token = "0x4001AFD")]
	[FieldOffset(Offset = "0x60")]
	public Texture2D m_EmissiveMap;

	[Token(Token = "0x4001AFE")]
	[FieldOffset(Offset = "0x68")]
	public float m_EmissiveStrength;

	[Token(Token = "0x4001AFF")]
	[FieldOffset(Offset = "0x70")]
	public List<Material> m_IgnoreMaterials;

	[Token(Token = "0x4001B00")]
	[FieldOffset(Offset = "0x78")]
	public bool m_AutoLoad;

	[Token(Token = "0x4001B01")]
	[FieldOffset(Offset = "0x80")]
	private List<Material> m_LocalMaterials;

	[Token(Token = "0x4001B02")]
	[FieldOffset(Offset = "0x88")]
	private bool m_IsReady;

	[Token(Token = "0x60018F3")]
	[Address(RVA = "0x6F96D0", Offset = "0x6F84D0", Length = "0x34")]
	private void Start()
	{
	}

	[Token(Token = "0x60018F4")]
	[Address(RVA = "0x6F9710", Offset = "0x6F8510", Length = "0x59B")]
	public void LoadTextures()
	{
	}

	[Token(Token = "0x60018F5")]
	[Address(RVA = "0x6F9CB0", Offset = "0x6F8AB0", Length = "0x589")]
	public void UnloadTextures()
	{
	}

	[Token(Token = "0x60018F6")]
	[Address(RVA = "0x6FA240", Offset = "0x6F9040", Length = "0x905")]
	private void Initialize()
	{
	}

	[Token(Token = "0x60018F7")]
	[Address(RVA = "0x6FAB50", Offset = "0x6F9950", Length = "0xD4")]
	private int Contains(List<Material> localList, string matName)
	{
		return 0;
	}

	[Token(Token = "0x60018F8")]
	[Address(RVA = "0x6FAC30", Offset = "0x6F9A30", Length = "0x65")]
	public TextureInjector()
	{
	}
}
