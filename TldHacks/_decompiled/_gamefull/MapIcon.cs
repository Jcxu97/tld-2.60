using Cpp2ILInjected;
using TLD.UI.Generics;
using UnityEngine;

[Token(Token = "0x200025C")]
public class MapIcon : MonoBehaviour
{
	[Token(Token = "0x200025D")]
	public enum MapIconType
	{
		[Token(Token = "0x4001585")]
		TopIcon,
		[Token(Token = "0x4001586")]
		DetailIcon,
		[Token(Token = "0x4001587")]
		Text,
		[Token(Token = "0x4001588")]
		DetailEntry,
		[Token(Token = "0x4001589")]
		Area
	}

	[Token(Token = "0x200025E")]
	public enum State
	{
		[Token(Token = "0x400158B")]
		Uninitialized = -1,
		[Token(Token = "0x400158C")]
		Default,
		[Token(Token = "0x400158D")]
		Mission,
		[Token(Token = "0x400158E")]
		Directional,
		[Token(Token = "0x400158F")]
		Offscreen
	}

	[Token(Token = "0x400155D")]
	private const int DETAIL_ENTRY_START_DEPTH = 100;

	[Token(Token = "0x400155E")]
	private const int DETAIL_ICON_START_DEPTH = 5000;

	[Token(Token = "0x400155F")]
	private const int AREA_START_DEPTH = 10000;

	[Token(Token = "0x4001560")]
	private const int TOP_ICON_START_DEPTH = 15000;

	[Token(Token = "0x4001561")]
	private const int TEXT_START_DEPTH = 20000;

	[Token(Token = "0x4001562")]
	private const int USER_PLACED_START_DEPTH = 30000;

	[Token(Token = "0x4001563")]
	private const int HOVER_WIDGET_DEPTH = 50000;

	[Header("Panel References")]
	[SerializeField]
	[Token(Token = "0x4001564")]
	[FieldOffset(Offset = "0x20")]
	private PanelReference<Panel_Map> m_Map;

	[Header("On Screen")]
	[Token(Token = "0x4001565")]
	[FieldOffset(Offset = "0x28")]
	public UISprite m_MainSprite;

	[Token(Token = "0x4001566")]
	[FieldOffset(Offset = "0x30")]
	public UISprite m_BGSelectedSprite;

	[Token(Token = "0x4001567")]
	[FieldOffset(Offset = "0x38")]
	public UISprite m_BGSprite;

	[Token(Token = "0x4001568")]
	[FieldOffset(Offset = "0x40")]
	public UISprite m_Directional;

	[Token(Token = "0x4001569")]
	[FieldOffset(Offset = "0x48")]
	public UISprite m_AreaZoneSprite;

	[Header("Off Screen")]
	[Token(Token = "0x400156A")]
	[FieldOffset(Offset = "0x50")]
	public UISprite m_OffscreenStationary;

	[Token(Token = "0x400156B")]
	[FieldOffset(Offset = "0x58")]
	public UISprite m_OffscreenDirectional;

	[Header("Labels")]
	[Token(Token = "0x400156C")]
	[FieldOffset(Offset = "0x60")]
	public TweenAlpha m_LabelTween;

	[Token(Token = "0x400156D")]
	[FieldOffset(Offset = "0x68")]
	public UILabel m_Label;

	[Token(Token = "0x400156E")]
	[FieldOffset(Offset = "0x70")]
	public UISprite m_LabelBGSprite;

	[Token(Token = "0x400156F")]
	[FieldOffset(Offset = "0x78")]
	public Vector2 m_LabelBGSpritePadding;

	[Token(Token = "0x4001570")]
	[FieldOffset(Offset = "0x80")]
	public float m_SizeIncreaseOnSelect;

	[Token(Token = "0x4001571")]
	[FieldOffset(Offset = "0x84")]
	public float m_SizeIncreaseTimeSeconds;

	[Token(Token = "0x4001572")]
	[FieldOffset(Offset = "0x88")]
	public bool m_TextEntryScaleWithZoom;

	[Header("Mission Highlight")]
	[Token(Token = "0x4001573")]
	[FieldOffset(Offset = "0x90")]
	public UISprite m_MissionHighlight;

	[Token(Token = "0x4001574")]
	[FieldOffset(Offset = "0x98")]
	public Color m_DefaultColour;

	[Token(Token = "0x4001575")]
	[FieldOffset(Offset = "0xA8")]
	public Color m_MainMissionColour;

	[Token(Token = "0x4001576")]
	[FieldOffset(Offset = "0xB8")]
	public Color m_SideMissionColour;

	[Token(Token = "0x4001577")]
	[FieldOffset(Offset = "0xC8")]
	private MapIcon m_LocationMapIcon;

	[Token(Token = "0x4001578")]
	[FieldOffset(Offset = "0xD0")]
	private MapIconType m_MapIconType;

