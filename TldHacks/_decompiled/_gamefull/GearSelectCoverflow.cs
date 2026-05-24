using Cpp2ILInjected;
using TLD.Gameplay;
using UnityEngine;

[Token(Token = "0x200023F")]
public class GearSelectCoverflow : MonoBehaviour
{
	[Token(Token = "0x40013E5")]
	[FieldOffset(Offset = "0x20")]
	public UITexture m_Texture;

	[SerializeField]
	[Token(Token = "0x40013E6")]
	[FieldOffset(Offset = "0x28")]
	private BodyHarvestSettings m_BodyHarvestSettings;

	[Token(Token = "0x40013E7")]
	[FieldOffset(Offset = "0x30")]
	private GearItem m_GearItem;

	[Token(Token = "0x60013CD")]
	[Address(RVA = "0x677240", Offset = "0x676040", Length = "0xD6")]
	public void SetEmptySlot(string textureName)
	{
	}

	[Token(Token = "0x60013CE")]
	[Address(RVA = "0x677320", Offset = "0x676120", Length = "0x288")]
	public void SetBareHands()
	{
	}

	[Token(Token = "0x60013CF")]
	[Address(RVA = "0x6775B0", Offset = "0x6763B0", Length = "0x160")]
	public void SetGearItem(GearItem gearItem)
	{
	}

	[Token(Token = "0x60013D0")]
	[Address(RVA = "0x677720", Offset = "0x676520", Length = "0xD9")]
	public void UpdateGearItemIcon()
	{
	}

	[Token(Token = "0x60013D1")]
	[Address(RVA = "0x677800", Offset = "0x676600", Length = "0x245")]
	private void SetGearItemIcon(GearItem gearItem)
	{
	}

	[Token(Token = "0x60013D2")]
	[Address(RVA = "0x677A50", Offset = "0x676850", Length = "0x82")]
	private void SetGearItemIcon(string gearPrefabName)
	{
	}

	[Token(Token = "0x60013D3")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public GearSelectCoverflow()
	{
	}
}
