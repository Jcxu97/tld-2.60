using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20006EB")]
public class ToggleButton : MonoBehaviour
{
	[SerializeField]
	[Token(Token = "0x40049BE")]
	[FieldOffset(Offset = "0x20")]
	private UISprite m_Toggle;

	[SerializeField]
	[Token(Token = "0x40049BF")]
	[FieldOffset(Offset = "0x28")]
	private float m_ToggleOffset;

	[Header("Tween Settings")]
	[SerializeField]
	[Token(Token = "0x40049C0")]
	[FieldOffset(Offset = "0x30")]
	private Gradient m_ColorFade;

	[SerializeField]
	[Token(Token = "0x40049C1")]
	[FieldOffset(Offset = "0x38")]
	private AnimationCurve m_ToggleCurve;

	[SerializeField]
	[Token(Token = "0x40049C2")]
	[FieldOffset(Offset = "0x40")]
	private float m_ToggleTime;

	[Token(Token = "0x40049C5")]
	[FieldOffset(Offset = "0x51")]
	private bool m_IsTweening;

	[Token(Token = "0x40049C6")]
	[FieldOffset(Offset = "0x54")]
	private float m_TweenTime;

	[Token(Token = "0x17000313")]
	[field: Token(Token = "0x40049C4")]
	[field: FieldOffset(Offset = "0x50")]
	public bool Value
	{
		[Token(Token = "0x6003CDB")]
		[Address(RVA = "0x6674B0", Offset = "0x6662B0", Length = "0x5")]
		get;
		[Token(Token = "0x6003CDC")]
		[Address(RVA = "0xB854B0", Offset = "0xB842B0", Length = "0x4")]
		private set;
	}

	[Token(Token = "0x1400000A")]
	public event Action m_OnToggled
	{
		[CompilerGenerated]
		[Token(Token = "0x6003CD9")]
		[Address(RVA = "0xB852D0", Offset = "0xB840D0", Length = "0xEB")]
		add
		{
		}
		[CompilerGenerated]
		[Token(Token = "0x6003CDA")]
		[Address(RVA = "0xB853C0", Offset = "0xB841C0", Length = "0xEB")]
		remove
		{
		}
	}

	[Token(Token = "0x6003CDD")]
	[Address(RVA = "0xB854C0", Offset = "0xB842C0", Length = "0x14")]
	private void Awake()
	{
	}

	[Token(Token = "0x6003CDE")]
	[Address(RVA = "0xB854E0", Offset = "0xB842E0", Length = "0x7")]
	private void OnClick()
	{
	}

	[Token(Token = "0x6003CDF")]
	[Address(RVA = "0xB854F0", Offset = "0xB842F0", Length = "0x8E")]
	public void ToggleValue()
	{
	}

	[Token(Token = "0x6003CE0")]
	[Address(RVA = "0xB85580", Offset = "0xB84380", Length = "0x3F")]
	public void SetValue(bool value, bool instant = true)
	{
	}

	[Token(Token = "0x6003CE1")]
	[Address(RVA = "0xB855C0", Offset = "0xB843C0", Length = "0xA8")]
	private void Update()
	{
	}

	[Token(Token = "0x6003CE2")]
	[Address(RVA = "0xB85670", Offset = "0xB84470", Length = "0x36E")]
	private void UpdateTween(float t)
	{
	}

	[Token(Token = "0x6003CE3")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public ToggleButton()
	{
	}
}
