using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20005E9")]
public class HUDMission : MonoBehaviour
{
	[Token(Token = "0x20005EA")]
	private struct StatusUpdate
	{
		[Token(Token = "0x40036A0")]
		[FieldOffset(Offset = "0x0")]
		public string mission;

		[Token(Token = "0x40036A1")]
		[FieldOffset(Offset = "0x8")]
		public string objective;

		[Token(Token = "0x40036A2")]
		[FieldOffset(Offset = "0x10")]
		public MissionStatusType type;

		[Token(Token = "0x6002DC9")]
		[Address(RVA = "0x955B00", Offset = "0x954900", Length = "0xB2")]
		public void Clear()
		{
		}

		[Token(Token = "0x6002DCA")]
		[Address(RVA = "0x955BC0", Offset = "0x9549C0", Length = "0x14")]
		public bool IsValid()
		{
			return false;
		}
	}

	[SerializeField]
	[Token(Token = "0x4003696")]
	[FieldOffset(Offset = "0x20")]
	private Panel_HUD m_HUD;

	[Token(Token = "0x4003697")]
	[FieldOffset(Offset = "0x28")]
	public UILabel m_MissionInfo;

	[Token(Token = "0x4003698")]
	[FieldOffset(Offset = "0x30")]
	public UILabel m_MissionStatus;

	[Token(Token = "0x4003699")]
	[FieldOffset(Offset = "0x38")]
	public MissionStatusDisplaySettings m_DisplaySettings;

	[HideInInspector]
	[Token(Token = "0x400369A")]
	[FieldOffset(Offset = "0xB8")]
	public bool m_RestoreDisplay;

	[Token(Token = "0x400369B")]
	[FieldOffset(Offset = "0xC0")]
	private StatusUpdate m_CurrentStatus;

	[Token(Token = "0x400369C")]
	[FieldOffset(Offset = "0xD8")]
	private Queue<StatusUpdate> m_Queue;

	[Token(Token = "0x400369D")]
	[FieldOffset(Offset = "0xE0")]
	private Animator m_Animator;

	[Token(Token = "0x400369E")]
	[FieldOffset(Offset = "0xE8")]
	private float m_AnimationStartTime;

	[Token(Token = "0x400369F")]
	[FieldOffset(Offset = "0xEC")]
	private float m_AnimationElapsedSec;

	[Token(Token = "0x6002DBE")]
	[Address(RVA = "0x9541F0", Offset = "0x952FF0", Length = "0x103")]
	public void Disable()
	{
	}

	[Token(Token = "0x6002DBF")]
	[Address(RVA = "0x954300", Offset = "0x953100", Length = "0x27F")]
	public void Enqueue(MissionStatusType type, string id)
	{
	}

	[Token(Token = "0x6002DC0")]
	[Address(RVA = "0x954580", Offset = "0x953380", Length = "0x1D8")]
	public void EnqueueObjective(MissionStatusType type, string objectiveId)
	{
	}

	[Token(Token = "0x6002DC1")]
	[Address(RVA = "0x954760", Offset = "0x953560", Length = "0x17C")]
	public string GetDebugText()
	{
		return null;
	}

	[Token(Token = "0x6002DC2")]
	[Address(RVA = "0x9548E0", Offset = "0x9536E0", Length = "0xEA")]
	public void HideDisplay()
	{
	}

	[Token(Token = "0x6002DC3")]
	[Address(RVA = "0x952270", Offset = "0x951070", Length = "0x9F")]
	public bool IsActive()
	{
		return false;
	}

	[Token(Token = "0x6002DC4")]
	[Address(RVA = "0x9549D0", Offset = "0x9537D0", Length = "0xFF")]
	public void RestoreDisplay()
	{
	}

	[Token(Token = "0x6002DC5")]
	[Address(RVA = "0x954AD0", Offset = "0x9538D0", Length = "0x20E")]
	private void Awake()
	{
	}

	[Token(Token = "0x6002DC6")]
	[Address(RVA = "0x954CE0", Offset = "0x953AE0", Length = "0xC39")]
	private void Dequeue()
	{
	}

	[Token(Token = "0x6002DC7")]
	[Address(RVA = "0x955920", Offset = "0x954720", Length = "0x7D")]
	private void OnAnimationComplete()
	{
	}

	[Token(Token = "0x6002DC8")]
	[Address(RVA = "0x9559A0", Offset = "0x9547A0", Length = "0x15F")]
	public HUDMission()
	{
	}
}
