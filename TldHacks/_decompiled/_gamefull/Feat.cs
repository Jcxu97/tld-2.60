using Cpp2ILInjected;
using TLD.UI.Generics;
using UnityEngine;
using UnityEngine.AddressableAssets;

[Token(Token = "0x2000338")]
public class Feat : MonoBehaviour
{
	[Token(Token = "0x4001CE8")]
	[FieldOffset(Offset = "0x20")]
	public FeatType m_FeatType;

	[Token(Token = "0x4001CE9")]
	[FieldOffset(Offset = "0x28")]
	public LocalizedString m_LocalizedDisplayName;

	[Token(Token = "0x4001CEA")]
	[FieldOffset(Offset = "0x30")]
	public LocalizedString m_LocalizedDescription;

	[Token(Token = "0x4001CEB")]
	[FieldOffset(Offset = "0x38")]
	public LocalizedString m_LocalizedShortDescription;

	[Token(Token = "0x4001CEC")]
	[FieldOffset(Offset = "0x40")]
	public LocalizedString m_LocalizedBonusDescription;

	[Header("UI")]
	[SerializeField]
	[Token(Token = "0x4001CED")]
	[FieldOffset(Offset = "0x48")]
	private AssetReferenceTexture2D m_UnlockedBadge;

	[SerializeField]
	[Token(Token = "0x4001CEE")]
	[FieldOffset(Offset = "0x50")]
	private AssetReferenceTexture2D m_LockedBadge;

	[Header("Panel References")]
	[SerializeField]
	[Token(Token = "0x4001CEF")]
	[FieldOffset(Offset = "0x58")]
	private PanelReference<Panel_ActionsRadial> m_ActionsRadial;

	[Token(Token = "0x4001CF0")]
	[FieldOffset(Offset = "0x60")]
	protected bool m_KickerPending;

	[Token(Token = "0x17000200")]
	public AssetReferenceTexture2D BadgeIconReference
	{
		[Token(Token = "0x6001A62")]
		[Address(RVA = "0x4B2FE0", Offset = "0x4B1DE0", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000201")]
	public string DisplayName
	{
		[Token(Token = "0x6001A63")]
		[Address(RVA = "0x74FB70", Offset = "0x74E970", Length = "0x5D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6001A64")]
	[Address(RVA = "0x74FBD0", Offset = "0x74E9D0", Length = "0x161")]
	protected virtual void Update()
	{
	}

	[Token(Token = "0x6001A65")]
	[Address(RVA = "0x74FD40", Offset = "0x74EB40", Length = "0x22E")]
	public BadgeInfo CreateBadgeInfo()
	{
		return null;
	}

	[Token(Token = "0x6001A66")]
	[Address(RVA = "0x74FF70", Offset = "0x74ED70", Length = "0x5D")]
	public virtual string GetDescription()
	{
		return null;
	}

	[Token(Token = "0x6001A67")]
	[Address(RVA = "0x74FFD0", Offset = "0x74EDD0", Length = "0x5D")]
	public virtual string GetShortDescription()
	{
		return null;
	}

	[Token(Token = "0x6001A68")]
	[Address(RVA = "0x750030", Offset = "0x74EE30", Length = "0x5D")]
	public virtual string GetBonusDescription()
	{
		return null;
	}

	[Token(Token = "0x6001A69")]
	[Address(RVA = "0x750090", Offset = "0x74EE90", Length = "0xE6")]
	public bool IsUnlockedAndEnabled()
	{
		return false;
	}

	[Token(Token = "0x6001A6A")]
	[Address(RVA = "0x4A2140", Offset = "0x4A0F40", Length = "0x3")]
	public virtual bool IsUnlocked()
	{
		return false;
	}

	[Token(Token = "0x6001A6B")]
	[Address(RVA = "0x699F10", Offset = "0x698D10", Length = "0x4")]
	public virtual float GetNormalizedProgress()
	{
		return 0f;
	}

	[Token(Token = "0x6001A6C")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public virtual void SetNormalizedProgress(float normalizedValue)
	{
	}

	[Token(Token = "0x6001A6D")]
	[Address(RVA = "0x750180", Offset = "0x74EF80", Length = "0x153")]
	protected bool TryToDisplayKicker()
	{
		return false;
	}

	[Token(Token = "0x6001A6E")]
	[Address(RVA = "0x7502E0", Offset = "0x74F0E0", Length = "0x81")]
	protected bool ShouldBlockIncrement()
	{
		return false;
	}

	[Token(Token = "0x6001A6F")]
	[Address(RVA = "0x750370", Offset = "0x74F170", Length = "0x4F")]
	protected void HandleOnFeatUnlocked()
	{
	}

	[Token(Token = "0x6001A70")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public Feat()
	{
	}
}
