using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Rendering;

[Token(Token = "0x20003C6")]
public class LightQualitySwitch : MonoBehaviour
{
	[Token(Token = "0x20003C7")]
	public enum LightLocation
	{
		[Token(Token = "0x4002215")]
		auto,
		[Token(Token = "0x4002216")]
		everywhere,
		[Token(Token = "0x4002217")]
		indoor,
		[Token(Token = "0x4002218")]
		outdoor,
		[Token(Token = "0x4002219")]
		cinematic
	}

	[Token(Token = "0x40021F6")]
	[FieldOffset(Offset = "0x20")]
	public Light m_Light;

	[Tooltip("Override the light's cookie, if it has one. Otherwise the light will always use it's existing cookie.")]
	[Token(Token = "0x40021F7")]
	[FieldOffset(Offset = "0x28")]
	public Texture m_Cookie;

	[Tooltip("Where should the light be active: Auto (looks for 'Indoor' or 'Outdoor' name)")]
	[Token(Token = "0x40021F8")]
	[FieldOffset(Offset = "0x30")]
	public LightLocation m_LightLocation;

	[Tooltip("Enabling this option limits shadow type and resolution to a maximum of what is already set on the Light component.\nEg. Shadows set to Off will remain off, Hard shadows will never be upgraded to Soft, Medium resolution shadows can be reduced to Low, but not increased to High")]
	[Token(Token = "0x40021F9")]
	[FieldOffset(Offset = "0x34")]
	public bool m_LimitToDefaultValues;

	[Header("Low Quality")]
	[Token(Token = "0x40021FA")]
	[FieldOffset(Offset = "0x38")]
	public LightShadowResolution m_LowResolution;

	[Token(Token = "0x40021FB")]
	[FieldOffset(Offset = "0x3C")]
	public LightShadows m_LowShadowType;

	[Token(Token = "0x40021FC")]
	[FieldOffset(Offset = "0x40")]
	public bool m_LowDisabled;

	[Header("Medium Quality")]
	[Token(Token = "0x40021FD")]
	[FieldOffset(Offset = "0x44")]
	public LightShadowResolution m_MediumResolution;

	[Token(Token = "0x40021FE")]
	[FieldOffset(Offset = "0x48")]
	public LightShadows m_MediumShadowType;

	[Token(Token = "0x40021FF")]
	[FieldOffset(Offset = "0x4C")]
	public bool m_MediumDisabled;

	[Header("High Quality")]
	[Token(Token = "0x4002200")]
	[FieldOffset(Offset = "0x50")]
	public LightShadowResolution m_HighResolution;

	[Token(Token = "0x4002201")]
	[FieldOffset(Offset = "0x54")]
	public LightShadows m_HighShadowType;

	[Token(Token = "0x4002202")]
	[FieldOffset(Offset = "0x58")]
	public bool m_HighDisabled;

	[Header("Ultra Quality")]
	[Token(Token = "0x4002203")]
	[FieldOffset(Offset = "0x5C")]
	public LightShadowResolution m_UltraResolution;

	[Token(Token = "0x4002204")]
	[FieldOffset(Offset = "0x60")]
	public LightShadows m_UltraShadowType;

	[Token(Token = "0x4002205")]
	[FieldOffset(Offset = "0x64")]
	public bool m_UltraDisabled;

	[Header("Console Low Quality (Switch)")]
	[Token(Token = "0x4002206")]
	[FieldOffset(Offset = "0x68")]
	public LightShadowResolution m_ConsoleLowResolution;

	[Token(Token = "0x4002207")]
	[FieldOffset(Offset = "0x6C")]
	public LightShadows m_ConsoleLowShadowType;

	[Token(Token = "0x4002208")]
	[FieldOffset(Offset = "0x70")]
	public bool m_ConsoleLowDisabled;

	[Header("Console Quality (Xbox & PS4)")]
	[Token(Token = "0x4002209")]
	[FieldOffset(Offset = "0x74")]
	public LightShadowResolution m_ConsoleResolution;

	[Token(Token = "0x400220A")]
	[FieldOffset(Offset = "0x78")]
	public LightShadows m_ConsoleShadowType;

	[Token(Token = "0x400220B")]
	[FieldOffset(Offset = "0x7C")]
	public bool m_ConsoleDisabled;

	[Header("Console Pro Quality (Xbox X & PS4 Pro)")]
	[Token(Token = "0x400220C")]
	[FieldOffset(Offset = "0x80")]
	public LightShadowResolution m_ConsoleProResolution;

	[Token(Token = "0x400220D")]
	[FieldOffset(Offset = "0x84")]
	public LightShadows m_ConsoleProShadowType;

	[Token(Token = "0x400220E")]
	[FieldOffset(Offset = "0x88")]
	public bool m_ConsoleProDisabled;

	[Token(Token = "0x400220F")]
	[FieldOffset(Offset = "0x90")]
	private Light[] m_LightList;

	[Token(Token = "0x4002210")]
	[FieldOffset(Offset = "0x98")]
	private QualityShadows m_CachedQuality;

	[Token(Token = "0x4002211")]
	[FieldOffset(Offset = "0x9C")]
	private bool m_Initialized;

	[Token(Token = "0x4002212")]
	[FieldOffset(Offset = "0xA0")]
	private LightShadows m_DefaultShadowType;

	[Token(Token = "0x4002213")]
	[FieldOffset(Offset = "0xA4")]
	private LightShadowResolution m_DefaultShadowResolution;

	[Token(Token = "0x6001D8A")]
	[Address(RVA = "0x7A56A0", Offset = "0x7A44A0", Length = "0x62A")]
	private void Start()
	{
	}

	[Token(Token = "0x6001D8B")]
	[Address(RVA = "0x7A5CD0", Offset = "0x7A4AD0", Length = "0x7")]
	private void Update()
	{
	}

	[Token(Token = "0x6001D8C")]
	[Address(RVA = "0x7A5CE0", Offset = "0x7A4AE0", Length = "0x1F3")]
	private void RefreshLocalQuality()
	{
	}

	[Token(Token = "0x6001D8D")]
	[Address(RVA = "0x7A5EE0", Offset = "0x7A4CE0", Length = "0x2C7")]
	private void SetLocalQuality(Light curLight)
	{
	}

	[Token(Token = "0x6001D8E")]
	[Address(RVA = "0x7A61B0", Offset = "0x7A4FB0", Length = "0x224")]
	private bool IsValidLocation()
	{
		return false;
	}

	[Token(Token = "0x6001D8F")]
	[Address(RVA = "0x7A63E0", Offset = "0x7A51E0", Length = "0x221")]
	private void UpdateLight(Light light, bool isDisabled, LightShadows shadowType, LightShadowResolution shadowResolution)
	{
	}

	[Token(Token = "0x6001D90")]
	[Address(RVA = "0x7A6610", Offset = "0x7A5410", Length = "0x77")]
	public LightQualitySwitch()
	{
	}
}
