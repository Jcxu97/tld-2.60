using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2ILInjected;

namespace ParadoxNotion.Services;

[Token(Token = "0x2000D73")]
public static class Threader
{
	[CompilerGenerated]
	[Token(Token = "0x2000D7B")]
	private sealed class _003CThreadUpdater_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4008402")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4008403")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4008404")]
		[FieldOffset(Offset = "0x20")]
		public Thread thread;

		[Token(Token = "0x4008405")]
		[FieldOffset(Offset = "0x28")]
		public Action callback;

		[Token(Token = "0x17000731")]
		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			[Token(Token = "0x600694D")]
			[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000732")]
		object IEnumerator.Current
		{
			[DebuggerHidden]
			[Token(Token = "0x600694F")]
			[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		[Token(Token = "0x600694A")]
		[Address(RVA = "0x4096E0", Offset = "0x4084E0", Length = "0x4")]
		public _003CThreadUpdater_003Ed__9(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[Token(Token = "0x600694B")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		void IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600694C")]
		[Address(RVA = "0x1073580", Offset = "0x1072380", Length = "0x1C2")]
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
		[Token(Token = "0x600694E")]
		[Address(RVA = "0x1073750", Offset = "0x1072550", Length = "0x3E")]
		void IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x600692E")]
	[Address(RVA = "0x10731F0", Offset = "0x1071FF0", Length = "0x10A")]
	public static Thread StartAction(Action function, Action callback = null)
	{
		return null;
	}

	[Token(Token = "0x600692F")]
	[Address(RVA = "0x1A03390", Offset = "0x1A02190", Length = "0x247")]
	public static Thread StartAction<T1>(Action<T1> function, T1 parameter1, Action callback = null)
	{
		return null;
	}

	[Token(Token = "0x6006930")]
	[Address(RVA = "0x1A035E0", Offset = "0x1A023E0", Length = "0x2B8")]
	public static Thread StartAction<T1, T2>(Action<T1, T2> function, T1 parameter1, T2 parameter2, Action callback = null)
	{
		return null;
	}

	[Token(Token = "0x6006931")]
	[Address(RVA = "0x1A038A0", Offset = "0x1A026A0", Length = "0x33D")]
	public static Thread StartAction<T1, T2, T3>(Action<T1, T2, T3> function, T1 parameter1, T2 parameter2, T3 parameter3, Action callback = null)
	{
		return null;
	}

	[Token(Token = "0x6006932")]
	[Address(RVA = "0x1A03BE0", Offset = "0x1A029E0", Length = "0x2B1")]
	public static Thread StartFunction<TResult>(Func<TResult> function, Action<TResult> callback = null)
	{
		return null;
	}

	[Token(Token = "0x6006933")]
	[Address(RVA = "0x1A03EA0", Offset = "0x1A02CA0", Length = "0x31A")]
	public static Thread StartFunction<TResult, T1>(Func<T1, TResult> function, T1 parameter1, Action<TResult> callback = null)
	{
		return null;
	}

	[Token(Token = "0x6006934")]
	[Address(RVA = "0x1A041C0", Offset = "0x1A02FC0", Length = "0x3AD")]
	public static Thread StartFunction<TResult, T1, T2>(Func<T1, T2, TResult> function, T1 parameter1, T2 parameter2, Action<TResult> callback = null)
	{
		return null;
	}

	[Token(Token = "0x6006935")]
	[Address(RVA = "0x1A04570", Offset = "0x1A03370", Length = "0x43A")]
	public static Thread StartFunction<TResult, T1, T2, T3>(Func<T1, T2, T3, TResult> function, T1 parameter1, T2 parameter2, T3 parameter3, Action<TResult> callback = null)
	{
		return null;
	}

	[Token(Token = "0x6006936")]
	[Address(RVA = "0x1073300", Offset = "0x1072100", Length = "0x170")]
	private static void Begin(Thread thread, Action callback)
	{
	}

	[IteratorStateMachine(typeof(_003CThreadUpdater_003Ed__9))]
	[Token(Token = "0x6006937")]
	[Address(RVA = "0x1073480", Offset = "0x1072280", Length = "0xF7")]
	private static IEnumerator ThreadUpdater(Thread thread, Action callback)
	{
		return null;
	}
}
