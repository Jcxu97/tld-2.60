using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20005CD")]
public class ConsoleSlider : MonoBehaviour
{
	[Token(Token = "0x4003585")]
	[FieldOffset(Offset = "0x20")]
	public GameObject m_Background;

	[Token(Token = "0x4003586")]
	[FieldOffset(Offset = "0x28")]
	public GameObject m_SliderObject;

	[Token(Token = "0x4003587")]
	[FieldOffset(Offset = "0x30")]
	public UILabel m_LableName;

	[Token(Token = "0x4003588")]
	[FieldOffset(Offset = "0x38")]
	public LocalizedString m_LocalizedToolTip;

	[Token(Token = "0x4003589")]
	[FieldOffset(Offset = "0x40")]
	public List<EventDelegate> onChange;

	[HideInInspector]
	[Token(Token = "0x400358A")]
	[FieldOffset(Offset = "0x48")]
	public UISlider m_Slider;

	[Token(Token = "0x170002D4")]
	public string m_ToolTip
	{
		[Token(Token = "0x6002CF9")]
		[Address(RVA = "0x74FFD0", Offset = "0x74EDD0", Length = "0x5D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002D5")]
	public float value
	{
		[Token(Token = "0x6002CFC")]
		[Address(RVA = "0x93E740", Offset = "0x93D540", Length = "0x4F")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6002CFD")]
		[Address(RVA = "0x93E790", Offset = "0x93D590", Length = "0x1E")]
		set
		{
		}
	}

	[Token(Token = "0x6002CFA")]
	[Address(RVA = "0x93E510", Offset = "0x93D310", Length = "0x173")]
	public void Start()
	{
	}

	[Token(Token = "0x6002CFB")]
	[Address(RVA = "0x93E690", Offset = "0x93D490", Length = "0xB0")]
	public void OnDragFinished()
	{
	}

	[Token(Token = "0x6002CFE")]
	[Address(RVA = "0x93E7B0", Offset = "0x93D5B0", Length = "0x1C6")]
	public void OnValueChanged()
	{
	}

	[Token(Token = "0x6002CFF")]
	[Address(RVA = "0x93E980", Offset = "0x93D780", Length = "0x178")]
	public void OnIncrease()
	{
	}

	[Token(Token = "0x6002D00")]
	[Address(RVA = "0x93EB00", Offset = "0x93D900", Length = "0x178")]
	public void OnDecrease()
	{
	}

	[Token(Token = "0x6002D01")]
	[Address(RVA = "0x93EC80", Offset = "0x93DA80", Length = "0xE3")]
	public ConsoleSlider()
	{
	}
}
