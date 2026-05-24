using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000958")]
public class SnowPatch
{
	[Token(Token = "0x40060CC")]
	[FieldOffset(Offset = "0x10")]
	public int m_Id;

	[Token(Token = "0x40060CD")]
	[FieldOffset(Offset = "0x14")]
	public Bounds m_Bounds;

	[Token(Token = "0x40060CE")]
	[FieldOffset(Offset = "0x2C")]
	public Bounds m_BoundsQ0;

	[Token(Token = "0x40060CF")]
	[FieldOffset(Offset = "0x44")]
	public Bounds m_BoundsQ1;

	[Token(Token = "0x40060D0")]
	[FieldOffset(Offset = "0x5C")]
	public Bounds m_BoundsQ2;

	[Token(Token = "0x40060D1")]
	[FieldOffset(Offset = "0x74")]
	public Bounds m_BoundsQ3;

	[Token(Token = "0x40060D2")]
	[FieldOffset(Offset = "0x90")]
	public Vector3[] m_HermiteCoefficients;

	[Token(Token = "0x40060D3")]
	[FieldOffset(Offset = "0x98")]
	public SnowImprintExpanded[] m_Imprints;

	[Token(Token = "0x40060D4")]
	[FieldOffset(Offset = "0xA0")]
	public int m_NumImprints;

	[Token(Token = "0x40060D5")]
	[FieldOffset(Offset = "0xA4")]
	public int m_MaxImprints;

	[Token(Token = "0x40060D6")]
	[FieldOffset(Offset = "0xA8")]
	public int m_NextImprint;

	[Token(Token = "0x40060D7")]
	[FieldOffset(Offset = "0xAC")]
	public int m_RefCount;

	[Token(Token = "0x40060D8")]
	[FieldOffset(Offset = "0xB0")]
	public int m_QuadrantUsage;

	[Token(Token = "0x40060D9")]
	[FieldOffset(Offset = "0xB4")]
	public int m_CaptureTick;

	[Token(Token = "0x40060DA")]
	[FieldOffset(Offset = "0xB8")]
	public float m_CaptureWeight;

	[Token(Token = "0x40060DB")]
	[FieldOffset(Offset = "0xBC")]
	public float m_DeviationWeight;

	[Token(Token = "0x40060DC")]
	private static int m_NextPatchId;

	[Token(Token = "0x40060DD")]
	public static int m_MaxImprintsPerPatch;

	[Token(Token = "0x600547D")]
	[Address(RVA = "0xE82D30", Offset = "0xE81B30", Length = "0x139")]
	public SnowPatch()
	{
	}

	[Token(Token = "0x600547E")]
	[Address(RVA = "0xE82E70", Offset = "0xE81C70", Length = "0x5D5")]
	public void Initialize(Vector3 centrePos, float boundsSize)
	{
	}

	[Token(Token = "0x600547F")]
	[Address(RVA = "0xE83450", Offset = "0xE82250", Length = "0x7")]
	public void AddReference()
	{
	}

	[Token(Token = "0x6005480")]
	[Address(RVA = "0xE83460", Offset = "0xE82260", Length = "0xB")]
	public bool RemoveReference()
	{
		return false;
	}

	[Token(Token = "0x6005481")]
	[Address(RVA = "0xE83470", Offset = "0xE82270", Length = "0xE9")]
	public void OnRenderCapture(int captureTick, Camera cam)
	{
	}

	[Token(Token = "0x6005482")]
	[Address(RVA = "0xE83560", Offset = "0xE82360", Length = "0xB")]
	public void Hide()
	{
	}

	[Token(Token = "0x6005483")]
	[Address(RVA = "0xE83570", Offset = "0xE82370", Length = "0x12E")]
	public static void GeneratePatchCoefficients(Vector3 minPos, Vector3 maxPos, ref Vector3[] hermiteCoefficients, out float deviationWeight)
	{
		deviationWeight = default(float);
	}

	[Token(Token = "0x6005484")]
	[Address(RVA = "0xE836A0", Offset = "0xE824A0", Length = "0x17C")]
	private float GetPatchHeightAtPosition(Vector3 pos)
	{
		return 0f;
	}

	[Token(Token = "0x6005485")]
	[Address(RVA = "0xE83820", Offset = "0xE82620", Length = "0x170")]
	private float GetPatchHeightTangentAtPosition(Vector3 pos)
	{
		return 0f;
	}

	[Token(Token = "0x6005486")]
	[Address(RVA = "0xE83990", Offset = "0xE82790", Length = "0x64C")]
	public int AddImprint(ref SnowImprint imprint, Bounds imprintBounds, int typeMask = -1)
	{
		return 0;
	}
}
