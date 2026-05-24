using System;
using System.Collections.Generic;
using AK.Wwise;
using Cpp2ILInjected;
using UnityEngine;

namespace TLD.ModularElectrolizer;

[Token(Token = "0x20013CB")]
public class AuroraModularElectrolizer : MonoBehaviour
{
	[Header("Activation")]
	[Token(Token = "0x40090FE")]
	[FieldOffset(Offset = "0x20")]
	public ActivationParameters m_ActivationParameters;

	[Token(Token = "0x40090FF")]
	[FieldOffset(Offset = "0x28")]
	public bool m_RequiresAuroraField;

	[Token(Token = "0x4009100")]
	[FieldOffset(Offset = "0x29")]
	public bool m_RequiresExternalPower;

	[Header("Objects")]
	[Token(Token = "0x4009101")]
	[FieldOffset(Offset = "0x30")]
	public List<Light> m_LocalLights;

	[Token(Token = "0x4009102")]
	[FieldOffset(Offset = "0x38")]
	public List<Renderer> m_EmissiveObjects;

	[Token(Token = "0x4009103")]
	[FieldOffset(Offset = "0x40")]
	public HighlightFog m_HighlightFogObject;

	[Token(Token = "0x4009104")]
	[FieldOffset(Offset = "0x48")]
	public AK.Wwise.Event m_AudioEvent;

	[Header("Intensity Control")]
	[Token(Token = "0x4009105")]
	[FieldOffset(Offset = "0x50")]
	public IntensityParameters m_IntensityParameters;

	[Token(Token = "0x4009106")]
	[FieldOffset(Offset = "0x58")]
	public List<FlickerModuleSet> m_FlickerSet;

	[Header("Distance controls")]
	[Token(Token = "0x4009107")]
	[FieldOffset(Offset = "0x60")]
	public DistanceParameters m_OutdoorDistance;

	[Token(Token = "0x4009108")]
	[FieldOffset(Offset = "0x68")]
	public DistanceParameters m_IndoorDistance;

	[NonSerialized]
	[Header("Debug")]
	[Token(Token = "0x4009109")]
	[FieldOffset(Offset = "0x70")]
	public bool m_PrintDebugToScreen;

	[NonSerialized]
	[Token(Token = "0x400910A")]
	[FieldOffset(Offset = "0x71")]
	public bool m_IndependentUpdate;

	[NonSerialized]
	[Token(Token = "0x400910B")]
	[FieldOffset(Offset = "0x72")]
	public bool m_UseAuroraStrengthOverride;

	[NonSerialized]
	[Token(Token = "0x400910C")]
	[FieldOffset(Offset = "0x74")]
	public float m_AuroraStrengthOverride;

	[Token(Token = "0x400910D")]
	private const bool IS_CONSOLE = false;

	[Token(Token = "0x400910E")]
	private const bool ALLOW_EDITOR_OVERRIDES = false;

	[Token(Token = "0x400910F")]
	[FieldOffset(Offset = "0x78")]
	private float _CamDist;

	[Token(Token = "0x4009110")]
	[FieldOffset(Offset = "0x7C")]
	private float m_ActivationThreshold;

	[Token(Token = "0x4009111")]
	[FieldOffset(Offset = "0x80")]
	private float m_StableThreshold;

	[Token(Token = "0x4009112")]
	[FieldOffset(Offset = "0x88")]
	private List<float> m_LocalLightsIntensities;

	[Token(Token = "0x4009113")]
	[FieldOffset(Offset = "0x90")]
	private Color m_LocalColor;

	[Token(Token = "0x4009114")]
	[FieldOffset(Offset = "0xA0")]
	private uint m_AudioInstanceID;

	[Token(Token = "0x4009115")]
	[FieldOffset(Offset = "0xA8")]
	private FlickerTimingControl m_FlickerTimingControl;

	[Token(Token = "0x4009116")]
	[FieldOffset(Offset = "0xB0")]
	private DistanceFadeControl m_DistanceFadeControl;

	[Token(Token = "0x4009117")]
	[FieldOffset(Offset = "0xB8")]
	private AuroraField m_ActiveAuroraField;

	[Token(Token = "0x4009118")]
	[FieldOffset(Offset = "0xC0")]
	private float m_AuroraFadeIntensity;

	[Token(Token = "0x4009119")]
	[FieldOffset(Offset = "0xC4")]
	private float m_OutputIntensity;