	[Token(Token = "0x4001579")]
	[FieldOffset(Offset = "0xD4")]
	private int m_Index;

	[Token(Token = "0x400157A")]
	[FieldOffset(Offset = "0xD8")]
	private bool m_IsUserPlaced;

	[Token(Token = "0x400157B")]
	[FieldOffset(Offset = "0xDC")]
	private State m_State;

	[Token(Token = "0x400157C")]
	[FieldOffset(Offset = "0xE0")]
	private bool m_IsHovering;

	[Token(Token = "0x400157D")]
	[FieldOffset(Offset = "0xE4")]
	private float m_SizeIncreaseCurrent;

	[Token(Token = "0x400157E")]
	[FieldOffset(Offset = "0xE8")]
	private float m_HoverTweenTimer;

	[Token(Token = "0x400157F")]
	[FieldOffset(Offset = "0xF0")]
	private string m_LocationNameLocID;

	[Token(Token = "0x4001580")]
	[FieldOffset(Offset = "0xF8")]
	private bool m_ShowDirection;

	[Token(Token = "0x4001581")]
	[FieldOffset(Offset = "0xFC")]
	private float m_MainSpriteSizeMultiplier;

	[Token(Token = "0x4001582")]
	[FieldOffset(Offset = "0x100")]
	private bool m_HasBgSelectedSprite;

	[Token(Token = "0x4001583")]
	[FieldOffset(Offset = "0x104")]
	private float m_OriginalBGSelectedAlpha;

	[Token(Token = "0x60014C5")]
	[Address(RVA = "0x693750", Offset = "0x692550", Length = "0x109")]
	private void Awake()
	{
	}

	[Token(Token = "0x60014C6")]
	[Address(RVA = "0x693860", Offset = "0x692660", Length = "0xA05")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x60014C7")]
	[Address(RVA = "0x694270", Offset = "0x693070", Length = "0x81C")]
	public void DoSetup(MapElementSaveData mapData, Transform parentToUse, int index, MapIconType iconType, float mainSpriteSizeMultiplier, bool isUserPlaced)
	{
	}

	[Token(Token = "0x60014C8")]
	[Address(RVA = "0x694A90", Offset = "0x693890", Length = "0x23A")]
	public void EnableDirectionalIcon(float angle)
	{
	}

	[Token(Token = "0x60014C9")]
	[Address(RVA = "0x694CD0", Offset = "0x693AD0", Length = "0x4E")]
	public void ShowHoverWidget()
	{
	}

	[Token(Token = "0x60014CA")]
	[Address(RVA = "0x694D20", Offset = "0x693B20", Length = "0x92")]
	public void HideHoverWidget()
	{
	}

	[Token(Token = "0x60014CB")]
	[Address(RVA = "0x694DC0", Offset = "0x693BC0", Length = "0x8")]
	public string GetLocationNameLocID()
	{
		return null;
	}

	[Token(Token = "0x60014CC")]
	[Address(RVA = "0x694DD0", Offset = "0x693BD0", Length = "0x7")]
	public State GetState()
	{
		return default(State);
	}

	[Token(Token = "0x60014CD")]
	[Address(RVA = "0x694DE0", Offset = "0x693BE0", Length = "0x2AC")]
	public State SetState(State state)
	{
		return default(State);
	}

	[Token(Token = "0x60014CE")]
	[Address(RVA = "0x695090", Offset = "0x693E90", Length = "0x23B")]
	public string SetLocationMapIcon(MapIcon icon)
	{
		return null;
	}

	[Token(Token = "0x60014CF")]
	[Address(RVA = "0x6952D0", Offset = "0x6940D0", Length = "0xE9")]
	public Transform GetLocationMapTransform()
	{
		return null;
	}

	[Token(Token = "0x60014D0")]
	[Address(RVA = "0x6953C0", Offset = "0x6941C0", Length = "0x10B")]
	private void SetSpriteActive(UISprite sprite, bool isActive)
	{
	}

	[Token(Token = "0x60014D1")]
	[Address(RVA = "0x6954D0", Offset = "0x6942D0", Length = "0x5A9")]
	private void UpdateDepths()
	{
	}

	[Token(Token = "0x60014D2")]
	[Address(RVA = "0x695A80", Offset = "0x694880", Length = "0x5D")]
	private int GetBaseDepth()
	{
		return 0;
	}

	[Token(Token = "0x60014D3")]
	[Address(RVA = "0x695AE0", Offset = "0x6948E0", Length = "0xE1")]
	private void TintSprite(UISprite sprite, Color tint)
	{
	}

	[Token(Token = "0x60014D4")]
	[Address(RVA = "0x695BD0", Offset = "0x6949D0", Length = "0x1E9")]
	private void ScaleSprite(UISprite sprite, float scale)
	{
	}

	[Token(Token = "0x60014D5")]
	[Address(RVA = "0x695DC0", Offset = "0x694BC0", Length = "0x85")]
	public MapIcon()
	{
	}
}
