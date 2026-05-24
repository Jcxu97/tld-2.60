using Cpp2ILInjected;
using TLD.Scenes.ObjectReferences;
using UnityEngine;

namespace TLD.Gameplay;

[Token(Token = "0x2001461")]
public class BunkerLocationReference : SceneObjectReference
{
	[SerializeField]
	[Token(Token = "0x40093ED")]
	[FieldOffset(Offset = "0x38")]
	private string m_Guid;

	[Token(Token = "0x17000B3A")]
	public string Guid
	{
		[Token(Token = "0x60081B8")]
		[Address(RVA = "0x4A7D50", Offset = "0x4A6B50", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60081B9")]
	[Address(RVA = "0x12247F0", Offset = "0x12235F0", Length = "0x4E")]
	public BunkerLocationReference()
	{
	}
}
