using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.UI.Generics;
using UnityEngine;

[Token(Token = "0x200047A")]
public class DamageProtection : MonoBehaviour
{
	[SerializeField]
	[Token(Token = "0x40028A8")]
	[FieldOffset(Offset = "0x20")]
	private PanelReference<Panel_HUD> m_HUD;

	[Token(Token = "0x40028A9")]
	[FieldOffset(Offset = "0x28")]
	private bool m_ShouldShowNewBuff;

	[Token(Token = "0x40028AA")]
	[FieldOffset(Offset = "0x30")]
	private ProtectionBuff m_ProtectionBuff;

	[Token(Token = "0x40028AB")]
	private const float NEUTRAL_MODIFIER = 0f;

	[Token(Token = "0x40028AC")]
	[FieldOffset(Offset = "0x38")]
	private Dictionary<ProtectionType, GearItem> m_DamageProtectionItems;

	[Token(Token = "0x60021CD")]
	[Address(RVA = "0x821030", Offset = "0x81FE30", Length = "0x1BC")]
	private void Update()
	{
	}

	[Token(Token = "0x60021CE")]
	[Address(RVA = "0x8211F0", Offset = "0x81FFF0", Length = "0x3E5")]
	public void MaybeUpdateDamageProtection(GearItem gearItem)
	{
	}

	[Token(Token = "0x60021CF")]
	[Address(RVA = "0x8215E0", Offset = "0x8203E0", Length = "0x3DF")]
	public float MaybeApplyClothingDamageProtection(DamageReason damageReason, GearItem gi)
	{
		return 0f;
	}

	[Token(Token = "0x60021D0")]
	[Address(RVA = "0x8219C0", Offset = "0x8207C0", Length = "0x8D")]
	public float MaybeApplyAnimalDamageProtection(DamageReason damageReason, WildlifeType wildlifeType)
	{
		return 0f;
	}

	[Token(Token = "0x60021D1")]
	[Address(RVA = "0x821A50", Offset = "0x820850", Length = "0x88")]
	public float MaybeApplyBrokenRibModifier(DamageReason damageReason, WildlifeType wildlifeTyp)
	{
		return 0f;
	}

	[Token(Token = "0x60021D2")]
	[Address(RVA = "0x821AE0", Offset = "0x8208E0", Length = "0x2C4")]
	public List<AfflictionBodyArea> GetBodyAreasToPreventBloodLoss()
	{
		return null;
	}

	[Token(Token = "0x60021D3")]
	[Address(RVA = "0x821DB0", Offset = "0x820BB0", Length = "0x49")]
	public bool HasDamageProtection()
	{
		return false;
	}

	[Token(Token = "0x60021D4")]
	[Address(RVA = "0x821E00", Offset = "0x820C00", Length = "0x1DE")]
	public string GetAfflictionDescription(int index)
	{
		return null;
	}

	[Token(Token = "0x60021D5")]
	[Address(RVA = "0x821FE0", Offset = "0x820DE0", Length = "0x1DE")]
	public string GetAfflictionCause(int index)
	{
		return null;
	}

	[Token(Token = "0x60021D6")]
	[Address(RVA = "0x8221C0", Offset = "0x820FC0", Length = "0x195")]
	public AfflictionBodyArea GetAfflictionBodyArea(int index)
	{
		return default(AfflictionBodyArea);
	}

	[Token(Token = "0x60021D7")]
	[Address(RVA = "0x822360", Offset = "0x821160", Length = "0x44")]
	public int GetDamageAfflictionsCount()
	{
		return 0;
	}

	[Token(Token = "0x60021D8")]
	[Address(RVA = "0x8223B0", Offset = "0x8211B0", Length = "0x18E")]
	private bool ShouldUpdateBuffNotification()
	{
		return false;
	}

	[Token(Token = "0x60021D9")]
	[Address(RVA = "0x822540", Offset = "0x821340", Length = "0x206")]
	private void ApplyProtectionBuff()
	{
	}

	[Token(Token = "0x60021DA")]
	[Address(RVA = "0x822750", Offset = "0x821550", Length = "0x206")]
	private void RemoveProtectionBuff()
	{
	}

	[Token(Token = "0x60021DB")]
	[Address(RVA = "0x822960", Offset = "0x821760", Length = "0x66")]
	private bool HasBallisticVest()
	{
		return false;
	}

	[Token(Token = "0x60021DC")]
	[Address(RVA = "0x8229D0", Offset = "0x8217D0", Length = "0xA7")]
	private GearItem GetBallisticVestItem()
	{
		return null;
	}

	[Token(Token = "0x60021DD")]
	[Address(RVA = "0x822A80", Offset = "0x821880", Length = "0x2A2")]
	private float GetTotalAnimalDamageModifier()
	{
		return 0f;
	}

	[Token(Token = "0x60021DE")]
	[Address(RVA = "0x822D30", Offset = "0x821B30", Length = "0x2A2")]
	private float GetTotalBrokenRibModifier()
	{
		return 0f;
	}

	[Token(Token = "0x60021DF")]
	[Address(RVA = "0x822FE0", Offset = "0x821DE0", Length = "0x9F")]
	private GearItem GetAfflictionGearItem(int index)
	{
		return null;
	}

	[Token(Token = "0x60021E0")]
	[Address(RVA = "0x823080", Offset = "0x821E80", Length = "0xE3")]
	public DamageProtection()
	{
	}
}
