using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[AddComponentMenu("NGUI/Interaction/Grid")]
[Token(Token = "0x200007B")]
public class UIGrid : UIWidgetContainer
{
	[Token(Token = "0x200007C")]
	public delegate void OnReposition();

	[Token(Token = "0x200007D")]
	public enum Arrangement
	{
		[Token(Token = "0x4000460")]
		Horizontal,
		[Token(Token = "0x4000461")]
		Vertical,
		[Token(Token = "0x4000462")]
		CellSnap
	}

	[Token(Token = "0x200007E")]
	public enum Sorting
	{
		[Token(Token = "0x4000464")]
		None,
		[Token(Token = "0x4000465")]
		Alphabetic,
		[Token(Token = "0x4000466")]
		Horizontal,
		[Token(Token = "0x4000467")]
		Vertical,
		[Token(Token = "0x4000468")]
		Custom
	}

	[Token(Token = "0x4000450")]
	[FieldOffset(Offset = "0x20")]
	public Arrangement arrangement;

	[Token(Token = "0x4000451")]
	[FieldOffset(Offset = "0x24")]
	public Sorting sorting;

	[Token(Token = "0x4000452")]
	[FieldOffset(Offset = "0x28")]
	public UIWidget.Pivot pivot;

	[Token(Token = "0x4000453")]
	[FieldOffset(Offset = "0x2C")]
	public int maxPerLine;

	[Token(Token = "0x4000454")]
	[FieldOffset(Offset = "0x30")]
	public float cellWidth;

	[Token(Token = "0x4000455")]
	[FieldOffset(Offset = "0x34")]
	public float cellHeight;

	[Token(Token = "0x4000456")]
	[FieldOffset(Offset = "0x38")]
	public bool animateSmoothly;

	[Token(Token = "0x4000457")]
	[FieldOffset(Offset = "0x39")]
	public bool hideInactive;

	[Token(Token = "0x4000458")]
	[FieldOffset(Offset = "0x3A")]
	public bool keepWithinPanel;

	[Token(Token = "0x4000459")]
	[FieldOffset(Offset = "0x40")]
	public OnReposition onReposition;

	[Token(Token = "0x400045A")]
	[FieldOffset(Offset = "0x48")]
	public Comparison<Transform> onCustomSort;

	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x400045B")]
	[FieldOffset(Offset = "0x50")]
	private bool sorted;

	[Token(Token = "0x400045C")]
	[FieldOffset(Offset = "0x51")]
	protected bool mReposition;

	[Token(Token = "0x400045D")]
	[FieldOffset(Offset = "0x58")]
	protected UIPanel mPanel;

	[Token(Token = "0x400045E")]
	[FieldOffset(Offset = "0x60")]
	protected bool mInitDone;

	[Token(Token = "0x1700003D")]
	public bool repositionNow
	{
		[Token(Token = "0x600044C")]
		[Address(RVA = "0xA38DB0", Offset = "0xA37BB0", Length = "0x13")]
		set
		{
		}
	}

	[Token(Token = "0x600044D")]
	[Address(RVA = "0xA38DD0", Offset = "0xA37BD0", Length = "0x3E1")]
	public void GetChildList(List<Transform> list)
	{
	}

	[Token(Token = "0x600044E")]
	[Address(RVA = "0xA391C0", Offset = "0xA37FC0", Length = "0x5FC")]
	public Transform GetChild(int index)
	{
		return null;
	}

	[Token(Token = "0x600044F")]
	[Address(RVA = "0xA397C0", Offset = "0xA385C0", Length = "0x5CB")]
	public int GetIndex(Transform trans)
	{
		return 0;
	}

	[Token(Token = "0x6000450")]
	[Address(RVA = "0xA39D90", Offset = "0xA38B90", Length = "0xB")]
	public void AddChild(Transform trans)
	{
	}

	[Token(Token = "0x6000451")]
	[Address(RVA = "0xA39DA0", Offset = "0xA38BA0", Length = "0x630")]
	public void AddChild(Transform trans, bool sort)
	{
	}

	[Token(Token = "0x6000452")]
	[Address(RVA = "0xA3A3E0", Offset = "0xA391E0", Length = "0x5F1")]
	public bool RemoveChild(Transform t)
	{
		return false;
	}

	[Token(Token = "0x6000453")]
	[Address(RVA = "0xA3A9E0", Offset = "0xA397E0", Length = "0xCC")]
	protected virtual void Init()
	{
	}

	[Token(Token = "0x6000454")]
	[Address(RVA = "0xA3AAB0", Offset = "0xA398B0", Length = "0x58")]
	protected virtual void Start()
	{
	}

	[Token(Token = "0x6000455")]
	[Address(RVA = "0xA3AB10", Offset = "0xA39910", Length = "0x2B")]
	protected virtual void Update()
	{
	}

	[Token(Token = "0x6000456")]
	[Address(RVA = "0xA3AB40", Offset = "0xA39940", Length = "0xD2")]
	private void OnValidate()
	{
	}

	[Token(Token = "0x6000457")]
	[Address(RVA = "0xA3AC20", Offset = "0xA39A20", Length = "0x48")]
	public static int SortByName(Transform a, Transform b)
	{
		return 0;
	}

	[Token(Token = "0x6000458")]
	[Address(RVA = "0xA3AC70", Offset = "0xA39A70", Length = "0x1E6")]
	public static int SortHorizontal(Transform a, Transform b)
	{
		return 0;
	}

	[Token(Token = "0x6000459")]
	[Address(RVA = "0xA3AE60", Offset = "0xA39C60", Length = "0x1E6")]
	public static int SortVertical(Transform a, Transform b)
	{
		return 0;
	}

	[Token(Token = "0x600045A")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	protected virtual void Sort(List<Transform> list)
	{
	}

	[ContextMenu("Execute")]
	[Token(Token = "0x600045B")]
	[Address(RVA = "0xA3B050", Offset = "0xA39E50", Length = "0x825")]
	public virtual void Reposition()
	{
	}

	[Token(Token = "0x600045C")]
	[Address(RVA = "0xA3B880", Offset = "0xA3A680", Length = "0x178")]
	public void ConstrainWithinPanel()
	{
	}

	[Token(Token = "0x600045D")]
	[Address(RVA = "0xA3BA00", Offset = "0xA3A800", Length = "0x7B6")]
	protected virtual void ResetPosition(List<Transform> list)
	{
	}

	[Token(Token = "0x600045E")]
	[Address(RVA = "0xA3C1C0", Offset = "0xA3AFC0", Length = "0x51")]
	public UIGrid()
	{
	}
}
