using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

namespace Rewired.Demos;

[AddComponentMenu(null)]
[Token(Token = "0x2000C56")]
public class SimpleCombinedKeyboardMouseRemapping : MonoBehaviour
{
	[Token(Token = "0x2000C57")]
	private class Row
	{
		[Token(Token = "0x4007D2E")]
		[FieldOffset(Offset = "0x10")]
		public InputAction action;

		[Token(Token = "0x4007D2F")]
		[FieldOffset(Offset = "0x18")]
		public AxisRange actionRange;

		[Token(Token = "0x4007D30")]
		[FieldOffset(Offset = "0x20")]
		public Button button;

		[Token(Token = "0x4007D31")]
		[FieldOffset(Offset = "0x28")]
		public Text text;

		[Token(Token = "0x60063EA")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public Row()
		{
		}
	}

	[Token(Token = "0x2000C58")]
	private struct TargetMapping
	{
		[Token(Token = "0x4007D32")]
		[FieldOffset(Offset = "0x0")]
		public ControllerMap controllerMap;

		[Token(Token = "0x4007D33")]
		[FieldOffset(Offset = "0x8")]
		public int actionElementMapId;
	}

	[CompilerGenerated]
	[Token(Token = "0x2000C5A")]
	private sealed class _003CStartListeningDelayed_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4007D37")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4007D38")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4007D39")]
		[FieldOffset(Offset = "0x20")]
		public SimpleCombinedKeyboardMouseRemapping _003C_003E4__this;

		[Token(Token = "0x4007D3A")]
		[FieldOffset(Offset = "0x28")]
		public int index;

		[Token(Token = "0x4007D3B")]
		[FieldOffset(Offset = "0x30")]
		public ControllerMap keyboardMap;

		[Token(Token = "0x4007D3C")]
		[FieldOffset(Offset = "0x38")]
		public int actionElementMapToReplaceId;

		[Token(Token = "0x4007D3D")]
		[FieldOffset(Offset = "0x40")]
		public ControllerMap mouseMap;

		[Token(Token = "0x170006B0")]
		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			[Token(Token = "0x60063F0")]
			[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170006B1")]
		object IEnumerator.Current
		{
			[DebuggerHidden]
			[Token(Token = "0x60063F2")]
			[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		[Token(Token = "0x60063ED")]
		[Address(RVA = "0x4096E0", Offset = "0x4084E0", Length = "0x4")]
		public _003CStartListeningDelayed_003Ed__22(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[Token(Token = "0x60063EE")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		void IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60063EF")]
		[Address(RVA = "0xFDB6F0", Offset = "0xFDA4F0", Length = "0x429")]
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
		[Token(Token = "0x60063F1")]
		[Address(RVA = "0xFDBB20", Offset = "0xFDA920", Length = "0x3E")]
		void IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4007D21")]
	private const string category = "Default";

	[Token(Token = "0x4007D22")]
	private const string layout = "Default";

	[Token(Token = "0x4007D23")]
	private const string uiCategory = "UI";

	[Token(Token = "0x4007D24")]
	[FieldOffset(Offset = "0x20")]
	private InputMapper inputMapper_keyboard;

	[Token(Token = "0x4007D25")]
	[FieldOffset(Offset = "0x28")]
	private InputMapper inputMapper_mouse;

	[Token(Token = "0x4007D26")]
	[FieldOffset(Offset = "0x30")]
	public GameObject buttonPrefab;

	[Token(Token = "0x4007D27")]
	[FieldOffset(Offset = "0x38")]
	public GameObject textPrefab;

	[Token(Token = "0x4007D28")]
	[FieldOffset(Offset = "0x40")]
	public RectTransform fieldGroupTransform;

	[Token(Token = "0x4007D29")]
	[FieldOffset(Offset = "0x48")]
	public RectTransform actionGroupTransform;

	[Token(Token = "0x4007D2A")]
	[FieldOffset(Offset = "0x50")]
	public Text controllerNameUIText;

	[Token(Token = "0x4007D2B")]
	[FieldOffset(Offset = "0x58")]
	public Text statusUIText;

	[Token(Token = "0x4007D2C")]
	[FieldOffset(Offset = "0x60")]
	private List<Row> rows;

	[Token(Token = "0x4007D2D")]
	[FieldOffset(Offset = "0x68")]
	private TargetMapping _replaceTargetMapping;

	[Token(Token = "0x170006AF")]
	private Player player
	{
		[Token(Token = "0x60063DE")]
		[Address(RVA = "0xFD93B0", Offset = "0xFD81B0", Length = "0x5C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60063DF")]
	[Address(RVA = "0xFD9410", Offset = "0xFD8210", Length = "0x2BA")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60063E0")]
	[Address(RVA = "0xFD96D0", Offset = "0xFD84D0", Length = "0xD9")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60063E1")]
	[Address(RVA = "0xFD97B0", Offset = "0xFD85B0", Length = "0x4DD")]
	private void RedrawUI()
	{
	}

	[Token(Token = "0x60063E2")]
	[Address(RVA = "0xFD9C90", Offset = "0xFD8A90", Length = "0x105")]
	private void ClearUI()
	{
	}

	[Token(Token = "0x60063E3")]
	[Address(RVA = "0xFD9DA0", Offset = "0xFD8BA0", Length = "0xB70")]
	private void InitializeUI()
	{
	}

	[Token(Token = "0x60063E4")]
	[Address(RVA = "0xFDA920", Offset = "0xFD9720", Length = "0x44D")]
	private void CreateUIRow(InputAction action, AxisRange actionRange, string label)
	{
	}

	[Token(Token = "0x60063E5")]
	[Address(RVA = "0xFDAD70", Offset = "0xFD9B70", Length = "0x35D")]
	private void OnInputFieldClicked(int index, int actionElementMapToReplaceId)
	{
	}

	[IteratorStateMachine(typeof(_003CStartListeningDelayed_003Ed__22))]
	[Token(Token = "0x60063E6")]
	[Address(RVA = "0xFDB0D0", Offset = "0xFD9ED0", Length = "0x169")]
	private IEnumerator StartListeningDelayed(int index, ControllerMap keyboardMap, ControllerMap mouseMap, int actionElementMapToReplaceId)
	{
		return null;
	}

	[Token(Token = "0x60063E7")]
	[Address(RVA = "0xFDB240", Offset = "0xFDA040", Length = "0x104")]
	private void OnInputMapped(InputMapper.InputMappedEventData data)
	{
	}

	[Token(Token = "0x60063E8")]
	[Address(RVA = "0xFDB350", Offset = "0xFDA150", Length = "0xDA")]
	private void OnStopped(InputMapper.StoppedEventData data)
	{
	}

	[Token(Token = "0x60063E9")]
	[Address(RVA = "0xFDB430", Offset = "0xFDA230", Length = "0x282")]
	public SimpleCombinedKeyboardMouseRemapping()
	{
	}
}
