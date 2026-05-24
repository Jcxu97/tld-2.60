using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.UI.Generics;
using UnityEngine;

[Token(Token = "0x2000533")]
public class SprainedWrist : MonoBehaviour
{
	[Token(Token = "0x2000534")]
	public enum CanEquipItemResult
	{
		[Token(Token = "0x4002FF8")]
		Success,
		[Token(Token = "0x4002FF9")]
		CannotEquipWeapon,
		[Token(Token = "0x4002FFA")]
		CannotEquip2HandedWeapon,
		[Token(Token = "0x4002FFB")]
		CannotEquipCamera
	}

	[Token(Token = "0x4002FE3")]
	[FieldOffset(Offset = "0x20")]
	public LocalizedString m_LocalizedDisplayName;

	[Token(Token = "0x4002FE4")]
	[FieldOffset(Offset = "0x28")]
	public LocalizedString m_LocalizedDescription;

	[Token(Token = "0x4002FE5")]
	[FieldOffset(Offset = "0x30")]
	public float m_ChanceSprainAfterFall;

	[Token(Token = "0x4002FE6")]
	[FieldOffset(Offset = "0x34")]
	public float m_DurationHoursMin;

	[Token(Token = "0x4002FE7")]
	[FieldOffset(Offset = "0x38")]
	public float m_DurationHoursMax;

	[Token(Token = "0x4002FE8")]
	[FieldOffset(Offset = "0x3C")]
	public float m_NumHoursRestForCure;

	[Header("Audio")]
	[Token(Token = "0x4002FE9")]
	[FieldOffset(Offset = "0x40")]
	public string m_SprainedWristVO;

	[Token(Token = "0x4002FEA")]
	[FieldOffset(Offset = "0x48")]
	public string m_SprainedWristSFX;

	[Header("Stumble")]
	[SerializeField]
	[Token(Token = "0x4002FEB")]
	[FieldOffset(Offset = "0x50")]
	private string m_StumblePainAudio;

	[SerializeField]
	[Token(Token = "0x4002FEC")]
	[FieldOffset(Offset = "0x58")]
	private float m_StumbleCameraTiltMin;

	[SerializeField]
	[Token(Token = "0x4002FED")]
	[FieldOffset(Offset = "0x5C")]
	private float m_StumbleCameraTiltMax;

	[Header("Panel References")]
	[SerializeField]
	[Token(Token = "0x4002FEE")]
	[FieldOffset(Offset = "0x60")]
	private PanelReference<Panel_FirstAid> m_FirstAid;

	[SerializeField]
	[Token(Token = "0x4002FEF")]
	[FieldOffset(Offset = "0x68")]
	private PanelReference<Panel_HUD> m_HUD;

	[Token(Token = "0x4002FF0")]
	[FieldOffset(Offset = "0x70")]
	private List<string> m_CausesLocIDs;

	[Token(Token = "0x4002FF1")]
	[FieldOffset(Offset = "0x78")]
	private List<int> m_Locations;

	[Token(Token = "0x4002FF2")]
	[FieldOffset(Offset = "0x80")]
	private List<float> m_ElapsedHoursList;

	[Token(Token = "0x4002FF3")]
	[FieldOffset(Offset = "0x88")]
	private List<float> m_DurationHoursList;

	[Token(Token = "0x4002FF4")]
	[FieldOffset(Offset = "0x90")]
	private List<float> m_ElapsedRestList;

	[Token(Token = "0x4002FF5")]
	[FieldOffset(Offset = "0x98")]
	private bool m_IsNoSprainWristForced;

	[Token(Token = "0x4002FF6")]
	private static SprainedWristSaveDataProxy m_SprainedWristSaveDataProxy;

