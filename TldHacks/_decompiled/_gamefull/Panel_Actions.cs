using Cpp2ILInjected;
using TLD.UI;
using TLD.UI.Generics;
using UnityEngine;

[Token(Token = "0x2000603")]
public class Panel_Actions : Panel_AutoReferenced
{
	[Header("Time Widget")]
	[Token(Token = "0x4003775")]
	[FieldOffset(Offset = "0x30")]
	public GameObject m_TimeWidgetPos;

	[Header("Labels")]
	[Token(Token = "0x4003776")]
	[FieldOffset(Offset = "0x38")]
	public UILabel m_TimeSurvivedLabel;

	[Token(Token = "0x4003777")]
	[FieldOffset(Offset = "0x40")]
	public UILabel m_ConditionsLabel;

	[Token(Token = "0x4003778")]
	[FieldOffset(Offset = "0x48")]
	public UILabel m_AirTempLabel;

	[Token(Token = "0x4003779")]
	[FieldOffset(Offset = "0x50")]
	public UILabel m_AirTempHeaderLabel;

	[Token(Token = "0x400377A")]
	[FieldOffset(Offset = "0x58")]
	public UILabel m_WindChillLabel;

	[Token(Token = "0x400377B")]
	[FieldOffset(Offset = "0x60")]
	public UILabel m_WindChillHeaderLabel;

	[Token(Token = "0x400377C")]
	[FieldOffset(Offset = "0x68")]
	public UILabel m_ClothingWarmthLabel;

	[Token(Token = "0x400377D")]
	[FieldOffset(Offset = "0x70")]
	public UILabel m_ClothingWarmthHeaderLabel;

	[Token(Token = "0x400377E")]
	[FieldOffset(Offset = "0x78")]
	public UILabel m_ClothingWindproofLabel;

	[Token(Token = "0x400377F")]
	[FieldOffset(Offset = "0x80")]
	public UILabel m_ClothingWindproofHeaderLabel;

	[Token(Token = "0x4003780")]
	[FieldOffset(Offset = "0x88")]
	public UILabel m_CalorieBurnLabel;

	[Token(Token = "0x4003781")]
	[FieldOffset(Offset = "0x90")]
	public UILabel m_FeelsLikeLabel;

	[Token(Token = "0x4003782")]
	[FieldOffset(Offset = "0x98")]
	public Color m_FreezingTempLabelColor;

	[Header("Mission Objective")]
	[Token(Token = "0x4003783")]
	[FieldOffset(Offset = "0xA8")]
	public GameObject m_MissionObjectivePanel;

	[Token(Token = "0x4003784")]
	[FieldOffset(Offset = "0xB0")]
	public UILabel m_ObjectiveStatus;

	[Token(Token = "0x4003785")]
	[FieldOffset(Offset = "0xB8")]
	public UILabel m_SubObjectiveStatus;

	[Header("Mission Progress")]
	[Token(Token = "0x4003786")]
	[FieldOffset(Offset = "0xC0")]
	public MissionsProgressBar m_MissionsProgressBar;

	[Header("Misc")]
	[Token(Token = "0x4003787")]
	[FieldOffset(Offset = "0xC8")]
	public UISprite m_SpriteBody;

	[Token(Token = "0x4003788")]
	[FieldOffset(Offset = "0xD0")]
	public GameObject m_RightPageHealthyObject;

	[Token(Token = "0x4003789")]
	[FieldOffset(Offset = "0xD8")]
	public ScrollList m_ScrollListEffects;

	[Token(Token = "0x400378A")]
	[FieldOffset(Offset = "0xE0")]
	public GameObject m_ButtonScrollUp;

	[Token(Token = "0x400378B")]
	[FieldOffset(Offset = "0xE8")]
	public GameObject m_ButtonScrollDown;

	[Token(Token = "0x400378C")]
	[FieldOffset(Offset = "0xF0")]
	public UISprite[] m_BodyIconList;

	[Token(Token = "0x400378D")]
	[FieldOffset(Offset = "0xF8")]
	public UISprite m_StatusLineSprite;

	[Token(Token = "0x400378E")]
	[FieldOffset(Offset = "0x100")]
	public float m_FadeTime;

	[Token(Token = "0x400378F")]
	[FieldOffset(Offset = "0x104")]
	public float m_FadeTimeMissionStart;

	[Token(Token = "0x4003790")]
	[FieldOffset(Offset = "0x108")]
	public UILabel m_MissionObjectiveLabel;

