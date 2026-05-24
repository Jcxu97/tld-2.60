using System;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000422")]
public class GlobalParameters : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000423")]
	public class DialogueSequenceParameters
	{
		[Range(0f, 1f)]
		[Token(Token = "0x4002562")]
		[FieldOffset(Offset = "0x10")]
		public float m_LookatSensitivityMultiplier;

		[Range(0f, 1f)]
		[Token(Token = "0x4002563")]
		[FieldOffset(Offset = "0x14")]
		public float m_StrafingSensitivityMultiplier;

		[Token(Token = "0x6001F41")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public DialogueSequenceParameters()
		{
		}
	}

	[Token(Token = "0x4002559")]
	[FieldOffset(Offset = "0x20")]
	public float m_FootStepPlayRange;

	[Token(Token = "0x400255A")]
	[FieldOffset(Offset = "0x24")]
	public float m_FootPrintCreateRange;

	[Token(Token = "0x400255B")]
	[FieldOffset(Offset = "0x28")]
	public float m_MaxPickupRange;

	[Token(Token = "0x400255C")]
	[FieldOffset(Offset = "0x2C")]
	public float m_MaxDecorationPickupRange;

	[Range(0f, 1f)]
	[Token(Token = "0x400255D")]
	[FieldOffset(Offset = "0x30")]
	public float m_PlayerRadiusIndoors;

	[Range(0f, 1f)]
	[Token(Token = "0x400255E")]
	[FieldOffset(Offset = "0x34")]
	public float m_PlayerRadiusOutdoors;

	[Range(0f, 1f)]
	[Token(Token = "0x400255F")]
	[FieldOffset(Offset = "0x38")]
	public float m_NearClipPlaneIndoors;

	[Range(0f, 1f)]
	[Token(Token = "0x4002560")]
	[FieldOffset(Offset = "0x3C")]
	public float m_NearClipPlaneOutdoors;

	[Token(Token = "0x4002561")]
	[FieldOffset(Offset = "0x40")]
	public DialogueSequenceParameters m_DialogueSequenceParameters;

	[Token(Token = "0x6001F3F")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	private void Start()
	{
	}

	[Token(Token = "0x6001F40")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public GlobalParameters()
	{
	}
}