	[Token(Token = "0x17000288")]
	public string m_DisplayName
	{
		[Token(Token = "0x60027B6")]
		[Address(RVA = "0x87E130", Offset = "0x87CF30", Length = "0x5D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000289")]
	public string m_Description
	{
		[Token(Token = "0x60027B7")]
		[Address(RVA = "0x74FB70", Offset = "0x74E970", Length = "0x5D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60027B8")]
	[Address(RVA = "0x8B82E0", Offset = "0x8B70E0", Length = "0x104")]
	public void Update()
	{
	}

	[Token(Token = "0x60027B9")]
	[Address(RVA = "0x8B83F0", Offset = "0x8B71F0", Length = "0x3B7")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x60027BA")]
	[Address(RVA = "0x8B87B0", Offset = "0x8B75B0", Length = "0x419")]
	public void Deserialize(string text)
	{
	}

	[Token(Token = "0x60027BB")]
	[Address(RVA = "0x8B8BD0", Offset = "0x8B79D0", Length = "0x45")]
	public bool LocationAvailable()
	{
		return false;
	}

	[Token(Token = "0x60027BC")]
	[Address(RVA = "0x8B8C20", Offset = "0x8B7A20", Length = "0x649")]
	public void SprainedWristStart(string causeId, AfflictionOptions options)
	{
	}

	[Token(Token = "0x60027BD")]
	[Address(RVA = "0x8B9270", Offset = "0x8B8070", Length = "0x2B7")]
	public void SprainedWristEnd(int index, AfflictionOptions options = AfflictionOptions.DisplayIcon)
	{
	}

	[Token(Token = "0x60027BE")]
	[Address(RVA = "0x8B9530", Offset = "0x8B8330", Length = "0x48")]
	public bool HasSprainedWrist()
	{
		return false;
	}

	[Token(Token = "0x60027BF")]
	[Address(RVA = "0x8B9580", Offset = "0x8B8380", Length = "0xA0")]
	public float GetRestAmountRemaining(int index)
	{
		return 0f;
	}

	[Token(Token = "0x60027C0")]
	[Address(RVA = "0x8B9530", Offset = "0x8B8330", Length = "0x48")]
	public bool HasSprainNeedingRest()
	{
		return false;
	}

	[Token(Token = "0x60027C1")]
	[Address(RVA = "0x8B9530", Offset = "0x8B8330", Length = "0x48")]
	public bool RequiresBandage()
	{
		return false;
	}

	[Token(Token = "0x60027C2")]
	[Address(RVA = "0x8B9630", Offset = "0x8B8430", Length = "0x93")]
	public AfflictionBodyArea GetLocation(int index)
	{
		return default(AfflictionBodyArea);
	}

	[Token(Token = "0x60027C3")]
	[Address(RVA = "0x8B96D0", Offset = "0x8B84D0", Length = "0x49")]
	public string[] GetCauseLocIDList()
	{
		return null;
	}

	[Token(Token = "0x60027C4")]
	[Address(RVA = "0x8B9720", Offset = "0x8B8520", Length = "0x41")]
	public int GetAfflictionsCount()
	{
		return 0;
	}

	[Token(Token = "0x60027C5")]
	[Address(RVA = "0x8B9770", Offset = "0x8B8570", Length = "0xAA")]
	public string GetAfflictionCauseLocalizationId(int localAfflictionIndex)
	{
		return null;
	}

	[Token(Token = "0x60027C6")]
	[Address(RVA = "0x8B9820", Offset = "0x8B8620", Length = "0x63")]
	public void ApplyBandage(int localAfflictionIndex)
	{
	}

	[Token(Token = "0x60027C7")]
	[Address(RVA = "0x8B9890", Offset = "0x8B8690", Length = "0x2D2")]
	public void Cure()
	{
	}

	[Token(Token = "0x60027C8")]
	[Address(RVA = "0x8B9B70", Offset = "0x8B8970", Length = "0xD2")]
	public void AddRest(float hours)
	{
	}

	[Token(Token = "0x60027C9")]
	[Address(RVA = "0x8B9C50", Offset = "0x8B8A50", Length = "0x243")]
	private void UpdateSprainedWrist(int index)
	{
	}

	[Token(Token = "0x60027CA")]
	[Address(RVA = "0x5023A0", Offset = "0x5011A0", Length = "0x8")]
	public bool IsNoSprainWristForced()
	{
		return false;
	}

	[Token(Token = "0x60027CB")]
	[Address(RVA = "0x5023B0", Offset = "0x5011B0", Length = "0x7")]
	public void SetForceNoSprainWrist(bool isNoSprainWristForced)
	{
	}

	[Token(Token = "0x60027CC")]
	[Address(RVA = "0x8B9EA0", Offset = "0x8B8CA0", Length = "0x20E")]
	public CanEquipItemResult CanEquipItem(GearItem gi)
	{
		return default(CanEquipItemResult);
	}

	[Token(Token = "0x60027CD")]
	[Address(RVA = "0x8BA0B0", Offset = "0x8B8EB0", Length = "0x80")]
	private void UnequipItemInHands()
	{
	}

	[Token(Token = "0x60027CE")]
	[Address(RVA = "0x8BA140", Offset = "0x8B8F40", Length = "0x13C")]
	private void DoStumbleEffects(bool alreadyInjured = false)
	{
	}

	[Token(Token = "0x60027CF")]
	[Address(RVA = "0x8BA280", Offset = "0x8B9080", Length = "0x2FF")]
	public SprainedWrist()
	{
	}
}
