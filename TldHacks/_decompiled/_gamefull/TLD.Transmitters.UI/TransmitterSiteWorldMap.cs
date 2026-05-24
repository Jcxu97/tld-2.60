using Cpp2ILInjected;
using TLD.Scenes;
using UnityEngine;

namespace TLD.Transmitters.UI;

[Token(Token = "0x20013EE")]
public class TransmitterSiteWorldMap : MonoBehaviour
{
	[SerializeField]
	[Token(Token = "0x40091DB")]
	[FieldOffset(Offset = "0x20")]
	private WorldMapSpecification m_WorldMap;

	[Token(Token = "0x17000AD8")]
	public WorldMapSpecification WorldMap
	{
		[Token(Token = "0x6007F13")]
		[Address(RVA = "0x40E110", Offset = "0x40CF10", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007F14")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public TransmitterSiteWorldMap()
	{
	}
}
