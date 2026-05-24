using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[AddComponentMenu("NGUI/Interaction/Table")]
[Token(Token = "0x200009D")]
public class UITable : UIWidgetContainer
{
	[Token(Token = "0x200009E")]
	public delegate void OnReposition();

	[Token(Token = "0x200009F")]
	public enum Direction
	{
		[Token(Token = "0x4000567")]
		Down,
		[Token(Token = "0x4000568")]
		Up
	}

	[Token(Token = "0x20000A0")]
	public enum Sorting
	{
		[Token(Token = "0x400056A")]
		None,
		[Token(Token = "0x400056B")]
		Alphabetic,
		[Token(Token = "0x400056C")]
		Horizontal,
		[Token(Token = "0x400056D")]
		Vertical,
		[Token(Token = "0x400056E")]
		Custom
	}

	[Token(Token = "0x4000559")]
	[FieldOffset(Offset = "0x20")]
	public int columns;

	[Token(Token = "0x400055A")]
	[FieldOffset(Offset = "0x24")]
	public Direction direction;

	[Token(Token = "0x400055B")]
	[FieldOffset(Offset = "0x28")]
	public Sorting sorting;

	[Token(Token = "0x400055C")]
	[FieldOffset(Offset = "0x2C")]
	public UIWidget.Pivot pivot;

	[Token(Token = "0x400055D")]
	[FieldOffset(Offset = "0x30")]
	public UIWidget.Pivot cellAlignment;

	[Token(Token = "0x400055E")]
	[FieldOffset(Offset = "0x34")]
	public bool hideInactive;

	[Token(Token = "0x400055F")]
	[FieldOffset(Offset = "0x35")]
	public bool keepWithinPanel;

	[Token(Token = "0x4000560")]
	[FieldOffset(Offset = "0x38")]
	public Vector2 padding;

	[Token(Token = "0x4000561")]
	[FieldOffset(Offset = "0x40")]
	public OnReposition onReposition;

	[Token(Token = "0x4000562")]
	[FieldOffset(Offset = "0x48")]
	public Comparison<Transform> onCustomSort;

	[Token(Token = "0x4000563")]
	[FieldOffset(Offset = "0x50")]
	protected UIPanel mPanel;

	[Token(Token = "0x4000564")]
	[FieldOffset(Offset = "0x58")]
	protected bool mInitDone;

	[Token(Token = "0x4000565")]
	[FieldOffset(Offset = "0x59")]
	protected bool mReposition;

	[Token(Token = "0x17000066")]
	public bool repositionNow
	{
		[Token(Token = "0x600054E")]
		[Address(RVA = "0xBEFDF0", Offset = "0xBEEBF0", Length = "0x13")]
		set
		{
		}
	}

	[Token(Token = "0x600054F")]
	[Address(RVA = "0xBEFE10", Offset = "0xBEEC10", Length = "0x42C")]
	public List<Transform> GetChildList()
	{
		return null;
	}

	[Token(Token = "0x6000550")]
	[Address(RVA = "0xBF0240", Offset = "0xBEF040", Length = "0x99")]
	protected virtual void Sort(List<Transform> list)
	{
	}

	[Token(Token = "0x6000551")]
	[Address(RVA = "0xBF02E0", Offset = "0xBEF0E0", Length = "0x3E")]
	protected virtual void Start()
	{
	}

	[Token(Token = "0x6000552")]
	[Address(RVA = "0xBF0320", Offset = "0xBEF120", Length = "0xCC")]
	protected virtual void Init()
	{
	}

	[Token(Token = "0x6000553")]
	[Address(RVA = "0xBF03F0", Offset = "0xBEF1F0", Length = "0x31")]
	protected virtual void LateUpdate()
	{
	}

	[Token(Token = "0x6000554")]
	[Address(RVA = "0xBF0430", Offset = "0xBEF230", Length = "0xD2")]
	private void OnValidate()
	{
	}

	[Token(Token = "0x6000555")]
	[Address(RVA = "0xBF0510", Offset = "0xBEF310", Length = "0xC64")]
	protected void RepositionVariableSize(List<Transform> children)
	{
	}

	[ContextMenu("Execute")]
	[Token(Token = "0x6000556")]
	[Address(RVA = "0xBF1180", Offset = "0xBEFF80", Length = "0x2EB")]
	public virtual void Reposition()
	{
	}

	[Token(Token = "0x6000557")]
	[Address(RVA = "0xBF1470", Offset = "0xBF0270", Length = "0x90")]
	public UITable()
	{
	}
}
