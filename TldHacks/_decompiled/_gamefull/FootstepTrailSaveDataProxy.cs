using System.Collections.Generic;
using Cpp2ILInjected;

[Token(Token = "0x200039E")]
public class FootstepTrailSaveDataProxy
{
	[Token(Token = "0x4002064")]
	[FieldOffset(Offset = "0x10")]
	public FootstepTrailType m_TrailType;

	[Token(Token = "0x4002065")]
	[FieldOffset(Offset = "0x14")]
	public SnowImprintType m_ImprintType;

	[Token(Token = "0x4002066")]
	[FieldOffset(Offset = "0x18")]
	public List<string> m_FootstepGroups;

	[Token(Token = "0x4002067")]
	[FieldOffset(Offset = "0x20")]
	public List<uint> m_Footsteps;

	[Token(Token = "0x6001CB1")]
	[Address(RVA = "0x787F20", Offset = "0x786D20", Length = "0x159")]
	public FootstepTrailSaveDataProxy()
	{
	}
}