	[Token(Token = "0x4003791")]
	[FieldOffset(Offset = "0x110")]
	public UILabel m_MissionObjectiveWithTimerLabel;

	[Token(Token = "0x4003792")]
	[FieldOffset(Offset = "0x118")]
	public UILabel m_MissionTimerLabel;

	[Token(Token = "0x4003793")]
	[FieldOffset(Offset = "0x120")]
	public GameObject m_MissionObjectWithTimer;

	[Token(Token = "0x4003794")]
	[FieldOffset(Offset = "0x128")]
	public GameObject m_MissionObjectNoTimer;

	[Token(Token = "0x4003795")]
	[FieldOffset(Offset = "0x130")]
	public GameObject m_SprayPaintCanPrefab;

	[Token(Token = "0x4003796")]
	[FieldOffset(Offset = "0x138")]
	public GameObject m_SprayPaintCanPrefabNW2H;

	[Header("Panel References")]
	[SerializeField]
	[Token(Token = "0x4003797")]
	[FieldOffset(Offset = "0x140")]
	private PanelReference<Panel_HUD> m_HUD;

	[SerializeField]
	[Token(Token = "0x4003798")]
	[FieldOffset(Offset = "0x148")]
	private PanelReference<Panel_Rest> m_Rest;

	[SerializeField]
	[Token(Token = "0x4003799")]
	[FieldOffset(Offset = "0x150")]
	private PanelReference<Panel_FirstAid> m_FirstAid;

	[SerializeField]
	[Token(Token = "0x400379A")]
	[FieldOffset(Offset = "0x158")]
	private PanelReference<Panel_Inventory> m_Inventory;

	[SerializeField]
	[Token(Token = "0x400379B")]
	[FieldOffset(Offset = "0x160")]
	private PanelReference<Panel_Log> m_Log;

	[SerializeField]
	[Token(Token = "0x400379C")]
	[FieldOffset(Offset = "0x168")]
	private PanelReference<Panel_BedRollSelect> m_BedRollSelect;

	[SerializeField]
	[Token(Token = "0x400379D")]
	[FieldOffset(Offset = "0x170")]
	private PanelReference<Panel_SprayPaint> m_SprayPaint;

	[SerializeField]
	[Token(Token = "0x400379E")]
	[FieldOffset(Offset = "0x178")]
	private PanelReference<Panel_Repair> m_Repair;

	[SerializeField]
	[Token(Token = "0x400379F")]
	[FieldOffset(Offset = "0x180")]
	private PanelReference<Panel_Harvest> m_Harvest;

	[Token(Token = "0x40037A0")]
	[FieldOffset(Offset = "0x188")]
	private bool m_IgnoreEscape;

	[Token(Token = "0x40037A1")]
	[FieldOffset(Offset = "0x189")]
	private bool m_IgnoreInput;

	[Token(Token = "0x40037A2")]
	[FieldOffset(Offset = "0x18A")]
	private bool m_DoFadeOut;

	[Token(Token = "0x40037A3")]
	[FieldOffset(Offset = "0x18C")]
	private float m_FadeTimer;

	[Token(Token = "0x6002E92")]
	[Address(RVA = "0x969BC0", Offset = "0x9689C0", Length = "0xB3")]
	public override void Initialize()
	{
	}

	[Token(Token = "0x6002E93")]
	[Address(RVA = "0x969C80", Offset = "0x968A80", Length = "0x6C9")]
	private void Update()
	{
	}

	[Token(Token = "0x6002E94")]
	[Address(RVA = "0x96A350", Offset = "0x969150", Length = "0x2A")]
	public float GetPanelAlpha()
	{
		return 0f;
	}

	[Token(Token = "0x6002E95")]
	[Address(RVA = "0x96A380", Offset = "0x969180", Length = "0x73")]
	public void ConfigureForMissionStart()
	{
	}

	[Token(Token = "0x6002E96")]
	[Address(RVA = "0x96A400", Offset = "0x969200", Length = "0x5C4")]
	public override void Enable(bool enable)
	{
	}

	[Token(Token = "0x6002E97")]
	[Address(RVA = "0x96A9D0", Offset = "0x9697D0", Length = "0x88")]
	public void OnInventory()
	{
	}

	[Token(Token = "0x6002E98")]
	[Address(RVA = "0x96AA60", Offset = "0x969860", Length = "0x85")]
	public void OnLog()
	{
	}

