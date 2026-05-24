using Cpp2ILInjected;
using TLD.UI.Generics;
using UnityEngine;

namespace TLD.Gameplay;

[Token(Token = "0x2001470")]
public class DropppedDecorationStorageCustomSpawnedItem : CustomSpawnedItem
{
	[SerializeField]
	[Token(Token = "0x4009458")]
	[FieldOffset(Offset = "0x38")]
	private Container m_Container;

	[SerializeField]
	[Token(Token = "0x4009459")]
	[FieldOffset(Offset = "0x40")]
	private PanelReference<Panel_Container> m_ContainerPanel;

	[Token(Token = "0x17000B43")]
	public Container Container
	{
		[Token(Token = "0x6008214")]
		[Address(RVA = "0x4A7D50", Offset = "0x4A6B50", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6008215")]
	[Address(RVA = "0x122C030", Offset = "0x122AE30", Length = "0x1A3")]
	private void Update()
	{
	}

	[Token(Token = "0x6008216")]
	[Address(RVA = "0x122C1E0", Offset = "0x122AFE0", Length = "0x4E")]
	public DropppedDecorationStorageCustomSpawnedItem()
	{
	}
}
