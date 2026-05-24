using System.Collections.Generic;
using AK.Wwise;
using Cpp2ILInjected;
using TLD.UI.Generics;
using UnityEngine;

[Token(Token = "0x2000531")]
public class SprainedAnkle : MonoBehaviour
{
	[Token(Token = "0x4002FBC")]
	[FieldOffset(Offset = "0x20")]
	public LocalizedString m_LocalizedDisplayName;

	[Token(Token = "0x4002FBD")]
	[FieldOffset(Offset = "0x28")]
	public LocalizedString m_LocalizedDescription;

	[Token(Token = "0x4002FBE")]
	[FieldOffset(Offset = "0x30")]
	public float m_ChanceSprainAfterFall;

	[Token(Token = "0x4002FBF")]
	[FieldOffset(Offset = "0x34")]
	public float m_DurationHoursMin;

	[Token(Token = "0x4002FC0")]
	[FieldOffset(Offset = "0x38")]
	public float m_DurationHoursMax;

	[Token(Token = "0x4002FC1")]
	[FieldOffset(Offset = "0x3C")]
	public float m_NumHoursRestForCure;

	[Token(Token = "0x4002FC2")]
	[FieldOffset(Offset = "0x40")]
	public float m_MinSecondsBetweenPainAudio;

	[Token(Token = "0x4002FC3")]
	[FieldOffset(Offset = "0x44")]
	public float m_MaxSecondsBetweenPainAudio;

	[Token(Token = "0x4002FC4")]
	[FieldOffset(Offset = "0x48")]
	public float m_LimpCameraTiltMin;

	[Token(Token = "0x4002FC5")]
	[FieldOffset(Offset = "0x4C")]
	public float m_LimpCameraTiltMax;

	[Token(Token = "0x4002FC6")]
	[FieldOffset(Offset = "0x50")]
	public float m_StumbleCameraTiltMin;

	[Token(Token = "0x4002FC7")]
	[FieldOffset(Offset = "0x54")]
	public float m_StumbleCameraTiltMax;

	[Header("Audio")]
	[SerializeField]
	[Token(Token = "0x4002FC8")]
	[FieldOffset(Offset = "0x58")]
	private AK.Wwise.Event m_SprainedAnkleAudioEvent;

	[SerializeField]
	[Token(Token = "0x4002FC9")]
	[FieldOffset(Offset = "0x60")]
	private AK.Wwise.Event m_StumblePainAudioEvent;

	[SerializeField]
	[Token(Token = "0x4002FCA")]
	[FieldOffset(Offset = "0x68")]
	private AK.Wwise.Event m_StumblePainMinorAudioEvent;

	[SerializeField]
	[Token(Token = "0x4002FCB")]
	[FieldOffset(Offset = "0x70")]
	private AK.Wwise.Event m_SprainedAnkleSFXEvent;

	[Tooltip("Triggered only if camera dampening is on")]
	[SerializeField]
	[Token(Token = "0x4002FCC")]
	[FieldOffset(Offset = "0x78")]
	private AK.Wwise.Event m_LimpAudioEvent;

	[Token(Token = "0x4002FCD")]
	[FieldOffset(Offset = "0x80")]
	public float m_LimpAudioDelay;

	[Header("Panel References")]
	[SerializeField]
	[Token(Token = "0x4002FCE")]
	[FieldOffset(Offset = "0x88")]
	private PanelReference<Panel_FirstAid> m_FirstAid;

	[SerializeField]
	[Token(Token = "0x4002FCF")]
	[FieldOffset(Offset = "0x90")]
	private PanelReference<Panel_HUD> m_HUD;

	[Token(Token = "0x4002FD0")]
	[FieldOffset(Offset = "0x98")]
	private float m_NextLimpAudio;

	[Token(Token = "0x4002FD1")]
	[FieldOffset(Offset = "0x9C")]
	private float m_SecondsSinceLastPainAudio;

	[Token(Token = "0x4002FD2")]
	[FieldOffset(Offset = "0xA0")]
	private float m_SecondsUntilNextPainAudio;

	[Token(Token = "0x4002FD3")]
	[FieldOffset(Offset = "0xA8")]
	private readonly List<string> m_CausesLocIDs;

	[Token(Token = "0x4002FD4")]
	[FieldOffset(Offset = "0xB0")]
	private readonly List<int> m_Locations;

	[Token(Token = "0x4002FD5")]
	[FieldOffset(Offset = "0xB8")]
	private readonly List<float> m_ElapsedHoursList;

	[Token(Token = "0x4002FD6")]
	[FieldOffset(Offset = "0xC0")]
	private readonly List<float> m_DurationHoursList;

	[Token(Token = "0x4002FD7")]
	[FieldOffset(Offset = "0xC8")]
	private readonly List<float> m_ElapsedRestList;

	[Token(Token = "0x4002FD8")]
	private static readonly SprainedAnkleSaveDataProxy m_SprainedAnkleSaveDataProxy;

