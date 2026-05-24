using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

[CreateAssetMenu(fileName = "PopupDefinition", menuName = "Interface/PopupDefinition", order = 10003)]
[Token(Token = "0x20006E1")]
public class PopupDefinition : ScriptableObject
{
	[CompilerGenerated]
	[Token(Token = "0x20006E2")]
	private sealed class _003CDisplayPopup_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400495F")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4004960")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4004961")]
		[FieldOffset(Offset = "0x20")]
		public float duration;

		[Token(Token = "0x4004962")]
		[FieldOffset(Offset = "0x28")]
		public GameObject go;

		[Token(Token = "0x4004963")]
		[FieldOffset(Offset = "0x30")]
		public PopupDefinition _003C_003E4__this;

		[Token(Token = "0x1700030F")]
		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			[Token(Token = "0x6003CAC")]
			[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000310")]
		object IEnumerator.Current
		{
			[DebuggerHidden]
			[Token(Token = "0x6003CAE")]
			[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		[Token(Token = "0x6003CA9")]
		[Address(RVA = "0x4096E0", Offset = "0x4084E0", Length = "0x4")]
		public _003CDisplayPopup_003Ed__7(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[Token(Token = "0x6003CAA")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		void IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6003CAB")]
		[Address(RVA = "0xB82D20", Offset = "0xB81B20", Length = "0x205")]
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
		[Token(Token = "0x6003CAD")]
		[Address(RVA = "0xB82F30", Offset = "0xB81D30", Length = "0x3E")]
		void IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400495B")]
	[FieldOffset(Offset = "0x18")]
	public UIPanel m_PanelPrefab;

	[Token(Token = "0x400495C")]
	[FieldOffset(Offset = "0x20")]
	public float m_DurationSeconds;

	[Token(Token = "0x400495D")]
	[FieldOffset(Offset = "0x28")]
	public string m_AudioEvent;

	[Token(Token = "0x400495E")]
	[FieldOffset(Offset = "0x30")]
	private Action m_OnPopupEndAction;

	[Token(Token = "0x6003CA4")]
	[Address(RVA = "0xB827D0", Offset = "0xB815D0", Length = "0x388")]
	public void Show(Action onPopupEndAction)
	{
	}

	[Token(Token = "0x6003CA5")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	protected virtual void ConfigurePopup(GameObject go)
	{
	}

	[Token(Token = "0x6003CA6")]
	[Address(RVA = "0xB82B60", Offset = "0xB81960", Length = "0x9C")]
	private void PlayAudio()
	{
	}

	[IteratorStateMachine(typeof(_003CDisplayPopup_003Ed__7))]
	[Token(Token = "0x6003CA7")]
	[Address(RVA = "0xB82C00", Offset = "0xB81A00", Length = "0x114")]
	private IEnumerator DisplayPopup(GameObject go, float duration)
	{
		return null;
	}

	[Token(Token = "0x6003CA8")]
	[Address(RVA = "0x4A22A0", Offset = "0x4A10A0", Length = "0x7")]
	public PopupDefinition()
	{
	}
}
