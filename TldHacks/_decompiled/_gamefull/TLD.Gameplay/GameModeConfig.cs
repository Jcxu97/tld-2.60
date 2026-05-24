using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.GameplayTags;
using TLD.Gear;
using TLD.Logging;
using TLD.Scenes;
using UnityEngine;

namespace TLD.Gameplay;

[Token(Token = "0x2001479")]
public abstract class GameModeConfig : ScriptableObject
{
	[Token(Token = "0x40094A4")]
	protected static readonly LogFilter s_LogFilter;

	[Token(Token = "0x40094A5")]
	[FieldOffset(Offset = "0x18")]
	public SaveSlotType m_SaveSlotType;

	[Token(Token = "0x40094A6")]
	[FieldOffset(Offset = "0x20")]
	public ExperienceMode m_XPMode;

	[SerializeField]
	[Token(Token = "0x40094A7")]
	[FieldOffset(Offset = "0x28")]
	private MissionServicesManager m_MissionServicesPrefab;

	[Token(Token = "0x40094A8")]
	[FieldOffset(Offset = "0x30")]
	public SceneLoadCondition[] m_LoadConditions;

	[Token(Token = "0x40094A9")]
	[FieldOffset(Offset = "0x38")]
	public bool m_StartRegionSelectionBlocked;

	[SerializeField]
	[Token(Token = "0x40094AA")]
	[FieldOffset(Offset = "0x40")]
	protected List<GameplayTag> m_ActiveTags;

	[SerializeField]
	[Token(Token = "0x40094AB")]
	[FieldOffset(Offset = "0x48")]
	private LocalizedString m_ModeName;

	[SerializeField]
	[Token(Token = "0x40094AC")]
	[FieldOffset(Offset = "0x50")]
	private LocalizedString m_Description;

	[Tooltip("Shown in the loading screen when playing this game mode.")]
	[Token(Token = "0x40094AD")]
	[FieldOffset(Offset = "0x58")]
	public LocalizedString m_LoadingText;

	[Tooltip("Icon sprite name to use in the pause menu")]
	[Token(Token = "0x40094AE")]
	[FieldOffset(Offset = "0x60")]
	public string m_SpriteName;

	[Token(Token = "0x40094AF")]
	[FieldOffset(Offset = "0x68")]
	private MissionServicesManager m_MissionServicesManager;

	[Token(Token = "0x17000B49")]
	public LocalizedString Name
	{
		[Token(Token = "0x600822B")]
		[Address(RVA = "0x4B2FE0", Offset = "0x4B1DE0", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000B4A")]
	public LocalizedString Description
	{
		[Token(Token = "0x600822C")]
		[Address(RVA = "0x669640", Offset = "0x668440", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000B4B")]
	public virtual StartGearData StartGear
	{
		[Token(Token = "0x600822F")]
		[Address(RVA = "0x122D410", Offset = "0x122C210", Length = "0xE9")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600822D")]
	[Address(RVA = "0x122CE20", Offset = "0x122BC20", Length = "0xEF")]
	public MissionServicesManager GetMissionServicesManager(bool createIfNeeded)
	{
		return null;
	}

	[Token(Token = "0x600822E")]
	[Address(RVA = "0x122CF10", Offset = "0x122BD10", Length = "0x4FA")]
	public void DestroyMissionServicesManager()
	{
	}

	[Token(Token = "0x6008230")]
	[Address(RVA = "0x122D500", Offset = "0x122C300", Length = "0x1B")]
	public bool HasActiveTag(GameplayTag tag)
	{
		return false;
	}

	[Token(Token = "0x6008231")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public virtual void Selected()
	{
	}

	[Token(Token = "0x6008232")]
	[Address(RVA = "0x122D520", Offset = "0x122C320", Length = "0x1D3")]
	public virtual void StartGame()
	{
	}

	[Token(Token = "0x6008233")]
	[Address(RVA = "0x122D700", Offset = "0x122C500", Length = "0x7")]
	public virtual void EndGame()
	{
	}

	[Token(Token = "0x6008234")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public virtual void SaveGame(SlotData slotData)
	{
	}

	[Token(Token = "0x6008235")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public virtual void LoadGame(string slotName)
	{
	}

	[Token(Token = "0x6008236")]
	[Address(RVA = "0x122D700", Offset = "0x122C500", Length = "0x7")]
	public virtual void Unselected()
	{
	}

	[Token(Token = "0x6008237")]
	[Address(RVA = "0x122D710", Offset = "0x122C510", Length = "0x1F2")]
	private void CreateMissionServicesManager()
	{
	}

	[Token(Token = "0x6008238")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public virtual void ApplyCustomWeatherTransitionWeights(WeatherTransitionWeights m_Weights)
	{
	}

	[Token(Token = "0x6008239")]
	[Address(RVA = "0x4A22A0", Offset = "0x4A10A0", Length = "0x7")]
	protected GameModeConfig()
	{
	}
}
