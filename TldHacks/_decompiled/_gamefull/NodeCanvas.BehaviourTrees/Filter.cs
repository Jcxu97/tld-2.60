using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.BehaviourTrees;

[Name("Filter", 0)]
[Category("Decorators")]
[Description("Filters the access of it's child node either a specific number of times, or every specific amount of time. By default the node is 'Treated as Inactive' to it's parent when child is Filtered. Unchecking this option will instead return Failure when Filtered.")]
[Icon("Filter", false, null)]
[Token(Token = "0x200102F")]
public class Filter : BTDecorator
{
	[Token(Token = "0x2001030")]
	public enum FilterMode
	{
		[Token(Token = "0x40084CE")]
		LimitNumberOfTimes,
		[Token(Token = "0x40084CF")]
		CoolDown
	}

	[Token(Token = "0x2001031")]
	public enum Policy
	{
		[Token(Token = "0x40084D1")]
		SuccessOrFailure,
		[Token(Token = "0x40084D2")]
		SuccessOnly,
		[Token(Token = "0x40084D3")]
		FailureOnly
	}

	[CompilerGenerated]
	[Token(Token = "0x2001032")]
	private sealed class _003CCooldown_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40084D4")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40084D5")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40084D6")]
		[FieldOffset(Offset = "0x20")]
		public Filter _003C_003E4__this;

		[Token(Token = "0x17000779")]
		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			[Token(Token = "0x6006DD4")]
			[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700077A")]
		object IEnumerator.Current
		{
			[DebuggerHidden]
			[Token(Token = "0x6006DD6")]
			[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		[Token(Token = "0x6006DD1")]
		[Address(RVA = "0x4096E0", Offset = "0x4084E0", Length = "0x4")]
		public _003CCooldown_003Ed__11(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[Token(Token = "0x6006DD2")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		void IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6006DD3")]
		[Address(RVA = "0x10B2010", Offset = "0x10B0E10", Length = "0x15E")]
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
		[Token(Token = "0x6006DD5")]
		[Address(RVA = "0x10B2170", Offset = "0x10B0F70", Length = "0x3E")]
		void IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40084C6")]
	[FieldOffset(Offset = "0x78")]
	public FilterMode filterMode;

	[ShowIf("filterMode", 0)]
	[Name("Max Times", 0)]
	[Token(Token = "0x40084C7")]
	[FieldOffset(Offset = "0x80")]
	public BBParameter<int> maxCount;

	[ShowIf("filterMode", 0)]
	[Name("Increase Count When", 0)]
	[Token(Token = "0x40084C8")]
	[FieldOffset(Offset = "0x88")]
	public Policy policy;

	[ShowIf("filterMode", 1)]
	[Token(Token = "0x40084C9")]
	[FieldOffset(Offset = "0x90")]
	public BBParameter<float> coolDownTime;

	[Token(Token = "0x40084CA")]
	[FieldOffset(Offset = "0x98")]
	public bool inactiveWhenLimited;

	[Token(Token = "0x40084CB")]
	[FieldOffset(Offset = "0x9C")]
	private int executedCount;

	[Token(Token = "0x40084CC")]
	[FieldOffset(Offset = "0xA0")]
	private float currentTime;

	[Token(Token = "0x6006DCD")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public override void OnGraphStarted()
	{
	}

	[Token(Token = "0x6006DCE")]
	[Address(RVA = "0x10B1C40", Offset = "0x10B0A40", Length = "0x1FA")]
	protected override Status OnExecute(Component agent, IBlackboard blackboard)
	{
		return default(Status);
	}

	[IteratorStateMachine(typeof(_003CCooldown_003Ed__11))]
	[Token(Token = "0x6006DCF")]
	[Address(RVA = "0x10B1E40", Offset = "0x10B0C40", Length = "0x9A")]
	private IEnumerator Cooldown()
	{
		return null;
	}

	[Token(Token = "0x6006DD0")]
	[Address(RVA = "0x10B1EE0", Offset = "0x10B0CE0", Length = "0x12B")]
	public Filter()
	{
	}
}
