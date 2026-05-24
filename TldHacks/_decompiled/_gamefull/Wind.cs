using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000334")]
public class Wind : MonoBehaviour
{
	[Token(Token = "0x4001C90")]
	public const float MAX_GUST = 0.25f;

	[Token(Token = "0x4001C91")]
	[FieldOffset(Offset = "0x20")]
	public WindSettings[] m_WindSettings;

	[Range(10f, 100f)]
	[Token(Token = "0x4001C92")]
	[FieldOffset(Offset = "0x28")]
	public float m_MaxWindMPH;

	[Token(Token = "0x4001C93")]
	[FieldOffset(Offset = "0x2C")]
	public float m_HoursBetweenWindChangeMin;

	[Token(Token = "0x4001C94")]
	[FieldOffset(Offset = "0x30")]
	public float m_HoursBetweenWindChangeMax;

	[Token(Token = "0x4001C95")]
	[FieldOffset(Offset = "0x34")]
	public float m_HoursForTransitionMin;

	[Token(Token = "0x4001C96")]
	[FieldOffset(Offset = "0x38")]
	public float m_HoursForTransitionMax;

	[Token(Token = "0x4001C97")]
	[FieldOffset(Offset = "0x3C")]
	public float m_Gust_NoiseStepSpeed;

	[Token(Token = "0x4001C98")]
	[FieldOffset(Offset = "0x40")]
	public float m_Gust_NoiseOctave2StepScalar;

	[Token(Token = "0x4001C99")]
	[FieldOffset(Offset = "0x44")]
	public float m_Gust_NoiseOctave2ResultScalar;

	[Range(0f, 90f)]
	[Token(Token = "0x4001C9A")]
	[FieldOffset(Offset = "0x48")]
	public float m_LateralBluster_Limit;

	[Token(Token = "0x4001C9B")]
	[FieldOffset(Offset = "0x4C")]
	public float m_LateralBluster_NoiseStepSpeed;

	[Token(Token = "0x4001C9C")]
	[FieldOffset(Offset = "0x50")]
	public float m_LateralBluster_NoiseOctave2StepScalar;

	[Token(Token = "0x4001C9D")]
	[FieldOffset(Offset = "0x54")]
	public float m_LateralBluster_NoiseOctave2ResultScalar;

	[Range(0f, 9f)]
	[Token(Token = "0x4001C9E")]
	[FieldOffset(Offset = "0x58")]
	public float m_VerticalBluster_Limit;

	[Token(Token = "0x4001C9F")]
	[FieldOffset(Offset = "0x5C")]
	public float m_VerticalBluster_NoiseStepSpeed;

	[Token(Token = "0x4001CA0")]
	[FieldOffset(Offset = "0x60")]
	public float m_VerticalBluster_NoiseOctave2StepScalar;

	[Token(Token = "0x4001CA1")]
	[FieldOffset(Offset = "0x64")]
	public float m_VerticalBluster_NoiseOctave2ResultScalar;

	[Token(Token = "0x4001CA2")]
	[FieldOffset(Offset = "0x68")]
	private ActiveWindSettings m_ActiveSettings;

	[Token(Token = "0x4001CA3")]
	[FieldOffset(Offset = "0x70")]
	private ActiveWindSettings m_SourceSettings;

	[Token(Token = "0x4001CA4")]
	[FieldOffset(Offset = "0x78")]
	private ActiveWindSettings m_TargetSettings;

	[Token(Token = "0x4001CA5")]
	[FieldOffset(Offset = "0x80")]
	private Vector2 m_Gust_NoisePos1;

	[Token(Token = "0x4001CA6")]
	[FieldOffset(Offset = "0x88")]
	private Vector2 m_Gust_NoiseStepVector1;

	[Token(Token = "0x4001CA7")]
	[FieldOffset(Offset = "0x90")]
	private Vector2 m_Gust_NoisePos2;

	[Token(Token = "0x4001CA8")]
	[FieldOffset(Offset = "0x98")]
	private Vector2 m_Gust_NoiseStepVector2;

	[Token(Token = "0x4001CA9")]
	[FieldOffset(Offset = "0xA0")]
	private Vector2 m_LateralBluster_NoisePos1;

	[Token(Token = "0x4001CAA")]
	[FieldOffset(Offset = "0xA8")]
	private Vector2 m_LateralBluster_NoiseStepVector1;

