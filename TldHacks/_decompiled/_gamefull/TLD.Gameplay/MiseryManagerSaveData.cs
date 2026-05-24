using System.Collections.Generic;
using Cpp2ILInjected;

namespace TLD.Gameplay;

[Token(Token = "0x200148B")]
public class MiseryManagerSaveData
{
	[Token(Token = "0x200148C")]
	public class MiseryStageSaveData
	{
		[Token(Token = "0x400951E")]
		[FieldOffset(Offset = "0x10")]
		public int m_ActiveUntilHours;

		[Token(Token = "0x400951F")]
		[FieldOffset(Offset = "0x18")]
		public List<MiseryManager.MiseryAffliction> m_Afflictions;

		[Token(Token = "0x600827F")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public MiseryStageSaveData()
		{
		}
	}

	[Token(Token = "0x400951B")]
	[FieldOffset(Offset = "0x10")]
	public int m_CurrentStage;

	[Token(Token = "0x400951C")]
	[FieldOffset(Offset = "0x18")]
	public List<MiseryStageSaveData> m_MiseryStages;

	[Token(Token = "0x400951D")]
	[FieldOffset(Offset = "0x20")]
	public float m_DebugHoursPadding;

	[Token(Token = "0x600827E")]
	[Address(RVA = "0x1239EB0", Offset = "0x1238CB0", Length = "0xAD")]
	public MiseryManagerSaveData()
	{
	}
}
