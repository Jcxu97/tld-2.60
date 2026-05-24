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
using ParadoxNotion.Serialization;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

[Name("Execute Function (mp)", 0)]
[Category("✫ Script Control/Multiplatform")]
[Description("Execute a function on a script and save the return if any. If function is an IEnumerator it will execute as a coroutine.")]
[Token(Token = "0x20012F3")]
public class ExecuteFunction_Multiplatform : ActionTask
{
	[CompilerGenerated]
	[Token(Token = "0x20012F5")]
	private sealed class _003CInternalCoroutine_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4008C90")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4008C91")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4008C92")]
		[FieldOffset(Offset = "0x20")]
		public ExecuteFunction_Multiplatform _003C_003E4__this;

		[Token(Token = "0x4008C93")]
		[FieldOffset(Offset = "0x28")]
		public IEnumerator routine;

		[Token(Token = "0x17000A08")]
		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			[Token(Token = "0x60079BD")]
			[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000A09")]
		object IEnumerator.Current
		{
			[DebuggerHidden]
			[Token(Token = "0x60079BF")]
			[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		[Token(Token = "0x60079BA")]
		[Address(RVA = "0x4096E0", Offset = "0x4084E0", Length = "0x4")]
		public _003CInternalCoroutine_003Ed__16(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[Token(Token = "0x60079BB")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		void IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60079BC")]
		[Address(RVA = "0x1187B40", Offset = "0x1186940", Length = "0xFB")]
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
		[Token(Token = "0x60079BE")]
		[Address(RVA = "0x1187C40", Offset = "0x1186A40", Length = "0x3E")]
		void IEnumerator.Reset()
		{
		}
	}

	[SerializeField]
	[Token(Token = "0x4008C88")]
	[FieldOffset(Offset = "0x68")]
	protected SerializedMethodInfo method;

	[SerializeField]
	[Token(Token = "0x4008C89")]
	[FieldOffset(Offset = "0x70")]
	protected List<BBObjectParameter> parameters;

	[SerializeField]
	[Token(Token = "0x4008C8A")]
	[FieldOffset(Offset = "0x78")]
	protected List<bool> parameterIsByRef;

	[SerializeField]
	[BlackboardOnly]
	[Token(Token = "0x4008C8B")]
	[FieldOffset(Offset = "0x80")]
	protected BBObjectParameter returnValue;

	[Token(Token = "0x4008C8C")]
	[FieldOffset(Offset = "0x88")]
	private object[] args;

	[Token(Token = "0x4008C8D")]
	[FieldOffset(Offset = "0x90")]
	private bool routineRunning;

	[Token(Token = "0x17000A05")]
	private MethodInfo targetMethod
	{
		[Token(Token = "0x60079AD")]
		[Address(RVA = "0x110B0E0", Offset = "0x1109EE0", Length = "0xF")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A06")]
	public override Type agentType
	{
		[Token(Token = "0x60079AE")]
		[Address(RVA = "0x1185CD0", Offset = "0x1184AD0", Length = "0x170")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A07")]
	protected override string info
	{
		[Token(Token = "0x60079AF")]
		[Address(RVA = "0x1185E50", Offset = "0x1184C50", Length = "0x8A4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60079B0")]
	[Address(RVA = "0x1186700", Offset = "0x1185500", Length = "0xF6")]
	public override void OnValidate(ITaskSystem ownerSystem)
	{
	}

	[Token(Token = "0x60079B1")]
	[Address(RVA = "0x1186800", Offset = "0x1185600", Length = "0x312")]
	protected override string OnInit()
	{
		return null;
	}

	[Token(Token = "0x60079B2")]
	[Address(RVA = "0x1186B20", Offset = "0x1185920", Length = "0x66B")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x60079B3")]
	[Address(RVA = "0x7C0900", Offset = "0x7BF700", Length = "0x8")]
	protected override void OnStop()
	{
	}

	[IteratorStateMachine(typeof(_003CInternalCoroutine_003Ed__16))]
	[Token(Token = "0x60079B4")]
	[Address(RVA = "0x1187190", Offset = "0x1185F90", Length = "0xF7")]
	private IEnumerator InternalCoroutine(IEnumerator routine)
	{
		return null;
	}

	[Token(Token = "0x60079B5")]
	[Address(RVA = "0x1187290", Offset = "0x1186090", Length = "0x6A9")]
	private void SetMethod(MethodInfo method)
	{
	}

	[Token(Token = "0x60079B6")]
	[Address(RVA = "0x1187940", Offset = "0x1186740", Length = "0x160")]
	public ExecuteFunction_Multiplatform()
	{
	}
}
