using Cpp2ILInjected;
using UnityEngine;

namespace TLD.Scenes.ObjectReferences;

[Token(Token = "0x200136C")]
public class SceneObjectReferenceOwnerAttribute : PropertyAttribute
{
	[Token(Token = "0x4008EDC")]
	[FieldOffset(Offset = "0x18")]
	private readonly string m_BaseAssetPath;

	[Token(Token = "0x17000A76")]
	public string BaseAssetPath
	{
		[Token(Token = "0x6007C11")]
		[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007C10")]
	[Address(RVA = "0x4A5700", Offset = "0x4A4500", Length = "0x52")]
	public SceneObjectReferenceOwnerAttribute(string baseAssetPath)
	{
	}
}
