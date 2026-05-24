using Cpp2ILInjected;
using TLD.UI;

[Token(Token = "0x20006BC")]
public class Panel_SaveIcon : Panel_AutoReferenced
{
	[Token(Token = "0x40047D8")]
	[FieldOffset(Offset = "0x30")]
	public UISprite m_Sprite_IsSaving;

	[Token(Token = "0x40047D9")]
	[FieldOffset(Offset = "0x38")]
	public UILabel m_Label_Saving;

	[Token(Token = "0x40047DA")]
	[FieldOffset(Offset = "0x40")]
	private float m_TimeToShowSaveSprite;

	[Token(Token = "0x6003B08")]
	[Address(RVA = "0xB55310", Offset = "0xB54110", Length = "0x5E")]
	public override void Initialize()
	{
	}

	[Token(Token = "0x6003B09")]
	[Address(RVA = "0xB55370", Offset = "0xB54170", Length = "0x279")]
	private void Update()
	{
	}

	[Token(Token = "0x6003B0A")]
	[Address(RVA = "0xB555F0", Offset = "0xB543F0", Length = "0x5E")]
	public void StartSaveIconAnimation()
	{
	}

	[Token(Token = "0x6003B0B")]
	[Address(RVA = "0x640990", Offset = "0x63F790", Length = "0xF")]
	public bool IsIconVisible()
	{
		return false;
	}

	[Token(Token = "0x6003B0C")]
	[Address(RVA = "0x4A2140", Offset = "0x4A0F40", Length = "0x3")]
	public override bool IsOverlayPanel()
	{
		return false;
	}

	[Token(Token = "0x6003B0D")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public Panel_SaveIcon()
	{
	}
}
