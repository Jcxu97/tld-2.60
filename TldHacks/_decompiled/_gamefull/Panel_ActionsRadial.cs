using System;
using System.Collections.Generic;
using AK.Wwise;
using Cpp2ILInjected;
using TLD.UI;
using TLD.UI.Generics;
using TLD.UI.Notifications;
using UnityEngine;

[Token(Token = "0x2000604")]
public class Panel_ActionsRadial : Panel_AutoReferenced, INotificationHandler
{
	[Token(Token = "0x2000605")]
	public enum RadialType
	{
		[Token(Token = "0x400380D")]
		LightSources,
		[Token(Token = "0x400380E")]
		Weapons,
		[Token(Token = "0x400380F")]
		Bedroll,
		[Token(Token = "0x4003810")]
		Fire,
		[Token(Token = "0x4003811")]
		Journal,
		[Token(Token = "0x4003812")]
		Inventory,
		[Token(Token = "0x4003813")]
		Decoy,
		[Token(Token = "0x4003814")]
		FirstAid,
		[Token(Token = "0x4003815")]
		PlaceItem,
		[Token(Token = "0x4003816")]
		Clothing,
		[Token(Token = "0x4003817")]
		Tools,
		[Token(Token = "0x4003818")]
		Crafting,
		[Token(Token = "0x4003819")]
		Empty,
		[Token(Token = "0x400381A")]
		EmergencyStim,
		[Token(Token = "0x400381B")]
		SnowShelter,
		[Token(Token = "0x400381C")]
		PassTime,
		[Token(Token = "0x400381D")]
		GoToRadial,
		[Token(Token = "0x400381E")]
		EmptySatchelSlot,
		[Token(Token = "0x400381F")]
		Status,
		[Token(Token = "0x4003820")]
		Food,
		[Token(Token = "0x4003821")]
		Drink,
		[Token(Token = "0x4003822")]
		Navigation,
		[Token(Token = "0x4003823")]
		Map,
		[Token(Token = "0x4003824")]
		Shelter,
		[Token(Token = "0x4003825")]
		LeanTo,
		[Token(Token = "0x4003826")]
		LeanToNoCampfire,
		[Token(Token = "0x4003827")]
		SprayPaint,
		[Token(Token = "0x4003828")]
		RockCache,
		[Token(Token = "0x4003829")]
		NoiseMaker,
		[Token(Token = "0x400382A")]
		IceFishingHole
	}

	[Serializable]
	[Token(Token = "0x2000606")]
	public class RadialInfo
	{
		[Token(Token = "0x400382B")]
		[FieldOffset(Offset = "0x10")]
		public RadialType m_RadialElement;

		[Token(Token = "0x400382C")]
		[FieldOffset(Offset = "0x18")]
		public string m_SpriteName;

		[Token(Token = "0x400382D")]
		[FieldOffset(Offset = "0x20")]
		public string m_SpriteNameHover;

		[Token(Token = "0x400382E")]
		[FieldOffset(Offset = "0x28")]
		public Vector2 m_PixelSize;

		[Token(Token = "0x400382F")]
		[FieldOffset(Offset = "0x30")]
		public string m_GreyOutSpriteName;

		[Token(Token = "0x4003830")]
		[FieldOffset(Offset = "0x38")]
		public Vector2 m_GreyOutPixelSize;

		[Token(Token = "0x4003831")]
		[FieldOffset(Offset = "0x40")]
		public Color m_IconActiveColor;

		[Token(Token = "0x4003832")]
		[FieldOffset(Offset = "0x50")]
		public Color m_IconActiveHoverColor;

		[Token(Token = "0x6002F09")]
		[Address(RVA = "0x97D000", Offset = "0x97BE00", Length = "0x2F")]
		public RadialInfo()
		{
		}
	}

	[Token(Token = "0x2000607")]
	public delegate void RadialGearDelegate(GearItem gi);

	[Header("Time Widget")]
	[Token(Token = "0x40037A4")]
	[FieldOffset(Offset = "0x30")]
	public GameObject m_TimeWidgetPos;

	[HideInInspector]
	[Token(Token = "0x40037A5")]
	[FieldOffset(Offset = "0x38")]
	public GearItem m_GearItemAddToSatchel;

	[HideInInspector]
	[Token(Token = "0x40037A6")]
	[FieldOffset(Offset = "0x40")]
	public RadialMenuArm m_RadialArmThatDidInvoke;

	[Token(Token = "0x40037A7")]
	[FieldOffset(Offset = "0x48")]
	public float m_SecondsToLockControlsAfter;

	[Token(Token = "0x40037A8")]
	[FieldOffset(Offset = "0x50")]
	public ButtonLegendContainer m_ButtonLegendContainer;

	[Token(Token = "0x40037A9")]
	[FieldOffset(Offset = "0x58")]
	public GameObject m_NonAnimatingObjects;

