using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[AddComponentMenu("NGUI/Interaction/Wrap Content")]
[Token(Token = "0x20000A6")]
public class UIWrapContent : MonoBehaviour
{
	[Token(Token = "0x20000A7")]
	public delegate void OnInitializeItem(GameObject go, int wrapIndex, int realIndex);

	[Token(Token = "0x400058C")]
	[FieldOffset(Offset = "0x20")]
	public int itemSize;

	[Token(Token = "0x400058D")]
	[FieldOffset(Offset = "0x24")]
	public bool cullContent;

	[Token(Token = "0x400058E")]
	[FieldOffset(Offset = "0x28")]
	public int minIndex;

	[Token(Token = "0x400058F")]
	[FieldOffset(Offset = "0x2C")]
	public int maxIndex;

	[Token(Token = "0x4000590")]
	[FieldOffset(Offset = "0x30")]
	public OnInitializeItem onInitializeItem;

	[Token(Token = "0x4000591")]
	[FieldOffset(Offset = "0x38")]
	private Transform mTrans;

	[Token(Token = "0x4000592")]
	[FieldOffset(Offset = "0x40")]
	private UIPanel mPanel;

	[Token(Token = "0x4000593")]
	[FieldOffset(Offset = "0x48")]
	private UIScrollView mScroll;

	[Token(Token = "0x4000594")]
	[FieldOffset(Offset = "0x50")]
	private bool mHorizontal;

	[Token(Token = "0x4000595")]
	[FieldOffset(Offset = "0x51")]
	private bool mFirstTime;

	[Token(Token = "0x4000596")]
	[FieldOffset(Offset = "0x58")]
	private List<Transform> mChildren;

	[Token(Token = "0x6000575")]
	[Address(RVA = "0xBF3C60", Offset = "0xBF2A60", Length = "0x1AB")]
	protected virtual void Start()
	{
	}

	[Token(Token = "0x6000576")]
	[Address(RVA = "0xBF3E10", Offset = "0xBF2C10", Length = "0x7")]
	protected virtual void OnMove(UIPanel panel)
	{
	}

	[ContextMenu("Sort Based on Scroll Movement")]
	[Token(Token = "0x6000577")]
	[Address(RVA = "0xBF3E20", Offset = "0xBF2C20", Length = "0x385")]
	public void SortBasedOnScrollMovement()
	{
	}

	[ContextMenu("Sort Alphabetically")]
	[Token(Token = "0x6000578")]
	[Address(RVA = "0xBF41B0", Offset = "0xBF2FB0", Length = "0x360")]
	public void SortAlphabetically()
	{
	}

	[Token(Token = "0x6000579")]
	[Address(RVA = "0xBF4520", Offset = "0xBF3320", Length = "0x298")]
	protected bool CacheScrollView()
	{
		return false;
	}

	[Token(Token = "0x600057A")]
	[Address(RVA = "0xBF47C0", Offset = "0xBF35C0", Length = "0x202")]
	private void ResetChildPositions()
	{
	}

	[Token(Token = "0x600057B")]
	[Address(RVA = "0xBF49D0", Offset = "0xBF37D0", Length = "0xB0F")]
	public void WrapContent()
	{
	}

	[Token(Token = "0x600057C")]
	[Address(RVA = "0xBF54E0", Offset = "0xBF42E0", Length = "0x13")]
	private void OnValidate()
	{
	}

	[Token(Token = "0x600057D")]
	[Address(RVA = "0xBF5500", Offset = "0xBF4300", Length = "0x1C5")]
	protected virtual void UpdateItem(Transform item, int index)
	{
	}

	[Token(Token = "0x600057E")]
	[Address(RVA = "0xBF56D0", Offset = "0xBF44D0", Length = "0x142")]
	public UIWrapContent()
	{
	}
}
