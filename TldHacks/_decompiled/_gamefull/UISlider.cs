using System;
using Cpp2ILInjected;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("NGUI/Interaction/NGUI Slider")]
[Token(Token = "0x200009A")]
public class UISlider : UIProgressBar
{
	[Token(Token = "0x200009B")]
	private enum Direction
	{
		[Token(Token = "0x4000556")]
		Horizontal,
		[Token(Token = "0x4000557")]
		Vertical,
		[Token(Token = "0x4000558")]
		Upgraded
	}

	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x4000551")]
	[FieldOffset(Offset = "0x80")]
	private Transform foreground;

	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x4000552")]
	[FieldOffset(Offset = "0x88")]
	private float rawValue;

	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x4000553")]
	[FieldOffset(Offset = "0x8C")]
	private Direction direction;

	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x4000554")]
	[FieldOffset(Offset = "0x90")]
	protected bool mInverted;

	[Obsolete("Use 'value' instead")]
	[Token(Token = "0x17000064")]
	public float sliderValue
	{
		[Token(Token = "0x600053F")]
		[Address(RVA = "0xBE4890", Offset = "0xBE3690", Length = "0x47")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6000540")]
		[Address(RVA = "0xBE8820", Offset = "0xBE7620", Length = "0x8")]
		set
		{
		}
	}

	[Obsolete("Use 'fillDirection' instead")]
	[Token(Token = "0x17000065")]
	public bool inverted
	{
		[Token(Token = "0x6000541")]
		[Address(RVA = "0xBE5680", Offset = "0xBE4480", Length = "0x10")]
		get
		{
			return false;
		}
		[Token(Token = "0x6000542")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		set
		{
		}
	}

	[Token(Token = "0x6000543")]
	[Address(RVA = "0xBEE790", Offset = "0xBED590", Length = "0x185")]
	protected override void Upgrade()
	{
	}

	[Token(Token = "0x6000544")]
	[Address(RVA = "0xBEE920", Offset = "0xBED720", Length = "0xA15")]
	protected override void OnStart()
	{
	}

	[Token(Token = "0x6000545")]
	[Address(RVA = "0xBEF340", Offset = "0xBEE140", Length = "0x124")]
	protected void OnPressBackground(GameObject go, bool isPressed)
	{
	}

	[Token(Token = "0x6000546")]
	[Address(RVA = "0xBEF470", Offset = "0xBEE270", Length = "0x107")]
	protected void OnDragBackground(GameObject go, Vector2 delta)
	{
	}

	[Token(Token = "0x6000547")]
	[Address(RVA = "0xBEF580", Offset = "0xBEE380", Length = "0x204")]
	protected void OnPressForeground(GameObject go, bool isPressed)
	{
	}

	[Token(Token = "0x6000548")]
	[Address(RVA = "0xBEF790", Offset = "0xBEE590", Length = "0x111")]
	protected void OnDragForeground(GameObject go, Vector2 delta)
	{
	}

	[Token(Token = "0x6000549")]
	[Address(RVA = "0xBEF8B0", Offset = "0xBEE6B0", Length = "0x15C")]
	public void OnKey(KeyCode key)
	{
	}

	[Token(Token = "0x600054A")]
	[Address(RVA = "0xBEFA10", Offset = "0xBEE810", Length = "0x114")]
	public UISlider()
	{
	}
}
