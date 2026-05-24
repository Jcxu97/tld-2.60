using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.ModularElectrolizer;
using TLD.UI.Generics;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;
using UnityEngine;

[Token(Token = "0x2000711")]
public class AuroraManager : MonoBehaviour
{
	[SerializeField]
	[Token(Token = "0x4004B11")]
	[FieldOffset(Offset = "0x20")]
	private PanelReference<Panel_Loading> m_Loading;

	[Token(Token = "0x4004B12")]
	[FieldOffset(Offset = "0x28")]
	public string m_AuroaAudio;

	[Range(0f, 1f)]
	[Token(Token = "0x4004B13")]
	[FieldOffset(Offset = "0x30")]
	public float m_SecondsBetweenFlyoverScale;

	[Range(0f, 10f)]
	[Token(Token = "0x4004B14")]
	[FieldOffset(Offset = "0x34")]
	public float m_WildlifeDetectionRangeScale;

	[Range(0f, 10f)]
	[Token(Token = "0x4004B15")]
	[FieldOffset(Offset = "0x38")]
	public float m_WildlifeFleeDistanceScale;

	[Range(0f, 1f)]
	[Token(Token = "0x4004B16")]
	[FieldOffset(Offset = "0x3C")]
	public float m_DamageToPredatorsScale;

	[Range(0f, 10f)]
	[Token(Token = "0x4004B17")]
	[FieldOffset(Offset = "0x40")]
	public float m_PredatorInflictDamageScale;

	[Range(0f, 1f)]
	[Token(Token = "0x4004B18")]
	[FieldOffset(Offset = "0x44")]
	public float m_PredatorFleeChanceScale;

	[Range(0f, 10f)]
	[Token(Token = "0x4004B19")]
	[FieldOffset(Offset = "0x48")]
	public float m_PredatorAttackDistanceScale;

	[Token(Token = "0x4004B1A")]
	public static bool m_ForceDisable;

	[Token(Token = "0x4004B1B")]
	public static bool s_UseJobs;

	[Token(Token = "0x4004B1C")]
	[FieldOffset(Offset = "0x4C")]
	public bool m_UseCinematicColours;

	[Token(Token = "0x4004B1D")]
	[FieldOffset(Offset = "0x50")]
	public MinMax m_RedTint;

	[Token(Token = "0x4004B1E")]
	[FieldOffset(Offset = "0x58")]
	public MinMax m_GreenTint;

	[Token(Token = "0x4004B1F")]
	[FieldOffset(Offset = "0x60")]
	public MinMax m_BlueTint;

	[Token(Token = "0x4004B20")]
	[FieldOffset(Offset = "0x68")]
	public MinMax m_AlphaControl;

	[Tooltip("RGBA cycle times, in seconds.")]
	[Token(Token = "0x4004B21")]
	[FieldOffset(Offset = "0x70")]
	public Vector4 m_RgbaCycleTime;

	[Header("Electrolyzers")]
	[Token(Token = "0x4004B22")]
	[FieldOffset(Offset = "0x80")]
	private Vector4 m_ColorTimers;

	[Token(Token = "0x4004B23")]
	[FieldOffset(Offset = "0x90")]
	public Gradient m_ElectricalColors;

	[Token(Token = "0x4004B24")]
	[FieldOffset(Offset = "0x98")]
	public MinMax m_ElectricalSaturation;

	[Token(Token = "0x4004B25")]
	[FieldOffset(Offset = "0xA0")]
	public MinMax m_ElectricalValue;

	[Tooltip("Primary speed control for colour systems.")]
	[Range(0f, 100f)]
	[Token(Token = "0x4004B26")]
	[FieldOffset(Offset = "0xA8")]
	private float m_SpeedPercentage;

	[Token(Token = "0x4004B27")]
	[FieldOffset(Offset = "0xAC")]
	private float m_FullyActiveValue;

	[Token(Token = "0x4004B28")]
	private static List<GameObject> m_AuroraGameObjectList;

	[Token(Token = "0x4004B29")]
	private static List<AuroraModularElectrolizer> m_AuroraElectrolizerList;

