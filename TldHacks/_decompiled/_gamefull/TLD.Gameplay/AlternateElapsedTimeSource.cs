using Cpp2ILInjected;
using UnityEngine;

namespace TLD.Gameplay;

[Token(Token = "0x2001454")]
public abstract class AlternateElapsedTimeSource : ScriptableObject
{
	[Token(Token = "0x600816F")]
	public abstract float GetElapsedTimeInHours();

	[Token(Token = "0x6008170")]
	[Address(RVA = "0x4A22A0", Offset = "0x4A10A0", Length = "0x7")]
	protected AlternateElapsedTimeSource()
	{
	}
}
