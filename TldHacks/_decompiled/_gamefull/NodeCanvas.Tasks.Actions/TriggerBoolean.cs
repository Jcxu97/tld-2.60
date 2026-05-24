using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Category("✫ Blackboard")]
[Description("Triggers a boolean variable for 1 frame to True then back to False")]
[Token(Token = "0x20012B1")]
public class TriggerBoolean : ActionTask
{
	[CompilerGenerated]
	[Token(Token = "0x20012B2")]
	private sealed class _003CFlip_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4008BA7")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4008BA8")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4008BA9")]
		[FieldOffset(Offset = "0x20")]
		public TriggerBoolean _003C_003E4__this;

		[Token(Token = "0x170009DF")]
		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			[Token(Token = "0x60078E1")]
			[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009E0")]
		object IEnumerator.Current
		{
			[DebuggerHidden]
			[Token(Token = "0x60078E3")]
			[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		[Token(Token = "0x60078DE")]
		[Address(RVA = "0x4096E0", Offset = "0x4084E0", Length = "0x4")]
		public _003CFlip_003Ed__4(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[Token(Token = "0x60078DF")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		void IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60078E0")]
		[Address(RVA = "0x11738D0", Offset = "0x11726D0", Length = "0xBF")]
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
		[Token(Token = "0x60078E2")]
		[Address(RVA = "0x1173990", Offset = "0x1172790", Length = "0x3E")]
		void IEnumerator.Reset()
		{
		}
	}

	[RequiredField]
	[BlackboardOnly]
	[Token(Token = "0x4008BA6")]
	[FieldOffset(Offset = "0x68")]
	public BBParameter<bool> variable;

	[Token(Token = "0x170009DE")]
	protected override string info
	{
		[Token(Token = "0x60078DA")]
		[Address(RVA = "0x1173680", Offset = "0x1172480", Length = "0x84")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60078DB")]
	[Address(RVA = "0x1173710", Offset = "0x1172510", Length = "0x116")]
	protected override void OnExecute()
	{
	}

	[IteratorStateMachine(typeof(_003CFlip_003Ed__4))]
	[Token(Token = "0x60078DC")]
	[Address(RVA = "0x1173830", Offset = "0x1172630", Length = "0x9A")]
	private IEnumerator Flip()
	{
		return null;
	}

	[Token(Token = "0x60078DD")]
	[Address(RVA = "0xD769F0", Offset = "0xD757F0", Length = "0x8")]
	public TriggerBoolean()
	{
	}
}
