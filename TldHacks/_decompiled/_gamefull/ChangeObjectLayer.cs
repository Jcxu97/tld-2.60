using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20009F6")]
public class ChangeObjectLayer : MonoBehaviour
{
	[SerializeField]
	[Token(Token = "0x4006549")]
	[FieldOffset(Offset = "0x20")]
	private List<GameObject> m_ObjectsToChange;

	[SerializeField]
	[Token(Token = "0x400654A")]
	[FieldOffset(Offset = "0x28")]
	private int m_TargetLayer;

	[SerializeField]
	[Token(Token = "0x400654B")]
	[FieldOffset(Offset = "0x2C")]
	private bool m_RevertOnDisable;

	[Token(Token = "0x400654C")]
	[FieldOffset(Offset = "0x30")]
	private List<int> m_OriginalLayer;

	[Token(Token = "0x60057AF")]
	[Address(RVA = "0xED7CF0", Offset = "0xED6AF0", Length = "0x2A6")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60057B0")]
	[Address(RVA = "0xED7FA0", Offset = "0xED6DA0", Length = "0x1D4")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60057B1")]
	[Address(RVA = "0xED8180", Offset = "0xED6F80", Length = "0x18F")]
	public ChangeObjectLayer()
	{
	}
}
