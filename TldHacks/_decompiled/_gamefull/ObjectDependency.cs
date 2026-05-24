using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000A1B")]
public class ObjectDependency : MonoBehaviour
{
	[Token(Token = "0x4006628")]
	[FieldOffset(Offset = "0x20")]
	public GameObject m_Dependency;

	[Token(Token = "0x4006629")]
	[FieldOffset(Offset = "0x28")]
	private float m_CheckTime;

	[Token(Token = "0x600588B")]
	[Address(RVA = "0xEECD10", Offset = "0xEEBB10", Length = "0x58")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600588C")]
	[Address(RVA = "0xEECD70", Offset = "0xEEBB70", Length = "0x158")]
	private void Update()
	{
	}

	[Token(Token = "0x600588D")]
	[Address(RVA = "0xEECED0", Offset = "0xEEBCD0", Length = "0xFF")]
	private void CheckDependency()
	{
	}

	[Token(Token = "0x600588E")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public ObjectDependency()
	{
	}
}
