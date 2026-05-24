using System;
using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using TLD.UI.Generics;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

[Name("ScrapMetalStruggle", 0)]
[Description("Used to spawn object, and tap to trigger animation")]
[Category("TLD Actions/Objects")]
[Token(Token = "0x2001226")]
public class Action_ScrapMetalStruggle : ActionTask
{
	[Serializable]
	[Token(Token = "0x2001227")]
	public class ConstrainedLimits
	{
		[Token(Token = "0x4008A0F")]
		[FieldOffset(Offset = "0x10")]
		public Vector2 m_PitchLimitDegrees;

		[Token(Token = "0x4008A10")]
		[FieldOffset(Offset = "0x18")]
		public Vector2 m_YawLimitDegrees;

		[Token(Token = "0x6007742")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public ConstrainedLimits()
		{
		}
	}

	[Token(Token = "0x2001228")]
	private enum State
	{
		[Token(Token = "0x4008A12")]
		Intro,
		[Token(Token = "0x4008A13")]
		WaitForFirstClick,
		[Token(Token = "0x4008A14")]
		PrepareStruggle,
		[Token(Token = "0x4008A15")]
		Struggle,
		[Token(Token = "0x4008A16")]
		Outro
	}

	[Token(Token = "0x40089FF")]
	[FieldOffset(Offset = "0x68")]
	private int m_AnimParameter_ScrapMetalStruggle_TriggerStruggle;

	[Token(Token = "0x4008A00")]
	[FieldOffset(Offset = "0x6C")]
	private int m_AnimParameter_ScrapMetalStruggle_Stage;

	[Token(Token = "0x4008A01")]
	[FieldOffset(Offset = "0x70")]
	private int m_AnimParameter_ScrapMetalStruggle_TapValue;

	[Token(Token = "0x4008A02")]
	[FieldOffset(Offset = "0x78")]
	public string m_KnifeIdentifier;

	[Token(Token = "0x4008A03")]
	[FieldOffset(Offset = "0x80")]
	private GameObject m_SpawnedProp;

	[Token(Token = "0x4008A04")]
	[FieldOffset(Offset = "0x88")]
	public float m_ChargePerTap;

	[Token(Token = "0x4008A05")]
	[FieldOffset(Offset = "0x8C")]
	public float m_DischargePerSecond;

	[Token(Token = "0x4008A06")]
	[FieldOffset(Offset = "0x90")]
	public int m_Stages;

	[Token(Token = "0x4008A07")]
	[FieldOffset(Offset = "0x94")]
	private float m_TapValue;

	[Token(Token = "0x4008A08")]
	[FieldOffset(Offset = "0x98")]
	private int m_Stage;

	[SerializeField]
	[Token(Token = "0x4008A09")]
	[FieldOffset(Offset = "0xA0")]
	private PanelReference<Panel_ActionsRadial> m_ActionsRadial;

	[SerializeField]
	[Token(Token = "0x4008A0A")]
	[FieldOffset(Offset = "0xA8")]
	private PanelReference<Panel_HUD> m_HUD;

	[Token(Token = "0x4008A0B")]
	[FieldOffset(Offset = "0xB0")]
	private ConstrainedLimits m_StartingConstainedLimits;

	[Token(Token = "0x4008A0C")]
	[FieldOffset(Offset = "0xB8")]
	public ConstrainedLimits m_WaitForClickConstainedLimits;

	[Token(Token = "0x4008A0D")]
	[FieldOffset(Offset = "0xC0")]
	public ConstrainedLimits m_StruggleConstainedLimits;

	[Token(Token = "0x4008A0E")]
	[FieldOffset(Offset = "0xC8")]
	private State m_State;

	[Token(Token = "0x6007731")]
	[Address(RVA = "0x1157C70", Offset = "0x1156A70", Length = "0x2CE")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x6007732")]
	[Address(RVA = "0x1157F40", Offset = "0x1156D40", Length = "0x23")]
	protected override void OnUpdate()
	{
	}

	[Token(Token = "0x6007733")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	private void UpdateIntro()
	{
	}

	[Token(Token = "0x6007734")]
	[Address(RVA = "0x1157F70", Offset = "0x1156D70", Length = "0x7")]
	private void OnIntroComplete()
	{
	}

	[Token(Token = "0x6007735")]
	[Address(RVA = "0x1157F80", Offset = "0x1156D80", Length = "0x3E8")]
	private void EnterWaitForFirstClick()
	{
	}

	[Token(Token = "0x6007736")]
	[Address(RVA = "0x1158370", Offset = "0x1157170", Length = "0x3F0")]
	private void UpdateWaitForFirstClick()
	{
	}

	[Token(Token = "0x6007737")]
	[Address(RVA = "0x1158770", Offset = "0x1157570", Length = "0x412")]
	private void EnterPrepareStruggle()
	{
	}

	[Token(Token = "0x6007738")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	private void UpdatePrepareStruggle()
	{
	}

	[Token(Token = "0x6007739")]
	[Address(RVA = "0x1158B90", Offset = "0x1157990", Length = "0xA7")]
	private void OnPrepareStruggleComplete()
	{
	}

	[Token(Token = "0x600773A")]
	[Address(RVA = "0x1158B90", Offset = "0x1157990", Length = "0xA7")]
	private void EnterStruggle()
	{
	}

	[Token(Token = "0x600773B")]
	[Address(RVA = "0x1158C40", Offset = "0x1157A40", Length = "0x2F3")]
	private void UpdateStruggle()
	{
	}

	[Token(Token = "0x600773C")]
	[Address(RVA = "0x1158F40", Offset = "0x1157D40", Length = "0x49E")]
	private void EnterOutro()
	{
	}

	[Token(Token = "0x600773D")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	private void UpdateOutro()
	{
	}

	[Token(Token = "0x600773E")]
	[Address(RVA = "0x11593E0", Offset = "0x11581E0", Length = "0x356")]
	private void OnOutroComplete()
	{
	}

	[Token(Token = "0x600773F")]
	[Address(RVA = "0x1159740", Offset = "0x1158540", Length = "0x265")]
	private void MaybeFindProp()
	{
	}

	[Token(Token = "0x6007740")]
	[Address(RVA = "0x11599B0", Offset = "0x11587B0", Length = "0x12D")]
	private void MaybeDestroyProp()
	{
	}

	[Token(Token = "0x6007741")]
	[Address(RVA = "0x1159AE0", Offset = "0x11588E0", Length = "0x1D0")]
	public Action_ScrapMetalStruggle()
	{
	}
}