	[Token(Token = "0x40037AA")]
	[FieldOffset(Offset = "0x60")]
	public UISpriteAnimation m_BackpieceAnim;

	[Token(Token = "0x40037AB")]
	[FieldOffset(Offset = "0x68")]
	public UISpriteAnimation m_BackpieceAnimOut;

	[Token(Token = "0x40037AC")]
	[FieldOffset(Offset = "0x70")]
	public UISprite m_FadeOverlaySprite;

	[Token(Token = "0x40037AD")]
	[FieldOffset(Offset = "0x78")]
	public float m_FadeOverlayMaxAlpha;

	[Token(Token = "0x40037AE")]
	[FieldOffset(Offset = "0x7C")]
	public int m_NumFramesToFadeInOut;

	[Token(Token = "0x40037AF")]
	[FieldOffset(Offset = "0x80")]
	public bool m_DisableStatusBarsDuringFadeOut;

	[Token(Token = "0x40037B0")]
	[FieldOffset(Offset = "0x84")]
	public float m_CenterButtonRadius;

	[Token(Token = "0x40037B1")]
	[FieldOffset(Offset = "0x88")]
	public TweenScale m_TweenScale;

	[Token(Token = "0x40037B2")]
	[FieldOffset(Offset = "0x90")]
	public RadialMenuArm[] m_RadialArms;

	[Token(Token = "0x40037B3")]
	[FieldOffset(Offset = "0x98")]
	public RadialInfo[] m_PrimaryRadial;

	[Token(Token = "0x40037B4")]
	[FieldOffset(Offset = "0xA0")]
	public RadialInfo m_FireRadialInfo;

	[Token(Token = "0x40037B5")]
	[FieldOffset(Offset = "0xA8")]
	public RadialInfo m_PassTimeRadialInfo;

	[Token(Token = "0x40037B6")]
	[FieldOffset(Offset = "0xB0")]
	public RadialInfo m_SnowShelterRadialInfo;

	[Token(Token = "0x40037B7")]
	[FieldOffset(Offset = "0xB8")]
	public RadialInfo m_ShelterRadialInfo;

	[Token(Token = "0x40037B8")]
	[FieldOffset(Offset = "0xC0")]
	public RadialInfo m_DecoyRadialInfo;

	[Token(Token = "0x40037B9")]
	[FieldOffset(Offset = "0xC8")]
	public RadialInfo m_OpenMapRadialInfo;

	[Token(Token = "0x40037BA")]
	[FieldOffset(Offset = "0xD0")]
	public RadialInfo m_SprayPaintRadialInfo;

	[Token(Token = "0x40037BB")]
	[FieldOffset(Offset = "0xD8")]
	public string m_NowhereToHideSprayPaintCanSprite;

	[Token(Token = "0x40037BC")]
	[FieldOffset(Offset = "0xE0")]
	public RadialInfo m_OpenRockCacheRadialInfo;

	[Token(Token = "0x40037BD")]
	[FieldOffset(Offset = "0xE8")]
	public RadialInfo m_IceFishingHoleRadialInfo;

	[Token(Token = "0x40037BE")]
	[FieldOffset(Offset = "0xF0")]
	public Color m_SectionColorUnselected;

	[Token(Token = "0x40037BF")]
	[FieldOffset(Offset = "0x100")]
	public Color m_SectionColorSelected;

	[Token(Token = "0x40037C0")]
	[FieldOffset(Offset = "0x110")]
	public Color m_SectionColorEmpty;

	[Token(Token = "0x40037C1")]
	[FieldOffset(Offset = "0x120")]
	public Color m_SectionColorEmptySelected;

	[Token(Token = "0x40037C2")]
	[FieldOffset(Offset = "0x130")]
	public Color m_IconColorGreyedOut;

	[Token(Token = "0x40037C3")]
	[FieldOffset(Offset = "0x140")]
	public Color m_GearIconColorGreyedOut;

	[Token(Token = "0x40037C4")]
	[FieldOffset(Offset = "0x150")]
	public Color m_SubRadialBackButtonSelected;

	[Token(Token = "0x40037C5")]
	[FieldOffset(Offset = "0x160")]
	public Color m_SubRadialBackButtonUnselected;

	[Token(Token = "0x40037C6")]
	[FieldOffset(Offset = "0x170")]
	public UILabel m_SegmentLabel;

	[Token(Token = "0x40037C7")]
	[FieldOffset(Offset = "0x178")]
	public UILabel m_CurrentTimeLabel;

	[Tooltip("Corresponds to the ordering of the Radial Arms list defined above. Fields can be left blank to skip that radial segment")]
	[Token(Token = "0x40037C8")]
	[FieldOffset(Offset = "0x180")]
	public string[] m_LightSourceRadialOrder;

	[Tooltip("Corresponds to the ordering of the Radial Arms list defined above. Fields can be left blank to skip that radial segment")]
	[Token(Token = "0x40037C9")]
	[FieldOffset(Offset = "0x188")]
	public string[] m_WeaponRadialOrder;

