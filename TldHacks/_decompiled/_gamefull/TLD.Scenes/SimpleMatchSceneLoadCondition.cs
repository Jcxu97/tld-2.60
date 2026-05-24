using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

namespace TLD.Scenes;

[CreateAssetMenu(menuName = "The Long Dark/Scenes/Load Condition/Simple Match")]
[Token(Token = "0x200135B")]
public class SimpleMatchSceneLoadCondition : SceneLoadCondition
{
	[Token(Token = "0x6007B9F")]
	[Address(RVA = "0x11A7F30", Offset = "0x11A6D30", Length = "0xC1")]
	public override bool ShouldLoadScene(ICollection<SceneLoadCondition> activeConditions)
	{
		return false;
	}

	[Token(Token = "0x6007BA0")]
	[Address(RVA = "0x4A22A0", Offset = "0x4A10A0", Length = "0x7")]
	public SimpleMatchSceneLoadCondition()
	{
	}
}
