using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000AE3")]
public class MB_SwapShirts : MonoBehaviour
{
	[Token(Token = "0x400694F")]
	[FieldOffset(Offset = "0x20")]
	public MB3_MeshBaker meshBaker;

	[Token(Token = "0x4006950")]
	[FieldOffset(Offset = "0x28")]
	public Renderer[] clothingAndBodyPartsBareTorso;

	[Token(Token = "0x4006951")]
	[FieldOffset(Offset = "0x30")]
	public Renderer[] clothingAndBodyPartsBareTorsoDamagedArm;

	[Token(Token = "0x4006952")]
	[FieldOffset(Offset = "0x38")]
	public Renderer[] clothingAndBodyPartsHoodie;

	[Token(Token = "0x6005CC2")]
	[Address(RVA = "0xF55CE0", Offset = "0xF54AE0", Length = "0x249")]
	private void Start()
	{
	}

	[Token(Token = "0x6005CC3")]
	[Address(RVA = "0xF55F30", Offset = "0xF54D30", Length = "0xFB")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x6005CC4")]
	[Address(RVA = "0xF56030", Offset = "0xF54E30", Length = "0x690")]
	private void ChangeOutfit(Renderer[] outfit)
	{
	}

	[Token(Token = "0x6005CC5")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public MB_SwapShirts()
	{
	}
}
