using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000389")]
public class FakeCubemapEnvironment : MonoBehaviour
{
	[Token(Token = "0x4001FA1")]
	[FieldOffset(Offset = "0x20")]
	public MeshRenderer m_FakeEnvironment;

	[Token(Token = "0x4001FA2")]
	[FieldOffset(Offset = "0x28")]
	private Material m_FakeEnvironmentMaterial;

	[Token(Token = "0x4001FA3")]
	private static readonly int Color1;

	[Token(Token = "0x6001C52")]
	[Address(RVA = "0x77DDA0", Offset = "0x77CBA0", Length = "0x70")]
	private void Awake()
	{
	}

	[Token(Token = "0x6001C53")]
	[Address(RVA = "0x77DE20", Offset = "0x77CC20", Length = "0x216")]
	private void Update()
	{
	}

	[Token(Token = "0x6001C54")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public FakeCubemapEnvironment()
	{
	}
}