	[Token(Token = "0x4004B2A")]
	private static List<bool> m_AuroraElectrolizerEnabledList;

	[Token(Token = "0x4004B2B")]
	private static List<Vector3> m_AuroraElectrolizerPosList;

	[Token(Token = "0x4004B2C")]
	private static List<AuroraLightingSimple> m_AuroraLightSimpleList;

	[Token(Token = "0x4004B2D")]
	private static List<Vector3> m_AuroraLightSimplePosList;

	[Token(Token = "0x4004B2E")]
	private static List<AuroraActivatedToggle> m_AuroraActivatedToggleList;

	[Token(Token = "0x4004B2F")]
	private static AuroraManagerSaveDataProxy m_AuroraManagerSaveDataProxy;

	[Token(Token = "0x4004B30")]
	private static AuroraFieldsSceneManager m_AuroraFieldsSceneManager;

	[Token(Token = "0x4004B31")]
	private static NativeArray<float3> m_AuroraElectrolizerPosArray;

	[Token(Token = "0x4004B32")]
	private static NativeArray<float> m_AuroraElectrolizerMaxDistSqr;

	[Token(Token = "0x4004B33")]
	private static NativeArray<float> m_AuroraElectrolizerCurDistSqr;

	[Token(Token = "0x4004B34")]
	private static NativeArray<float> m_AuroraElectrolizerRangeDiff;

	[Token(Token = "0x4004B35")]
	private static NativeArray<float> m_AuroraElectrolizerTimer;

	[Token(Token = "0x4004B36")]
	private static JobHandle m_ElectrolizerJobHandle;

	[Token(Token = "0x4004B37")]
	private static float m_PhiTimer;

	[Token(Token = "0x4004B38")]
	private static bool s_NativeArraySetup;

	[Token(Token = "0x4004B39")]
	private static bool s_ForceArrayRebuild;

	[Token(Token = "0x4004B3A")]
	[FieldOffset(Offset = "0xB0")]
	private int m_NumFramesNotActive;

	[Token(Token = "0x4004B3B")]
	[FieldOffset(Offset = "0xB4")]
	private bool m_StartHasBeenCalled;

	[Token(Token = "0x4004B3C")]
	[FieldOffset(Offset = "0xB8")]
	private uint m_AuroaAudioInstance;

	[Token(Token = "0x4004B3D")]
	[FieldOffset(Offset = "0xBC")]
	private float m_NormalizedActiveSentToWise;

	[Token(Token = "0x4004B3E")]
	[FieldOffset(Offset = "0xC0")]
	private float m_NormalizedActive;

	[Token(Token = "0x4004B3F")]
	[FieldOffset(Offset = "0xC4")]
	private bool m_ForceAuroraNextOpportunity;

	[Token(Token = "0x4004B40")]
	[FieldOffset(Offset = "0xC5")]
	private bool m_ForceAuroraEarlyWindowAllowed;

	[Token(Token = "0x4004B41")]
	[FieldOffset(Offset = "0xC6")]
	private bool m_ForceAuroraLateWindowAllowed;

	[Token(Token = "0x4004B42")]
	[FieldOffset(Offset = "0xC8")]
	private float m_ForceAuroraDurationOverride;

	[Token(Token = "0x4004B43")]
	[FieldOffset(Offset = "0xCC")]
	private bool m_IsDoingForceAurora;

	[Token(Token = "0x4004B44")]
	[FieldOffset(Offset = "0xCD")]
	private bool m_HasForcedAuroraStarted;

	[Token(Token = "0x4004B45")]
	[FieldOffset(Offset = "0xD0")]
	private int m_NumAurorasForSave;

	[Token(Token = "0x4004B46")]
	[FieldOffset(Offset = "0xD4")]
	private bool m_BoostAuroraElectrolyzer;

	[Token(Token = "0x4004B47")]
	[FieldOffset(Offset = "0xD5")]
	private bool m_IsElectrolizerActive;

	[Token(Token = "0x4004B48")]
	[FieldOffset(Offset = "0xD8")]
	private float m_LastAuroraDays;

