using Cpp2ILInjected;
using TLD.Scenes;
using TLD.Scenes.ObjectReferences;
using TLD.Utility;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace InteractiveObjects;

[CreateAssetMenu(menuName = "The Long Dark/Transmitter/Create a Transmitter")]
[Token(Token = "0x2001329")]
public class TransmitterData : SceneObjectReference
{
	[SerializeField]
	[EditorReadOnly]
	[Token(Token = "0x4008D88")]
	[FieldOffset(Offset = "0x38")]
	private string m_Guid;

	[SerializeField]
	[EditorReadOnly]
	[Token(Token = "0x4008D89")]
	[FieldOffset(Offset = "0x40")]
	private string[] m_GuidAliases;

	[SerializeField]
	[Token(Token = "0x4008D8A")]
	[FieldOffset(Offset = "0x48")]
	private LocalizedString m_TransmitterName;

	[SerializeField]
	[Token(Token = "0x4008D8B")]
	[FieldOffset(Offset = "0x50")]
	private LocalizedString m_TransmitterDescription;

	[SerializeField]
	[Token(Token = "0x4008D8C")]
	[FieldOffset(Offset = "0x58")]
	private ZoneSpecification m_HomeZone;

	[SerializeField]
	[Token(Token = "0x4008D8D")]
	[FieldOffset(Offset = "0x60")]
	private AssetReferenceTexture2D m_RegionTexture;

	[SerializeField]
	[Token(Token = "0x4008D8E")]
	[FieldOffset(Offset = "0x68")]
	private AssetReferenceGameObject m_JournalMapItemPrefab;

	[Token(Token = "0x17000A3E")]
	public string Guid
	{
		[Token(Token = "0x6007ADA")]
		[Address(RVA = "0x4A7D50", Offset = "0x4A6B50", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A3F")]
	public LocalizedString TransmitterName
	{
		[Token(Token = "0x6007ADB")]
		[Address(RVA = "0x4B2FE0", Offset = "0x4B1DE0", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A40")]
	public LocalizedString TransmitterDescription
	{
		[Token(Token = "0x6007ADC")]
		[Address(RVA = "0x669640", Offset = "0x668440", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A41")]
	public AssetReferenceTexture2D RegionTexture
	{
		[Token(Token = "0x6007ADD")]
		[Address(RVA = "0x6E2FE0", Offset = "0x6E1DE0", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A42")]
	public AssetReferenceGameObject JournalMapItemPrefab
	{
		[Token(Token = "0x6007ADE")]
		[Address(RVA = "0x65D9D0", Offset = "0x65C7D0", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A43")]
	public WorldMapSpecification WorldMap
	{
		[Token(Token = "0x6007ADF")]
		[Address(RVA = "0x11998A0", Offset = "0x11986A0", Length = "0x1B")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007AE0")]
	[Address(RVA = "0x11998C0", Offset = "0x11986C0", Length = "0x12A")]
	public bool IsAlsoKnownAs(string otherGuid)
	{
		return false;
	}

	[Token(Token = "0x6007AE1")]
	[Address(RVA = "0x11999F0", Offset = "0x11987F0", Length = "0x4E")]
	public TransmitterData()
	{
	}
}
