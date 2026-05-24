using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000387")]
public class EyeGlow : MonoBehaviour
{
	[Token(Token = "0x4001F8E")]
	[FieldOffset(Offset = "0x20")]
	public string m_eyeMeshName;

	[Token(Token = "0x4001F8F")]
	[FieldOffset(Offset = "0x28")]
	public string m_headBoneName;

	[Token(Token = "0x4001F90")]
	[FieldOffset(Offset = "0x30")]
	public float m_minSensitivity;

	[Token(Token = "0x4001F91")]
	[FieldOffset(Offset = "0x34")]
	public float m_MaxSensitivity;

	[Token(Token = "0x4001F92")]
	[FieldOffset(Offset = "0x38")]
	public bool m_ignorePitch;

	[Token(Token = "0x4001F93")]
	[FieldOffset(Offset = "0x3C")]
	public float m_minDistance;

	[Token(Token = "0x4001F94")]
	[FieldOffset(Offset = "0x40")]
	public float m_maxDistance;

	[Token(Token = "0x4001F95")]
	[FieldOffset(Offset = "0x44")]
	public float m_minIntensity;

	[Token(Token = "0x4001F96")]
	[FieldOffset(Offset = "0x48")]
	public float m_MaxIntensity;

	[Token(Token = "0x4001F97")]
	[FieldOffset(Offset = "0x4C")]
	public float m_curDistance;

	[Token(Token = "0x4001F98")]
	[FieldOffset(Offset = "0x50")]
	private Color m_glowIntensity;

	[Token(Token = "0x4001F99")]
	[FieldOffset(Offset = "0x60")]
	private Material m_material;

	[Token(Token = "0x4001F9A")]
	[FieldOffset(Offset = "0x68")]
	private Transform m_fpsCamTransform;

	[Token(Token = "0x4001F9B")]
	[FieldOffset(Offset = "0x70")]
	private Transform m_headBoneTransform;

	[Token(Token = "0x4001F9C")]
	[FieldOffset(Offset = "0x78")]
	private BaseAi m_BaseAi;

	[Token(Token = "0x6001C4C")]
	[Address(RVA = "0x77CC80", Offset = "0x77BA80", Length = "0x3F3")]
	private void Start()
	{
	}

	[Token(Token = "0x6001C4D")]
	[Address(RVA = "0x77D080", Offset = "0x77BE80", Length = "0x56A")]
	private void Update()
	{
	}

	[Token(Token = "0x6001C4E")]
	[Address(RVA = "0x77D5F0", Offset = "0x77C3F0", Length = "0x127")]
	private bool TurnOffEyeGlow()
	{
		return false;
	}

	[Token(Token = "0x6001C4F")]
	[Address(RVA = "0x77D720", Offset = "0x77C520", Length = "0x6D")]
	public EyeGlow()
	{
	}
}
