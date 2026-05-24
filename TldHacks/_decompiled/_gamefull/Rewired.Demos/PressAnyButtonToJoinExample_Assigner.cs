using Cpp2ILInjected;
using UnityEngine;

namespace Rewired.Demos;

[AddComponentMenu(null)]
[Token(Token = "0x2000C50")]
public class PressAnyButtonToJoinExample_Assigner : MonoBehaviour
{
	[Token(Token = "0x60063C3")]
	[Address(RVA = "0xFD7350", Offset = "0xFD6150", Length = "0x9E")]
	private void Update()
	{
	}

	[Token(Token = "0x60063C4")]
	[Address(RVA = "0xFD73F0", Offset = "0xFD61F0", Length = "0x280")]
	private void AssignJoysticksToPlayers()
	{
	}

	[Token(Token = "0x60063C5")]
	[Address(RVA = "0xFD7680", Offset = "0xFD6480", Length = "0x109")]
	private Player FindPlayerWithoutJoystick()
	{
		return null;
	}

	[Token(Token = "0x60063C6")]
	[Address(RVA = "0xFD7790", Offset = "0xFD6590", Length = "0x16")]
	private bool DoAllPlayersHaveJoysticks()
	{
		return false;
	}

	[Token(Token = "0x60063C7")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public PressAnyButtonToJoinExample_Assigner()
	{
	}
}
