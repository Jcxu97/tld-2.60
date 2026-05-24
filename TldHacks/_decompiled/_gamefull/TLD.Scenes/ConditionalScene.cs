using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine.AddressableAssets;

namespace TLD.Scenes;

[Serializable]
[Token(Token = "0x2001359")]
public class ConditionalScene
{
	[Token(Token = "0x4008E93")]
	[FieldOffset(Offset = "0x10")]
	public AssetReference m_Scene;

	[Token(Token = "0x4008E94")]
	[FieldOffset(Offset = "0x18")]
	public SceneLoadCondition m_Condition;

	[Token(Token = "0x6007B9A")]
	[Address(RVA = "0x11A7DF0", Offset = "0x11A6BF0", Length = "0x135")]
	public bool ShouldLoadScene(ICollection<SceneLoadCondition> conditions)
	{
		return false;
	}

	[Token(Token = "0x6007B9B")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public ConditionalScene()
	{
	}
}
