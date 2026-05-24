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
[Token(Token = "0x2000C5B")]
public class SimpleControlRemapping : MonoBehaviour
{
	[Token(Token = "0x2000C5C")]
	private class Row
	{
		[Token(Token = "0x4007D4B")]
		[FieldOffset(Offset = "0x10")]
		public InputAction action;

		[Token(Token = "0x4007D4C")]
		[FieldOffset(Offset = "0x18")]
		public AxisRange actionRange;

		[Token(Token = "0x4007D4D")]
		[FieldOffset(Offset = "0x20")]
		public Button button;

		[Token(Token = "0x4007D4E")]
		[FieldOffset(Offset = "0x28")]
		public Text text;

		[Token(Token = "0x6006404")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public Row()
		{
		}
	}

	[CompilerGenerated]
	[Token(Token = "0x2000C5E")]
	private sealed class _003CStartListeningDelayed_003Ed__28 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4007D52")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4007D53")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4007D54")]
		[FieldOffset(Offset = "0x20")]
		public SimpleControlRemapping _003C_003E4__this;

		[Token(Token = "0x4007D55")]
		[FieldOffset(Offset = "0x28")]
		public int index;

		[Token(Token = "0x4007D56")]
		[FieldOffset(Offset = "0x2C")]
		public int actionElementMapToReplaceId;

		[Token(Token = "0x170006B5")]
		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			[Token(Token = "0x600640A")]
			[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170006B6")]
		object IEnumerator.Current
		{
			[DebuggerHidden]
			[Token(Token = "0x600640C")]
			[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		[Token(Token = "0x6006407")]
		[Address(RVA = "0x4096E0", Offset = "0x4084E0", Length = "0x4")]
		public _003CStartListeningDelayed_003Ed__28(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[Token(Token = "0x6006408")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		void IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6006409")]
		[Address(RVA = "0xFDDF40", Offset = "0xFDCD40", Length = "0x2F9")]
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
		[Token(Token = "0x600640B")]
		[Address(RVA = "0xFDE240", Offset = "0xFDD040", Length = "0x3E")]
		void IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4007D3E")]
	private const string category = "Default";

	[Token(Token = "0x4007D3F")]
	private const string layout = "Default";

	[Token(Token = "0x4007D40")]
	private const string uiCategory = "UI";

	[Token(Token = "0x4007D41")]
	[FieldOffset(Offset = "0x20")]
	private InputMapper inputMapper;

	[Token(Token = "0x4007D42")]
	[FieldOffset(Offset = "0x28")]
	public GameObject buttonPrefab;

	[Token(Token = "0x4007D43")]
	[FieldOffset(Offset = "0x30")]
	public GameObject textPrefab;

	[Token(Token = "0x4007D44")]
	[FieldOffset(Offset = "0x38")]
	public RectTransform fieldGroupTransform;

	[Token(Token = "0x4007D45")]
	[FieldOffset(Offset = "0x40")]
	public RectTransform actionGroupTransform;

	[Token(Token = "0x4007D46")]
	[FieldOffset(Offset = "0x48")]
	public Text controllerNameUIText;

	[Token(Token = "0x4007D47")]
	[FieldOffset(Offset = "0x50")]
	public Text statusUIText;

	[Token(Token = "0x4007D48")]
	[FieldOffset(Offset = "0x58")]
	private ControllerType selectedControllerType;

	[Token(Token = "0x4007D49")]
	[FieldOffset(Offset = "0x5C")]
	private int selectedControllerId;

	[Token(Token = "0x4007D4A")]
	[FieldOffset(Offset = "0x60")]
	private List<Row> rows;

	[Token(Token = "0x170006B2")]
	private Player player
	{
		[Token(Token = "0x60063F3")]
		[Address(RVA = "0xFDBB60", Offset = "0xFDA960", Length = "0x5C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170006B3")]
	private ControllerMap controllerMap
	{
		[Token(Token = "0x60063F4")]
		[Address(RVA = "0xFDBBC0", Offset = "0xFDA9C0", Length = "0x119")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170006B4")]
	private Controller controller
	{
		[Token(Token = "0x60063F5")]
		[Address(RVA = "0xFDBCE0", Offset = "0xFDAAE0", Length = "0x7F")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60063F6")]
	[Address(RVA = "0xFDBD60", Offset = "0xFDAB60", Length = "0x269")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60063F7")]
	[Address(RVA = "0xFDBFD0", Offset = "0xFDADD0", Length = "0x134")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60063F8")]
	[Address(RVA = "0xFDC110", Offset = "0xFDAF10", Length = "0x5B3")]
	private void RedrawUI()
	{
	}

	[Token(Token = "0x60063F9")]
	[Address(RVA = "0xFDC6D0", Offset = "0xFDB4D0", Length = "0x13D")]
	private void ClearUI()
	{
	}

	[Token(Token = "0x60063FA")]
	[Address(RVA = "0xFDC810", Offset = "0xFDB610", Length = "0xB70")]
	private void InitializeUI()
	{
	}

	[Token(Token = "0x60063FB")]
	[Address(RVA = "0xFDD390", Offset = "0xFDC190", Length = "0x44D")]
	private void CreateUIRow(InputAction action, AxisRange actionRange, string label)
	{
	}

	[Token(Token = "0x60063FC")]
	[Address(RVA = "0xFDD7E0", Offset = "0xFDC5E0", Length = "0x184")]
	private void SetSelectedController(ControllerType controllerType)
	{
	}

	[Token(Token = "0x60063FD")]
	[Address(RVA = "0xFDD970", Offset = "0xFDC770", Length = "0x8")]
	public void OnControllerSelected(int controllerType)
	{
	}

	[Token(Token = "0x60063FE")]
	[Address(RVA = "0xFDD980", Offset = "0xFDC780", Length = "0x11C")]
	private void OnInputFieldClicked(int index, int actionElementMapToReplaceId)
	{
	}

	[IteratorStateMachine(typeof(_003CStartListeningDelayed_003Ed__28))]
	[Token(Token = "0x60063FF")]
	[Address(RVA = "0xFDDAA0", Offset = "0xFDC8A0", Length = "0xBC")]
	private IEnumerator StartListeningDelayed(int index, int actionElementMapToReplaceId)
	{
		return null;
	}

	[Token(Token = "0x6006400")]
	[Address(RVA = "0xFDDB60", Offset = "0xFDC960", Length = "0xB")]
	private void OnControllerChanged(ControllerStatusChangedEventArgs args)
	{
	}

	[Token(Token = "0x6006401")]
	[Address(RVA = "0xFDDB70", Offset = "0xFDC970", Length = "0x7")]
	private void OnInputMapped(InputMapper.InputMappedEventData data)
	{
	}

	[Token(Token = "0x6006402")]
	[Address(RVA = "0xFDDB80", Offset = "0xFDC980", Length = "0xDA")]
	private void OnStopped(InputMapper.StoppedEventData data)
	{
	}

	[Token(Token = "0x6006403")]
	[Address(RVA = "0xFDDC60", Offset = "0xFDCA60", Length = "0x1BF")]
	public SimpleControlRemapping()
	{
	}
}
