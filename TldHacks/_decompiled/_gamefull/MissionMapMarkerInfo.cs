using Cpp2ILInjected;
using TLD.Utility;
using UnityEngine;

[Token(Token = "0x20005F7")]
public class MissionMapMarkerInfo : MonoBehaviour
{
	[Token(Token = "0x4003700")]
	[FieldOffset(Offset = "0x20")]
	public string m_MarkerID;

	[Token(Token = "0x4003701")]
	[FieldOffset(Offset = "0x28")]
	public string m_RegionName;

	[Tooltip("Refers to the scene name of the LoadScene, or the trigger ID of the IndoorSpaceTrigger. Optional for mission markers.")]
	[Token(Token = "0x4003702")]
	[FieldOffset(Offset = "0x30")]
	public string m_LocationName;

	[Tooltip("For adding/removing mission map markers, if Location Name is empty, then just World Pos will be used. For revealing existing map locations, Location Name AND World Pos are required.")]
	[Token(Token = "0x4003703")]
	[FieldOffset(Offset = "0x38")]
	public Vector3 m_WorldPos;

	[Tooltip("Defines the size of the zone for Area markers. Not used for any other icon type")]
	[Token(Token = "0x4003704")]
	[FieldOffset(Offset = "0x44")]
	public Vector2 m_AreaZoneSize;

	[Tooltip("For revealing existing map locations, missionID is not required")]
	[Token(Token = "0x4003705")]
	[FieldOffset(Offset = "0x50")]
	public string m_MissionID;

	[Tooltip("Optional link to a specific objective ID. If not set, the map will only show info about the current mission")]
	[Token(Token = "0x4003706")]
	[FieldOffset(Offset = "0x58")]
	public string m_ObjectiveID;

	[SpriteAtlasIconName]
	[Token(Token = "0x4003707")]
	[FieldOffset(Offset = "0x60")]
	public string m_SpriteName;

	[Token(Token = "0x4003708")]
	[FieldOffset(Offset = "0x68")]
	public MapIcon.MapIconType m_IconType;

	[Tooltip("Whether this icon should attempt to merge with nearby location icons")]
	[Token(Token = "0x4003709")]
	[FieldOffset(Offset = "0x6C")]
	public bool m_MergeWithNearbyLocationIcons;

	[Token(Token = "0x400370A")]
	[FieldOffset(Offset = "0x70")]
	public LocalizedString m_OptionalCustomName;

	[Token(Token = "0x400370B")]
	[FieldOffset(Offset = "0x78")]
	public bool m_IsSurveyed;

	[Token(Token = "0x6002E1A")]
	[Address(RVA = "0x95E690", Offset = "0x95D490", Length = "0xCD")]
	public MissionMapMarkerInfo()
	{
	}
}
