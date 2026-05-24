using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.DialogueTrees;

[Icon("Action", false, null)]
[Name("Task Action", 0)]
[Description("Execute an Action Task for the Dialogue Actor selected.")]
[Token(Token = "0x20010F9")]
public class ActionNode : DTNode, ITaskAssignable<ActionTask>, ITaskAssignable
{
	[CompilerGenerated]
	[Token(Token = "0x20010FA")]
	private sealed class _003CUpdateAction_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40086F6")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40086F7")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40086F8")]
		[FieldOffset(Offset = "0x20")]
		public ActionNode _003C_003E4__this;

		[Token(Token = "0x40086F9")]
		[FieldOffset(Offset = "0x28")]
		public Component actionAgent;

		[Token(Token = "0x170008B7")]
		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			[Token(Token = "0x600732A")]
			[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170008B8")]
		object IEnumerator.Current
		{
			[DebuggerHidden]
			[Token(Token = "0x600732C")]
			[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		[Token(Token = "0x6007327")]
		[Address(RVA = "0x4096E0", Offset = "0x4084E0", Length = "0x4")]
		public _003CUpdateAction_003Ed__10(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[Token(Token = "0x6007328")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		void IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6007329")]
		[Address(RVA = "0x10E8F90", Offset = "0x10E7D90", Length = "0x12C")]
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
		[Token(Token = "0x600732B")]
		[Address(RVA = "0x10E90C0", Offset = "0x10E7EC0", Length = "0x3E")]
		void IEnumerator.Reset()
		{
		}
	}

	[SerializeField]
	[Token(Token = "0x40086F5")]
	[FieldOffset(Offset = "0x88")]
	private ActionTask _action;

	[Token(Token = "0x170008B4")]
	public ActionTask action
	{
		[Token(Token = "0x600731C")]
		[Address(RVA = "0x4C0240", Offset = "0x4BF040", Length = "0x8")]
		get
		{
			return null;
		}
		[Token(Token = "0x600731D")]
		[Address(RVA = "0xB69600", Offset = "0xB68400", Length = "0x52")]
		set
		{
		}
	}

	[Token(Token = "0x170008B5")]
	public Task task
	{
		[Token(Token = "0x600731E")]
		[Address(RVA = "0x4C0240", Offset = "0x4BF040", Length = "0x8")]
		get
		{
			return null;
		}
		[Token(Token = "0x600731F")]
		[Address(RVA = "0x10E8BF0", Offset = "0x10E79F0", Length = "0xC4")]
		set
		{
		}
	}

	[Token(Token = "0x170008B6")]
	public override bool requireActorSelection
	{
		[Token(Token = "0x6007320")]
		[Address(RVA = "0x430B50", Offset = "0x42F950", Length = "0x3")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x6007321")]
	[Address(RVA = "0x10E8CC0", Offset = "0x10E7AC0", Length = "0x18A")]
	protected override Status OnExecute(Component agent, IBlackboard bb)
	{
		return default(Status);
	}

	[IteratorStateMachine(typeof(_003CUpdateAction_003Ed__10))]
	[Token(Token = "0x6007322")]
	[Address(RVA = "0x10E8E50", Offset = "0x10E7C50", Length = "0xF7")]
	private IEnumerator UpdateAction(Component actionAgent)
	{
		return null;
	}

	[Token(Token = "0x6007323")]
	[Address(RVA = "0x10E0350", Offset = "0x10DF150", Length = "0x55")]
	private void OnActionEnd(bool success)
	{
	}

	[Token(Token = "0x6007324")]
	[Address(RVA = "0x10E8F50", Offset = "0x10E7D50", Length = "0x1A")]
	protected override void OnReset()
	{
	}

	[Token(Token = "0x6007325")]
	[Address(RVA = "0x10E8F70", Offset = "0x10E7D70", Length = "0x14")]
	public override void OnGraphPaused()
	{
	}

	[Token(Token = "0x6007326")]
	[Address(RVA = "0x10E0B40", Offset = "0x10DF940", Length = "0x7")]
	public ActionNode()
	{
	}
}