	[Tooltip("Corresponds to the ordering of the Radial Arms list defined above. Fields can be left blank to skip that radial segment")]
	[Token(Token = "0x40037CA")]
	[FieldOffset(Offset = "0x190")]
	public string[] m_PlaceItemRadialOrder;

	[Tooltip("Corresponds to the ordering of the Radial Arms list defined above. Fields can be left blank to skip that radial segment")]
	[Token(Token = "0x40037CB")]
	[FieldOffset(Offset = "0x198")]
	public string[] m_NavigationRadialOrder;

	[Tooltip("Corresponds to the ordering of the Radial Arms list defined above. Fields can be left blank to skip that radial segment")]
	[Token(Token = "0x40037CC")]
	[FieldOffset(Offset = "0x1A0")]
	public string[] m_ShelterRadialOrder;

	[Token(Token = "0x40037CD")]
	[FieldOffset(Offset = "0x1A8")]
	public string[] m_ToolsRadialOrder;

	[Token(Token = "0x40037CE")]
	[FieldOffset(Offset = "0x1B0")]
	public AK.Wwise.Event m_ClickAudio;

	[Token(Token = "0x40037CF")]
	[FieldOffset(Offset = "0x1B8")]
	public AK.Wwise.Event m_BackAudio;

	[Token(Token = "0x40037D0")]
	[FieldOffset(Offset = "0x1C0")]
	public AK.Wwise.Event m_OpenAudio;

	[Token(Token = "0x40037D1")]
	[FieldOffset(Offset = "0x1C8")]
	public AK.Wwise.Event m_CloseAudio;

	[Token(Token = "0x40037D2")]
	[FieldOffset(Offset = "0x1D0")]
	public StatusBar m_ColdStatusBar;

	[Header("Condition Status")]
	[Token(Token = "0x40037D3")]
	[FieldOffset(Offset = "0x1D8")]
	public GameObject m_GearStatsObject;

	[Token(Token = "0x40037D4")]
	[FieldOffset(Offset = "0x1E0")]
	public GameObject m_GearConditionObject;

	[Token(Token = "0x40037D5")]
	[FieldOffset(Offset = "0x1E8")]
	public UISprite m_GearConditionSprite;

	[Token(Token = "0x40037D6")]
	[FieldOffset(Offset = "0x1F0")]
	public UILabel m_GearConditionLabel;

	[Token(Token = "0x40037D7")]
	[FieldOffset(Offset = "0x1F8")]
	public GameObject m_GearConditionCenteredObject;

	[Token(Token = "0x40037D8")]
	[FieldOffset(Offset = "0x200")]
	public UISprite m_GearConditionCenteredSprite;

	[Token(Token = "0x40037D9")]
	[FieldOffset(Offset = "0x208")]
	public UILabel m_GearConditionCenteredLabel;

	[Header("Stack Status")]
	[Token(Token = "0x40037DA")]
	[FieldOffset(Offset = "0x210")]
	public UISprite m_StackStatusIcon;

	[Token(Token = "0x40037DB")]
	[FieldOffset(Offset = "0x218")]
	public UISprite m_StackStatusIconShadow;

	[Token(Token = "0x40037DC")]
	[FieldOffset(Offset = "0x220")]
	public UILabel m_StackStatusLabel;

	[Token(Token = "0x40037DD")]
	[FieldOffset(Offset = "0x228")]
	public Color m_StackStatusColor;

	[Token(Token = "0x40037DE")]
	[FieldOffset(Offset = "0x238")]
	public string m_LiquidIcon;

	[Token(Token = "0x40037DF")]
	[FieldOffset(Offset = "0x240")]
	public string m_LampFuelIcon;

	[Header("Hot Cold Status")]
	[Token(Token = "0x40037E0")]
	[FieldOffset(Offset = "0x248")]
	public UISprite m_HotColdStatusIcon;

	[Token(Token = "0x40037E1")]
	[FieldOffset(Offset = "0x250")]
	public UISprite m_HotColdStatusIconShadow;

	[Token(Token = "0x40037E2")]
	[FieldOffset(Offset = "0x258")]
	public UILabel m_HotColdStatusLabel;

	[Token(Token = "0x40037E3")]
	[FieldOffset(Offset = "0x260")]
	public string m_FoodHotStatusIcon;

	[Token(Token = "0x40037E4")]
	[FieldOffset(Offset = "0x268")]
	public Color m_FoodHotStatusColor;

	[Token(Token = "0x40037E5")]
	[FieldOffset(Offset = "0x278")]
	public string m_FoodColdStatusIcon;

	[Token(Token = "0x40037E6")]
	[FieldOffset(Offset = "0x280")]
	public Color m_FoodColdStatusColor;

	[Header("Challenge Objective")]
	[Token(Token = "0x40037E7")]
	[FieldOffset(Offset = "0x290")]
	public UILabel m_MissionObjectiveLabel;

