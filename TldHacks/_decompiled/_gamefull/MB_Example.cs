using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000AE7")]
public class MB_Example : MonoBehaviour
{
	[Token(Token = "0x400695A")]
	[FieldOffset(Offset = "0x20")]
	public MB3_MeshBaker meshbaker;

	[Token(Token = "0x400695B")]
	[FieldOffset(Offset = "0x28")]
	public GameObject[] objsToCombine;

	[Token(Token = "0x6005CD3")]
	[Address(RVA = "0xF573D0", Offset = "0xF561D0", Length = "0x58")]
	private void Start()
	{
	}

	[Token(Token = "0x6005CD4")]
	[Address(RVA = "0xF57430", Offset = "0xF56230", Length = "0xBE")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6005CD5")]
	[Address(RVA = "0xF574F0", Offset = "0xF562F0", Length = "0x58")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x6005CD6")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public MB_Example()
	{
	}
}
