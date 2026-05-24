using Cpp2ILInjected;
using UnityEngine;

namespace TLD.Gameplay;

[CreateAssetMenu(menuName = "The Long Dark/Gameplay/Nowhere To Hide/Elapsed Time Source")]
[Token(Token = "0x2001490")]
public class NowhereToHideElapsedTimeSource : AlternateElapsedTimeSource
{
	[Token(Token = "0x600828D")]
	[Address(RVA = "0x123B970", Offset = "0x123A770", Length = "0x5E")]
	public override float GetElapsedTimeInHours()
	{
		return 0f;
	}

	[Token(Token = "0x600828E")]
	[Address(RVA = "0x4A22A0", Offset = "0x4A10A0", Length = "0x7")]
	public NowhereToHideElapsedTimeSource()
	{
	}
}