	[Token(Token = "0x17000286")]
	public string DisplayName
	{
		[Token(Token = "0x6002799")]
		[Address(RVA = "0x87E130", Offset = "0x87CF30", Length = "0x5D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000287")]
	public string Description
	{
		[Token(Token = "0x600279A")]
		[Address(RVA = "0x74FB70", Offset = "0x74E970", Length = "0x5D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600279B")]
	[Address(RVA = "0x8B53B0", Offset = "0x8B41B0", Length = "0x437")]
	private void UpdateLimpAnimation()
	{
	}

	[Token(Token = "0x600279C")]
	[Address(RVA = "0x8B57F0", Offset = "0x8B45F0", Length = "0x10E")]
	public void Update()
	{
	}

	[Token(Token = "0x600279D")]
	[Address(RVA = "0x8B5900", Offset = "0x8B4700", Length = "0x3D5")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x600279E")]
	[Address(RVA = "0x8B5CE0", Offset = "0x8B4AE0", Length = "0x442")]
	public void Deserialize(string text)
	{
	}

	[Token(Token = "0x600279F")]
	[Address(RVA = "0x8B6130", Offset = "0x8B4F30", Length = "0x48")]
	public bool LocationAvailable()
	{
		return false;
	}

	[Token(Token = "0x60027A0")]
	[Address(RVA = "0x8B6180", Offset = "0x8B4F80", Length = "0xA06")]
	public void SprainedAnkleStart(string causeID, AfflictionOptions options)
	{
	}

	[Token(Token = "0x60027A1")]
	[Address(RVA = "0x8B6B90", Offset = "0x8B5990", Length = "0x2C0")]
	public void SprainedAnkleEnd(int index, AfflictionOptions options = AfflictionOptions.DisplayIcon)
	{
	}

	[Token(Token = "0x60027A2")]
	[Address(RVA = "0x8B6E60", Offset = "0x8B5C60", Length = "0x96")]
	public AfflictionBodyArea GetLocation(int index)
	{
		return default(AfflictionBodyArea);
	}

	[Token(Token = "0x60027A3")]
	[Address(RVA = "0x8B6F00", Offset = "0x8B5D00", Length = "0x48")]
	public bool HasSprainedAnkle()
	{
		return false;
	}

	[Token(Token = "0x60027A4")]
	[Address(RVA = "0x8B6F50", Offset = "0x8B5D50", Length = "0x9B")]
	public bool HasSprainedLeftAnkle()
	{
		return false;
	}

	[Token(Token = "0x60027A5")]
	[Address(RVA = "0x8B6FF0", Offset = "0x8B5DF0", Length = "0x4C")]
	public string[] GetCauseLocIDList()
	{
		return null;
	}

	[Token(Token = "0x60027A6")]
	[Address(RVA = "0x8B7040", Offset = "0x8B5E40", Length = "0x44")]
	public int GetAfflictionsCount()
	{
		return 0;
	}

	[Token(Token = "0x60027A7")]
	[Address(RVA = "0x8B7090", Offset = "0x8B5E90", Length = "0xAD")]
	public string GetAfflictionCauseLocalizationId(int localAfflictionIndex)
	{
		return null;
	}

	[Token(Token = "0x60027A8")]
	[Address(RVA = "0x8B7140", Offset = "0x8B5F40", Length = "0xA0")]
	public float GetRestAmountRemaining(int index)
	{
		return 0f;
	}

	[Token(Token = "0x60027A9")]
	[Address(RVA = "0x8B6F00", Offset = "0x8B5D00", Length = "0x48")]
	public bool HasSprainNeedingRest()
	{
		return false;
	}

	[Token(Token = "0x60027AA")]
	[Address(RVA = "0x8B6F00", Offset = "0x8B5D00", Length = "0x48")]
	public bool RequiresBandage()
	{
		return false;
	}

	[Token(Token = "0x60027AB")]
	[Address(RVA = "0x8B71F0", Offset = "0x8B5FF0", Length = "0x66")]
	public void ApplyBandage(int localAfflictionIndex)
	{
	}

	[Token(Token = "0x60027AC")]
	[Address(RVA = "0x8B7260", Offset = "0x8B6060", Length = "0x2DF")]
	public void Cure()
	{
	}

	[Token(Token = "0x60027AD")]
	[Address(RVA = "0x8B7540", Offset = "0x8B6340", Length = "0xD2")]
	public void AddRest(float hours)
	{
	}

	[Token(Token = "0x60027AE")]
	[Address(RVA = "0x8B7620", Offset = "0x8B6420", Length = "0x2E9")]
	private void UpdateSprainedAnkle(int index)
	{
	}

	[Token(Token = "0x60027AF")]
	[Address(RVA = "0x8B7910", Offset = "0x8B6710", Length = "0x130")]
	public void DoLimpAnimation()
	{
	}

	[Token(Token = "0x60027B0")]
	[Address(RVA = "0x8B7A50", Offset = "0x8B6850", Length = "0xAC")]
	public void MaybeDoLimpAudio()
	{
	}

	[Token(Token = "0x60027B1")]
	[Address(RVA = "0x8B7B00", Offset = "0x8B6900", Length = "0x2EE")]
	public bool MaybeLimpOrStumbleWithFootStep(bool left)
	{
		return false;
	}

	[Token(Token = "0x60027B2")]
	[Address(RVA = "0x8B7DF0", Offset = "0x8B6BF0", Length = "0x13C")]
	private void DoStumbleEffects(bool alreadyInjured = false)
	{
	}

	[Token(Token = "0x60027B3")]
	[Address(RVA = "0x8B7F30", Offset = "0x8B6D30", Length = "0x2FF")]
	public SprainedAnkle()
	{
	}
}
