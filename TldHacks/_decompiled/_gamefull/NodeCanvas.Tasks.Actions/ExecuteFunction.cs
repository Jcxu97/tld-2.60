using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using NodeCanvas.Framework;
using NodeCanvas.Framework.Internal;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

[Category("✫ Script Control/Standalone Only")]
[Description("Execute a function on a script, of up to 6 parameters and save the return if any. If function is an IEnumerator it will execute as a coroutine.")]
[Token(Token = "0x20012FA")]
public class ExecuteFunction : ActionTask, ISubParametersContainer, IReflectedWrapper
{
	[CompilerGenerated]
	[Token(Token = "0x20012FB")]
	private sealed class _003CInternalCoroutine_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4008C9F")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4008CA0")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4008CA1")]
		[FieldOffset(Offset = "0x20")]
		public ExecuteFunction _003C_003E4__this;

		[Token(Token = "0x4008CA2")]
		[FieldOffset(Offset = "0x28")]
		public IEnumerator routine;

		[Token(Token = "0x17000A16")]
		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			[Token(Token = "0x60079EB")]
			[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A17")]
		object IEnumerator.Current
		{
			[DebuggerHidden]
			[Token(Token = "0x60079ED")]
			[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		[Token(Token = "0x60079E8")]
		[Address(RVA = "0x4096E0", Offset = "0x4084E0", Length = "0x4")]
		public _003CInternalCoroutine_003Ed__14(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[Token(Token = "0x60079E9")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		void IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60079EA")]
		[Address(RVA = "0x118B220", Offset = "0x118A020", Length = "0xEF")]
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
		[Token(Token = "0x60079EC")]
		[Address(RVA = "0x118B310", Offset = "0x118A110", Length = "0x3E")]
		void IEnumerator.Reset()
		{
		}
	}

	[SerializeField]
	[Token(Token = "0x4008C9D")]
	[FieldOffset(Offset = "0x68")]
	protected ReflectedWrapper functionWrapper;

	[Token(Token = "0x4008C9E")]
	[FieldOffset(Offset = "0x70")]
	private bool routineRunning;

	[Token(Token = "0x17000A13")]
	private MethodInfo targetMethod
	{
		[Token(Token = "0x60079DE")]
		[Address(RVA = "0x110D4E0", Offset = "0x110C2E0", Length = "0x1A")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A14")]
	public override Type agentType
	{
		[Token(Token = "0x60079DF")]
		[Address(RVA = "0x1189D10", Offset = "0x1188B10", Length = "0x1A7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A15")]
	protected override string info
	{
		[Token(Token = "0x60079E0")]
		[Address(RVA = "0x1189EC0", Offset = "0x1188CC0", Length = "0xA04")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60079DC")]
	[Address(RVA = "0x110D4E0", Offset = "0x110C2E0", Length = "0x1A")]
	MemberInfo IReflectedWrapper.GetMemberInfo()
	{
		return null;
	}

	[Token(Token = "0x60079DD")]
	[Address(RVA = "0x110D4C0", Offset = "0x110C2C0", Length = "0x20")]
	BBParameter[] ISubParametersContainer.GetSubParameters()
	{
		return null;
	}

	[Token(Token = "0x60079E1")]
	[Address(RVA = "0x118A8D0", Offset = "0x11896D0", Length = "0x168")]
	public override void OnValidate(ITaskSystem ownerSystem)
	{
	}

	[Token(Token = "0x60079E2")]
	[Address(RVA = "0x118AA40", Offset = "0x1189840", Length = "0x18D")]
	protected override string OnInit()
	{
		return null;
	}

	[Token(Token = "0x60079E3")]
	[Address(RVA = "0x118ABD0", Offset = "0x11899D0", Length = "0x4CF")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x60079E4")]
	[Address(RVA = "0x118B0A0", Offset = "0x1189EA0", Length = "0x5")]
	protected override void OnStop()
	{
	}

	[IteratorStateMachine(typeof(_003CInternalCoroutine_003Ed__14))]
	[Token(Token = "0x60079E5")]
	[Address(RVA = "0x118B0B0", Offset = "0x1189EB0", Length = "0xF7")]
	private IEnumerator InternalCoroutine(IEnumerator routine)
	{
		return null;
	}

	[Token(Token = "0x60079E6")]
	[Address(RVA = "0x118B1B0", Offset = "0x1189FB0", Length = "0x6C")]
	private void SetMethod(MethodInfo method)
	{
	}

	[Token(Token = "0x60079E7")]
	[Address(RVA = "0xD769F0", Offset = "0xD757F0", Length = "0x8")]
	public ExecuteFunction()
	{
	}
}
