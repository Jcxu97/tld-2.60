using Cpp2ILInjected;
using TLD.UI.Generics;
using UnityEngine;
using UnityEngine.AddressableAssets;

[Token(Token = "0x2000339")]
public class FeatNotify : MonoBehaviour
{
	[Token(Token = "0x4001CF1")]
	[FieldOffset(Offset = "0x20")]
	public float m_FeatUnlockDisplayTimeSeconds;

	[Token(Token = "0x4001CF2")]
	[FieldOffset(Offset = "0x24")]
	public float m_FadeTimeSeconds;

	[Token(Token = "0x4001CF3")]
	[FieldOffset(Offset = "0x28")]
	public string m_FeatUnlockAudio;

	[Header("Panel References")]
	[SerializeField]
	[Token(Token = "0x4001CF4")]
	[FieldOffset(Offset = "0x30")]
	private PanelReference<Panel_HUD> m_HUD;

	[Token(Token = "0x4001CF5")]
	[FieldOffset(Offset = "0x38")]
	private float m_FeatUnlockedElapsedDisplayTimeSeconds;

	[Token(Token = "0x4001CF6")]
	[FieldOffset(Offset = "0x3C")]
	private float m_FeatUnlockedAlpha;

	[Token(Token = "0x6001A71")]
	[Address(RVA = "0x7503C0", Offset = "0x74F1C0", Length = "0x86")]
	public void Start()
	{
	}

	[Token(Token = "0x6001A72")]
	[Address(RVA = "0x750450", Offset = "0x74F250", Length = "0x1EA")]
	public void Update()
	{
	}

	[Token(Token = "0x6001A73")]
	[Address(RVA = "0x750640", Offset = "0x74F440", Length = "0x5BE")]
	public void ShowFeatUnlockedKicker(AssetReferenceTexture2D textureReference, string footer)
	{
	}

	[Token(Token = "0x6001A74")]
	[Address(RVA = "0x750C00", Offset = "0x74FA00", Length = "0x285")]
	private void UpdateFeatUnlockedAlpha(Panel_HUD hud)
	{
	}

	[Token(Token = "0x6001A75")]
	[Address(RVA = "0x750E90", Offset = "0x74FC90", Length = "0xC3")]
	private bool ShouldHideFeatUnlockedIcon()
	{
		return false;
	}

	[Token(Token = "0x6001A76")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public FeatNotify()
	{
	}
}
