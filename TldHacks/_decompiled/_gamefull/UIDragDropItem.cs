using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

[AddComponentMenu("NGUI/Interaction/Drag and Drop Item")]
[Token(Token = "0x2000070")]
public class UIDragDropItem : MonoBehaviour
{
	[Token(Token = "0x2000071")]
	public enum Restriction
	{
		[Token(Token = "0x40003FA")]
		None,
		[Token(Token = "0x40003FB")]
		Horizontal,
		[Token(Token = "0x40003FC")]
		Vertical,
		[Token(Token = "0x40003FD")]
		PressAndHold
	}

	[CompilerGenerated]
	[Token(Token = "0x2000072")]
	private sealed class _003CEnableDragScrollView_003Ed__32 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40003FE")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40003FF")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000400")]
		[FieldOffset(Offset = "0x20")]
		public UIDragDropItem _003C_003E4__this;

		[Token(Token = "0x17000039")]
		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			[Token(Token = "0x600040E")]
			[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003A")]
		object IEnumerator.Current
		{
			[DebuggerHidden]
			[Token(Token = "0x6000410")]
			[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		[Token(Token = "0x600040B")]
		[Address(RVA = "0x4096E0", Offset = "0x4084E0", Length = "0x4")]
		public _003CEnableDragScrollView_003Ed__32(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[Token(Token = "0x600040C")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		void IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600040D")]
		[Address(RVA = "0xA302D0", Offset = "0xA2F0D0", Length = "0x18A")]
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
		[Token(Token = "0x600040F")]
		[Address(RVA = "0xA30460", Offset = "0xA2F260", Length = "0x3E")]
		void IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40003E6")]
	[FieldOffset(Offset = "0x20")]
	public Restriction restriction;

	[Token(Token = "0x40003E7")]
	[FieldOffset(Offset = "0x24")]
	public bool cloneOnDrag;

	[HideInInspector]
	[Token(Token = "0x40003E8")]
	[FieldOffset(Offset = "0x28")]
	public float pressAndHoldDelay;

	[Token(Token = "0x40003E9")]
	[FieldOffset(Offset = "0x2C")]
	public bool interactable;

	[Token(Token = "0x40003EA")]
	[FieldOffset(Offset = "0x30")]
	public Action m_OnPositionChanged;

	[Token(Token = "0x40003EB")]
	[FieldOffset(Offset = "0x38")]
	public Action m_OnPressed;

	[NonSerialized]
	[Token(Token = "0x40003EC")]
	[FieldOffset(Offset = "0x40")]
	protected Transform mTrans;

	[NonSerialized]
	[Token(Token = "0x40003ED")]
	[FieldOffset(Offset = "0x48")]
	protected Transform mParent;

	[NonSerialized]
	[Token(Token = "0x40003EE")]
	[FieldOffset(Offset = "0x50")]
	protected Collider mCollider;

	[NonSerialized]
	[Token(Token = "0x40003EF")]
	[FieldOffset(Offset = "0x58")]
	protected Collider2D mCollider2D;

	[NonSerialized]
	[Token(Token = "0x40003F0")]
	[FieldOffset(Offset = "0x60")]
	protected UIButton mButton;

	[NonSerialized]
	[Token(Token = "0x40003F1")]
	[FieldOffset(Offset = "0x68")]
	protected UIRoot mRoot;

	[NonSerialized]
	[Token(Token = "0x40003F2")]
	[FieldOffset(Offset = "0x70")]
	protected UIGrid mGrid;

	[NonSerialized]
	[Token(Token = "0x40003F3")]
	[FieldOffset(Offset = "0x78")]
	protected UITable mTable;

	[NonSerialized]
	[Token(Token = "0x40003F4")]
	[FieldOffset(Offset = "0x80")]
	protected float mDragStartTime;

	[NonSerialized]
	[Token(Token = "0x40003F5")]
	[FieldOffset(Offset = "0x88")]
	protected UIDragScrollView mDragScrollView;

	[NonSerialized]
	[Token(Token = "0x40003F6")]
	[FieldOffset(Offset = "0x90")]
	protected bool mPressed;

	[NonSerialized]
	[Token(Token = "0x40003F7")]
	[FieldOffset(Offset = "0x91")]
	protected bool mDragging;

	[NonSerialized]
	[Token(Token = "0x40003F8")]
	[FieldOffset(Offset = "0x98")]
	protected UICamera.MouseOrTouch mTouch;

	[Token(Token = "0x60003FD")]
	[Address(RVA = "0xA2D940", Offset = "0xA2C740", Length = "0x27E")]
	protected virtual void Start()
	{
	}

	[Token(Token = "0x60003FE")]
	[Address(RVA = "0xA2DBC0", Offset = "0xA2C9C0", Length = "0x1AA")]
	protected virtual void OnPress(bool isPressed)
	{
	}

	[Token(Token = "0x60003FF")]
	[Address(RVA = "0xA2DD70", Offset = "0xA2CB70", Length = "0x5E")]
	protected virtual void Update()
	{
	}

	[Token(Token = "0x6000400")]
	[Address(RVA = "0xA2DDD0", Offset = "0xA2CBD0", Length = "0x112")]
	protected virtual void OnDragStart()
	{
	}

	[Token(Token = "0x6000401")]
	[Address(RVA = "0xA2DEF0", Offset = "0xA2CCF0", Length = "0xA72")]
	protected virtual void StartDragging()
	{
	}

	[Token(Token = "0x6000402")]
	[Address(RVA = "0xA2E970", Offset = "0xA2D770", Length = "0xEB")]
	protected virtual void OnDrag(Vector2 delta)
	{
	}

	[Token(Token = "0x6000403")]
	[Address(RVA = "0xA2EA60", Offset = "0xA2D860", Length = "0xBF")]
	protected virtual void OnDragEnd()
	{
	}

	[Token(Token = "0x6000404")]
	[Address(RVA = "0xA2EB20", Offset = "0xA2D920", Length = "0x22")]
	public void StopDragging(GameObject go)
	{
	}

	[Token(Token = "0x6000405")]
	[Address(RVA = "0xA2EB50", Offset = "0xA2D950", Length = "0xA34")]
	protected virtual void OnDragDropStart()
	{
	}

	[Token(Token = "0x6000406")]
	[Address(RVA = "0xA2F590", Offset = "0xA2E390", Length = "0x229")]
	protected virtual void OnDragDropMove(Vector2 delta)
	{
	}

	[Token(Token = "0x6000407")]
	[Address(RVA = "0xA2F7C0", Offset = "0xA2E5C0", Length = "0xA6F")]
	protected virtual void OnDragDropRelease(GameObject surface)
	{
	}

	[Token(Token = "0x6000408")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	protected virtual void OnDragDropEnd()
	{
	}

	[IteratorStateMachine(typeof(_003CEnableDragScrollView_003Ed__32))]
	[Token(Token = "0x6000409")]
	[Address(RVA = "0xA30230", Offset = "0xA2F030", Length = "0x9A")]
	protected IEnumerator EnableDragScrollView()
	{
		return null;
	}

	[Token(Token = "0x600040A")]
	[Address(RVA = "0xA1D6B0", Offset = "0xA1C4B0", Length = "0x4E")]
	public UIDragDropItem()
	{
	}
}
