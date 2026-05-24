using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000A35")]
public class ReplaceMaterial : MonoBehaviour
{
	[Token(Token = "0x4006683")]
	[FieldOffset(Offset = "0x20")]
	public Material sourceMaterial;

	[Token(Token = "0x4006684")]
	[FieldOffset(Offset = "0x28")]
	public List<Material> newMaterial;

	[Token(Token = "0x4006685")]
	[FieldOffset(Offset = "0x30")]
	public bool chooseRandom;

	[Token(Token = "0x4006686")]
	[FieldOffset(Offset = "0x31")]
	public bool includeChildren;

	[Token(Token = "0x4006687")]
	[FieldOffset(Offset = "0x38")]
	private List<Renderer> allRends;

	[Token(Token = "0x4006688")]
	[FieldOffset(Offset = "0x40")]
	private int newMatIndex;

	[Token(Token = "0x4006689")]
	[FieldOffset(Offset = "0x44")]
	private bool m_MaterialsReplaced;

	[Token(Token = "0x400668A")]
	[FieldOffset(Offset = "0x45")]
	private bool m_StartHasBeenCalled;

	[Token(Token = "0x400668B")]
	[FieldOffset(Offset = "0x48")]
	private Dictionary<string, List<Renderer>> m_OriginalMaterialNameMap;

	[Token(Token = "0x400668C")]
	private static ReplaceMaterialSaveDataProxy m_ReplaceMaterialSaveDataProxy;

	[Token(Token = "0x6005916")]
	[Address(RVA = "0xEEFC60", Offset = "0xEEEA60", Length = "0x113")]
	private void Start()
	{
	}

	[Token(Token = "0x6005917")]
	[Address(RVA = "0xEEFD80", Offset = "0xEEEB80", Length = "0x10D")]
	private void Update()
	{
	}

	[Token(Token = "0x6005918")]
	[Address(RVA = "0xEEFE90", Offset = "0xEEEC90", Length = "0x166")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x6005919")]
	[Address(RVA = "0xEF0000", Offset = "0xEEEE00", Length = "0x1A8")]
	public void Deserialize(string text)
	{
	}

	[Token(Token = "0x600591A")]
	[Address(RVA = "0xEF01B0", Offset = "0xEEEFB0", Length = "0x1F2")]
	public void ScanForRenderers()
	{
	}

	[Token(Token = "0x600591B")]
	[Address(RVA = "0xEF03B0", Offset = "0xEEF1B0", Length = "0xA8")]
	public void ChooseRandomMaterial(bool useRandom)
	{
	}

	[Token(Token = "0x600591C")]
	[Address(RVA = "0xEF0460", Offset = "0xEEF260", Length = "0x229")]
	public void ReplaceMaterials(Material srcMat, int newMatIndex)
	{
	}

	[Token(Token = "0x600591D")]
	[Address(RVA = "0xEF0690", Offset = "0xEEF490", Length = "0x43F")]
	private void SetMaterialNameMap()
	{
	}

	[Token(Token = "0x600591E")]
	[Address(RVA = "0xEF0AD0", Offset = "0xEEF8D0", Length = "0x18F")]
	public ReplaceMaterial()
	{
	}
}
