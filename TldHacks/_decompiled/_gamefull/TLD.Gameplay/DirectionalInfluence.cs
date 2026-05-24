using Cpp2ILInjected;
using UnityEngine;

namespace TLD.Gameplay;

[Token(Token = "0x2001472")]
public class DirectionalInfluence : MonoBehaviour
{
	[Range(0f, 360f)]
	[Token(Token = "0x400945B")]
	[FieldOffset(Offset = "0x20")]
	public float m_ConeAngle;

	[Token(Token = "0x6008219")]
	[Address(RVA = "0x122C280", Offset = "0x122B080", Length = "0x271")]
	public float GetNormalizedInfluenceFromPosition(Vector3 worldPos)
	{
		return 0f;
	}

	[Token(Token = "0x600821A")]
	[Address(RVA = "0x122C500", Offset = "0x122B300", Length = "0x4A")]
	public DirectionalInfluence()
	{
	}
}