	[Token(Token = "0x1700031A")]
	public int NumAuroras
	{
		[Token(Token = "0x6003DE2")]
		[Address(RVA = "0xBFB8A0", Offset = "0xBFA6A0", Length = "0x7")]
		get
		{
			return 0;
		}
	}

	[Token(Token = "0x6003DE3")]
	[Address(RVA = "0xBFB8B0", Offset = "0xBFA6B0", Length = "0x1F7")]
	public void Start()
	{
	}

	[Token(Token = "0x6003DE4")]
	[Address(RVA = "0xBFBAB0", Offset = "0xBFA8B0", Length = "0x190")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6003DE5")]
	[Address(RVA = "0xBFBC50", Offset = "0xBFAA50", Length = "0x370")]
	public void Update()
	{
	}

	[Token(Token = "0x6003DE6")]
	[Address(RVA = "0xBFBFD0", Offset = "0xBFADD0", Length = "0x206")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x6003DE7")]
	[Address(RVA = "0xBFC1E0", Offset = "0xBFAFE0", Length = "0x17F")]
	public void Deserialize(string text)
	{
	}

	[Token(Token = "0x6003DE8")]
	[Address(RVA = "0xBFC360", Offset = "0xBFB160", Length = "0x6E")]
	public static void RegisterAuroraField(AuroraField auroraField)
	{
	}

	[Token(Token = "0x6003DE9")]
	[Address(RVA = "0xBFC3D0", Offset = "0xBFB1D0", Length = "0x173")]
	public static void UnRegisterAuroraField(AuroraField auroraField)
	{
	}

	[Token(Token = "0x6003DEA")]
	[Address(RVA = "0xBFC550", Offset = "0xBFB350", Length = "0x9E")]
	public static bool IsRegisteredAuroraField(AuroraField auroraField)
	{
		return false;
	}

	[Token(Token = "0x6003DEB")]
	[Address(RVA = "0xBFC5F0", Offset = "0xBFB3F0", Length = "0xBE")]
	public static void RegisterAuroraGameObject(GameObject go)
	{
	}

	[Token(Token = "0x6003DEC")]
	[Address(RVA = "0xBFC6B0", Offset = "0xBFB4B0", Length = "0x442")]
	public static void RegisterAuroraElectrolizer(AuroraModularElectrolizer auroraElectrolizer)
	{
	}

	[Token(Token = "0x6003DED")]
	[Address(RVA = "0xBFCB00", Offset = "0xBFB900", Length = "0x242")]
	public static void RegisterAuroraLightSimple(AuroraLightingSimple auroraLightSimple)
	{
	}

	[Token(Token = "0x6003DEE")]
	[Address(RVA = "0xBFCD50", Offset = "0xBFBB50", Length = "0x54")]
	public static AuroraFieldsSceneManager GetAuroraFieldsSceneManager()
	{
		return null;
	}

	[Token(Token = "0x6003DEF")]
	[Address(RVA = "0xBFCDB0", Offset = "0xBFBBB0", Length = "0x54")]
	public static List<AuroraModularElectrolizer> GetAuroraElectrolizerList()
	{
		return null;
	}

	[Token(Token = "0x6003DF0")]
	[Address(RVA = "0xBFCE10", Offset = "0xBFBC10", Length = "0xBE")]
	public static void RegisterAuroraActivatedToggle(AuroraActivatedToggle auroraActivatedToggle)
	{
	}

	[Token(Token = "0x6003DF1")]
	[Address(RVA = "0xBFCED0", Offset = "0xBFBCD0", Length = "0x54")]
	public static List<AuroraActivatedToggle> GetAuroraActivatedToggleList()
	{
		return null;
	}

	[Token(Token = "0x6003DF2")]
	[Address(RVA = "0xBFCF30", Offset = "0xBFBD30", Length = "0x2CA")]
	public static void Reset()
	{
	}

	[Token(Token = "0x6003DF3")]
	[Address(RVA = "0xBFD200", Offset = "0xBFC000", Length = "0x193")]
	private void ResetJobs()
	{
	}

	[Token(Token = "0x6003DF4")]
	[Address(RVA = "0xBFD3A0", Offset = "0xBFC1A0", Length = "0x241")]
	public static void DisposeNativeArrays()
	{
	}

	[Token(Token = "0x6003DF5")]
	[Address(RVA = "0xBFD5F0", Offset = "0xBFC3F0", Length = "0x6C")]
	public bool AuroraIsActive()
	{
		return false;
	}

	[Token(Token = "0x6003DF6")]
	[Address(RVA = "0xBFD660", Offset = "0xBFC460", Length = "0x2D")]
	public float GetSecondsBetweenFlyoverScale()
	{
		return 0f;
	}

	[Token(Token = "0x6003DF7")]
	[Address(RVA = "0xBFD690", Offset = "0xBFC490", Length = "0x2D")]
	public float GetWildlifeDetectionRangeScale()
	{
		return 0f;
	}

	[Token(Token = "0x6003DF8")]
	[Address(RVA = "0xBFD6C0", Offset = "0xBFC4C0", Length = "0x2D")]
	public float GetWildlifeFleeDistanceScale()
	{
		return 0f;
	}

	[Token(Token = "0x6003DF9")]
	[Address(RVA = "0xBFD6F0", Offset = "0xBFC4F0", Length = "0x2D")]
	public float GetDamageToPredatorsScale()
	{
		return 0f;
	}

	[Token(Token = "0x6003DFA")]
	[Address(RVA = "0xBFD720", Offset = "0xBFC520", Length = "0x2D")]
	public float GetPredatorInflictDamageScale()
	{
		return 0f;
	}

	[Token(Token = "0x6003DFB")]
	[Address(RVA = "0xBFD750", Offset = "0xBFC550", Length = "0x2D")]
	public float GetPredatorFleeChanceScale()
	{
		return 0f;
	}

	[Token(Token = "0x6003DFC")]
	[Address(RVA = "0xBFD780", Offset = "0xBFC580", Length = "0x2D")]
	public float GetPredatorAttackDistanceScale()
	{
		return 0f;
	}

	[Token(Token = "0x6003DFD")]
	[Address(RVA = "0x557970", Offset = "0x556770", Length = "0x9")]
	public float GetNormalizedAlpha()
	{
		return 0f;
	}

	[Token(Token = "0x6003DFE")]
	[Address(RVA = "0xBFD7B0", Offset = "0xBFC5B0", Length = "0xD")]
	public float GetNormalizedAlphaSquare()
	{
		return 0f;
	}

	[Token(Token = "0x6003DFF")]
	[Address(RVA = "0xBFD7C0", Offset = "0xBFC5C0", Length = "0x1D")]
	public void ForceAuroraNextOpportunity(bool earlyWindowAllowed, bool lateWindowAllowed, float durationOverride)
	{
	}

	[Token(Token = "0x6003E00")]
	[Address(RVA = "0xBFD7E0", Offset = "0xBFC5E0", Length = "0x13")]
	public bool IsFullyActive()
	{
		return false;
	}

	[Token(Token = "0x6003E01")]
	[Address(RVA = "0x93A860", Offset = "0x939660", Length = "0x7")]
	public void BoostAurora(bool isBoostEnabled)
	{
	}

	[Token(Token = "0x6003E02")]
	[Address(RVA = "0x93A870", Offset = "0x939670", Length = "0x8")]
	public bool IsAuroraBoostEnabled()
	{
		return false;
	}

	[Token(Token = "0x6003E03")]
	[Address(RVA = "0xBFD800", Offset = "0xBFC600", Length = "0x9AE")]
	private void StartElectrolizerJob(float deltaTime, Vector3 camPos)
	{
	}

	[Token(Token = "0x6003E04")]
	[Address(RVA = "0xBFE1B0", Offset = "0xBFCFB0", Length = "0xAB8")]
	private void UpdateAuroraElectrolizers(float deltaTime, Vector3 camPos)
	{
	}

	[Token(Token = "0x6003E05")]
	[Address(RVA = "0xBFEC70", Offset = "0xBFDA70", Length = "0x341")]
	private void UpdateActivation()
	{
	}

	[Token(Token = "0x6003E06")]
	[Address(RVA = "0xBFEFC0", Offset = "0xBFDDC0", Length = "0x1EB")]
	private void MaybeForceAuroraAfterDays()
	{
	}

	[Token(Token = "0x6003E07")]
	[Address(RVA = "0xBFF1B0", Offset = "0xBFDFB0", Length = "0xBD")]
	private void UpdateAuroraValue()
	{
	}

	[Token(Token = "0x6003E08")]
	[Address(RVA = "0xBFF270", Offset = "0xBFE070", Length = "0x555")]
	private void UpdateElectrolizerState()
	{
	}

	[Token(Token = "0x6003E09")]
	[Address(RVA = "0xBFF7D0", Offset = "0xBFE5D0", Length = "0x74")]
	private void UpdateUniStormAuroraLighting()
	{
	}

	[Token(Token = "0x6003E0A")]
	[Address(RVA = "0xBFF850", Offset = "0xBFE650", Length = "0x416")]
	private void UpdateForceAurora()
	{
	}

	[Token(Token = "0x6003E0B")]
	[Address(RVA = "0xBFFC70", Offset = "0xBFEA70", Length = "0x1D1")]
	public Color GetAuroraColour()
	{
		return default(Color);
	}

	[Token(Token = "0x6003E0C")]
	[Address(RVA = "0xBFFE50", Offset = "0xBFEC50", Length = "0x6E")]
	public Color GetAuroraColourCorrected()
	{
		return default(Color);
	}

	[Token(Token = "0x6003E0D")]
	[Address(RVA = "0xBFFEC0", Offset = "0xBFECC0", Length = "0x24C")]
	public Color GetRandomElectricalColor(bool randomSaturation = true, bool randomBrightness = true)
	{
		return default(Color);
	}

	[Token(Token = "0x6003E0E")]
	[Address(RVA = "0x5737F0", Offset = "0x5725F0", Length = "0x4")]
	public void SetCinematicColours(bool useCineColours)
	{
	}

	[Token(Token = "0x6003E0F")]
	[Address(RVA = "0x5737E0", Offset = "0x5725E0", Length = "0x5")]
	public bool IsUsingCinematicColours()
	{
		return false;
	}

	[Token(Token = "0x6003E10")]
	[Address(RVA = "0xC00110", Offset = "0xBFEF10", Length = "0x1CE")]
	public void UpdateColour()
	{
	}

	[Token(Token = "0x6003E11")]
	[Address(RVA = "0xC002E0", Offset = "0xBFF0E0", Length = "0x1E8")]
	private void UpdateAuroraAudio()
	{
	}

	[Token(Token = "0x6003E12")]
	[Address(RVA = "0xC004D0", Offset = "0xBFF2D0", Length = "0x57")]
	private void AuroraAudioStop()
	{
	}

	[Token(Token = "0x6003E13")]
	[Address(RVA = "0xC00530", Offset = "0xBFF330", Length = "0xA0")]
	private void AuroraAudioPlay()
	{
	}

	[Token(Token = "0x6003E14")]
	[Address(RVA = "0xC005D0", Offset = "0xBFF3D0", Length = "0x99")]
	private void AuroraAudioSetIntensityRTPC()
	{
	}

	[Token(Token = "0x6003E15")]
	[Address(RVA = "0xC00670", Offset = "0xBFF470", Length = "0x27C")]
	private bool GetForceDisableForNewGame()
	{
		return false;
	}

	[Token(Token = "0x6003E16")]
	[Address(RVA = "0xC008F0", Offset = "0xBFF6F0", Length = "0x124")]
	public static void OnAuroraElectrolizerEnableChanged(AuroraModularElectrolizer a, bool isEnabled)
	{
	}

	[Token(Token = "0x6003E17")]
	[Address(RVA = "0xC00A20", Offset = "0xBFF820", Length = "0x340")]
	public AuroraManager()
	{
	}
}