	[Token(Token = "0x4001CAB")]
	[FieldOffset(Offset = "0xB0")]
	private Vector2 m_LateralBluster_NoisePos2;

	[Token(Token = "0x4001CAC")]
	[FieldOffset(Offset = "0xB8")]
	private Vector2 m_LateralBluster_NoiseStepVector2;

	[Token(Token = "0x4001CAD")]
	[FieldOffset(Offset = "0xC0")]
	private Vector2 m_VerticalBluster_NoisePos1;

	[Token(Token = "0x4001CAE")]
	[FieldOffset(Offset = "0xC8")]
	private Vector2 m_VerticalBluster_NoiseStepVector1;

	[Token(Token = "0x4001CAF")]
	[FieldOffset(Offset = "0xD0")]
	private Vector2 m_VerticalBluster_NoisePos2;

	[Token(Token = "0x4001CB0")]
	[FieldOffset(Offset = "0xD8")]
	private Vector2 m_VerticalBluster_NoiseStepVector2;

	[Token(Token = "0x4001CB1")]
	[FieldOffset(Offset = "0xE0")]
	private WindStrength m_CurrentStrength;

	[Token(Token = "0x4001CB2")]
	[FieldOffset(Offset = "0xE4")]
	private float m_CurrentMPH_Base;

	[Token(Token = "0x4001CB3")]
	[FieldOffset(Offset = "0xE8")]
	private float m_CurrentAngleDeg_Base;

	[Token(Token = "0x4001CB4")]
	[FieldOffset(Offset = "0xEC")]
	private Vector3 m_CurrentDirection_Base;

	[Token(Token = "0x4001CB5")]
	[FieldOffset(Offset = "0xF8")]
	private float m_CurrentMPH;

	[Token(Token = "0x4001CB6")]
	[FieldOffset(Offset = "0xFC")]
	private float m_CurrentAngleDeg;

	[Token(Token = "0x4001CB7")]
	[FieldOffset(Offset = "0x100")]
	private Vector3 m_CurrentDirection;

	[Token(Token = "0x4001CB8")]
	[FieldOffset(Offset = "0x10C")]
	private float m_CurrentPitch;

	[Token(Token = "0x4001CB9")]
	[FieldOffset(Offset = "0x110")]
	private float m_LateralBluster;

	[Token(Token = "0x4001CBA")]
	[FieldOffset(Offset = "0x114")]
	private float m_VerticalBluster;

	[Token(Token = "0x4001CBB")]
	[FieldOffset(Offset = "0x118")]
	private float m_GustScalar;

	[Token(Token = "0x4001CBC")]
	[FieldOffset(Offset = "0x11C")]
	private float m_GustScalarAdjusted;

	[Token(Token = "0x4001CBD")]
	[FieldOffset(Offset = "0x120")]
	private float m_TransitionTimeTODSeconds;

	[Token(Token = "0x4001CBE")]
	[FieldOffset(Offset = "0x124")]
	private float m_PhaseElapsedTODSeconds;

	[Token(Token = "0x4001CBF")]
	[FieldOffset(Offset = "0x128")]
	private float m_PhaseDurationHours;

	[Token(Token = "0x4001CC0")]
	[FieldOffset(Offset = "0x12C")]
	private float m_BaseWindChill;

	[Token(Token = "0x4001CC1")]
	[FieldOffset(Offset = "0x130")]
	private float m_WindChill;

	[Token(Token = "0x4001CC2")]
	[FieldOffset(Offset = "0x138")]
	private ParticleSystem m_LightSnowParticleSystem;

	[Token(Token = "0x4001CC3")]
	[FieldOffset(Offset = "0x140")]
	private ParticleSystem m_HeavySnowParticleSystem;

	[Token(Token = "0x4001CC4")]
	[FieldOffset(Offset = "0x148")]
	private WindZone m_WindZone;

	[Token(Token = "0x4001CC5")]
	[FieldOffset(Offset = "0x150")]
	private Transform m_WindZoneTransform;

	[Token(Token = "0x4001CC6")]
	[FieldOffset(Offset = "0x158")]
	private List<WindKiller> m_WindKillers;

	[HideInInspector]
	[Token(Token = "0x4001CC7")]
	[FieldOffset(Offset = "0x160")]
	public float m_LastWindIntensityBlendSentToWise;

