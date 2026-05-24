using System.Collections.Generic;
using Cpp2ILInjected;

[Token(Token = "0x2000953")]
public class SnowfallManager
{
	[Token(Token = "0x4006092")]
	private static SnowfallManagerSaveDataProxy m_SnowfallManagerSaveDataProxy;

	[Token(Token = "0x4006093")]
	[FieldOffset(Offset = "0x10")]
	private Dictionary<string, SnowfallRecord> m_SnowfallRecords;

	[Token(Token = "0x4006094")]
	[FieldOffset(Offset = "0x18")]
	private SnowfallRecord m_LocalSceneRecord;

	[Token(Token = "0x1700037E")]
	public float LocalSnowDepth
	{
		[Token(Token = "0x6005464")]
		[Address(RVA = "0xE7E7C0", Offset = "0xE7D5C0", Length = "0x13")]
		get
		{
			return 0f;
		}
	}

	[Token(Token = "0x6005465")]
	[Address(RVA = "0xE7E7E0", Offset = "0xE7D5E0", Length = "0x415")]
	public SnowfallManager()
	{
	}

	[Token(Token = "0x6005466")]
	[Address(RVA = "0xE7EC00", Offset = "0xE7DA00", Length = "0xBC")]
	private SnowfallRecord RegisterRecord(string scene, float outOfSceneRateScalar)
	{
		return null;
	}

	[Token(Token = "0x6005467")]
	[Address(RVA = "0xE7ECC0", Offset = "0xE7DAC0", Length = "0x4AF")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x6005468")]
	[Address(RVA = "0xE7F170", Offset = "0xE7DF70", Length = "0x236")]
	public void Deserialize(string text)
	{
	}

	[Token(Token = "0x6005469")]
	[Address(RVA = "0xE7F3B0", Offset = "0xE7E1B0", Length = "0x1F")]
	public void AdjustSnowDepthRecord(float baseDepth)
	{
	}

	[Token(Token = "0x600546A")]
	[Address(RVA = "0xE7F3D0", Offset = "0xE7E1D0", Length = "0x174")]
	public void Update(float snowAdd)
	{
	}
}
