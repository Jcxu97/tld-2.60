using System;
using Cpp2ILInjected;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("NGUI/Interaction/NGUI Scroll Bar")]
[Token(Token = "0x2000093")]
public class UIScrollBar : UISlider
{
	[Token(Token = "0x2000094")]
	private enum Direction
	{
		[Token(Token = "0x400051B")]
		Horizontal,
		[Token(Token = "0x400051C")]
		Vertical,
		[Token(Token = "0x400051D")]
		Upgraded
	}

	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x4000517")]
	[FieldOffset(Offset = "0x98")]
	protected float mSize;

	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x4000518")]
	[FieldOffset(Offset = "0x9C")]
	private float mScroll;

	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x4000519")]
	[FieldOffset(Offset = "0xA0")]
	private Direction mDir;

	[Obsolete("Use 'value' instead")]
	[Token(Token = "0x17000059")]
	public float scrollValue
	{
		[Token(Token = "0x6000510")]
		[Address(RVA = "0xBE4890", Offset = "0xBE3690", Length = "0x47")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6000511")]
		[Address(RVA = "0xBE8820", Offset = "0xBE7620", Length = "0x8")]
		set
		{
		}
	}

	[Token(Token = "0x1700005A")]
	public float barSize
	{
		[Token(Token = "0x6000512")]
		[Address(RVA = "0x507960", Offset = "0x506760", Length = "0x9")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6000513")]
		[Address(RVA = "0xBE8830", Offset = "0xBE7630", Length = "0x204")]
		set
		{
		}
	}

	[Token(Token = "0x6000514")]
	[Address(RVA = "0xBE8A40", Offset = "0xBE7840", Length = "0x4C")]
	protected override void Upgrade()
	{
	}

	[Token(Token = "0x6000515")]
	[Address(RVA = "0xBE8A90", Offset = "0xBE7890", Length = "0x523")]
	protected override void OnStart()
	{
	}

	[Token(Token = "0x6000516")]
	[Address(RVA = "0xBE8FC0", Offset = "0xBE7DC0", Length = "0x302")]
	protected override float LocalToValue(Vector2 localPos)
	{
		return 0f;
	}

	[Token(Token = "0x6000517")]
	[Address(RVA = "0xBE92D0", Offset = "0xBE80D0", Length = "0x457")]
	public override void ForceUpdate()
	{
	}

	[Token(Token = "0x6000518")]
	[Address(RVA = "0xBE9730", Offset = "0xBE8530", Length = "0x124")]
	public UIScrollBar()
	{
	}
}
