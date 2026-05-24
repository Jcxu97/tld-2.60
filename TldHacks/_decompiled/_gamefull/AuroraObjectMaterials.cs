using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000360")]
public class AuroraObjectMaterials : MonoBehaviour
{
	[Token(Token = "0x2000361")]
	private enum TypeMaterialActive
	{
		[Token(Token = "0x4001DD4")]
		None,
		[Token(Token = "0x4001DD5")]
		TypeMaterialAurora,
		[Token(Token = "0x4001DD6")]
		TypeMaterialNormal
	}

	[Token(Token = "0x4001DD1")]
	[FieldOffset(Offset = "0x20")]
	public List<AuroraObjectMaterialInfo> m_AuroraObjectMaterialInfoList;

	[Token(Token = "0x4001DD2")]
	[FieldOffset(Offset = "0x28")]
	private TypeMaterialActive m_TypeMaterialActive;

	[Token(Token = "0x6001B80")]
	[Address(RVA = "0x761270", Offset = "0x760070", Length = "0x283")]
	public void Awake()
	{
	}

	[Token(Token = "0x6001B81")]
	[Address(RVA = "0x761500", Offset = "0x760300", Length = "0x22B")]
	public void Reset()
	{
	}

	[Token(Token = "0x6001B82")]
	[Address(RVA = "0x761730", Offset = "0x760530", Length = "0x24E")]
	public void SwitchToNormalMaterials()
	{
	}

	[Token(Token = "0x6001B83")]
	[Address(RVA = "0x761980", Offset = "0x760780", Length = "0x24E")]
	public void SwitchToAuroraMaterials()
	{
	}

	[Token(Token = "0x6001B84")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public AuroraObjectMaterials()
	{
	}
}
