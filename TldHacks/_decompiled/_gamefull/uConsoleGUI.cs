using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x2000A99")]
public class uConsoleGUI : MonoBehaviour
{
	[CompilerGenerated]
	[Token(Token = "0x2000A9A")]
	private sealed class _003CMoveTextEnd_NextFrame_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400684F")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4006850")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4006851")]
		[FieldOffset(Offset = "0x20")]
		public uConsoleGUI _003C_003E4__this;

		[Token(Token = "0x170003B6")]
		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			[Token(Token = "0x6005C1D")]
			[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170003B7")]
		object IEnumerator.Current
		{
			[DebuggerHidden]
			[Token(Token = "0x6005C1F")]
			[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		[Token(Token = "0x6005C1A")]
		[Address(RVA = "0x4096E0", Offset = "0x4084E0", Length = "0x4")]
		public _003CMoveTextEnd_NextFrame_003Ed__16(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[Token(Token = "0x6005C1B")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		void IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6005C1C")]
		[Address(RVA = "0xF38160", Offset = "0xF36F60", Length = "0x16E")]
		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		[Token(Token = "0x6005C1E")]
		[Address(RVA = "0xF382D0", Offset = "0xF370D0", Length = "0x3E")]
		void IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4006847")]
	[FieldOffset(Offset = "0x20")]
	public GameObject m_ConsoleEventSystem;

	[Token(Token = "0x4006848")]
	[FieldOffset(Offset = "0x28")]
	public RectTransform m_PanelRectTransform;

	[Token(Token = "0x4006849")]
	[FieldOffset(Offset = "0x30")]
	public Image m_PanelImage;

	[Token(Token = "0x400684A")]
	[FieldOffset(Offset = "0x38")]
	public Text m_LogText;

	[Token(Token = "0x400684B")]
	[FieldOffset(Offset = "0x40")]
	public InputField m_InputField;

	[Token(Token = "0x400684C")]
	[FieldOffset(Offset = "0x48")]
	public Text m_InputFieldText;

	[Token(Token = "0x400684D")]
	[FieldOffset(Offset = "0x50")]
	private RectTransform m_InputFieldRectTransform;

	[Token(Token = "0x400684E")]
	[FieldOffset(Offset = "0x58")]
	private int m_LogScrollOffset;

	[Token(Token = "0x6005C03")]
	[Address(RVA = "0xF36730", Offset = "0xF35530", Length = "0x16C")]
	private void Start()
	{
	}

	[Token(Token = "0x6005C04")]
	[Address(RVA = "0xF368A0", Offset = "0xF356A0", Length = "0x109")]
	private void Update()
	{
	}

	[Token(Token = "0x6005C05")]
	[Address(RVA = "0xF369B0", Offset = "0xF357B0", Length = "0x87")]
	public void ScrollLogUp()
	{
	}

	[Token(Token = "0x6005C06")]
	[Address(RVA = "0xF36A40", Offset = "0xF35840", Length = "0x17")]
	public void ScrollLogDown()
	{
	}

	[Token(Token = "0x6005C07")]
	[Address(RVA = "0xF36A60", Offset = "0xF35860", Length = "0x58")]
	public void ScrollLogUpMax()
	{
	}

	[Token(Token = "0x6005C08")]
	[Address(RVA = "0xF36AC0", Offset = "0xF358C0", Length = "0xE")]
	public void ScrollLogDownMax()
	{
	}

	[Token(Token = "0x6005C09")]
	[Address(RVA = "0xF36AD0", Offset = "0xF358D0", Length = "0x2E3")]
	public void RefreshLogText()
	{
	}

	[Token(Token = "0x6005C0A")]
	[Address(RVA = "0xF36DC0", Offset = "0xF35BC0", Length = "0xEF")]
	public void InputFieldSetFocus()
	{
	}

	[IteratorStateMachine(typeof(_003CMoveTextEnd_NextFrame_003Ed__16))]
	[Token(Token = "0x6005C0B")]
	[Address(RVA = "0xF36EB0", Offset = "0xF35CB0", Length = "0x9A")]
	private IEnumerator MoveTextEnd_NextFrame()
	{
		return null;
	}

	[Token(Token = "0x6005C0C")]
	[Address(RVA = "0xF36F50", Offset = "0xF35D50", Length = "0x1E")]
	public string InputFieldGetText()
	{
		return null;
	}

	[Token(Token = "0x6005C0D")]
	[Address(RVA = "0xF36F70", Offset = "0xF35D70", Length = "0xEC")]
	public void InputFieldClearText()
	{
	}

	[Token(Token = "0x6005C0E")]
	[Address(RVA = "0xF37060", Offset = "0xF35E60", Length = "0x21")]
	public void InputFieldSetText(string text)
	{
	}

	[Token(Token = "0x6005C0F")]
	[Address(RVA = "0xF37090", Offset = "0xF35E90", Length = "0x20")]
	public void InputFieldMoveCaretToEnd()
	{
	}

	[Token(Token = "0x6005C10")]
	[Address(RVA = "0xF370C0", Offset = "0xF35EC0", Length = "0x1D")]
	public void InputFieldDeactivate()
	{
	}

	[Token(Token = "0x6005C11")]
	[Address(RVA = "0xF370E0", Offset = "0xF35EE0", Length = "0x520")]
	private void Animate(float deltaTimeSeconds)
	{
	}

	[Token(Token = "0x6005C12")]
	[Address(RVA = "0xF37610", Offset = "0xF36410", Length = "0xF2")]
	private float CalculatePixelsMovedForAnimation(float deltaSeconds, float fullAnimateSeconds)
	{
		return 0f;
	}

	[Token(Token = "0x6005C13")]
	[Address(RVA = "0xF37710", Offset = "0xF36510", Length = "0x45F")]
	private void UpdateUIDimensions()
	{
	}

	[Token(Token = "0x6005C14")]
	[Address(RVA = "0xF37B70", Offset = "0xF36970", Length = "0x73")]
	private float GetInputFieldHeightInPixels()
	{
		return 0f;
	}

	[Token(Token = "0x6005C15")]
	[Address(RVA = "0xF37BF0", Offset = "0xF369F0", Length = "0x2AC")]
	private void UpdateUIWithCustomizationSettings()
	{
	}

	[Token(Token = "0x6005C16")]
	[Address(RVA = "0xF37EA0", Offset = "0xF36CA0", Length = "0x6")]
	private int ComputeMaxDisplayLinesForLog()
	{
		return 0;
	}

	[Token(Token = "0x6005C17")]
	[Address(RVA = "0xF37EB0", Offset = "0xF36CB0", Length = "0x1FB")]
	private void MaybeInstantiateEventSystem()
	{
	}

	[Token(Token = "0x6005C18")]
	[Address(RVA = "0xF380B0", Offset = "0xF36EB0", Length = "0xA9")]
	private void MaybeDeactivateInputField()
	{
	}

	[Token(Token = "0x6005C19")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public uConsoleGUI()
	{
	}
}
