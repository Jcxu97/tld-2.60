using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

namespace NodeCanvas.Framework;

[Token(Token = "0x200106D")]
public abstract class ActionTask<T> : ActionTask where T : class
{
	[Token(Token = "0x170007D2")]
	public sealed override Type agentType
	{
		[Token(Token = "0x6006F76")]
		[Address(RVA = "0x1E7AEF0", Offset = "0x1E79CF0", Length = "0x63")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170007D3")]
	public new T agent
	{
		[Token(Token = "0x6006F77")]
		[Address(RVA = "0x240BA10", Offset = "0x240A810", Length = "0x57")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6006F78")]
	[Address(RVA = "0xD769F0", Offset = "0xD757F0", Length = "0x8")]
	protected ActionTask()
	{
	}
}
[Token(Token = "0x200106E")]
public abstract class ActionTask : Task
{
	[CompilerGenerated]
	[Token(Token = "0x200106F")]
	private sealed class _003CActionUpdater_003Ed__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400858C")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400858D")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400858E")]
		[FieldOffset(Offset = "0x20")]
		public ActionTask _003C_003E4__this;

		[Token(Token = "0x400858F")]
		[FieldOffset(Offset = "0x28")]
		public Component agent;

		[Token(Token = "0x4008590")]
		[FieldOffset(Offset = "0x30")]
		public IBlackboard blackboard;

		[Token(Token = "0x4008591")]
		[FieldOffset(Offset = "0x38")]
		public Action<bool> callback;

		[Token(Token = "0x170007DA")]
		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			[Token(Token = "0x6006F90")]
			[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170007DB")]
		object IEnumerator.Current
		{
			[DebuggerHidden]
			[Token(Token = "0x6006F92")]
			[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		[Token(Token = "0x6006F8D")]
		[Address(RVA = "0x4096E0", Offset = "0x4084E0", Length = "0x4")]
		public _003CActionUpdater_003Ed__20(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[Token(Token = "0x6006F8E")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		void IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6006F8F")]
		[Address(RVA = "0x10C54F0", Offset = "0x10C42F0", Length = "0xD2")]
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
		[Token(Token = "0x6006F91")]
		[Address(RVA = "0x10C55D0", Offset = "0x10C43D0", Length = "0x3E")]
		void IEnumerator.Reset()
		{
		}
	}

	[NonSerialized]
	[Token(Token = "0x4008586")]
	[FieldOffset(Offset = "0x58")]
	private Status status;

	[NonSerialized]
	[Token(Token = "0x4008587")]
	[FieldOffset(Offset = "0x5C")]
	private float startedTime;

	[NonSerialized]
	[Token(Token = "0x4008588")]
	[FieldOffset(Offset = "0x60")]
	private float pausedTime;

	[NonSerialized]
	[Token(Token = "0x4008589")]
	[FieldOffset(Offset = "0x64")]
	private bool latch;

	[NonSerialized]
	[Token(Token = "0x400858A")]
	[FieldOffset(Offset = "0x65")]
	private bool _isPaused;

	[NonSerialized]
	[Token(Token = "0x400858B")]
	[FieldOffset(Offset = "0x66")]
	protected bool _ignoreSaveCheck;

	[Token(Token = "0x170007D4")]
	public float elapsedTime
	{
		[Token(Token = "0x6006F79")]
		[Address(RVA = "0x10C4D10", Offset = "0x10C3B10", Length = "0x75")]
		get
		{
			return 0f;
		}
	}

	[Token(Token = "0x170007D5")]
	public float deltaTime
	{
		[Token(Token = "0x6006F7A")]
		[Address(RVA = "0x10C4D90", Offset = "0x10C3B90", Length = "0xD6")]
		get
		{
			return 0f;
		}
	}

	[Token(Token = "0x170007D6")]
	public bool isRunning
	{
		[Token(Token = "0x6006F7B")]
		[Address(RVA = "0x9318A0", Offset = "0x9306A0", Length = "0x8")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x170007D7")]
	public bool isResting
	{
		[Token(Token = "0x6006F7C")]
		[Address(RVA = "0x10C4E70", Offset = "0x10C3C70", Length = "0x8")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x170007D8")]
	public bool ignoreSaveCheck
	{
		[Token(Token = "0x6006F7D")]
		[Address(RVA = "0x10C4E80", Offset = "0x10C3C80", Length = "0x5")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x170007D9")]
	public bool isPaused
	{
		[Token(Token = "0x6006F7E")]
		[Address(RVA = "0x10C4E90", Offset = "0x10C3C90", Length = "0x5")]
		get
		{
			return false;
		}
		[Token(Token = "0x6006F7F")]
		[Address(RVA = "0x10C4EA0", Offset = "0x10C3CA0", Length = "0x4")]
		private set
		{
		}
	}

	[Token(Token = "0x6006F80")]
	[Address(RVA = "0x10C4EB0", Offset = "0x10C3CB0", Length = "0xB9")]
	public void ExecuteAction(Component agent, IBlackboard blackboard, Action<bool> callback)
	{
	}

	[IteratorStateMachine(typeof(_003CActionUpdater_003Ed__20))]
	[Token(Token = "0x6006F81")]
	[Address(RVA = "0x10C4F70", Offset = "0x10C3D70", Length = "0x1B1")]
	private IEnumerator ActionUpdater(Component agent, IBlackboard blackboard, Action<bool> callback)
	{
		return null;
	}

	[Token(Token = "0x6006F82")]
	[Address(RVA = "0x10C5130", Offset = "0x10C3F30", Length = "0x15C")]
	public Status ExecuteAction(Component agent, IBlackboard blackboard)
	{
		return default(Status);
	}

	[Token(Token = "0x6006F83")]
	[Address(RVA = "0x10C5290", Offset = "0x10C4090", Length = "0xA")]
	public void EndAction()
	{
	}

	[Token(Token = "0x6006F84")]
	[Address(RVA = "0x10C52A0", Offset = "0x10C40A0", Length = "0xD2")]
	public void EndAction(bool success)
	{
	}

	[Token(Token = "0x6006F85")]
	[Address(RVA = "0x10C5380", Offset = "0x10C4180", Length = "0xC5")]
	public void EndAction(bool? success)
	{
	}

	[Token(Token = "0x6006F86")]
	[Address(RVA = "0x10C5450", Offset = "0x10C4250", Length = "0x73")]
	public void PauseAction()
	{
	}

	[Token(Token = "0x6006F87")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	protected virtual void OnExecute()
	{
	}

	[Token(Token = "0x6006F88")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	protected virtual void OnUpdate()
	{
	}

	[Token(Token = "0x6006F89")]
	[Address(RVA = "0x10C54D0", Offset = "0x10C42D0", Length = "0x11")]
	protected virtual void OnStop(bool interrupted)
	{
	}

	[Token(Token = "0x6006F8A")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	protected virtual void OnStop()
	{
	}

	[Token(Token = "0x6006F8B")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	protected virtual void OnPause()
	{
	}

	[Token(Token = "0x6006F8C")]
	[Address(RVA = "0xD769F0", Offset = "0xD757F0", Length = "0x8")]
	protected ActionTask()
	{
	}
}
