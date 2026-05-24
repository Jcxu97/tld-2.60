using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20003A1")]
public class FootStepGroupDistanceComparer : IComparer<FootstepGroup>
{
	[Token(Token = "0x4002079")]
	[FieldOffset(Offset = "0x10")]
	public Vector3 m_Point;

	[Token(Token = "0x6001CC1")]
	[Address(RVA = "0x789700", Offset = "0x788500", Length = "0x158")]
	public int Compare(FootstepGroup x, FootstepGroup y)
	{
		return 0;
	}

	[Token(Token = "0x6001CC2")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public FootStepGroupDistanceComparer()
	{
	}
}
