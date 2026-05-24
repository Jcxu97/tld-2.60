using Cpp2ILInjected;
using UnityEngine;

[RequireComponent(typeof(SphereCollider))]
[Token(Token = "0x20003AD")]
public class HeightFogVolume : MonoBehaviour
{
	[Token(Token = "0x40020CA")]
	[FieldOffset(Offset = "0x20")]
	public bool m_IsGlobal;

	[Range(0f, 1f)]
	[Token(Token = "0x40020CB")]
	[FieldOffset(Offset = "0x24")]
	public float m_Falloff;

	[Token(Token = "0x40020CC")]
	[FieldOffset(Offset = "0x28")]
	public HeightFogSettings m_Settings;

	[AutoComponent(ComponentRequirement.Required)]
	[SerializeField]
	[Token(Token = "0x40020CD")]
	[FieldOffset(Offset = "0x78")]
	private SphereCollider m_Collider;

	[Token(Token = "0x6001D09")]
	[Address(RVA = "0x792B50", Offset = "0x791950", Length = "0x396")]
	public float GetBlendAmount()
	{
		return 0f;
	}

	[Token(Token = "0x6001D0A")]
	[Address(RVA = "0x792EF0", Offset = "0x791CF0", Length = "0x10C")]
	private void Start()
	{
	}

	[Token(Token = "0x6001D0B")]
	[Address(RVA = "0x793000", Offset = "0x791E00", Length = "0x1D9")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6001D0C")]
	[Address(RVA = "0x7931E0", Offset = "0x791FE0", Length = "0x200")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x6001D0D")]
	[Address(RVA = "0x7933F0", Offset = "0x7921F0", Length = "0x3E")]
	private void OnValidate()
	{
	}

	[Token(Token = "0x6001D0E")]
	[Address(RVA = "0x6A2880", Offset = "0x6A1680", Length = "0x47")]
	public HeightFogVolume()
	{
	}
}
