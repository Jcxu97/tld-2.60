using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20002EA")]
public abstract class ActivatedMaterialProperties : ScriptableObject
{
	[Token(Token = "0x170001F6")]
	public abstract string ActivationKeyword
	{
		[Token(Token = "0x600184B")]
		get;
	}

	[Token(Token = "0x600184C")]
	[Address(RVA = "0x6E4FC0", Offset = "0x6E3DC0", Length = "0x190")]
	public virtual void UpdateMaterial(Material mat, bool isActive)
	{
	}

	[Token(Token = "0x600184D")]
	[Address(RVA = "0x4A22A0", Offset = "0x4A10A0", Length = "0x7")]
	protected ActivatedMaterialProperties()
	{
	}
}
