using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200083C")]
public class ObjectiveInfo : MonoBehaviour
{
	[CompilerGenerated]
	[Token(Token = "0x200083D")]
	private sealed class _003CGetSubObjectives_003Ed__13 : IEnumerable<ObjectiveInfo>, IEnumerable, IEnumerator<ObjectiveInfo>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4005642")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4005643")]
		[FieldOffset(Offset = "0x18")]
		private ObjectiveInfo _003C_003E2__current;

		[Token(Token = "0x4005644")]
		[FieldOffset(Offset = "0x20")]
		private int _003C_003El__initialThreadId;

		[Token(Token = "0x4005645")]
		[FieldOffset(Offset = "0x28")]
		public ObjectiveInfo _003C_003E4__this;

		[Token(Token = "0x4005646")]
		[FieldOffset(Offset = "0x30")]
		private IEnumerator _003C_003E7__wrap1;

		[Token(Token = "0x17000353")]
		ObjectiveInfo IEnumerator<ObjectiveInfo>.Current
		{
			[DebuggerHidden]
			[Token(Token = "0x6004C77")]
			[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000354")]
		object IEnumerator.Current
		{
			[DebuggerHidden]
			[Token(Token = "0x6004C79")]
			[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		[Token(Token = "0x6004C73")]
		[Address(RVA = "0x61AD60", Offset = "0x619B60", Length = "0x1C")]
		public _003CGetSubObjectives_003Ed__13(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[Token(Token = "0x6004C74")]
		[Address(RVA = "0xD70860", Offset = "0xD6F660", Length = "0xD5")]
		void IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6004C75")]
		[Address(RVA = "0xD70940", Offset = "0xD6F740", Length = "0x4FF")]
		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[Token(Token = "0x6004C76")]
		[Address(RVA = "0xD70E40", Offset = "0xD6FC40", Length = "0x62")]
		private void _003C_003Em__Finally1()
		{
		}

		[DebuggerHidden]
		[Token(Token = "0x6004C78")]
		[Address(RVA = "0xD70EB0", Offset = "0xD6FCB0", Length = "0x3E")]
		void IEnumerator.Reset()
		{
		}

		[DebuggerHidden]
		[Token(Token = "0x6004C7A")]
		[Address(RVA = "0xD70EF0", Offset = "0xD6FCF0", Length = "0xCF")]
		IEnumerator<ObjectiveInfo> IEnumerable<ObjectiveInfo>.GetEnumerator()
		{
			return null;
		}

		[DebuggerHidden]
		[Token(Token = "0x6004C7B")]
		[Address(RVA = "0xD70EF0", Offset = "0xD6FCF0", Length = "0xCF")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Token(Token = "0x4005635")]
	[FieldOffset(Offset = "0x20")]
	public string m_ObjectiveID;

	[Token(Token = "0x4005636")]
	[FieldOffset(Offset = "0x28")]
	public LocalizedString m_ObjectiveDescription;

	[Token(Token = "0x4005637")]
	[FieldOffset(Offset = "0x30")]
	public LocalizedString m_ObjectiveDescriptionUnits;

	[Token(Token = "0x4005638")]
	[FieldOffset(Offset = "0x38")]
	public LocalizedString m_ObjectiveHudDescription;

	[Token(Token = "0x4005639")]
	[FieldOffset(Offset = "0x40")]
	public string m_TimerID;

	[Token(Token = "0x400563A")]
	[FieldOffset(Offset = "0x48")]
	public string m_CountCurrentBBName;

	[Token(Token = "0x400563B")]
	[FieldOffset(Offset = "0x50")]
	public string m_CountRequiredBBName;

	[Token(Token = "0x400563C")]
	[FieldOffset(Offset = "0x58")]
	public MissionObjectiveCountType m_UnitType;

	[Token(Token = "0x400563D")]
	[FieldOffset(Offset = "0x5C")]
	public bool m_ShowWhenCompleted;

	[Token(Token = "0x400563E")]
	[FieldOffset(Offset = "0x5D")]
	public bool m_ShowSubobjectivesInSummary;

	[Token(Token = "0x400563F")]
	[FieldOffset(Offset = "0x5E")]
	public bool m_ShowSmallKicker;

	[Tooltip("An optional way to not count a specific objective's state towards the overall %")]
	[Token(Token = "0x4005640")]
	[FieldOffset(Offset = "0x5F")]
	public bool m_IgnoreInProgressionCalculation;

	[Tooltip("An optional way to count a specific objective's progress towards the overall %")]
	[Token(Token = "0x4005641")]
	[FieldOffset(Offset = "0x60")]
	public bool m_UseAsFraction;

	[IteratorStateMachine(typeof(_003CGetSubObjectives_003Ed__13))]
	[Token(Token = "0x6004C71")]
	[Address(RVA = "0xD70760", Offset = "0xD6F560", Length = "0xAF")]
	public IEnumerable<ObjectiveInfo> GetSubObjectives()
	{
		return null;
	}

	[Token(Token = "0x6004C72")]
	[Address(RVA = "0xD70810", Offset = "0xD6F610", Length = "0x47")]
	public ObjectiveInfo()
	{
	}
}