	[HideInInspector]
	[Token(Token = "0x4001CC8")]
	[FieldOffset(Offset = "0x164")]
	public float m_LastWindActualSpeedSentToWise;

	[HideInInspector]
	[Token(Token = "0x4001CC9")]
	[FieldOffset(Offset = "0x168")]
	public float m_LastWindGustStrengthSentToWise;

	[Token(Token = "0x4001CCA")]
	[FieldOffset(Offset = "0x16C")]
	private float m_LastPlayerWindAngleSentToWise;

	[Token(Token = "0x4001CCB")]
	[FieldOffset(Offset = "0x170")]
	private float m_LockedWindSpeed;

	[Token(Token = "0x4001CCC")]
	[FieldOffset(Offset = "0x174")]
	private bool m_NeverCalmWind;

	[Token(Token = "0x4001CCD")]
	[FieldOffset(Offset = "0x175")]
	private bool m_StartHasBeenCalled;

	[Token(Token = "0x4001CCE")]
	[FieldOffset(Offset = "0x178")]
	private uint m_WindLoopAudioInstance;

	[Token(Token = "0x4001CCF")]
	[FieldOffset(Offset = "0x17C")]
	private bool m_WindAudioForceStopped;

	[Token(Token = "0x4001CD0")]
	[FieldOffset(Offset = "0x180")]
	private float m_ArtificalWindSpeedIncrease;

	[Token(Token = "0x4001CD1")]
	private static WindSaveDataProxy m_WindSaveDataProxy;

	[Token(Token = "0x4001CD2")]
	[FieldOffset(Offset = "0x184")]
	public float m_OcclusionTestRange;

	[Token(Token = "0x4001CD3")]
	[FieldOffset(Offset = "0x188")]
	public float m_OcclusionTestFOV;

	[Token(Token = "0x4001CD4")]
	[FieldOffset(Offset = "0x18C")]
	public float m_OcclusionReduceWindchillPercent;

	[Token(Token = "0x4001CD5")]
	[FieldOffset(Offset = "0x190")]
	public AudioOcclusionLevel m_OcclusionAudioLevel;

	[Token(Token = "0x4001CD6")]
	[FieldOffset(Offset = "0x194")]
	private bool m_PlayerOccluded;

	[Token(Token = "0x4001CD7")]
	[FieldOffset(Offset = "0x198")]
	private Vector3 m_LastTestPosition;

	[Token(Token = "0x6001A2A")]
	[Address(RVA = "0x749CE0", Offset = "0x748AE0", Length = "0x220")]
	public void Start()
	{
	}

	[Token(Token = "0x6001A2B")]
	[Address(RVA = "0x749F10", Offset = "0x748D10", Length = "0x4CA")]
	private void ResetNoise()
	{
	}

	[Token(Token = "0x6001A2C")]
	[Address(RVA = "0x74A3E0", Offset = "0x7491E0", Length = "0x446")]
	private void UpdateNoise()
	{
	}

	[Token(Token = "0x6001A2D")]
	[Address(RVA = "0x74A830", Offset = "0x749630", Length = "0x597")]
	public void Update()
	{
	}