	[Token(Token = "0x40037E8")]
	[FieldOffset(Offset = "0x298")]
	public UILabel m_MissionObjectiveWithTimerLabel;

	[Token(Token = "0x40037E9")]
	[FieldOffset(Offset = "0x2A0")]
	public UILabel m_MissionTimerLabel;

	[Token(Token = "0x40037EA")]
	[FieldOffset(Offset = "0x2A8")]
	public GameObject m_MissionObjectWithTimer;

	[Token(Token = "0x40037EB")]
	[FieldOffset(Offset = "0x2B0")]
	public GameObject m_MissionObjectNoTimer;

	[Header("Mission Objective")]
	[Token(Token = "0x40037EC")]
	[FieldOffset(Offset = "0x2B8")]
	public GameObject m_MissionObjectivePanel;

	[Token(Token = "0x40037ED")]
	[FieldOffset(Offset = "0x2C0")]
	public UILabel m_ObjectiveStatus;

	[Token(Token = "0x40037EE")]
	[FieldOffset(Offset = "0x2C8")]
	public UILabel m_SubObjectiveStatus;

	[Header("Mission Progress")]
	[Token(Token = "0x40037EF")]
	[FieldOffset(Offset = "0x2D0")]
	public MissionsProgressBar m_MissionsProgressBar;

	[Header("Body Carry Radial")]
	[Token(Token = "0x40037F0")]
	[FieldOffset(Offset = "0x2D8")]
	public RadialInfo m_PlaceBodyRadialInfo;

	[Token(Token = "0x40037F1")]
	[FieldOffset(Offset = "0x2E0")]
	public RadialInfo m_DropBodyRadialInfo;

	[Token(Token = "0x40037F2")]
	[FieldOffset(Offset = "0x2E8")]
	public List<string> m_BodyCarryRadialOrder;

	[Header("Travois Carry Radial")]
	[Token(Token = "0x40037F3")]
	[FieldOffset(Offset = "0x2F0")]
	public List<string> m_TravoisCarryRadialOrder;

	[Token(Token = "0x40037F4")]
	[FieldOffset(Offset = "0x2F8")]
	public RadialInfo m_DropTravoisRadialInfo;

	[Header("Panel References")]
	[SerializeField]
	[Token(Token = "0x40037F5")]
	[FieldOffset(Offset = "0x300")]
	private PanelReference<Panel_Actions> m_Actions;

	[SerializeField]
	[Token(Token = "0x40037F6")]
	[FieldOffset(Offset = "0x308")]
	private PanelReference<Panel_Clothing> m_Clothing;

	[SerializeField]
	[Token(Token = "0x40037F7")]
	[FieldOffset(Offset = "0x310")]
	private PanelReference<Panel_Confirmation> m_Confirmation;

	[SerializeField]
	[Token(Token = "0x40037F8")]
	[FieldOffset(Offset = "0x318")]
	private PanelReference<Panel_HUD> m_HUD;

	[SerializeField]
	[Token(Token = "0x40037F9")]
	[FieldOffset(Offset = "0x320")]
	private PanelReference<Panel_Inventory> m_Inventory;

	[SerializeField]
	[Token(Token = "0x40037FA")]
	[FieldOffset(Offset = "0x328")]
	private PanelReference<Panel_Map> m_Map;

	[SerializeField]
	[Token(Token = "0x40037FB")]
	[FieldOffset(Offset = "0x330")]
	private PanelReference<Panel_MissionsStory> m_MissionsStory;

	[SerializeField]
	[Token(Token = "0x40037FC")]
	[FieldOffset(Offset = "0x338")]
	private PanelReference<Panel_Rest> m_Rest;

	[SerializeField]
	[Token(Token = "0x40037FD")]
	[FieldOffset(Offset = "0x340")]
	private PanelReference<Panel_IceFishingHoleClear> m_ClearHolePanel;

	[Header("Notification Flag")]
	[Token(Token = "0x40037FE")]
	[FieldOffset(Offset = "0x348")]
	public GameObject m_MissionNotificanFlag;

	[Token(Token = "0x40037FF")]
	[FieldOffset(Offset = "0x350")]
	public int m_MaximumRadialOnScreenLimit;

	[Token(Token = "0x4003800")]
	[FieldOffset(Offset = "0x354")]
	private int m_NextArmToAdd;

	[Token(Token = "0x4003801")]
	[FieldOffset(Offset = "0x358")]
	private bool m_UsingGamepadLastFrame;

	[Token(Token = "0x4003802")]
	[FieldOffset(Offset = "0x360")]
	private GearItem m_GearItemBeingInspected;

	[Token(Token = "0x4003803")]
	[FieldOffset(Offset = "0x368")]
	private float m_MaxFadeOverlayAlphaReached;

