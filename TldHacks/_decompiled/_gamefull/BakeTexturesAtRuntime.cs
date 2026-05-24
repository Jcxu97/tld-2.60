using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000AE1")]
public class BakeTexturesAtRuntime : MonoBehaviour
{
	[Token(Token = "0x400694C")]
	[FieldOffset(Offset = "0x20")]
	public GameObject target;

	[Token(Token = "0x400694D")]
	[FieldOffset(Offset = "0x28")]
	private float elapsedTime;

	[Token(Token = "0x400694E")]
	[FieldOffset(Offset = "0x30")]
	private MB3_TextureBaker.CreateAtlasesCoroutineResult result;

	[Token(Token = "0x6005CBD")]
	[Address(RVA = "0xF551F0", Offset = "0xF53FF0", Length = "0x6CA")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x6005CBE")]
	[Address(RVA = "0xF558C0", Offset = "0xF546C0", Length = "0x2E6")]
	private void OnBuiltAtlasesSuccess()
	{
	}

	[Token(Token = "0x6005CBF")]
	[Address(RVA = "0xF55BB0", Offset = "0xF549B0", Length = "0xC2")]
	public BakeTexturesAtRuntime()
	{
	}
}