	[Token(Token = "0x400911A")]
	[FieldOffset(Offset = "0xC8")]
	private float m_IntensitySentToWise;

	[Token(Token = "0x400911B")]
	[FieldOffset(Offset = "0xCC")]
	private float m_FlickerModuleDuration;

	[Token(Token = "0x400911C")]
	[FieldOffset(Offset = "0xD0")]
	private bool m_IsInitialized;

	[Token(Token = "0x400911D")]
	[FieldOffset(Offset = "0xD1")]
	private bool m_ExternalPowerActive;

	[Token(Token = "0x400911E")]
	[FieldOffset(Offset = "0xD2")]
	private bool m_HasStopped;

	[Token(Token = "0x400911F")]
	[FieldOffset(Offset = "0xD3")]
	private bool m_DoUpdate;

	[Token(Token = "0x4009120")]
	[FieldOffset(Offset = "0xD4")]
	private bool m_HasHighlightFog;

	[Token(Token = "0x4009121")]
	[FieldOffset(Offset = "0xD5")]
	private bool m_HasFlickerSet;

	[Token(Token = "0x4009122")]
	[FieldOffset(Offset = "0xD6")]
	private bool m_PrevFogState;

	[Token(Token = "0x4009123")]
	[FieldOffset(Offset = "0xD8")]
	private HashSet<Renderer> m_Renderers;

	[Token(Token = "0x4009124")]
	[FieldOffset(Offset = "0xE0")]
	private MaterialPropertyBlock m_EmissivePropertyBlock;

	[Token(Token = "0x4009125")]
	[FieldOffset(Offset = "0xE8")]
	private Shader m_EmissiveShader;

	[Token(Token = "0x4009126")]
	private static readonly int s_EmissiveStrengthPropertyID;

	[Token(Token = "0x4009127")]
	private static readonly int s_EmissiveTintPropertyID;

	[Token(Token = "0x17000AC4")]
	public float ActivationThreshold
	{
		[Token(Token = "0x6007E66")]
		[Address(RVA = "0x502720", Offset = "0x501520", Length = "0x6")]
		get
		{
			return 0f;
		}
	}

	[Token(Token = "0x17000AC5")]
	public float StableThreshold
	{
		[Token(Token = "0x6007E67")]
		[Address(RVA = "0xCB4000", Offset = "0xCB2E00", Length = "0x9")]
		get
		{
			return 0f;
		}
	}

