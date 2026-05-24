using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Name("Control Graph Owner", 0)]
[Category("✫ Utility")]
[Description("Start, Resume, Pause, Stop a GraphOwner's behaviour")]
[Token(Token = "0x2001306")]
public class GraphOwnerControl : ActionTask<GraphOwner>
{
	[Token(Token = "0x2001307")]
	public enum Control
	{
		[Token(Token = "0x4008CC2")]
		StartBehaviour,
		[Token(Token = "0x4008CC3")]
		StopBehaviour,
		[Token(Token = "0x4008CC4")]
		PauseBehaviour
	}

	[CompilerGenerated]
	[Token(Token = "0x2001308")]
	private sealed class _003CYieldDo_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4008CC5")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4008CC6")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4008CC7")]
		[FieldOffset(Offset = "0x20")]
		public GraphOwnerControl _003C_003E4__this;

		[Token(Token = "0x17000A25")]
		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			[Token(Token = "0x6007A24")]
			[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A26")]
		object IEnumerator.Current
		{
			[DebuggerHidden]
			[Token(Token = "0x6007A26")]
			[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		[Token(Token = "0x6007A21")]
		[Address(RVA = "0x4096E0", Offset = "0x4084E0", Length = "0x4")]
		public _003CYieldDo_003Ed__6(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[Token(Token = "0x6007A22")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		void IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6007A23")]
		[Address(RVA = "0x118E820", Offset = "0x118D620", Length = "0x95")]
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
		[Token(Token = "0x6007A25")]
		[Address(RVA = "0x118E8C0", Offset = "0x118D6C0", Length = "0x3E")]
		void IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4008CBF")]
	[FieldOffset(Offset = "0x68")]
	public Control control;

	[Token(Token = "0x4008CC0")]
	[FieldOffset(Offset = "0x6C")]
	public bool waitActionFinish;

	[Token(Token = "0x17000A24")]
	protected override string info
	{
		[Token(Token = "0x6007A1A")]
		[Address(RVA = "0x118E150", Offset = "0x118CF50", Length = "0xCF")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007A1B")]
	[Address(RVA = "0x118E220", Offset = "0x118D020", Length = "0x33C")]
	protected override void OnExecute()
	{
	}

	[IteratorStateMachine(typeof(_003CYieldDo_003Ed__6))]
	[Token(Token = "0x6007A1C")]
	[Address(RVA = "0x118E560", Offset = "0x118D360", Length = "0x9A")]
	private IEnumerator YieldDo()
	{
		return null;
	}

	[Token(Token = "0x6007A1D")]
	[Address(RVA = "0x118E600", Offset = "0x118D400", Length = "0x10E")]
	private void Do()
	{
	}

	[Token(Token = "0x6007A1E")]
	[Address(RVA = "0x118E710", Offset = "0x118D510", Length = "0xA1")]
	protected override void OnStop()
	{
	}

	[Token(Token = "0x6007A1F")]
	[Address(RVA = "0x118E7C0", Offset = "0x118D5C0", Length = "0x4C")]
	public GraphOwnerControl()
	{
	}
}
