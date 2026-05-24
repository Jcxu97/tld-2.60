using Cpp2ILInjected;
using UnityEngine;

[ExecuteInEditMode]
[Token(Token = "0x20008DE")]
public class CameraLodBiasOverride : MonoBehaviour
{
	[SerializeField]
	[Token(Token = "0x4005D00")]
	[FieldOffset(Offset = "0x20")]
	private float m_LodBias;

	[Token(Token = "0x4005D01")]
	[FieldOffset(Offset = "0x24")]
	private float m_LastLodBias;

	[Token(Token = "0x6005196")]
	[Address(RVA = "0x504300", Offset = "0x503100", Length = "0x6")]
	public void SetLodBias(float lodBias)
	{
	}

	[Token(Token = "0x6005197")]
	[Address(RVA = "0xE2F8C0", Offset = "0xE2E6C0", Length = "0x9F")]
	private void OnPreCull()
	{
	}

	[Token(Token = "0x6005198")]
	[Address(RVA = "0xE2F960", Offset = "0xE2E760", Length = "0x57")]
	private void OnPostRender()
	{
	}

	[Token(Token = "0x6005199")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public CameraLodBiasOverride()
	{
	}
}
