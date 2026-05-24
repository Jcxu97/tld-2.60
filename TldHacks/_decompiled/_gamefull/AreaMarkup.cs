using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[ExecuteInEditMode]
[Token(Token = "0x2000936")]
public class AreaMarkup : MonoBehaviour
{
	[Token(Token = "0x4006010")]
	[FieldOffset(Offset = "0x20")]
	public AreaMarkupType m_MarkupType;

	[Range(0.1f, 1000f)]
	[Token(Token = "0x4006011")]
	[FieldOffset(Offset = "0x24")]
	public float m_Radius;

	[Token(Token = "0x4006012")]
	[FieldOffset(Offset = "0x28")]
	public MarkupPointGenerator m_MarkupPointGenerator;

	[Token(Token = "0x4006013")]
	[FieldOffset(Offset = "0x30")]
	public List<AreaMarkup> m_ValidNeighborMarkups;

	[Token(Token = "0x60053CA")]
	[Address(RVA = "0xE76A60", Offset = "0xE75860", Length = "0x102")]
	private void Start()
	{
	}

	[Token(Token = "0x60053CB")]
	[Address(RVA = "0xE76B70", Offset = "0xE75970", Length = "0x232")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60053CC")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public AreaMarkup()
	{
	}
}
