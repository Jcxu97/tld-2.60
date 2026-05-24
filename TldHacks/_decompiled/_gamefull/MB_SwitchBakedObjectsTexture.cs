using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000AEB")]
public class MB_SwitchBakedObjectsTexture : MonoBehaviour
{
	[Token(Token = "0x4006966")]
	[FieldOffset(Offset = "0x20")]
	public MeshRenderer targetRenderer;

	[Token(Token = "0x4006967")]
	[FieldOffset(Offset = "0x28")]
	public Material[] materials;

	[Token(Token = "0x4006968")]
	[FieldOffset(Offset = "0x30")]
	public MB3_MeshBaker meshBaker;

	[Token(Token = "0x6005CDF")]
	[Address(RVA = "0xF59050", Offset = "0xF57E50", Length = "0x58")]
	public void OnGUI()
	{
	}

	[Token(Token = "0x6005CE0")]
	[Address(RVA = "0xF590B0", Offset = "0xF57EB0", Length = "0xAE")]
	public void Start()
	{
	}

	[Token(Token = "0x6005CE1")]
	[Address(RVA = "0xF59160", Offset = "0xF57F60", Length = "0x5A8")]
	public void Update()
	{
	}

	[Token(Token = "0x6005CE2")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public MB_SwitchBakedObjectsTexture()
	{
	}
}
