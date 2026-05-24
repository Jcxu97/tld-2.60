using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

namespace NodeCanvas.Framework;

[Token(Token = "0x2001073")]
public abstract class ConditionTask<T> : ConditionTask where T : class
{
	[Token(Token = "0x170007DE")]
	public sealed override Type agentType
	{
		[Token(Token = "0x6006FA2")]
		[Address(RVA = "0x1E7AEF0", Offset = "0x1E79CF0", Length = "0x63")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170007DF")]
	public new T agent
	{
		[Token(Token = "0x6006FA3")]
		[Address(RVA = "0x240BA10", Offset = "0x240A810", Length = "0x57")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6006FA4")]
	[Address(RVA = "0x10C6920", Offset = "0x10C5720", Length = "0x8")]
	protected ConditionTask()
	{
	}
}
[Token(Token = "0x2001074")]
public abstract class ConditionTask : Task
{
	[CompilerGenerated]
	[Token(Token = "0x2001075")]
	private sealed class _003CFlip_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400859D")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400859E")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400859F")]
		[FieldOffset(Offset = "0x20")]
		public ConditionTask _003C_003E4__this;

		[Token(Token = "0x170007E1")]
		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			[Token(Token = "0x6006FB3")]
			[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170007E2")]
		object IEnumerator.Current
		{
			[DebuggerHidden]
			[Token(Token = "0x6006FB5")]
			[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		[Token(Token = "0x6006FB0")]
		[Address(RVA = "0x4096E0", Offset = "0x4084E0", Length = "0x4")]
		public _003CFlip_003Ed__13(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[Token(Token = "0x6006FB1")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		void IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6006FB2")]
		[Address(RVA = "0x10C6930", Offset = "0x10C5730", Length = "0x1A8")]
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
		[Token(Token = "0x6006FB4")]
		[Address(RVA = "0x10C6AE0", Offset = "0x10C58E0", Length = "0x3E")]
		void IEnumerator.Reset()
		{
		}
	}

	[SerializeField]
	[Token(Token = "0x400859A")]
	[FieldOffset(Offset = "0x58")]
	private bool _invert;

	[NonSerialized]
	[Token(Token = "0x400859B")]
	[FieldOffset(Offset = "0x5C")]
	private int yieldReturn;

	[Token(Token = "0x400859C")]
	[FieldOffset(Offset = "0x60")]
	private int yields;

	[Token(Token = "0x170007E0")]
	public bool invert
	{
		[Token(Token = "0x6006FA5")]
		[Address(RVA = "0x67E850", Offset = "0x67D650", Length = "0x5")]
		get
		{
			return false;
		}
		[Token(Token = "0x6006FA6")]
		[Address(RVA = "0x10C66B0", Offset = "0x10C54B0", Length = "0x4")]
		set
		{
		}
	}

	[Token(Token = "0x6006FA7")]
	[Address(RVA = "0x10C66C0", Offset = "0x10C54C0", Length = "0x34")]
	public void Enable(Component agent, IBlackboard bb)
	{
	}

	[Token(Token = "0x6006FA8")]
	[Address(RVA = "0x10C6700", Offset = "0x10C5500", Length = "0x15")]
	public void Disable()
	{
	}

	[Token(Token = "0x6006FA9")]
	[Address(RVA = "0x10C6720", Offset = "0x10C5520", Length = "0x86")]
	public bool CheckCondition(Component agent, IBlackboard blackboard)
	{
		return false;
	}

	[Token(Token = "0x6006FAA")]
	[Address(RVA = "0x10C67B0", Offset = "0x10C55B0", Length = "0xCA")]
	protected void YieldReturn(bool value)
	{
	}

	[Token(Token = "0x6006FAB")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	protected virtual void OnEnable()
	{
	}

	[Token(Token = "0x6006FAC")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	protected virtual void OnDisable()
	{
	}

	[Token(Token = "0x6006FAD")]
	[Address(RVA = "0x430B50", Offset = "0x42F950", Length = "0x3")]
	protected virtual bool OnCheck()
	{
		return false;
	}

	[IteratorStateMachine(typeof(_003CFlip_003Ed__13))]
	[Token(Token = "0x6006FAE")]
	[Address(RVA = "0x10C6880", Offset = "0x10C5680", Length = "0x9A")]
	private IEnumerator Flip()
	{
		return null;
	}

	[Token(Token = "0x6006FAF")]
	[Address(RVA = "0x10C6920", Offset = "0x10C5720", Length = "0x8")]
	protected ConditionTask()
	{
	}
}
