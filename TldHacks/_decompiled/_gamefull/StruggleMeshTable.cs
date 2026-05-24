using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20008D7")]
public class StruggleMeshTable : MonoBehaviour
{
	[Token(Token = "0x4005C87")]
	[FieldOffset(Offset = "0x20")]
	public MeshFilter m_BareHands;

	[Token(Token = "0x4005C88")]
	[FieldOffset(Offset = "0x28")]
	public MeshFilter m_Knife;

	[Token(Token = "0x4005C89")]
	[FieldOffset(Offset = "0x30")]
	public MeshFilter m_Hatchet;

	[Token(Token = "0x4005C8A")]
	[FieldOffset(Offset = "0x38")]
	public MeshFilter m_Prybar;

	[Token(Token = "0x4005C8B")]
	[FieldOffset(Offset = "0x40")]
	public MeshFilter m_ImprovisedKnife;

	[Token(Token = "0x4005C8C")]
	[FieldOffset(Offset = "0x48")]
	public MeshFilter m_CougarClawKnife;

	[Token(Token = "0x4005C8D")]
	[FieldOffset(Offset = "0x50")]
	public MeshFilter m_SurvivalKnife;

	[Token(Token = "0x4005C8E")]
	[FieldOffset(Offset = "0x58")]
	public MeshFilter m_ImprovisedHatchet;

	[Token(Token = "0x4005C8F")]
	[FieldOffset(Offset = "0x60")]
	public MeshFilter m_Hammer;

	[Token(Token = "0x4005C90")]
	[FieldOffset(Offset = "0x68")]
	public MeshFilter m_Revolver;

	[Token(Token = "0x4005C91")]
	[FieldOffset(Offset = "0x70")]
	private Dictionary<StruggleBonus.StruggleWeaponType, MeshFilter> m_SturggleMeshTable;

	[Token(Token = "0x6005149")]
	[Address(RVA = "0xE227D0", Offset = "0xE215D0", Length = "0x282")]
	public void Start()
	{
	}

	[Token(Token = "0x600514A")]
	[Address(RVA = "0xE22A60", Offset = "0xE21860", Length = "0xD1")]
	public MeshFilter GetMesh(StruggleBonus.StruggleWeaponType type)
	{
		return null;
	}

	[Token(Token = "0x600514B")]
	[Address(RVA = "0xE22B40", Offset = "0xE21940", Length = "0xE3")]
	public StruggleMeshTable()
	{
	}
}