	[Token(Token = "0x4003804")]
	[FieldOffset(Offset = "0x36C")]
	private int m_NumFramesActive;

	[Token(Token = "0x4003805")]
	[FieldOffset(Offset = "0x370")]
	private bool m_RadialDisabled;

	[Token(Token = "0x4003806")]
	[FieldOffset(Offset = "0x371")]
	private bool m_IsExiting;

	[Token(Token = "0x4003807")]
	[FieldOffset(Offset = "0x378")]
	private List<Action> m_Queue;

	[Token(Token = "0x4003808")]
	[FieldOffset(Offset = "0x380")]
	private GearItem[] m_SatchelItems;

	[Token(Token = "0x4003809")]
	[FieldOffset(Offset = "0x388")]
	private List<GearItem> m_TempGearItemListNormal;

	[Token(Token = "0x400380A")]
	[FieldOffset(Offset = "0x390")]
	private List<GearItem> m_TempGearItemListFavorites;

	[Token(Token = "0x400380B")]
	[FieldOffset(Offset = "0x398")]
	private bool m_DoItemInHandsDuringInteractionEnd;

	[Token(Token = "0x6002EB0")]
	[Address(RVA = "0x96F9D0", Offset = "0x96E7D0", Length = "0x17E")]
	public override void Initialize()
	{
	}

	[Token(Token = "0x6002EB1")]
	[Address(RVA = "0x96FB50", Offset = "0x96E950", Length = "0xC1C")]
	private void Update()
	{
	}

	[Token(Token = "0x6002EB2")]
	[Address(RVA = "0x970770", Offset = "0x96F570", Length = "0xB")]
	public override void Enable(bool enable)
	{
	}

	[Token(Token = "0x6002EB3")]
	[Address(RVA = "0x970780", Offset = "0x96F580", Length = "0x709")]
	public void Enable(bool enable, bool doHoverDisable)
	{
	}

	[Token(Token = "0x6002EB4")]
	[Address(RVA = "0x96A350", Offset = "0x969150", Length = "0x2A")]
	public float GetPanelAlpha()
	{
		return 0f;
	}

	[Token(Token = "0x6002EB5")]
	[Address(RVA = "0x970E90", Offset = "0x96FC90", Length = "0x8")]
	public bool IsRadialDisabled()
	{
		return false;
	}

	[Token(Token = "0x6002EB6")]
	[Address(RVA = "0x970EA0", Offset = "0x96FCA0", Length = "0x7")]
	public void DisableRadial(bool disabled)
	{
	}

	[Token(Token = "0x6002EB7")]
	[Address(RVA = "0x970EB0", Offset = "0x96FCB0", Length = "0x9C")]
	public void DoFirstOpen()
	{
	}

	[Token(Token = "0x6002EB8")]
	[Address(RVA = "0x970F50", Offset = "0x96FD50", Length = "0x237")]
	public void DoTween()
	{
	}

	[Token(Token = "0x6002EB9")]
	[Address(RVA = "0x971190", Offset = "0x96FF90", Length = "0x69E")]
	public void ShowSatchelSelectSlotRadial()
	{
	}

	[Token(Token = "0x6002EBA")]
	[Address(RVA = "0x971830", Offset = "0x970630", Length = "0x75A")]
	public void ShowSatchelRadial()
	{
	}

	[Token(Token = "0x6002EBB")]
	[Address(RVA = "0x971F90", Offset = "0x970D90", Length = "0x3A4")]
	public void ShowPrimaryRadial()
	{
	}

	[Token(Token = "0x6002EBC")]
	[Address(RVA = "0x972340", Offset = "0x971140", Length = "0x38C")]
	public void ShowLightSourceRadial()
	{
	}

	[Token(Token = "0x6002EBD")]
	[Address(RVA = "0x9726D0", Offset = "0x9714D0", Length = "0x38C")]
	public void ShowWeaponRadial()
	{
	}

	[Token(Token = "0x6002EBE")]
	[Address(RVA = "0x972A60", Offset = "0x971860", Length = "0x38C")]
	public void ShowToolsRadial()
	{
	}

	[Token(Token = "0x6002EBF")]
	[Address(RVA = "0x972DF0", Offset = "0x971BF0", Length = "0x3A1")]
	private List<GearItem> GetGearItemsForRadial(string[] itemOrder, out int items)
	{
		items = default(int);
		return null;
	}

	[Token(Token = "0x6002EC0")]
	[Address(RVA = "0x9731A0", Offset = "0x971FA0", Length = "0xE3F")]
	public void ShowPlaceItemRadial()
	{
	}

	[Token(Token = "0x6002EC1")]
	[Address(RVA = "0x973FE0", Offset = "0x972DE0", Length = "0x1CB")]
	private static bool VehicleHasBuiltInBed()
	{
		return false;
	}

	[Token(Token = "0x6002EC2")]
	[Address(RVA = "0x9741B0", Offset = "0x972FB0", Length = "0x7E")]
	private static bool IsInVehicle()
	{
		return false;
	}

