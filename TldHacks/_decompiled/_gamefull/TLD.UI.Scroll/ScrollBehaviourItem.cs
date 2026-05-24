using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

namespace TLD.UI.Scroll;

[Token(Token = "0x2001397")]
public abstract class ScrollBehaviourItem : MonoBehaviour
{
	[Token(Token = "0x2001398")]
	private enum SelectBehaviour
	{
		[Token(Token = "0x4008FD9")]
		OnClick,
		[Token(Token = "0x4008FDA")]
		OnDoubleClick,
		[Token(Token = "0x4008FDB")]
		None
	}

	[Header("Scroll Select")]
	[SerializeField]
	[Token(Token = "0x4008FD3")]
	[FieldOffset(Offset = "0x20")]
	private SelectBehaviour m_SelectBehaviour;

	[Token(Token = "0x4008FD5")]
	[FieldOffset(Offset = "0x30")]
	protected bool m_IsSelected;

	[Token(Token = "0x4008FD6")]
	[FieldOffset(Offset = "0x31")]
	protected bool m_IsHovered;

	[Token(Token = "0x4008FD7")]
	[FieldOffset(Offset = "0x34")]
	private float m_DoubleClickTimer;

	[Token(Token = "0x14000040")]
	public event Action<GameObject> OnSelected
	{
		[CompilerGenerated]
		[Token(Token = "0x6007D20")]
		[Address(RVA = "0x11C55E0", Offset = "0x11C43E0", Length = "0x166")]
		add
		{
		}
		[CompilerGenerated]
		[Token(Token = "0x6007D21")]
		[Address(RVA = "0x11C5750", Offset = "0x11C4550", Length = "0x166")]
		remove
		{
		}
	}

	[Token(Token = "0x6007D22")]
	[Address(RVA = "0x11C58C0", Offset = "0x11C46C0", Length = "0xAC")]
	private void OnClick()
	{
	}

	[Token(Token = "0x6007D23")]
	[Address(RVA = "0x11C5970", Offset = "0x11C4770", Length = "0x14")]
	public void OnHover(bool isHovered)
	{
	}

	[Token(Token = "0x6007D24")]
	[Address(RVA = "0x5027B0", Offset = "0x5015B0", Length = "0x4")]
	public virtual void SetSelected(bool selected)
	{
	}

	[Token(Token = "0x6007D25")]
	[Address(RVA = "0x11C5990", Offset = "0x11C4790", Length = "0x6B")]
	protected virtual void Update()
	{
	}

	[Token(Token = "0x6007D26")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	protected virtual void OnItemClick()
	{
	}

	[Token(Token = "0x6007D27")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	protected virtual void OnItemDoubleClick()
	{
	}

	[Token(Token = "0x6007D28")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	protected virtual void OnItemHovered()
	{
	}

	[Token(Token = "0x6007D29")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	protected ScrollBehaviourItem()
	{
	}
}
