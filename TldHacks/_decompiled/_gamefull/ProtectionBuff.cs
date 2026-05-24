using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000469")]
public class ProtectionBuff : MonoBehaviour
{
	[Token(Token = "0x40027D0")]
	[FieldOffset(Offset = "0x20")]
	public ProtectionType m_ProtectionType;

	[Token(Token = "0x40027D1")]
	[FieldOffset(Offset = "0x28")]
	public string m_BuffSprite;

	[Token(Token = "0x40027D2")]
	[FieldOffset(Offset = "0x30")]
	public LocalizedString m_ProtectionBuffNameLocID;

	[Token(Token = "0x40027D3")]
	[FieldOffset(Offset = "0x38")]
	public LocalizedString m_ProtectionLossBuffNameLocID;

	[Token(Token = "0x40027D4")]
	[FieldOffset(Offset = "0x40")]
	public LocalizedString m_AfflictionDescriptionLocID;

	[Token(Token = "0x40027D5")]
	[FieldOffset(Offset = "0x48")]
	public LocalizedString m_AfflictionCauseLocID;

	[Token(Token = "0x40027D6")]
	[FieldOffset(Offset = "0x50")]
	public AfflictionBodyArea m_AfflicationBodyArea;

	[Tooltip("Prevent blood loss on specific body parts - Optional")]
	[Token(Token = "0x40027D7")]
	[FieldOffset(Offset = "0x58")]
	public List<AfflictionBodyArea> m_BodyAreasToPreventBloodLossOn;

	[Tooltip("Reduce moose/bear damage by this percentage - Optional")]
	[Range(0f, 100f)]
	[Token(Token = "0x40027D8")]
	[FieldOffset(Offset = "0x60")]
	public float m_AnimalDamageModifier;

	[Tooltip("Reduce damage to this clothing gear item causing by damage sources like blizzard using this percentage - Optional")]
	[Range(0f, 100f)]
	[Token(Token = "0x40027D9")]
	[FieldOffset(Offset = "0x64")]
	public float m_ClothingDamageModifier;

	[Tooltip("Reduce recovery time for broken ribs caused by moose using this percentage - Optional")]
	[Range(0f, 100f)]
	[Token(Token = "0x40027DA")]
	[FieldOffset(Offset = "0x68")]
	public float m_BrokenRibRecoveryTimeModifier;

	[Token(Token = "0x6002128")]
	[Address(RVA = "0x80C780", Offset = "0x80B580", Length = "0x2A")]
	public float GetAnimalDamageModifier()
	{
		return 0f;
	}

	[Token(Token = "0x6002129")]
	[Address(RVA = "0x80C7B0", Offset = "0x80B5B0", Length = "0x2A")]
	public float GetClothingDamageModifier()
	{
		return 0f;
	}

	[Token(Token = "0x600212A")]
	[Address(RVA = "0x80C7E0", Offset = "0x80B5E0", Length = "0x2A")]
	public float GetBrokenRibModifier()
	{
		return 0f;
	}

	[Token(Token = "0x600212B")]
	[Address(RVA = "0x80C810", Offset = "0x80B610", Length = "0x58")]
	public ProtectionBuff()
	{
	}
}