	[Token(Token = "0x6002EC3")]
	[Address(RVA = "0x974230", Offset = "0x973030", Length = "0x89")]
	private static bool IsInSnowShelter()
	{
		return false;
	}

	[Token(Token = "0x6002EC4")]
	[Address(RVA = "0x9742C0", Offset = "0x9730C0", Length = "0x3B4")]
	public void ShowShelterRadial()
	{
	}

	[Token(Token = "0x6002EC5")]
	[Address(RVA = "0x974680", Offset = "0x973480", Length = "0x6DA")]
	public void ShowNavigationRadial()
	{
	}

	[Token(Token = "0x6002EC6")]
	[Address(RVA = "0x974D60", Offset = "0x973B60", Length = "0x634")]
	public void ShowBodyCarryRadial()
	{
	}

	[Token(Token = "0x6002EC7")]
	[Address(RVA = "0x9753A0", Offset = "0x9741A0", Length = "0x464")]
	public void ShowTravoisCarryRadial()
	{
	}

	[Token(Token = "0x6002EC8")]
	[Address(RVA = "0x975810", Offset = "0x974610", Length = "0x9C")]
	public void DoBigCarryDrop()
	{
	}

	[Token(Token = "0x6002EC9")]
	[Address(RVA = "0x9758B0", Offset = "0x9746B0", Length = "0x97")]
	public void DoBodyPlacement()
	{
	}

	[Token(Token = "0x6002ECA")]
	[Address(RVA = "0x975950", Offset = "0x974750", Length = "0x76")]
	public void DoOpenMap()
	{
	}

	[Token(Token = "0x6002ECB")]
	[Address(RVA = "0x9759D0", Offset = "0x9747D0", Length = "0x13A")]
	public void ShowFoodRadial()
	{
	}

	[Token(Token = "0x6002ECC")]
	[Address(RVA = "0x975B10", Offset = "0x974910", Length = "0x13A")]
	public void ShowDrinkRadial()
	{
	}

	[Token(Token = "0x6002ECD")]
	[Address(RVA = "0x975C50", Offset = "0x974A50", Length = "0x13A")]
	public void ShowFirstAidRadial()
	{
	}

	[Token(Token = "0x6002ECE")]
	[Address(RVA = "0x975D90", Offset = "0x974B90", Length = "0xB7")]
	private void AddRadialSelection(RadialInfo radialInfo, Action callback, bool greyOut = false, bool showHighlight = false)
	{
	}

	[Token(Token = "0x6002ECF")]
	[Address(RVA = "0x975E50", Offset = "0x974C50", Length = "0x76")]
	private void AddRadialSelectionGear(RadialGearDelegate callback, GearItem gi)
	{
	}

	[Token(Token = "0x6002ED0")]
	[Address(RVA = "0x975ED0", Offset = "0x974CD0", Length = "0x16F")]
	public void OnPrevRadial()
	{
	}

	[Token(Token = "0x6002ED1")]
	[Address(RVA = "0x976040", Offset = "0x974E40", Length = "0x14F")]
	public void OnBack()
	{
	}

	[Token(Token = "0x6002ED2")]
	[Address(RVA = "0x976190", Offset = "0x974F90", Length = "0xD8")]
	public void OnBackFinal()
	{
	}

	[Token(Token = "0x6002ED3")]
	[Address(RVA = "0x976270", Offset = "0x975070", Length = "0x6D")]
	public void ShowNotInjuredMessage()
	{
	}

	[Token(Token = "0x6002ED4")]
	[Address(RVA = "0x9762E0", Offset = "0x9750E0", Length = "0x6D")]
	public void ShowNoBedrollMessage()
	{
	}

	[Token(Token = "0x6002ED5")]
	[Address(RVA = "0x976350", Offset = "0x975150", Length = "0x18A")]
	public void ShowNoDecoyMessage()
	{
	}

	[Token(Token = "0x6002ED6")]
	[Address(RVA = "0x9764E0", Offset = "0x9752E0", Length = "0xE6")]
	public void ShowNoCampfireMessage()
	{
	}

	[Token(Token = "0x6002ED7")]
	[Address(RVA = "0x9765D0", Offset = "0x9753D0", Length = "0x6D")]
	public void ShowNoLightSourceMessage()
	{
	}

	[Token(Token = "0x6002ED8")]
	[Address(RVA = "0x976640", Offset = "0x975440", Length = "0x6D")]
	public void ShowNoWeaponMessage()
	{
	}

	[Token(Token = "0x6002ED9")]
	[Address(RVA = "0x9766B0", Offset = "0x9754B0", Length = "0x6D")]
	public void ShowNoToolsMessage()
	{
	}

	[Token(Token = "0x6002EDA")]
	[Address(RVA = "0x976720", Offset = "0x975520", Length = "0x6D")]
	public void ShowNoMapsMessage()
	{
	}

