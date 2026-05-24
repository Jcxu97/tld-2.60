using Cpp2ILInjected;
using UnityEngine;

namespace TLD.Gameplay;

[CreateAssetMenu(menuName = "The Long Dark/Experience Modes/Custom Based Experience Mode")]
[Token(Token = "0x2001468")]
public class CustomBasedExperienceMode : CustomExperienceMode
{
	[Token(Token = "0x60081D2")]
	[Address(RVA = "0x1225D10", Offset = "0x1224B10", Length = "0x40")]
	public CustomBasedExperienceMode()
	{
	}
}
