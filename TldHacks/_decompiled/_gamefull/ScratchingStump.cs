using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000182")]
public class ScratchingStump : MonoBehaviour
{
	[Token(Token = "0x4000DF4")]
	[FieldOffset(Offset = "0x20")]
	public float m_ApproachRadiusDistance;

	[Token(Token = "0x4000DF5")]
	[FieldOffset(Offset = "0x24")]
	public float m_FinalRadiusDistance;

	[Token(Token = "0x4000DF6")]
	[FieldOffset(Offset = "0x28")]
	public float m_OffsetTowardStump;

	[Token(Token = "0x4000DF7")]
	private static List<ScratchingStump> m_ScratchingStumpList;

	[Token(Token = "0x4000DF8")]
	private static List<ScratchingStump> m_SelectedScratchingStumpList;

	[Token(Token = "0x6000EC2")]
	[Address(RVA = "0x600270", Offset = "0x5FF070", Length = "0xBD")]
	public void Awake()
	{
	}

	[Token(Token = "0x6000EC3")]
	[Address(RVA = "0x600330", Offset = "0x5FF130", Length = "0x82")]
	public void OnDestroy()
	{
	}

	[Token(Token = "0x6000EC4")]
	[Address(RVA = "0x6003C0", Offset = "0x5FF1C0", Length = "0x93")]
	public static void ResetStumps()
	{
	}

	[Token(Token = "0x6000EC5")]
	[Address(RVA = "0x600460", Offset = "0x5FF260", Length = "0x4BA")]
	public static ScratchingStump SelectRandomStump(float radius, Vector3 currentAiPos)
	{
		return null;
	}

	[Token(Token = "0x6000EC6")]
	[Address(RVA = "0x600920", Offset = "0x5FF720", Length = "0x58")]
	public ScratchingStump()
	{
	}
}
