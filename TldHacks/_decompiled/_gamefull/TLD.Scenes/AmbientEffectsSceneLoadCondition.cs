using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

namespace TLD.Scenes;

[CreateAssetMenu(menuName = "The Long Dark/Scenes/Load Condition/Ambient Effects")]
[Token(Token = "0x2001358")]
public class AmbientEffectsSceneLoadCondition : SceneLoadCondition
{
	[Token(Token = "0x17000A53")]
	public override bool AllowLoadUnloadDuringPlay
	{
		[Token(Token = "0x6007B97")]
		[Address(RVA = "0x430B50", Offset = "0x42F950", Length = "0x3")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x6007B98")]
	[Address(RVA = "0x11A7CE0", Offset = "0x11A6AE0", Length = "0x108")]
	public override bool ShouldLoadScene(ICollection<SceneLoadCondition> activeConditions)
	{
		return false;
	}

	[Token(Token = "0x6007B99")]
	[Address(RVA = "0x4A22A0", Offset = "0x4A10A0", Length = "0x7")]
	public AmbientEffectsSceneLoadCondition()
	{
	}
}
