using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20001A6")]
public class PlayEventMonitor : MonoBehaviour
{
	[Token(Token = "0x20001A7")]
	public struct PlayEventInfo
	{
		[Token(Token = "0x4000F00")]
		[FieldOffset(Offset = "0x0")]
		public string m_StateName;

		[Token(Token = "0x4000F01")]
		[FieldOffset(Offset = "0x8")]
		public int m_StateId;

		[Token(Token = "0x4000F02")]
		[FieldOffset(Offset = "0x10")]
		public Animator m_Animator;

		[Token(Token = "0x4000F03")]
		[FieldOffset(Offset = "0x18")]
		public StateMachineBehaviour m_Instigator;

		[Token(Token = "0x6000F94")]
		[Address(RVA = "0x617F20", Offset = "0x616D20", Length = "0xFF")]
		public PlayEventInfo(string stateName, int state, Animator animator, StateMachineBehaviour instigator)
		{
			m_StateName = null;
			m_StateId = 0;
			m_Animator = null;
			m_Instigator = null;
		}
	}

	[Token(Token = "0x4000EFF")]
	[FieldOffset(Offset = "0x20")]
	private List<PlayEventInfo> m_PlayEventInfoList;

	[Token(Token = "0x6000F8E")]
	[Address(RVA = "0x617440", Offset = "0x616240", Length = "0x1E3")]
	public void ResetRemainingEventsForInstigator(StateMachineBehaviour instigator)
	{
	}

	[Token(Token = "0x6000F8F")]
	[Address(RVA = "0x617630", Offset = "0x616430", Length = "0xD1")]
	public void OnPlay(string name, int stateId, Animator animator, StateMachineBehaviour instigator)
	{
	}

	[Token(Token = "0x6000F90")]
	[Address(RVA = "0x617710", Offset = "0x616510", Length = "0x28E")]
	public bool TryGetPlayingStateId(Animator animator, out int statedId)
	{
		statedId = default(int);
		return false;
	}

	[Token(Token = "0x6000F91")]
	[Address(RVA = "0x6179A0", Offset = "0x6167A0", Length = "0x29A")]
	public void OnStop(string name, int hash, Animator animator)
	{
	}

	[Token(Token = "0x6000F92")]
	[Address(RVA = "0x617C40", Offset = "0x616A40", Length = "0x1E3")]
	private void ClearPlayOnAnimator(Animator animator)
	{
	}

	[Token(Token = "0x6000F93")]
	[Address(RVA = "0x617E30", Offset = "0x616C30", Length = "0xE3")]
	public PlayEventMonitor()
	{
	}
}
