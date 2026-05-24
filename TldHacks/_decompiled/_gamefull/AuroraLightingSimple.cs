using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200035E")]
public class AuroraLightingSimple : MonoBehaviour
{
	[Header("Primary aurora controls")]
	[Tooltip("How sensitive is the object to the aurora. This is the value to activate it.")]
	[Token(Token = "0x4001DA9")]
	[FieldOffset(Offset = "0x20")]
	public MinMax m_AuroraThresholdActivate;

	[Tooltip("How much of the aurora power does the object need to achieve stable power.")]
	[Token(Token = "0x4001DAA")]
	[FieldOffset(Offset = "0x28")]
	public MinMax m_AuroraThresholdStable;

	[Tooltip("Looping audio that plays when effects are active")]
	[Token(Token = "0x4001DAB")]
	[FieldOffset(Offset = "0x30")]
	public string m_Audio;

	[Tooltip("Fade the light in and out based on the aurora fade. Otherwise it will either be ON or OFF.")]
	[Token(Token = "0x4001DAC")]
	[FieldOffset(Offset = "0x38")]
	public bool m_LightFadeWithAurora;

	[Tooltip("Intensity difference must be greater than  this percentage to affect the light and object.")]
	[Token(Token = "0x4001DAD")]
	[FieldOffset(Offset = "0x3C")]
	public float m_UpdateThresholdPercent;

	[Header("Intensity control")]
	[Tooltip("Primary intensity minimum and maximum, chosen at random.")]
	[Token(Token = "0x4001DAE")]
	[FieldOffset(Offset = "0x40")]
	public MinMax m_LightPrimaryIntensity;

	[Tooltip("Primary minimum and maximum frequency, chosen at random.")]
	[Token(Token = "0x4001DAF")]
	[FieldOffset(Offset = "0x48")]
	public MinMax m_LightPrimaryFrequency;

	[Token(Token = "0x4001DB0")]
	[FieldOffset(Offset = "0x50")]
	public bool m_RequiresAuroraField;

	[Token(Token = "0x4001DB1")]
	[FieldOffset(Offset = "0x51")]
	public bool m_ExternalPowerActive;

	[Header("Fade by distance")]
	[Tooltip("Beyond this distance to the camera, the lights and effects will fade out / stop emitting particles.")]
	[Token(Token = "0x4001DB2")]
	[FieldOffset(Offset = "0x54")]
	public float m_MaximumDistanceFromCamera;

	[Tooltip("Beyond this distance to the camera, the lights and effects will fade out / stop emitting particles. Console specific variable.")]
	[Token(Token = "0x4001DB3")]
	[FieldOffset(Offset = "0x58")]
	public float m_MaxConsoleDistanceFromCamera;

	[Range(0f, 100f)]
	[Token(Token = "0x4001DB4")]
	[FieldOffset(Offset = "0x5C")]
	public float m_SwitchIndoorPercent;

	[Range(0f, 100f)]
	[Token(Token = "0x4001DB5")]
	[FieldOffset(Offset = "0x60")]
	public float m_XboxPs4IndoorPercent;

	[Range(0f, 100f)]
	[Token(Token = "0x4001DB6")]
	[FieldOffset(Offset = "0x64")]
	public float m_PcIndoorPercent;

	[Tooltip("The percentage where lights and effects will begin to fade before reaching 0 at the maximum distance. Eg, 15% of 150m = 127m")]
	[Range(0f, 90f)]
	[Token(Token = "0x4001DB7")]
	[FieldOffset(Offset = "0x68")]
	public float m_FadeDistancePercent;

	[Token(Token = "0x4001DB8")]
	[FieldOffset(Offset = "0x6C")]
	private float m_CurPriFreq;

	[Token(Token = "0x4001DB9")]
	[FieldOffset(Offset = "0x70")]
	private float m_PriPeriod;

	[Token(Token = "0x4001DBA")]
	[FieldOffset(Offset = "0x74")]
	private float m_PhiPri;

	[Token(Token = "0x4001DBB")]
	[FieldOffset(Offset = "0x78")]
	private float m_PhiTimer;

	[Token(Token = "0x4001DBC")]
	[FieldOffset(Offset = "0x7C")]
	private float m_CurIntensity;

	[Token(Token = "0x4001DBD")]
	[FieldOffset(Offset = "0x80")]
	private float m_StaticIntensity;

	[Token(Token = "0x4001DBE")]
	[FieldOffset(Offset = "0x84")]
	private float m_CurLowThreshold;

	[Token(Token = "0x4001DBF")]
	[FieldOffset(Offset = "0x88")]
	private float m_CurStableThreshold;

	[Token(Token = "0x4001DC0")]
	[FieldOffset(Offset = "0x8C")]
	private float m_AuroraLightFade;

	[Token(Token = "0x4001DC1")]
	[FieldOffset(Offset = "0x90")]
	private Shader m_EmissiveShader;

	[Token(Token = "0x4001DC2")]
	[FieldOffset(Offset = "0x98")]
	private AuroraField m_ActiveAuroraField;

	[Token(Token = "0x4001DC3")]
	[FieldOffset(Offset = "0xA0")]
	private List<Material> m_LocalMaterials;

	[Token(Token = "0x4001DC4")]
	[FieldOffset(Offset = "0xA8")]
	private Light[] m_LocalLights;

