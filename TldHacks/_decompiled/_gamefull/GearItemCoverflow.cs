using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200023B")]
public class GearItemCoverflow : MonoBehaviour
{
	[Token(Token = "0x40013C2")]
	private const string DAMAGE_TEXTURE_NAME = "_DamageTex";

	[Token(Token = "0x40013C3")]
	private const string BLENDMAP_TEXTURE_NAME = "_blendmap";

	[Token(Token = "0x40013C4")]
	private const string BLENDAMOUNT_PARAM_NAME = "_blend_amt";

	[Token(Token = "0x40013C5")]
	[FieldOffset(Offset = "0x20")]
	public UILabel m_UseLabel;

	[Token(Token = "0x40013C6")]
	[FieldOffset(Offset = "0x28")]
	public UILabel m_Label;

	[Token(Token = "0x40013C7")]
	[FieldOffset(Offset = "0x30")]
	public UITexture m_Texture;

	[Token(Token = "0x40013C8")]
	[FieldOffset(Offset = "0x38")]
	public UITexture m_TextureWithDamage;

	[Token(Token = "0x40013C9")]
	[FieldOffset(Offset = "0x40")]
	public UITexture m_PhotoTexture;

	[Token(Token = "0x40013CA")]
	[FieldOffset(Offset = "0x48")]
	public Material m_MaterialSource;

	[HideInInspector]
	[Token(Token = "0x40013CB")]
	[FieldOffset(Offset = "0x50")]
	public bool m_ShowUseLabel;

	[HideInInspector]
	[Token(Token = "0x40013CC")]
	[FieldOffset(Offset = "0x58")]
	public string m_ItemName;

	[Token(Token = "0x40013CD")]
	[FieldOffset(Offset = "0x60")]
	private GearItem m_GearItem;

	[Token(Token = "0x40013CE")]
	[FieldOffset(Offset = "0x68")]
	private Material m_TextureWithDamageMaterial;

	[Token(Token = "0x60013B5")]
	[Address(RVA = "0x674DB0", Offset = "0x673BB0", Length = "0xD3")]
	private void Awake()
	{
	}

	[Token(Token = "0x60013B6")]
	[Address(RVA = "0x674E90", Offset = "0x673C90", Length = "0xED")]
	private void Update()
	{
	}

	[Token(Token = "0x60013B7")]
	[Address(RVA = "0x674F80", Offset = "0x673D80", Length = "0x4FE")]
	public void SetGearItem(GearItem gi, string gearPrefabName, bool isSmash)
	{
	}

	[Token(Token = "0x60013B8")]
	[Address(RVA = "0x675480", Offset = "0x674280", Length = "0x39C")]
	public void SetDecorationItem(DecorationItem di)
	{
	}

	[Token(Token = "0x60013B9")]
	[Address(RVA = "0x675820", Offset = "0x674620", Length = "0x19B")]
	public void SetSelected(bool selected)
	{
	}

	[Token(Token = "0x60013BA")]
	[Address(RVA = "0x6759C0", Offset = "0x6747C0", Length = "0x32F")]
	public void SetEmptySlot(string textureName)
	{
	}

	[Token(Token = "0x60013BB")]
	[Address(RVA = "0x675CF0", Offset = "0x674AF0", Length = "0x2FD")]
	private void SetDamageTextures()
	{
	}

	[Token(Token = "0x60013BC")]
	[Address(RVA = "0x675FF0", Offset = "0x674DF0", Length = "0x17B")]
	private void SetBlendAmountOnly()
	{
	}

	[Token(Token = "0x60013BD")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public GearItemCoverflow()
	{
	}
}
