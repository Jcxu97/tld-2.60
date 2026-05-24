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

[Name("ActionList", 0)]
[Description("Execute an ActionList Task for the Dialogue Actor selected.")]
[Token(Token = "0x20010DA")]
public class ActionListNode : DTNode
{
	[CompilerGenerated]
	[Token(Token = "0x20010DB")]
	private sealed class _003CUpdateAction_003Ed__2 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4008697")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4008698")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4008699")]
		[FieldOffset(Offset = "0x20")]
		public ActionListNode _003C_003E4__this;

		[Token(Token = "0x400869A")]
		[FieldOffset(Offset = "0x28")]
		public Component actionAgent;

		[Token(Token = "0x1700087A")]
		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			[Token(Token = "0x600727C")]
			[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700087B")]
		object IEnumerator.Current
		{
			[DebuggerHidden]
			[Token(Token = "0x600727E")]
			[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		[Token(Token = "0x6007279")]
		[Address(RVA = "0x4096E0", Offset = "0x4084E0", Length = "0x4")]
		public _003CUpdateAction_003Ed__2(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[Token(Token = "0x600727A")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		void IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600727B")]
		[Address(RVA = "0x10E0780", Offset = "0x10DF580", Length = "0x18F")]
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
		[Token(Token = "0x600727D")]
		[Address(RVA = "0x10E0910", Offset = "0x10DF710", Length = "0x3E")]
		void IEnumerator.Reset()
		{
		}
	}

	[SerializeField]
	[Token(Token = "0x4008696")]
	[FieldOffset(Offset = "0x88")]
	public List<ActionTask> actions;

	[Token(Token = "0x6007272")]
	[Address(RVA = "0x10E00A0", Offset = "0x10DEEA0", Length = "0x1AA")]
	protected override Status OnExecute(Component agent, IBlackboard bb)
	{
		return default(Status);
	}

	[IteratorStateMachine(typeof(_003CUpdateAction_003Ed__2))]
	[Token(Token = "0x6007273")]
	[Address(RVA = "0x10E0250", Offset = "0x10DF050", Length = "0xF7")]
	private IEnumerator UpdateAction(Component actionAgent)
	{
		return null;
	}

	[Token(Token = "0x6007274")]
	[Address(RVA = "0x10E0350", Offset = "0x10DF150", Length = "0x55")]
	private void OnActionEnd(bool success)
	{
	}

	[Token(Token = "0x6007275")]
	[Address(RVA = "0x10E03B0", Offset = "0x10DF1B0", Length = "0xCD")]
	protected override void OnReset()
	{
	}

	[Token(Token = "0x6007276")]
	[Address(RVA = "0x10E0480", Offset = "0x10DF280", Length = "0x138")]
	public override void OnGraphPaused()
	{
	}

	[Token(Token = "0x6007277")]
	[Address(RVA = "0x10E05C0", Offset = "0x10DF3C0", Length = "0xE0")]
	private void AddAction(ActionTask action)
	{
	}

	[Token(Token = "0x6007278")]
	[Address(RVA = "0x10E06B0", Offset = "0x10DF4B0", Length = "0xC5")]
	public ActionListNode()
	{
	}
}
