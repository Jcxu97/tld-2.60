using Cpp2ILInjected;
using TLD.Scenes;
using UnityEngine;

namespace TLD.Gameplay;

[CreateAssetMenu(menuName = "The Long Dark/Gameplay/Bunker Interior")]
[Token(Token = "0x200145F")]
public class BunkerInteriorSpecification : ScriptableObject
{
	[SerializeField]
	[Token(Token = "0x40093EA")]
	[FieldOffset(Offset = "0x18")]
	private SceneSet m_Interior;

	[SerializeField]
	[Token(Token = "0x40093EB")]
	[FieldOffset(Offset = "0x20")]
	private string m_ExitPointName;

	[Token(Token = "0x17000B38")]
	public SceneSet Interior
	{
		[Token(Token = "0x60081B2")]
		[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000B39")]
	public string ExitPointName
	{
		[Token(Token = "0x60081B3")]
		[Address(RVA = "0x40E110", Offset = "0x40CF10", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60081B4")]
	[Address(RVA = "0x4A22A0", Offset = "0x4A10A0", Length = "0x7")]
	public BunkerInteriorSpecification()
	{
	}
}
