using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20003C9")]
public class LightRandomIntensity : MonoBehaviour
{
	[Token(Token = "0x4002222")]
	[FieldOffset(Offset = "0x20")]
	public float m_IntervalSeconds;

	[Token(Token = "0x4002223")]
	[FieldOffset(Offset = "0x24")]
	public float m_Min;

	[Token(Token = "0x4002224")]
	[FieldOffset(Offset = "0x28")]
	public float m_Max;

	[Token(Token = "0x4002225")]
	[FieldOffset(Offset = "0x2C")]
	public bool m_AuroraLight;

	[Header("TOD")]
	[Token(Token = "0x4002226")]
	[FieldOffset(Offset = "0x2D")]
	public bool m_NightOnly;

	[Header("Fade")]
	[Token(Token = "0x4002227")]
	[FieldOffset(Offset = "0x2E")]
	public bool m_Fade;

	[Token(Token = "0x4002228")]
	[FieldOffset(Offset = "0x30")]
	public float m_FadeTime;

	[Token(Token = "0x4002229")]
	[FieldOffset(Offset = "0x34")]
	private float m_CurrentFadeTime;

	[Token(Token = "0x400222A")]
	[FieldOffset(Offset = "0x38")]
	private float m_FadeMultiplier;

	[Token(Token = "0x400222B")]
	[FieldOffset(Offset = "0x3C")]
	private float m_CurrentTime;

	[Token(Token = "0x400222C")]
	[FieldOffset(Offset = "0x40")]
	private float m_Destination;

	[Token(Token = "0x400222D")]
	[FieldOffset(Offset = "0x44")]
	private float m_LightIntensityStart;

	[Token(Token = "0x400222E")]
	[FieldOffset(Offset = "0x48")]
	private LightTracking m_Light;

	[Token(Token = "0x400222F")]
	[FieldOffset(Offset = "0x50")]
	private bool m_HasLight;

	[Token(Token = "0x4002230")]
	[FieldOffset(Offset = "0x58")]
	private UniStormWeatherSystem m_UniStorm;

	[Token(Token = "0x6001D94")]
	[Address(RVA = "0x7A6B20", Offset = "0x7A5920", Length = "0x22E")]
	private void Start()
	{
	}

	[Token(Token = "0x6001D95")]
	[Address(RVA = "0x7A6D50", Offset = "0x7A5B50", Length = "0x330")]
	private void Update()
	{
	}

	[Token(Token = "0x6001D96")]
	[Address(RVA = "0x7A7090", Offset = "0x7A5E90", Length = "0x2B")]
	public float GetIntensity()
	{
		return 0f;
	}

	[Token(Token = "0x6001D97")]
	[Address(RVA = "0x7A70C0", Offset = "0x7A5EC0", Length = "0xB")]
	public void SetMinMax(float min, float max)
	{
	}

	[Token(Token = "0x6001D98")]
	[Address(RVA = "0x787050", Offset = "0x785E50", Length = "0x51")]
	public LightRandomIntensity()
	{
	}
}
