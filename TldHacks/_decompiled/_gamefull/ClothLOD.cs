using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000377")]
public class ClothLOD : MonoBehaviour
{
	[Token(Token = "0x4001EBB")]
	[FieldOffset(Offset = "0x20")]
	public bool m_ForceAlwaysEnabled;

	[Token(Token = "0x4001EBC")]
	[FieldOffset(Offset = "0x24")]
	public float m_Distance;

	[Token(Token = "0x6001C02")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public ClothLOD()
	{
	}
}