	[Token(Token = "0x6002EDB")]
	[Address(RVA = "0x976790", Offset = "0x975590", Length = "0x3D")]
	public void ShowNotImplemented()
	{
	}

	[Token(Token = "0x6002EDC")]
	[Address(RVA = "0x9767D0", Offset = "0x9755D0", Length = "0x6D")]
	public void ShowNoEmergencyStimMessage()
	{
	}

	[Token(Token = "0x6002EDD")]
	[Address(RVA = "0x976840", Offset = "0x975640", Length = "0x6D")]
	public void ShowNoFirstAidItemsMessage()
	{
	}

	[Token(Token = "0x6002EDE")]
	[Address(RVA = "0x9768B0", Offset = "0x9756B0", Length = "0x6D")]
	public void ShowNoFoodMessage()
	{
	}

	[Token(Token = "0x6002EDF")]
	[Address(RVA = "0x976920", Offset = "0x975720", Length = "0x6D")]
	public void ShowNoDrinkMessage()
	{
	}

	[Token(Token = "0x6002EE0")]
	[Address(RVA = "0x976990", Offset = "0x975790", Length = "0x1B6")]
	public void ShowNoRockCacheMessage()
	{
	}

	[Token(Token = "0x6002EE1")]
	[Address(RVA = "0x976B50", Offset = "0x975950", Length = "0x8A")]
	public void ShowNoIceFishingHoleMessage()
	{
	}

	[Token(Token = "0x6002EE2")]
	[Address(RVA = "0x976BE0", Offset = "0x9759E0", Length = "0x84")]
	public void UseEmergencyStim()
	{
	}

	[Token(Token = "0x6002EE3")]
	[Address(RVA = "0x976C70", Offset = "0x975A70", Length = "0x44")]
	public void StartClothingUI()
	{
	}

	[Token(Token = "0x6002EE4")]
	[Address(RVA = "0x976CC0", Offset = "0x975AC0", Length = "0xE2")]
	public void ShowNoSnowShelterMessage()
	{
	}

	[Token(Token = "0x6002EE5")]
	[Address(RVA = "0x976DB0", Offset = "0x975BB0", Length = "0x100")]
	private void ShowNoSprayPaintMessage()
	{
	}

	[Token(Token = "0x6002EE6")]
	[Address(RVA = "0x976EC0", Offset = "0x975CC0", Length = "0x280")]
	public void UseItem(GearItem gi)
	{
	}

	[Token(Token = "0x6002EE7")]
	[Address(RVA = "0x977150", Offset = "0x975F50", Length = "0xE6")]
	public void ReplaceItemInSatchel(GearItem gi)
	{
	}

	[Token(Token = "0x6002EE8")]
	[Address(RVA = "0x977240", Offset = "0x976040", Length = "0x21E")]
	public void AddItemToSatchel()
	{
	}

	[Token(Token = "0x6002EE9")]
	[Address(RVA = "0x977460", Offset = "0x976260", Length = "0x5A")]
	public void OpenVehicleRest()
	{
	}

	[Token(Token = "0x6002EEA")]
	[Address(RVA = "0x9774C0", Offset = "0x9762C0", Length = "0x61")]
	public void OpenVehicleRest(GearItem gi)
	{
	}

	[Token(Token = "0x6002EEB")]
	[Address(RVA = "0x977530", Offset = "0x976330", Length = "0x5A")]
	public void OpenSnowShelterRest()
	{
	}

	[Token(Token = "0x6002EEC")]
	[Address(RVA = "0x977590", Offset = "0x976390", Length = "0x61")]
	public void OpenSnowShelterRest(GearItem gi)
	{
	}

	[Token(Token = "0x6002EED")]
	[Address(RVA = "0x977600", Offset = "0x976400", Length = "0x73")]
	public void DoPassTime()
	{
	}

	[Token(Token = "0x6002EEE")]
	[Address(RVA = "0x977680", Offset = "0x976480", Length = "0x1E5")]
	public void ShowEatRawMeatConfirmPopup()
	{
	}

	[Token(Token = "0x6002EEF")]
	[Address(RVA = "0x977870", Offset = "0x976670", Length = "0xE8")]
	public void ResetNotificationsData()
	{
	}

	[Token(Token = "0x6002EF0")]
	[Address(RVA = "0x977960", Offset = "0x976760", Length = "0x199")]
	private bool CanPlaceFromRadial(GearItem gi)
	{
		return false;
	}

	[Token(Token = "0x6002EF1")]
	[Address(RVA = "0x977B00", Offset = "0x976900", Length = "0xC6")]
	private bool CanUseFromRadial(GearItem gi)
	{
		return false;
	}

	[Token(Token = "0x6002EF2")]
	[Address(RVA = "0x977BD0", Offset = "0x9769D0", Length = "0x364")]
	private void UpdateButtonLegend()
	{
	}