	[Token(Token = "0x4001DC5")]
	[FieldOffset(Offset = "0xB0")]
	private uint m_AudioInstanceID;

	[Token(Token = "0x4001DC6")]
	[FieldOffset(Offset = "0xB4")]
	private bool m_HasStopped;

	[Token(Token = "0x4001DC7")]
	[FieldOffset(Offset = "0xB5")]
	private bool m_SetDistances;

	[Token(Token = "0x4001DC8")]
	[FieldOffset(Offset = "0xB8")]
	private float m_MaximumSqrDistanceFromCamera;

	[Token(Token = "0x4001DC9")]
	[FieldOffset(Offset = "0xBC")]
	private float m_MaximumSqrFadeFromCamera;

	[Token(Token = "0x4001DCA")]
	[FieldOffset(Offset = "0xC0")]
	private float m_IntensitySentToWise;

	[Token(Token = "0x4001DCB")]
	[FieldOffset(Offset = "0xC4")]
	private float m_FadeIntensity;

	[Token(Token = "0x4001DCC")]
	private static readonly int EmissiveStrength;

	[Token(Token = "0x6001B67")]
	[Address(RVA = "0x75FAC0", Offset = "0x75E8C0", Length = "0x2E8")]
	private void Awake()
	{
	}

	[Token(Token = "0x6001B68")]
	[Address(RVA = "0x75FDB0", Offset = "0x75EBB0", Length = "0xE")]
	private void Start()
	{
	}

	[Token(Token = "0x6001B69")]
	[Address(RVA = "0x75FDC0", Offset = "0x75EBC0", Length = "0x218")]
	private void FindLights()
	{
	}

	[Token(Token = "0x6001B6A")]
	[Address(RVA = "0x75FFE0", Offset = "0x75EDE0", Length = "0x2DF")]
	private void FindMaterials()
	{
	}

	[Token(Token = "0x6001B6B")]
	[Address(RVA = "0x7602C0", Offset = "0x75F0C0", Length = "0x7")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6001B6C")]
	[Address(RVA = "0x7602D0", Offset = "0x75F0D0", Length = "0x7F")]
	public void StopAll()
	{
	}

	[Token(Token = "0x6001B6D")]
	[Address(RVA = "0x760350", Offset = "0x75F150", Length = "0x298")]
	public void ManualUpdate(float camDistSqr, float fadeIntensity, float auroraIntensity, float deltaTime)
	{
	}

	[Token(Token = "0x6001B6E")]
	[Address(RVA = "0x7605F0", Offset = "0x75F3F0", Length = "0x241")]
	private bool CheckActivation(float camDistSqr, float fadeIntensity, float auroraIntensity)
	{
		return false;
	}

	[Token(Token = "0x6001B6F")]
	[Address(RVA = "0x760840", Offset = "0x75F640", Length = "0xCB")]
	private void UpdateIntensity(float deltaTime)
	{
	}

	[Token(Token = "0x6001B70")]
	[Address(RVA = "0x760910", Offset = "0x75F710", Length = "0x152")]
	private void UpdateLight(bool allOff = false)
	{
	}

	[Token(Token = "0x6001B71")]
	[Address(RVA = "0x760A70", Offset = "0x75F870", Length = "0x146")]
	private void UpdateEmissiveObjects(bool allOff = false)
	{
	}

	[Token(Token = "0x6001B72")]
	[Address(RVA = "0x760BC0", Offset = "0x75F9C0", Length = "0x197")]
	private void UpdateAudio()
	{
	}

	[Token(Token = "0x6001B73")]
	[Address(RVA = "0x760D60", Offset = "0x75FB60", Length = "0x57")]
	private void StopAudio()
	{
	}

	[Token(Token = "0x6001B74")]
	[Address(RVA = "0x760DC0", Offset = "0x75FBC0", Length = "0x5B")]
	public void SetLocationDistances(bool useOutdoorValues)
	{
	}

	[Token(Token = "0x6001B75")]
	[Address(RVA = "0x760E20", Offset = "0x75FC20", Length = "0x9")]
	public float GetCurrentLowThreshold()
	{
		return 0f;
	}

	[Token(Token = "0x6001B76")]
	[Address(RVA = "0x760E30", Offset = "0x75FC30", Length = "0x9")]
	public float GetCurrentStableThreshold()
	{
		return 0f;
	}

	[Token(Token = "0x6001B77")]
	[Address(RVA = "0x760E40", Offset = "0x75FC40", Length = "0xB")]
	public bool IsElectrolized()
	{
		return false;
	}

	[Token(Token = "0x6001B78")]
	[Address(RVA = "0x760E50", Offset = "0x75FC50", Length = "0x52")]
	public void SetAuroraField(AuroraField auroraField)
	{
	}

	[Token(Token = "0x6001B79")]
	[Address(RVA = "0x760EB0", Offset = "0x75FCB0", Length = "0xD0")]
	public float GetIntensityNormalized()
	{
		return 0f;
	}

	[Token(Token = "0x6001B7A")]
	[Address(RVA = "0x760F90", Offset = "0x75FD90", Length = "0x4")]
	public void SetExternalPowerState(bool isActive)
	{
	}

	[Token(Token = "0x6001B7B")]
	[Address(RVA = "0x760FA0", Offset = "0x75FDA0", Length = "0x26E")]
	public AuroraLightingSimple()
	{
	}
}
