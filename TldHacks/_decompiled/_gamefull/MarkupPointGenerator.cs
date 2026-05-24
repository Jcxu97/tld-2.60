using Cpp2ILInjected;
using UnityEngine;

[ExecuteInEditMode]
[Token(Token = "0x2000039")]
public class MarkupPointGenerator : MonoBehaviour
{
	[Range(1f, 5000f)]
	[Token(Token = "0x40002E8")]
	[FieldOffset(Offset = "0x20")]
	public float m_Radius;

	[Range(1f, 100f)]
	[Token(Token = "0x40002E9")]
	[FieldOffset(Offset = "0x24")]
	public float m_PlacementDistance;

	[Range(1f, 1000f)]
	[Token(Token = "0x40002EA")]
	[FieldOffset(Offset = "0x28")]
	public float m_PlacementCeiling;

	[Range(1f, 100f)]
	[Token(Token = "0x40002EB")]
	[FieldOffset(Offset = "0x2C")]
	public float m_MarkupPointRadius;

	[Range(1f, 30f)]
	[Token(Token = "0x40002EC")]
	[FieldOffset(Offset = "0x30")]
	public int m_MinMarkupLinks;

	[Token(Token = "0x40002ED")]
	[FieldOffset(Offset = "0x34")]
	public AreaMarkupType m_AreaMarkupType;

	[HideInInspector]
	[Token(Token = "0x40002EE")]
	[FieldOffset(Offset = "0x38")]
	public bool m_TriggeredHasMarkupPointsWarning;

	[Token(Token = "0x6000316")]
	[Address(RVA = "0xA16A00", Offset = "0xA15800", Length = "0x6D")]
	public MarkupPointGenerator()
	{
	}
}
