using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.Interactions;
using TLD.UI.Generics;
using UnityEngine;

[Token(Token = "0x200018D")]
public class WolfDen : MonoBehaviour
{
	[Token(Token = "0x4000E66")]
	[FieldOffset(Offset = "0x20")]
	public SpawnRegion m_DenSpawnRegion;

	[Token(Token = "0x4000E67")]
	[FieldOffset(Offset = "0x28")]
	public SpawnRegion m_WanderSpawnRegion;

	[Token(Token = "0x4000E68")]
	[FieldOffset(Offset = "0x30")]
	public SpawnRegion m_AlphaSpawnRegion;

	[Token(Token = "0x4000E69")]
	[FieldOffset(Offset = "0x38")]
	public LocalizedString m_DestroyedDisplayName;

	[Header("Start Fire")]
	[Token(Token = "0x4000E6A")]
	[FieldOffset(Offset = "0x40")]
	public string m_StartFireIconName;

	[Token(Token = "0x4000E6B")]
	[FieldOffset(Offset = "0x48")]
	public LocalizedString m_StartingFireProgress;

	[Token(Token = "0x4000E6C")]
	[FieldOffset(Offset = "0x50")]
	public float m_StartFireRealTimeSeconds;

	[Token(Token = "0x4000E6D")]
	[FieldOffset(Offset = "0x54")]
	public float m_StartFireGameTimeMinutes;

	[Header("Panel References")]
	[SerializeField]
	[Token(Token = "0x4000E6E")]
	[FieldOffset(Offset = "0x58")]
	private PanelReference<Panel_ActionPicker> m_ActionPicker;

	[SerializeField]
	[Token(Token = "0x4000E6F")]
	[FieldOffset(Offset = "0x60")]
	private PanelReference<Panel_GenericProgressBar> m_GenericProgressBar;

	[Token(Token = "0x4000E70")]
	[FieldOffset(Offset = "0x68")]
	private string m_Guid;

	[Token(Token = "0x4000E71")]
	[FieldOffset(Offset = "0x70")]
	private bool m_IsDestroyed;

	[Token(Token = "0x4000E72")]
	[FieldOffset(Offset = "0x78")]
	private List<ActionPickerItemData> m_ItemData;

	[Token(Token = "0x4000E73")]
	private static List<WolfDen> s_WolfDenObjects;

	[Token(Token = "0x6000F13")]
	[Address(RVA = "0x609AC0", Offset = "0x6088C0", Length = "0x26F")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000F14")]
	[Address(RVA = "0x609D30", Offset = "0x608B30", Length = "0x93")]
	public static void Reset()
	{
	}

	[Token(Token = "0x6000F15")]
	[Address(RVA = "0x609DD0", Offset = "0x608BD0", Length = "0x82")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000F16")]
	[Address(RVA = "0x609E60", Offset = "0x608C60", Length = "0x56")]
	public void SetDenEnabled(bool enabled)
	{
	}

	[Token(Token = "0x6000F17")]
	[Address(RVA = "0x609EC0", Offset = "0x608CC0", Length = "0x679")]
	public bool HasRequiredItemsInInventory()
	{
		return false;
	}

	[Token(Token = "0x6000F18")]
	[Address(RVA = "0x60A540", Offset = "0x609340", Length = "0x116")]
	public void InitializeInteraction(BaseInteraction baseInteraction)
	{
	}

	[Token(Token = "0x6000F19")]
	[Address(RVA = "0x60A660", Offset = "0x609460", Length = "0xF1")]
	public void PerformInteraction()
	{
	}

	[Token(Token = "0x6000F1A")]
	[Address(RVA = "0x60A760", Offset = "0x609560", Length = "0x1AA")]
	public void OnStartFire()
	{
	}

	[Token(Token = "0x6000F1B")]
	[Address(RVA = "0x60A910", Offset = "0x609710", Length = "0x4F")]
	public void OnStartFireComplete(bool success, bool playerCancel, float progress)
	{
	}

	[Token(Token = "0x6000F1C")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public void CancelStartFire()
	{
	}

	[Token(Token = "0x6000F1D")]
	[Address(RVA = "0x60A960", Offset = "0x609760", Length = "0x4DB")]
	public static string SerializeAll()
	{
		return null;
	}

	[Token(Token = "0x6000F1E")]
	[Address(RVA = "0x60AE40", Offset = "0x609C40", Length = "0x332")]
	public static void DeserializeAll(string text)
	{
	}

	[Token(Token = "0x6000F1F")]
	[Address(RVA = "0x60B180", Offset = "0x609F80", Length = "0x125")]
	private string Serialize()
	{
		return null;
	}

	[Token(Token = "0x6000F20")]
	[Address(RVA = "0x60B2B0", Offset = "0x60A0B0", Length = "0x98")]
	private void Deserialize(string text)
	{
	}

	[Token(Token = "0x6000F21")]
	[Address(RVA = "0x60B350", Offset = "0x60A150", Length = "0x12A")]
	private static WolfDen FindWolfDenByGuid(string guid)
	{
		return null;
	}

	[Token(Token = "0x6000F22")]
	[Address(RVA = "0x60B480", Offset = "0x60A280", Length = "0x1F6")]
	public WolfDen()
	{
	}
}
