using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20003CC")]
public class LightShaftTod : MonoBehaviour
{
	[Token(Token = "0x20003CD")]
	public enum LightShaftDirection
	{
		[Token(Token = "0x4002268")]
		NORTH,
		[Token(Token = "0x4002269")]
		EAST,
		[Token(Token = "0x400226A")]
		SOUTH,
		[Token(Token = "0x400226B")]
		WEST,
		[Token(Token = "0x400226C")]
		NONE
	}

	[Token(Token = "0x4002255")]
	[FieldOffset(Offset = "0x20")]
	public bool followTod;

	[Token(Token = "0x4002256")]
	[FieldOffset(Offset = "0x21")]
	public bool m_FadeWithViewAngle;

	[Token(Token = "0x4002257")]
	[FieldOffset(Offset = "0x24")]
	public Vector2 yMinMax;

	[Token(Token = "0x4002258")]
	[FieldOffset(Offset = "0x2C")]
	public Vector2 zMinMax;

	[Tooltip("Optional: Rotate the light on the x axis to keep it aligned horizontally, based on the equation...\nx = 17.8f * Cos(4.20973 * (tod - 0.122))")]
	[Token(Token = "0x4002259")]
	[FieldOffset(Offset = "0x34")]
	public bool useXRotation;

	[Tooltip("Sets the ingame direction, regardless of how it's set in the editor.")]
	[Token(Token = "0x400225A")]
	[FieldOffset(Offset = "0x38")]
	public LightShaftDirection facingDirection;

	[Tooltip("The maximum intensity of the light shaft 'gain' property.")]
	[Range(0f, 1f)]
	[Token(Token = "0x400225B")]
	[FieldOffset(Offset = "0x3C")]
	public float m_MaximumIntensity;

	[Token(Token = "0x400225C")]
	[FieldOffset(Offset = "0x40")]
	public Light m_Light;

	[Token(Token = "0x400225D")]
	[FieldOffset(Offset = "0x48")]
	public GameObject[] m_LightShaft;

	[Token(Token = "0x400225E")]
	[FieldOffset(Offset = "0x50")]
	public bool m_UseLightColour;

	[Token(Token = "0x400225F")]
	[FieldOffset(Offset = "0x54")]
	private float m_ExternalIntensity;

	[Token(Token = "0x4002260")]
	[FieldOffset(Offset = "0x58")]
	private float m_TodIntensity;

	[Token(Token = "0x4002261")]
	[FieldOffset(Offset = "0x5C")]
	private float yDirection;

	[Token(Token = "0x4002262")]
	[FieldOffset(Offset = "0x60")]
	private float tod;

	[Token(Token = "0x4002263")]
	[FieldOffset(Offset = "0x64")]
	private float xtemp;

	[Token(Token = "0x4002264")]
	[FieldOffset(Offset = "0x68")]
	private float m_Dot;

	[Token(Token = "0x4002265")]
	[FieldOffset(Offset = "0x6C")]
	private float m_lValOrg;

	[Token(Token = "0x4002266")]
	[FieldOffset(Offset = "0x70")]
	private Renderer[] m_LightShaftRenderer;

	[Token(Token = "0x6001DAD")]
	[Address(RVA = "0x7A8940", Offset = "0x7A7740", Length = "0x2FB")]
	private void Start()
	{
	}

	[Token(Token = "0x6001DAE")]
	[Address(RVA = "0x7A8C40", Offset = "0x7A7A40", Length = "0x2F7")]
	private void Update()
	{
	}

	[Token(Token = "0x6001DAF")]
	[Address(RVA = "0x7A8F40", Offset = "0x7A7D40", Length = "0x177")]
	private void UpdateRotation(float tod)
	{
	}

	[Token(Token = "0x6001DB0")]
	[Address(RVA = "0x7A90C0", Offset = "0x7A7EC0", Length = "0x2F8")]
	private void UpdateMaterial()
	{
	}

	[Token(Token = "0x6001DB1")]
	[Address(RVA = "0x7A93C0", Offset = "0x7A81C0", Length = "0xEA")]
	private void UpdateLight()
	{
	}

	[Token(Token = "0x6001DB2")]
	[Address(RVA = "0x5094D0", Offset = "0x5082D0", Length = "0x6")]
	public void SetExternalIntensity(float newIntensity)
	{
	}

	[Token(Token = "0x6001DB3")]
	[Address(RVA = "0x5094F0", Offset = "0x5082F0", Length = "0x6")]
	public void SetTimeOfDayIntensity(float todIntensity)
	{
	}

	[Token(Token = "0x6001DB4")]
	[Address(RVA = "0x4D3E50", Offset = "0x4D2C50", Length = "0x4")]
	public void SetFollowTimeOfDay(bool followTod)
	{
	}

	[Token(Token = "0x6001DB5")]
	[Address(RVA = "0x7A94B0", Offset = "0x7A82B0", Length = "0x163")]
	private float CalculateDot()
	{
		return 0f;
	}

	[Token(Token = "0x6001DB6")]
	[Address(RVA = "0x7A9620", Offset = "0x7A8420", Length = "0xE8")]
	private float AngleDir(Vector3 fwd, Vector3 targetDir, Vector3 up)
	{
		return 0f;
	}

	[Token(Token = "0x6001DB7")]
	[Address(RVA = "0x7A9710", Offset = "0x7A8510", Length = "0x81")]
	public LightShaftTod()
	{
	}
}