	[Token(Token = "0x17000AC6")]
	public bool HasStopped
	{
		[Token(Token = "0x6007E68")]
		[Address(RVA = "0x11DEB40", Offset = "0x11DD940", Length = "0x8")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x17000AC7")]
	public AuroraField ActiveAuroraField
	{
		[Token(Token = "0x6007E69")]
		[Address(RVA = "0x633890", Offset = "0x632690", Length = "0x115")]
		set
		{
		}
	}

	[Token(Token = "0x17000AC8")]
	public DistanceFadeControl DistanceFadeControl
	{
		[Token(Token = "0x6007E6A")]
		[Address(RVA = "0x502310", Offset = "0x501110", Length = "0x8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000AC9")]
	public bool ExternalPowerActive
	{
		[Token(Token = "0x6007E6B")]
		[Address(RVA = "0x11DEB50", Offset = "0x11DD950", Length = "0x7")]
		set
		{
		}
	}

	[Token(Token = "0x17000ACA")]
	public float FlickerModuleDuration
	{
		[Token(Token = "0x6007E6C")]
		[Address(RVA = "0x11DEB60", Offset = "0x11DD960", Length = "0x9")]
		get
		{
			return 0f;
		}
	}

	[Token(Token = "0x6007E6D")]
	[Address(RVA = "0x11DEB70", Offset = "0x11DD970", Length = "0x91")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6007E6E")]
	[Address(RVA = "0x11DEC10", Offset = "0x11DDA10", Length = "0x5B")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6007E6F")]
	[Address(RVA = "0x11DEC70", Offset = "0x11DDA70", Length = "0x160")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6007E70")]
	[Address(RVA = "0x11DEDE0", Offset = "0x11DDBE0", Length = "0x511")]
	private void Awake()
	{
	}

	[Token(Token = "0x6007E71")]
	[Address(RVA = "0x11DF300", Offset = "0x11DE100", Length = "0x4E")]
	private void RegisterWithManager()
	{
	}

	[Token(Token = "0x6007E72")]
	[Address(RVA = "0x869190", Offset = "0x867F90", Length = "0xB")]
	private void Start()
	{
	}

	[Token(Token = "0x6007E73")]
	[Address(RVA = "0x11DF350", Offset = "0x11DE150", Length = "0xF62")]
	private void Initialize()
	{
	}

	[Token(Token = "0x6007E74")]
	[Address(RVA = "0x11E02C0", Offset = "0x11DF0C0", Length = "0x154")]
	private void InitializeFlickerSet()
	{
	}

	[Token(Token = "0x6007E75")]
	[Address(RVA = "0x11E0420", Offset = "0x11DF220", Length = "0x1C")]
	public void JobUpdate(float camDistSqr, float auroraIntensity, float auroraDeltaTime, float jobTimer)
	{
	}

	[Token(Token = "0x6007E76")]
	[Address(RVA = "0x11E0440", Offset = "0x11DF240", Length = "0x298")]
	public void ManualUpdate(float camDistSqr, float auroraIntensity, float auroraDeltaTime)
	{
	}

	[Token(Token = "0x6007E77")]
	[Address(RVA = "0x11E06E0", Offset = "0x11DF4E0", Length = "0x18F")]
	private bool HasActivePower()
	{
		return false;
	}

	[Token(Token = "0x6007E78")]
	[Address(RVA = "0x11E0870", Offset = "0x11DF670", Length = "0x10")]
	private bool HasExternalPower()
	{
		return false;
	}

	[Token(Token = "0x6007E79")]
	[Address(RVA = "0x11E0880", Offset = "0x11DF680", Length = "0xFE")]
	private bool HasFieldPower()
	{
		return false;
	}

	[Token(Token = "0x6007E7A")]
	[Address(RVA = "0x11E0980", Offset = "0x11DF780", Length = "0xBB")]
	public void StopAll()
	{
	}

	[Token(Token = "0x6007E7B")]
	[Address(RVA = "0x11E0A40", Offset = "0x11DF840", Length = "0x57")]
	private void StopAudio()
	{
	}

	[Token(Token = "0x6007E7C")]
	[Address(RVA = "0x11E0AA0", Offset = "0x11DF8A0", Length = "0x2A5")]
	private void UpdateIntensity(float distanceFade, float auroraIntensity)
	{
	}

	[Token(Token = "0x6007E7D")]
	[Address(RVA = "0x11E0D50", Offset = "0x11DFB50", Length = "0x19A")]
	private void UpdateLight(bool allOff = false)
	{
	}

	[Token(Token = "0x6007E7E")]
	[Address(RVA = "0x11E0EF0", Offset = "0x11DFCF0", Length = "0x563")]
	private void UpdateEmissiveObjects(bool allOff = false)
	{
	}

	[Token(Token = "0x6007E7F")]
	[Address(RVA = "0x11E1460", Offset = "0x11E0260", Length = "0x1C3")]
	private void MaybeSetupHighlightFog()
	{
	}

	[Token(Token = "0x6007E80")]
	[Address(RVA = "0x11E1630", Offset = "0x11E0430", Length = "0x64")]
	public void MaybeActivateHighlightFogObject()
	{
	}

	[Token(Token = "0x6007E81")]
	[Address(RVA = "0x11E16A0", Offset = "0x11E04A0", Length = "0x53")]
	private void EnableHighlightFogObject(bool enabled)
	{
	}

	[Token(Token = "0x6007E82")]
	[Address(RVA = "0x11E1700", Offset = "0x11E0500", Length = "0x1E4")]
	private void UpdateAudio()
	{
	}

	[Token(Token = "0x6007E83")]
	[Address(RVA = "0x11E18F0", Offset = "0x11E06F0", Length = "0xE3")]
	private void UpdateFlickerTiming(float auroraDeltaTime)
	{
	}

	[Token(Token = "0x6007E84")]
	[Address(RVA = "0x11E19E0", Offset = "0x11E07E0", Length = "0x56")]
	private bool HasFlickerSets()
	{
		return false;
	}

	[Token(Token = "0x6007E85")]
	[Address(RVA = "0x11E1A40", Offset = "0x11E0840", Length = "0x18F")]
	public AuroraModularElectrolizer()
	{
	}
}
