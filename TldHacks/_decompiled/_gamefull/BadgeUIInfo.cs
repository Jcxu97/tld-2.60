using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.SaveState;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

[CreateAssetMenu(order = 10002)]
[Token(Token = "0x20005C7")]
public class BadgeUIInfo : ScriptableObject
{
	[Token(Token = "0x400355E")]
	[FieldOffset(Offset = "0x18")]
	public BadgeInfoType m_Type;

	[SerializeField]
	[Token(Token = "0x400355F")]
	[FieldOffset(Offset = "0x20")]
	private AssetReferenceTexture2D m_UnlockedSprite;

	[SerializeField]
	[Token(Token = "0x4003560")]
	[FieldOffset(Offset = "0x28")]
	private AssetReferenceTexture2D m_LockedSprite;

	[SerializeField]
	[Token(Token = "0x4003561")]
	[FieldOffset(Offset = "0x30")]
	private LocalizedString m_BadgeName;

	[SerializeField]
	[Token(Token = "0x4003562")]
	[FieldOffset(Offset = "0x38")]
	private LocalizedString m_Description;

	[SerializeField]
	[Token(Token = "0x4003563")]
	[FieldOffset(Offset = "0x40")]
	private LocalizedString m_LockedDescription;

	[NonSerialized]
	[Token(Token = "0x4003564")]
	[FieldOffset(Offset = "0x48")]
	public bool m_Unlocked;

	[Token(Token = "0x4003565")]
	private static AsyncOperationHandle<IList<BadgeUIInfo>> s_BadgeUIInfoHandle;

	[Token(Token = "0x170002D1")]
	public AssetReferenceTexture2D UnlockedSprite
	{
		[Token(Token = "0x6002CBD")]
		[Address(RVA = "0x40E110", Offset = "0x40CF10", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6002CBE")]
	[Address(RVA = "0x93AFD0", Offset = "0x939DD0", Length = "0x36A")]
	public BadgeInfo CreateBadgeInfo()
	{
		return null;
	}

	[Token(Token = "0x6002CBF")]
	[Address(RVA = "0x93B340", Offset = "0x93A140", Length = "0x227")]
	public static void UnlockBadge(BadgeInfoType badge, bool skipProfileSave = false)
	{
	}

	[Token(Token = "0x6002CC0")]
	[Address(RVA = "0x93B570", Offset = "0x93A370", Length = "0x35C")]
	private static BadgeUIInfo GetBadgeUIInfo(BadgeInfoType badge)
	{
		return null;
	}

	[Token(Token = "0x6002CC1")]
	[Address(RVA = "0x93B8D0", Offset = "0x93A6D0", Length = "0x185")]
	private static IList<BadgeUIInfo> GetAllBadgeUIInfo()
	{
		return null;
	}

	[Token(Token = "0x6002CC2")]
	[Address(RVA = "0x4A22A0", Offset = "0x4A10A0", Length = "0x7")]
	public BadgeUIInfo()
	{
	}
}
