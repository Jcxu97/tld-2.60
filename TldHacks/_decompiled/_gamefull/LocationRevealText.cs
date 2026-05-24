using System.Collections.Generic;
using Cpp2ILInjected;
using TMPro;
using UnityEngine;

[Token(Token = "0x2000257")]
public class LocationRevealText : MonoBehaviour
{
	[Token(Token = "0x400151E")]
	[FieldOffset(Offset = "0x20")]
	public Panel_HUD m_HUD;

	[Token(Token = "0x400151F")]
	[FieldOffset(Offset = "0x28")]
	public AnimationCurve m_FadeCurve;

	[Token(Token = "0x4001520")]
	[FieldOffset(Offset = "0x30")]
	public float m_FadeInDelay;

	[Token(Token = "0x4001521")]
	[FieldOffset(Offset = "0x34")]
	public float m_FadeTime;

	[Token(Token = "0x4001522")]
	[FieldOffset(Offset = "0x38")]
	public float m_FullViewTime;

	[Token(Token = "0x4001523")]
	[FieldOffset(Offset = "0x3C")]
	public float m_FadeOutTime;

	[Token(Token = "0x4001524")]
	[FieldOffset(Offset = "0x40")]
	public bool m_DisplayOverAccelTime;

	[Token(Token = "0x4001525")]
	[FieldOffset(Offset = "0x48")]
	public Texture2D m_TextureLeftToRight;

	[Token(Token = "0x4001526")]
	[FieldOffset(Offset = "0x50")]
	public Texture2D m_TextureRightToLeft;

	[Token(Token = "0x4001527")]
	[FieldOffset(Offset = "0x58")]
	public Shader m_RevealShader;

	[Token(Token = "0x4001528")]
	[FieldOffset(Offset = "0x60")]
	private TextMeshPro m_TMP;

	[Token(Token = "0x4001529")]
	[FieldOffset(Offset = "0x68")]
	private Material m_FontMaterial;

	[Token(Token = "0x400152A")]
	[FieldOffset(Offset = "0x70")]
	private bool m_HideLocationLabelLastFrame;

	[Token(Token = "0x400152B")]
	[FieldOffset(Offset = "0x74")]
	private float m_AlphaOrig;

	[Token(Token = "0x400152C")]
	[FieldOffset(Offset = "0x78")]
	private bool m_DoFade;

	[Token(Token = "0x400152D")]
	[FieldOffset(Offset = "0x7C")]
	private float m_FadeTimer;

	[Token(Token = "0x400152E")]
	[FieldOffset(Offset = "0x80")]
	private Queue<string> m_Queue;

	[Token(Token = "0x60014A6")]
	[Address(RVA = "0x690960", Offset = "0x68F760", Length = "0x225")]
	private void Awake()
	{
	}

	[Token(Token = "0x60014A7")]
	[Address(RVA = "0x690B90", Offset = "0x68F990", Length = "0x14B")]
	private void Update()
	{
	}

	[Token(Token = "0x60014A8")]
	[Address(RVA = "0x690CE0", Offset = "0x68FAE0", Length = "0x153")]
	public void SetFontAndHide(TMP_FontAsset font)
	{
	}

	[Token(Token = "0x60014A9")]
	[Address(RVA = "0x690E40", Offset = "0x68FC40", Length = "0x211")]
	private void UpdateMaterial()
	{
	}

	[Token(Token = "0x60014AA")]
	[Address(RVA = "0x691060", Offset = "0x68FE60", Length = "0xDC")]
	public void Hide()
	{
	}

	[Token(Token = "0x60014AB")]
	[Address(RVA = "0x691140", Offset = "0x68FF40", Length = "0xB0")]
	public void StartFade(string msg)
	{
	}

	[Token(Token = "0x60014AC")]
	[Address(RVA = "0x502700", Offset = "0x501500", Length = "0x5")]
	public bool FadeActive()
	{
		return false;
	}

	[Token(Token = "0x60014AD")]
	[Address(RVA = "0x691200", Offset = "0x690000", Length = "0x2DD")]
	private void SetTextureElementsForTime(float timeVal)
	{
	}

	[Token(Token = "0x60014AE")]
	[Address(RVA = "0x6914E0", Offset = "0x6902E0", Length = "0x1AE")]
	private void NormalizeTextureAlpha(Texture2D textureToNormalize)
	{
	}

	[Token(Token = "0x60014AF")]
	[Address(RVA = "0x691690", Offset = "0x690490", Length = "0xF2")]
	public LocationRevealText()
	{
	}
}
