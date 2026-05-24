using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace TLD.Scenes;

[CreateAssetMenu(menuName = "The Long Dark/Scenes/Scene Set Extension")]
[Token(Token = "0x2001363")]
public class SceneSetExtension : ScriptableObject
{
	[SerializeField]
	[Token(Token = "0x4008EB3")]
	[FieldOffset(Offset = "0x18")]
	private AssetReferenceT<SceneSet> m_ParentSceneSet;

	[SerializeField]
	[Token(Token = "0x4008EB4")]
	[FieldOffset(Offset = "0x20")]
	private List<AssetReference> m_AdditiveScenes;

	[SerializeField]
	[Token(Token = "0x4008EB5")]
	[FieldOffset(Offset = "0x28")]
	private List<ConditionalScene> m_ConditionalScenes;

	[Token(Token = "0x17000A65")]
	public List<AssetReference> AdditiveScenes
	{
		[Token(Token = "0x6007BCC")]
		[Address(RVA = "0x40E110", Offset = "0x40CF10", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A66")]
	public List<ConditionalScene> ConditionalScenes
	{
		[Token(Token = "0x6007BCD")]
		[Address(RVA = "0x413AB0", Offset = "0x4128B0", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007BCE")]
	[Address(RVA = "0x11AAD60", Offset = "0x11A9B60", Length = "0x302")]
	public SceneSet GetParentSceneSet()
	{
		return null;
	}

	[Token(Token = "0x6007BCF")]
	[Address(RVA = "0x11AB070", Offset = "0x11A9E70", Length = "0x162")]
	public SceneSetExtension()
	{
	}
}