	[Token(Token = "0x6001A2E")]
	[Address(RVA = "0x74ADD0", Offset = "0x749BD0", Length = "0x5C")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6001A2F")]
	[Address(RVA = "0x74AE30", Offset = "0x749C30", Length = "0x612")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x6001A30")]
	[Address(RVA = "0x74B450", Offset = "0x74A250", Length = "0x2E5")]
	public void Deserialize(string text)
	{
	}

	[Token(Token = "0x6001A31")]
	[Address(RVA = "0x74B740", Offset = "0x74A540", Length = "0x164")]
	public void StartRandomPhase(bool forceCalm)
	{
	}

	[Token(Token = "0x6001A32")]
	[Address(RVA = "0x74B8B0", Offset = "0x74A6B0", Length = "0x75")]
	public void StartPhase(WindDirection direction, WindStrength strength)
	{
	}

	[Token(Token = "0x6001A33")]
	[Address(RVA = "0x74B930", Offset = "0x74A730", Length = "0x496")]
	public void StartPhase(WindStrength strength, float angle = -1f)
	{
	}

	[Token(Token = "0x6001A34")]
	[Address(RVA = "0x74BDD0", Offset = "0x74ABD0", Length = "0x11A")]
	public void StartPhaseImmediate(WindDirection direction, WindStrength strength)
	{
	}

	[Token(Token = "0x6001A35")]
	[Address(RVA = "0x74BEF0", Offset = "0x74ACF0", Length = "0xD0")]
	public void StartPhaseImmediate(WindStrength strength, float angle = -1f)
	{
	}

	[Token(Token = "0x6001A36")]
	[Address(RVA = "0x74ADD0", Offset = "0x749BD0", Length = "0x5C")]
	public void ForceStopAudioLoop()
	{
	}

	[Token(Token = "0x6001A37")]
	[Address(RVA = "0x74BFD0", Offset = "0x74ADD0", Length = "0x60")]
	public static float DirectionToAngle(WindDirection direction)
	{
		return 0f;
	}

	[Token(Token = "0x6001A38")]
	[Address(RVA = "0x74C050", Offset = "0x74AE50", Length = "0x11")]
	public void AddArtificialWindSpeedIncrease(float increase)
	{
	}

	[Token(Token = "0x6001A39")]
	[Address(RVA = "0x74C070", Offset = "0x74AE70", Length = "0x7")]
	public WindStrength GetStrength()
	{
		return default(WindStrength);
	}

	[Token(Token = "0x6001A3A")]
	[Address(RVA = "0x74C080", Offset = "0x74AE80", Length = "0xE")]
	public float GetNormalizedIntensity()
	{
		return 0f;
	}

	[Token(Token = "0x6001A3B")]
	[Address(RVA = "0x74C090", Offset = "0x74AE90", Length = "0x9")]
	public float GetSpeedMPH_Base()
	{
		return 0f;
	}

	[Token(Token = "0x6001A3C")]
	[Address(RVA = "0x74C0A0", Offset = "0x74AEA0", Length = "0x9")]
	public float GetSpeedMPH()
	{
		return 0f;
	}

	[Token(Token = "0x6001A3D")]
	[Address(RVA = "0x74C0B0", Offset = "0x74AEB0", Length = "0x1D")]
	public float GetTargetSpeedMPH()
	{
		return 0f;
	}

	[Token(Token = "0x6001A3E")]
	[Address(RVA = "0x74C0D0", Offset = "0x74AED0", Length = "0x9")]
	public float GetWindAngle_Base()
	{
		return 0f;
	}

	[Token(Token = "0x6001A3F")]
	[Address(RVA = "0x74C0E0", Offset = "0x74AEE0", Length = "0x9")]
	public float GetWindAngle()
	{
		return 0f;
	}

	[Token(Token = "0x6001A40")]
	[Address(RVA = "0x74C0F0", Offset = "0x74AEF0", Length = "0x19")]
	public Vector3 GetWindDirection_Base()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6001A41")]
	[Address(RVA = "0x74C110", Offset = "0x74AF10", Length = "0x19")]
	public Vector3 GetWindDirection()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6001A42")]
	[Address(RVA = "0x74C130", Offset = "0x74AF30", Length = "0x2A")]
	public float GetWindLift()
	{
		return 0f;
	}

	[Token(Token = "0x6001A43")]
	[Address(RVA = "0x74C160", Offset = "0x74AF60", Length = "0x9")]
	public float GetBaseWindChill()
	{
		return 0f;
	}

	[Token(Token = "0x6001A44")]
	[Address(RVA = "0x74C170", Offset = "0x74AF70", Length = "0x9")]
	public float GetWindChill()
	{
		return 0f;
	}

	[Token(Token = "0x6001A45")]
	[Address(RVA = "0x74C180", Offset = "0x74AF80", Length = "0x62")]
	public void ForceImmediateWindChangeBasedOnWeather(WeatherStage ws)
	{
	}

	[Token(Token = "0x6001A46")]
	[Address(RVA = "0x74C1F0", Offset = "0x74AFF0", Length = "0x92")]
	public bool TooWindyForPlayerAction(float thresholdSpeedMPH)
	{
		return false;
	}

	[Token(Token = "0x6001A47")]
	[Address(RVA = "0x74C290", Offset = "0x74B090", Length = "0x10A")]
	public void AddWindKiller(WindKiller wk)
	{
	}

	[Token(Token = "0x6001A48")]
	[Address(RVA = "0x74C3A0", Offset = "0x74B1A0", Length = "0x9")]
	public float GetPlayerWindAngle()
	{
		return 0f;
	}

	[Token(Token = "0x6001A49")]
	[Address(RVA = "0x74C3B0", Offset = "0x74B1B0", Length = "0x19A")]
	private void MaybeChangePhase()
	{
	}

	[Token(Token = "0x6001A4A")]
	[Address(RVA = "0x74C550", Offset = "0x74B350", Length = "0x75F")]
	private void RefreshSettings()
	{
	}

	[Token(Token = "0x6001A4B")]
	[Address(RVA = "0x74CCB0", Offset = "0x74BAB0", Length = "0x31D")]
	private void UpdateWindZone()
	{
	}

	[Token(Token = "0x6001A4C")]
	[Address(RVA = "0x74CFD0", Offset = "0x74BDD0", Length = "0x114")]
	private void UpdateUniStormParticleSystems()
	{
	}

	[Token(Token = "0x6001A4D")]
	[Address(RVA = "0x74D0F0", Offset = "0x74BEF0", Length = "0x15A")]
	private void UpdateWindChill()
	{
	}

	[Token(Token = "0x6001A4E")]
	[Address(RVA = "0x74D250", Offset = "0x74C050", Length = "0x20C")]
	private float CalculateWindChill(float airTempCelsius)
	{
		return 0f;
	}

	[Token(Token = "0x6001A4F")]
	[Address(RVA = "0x74D460", Offset = "0x74C260", Length = "0xC9")]
	private WindStrength GetStrengthFromSpeed(float normalizedSpeed, out WindSettings ws)
	{
		ws = null;
		return default(WindStrength);
	}

	[Token(Token = "0x6001A50")]
	[Address(RVA = "0x74D530", Offset = "0x74C330", Length = "0x237")]
	private void SetWindAccelerationForAllInteractiveCloth()
	{
	}

	[Token(Token = "0x6001A51")]
	[Address(RVA = "0x74D770", Offset = "0x74C570", Length = "0x43E")]
	private void UpdateProceduralWind()
	{
	}

	[Token(Token = "0x6001A52")]
	[Address(RVA = "0x74DBB0", Offset = "0x74C9B0", Length = "0x151")]
	public float GetWindAngleRelativeToPlayer()
	{
		return 0f;
	}

	[Token(Token = "0x6001A53")]
	[Address(RVA = "0x74DD10", Offset = "0x74CB10", Length = "0x129")]
	public void ApplySceneOverrides(SceneWeatherOverrideData swo)
	{
	}

	[Token(Token = "0x6001A54")]
	[Address(RVA = "0x74DE40", Offset = "0x74CC40", Length = "0x9")]
	public void LockWindInstant(float mph)
	{
	}

	[Token(Token = "0x6001A55")]
	[Address(RVA = "0x74DE50", Offset = "0x74CC50", Length = "0x626")]
	private uint PlayProceduralWindAudio()
	{
		return 0u;
	}

	[Token(Token = "0x6001A56")]
	[Address(RVA = "0x74E480", Offset = "0x74D280", Length = "0x8")]
	public bool PlayerShelteredFromWind()
	{
		return false;
	}

	[Token(Token = "0x6001A57")]
	[Address(RVA = "0x74E490", Offset = "0x74D290", Length = "0x6C4")]
	public bool IsPositionOccludedFromWind(Vector3 pos)
	{
		return false;
	}

	[Token(Token = "0x6001A58")]
	[Address(RVA = "0x74EB60", Offset = "0x74D960", Length = "0x246")]
	private bool ShouldIgnoreWindOccluder(Collider collider)
	{
		return false;
	}

	[Token(Token = "0x6001A59")]
	[Address(RVA = "0x74EDB0", Offset = "0x74DBB0", Length = "0x28B")]
	public void UpdateWindOcclusion()
	{
	}

	[Token(Token = "0x6001A5A")]
	[Address(RVA = "0x74F040", Offset = "0x74DE40", Length = "0xFC")]
	private bool PointInsideWindKiller(Vector3 pos)
	{
		return false;
	}

	[Token(Token = "0x6001A5B")]
	[Address(RVA = "0x74F140", Offset = "0x74DF40", Length = "0xF2")]
	public Wind()
	{
	}
}
