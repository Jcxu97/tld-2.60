using System.Collections.Generic;
using AnimationOrTween;
using Cpp2ILInjected;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("NGUI/Interaction/Play Animation")]
[Token(Token = "0x2000085")]
public class UIPlayAnimation : MonoBehaviour
{
	[Token(Token = "0x4000499")]
	public static UIPlayAnimation current;

	[Token(Token = "0x400049A")]
	[FieldOffset(Offset = "0x20")]
	public Animation target;

	[Token(Token = "0x400049B")]
	[FieldOffset(Offset = "0x28")]
	public Animator animator;

	[Token(Token = "0x400049C")]
	[FieldOffset(Offset = "0x30")]
	public string clipName;

	[Token(Token = "0x400049D")]
	[FieldOffset(Offset = "0x38")]
	public Trigger trigger;

	[Token(Token = "0x400049E")]
	[FieldOffset(Offset = "0x3C")]
	public Direction playDirection;

	[Token(Token = "0x400049F")]
	[FieldOffset(Offset = "0x40")]
	public bool resetOnPlay;

	[Token(Token = "0x40004A0")]
	[FieldOffset(Offset = "0x41")]
	public bool clearSelection;

	[Token(Token = "0x40004A1")]
	[FieldOffset(Offset = "0x44")]
	public EnableCondition ifDisabledOnPlay;

	[Token(Token = "0x40004A2")]
	[FieldOffset(Offset = "0x48")]
	public DisableCondition disableWhenFinished;

	[Token(Token = "0x40004A3")]
	[FieldOffset(Offset = "0x50")]
	public List<EventDelegate> onFinished;

	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x40004A4")]
	[FieldOffset(Offset = "0x58")]
	private GameObject eventReceiver;

	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x40004A5")]
	[FieldOffset(Offset = "0x60")]
	private string callWhenFinished;

	[Token(Token = "0x40004A6")]
	[FieldOffset(Offset = "0x68")]
	private bool mStarted;

	[Token(Token = "0x40004A7")]
	[FieldOffset(Offset = "0x69")]
	private bool mActivated;

	[Token(Token = "0x40004A8")]
	[FieldOffset(Offset = "0x6A")]
	private bool dragHighlight;

	[Token(Token = "0x1700003F")]
	private bool dualState
	{
		[Token(Token = "0x6000480")]
		[Address(RVA = "0xBD9130", Offset = "0xBD7F30", Length = "0x12")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x6000481")]
	[Address(RVA = "0xBD9150", Offset = "0xBD7F50", Length = "0x279")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000482")]
	[Address(RVA = "0xBD93D0", Offset = "0xBD81D0", Length = "0x46C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000483")]
	[Address(RVA = "0xBD9840", Offset = "0xBD8640", Length = "0x517")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000484")]
	[Address(RVA = "0xBD9D60", Offset = "0xBD8B60", Length = "0x171")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000485")]
	[Address(RVA = "0xBD9EE0", Offset = "0xBD8CE0", Length = "0xEE")]
	private void OnHover(bool isOver)
	{
	}

	[Token(Token = "0x6000486")]
	[Address(RVA = "0xBD9FD0", Offset = "0xBD8DD0", Length = "0x152")]
	private void OnPress(bool isPressed)
	{
	}

	[Token(Token = "0x6000487")]
	[Address(RVA = "0xBDA130", Offset = "0xBD8F30", Length = "0x117")]
	private void OnClick()
	{
	}

	[Token(Token = "0x6000488")]
	[Address(RVA = "0xBDA250", Offset = "0xBD9050", Length = "0x117")]
	private void OnDoubleClick()
	{
	}

	[Token(Token = "0x6000489")]
	[Address(RVA = "0xBDA370", Offset = "0xBD9170", Length = "0xEE")]
	private void OnSelect(bool isSelected)
	{
	}

	[Token(Token = "0x600048A")]
	[Address(RVA = "0xBDA460", Offset = "0xBD9260", Length = "0x2AA")]
	private void OnToggle()
	{
	}

	[Token(Token = "0x600048B")]
	[Address(RVA = "0xBDA710", Offset = "0xBD9510", Length = "0x22E")]
	private void OnDragOver()
	{
	}

	[Token(Token = "0x600048C")]
	[Address(RVA = "0xBDA940", Offset = "0xBD9740", Length = "0x203")]
	private void OnDragOut()
	{
	}

	[Token(Token = "0x600048D")]
	[Address(RVA = "0xBDAB50", Offset = "0xBD9950", Length = "0x21A")]
	private void OnDrop(GameObject go)
	{
	}

	[Token(Token = "0x600048E")]
	[Address(RVA = "0xBDAD70", Offset = "0xBD9B70", Length = "0xB")]
	public void Play(bool forward)
	{
	}

	[Token(Token = "0x600048F")]
	[Address(RVA = "0xBDAD80", Offset = "0xBD9B80", Length = "0x5B3")]
	public void Play(bool forward, bool onlyIfDifferent)
	{
	}

	[Token(Token = "0x6000490")]
	[Address(RVA = "0xBDB340", Offset = "0xBDA140", Length = "0xF")]
	public void PlayForward()
	{
	}

	[Token(Token = "0x6000491")]
	[Address(RVA = "0xBDB350", Offset = "0xBDA150", Length = "0xD")]
	public void PlayReverse()
	{
	}

	[Token(Token = "0x6000492")]
	[Address(RVA = "0xBDB360", Offset = "0xBDA160", Length = "0x323")]
	private void OnFinished()
	{
	}

	[Token(Token = "0x6000493")]
	[Address(RVA = "0xBDB690", Offset = "0xBDA490", Length = "0xF2")]
	public UIPlayAnimation()
	{
	}
}
