using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

namespace TLD.Scenes;

[Token(Token = "0x200135A")]
public abstract class SceneLoadCondition : ScriptableObject
{
	[Token(Token = "0x17000A54")]
	public virtual bool AllowLoadUnloadDuringPlay
	{
		[Token(Token = "0x6007B9C")]
		[Address(RVA = "0x4A2140", Offset = "0x4A0F40", Length = "0x3")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x6007B9D")]
	public abstract bool ShouldLoadScene(ICollection<SceneLoadCondition> activeConditions);

	[Token(Token = "0x6007B9E")]
	[Address(RVA = "0x4A22A0", Offset = "0x4A10A0", Length = "0x7")]
	protected SceneLoadCondition()
	{
	}
}