	[Token(Token = "0x6002EF3")]
	[Address(RVA = "0x977F40", Offset = "0x976D40", Length = "0x40B")]
	private void UpdateButtonStates()
	{
	}

	[Token(Token = "0x6002EF4")]
	[Address(RVA = "0x978350", Offset = "0x977150", Length = "0x22F")]
	private void DetermineHoveredItemState(out bool canPlace, out string useAction)
	{
		canPlace = default(bool);
		useAction = null;
	}

	[Token(Token = "0x6002EF5")]
	[Address(RVA = "0x978580", Offset = "0x977380", Length = "0x32C")]
	private string GetActionText(RadialMenuArm arm)
	{
		return null;
	}

	[Token(Token = "0x6002EF6")]
	[Address(RVA = "0x9788D0", Offset = "0x9776D0", Length = "0xAE")]
	private int StickDirectionToIndex(Vector2 stickVec)
	{
		return 0;
	}

	[Token(Token = "0x6002EF7")]
	[Address(RVA = "0x978980", Offset = "0x977780", Length = "0x36E")]
	private int MousePosToIndex()
	{
		return 0;
	}

	[Token(Token = "0x6002EF8")]
	[Address(RVA = "0x978CF0", Offset = "0x977AF0", Length = "0x45")]
	private void ErrorAction()
	{
	}

	[Token(Token = "0x6002EF9")]
	[Address(RVA = "0x978D40", Offset = "0x977B40", Length = "0x7E8")]
	private Action GetDelegateForRadial(RadialType radialType)
	{
		return null;
	}

	[Token(Token = "0x6002EFA")]
	[Address(RVA = "0x9795A0", Offset = "0x9783A0", Length = "0x7E0")]
	private bool GetShouldGreyOut(RadialType radialType)
	{
		return false;
	}

	[Token(Token = "0x6002EFB")]
	[Address(RVA = "0x979E00", Offset = "0x978C00", Length = "0xD9")]
	private bool ShouldShowNewItemHighlight(RadialType radialType)
	{
		return false;
	}

	[Token(Token = "0x6002EFC")]
	[Address(RVA = "0x979EE0", Offset = "0x978CE0", Length = "0x91A")]
	private void UpdateDisplayText()
	{
	}

	[Token(Token = "0x6002EFD")]
	[Address(RVA = "0x97A800", Offset = "0x979600", Length = "0x77")]
	private void UpdateCurrentTimeLabel()
	{
	}

	[Token(Token = "0x6002EFE")]
	[Address(RVA = "0x97A880", Offset = "0x979680", Length = "0x259")]
	private void ShowGearRadial(List<GearItem> gearItems, Action noItemsAction)
	{
	}

	[Token(Token = "0x6002EFF")]
	[Address(RVA = "0x97AAE0", Offset = "0x9798E0", Length = "0x3C0")]
	private List<GearItem> GetFoodItemsInInventory()
	{
		return null;
	}

	[Token(Token = "0x6002F00")]
	[Address(RVA = "0x97AEB0", Offset = "0x979CB0", Length = "0x4E0")]
	private List<GearItem> GetDrinkItemsInInventory()
	{
		return null;
	}

	[Token(Token = "0x6002F01")]
	[Address(RVA = "0x97B3A0", Offset = "0x97A1A0", Length = "0x41D")]
	private List<GearItem> GetFirstAidItemsInInventory()
	{
		return null;
	}

	[Token(Token = "0x6002F02")]
	[Address(RVA = "0x97B7C0", Offset = "0x97A5C0", Length = "0x2FF")]
	private void UpdateFadeOverlay()
	{
	}

	[Token(Token = "0x6002F03")]
	[Address(RVA = "0x97BAC0", Offset = "0x97A8C0", Length = "0x8AB")]
	private void UpdateStackStatus(GearItem gi)
	{
	}

	[Token(Token = "0x6002F04")]
	[Address(RVA = "0x97C370", Offset = "0x97B170", Length = "0x5D")]
	private void UpdateHotColdStatus(GearItem gi)
	{
	}

	[Token(Token = "0x6002F05")]
	[Address(RVA = "0x97C3D0", Offset = "0x97B1D0", Length = "0x2F0")]
	private void UpdateAndEnableStackStatus(string text, string spriteName, Color c)
	{
	}

	[Token(Token = "0x6002F06")]
	[Address(RVA = "0x97C6D0", Offset = "0x97B4D0", Length = "0x2AD")]
	private void UpdateMissionInfo()
	{
	}

	[Token(Token = "0x6002F07")]
	[Address(RVA = "0x97C980", Offset = "0x97B780", Length = "0xE2")]
	private void ForceRadialMenuArmCallback()
	{
	}

	[Token(Token = "0x6002F08")]
	[Address(RVA = "0x97CA70", Offset = "0x97B870", Length = "0x4C7")]
	public Panel_ActionsRadial()
	{
	}
}
