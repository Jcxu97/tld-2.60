using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200040D")]
public class WaterHazard : MonoBehaviour
{
	[Token(Token = "0x40024B9")]
	[FieldOffset(Offset = "0x20")]
	private Material m_LocalMaterial;

	[Token(Token = "0x40024BA")]
	[FieldOffset(Offset = "0x28")]
	private float m_WindAngle;

	[Token(Token = "0x40024BB")]
	[FieldOffset(Offset = "0x2C")]
	private float m_WindSpeed;

	[Token(Token = "0x6001EC6")]
	[Address(RVA = "0x7CC960", Offset = "0x7CB760", Length = "0xAC")]
	private void Start()
	{
	}

	[Token(Token = "0x6001EC7")]
	[Address(RVA = "0x7CCA10", Offset = "0x7CB810", Length = "0x130")]
	private void Update()
	{
	}

	[Token(Token = "0x6001EC8")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public WaterHazard()
	{
	}
}
