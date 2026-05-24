using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;

[Token(Token = "0x200081E")]
public class MissionInfo : MonoBehaviour
{
	[CompilerGenerated]
	[Token(Token = "0x200081F")]
	private sealed class _003CGetObjectives_003Ed__11 : IEnumerable<ObjectiveInfo>, IEnumerable, IEnumerator<ObjectiveInfo>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4005587")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4005588")]
		[FieldOffset(Offset = "0x18")]
		private ObjectiveInfo _003C_003E2__current;

		[Token(Token = "0x4005589")]
		[FieldOffset(Offset = "0x20")]
		private int _003C_003El__initialThreadId;

		[Token(Token = "0x400558A")]
		[FieldOffset(Offset = "0x28")]
		public MissionInfo _003C_003E4__this;

		[Token(Token = "0x400558B")]
		[FieldOffset(Offset = "0x30")]
		private IEnumerator _003C_003E7__wrap1;

		[Token(Token = "0x17000344")]
		ObjectiveInfo IEnumerator<ObjectiveInfo>.Current
		{
			[DebuggerHidden]
			[Token(Token = "0x6004B85")]
			[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000345")]
		object IEnumerator.Current
		{
			[DebuggerHidden]
			[Token(Token = "0x6004B87")]
			[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		[Token(Token = "0x6004B81")]
		[Address(RVA = "0x61AD60", Offset = "0x619B60", Length = "0x1C")]
		public _003CGetObjectives_003Ed__11(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[Token(Token = "0x6004B82")]
		[Address(RVA = "0xD564B0", Offset = "0xD552B0", Length = "0xD5")]
		void IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6004B83")]
		[Address(RVA = "0xD56590", Offset = "0xD55390", Length = "0x4FF")]
		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[Token(Token = "0x6004B84")]
		[Address(RVA = "0xD56A90", Offset = "0xD55890", Length = "0x62")]
		private void _003C_003Em__Finally1()
		{
		}

		[DebuggerHidden]
		[Token(Token = "0x6004B86")]
		[Address(RVA = "0xD56B00", Offset = "0xD55900", Length = "0x3E")]
		void IEnumerator.Reset()
		{
		}

		[DebuggerHidden]
		[Token(Token = "0x6004B88")]
		[Address(RVA = "0xD56B40", Offset = "0xD55940", Length = "0xCF")]
		IEnumerator<ObjectiveInfo> IEnumerable<ObjectiveInfo>.GetEnumerator()
		{
			return null;
		}

		[DebuggerHidden]
		[Token(Token = "0x6004B89")]
		[Address(RVA = "0xD56B40", Offset = "0xD55940", Length = "0xCF")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Token(Token = "0x400557C")]
	public const string Label = "MissionInfo";

	[Token(Token = "0x400557D")]
	[FieldOffset(Offset = "0x20")]
	public bool m_IsSideMission;

	[Token(Token = "0x400557E")]
	[FieldOffset(Offset = "0x28")]
	public LocalizedString m_MissionName;

	[Token(Token = "0x400557F")]
	[FieldOffset(Offset = "0x30")]
	public LocalizedString m_MissionDescription;

	[Token(Token = "0x4005580")]
	[FieldOffset(Offset = "0x38")]
	public LocalizedString m_MissionChapter;

	[Token(Token = "0x4005581")]
	[FieldOffset(Offset = "0x40")]
	public string m_MissionID;

	[Token(Token = "0x4005582")]
	[FieldOffset(Offset = "0x48")]
	public string m_TextureName;

	[Token(Token = "0x4005583")]
	[FieldOffset(Offset = "0x50")]
	public string m_TimerID;

	[Token(Token = "0x4005584")]
	[FieldOffset(Offset = "0x58")]
	public bool m_ShowWhenCompleted;

	[Token(Token = "0x4005585")]
	[FieldOffset(Offset = "0x60")]
	public string m_Icon;

	[Token(Token = "0x4005586")]
	private static AsyncOperationHandle<IList<GameObject>> s_handles;

	[IteratorStateMachine(typeof(_003CGetObjectives_003Ed__11))]
	[Token(Token = "0x6004B7D")]
	[Address(RVA = "0xD55E80", Offset = "0xD54C80", Length = "0xAF")]
	public IEnumerable<ObjectiveInfo> GetObjectives()
	{
		return null;
	}

	[Token(Token = "0x6004B7E")]
	[Address(RVA = "0xD55F30", Offset = "0xD54D30", Length = "0x450")]
	public static IList<MissionInfo> GetAllMissionInfos()
	{
		return null;
	}

	[Token(Token = "0x6004B7F")]
	[Address(RVA = "0xD56390", Offset = "0xD55190", Length = "0x118")]
	public static void ReleaseAllMissionInfos()
	{
	}

	[Token(Token = "0x6004B80")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public MissionInfo()
	{
	}
}
