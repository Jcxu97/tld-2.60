using Cpp2ILInjected;
using UnityEngine;

namespace TLD.ModularElectrolizer;

[CreateAssetMenu(menuName = "Aurora/Activation parameters")]
[Token(Token = "0x20013CA")]
public class ActivationParameters : ScriptableObject
{
	[Token(Token = "0x40090FC")]
	[FieldOffset(Offset = "0x18")]
	public MinMax m_ActivationThreshold;

	[Token(Token = "0x40090FD")]
	[FieldOffset(Offset = "0x20")]
	public MinMax m_ActivationStable;

	[Token(Token = "0x6007E63")]
	[Address(RVA = "0x11DEAE0", Offset = "0x11DD8E0", Length = "0x28")]
	public float GetRandomActivationThreshold()
	{
		return 0f;
	}

	[Token(Token = "0x6007E64")]
	[Address(RVA = "0x11DEB10", Offset = "0x11DD910", Length = "0x28")]
	public float GetRandomStableThreshold()
	{
		return 0f;
	}

	[Token(Token = "0x6007E65")]
	[Address(RVA = "0x4A22A0", Offset = "0x4A10A0", Length = "0x7")]
	public ActivationParameters()
	{
	}
}
