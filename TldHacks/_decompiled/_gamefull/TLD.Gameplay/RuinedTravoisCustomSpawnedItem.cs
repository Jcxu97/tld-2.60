using Cpp2ILInjected;
using UnityEngine;

namespace TLD.Gameplay;

[Token(Token = "0x2001471")]
public class RuinedTravoisCustomSpawnedItem : CustomSpawnedItem
{
	[SerializeField]
	[Token(Token = "0x400945A")]
	[FieldOffset(Offset = "0x38")]
	private Container m_Container;

	[Token(Token = "0x17000B44")]
	public Container Container
	{
		[Token(Token = "0x6008217")]
		[Address(RVA = "0x4A7D50", Offset = "0x4A6B50", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6008218")]
	[Address(RVA = "0x122C230", Offset = "0x122B030", Length = "0x4E")]
	public RuinedTravoisCustomSpawnedItem()
	{
	}
}
