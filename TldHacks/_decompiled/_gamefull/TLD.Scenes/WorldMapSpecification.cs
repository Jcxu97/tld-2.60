using Cpp2ILInjected;
using TLD.OptionalContent;
using UnityEngine;

namespace TLD.Scenes;

[CreateAssetMenu(menuName = "The Long Dark/Scenes/World Map")]
[Token(Token = "0x2001367")]
public class WorldMapSpecification : ScriptableObject
{
	[SerializeField]
	[Token(Token = "0x4008EC2")]
	[FieldOffset(Offset = "0x18")]
	private LocalizedString m_MapName;

	[SerializeField]
	[Token(Token = "0x4008EC3")]
	[FieldOffset(Offset = "0x20")]
	private LocalizedString m_MapDescription;

	[SerializeField]
	[Token(Token = "0x4008EC4")]
	[FieldOffset(Offset = "0x28")]
	private UIWorldMap m_SelectWorldBaseMap;

	[SerializeField]
	[Token(Token = "0x4008EC5")]
	[FieldOffset(Offset = "0x30")]
	private UIWorldMap m_SelectRegionBaseMap;

	[SerializeField]
	[Token(Token = "0x4008EC6")]
	[FieldOffset(Offset = "0x38")]
	private UIWorldMap m_WorldMapBaseMap;

	[SerializeField]
	[Token(Token = "0x4008EC7")]
	[FieldOffset(Offset = "0x40")]
	private OptionalContentConfig m_RequiredOptionalContent;

	[Token(Token = "0x4008EC8")]
	[FieldOffset(Offset = "0x48")]
	private UIWorldMap m_SelectWorldBaseMapInstance;

	[Token(Token = "0x4008EC9")]
	[FieldOffset(Offset = "0x50")]
	private UIWorldMap m_SelectRegionBaseMapInstance;

	[Token(Token = "0x4008ECA")]
	[FieldOffset(Offset = "0x58")]
	private UIWorldMap m_WorldMapBaseMapInstance;

	[Token(Token = "0x17000A69")]
	public LocalizedString MapName
	{
		[Token(Token = "0x6007BEA")]
		[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A6A")]
	public LocalizedString MapDescription
	{
		[Token(Token = "0x6007BEB")]
		[Address(RVA = "0x40E110", Offset = "0x40CF10", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007BEC")]
	[Address(RVA = "0x11AD690", Offset = "0x11AC490", Length = "0x22")]
	public UIWorldMap GetSelectWorldBaseMap(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x6007BED")]
	[Address(RVA = "0x11AD6C0", Offset = "0x11AC4C0", Length = "0x22")]
	public UIWorldMap GetSelectRegionBaseMap(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x6007BEE")]
	[Address(RVA = "0x11AD6F0", Offset = "0x11AC4F0", Length = "0x22")]
	public UIWorldMap GetWorldMapBaseMap(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x6007BEF")]
	[Address(RVA = "0x11AD720", Offset = "0x11AC520", Length = "0x420")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6007BF0")]
	[Address(RVA = "0x11ADB40", Offset = "0x11AC940", Length = "0x11C")]
	public bool IsAvailable()
	{
		return false;
	}

	[Token(Token = "0x6007BF1")]
	[Address(RVA = "0x11ADC60", Offset = "0x11ACA60", Length = "0x27C")]
	private UIWorldMap GetOrInstantiateBaseMap(UIWorldMap prefab, Transform parent, ref UIWorldMap instance)
	{
		return null;
	}

	[Token(Token = "0x6007BF2")]
	[Address(RVA = "0x4A22A0", Offset = "0x4A10A0", Length = "0x7")]
	public WorldMapSpecification()
	{
	}
}
