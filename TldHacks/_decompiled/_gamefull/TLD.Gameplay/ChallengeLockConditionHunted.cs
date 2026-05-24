using Cpp2ILInjected;
using UnityEngine;

namespace TLD.Gameplay;

[CreateAssetMenu(menuName = "The Long Dark/Gameplay/Challenges/Hunted Lock Condition")]
[Token(Token = "0x20014A4")]
public class ChallengeLockConditionHunted : ChallengeLockCondition
{
	[Token(Token = "0x60082E0")]
	[Address(RVA = "0x123FA80", Offset = "0x123E880", Length = "0xB6")]
	public override bool IsLocked()
	{
		return false;
	}

	[Token(Token = "0x60082E1")]
	[Address(RVA = "0x4A22A0", Offset = "0x4A10A0", Length = "0x7")]
	public ChallengeLockConditionHunted()
	{
	}
}
