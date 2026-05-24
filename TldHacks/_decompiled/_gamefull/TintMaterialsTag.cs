using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000A3E")]
public class TintMaterialsTag : MonoBehaviour
{
	[SerializeField]
	[Token(Token = "0x40066AE")]
	[FieldOffset(Offset = "0x20")]
	private string m_Tag;

	[SerializeField]
	[Token(Token = "0x40066AF")]
	[FieldOffset(Offset = "0x28")]
	private Renderer[] m_Renderers;

	[Token(Token = "0x600593B")]
	[Address(RVA = "0x40E110", Offset = "0x40CF10", Length = "0x5")]
	public string GetTag()
	{
		return null;
	}

	[Token(Token = "0x600593C")]
	[Address(RVA = "0x413AB0", Offset = "0x4128B0", Length = "0x5")]
	public Renderer[] GetRenderers()
	{
		return null;
	}

	[Token(Token = "0x600593D")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public TintMaterialsTag()
	{
	}
}