	[Token(Token = "0x6002E99")]
	[Address(RVA = "0x96AAF0", Offset = "0x9698F0", Length = "0x99")]
	public void OnFirstAid()
	{
	}

	[Token(Token = "0x6002E9A")]
	[Address(RVA = "0x96AB90", Offset = "0x969990", Length = "0x61A")]
	public void OnBedRoll()
	{
	}

	[Token(Token = "0x6002E9B")]
	[Address(RVA = "0x96B1B0", Offset = "0x969FB0", Length = "0x2E0")]
	public void OnSnowShelter()
	{
	}

	[Token(Token = "0x6002E9C")]
	[Address(RVA = "0x4A2140", Offset = "0x4A0F40", Length = "0x3")]
	public override bool IsOverlayPanel()
	{
		return false;
	}

	[Token(Token = "0x6002E9D")]
	[Address(RVA = "0x96B4A0", Offset = "0x96A2A0", Length = "0x2EC")]
	public void OnSprayPaint()
	{
	}

	[Token(Token = "0x6002E9E")]
	[Address(RVA = "0x96B790", Offset = "0x96A590", Length = "0xD3")]
	public void OnSprayPaint(GearItem sprayPaintCanToUse)
	{
	}

	[Token(Token = "0x6002E9F")]
	[Address(RVA = "0x96B870", Offset = "0x96A670", Length = "0x6B")]
	public void OnStartFire()
	{
	}

	[Token(Token = "0x6002EA0")]
	[Address(RVA = "0x96B8E0", Offset = "0x96A6E0", Length = "0x337")]
	public void OnPlaceRockCache()
	{
	}

	[Token(Token = "0x6002EA1")]
	[Address(RVA = "0x96BC20", Offset = "0x96AA20", Length = "0x37F")]
	public void OnPlaceIceFishingHole()
	{
	}

	[Token(Token = "0x6002EA2")]
	[Address(RVA = "0x96BFA0", Offset = "0x96ADA0", Length = "0xE4")]
	public void OnRepair()
	{
	}

	[Token(Token = "0x6002EA3")]
	[Address(RVA = "0x96C090", Offset = "0x96AE90", Length = "0xE4")]
	public void OnHarvest()
	{
	}

	[Token(Token = "0x6002EA4")]
	[Address(RVA = "0x7F6DB0", Offset = "0x7F5BB0", Length = "0x13")]
	public void OnBack()
	{
	}

	[Token(Token = "0x6002EA5")]
	[Address(RVA = "0x96C180", Offset = "0x96AF80", Length = "0xBF")]
	public void DoScrollUp()
	{
	}

	[Token(Token = "0x6002EA6")]
	[Address(RVA = "0x96C240", Offset = "0x96B040", Length = "0xBF")]
	public void DoScrollDown()
	{
	}

	[Token(Token = "0x6002EA7")]
	[Address(RVA = "0x96C300", Offset = "0x96B100", Length = "0xBB")]
	public void UpdateAirTemperature()
	{
	}

	[Token(Token = "0x6002EA8")]
	[Address(RVA = "0x96C3C0", Offset = "0x96B1C0", Length = "0xBD")]
	public void UpdateWindchill()
	{
	}

	[Token(Token = "0x6002EA9")]
	[Address(RVA = "0x96C480", Offset = "0x96B280", Length = "0x108")]
	public void UpdateWeatherConditions()
	{
	}

	[Token(Token = "0x6002EAA")]
	[Address(RVA = "0x96C590", Offset = "0x96B390", Length = "0x38")]
	public bool IsFadingOut()
	{
		return false;
	}

	[Token(Token = "0x6002EAB")]
	[Address(RVA = "0x96C5D0", Offset = "0x96B3D0", Length = "0x161")]
	private void SetFirstAidElements()
	{
	}

	[Token(Token = "0x6002EAC")]
	[Address(RVA = "0x96C740", Offset = "0x96B540", Length = "0x2DE7")]
	private void RefreshScrollList()
	{
	}

	[Token(Token = "0x6002EAD")]
	[Address(RVA = "0x96F530", Offset = "0x96E330", Length = "0x2AD")]
	private void UpdateMissionInfo()
	{
	}

	[Token(Token = "0x6002EAE")]
	[Address(RVA = "0x96F7E0", Offset = "0x96E5E0", Length = "0x1E0")]
	private void UpdateFeelsLike()
	{
	}

	[Token(Token = "0x6002EAF")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public Panel_Actions()
	{
	}
}
