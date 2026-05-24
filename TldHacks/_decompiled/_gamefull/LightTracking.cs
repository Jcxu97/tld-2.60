using Cpp2ILInjected;
using UnityEngine;

[RequireComponent(typeof(Light))]
[Token(Token = "0x20003CF")]
public class LightTracking : MonoBehaviour
{
	[Token(Token = "0x4002274")]
	private const float CINEMATIC_FADE_TIME = 0.5f;

	[Token(Token = "0x4002275")]
	private const float CINEMATIC_FADE_MIN_STRENGTH = 0f;

	[Token(Token = "0x4002276")]
	public static bool s_FadePlayerLightsDurignCinematics;

	[Token(Token = "0x4002277")]
	[FieldOffset(Offset = "0x20")]
	public Light m_LightComponent;

	[Token(Token = "0x4002278")]
	[FieldOffset(Offset = "0x28")]
	public Vector3 m_WorldPosition;

	[Token(Token = "0x4002279")]
	[FieldOffset(Offset = "0x34")]
	public bool m_StaticPosition;

	[Token(Token = "0x400227A")]
	[FieldOffset(Offset = "0x38")]
	private Vector3 m_OriginalPosition;

	[Token(Token = "0x400227B")]
	[FieldOffset(Offset = "0x44")]
	private Quaternion m_OriginalRotation;

	[Token(Token = "0x400227C")]
	[FieldOffset(Offset = "0x54")]
	private bool m_Started;

	[Token(Token = "0x400227D")]
	[FieldOffset(Offset = "0x58")]
	private GearItem m_AssociatedGearItem;

	[Token(Token = "0x400227E")]
	[FieldOffset(Offset = "0x60")]
	private float m_BaseLightIntensity;

	[Token(Token = "0x400227F")]
	[FieldOffset(Offset = "0x64")]
	private float m_CinematicFadeStrength;

	[Token(Token = "0x4002280")]
	[FieldOffset(Offset = "0x68")]
	private bool m_WasLightingWeaponCamera;

	[Token(Token = "0x4002281")]
	[FieldOffset(Offset = "0x69")]
	private bool m_IsDirectional;

	[Token(Token = "0x6001DBE")]
	[Address(RVA = "0x7AA4D0", Offset = "0x7A92D0", Length = "0xC8")]
	private void Awake()
	{
	}

	[Token(Token = "0x6001DBF")]
	[Address(RVA = "0x7AA5A0", Offset = "0x7A93A0", Length = "0xA")]
	private void Start()
	{
	}

	[Token(Token = "0x6001DC0")]
	[Address(RVA = "0x7AA5B0", Offset = "0x7A93B0", Length = "0xA")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6001DC1")]
	[Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", Length = "0x33B")]
	private void MaybeAdd(bool areWeStarting)
	{
	}

	[Token(Token = "0x6001DC2")]
	[Address(RVA = "0x7AA900", Offset = "0x7A9700", Length = "0x4E")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6001DC3")]
	[Address(RVA = "0x7AA950", Offset = "0x7A9750", Length = "0x239")]
	public void StorePositionAndRotation()
	{
	}

	[Token(Token = "0x6001DC4")]
	[Address(RVA = "0x7AAB90", Offset = "0x7A9990", Length = "0x163")]
	public void RestorePositionAndRotation()
	{
	}

	[Token(Token = "0x6001DC5")]
	[Address(RVA = "0x7AAD00", Offset = "0x7A9B00", Length = "0x190")]
	public void MaybeUpdateForCinematic(bool isCinematicActive)
	{
	}

	[Token(Token = "0x6001DC6")]
	[Address(RVA = "0x7AAEA0", Offset = "0x7A9CA0", Length = "0x9F")]
	public bool IsLightEnabled()
	{
		return false;
	}

	[Token(Token = "0x6001DC7")]
	[Address(RVA = "0x7AAF40", Offset = "0x7A9D40", Length = "0x2D")]
	public void EnableLight(bool state)
	{
	}

	[Token(Token = "0x6001DC8")]
	[Address(RVA = "0x7AAF70", Offset = "0x7A9D70", Length = "0xFC")]
	public void EnableWeaponCameraLighting(bool enable)
	{
	}

	[Token(Token = "0x6001DC9")]
	[Address(RVA = "0x4C3B90", Offset = "0x4C2990", Length = "0x5")]
	public bool WasLightingWeaponCamera()
	{
		return false;
	}

	[Token(Token = "0x6001DCA")]
	[Address(RVA = "0x7AB070", Offset = "0x7A9E70", Length = "0x9F")]
	public float GetLightRange()
	{
		return 0f;
	}

	[Token(Token = "0x6001DCB")]
	[Address(RVA = "0x7AB110", Offset = "0x7A9F10", Length = "0x5")]
	public bool IsDirectional()
	{
		return false;
	}

	[Token(Token = "0x6001DCC")]
	[Address(RVA = "0x7AB120", Offset = "0x7A9F20", Length = "0x9F")]
	public float GetLightIntensity()
	{
		return 0f;
	}

	[Token(Token = "0x6001DCD")]
	[Address(RVA = "0x7AB1C0", Offset = "0x7A9FC0", Length = "0x39")]
	public void SetLightIntensity(float intensity)
	{
	}

	[Token(Token = "0x6001DCE")]
	[Address(RVA = "0x7AB200", Offset = "0x7AA000", Length = "0x34")]
	private void UpdateLightIntensity()
	{
	}

	[Token(Token = "0x6001DCF")]
	[Address(RVA = "0x7AB240", Offset = "0x7AA040", Length = "0x145")]
	private Light GetLightComponent()
	{
		return null;
	}

	[Token(Token = "0x6001DD0")]
	[Address(RVA = "0x7AB390", Offset = "0x7AA190", Length = "0xA7")]
	private bool IsLightingWeaponCamera()
	{
		return false;
	}

	[Token(Token = "0x6001DD1")]
	[Address(RVA = "0x7AB440", Offset = "0x7AA240", Length = "0x15F")]
	public LightTracking()
	{
	}
}
