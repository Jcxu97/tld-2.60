using System;
using System.ComponentModel;
using Cpp2ILInjected;
using SpecialEvents;
using TLD.Gameplay.Challenges.DarkWalker;
using TLD.UI.Generics;
using UnityEngine;

[Token(Token = "0x20005EB")]
public class HUDNowhereToHide : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x20005EC")]
	public struct GlyphData
	{
		[DefaultValue(NowhereToHide.GlyphTypes.None)]
		[Token(Token = "0x40036C0")]
		[FieldOffset(Offset = "0x0")]
		public NowhereToHide.GlyphTypes m_Type;

		[Token(Token = "0x40036C1")]
		[FieldOffset(Offset = "0x8")]
		public LocalizedString m_Name;

		[Token(Token = "0x40036C2")]
		[FieldOffset(Offset = "0x10")]
		public string m_Texture;
	}

	[Token(Token = "0x40036A3")]
	[FieldOffset(Offset = "0x20")]
	public Panel_HUD m_HUD;

	[SerializeField]
	[Token(Token = "0x40036A4")]
	[FieldOffset(Offset = "0x28")]
	private PanelReference<Panel_Loading> m_Loading;

	[Token(Token = "0x40036A5")]
	[FieldOffset(Offset = "0x30")]
	public ToxicFogConfig m_ToxicFogConfig;

	[Token(Token = "0x40036A6")]
	[FieldOffset(Offset = "0x38")]
	public UISprite m_LureGlyphProgressSprite;

	[Token(Token = "0x40036A7")]
	[FieldOffset(Offset = "0x40")]
	public GameObject m_LureGlyphRoot;

	[Token(Token = "0x40036A8")]
	[FieldOffset(Offset = "0x48")]
	public UISprite m_WardGlyphProgressSprite;

	[Token(Token = "0x40036A9")]
	[FieldOffset(Offset = "0x50")]
	public GameObject m_WardGlyphRoot;

	[Token(Token = "0x40036AA")]
	[FieldOffset(Offset = "0x58")]
	public UILabel m_EntityDistanceLabel;

	[Token(Token = "0x40036AB")]
	[FieldOffset(Offset = "0x60")]
	public GameObject m_EntityDistanceRoot;

	[Token(Token = "0x40036AC")]
	[FieldOffset(Offset = "0x68")]
	public UILabel m_StartCountdownLabel;

	[Token(Token = "0x40036AD")]
	[FieldOffset(Offset = "0x70")]
	public GameObject m_StartCountdownRoot;

	[Token(Token = "0x40036AE")]
	[FieldOffset(Offset = "0x78")]
	public GameObject m_ToxicFogWarningRoot;

	[Range(0f, 1f)]
	[Token(Token = "0x40036AF")]
	[FieldOffset(Offset = "0x80")]
	public float m_ToxicFogWarningThreshold;

	[Token(Token = "0x40036B0")]
	[FieldOffset(Offset = "0x88")]
	public GameObject m_ToxicFogIndicatorLevel1;

	[Token(Token = "0x40036B1")]
	[FieldOffset(Offset = "0x90")]
	public GameObject m_ToxicFogIndicatorLevel2;

	[Token(Token = "0x40036B2")]
	[FieldOffset(Offset = "0x98")]
	public GameObject m_ToxicFogIndicatorLevel3;

	[Token(Token = "0x40036B3")]
	[FieldOffset(Offset = "0xA0")]
	public UILabel m_ToxicFogIndicatorLabel;

	[Token(Token = "0x40036B4")]
	[FieldOffset(Offset = "0xA8")]
	public GameObject m_AfflictionRoot;

	[Token(Token = "0x40036B5")]
	[FieldOffset(Offset = "0xB0")]
	public UITexture m_NowhereToHideMould;

	[Token(Token = "0x40036B6")]
	[FieldOffset(Offset = "0xB8")]
	public float m_WardIndicatorInactiveFadeValue;

	[Token(Token = "0x40036B7")]
	[FieldOffset(Offset = "0xC0")]
	private Material m_MouldMaterial;

	[Token(Token = "0x40036B8")]
	private static readonly int s_AnxietyAmountID;

	[Token(Token = "0x40036B9")]
	private static readonly int s_FearAmountID;

	[Token(Token = "0x40036BA")]
	[FieldOffset(Offset = "0xC8")]
	private bool m_IsLureActive;

	[Token(Token = "0x40036BB")]
	[FieldOffset(Offset = "0xC9")]
	private bool m_IsWardActive;

	[Token(Token = "0x40036BC")]
	[FieldOffset(Offset = "0xCC")]
	private int m_ToxicFogSecondsRemaining;

	[Token(Token = "0x40036BD")]
	[FieldOffset(Offset = "0xD0")]
	private UIWidget[] m_WardIndicatorWidgets;

	[Token(Token = "0x40036BE")]
	[FieldOffset(Offset = "0xD8")]
	private float[] m_WardIndicatorWidgetAlphas;

	[Token(Token = "0x40036BF")]
	[FieldOffset(Offset = "0xE0")]
	private bool m_HasShownToxicFogWarning;

	[Token(Token = "0x6002DCB")]
	[Address(RVA = "0x955BE0", Offset = "0x9549E0", Length = "0x243")]
	private void Start()
	{
	}

	[Token(Token = "0x6002DCC")]
	[Address(RVA = "0x955E30", Offset = "0x954C30", Length = "0x197")]
	public void Reset()
	{
	}

	[Token(Token = "0x6002DCD")]
	[Address(RVA = "0x955FD0", Offset = "0x954DD0", Length = "0x6F")]
	public bool ShouldShow()
	{
		return false;
	}

	[Token(Token = "0x6002DCE")]
	[Address(RVA = "0x956040", Offset = "0x954E40", Length = "0x55")]
	public void MaybeHideToxicFogWarning()
	{
	}

	[Token(Token = "0x6002DCF")]
	[Address(RVA = "0x9560A0", Offset = "0x954EA0", Length = "0xED9")]
	private void Update()
	{
	}

	[Token(Token = "0x6002DD0")]
	[Address(RVA = "0x956F80", Offset = "0x955D80", Length = "0x79")]
	private void ShowToxicFogIndicator(int level)
	{
	}

	[Token(Token = "0x6002DD1")]
	[Address(RVA = "0x957000", Offset = "0x955E00", Length = "0x4A0")]
	private void UpdateToxicFogIndicatorLabel(int level)
	{
	}

	[Token(Token = "0x6002DD2")]
	[Address(RVA = "0x9574B0", Offset = "0x9562B0", Length = "0x10D")]
	private static void MaybeSetRootActive(GameObject go, bool enabled)
	{
	}

	[Token(Token = "0x6002DD3")]
	[Address(RVA = "0x9575C0", Offset = "0x9563C0", Length = "0x66")]
	public void NowhereToHideAffliction(bool enable)
	{
	}

	[Token(Token = "0x6002DD4")]
	[Address(RVA = "0x957630", Offset = "0x956430", Length = "0x237")]
	public void NowhereToHideAfflictionAlpha(float fearAmount, float anxietyAmount)
	{
	}

	[Token(Token = "0x6002DD5")]
	[Address(RVA = "0x957870", Offset = "0x956670", Length = "0x57")]
	public HUDNowhereToHide()
	{
	}
}
