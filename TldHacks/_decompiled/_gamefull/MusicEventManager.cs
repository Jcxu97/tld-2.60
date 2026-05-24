using AK.Wwise;
using Cpp2ILInjected;
using TLD.UI.Generics;
using UnityEngine;

[Token(Token = "0x2000789")]
public class MusicEventManager : MonoBehaviour
{
	[Header("Location Sounds")]
	[Token(Token = "0x400509E")]
	[FieldOffset(Offset = "0x20")]
	public AK.Wwise.Event m_OutdoorLocationFirstTime;

	[Token(Token = "0x400509F")]
	[FieldOffset(Offset = "0x28")]
	public AK.Wwise.Event m_OutdoorLocationSubsequentTimes;

	[Token(Token = "0x40050A0")]
	[FieldOffset(Offset = "0x30")]
	public AK.Wwise.Event m_IndoorLocationFirstTime;

	[Token(Token = "0x40050A1")]
	[FieldOffset(Offset = "0x38")]
	public AK.Wwise.Event m_IndoorLocationSubsequentTimes;

	[Tooltip("Indoor locations listed here will play a location sound, all other interiors will not.")]
	[Token(Token = "0x40050A2")]
	[FieldOffset(Offset = "0x40")]
	public string[] m_IndoorLocationsToPlaySound;

	[Header("Happy Success")]
	[Token(Token = "0x40050A3")]
	[FieldOffset(Offset = "0x48")]
	public AK.Wwise.Event m_HappySuccessMusic;

	[Token(Token = "0x40050A4")]
	[FieldOffset(Offset = "0x50")]
	public float m_HappySuccessMinHoursBetween;

	[Header("Sorrow")]
	[Token(Token = "0x40050A5")]
	[FieldOffset(Offset = "0x58")]
	public AK.Wwise.Event m_SorrowMusic;

	[Token(Token = "0x40050A6")]
	[FieldOffset(Offset = "0x60")]
	public float m_SorrowNumHoursWithAffliction;

	[Token(Token = "0x40050A7")]
	[FieldOffset(Offset = "0x64")]
	public float m_SorrowHealthThreshold;

	[Token(Token = "0x40050A8")]
	[FieldOffset(Offset = "0x68")]
	public float m_SorrowMinHoursBetween;

	[Header("Rope Climb Stress")]
	[Token(Token = "0x40050A9")]
	[FieldOffset(Offset = "0x70")]
	public AK.Wwise.Event m_RopeStressMusic;

	[Token(Token = "0x40050AA")]
	[FieldOffset(Offset = "0x78")]
	public float m_RopeStressFatigueBarThreshold;

	[Token(Token = "0x40050AB")]
	[FieldOffset(Offset = "0x7C")]
	public float m_RopeStressMinHoursBetween;

	[Header("Being Stalked")]
	[Token(Token = "0x40050AC")]
	[FieldOffset(Offset = "0x80")]
	public AK.Wwise.Event m_BeingStalkedMusic;

	[Token(Token = "0x40050AD")]
	[FieldOffset(Offset = "0x88")]
	public AK.Wwise.Event m_ExitStalkMusic;

	[Token(Token = "0x40050AE")]
	[FieldOffset(Offset = "0x90")]
	public AK.Wwise.Event m_EnterAttackMusic;

	[Token(Token = "0x40050AF")]
	[FieldOffset(Offset = "0x98")]
	public float m_BeingStalkedMinHoursBetween;

	[Header("Panel References")]
	[SerializeField]
	[Token(Token = "0x40050B0")]
	[FieldOffset(Offset = "0xA0")]
	private PanelReference<Panel_BodyHarvest> m_BodyHarvest;

	[Token(Token = "0x40050B1")]
	[FieldOffset(Offset = "0xA8")]
	private float m_HappySuccessLastPlayTime;

	[Token(Token = "0x40050B2")]
	[FieldOffset(Offset = "0xAC")]
	private float m_SorrowLastPlayTime;

	[Token(Token = "0x40050B3")]
	[FieldOffset(Offset = "0xB0")]
	private float m_RopeClimbStressLastPlayTime;

	[Token(Token = "0x40050B4")]
	[FieldOffset(Offset = "0xB4")]
	private float m_BeingStalkedLastPlayTime;

	[Token(Token = "0x40050B5")]
	[FieldOffset(Offset = "0xB8")]
	private float m_NumHoursWithAffliction;

	[Token(Token = "0x40050B6")]
	[FieldOffset(Offset = "0xBC")]
	private bool m_WasBeingStalkedLastFrame;

	[Token(Token = "0x40050B7")]
	[FieldOffset(Offset = "0xBD")]
	private bool m_WasBeingAttackedLastFrame;

	[Token(Token = "0x40050B8")]
	[FieldOffset(Offset = "0xBE")]
	private bool m_MusicPlayedThisStalk;

	[Token(Token = "0x40050B9")]
	private static MusicEventSaveData m_MusicEventSaveData;

	[Token(Token = "0x6004689")]
	[Address(RVA = "0xCA9BC0", Offset = "0xCA89C0", Length = "0x33")]
	private void Awake()
	{
	}

	[Token(Token = "0x600468A")]
	[Address(RVA = "0xCA9C00", Offset = "0xCA8A00", Length = "0x89")]
	private void Update()
	{
	}

	[Token(Token = "0x600468B")]
	[Address(RVA = "0xCA9C90", Offset = "0xCA8A90", Length = "0x16E")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x600468C")]
	[Address(RVA = "0xCA9E00", Offset = "0xCA8C00", Length = "0xB3")]
	public void Deserialize(string text)
	{
	}

	[Token(Token = "0x600468D")]
	[Address(RVA = "0xCA9EC0", Offset = "0xCA8CC0", Length = "0x130")]
	public void PlaySorrowMusic()
	{
	}

	[Token(Token = "0x600468E")]
	[Address(RVA = "0xCAA000", Offset = "0xCA8E00", Length = "0x70C")]
	private void CheckForHappySuccess()
	{
	}

	[Token(Token = "0x600468F")]
	[Address(RVA = "0xCAA710", Offset = "0xCA9510", Length = "0x2FB")]
	private void CheckForSorrow()
	{
	}

	[Token(Token = "0x6004690")]
	[Address(RVA = "0xCAAA10", Offset = "0xCA9810", Length = "0x220")]
	private void CheckForRopeClimbStress()
	{
	}

	[Token(Token = "0x6004691")]
	[Address(RVA = "0xCAAC40", Offset = "0xCA9A40", Length = "0x77F")]
	private void CheckForBeingStalked()
	{
	}

	[Token(Token = "0x6004692")]
	[Address(RVA = "0xCAB3C0", Offset = "0xCAA1C0", Length = "0x2C8")]
	public void PlayLocationSound(bool hasPlayedBefore)
	{
	}

	[Token(Token = "0x6004693")]
	[Address(RVA = "0xCAB690", Offset = "0xCAA490", Length = "0x62")]
	public MusicEventManager()
	{
	}
}
