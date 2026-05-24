using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000172")]
public class HeadLights : MonoBehaviour
{
	[Token(Token = "0x4000D81")]
	[FieldOffset(Offset = "0x20")]
	public float m_AttractDistance;

	[Token(Token = "0x4000D82")]
	[FieldOffset(Offset = "0x24")]
	public float m_FleeDistance;

	[Token(Token = "0x6000E3C")]
	[Address(RVA = "0x5EBDF0", Offset = "0x5EABF0", Length = "0x23B")]
	private void Update()
	{
	}

	[Token(Token = "0x6000E3D")]
	[Address(RVA = "0x5EC030", Offset = "0x5EAE30", Length = "0x25E")]
	private void ProcessHeadLightsReaction(BaseAi bai)
	{
	}

	[Token(Token = "0x6000E3E")]
	[Address(RVA = "0x5EC290", Offset = "0x5EB090", Length = "0x34")]
	private bool ShouldReactToHeadLights(BaseAi bai)
	{
		return false;
	}

	[Token(Token = "0x6000E3F")]
	[Address(RVA = "0x5EC2D0", Offset = "0x5EB0D0", Length = "0x34C")]
	private void MaybeInvestigateHeadLights(BaseAi bai)
	{
	}

	[Token(Token = "0x6000E40")]
	[Address(RVA = "0x5EC620", Offset = "0x5EB420", Length = "0x338")]
	private void MaybeFleeHeadLights(BaseAi bai)
	{
	}

	[Token(Token = "0x6000E41")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public HeadLights()
	{
	}
}
