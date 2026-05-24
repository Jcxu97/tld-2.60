using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200036E")]
public class CameraFacingLightGlare : MonoBehaviour
{
	[Token(Token = "0x200036F")]
	private enum EasingMode
	{
		[Token(Token = "0x4001E58")]
		Linear,
		[Token(Token = "0x4001E59")]
		Quadratic,
		[Token(Token = "0x4001E5A")]
		Cubic
	}

	[SerializeField]
	[Range(0f, 1f)]
	[Token(Token = "0x4001E52")]
	[FieldOffset(Offset = "0x20")]
	private float m_FacingThreshold;

	[SerializeField]
	[Token(Token = "0x4001E53")]
	[FieldOffset(Offset = "0x24")]
	private float m_FalloffStart;

	[SerializeField]
	[Token(Token = "0x4001E54")]
	[FieldOffset(Offset = "0x28")]
	private float m_FalloffRange;

	[SerializeField]
	[Token(Token = "0x4001E55")]
	[FieldOffset(Offset = "0x2C")]
	private EasingMode m_EasingMode;

	[SerializeField]
	[Token(Token = "0x4001E56")]
	[FieldOffset(Offset = "0x30")]
	private CameraEffects.BloomOverride m_BloomOverride;

	[Token(Token = "0x6001BD5")]
	[Address(RVA = "0x76A5D0", Offset = "0x7693D0", Length = "0x75C")]
	private void Update()
	{
	}

	[Token(Token = "0x6001BD6")]
	[Address(RVA = "0x76AD30", Offset = "0x769B30", Length = "0x58")]
	public CameraFacingLightGlare()
	{
	}
}
