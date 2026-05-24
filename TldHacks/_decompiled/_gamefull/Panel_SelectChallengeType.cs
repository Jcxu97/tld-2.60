using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.Gameplay;
using TLD.UI;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;

[Token(Token = "0x20006C2")]
public class Panel_SelectChallengeType : Panel_AutoReferenced
{
	[Token(Token = "0x4004809")]
	[FieldOffset(Offset = "0x30")]
	public ButtonLegendContainer m_ButtonLegendContainer;

	[Token(Token = "0x400480A")]
	[FieldOffset(Offset = "0x38")]
	public UITexture m_ChallengeTexture;

	[Header("Menu")]
	[Token(Token = "0x400480B")]
	[FieldOffset(Offset = "0x40")]
	public string m_HeaderTitleLocalizationId;

	[Token(Token = "0x400480C")]
	[FieldOffset(Offset = "0x48")]
	public string m_TitleLocalizationId;

	[Token(Token = "0x400480D")]
	[FieldOffset(Offset = "0x50")]
	public Vector3 m_TitleHeaderOffset;

	[Token(Token = "0x400480E")]
	[FieldOffset(Offset = "0x60")]
	public GameObject m_BasicMenuRoot;

	[Token(Token = "0x400480F")]
	[FieldOffset(Offset = "0x68")]
	private BasicMenu m_BasicMenu;

	[Token(Token = "0x4004810")]
	[FieldOffset(Offset = "0x70")]
	public List<ChallengeConfig> m_Challenges;

	[Token(Token = "0x4004811")]
	[FieldOffset(Offset = "0x78")]
	public UISprite m_TitleIcon;

	[Token(Token = "0x4004812")]
	[FieldOffset(Offset = "0x80")]
	public UILocalize m_TitleText;

	[Token(Token = "0x4004813")]
	[FieldOffset(Offset = "0x88")]
	public UILocalize m_Description;

	[Token(Token = "0x4004814")]
	[FieldOffset(Offset = "0x90")]
	public UILocalize m_Instructions;

	[Token(Token = "0x4004815")]
	[FieldOffset(Offset = "0x98")]
	public UILocalize m_BulletPoints;

	[Token(Token = "0x4004816")]
	[FieldOffset(Offset = "0xA0")]
	public List<UISprite> m_DifficultySprites;

	[Token(Token = "0x4004817")]
	[FieldOffset(Offset = "0xA8")]
	public Color m_DifficultyOnColor;

	[Token(Token = "0x4004818")]
	[FieldOffset(Offset = "0xB8")]
	public Color m_DifficultyOffColor;

	[Token(Token = "0x4004819")]
	[FieldOffset(Offset = "0xC8")]
	private ChallengeConfig m_lastSelectedConfig;

	[Token(Token = "0x400481A")]
	[FieldOffset(Offset = "0xD0")]
	private AsyncOperationHandle<Texture2D> m_ChallengeTextureHandle;

	[Token(Token = "0x6003B40")]
	[Address(RVA = "0xB5A3C0", Offset = "0xB591C0", Length = "0x11B")]
	public override void Initialize()
	{
	}

	[Token(Token = "0x6003B41")]
	[Address(RVA = "0xB5A4E0", Offset = "0xB592E0", Length = "0x24C")]
	private void Update()
	{
	}

	[Token(Token = "0x6003B42")]
	[Address(RVA = "0xB5A730", Offset = "0xB59530", Length = "0x1B3")]
	private bool ChallengeIsLocked()
	{
		return false;
	}

	[Token(Token = "0x6003B43")]
	[Address(RVA = "0xB5A8F0", Offset = "0xB596F0", Length = "0x1E0")]
	public void OnChallengeClicked()
	{
	}

	[Token(Token = "0x6003B44")]
	[Address(RVA = "0xB5AAE0", Offset = "0xB598E0", Length = "0x1F6")]
	private void AddMenuItem(int itemIndex)
	{
	}

	[Token(Token = "0x6003B45")]
	[Address(RVA = "0xB5ACE0", Offset = "0xB59AE0", Length = "0x538")]
	private void ConfigureMenu()
	{
	}

	[Token(Token = "0x6003B46")]
	[Address(RVA = "0xB5B220", Offset = "0xB5A020", Length = "0x257")]
	public override void Enable(bool enable)
	{
	}

	[Token(Token = "0x6003B47")]
	[Address(RVA = "0xB5B480", Offset = "0xB5A280", Length = "0xE4")]
	public void OnClickBack()
	{
	}

	[Token(Token = "0x6003B48")]
	[Address(RVA = "0xB5B570", Offset = "0xB5A370", Length = "0xB")]
	private void OnSelectionUpdate(string name, int value, int itemIndex)
	{
	}

	[Token(Token = "0x6003B49")]
	[Address(RVA = "0xB5B580", Offset = "0xB5A380", Length = "0xB95")]
	private void UpdateUISelection(int itemIndex)
	{
	}

	[Token(Token = "0x6003B4A")]
	[Address(RVA = "0xB5C120", Offset = "0xB5AF20", Length = "0x113")]
	private void UpdateButtonLegend()
	{
	}

	[Token(Token = "0x6003B4B")]
	[Address(RVA = "0xB5C240", Offset = "0xB5B040", Length = "0x235")]
	private void RestoreSelection()
	{
	}

	[Token(Token = "0x6003B4C")]
	[Address(RVA = "0xB5C480", Offset = "0xB5B280", Length = "0xC3")]
	public Panel_SelectChallengeType()
	{
	}
}
