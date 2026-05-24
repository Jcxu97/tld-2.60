using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.Gear;
using TLD.UI;
using TLD.UI.Generics;
using UnityEngine;

[Token(Token = "0x200066F")]
public class Panel_Inventory_Examine : Panel_AutoReferenced, IAccelerateTimeProvider
{
	[Token(Token = "0x2000670")]
	private delegate void OnMethod();

	[Token(Token = "0x2000671")]
	private enum ButtonChoice
	{
		[Token(Token = "0x400417E")]
		Refuel,
		[Token(Token = "0x400417F")]
		SafehouseCustomizationRepair,
		[Token(Token = "0x4004180")]
		Repair,
		[Token(Token = "0x4004181")]
		Clean,
		[Token(Token = "0x4004182")]
		Sharpen,
		[Token(Token = "0x4004183")]
		Harvest,
		[Token(Token = "0x4004184")]
		Unload,
		[Token(Token = "0x4004185")]
		Read
	}

	[Token(Token = "0x40040CB")]
	[FieldOffset(Offset = "0x30")]
	public ButtonLegendContainer m_ButtonLegendContainer;

	[HideInInspector]
	[Token(Token = "0x40040CC")]
	[FieldOffset(Offset = "0x38")]
	public GameObject m_FireContainer;

	[Token(Token = "0x40040CD")]
	[FieldOffset(Offset = "0x40")]
	public UIWidget m_ExamineWidget;

	[Header("Windows")]
	[Token(Token = "0x40040CE")]
	[FieldOffset(Offset = "0x48")]
	public GameObject m_MainWindow;

	[Token(Token = "0x40040CF")]
	[FieldOffset(Offset = "0x50")]
	public GameObject m_HarvestWindow;

	[Token(Token = "0x40040D0")]
	[FieldOffset(Offset = "0x58")]
	public GameObject m_RepairPanel;

	[Token(Token = "0x40040D1")]
	[FieldOffset(Offset = "0x60")]
	public GameObject m_CleanPanel;

	[Token(Token = "0x40040D2")]
	[FieldOffset(Offset = "0x68")]
	public GameObject m_SharpenPanel;

	[Token(Token = "0x40040D3")]
	[FieldOffset(Offset = "0x70")]
	public GameObject m_RifleUnloadPanel;

	[Token(Token = "0x40040D4")]
	[FieldOffset(Offset = "0x78")]
	public GameObject m_ReadPanel;

	[Token(Token = "0x40040D5")]
	[FieldOffset(Offset = "0x80")]
	public GameObject m_ActionInProgressWindow;

	[Token(Token = "0x40040D6")]
	[FieldOffset(Offset = "0x88")]
	public ScrollList m_ToolScrollList;

	[Token(Token = "0x40040D7")]
	[FieldOffset(Offset = "0x90")]
	public MaterialsTable m_RepairMaterialsTable;

	[Token(Token = "0x40040D8")]
	[FieldOffset(Offset = "0x98")]
	public MaterialsTable m_SafehouseCustomizationRepairMaterialsTable;

	[Token(Token = "0x40040D9")]
	[FieldOffset(Offset = "0xA0")]
	public ToolsList m_RepairToolsList;

	[Token(Token = "0x40040DA")]
	[FieldOffset(Offset = "0xA8")]
	public ToolsList m_SafehouseCustomizationRepairToolsList;

	[Header("Buttons")]
	[Token(Token = "0x40040DB")]
	[FieldOffset(Offset = "0xB0")]
	public UIButton m_Button_Harvest;

	[Token(Token = "0x40040DC")]
	[FieldOffset(Offset = "0xB8")]
	public UIButton m_Button_Repair;

	[Token(Token = "0x40040DD")]
	[FieldOffset(Offset = "0xC0")]
	public UIButton m_Button_SafehouseCustomizationRepair;

	[Token(Token = "0x40040DE")]
	[FieldOffset(Offset = "0xC8")]
	public UIButton m_Button_Refuel;

	[Token(Token = "0x40040DF")]
	[FieldOffset(Offset = "0xD0")]
	public UIButton m_Button_Unload;

	[Token(Token = "0x40040E0")]
	[FieldOffset(Offset = "0xD8")]
	public UIButton m_Button_Clean;

	[Token(Token = "0x40040E1")]
	[FieldOffset(Offset = "0xE0")]
	public UIButton m_Button_Sharpen;

	[Header("Button Backgrounds")]
	[Token(Token = "0x40040E2")]
	[FieldOffset(Offset = "0xE8")]
	public GameObject m_Button_HarvestBackground;

	[Token(Token = "0x40040E3")]
	[FieldOffset(Offset = "0xF0")]
	public GameObject m_Button_RepairBackground;

	[Token(Token = "0x40040E4")]
	[FieldOffset(Offset = "0xF8")]
	public GameObject m_Button_RefuelBackground;

	[Token(Token = "0x40040E5")]
	[FieldOffset(Offset = "0x100")]
	public GameObject m_Button_UnloadBackground;

	[Token(Token = "0x40040E6")]
	[FieldOffset(Offset = "0x108")]
	public GameObject m_Button_CleanBackground;

	[Token(Token = "0x40040E7")]
	[FieldOffset(Offset = "0x110")]
	public GameObject m_Button_SharpenBackground;

	[Token(Token = "0x40040E8")]
	[FieldOffset(Offset = "0x118")]
	public GameObject m_GeneralBackground;

	[Header("Items")]
	[Token(Token = "0x40040E9")]
	[FieldOffset(Offset = "0x120")]
	public UISprite[] m_ItemIcons;

	[Token(Token = "0x40040EA")]
	[FieldOffset(Offset = "0x128")]
	public UILabel m_Item_Label;

	[Token(Token = "0x40040EB")]
	[FieldOffset(Offset = "0x130")]
	public UITexture m_GearItemTexture;

	[Token(Token = "0x40040EC")]
	[FieldOffset(Offset = "0x138")]
	public Transform m_ButtonTopLeftLocation;

	[Token(Token = "0x40040ED")]
	[FieldOffset(Offset = "0x140")]
	public float m_ButtonSpacing;

	[Token(Token = "0x40040EE")]
	[FieldOffset(Offset = "0x148")]
	public GameObject m_MainWindow_Buttons;

	[Token(Token = "0x40040EF")]
	[FieldOffset(Offset = "0x150")]
	public GameObject m_GearStats;

	[Token(Token = "0x40040F0")]
	[FieldOffset(Offset = "0x158")]
	public UILabel m_Stack_Label;

	[Header("Repair")]
	[Token(Token = "0x40040F1")]
	[FieldOffset(Offset = "0x160")]
	public UILabel m_Repair_SkillLabel;

	[Token(Token = "0x40040F2")]
	[FieldOffset(Offset = "0x168")]
	public UILabel m_Repair_AmountLabel;

	[Token(Token = "0x40040F3")]
	[FieldOffset(Offset = "0x170")]
	public UILabel m_Repair_ChanceSuccessLabel;

	[Token(Token = "0x40040F4")]
	[FieldOffset(Offset = "0x178")]
	public UILabel m_Repair_ConditionCapLabel;

	[Token(Token = "0x40040F5")]
	[FieldOffset(Offset = "0x180")]
	public UILabel m_Repair_TimeLabel;

	[Token(Token = "0x40040F6")]
	[FieldOffset(Offset = "0x188")]
	public float m_SkillIncreaseChanceOnSuccess;

	[Token(Token = "0x40040F7")]
	[FieldOffset(Offset = "0x18C")]
	public float m_SkillIncreaseChanceOnFailure;

	[Token(Token = "0x40040F8")]
	[FieldOffset(Offset = "0x190")]
	public float m_RepairTimeSeconds;

	[Token(Token = "0x40040F9")]
	[FieldOffset(Offset = "0x194")]
	public Color m_RepairLabelColorNormal;

	[Token(Token = "0x40040FA")]
	[FieldOffset(Offset = "0x1A4")]
	public Color m_RepairLabelColorNormalHover;

	[Token(Token = "0x40040FB")]
	[FieldOffset(Offset = "0x1B4")]
	public Color m_RepairLabelColorNormalSelected;

	[Token(Token = "0x40040FC")]
	[FieldOffset(Offset = "0x1C4")]
	public Color m_RepairLabelColorDisabled;

	[Token(Token = "0x40040FD")]
	[FieldOffset(Offset = "0x1D4")]
	public Color m_RepairLabelColorDisabledHover;

	[Token(Token = "0x40040FE")]
	[FieldOffset(Offset = "0x1E4")]
	public Color m_RepairLabelColorDisabledSelected;

	[Token(Token = "0x40040FF")]
	[FieldOffset(Offset = "0x1F4")]
	public Color m_HighConditionColor;

	[Token(Token = "0x4004100")]
	[FieldOffset(Offset = "0x208")]
	public UILabel m_RequiresToolLabel;

	[Token(Token = "0x4004101")]
	[FieldOffset(Offset = "0x210")]
	public GameObject m_RepairPanel_Buttons;

	[Token(Token = "0x4004102")]
	[FieldOffset(Offset = "0x218")]
	public GameObject m_MouseRepairButton;

	[Token(Token = "0x4004103")]
	[FieldOffset(Offset = "0x220")]
	public ToolsItem m_SewingKitToolsItem;

	[Header("Safehouse CustomizationRepair")]
	[Token(Token = "0x4004104")]
	[FieldOffset(Offset = "0x228")]
	public GameObject m_SafehouseCustomizationRepairPanel;

	[Token(Token = "0x4004105")]
	[FieldOffset(Offset = "0x230")]
	public UILabel m_SafehouseCustomizationRepair_SkillLabel;

	[Token(Token = "0x4004106")]
	[FieldOffset(Offset = "0x238")]
	public UILabel m_SafehouseCustomizationRepair_TimeLabel;

	[Token(Token = "0x4004107")]
	[FieldOffset(Offset = "0x240")]
	public GameObject m_SafehouseCustomizationRepairPanel_Buttons;

	[Token(Token = "0x4004108")]
	[FieldOffset(Offset = "0x248")]
	public GameObject m_MouseSafehouseRepairButton;

	[Token(Token = "0x4004109")]
	[FieldOffset(Offset = "0x250")]
	public UILabel m_SafehouseCustomizationRepairRequiresToolLabel;

	[Token(Token = "0x400410A")]
	[FieldOffset(Offset = "0x258")]
	public GameObject m_SafehouseCustomizationRepair_Background;

	[SerializeField]
	[Token(Token = "0x400410B")]
	[FieldOffset(Offset = "0x260")]
	private float m_SafehouseCustomizationRepairElementOffset;

	[Header("Clean")]
	[Token(Token = "0x400410C")]
	[FieldOffset(Offset = "0x268")]
	public UISprite m_Clean_X;

	[Token(Token = "0x400410D")]
	[FieldOffset(Offset = "0x270")]
	public UILabel m_Clean_SkillLabel;

	[Token(Token = "0x400410E")]
	[FieldOffset(Offset = "0x278")]
	public UILabel m_Clean_AmountLabel;

	[Token(Token = "0x400410F")]
	[FieldOffset(Offset = "0x280")]
	public UILabel m_Clean_ChanceSuccessLabel;

	[Token(Token = "0x4004110")]
	[FieldOffset(Offset = "0x288")]
	public UILabel m_Clean_TimeLabel;

	[Token(Token = "0x4004111")]
	[FieldOffset(Offset = "0x290")]
	public UITexture m_CleanRequiresToolSprite;

	[Token(Token = "0x4004112")]
	[FieldOffset(Offset = "0x298")]
	public UILabel m_CleanRequiresToolNameLabel;

	[Token(Token = "0x4004113")]
	[FieldOffset(Offset = "0x2A0")]
	public UILabel m_CleanRequiresToolLabel;

	[Token(Token = "0x4004114")]
	[FieldOffset(Offset = "0x2A8")]
	public GameObject m_CleanPanel_Buttons;

	[Token(Token = "0x4004115")]
	[FieldOffset(Offset = "0x2B0")]
	public GameObject m_MouseCleanButton;

	[Token(Token = "0x4004116")]
	[FieldOffset(Offset = "0x2B8")]
	public float m_Clean_SkillIncreaseChanceOnSuccess;

	[Token(Token = "0x4004117")]
	[FieldOffset(Offset = "0x2BC")]
	public float m_Clean_SkillIncreaseChanceOnFailure;

	[Token(Token = "0x4004118")]
	[FieldOffset(Offset = "0x2C0")]
	public float m_CleanTimeSeconds;

	[Header("Sharpen")]
	[Token(Token = "0x4004119")]
	[FieldOffset(Offset = "0x2C8")]
	public UISprite m_Sharpen_X;

	[Token(Token = "0x400411A")]
	[FieldOffset(Offset = "0x2D0")]
	public UILabel m_Sharpen_SkillLabel;

	[Token(Token = "0x400411B")]
	[FieldOffset(Offset = "0x2D8")]
	public UILabel m_Sharpen_AmountLabel;

	[Token(Token = "0x400411C")]
	[FieldOffset(Offset = "0x2E0")]
	public UILabel m_Sharpen_ChanceSuccessLabel;

	[Token(Token = "0x400411D")]
	[FieldOffset(Offset = "0x2E8")]
	public UILabel m_Sharpen_TimeLabel;

	[Token(Token = "0x400411E")]
	[FieldOffset(Offset = "0x2F0")]
	public UITexture m_SharpenRequiresToolSprite;

	[Token(Token = "0x400411F")]
	[FieldOffset(Offset = "0x2F8")]
	public UILabel m_SharpenRequiresToolNameLabel;

	[Token(Token = "0x4004120")]
	[FieldOffset(Offset = "0x300")]
	public UILabel m_SharpenRequiresToolLabel;

	[Token(Token = "0x4004121")]
	[FieldOffset(Offset = "0x308")]
	public GameObject m_SharpenPanel_Buttons;

	[Token(Token = "0x4004122")]
	[FieldOffset(Offset = "0x310")]
	public GameObject m_MouseSharpenButton;

	[Token(Token = "0x4004123")]
	[FieldOffset(Offset = "0x318")]
	public float m_Sharpen_SkillIncreaseChanceOnSuccess;

	[Token(Token = "0x4004124")]
	[FieldOffset(Offset = "0x31C")]
	public float m_Sharpen_SkillIncreaseChanceOnFailure;

	[Token(Token = "0x4004125")]
	[FieldOffset(Offset = "0x320")]
	public float m_SharpenTimeSeconds;

	[Header("Read")]
	[Token(Token = "0x4004126")]
	[FieldOffset(Offset = "0x328")]
	public UISprite m_ResearchIcon;

	[Token(Token = "0x4004127")]
	[FieldOffset(Offset = "0x330")]
	public GameObject m_MouseReadButton;

	[Token(Token = "0x4004128")]
	[FieldOffset(Offset = "0x338")]
	public UILabel m_BookNameLabel;

	[Token(Token = "0x4004129")]
	[FieldOffset(Offset = "0x340")]
	public UILabel m_BookDescLabel;

	[Token(Token = "0x400412A")]
	[FieldOffset(Offset = "0x348")]
	public UILabel m_SkillImprovedLabel;

	[Token(Token = "0x400412B")]
	[FieldOffset(Offset = "0x350")]
	public UILabel m_TimeToReadRemainingLabel;

	[Token(Token = "0x400412C")]
	[FieldOffset(Offset = "0x358")]
	public UILabel m_TimeToReadLabel;

	[Token(Token = "0x400412D")]
	[FieldOffset(Offset = "0x360")]
	public UILabel m_SkillLevelLabel;

	[Token(Token = "0x400412E")]
	[FieldOffset(Offset = "0x368")]
	public UILabel m_SkillProgressBarLabel;

	[Token(Token = "0x400412F")]
	[FieldOffset(Offset = "0x370")]
	public UIProgressBar m_SkillProgressBar;

	[Token(Token = "0x4004130")]
	[FieldOffset(Offset = "0x378")]
	public UISprite m_SkillProgressBarSprite;

	[Token(Token = "0x4004131")]
	[FieldOffset(Offset = "0x380")]
	public UIButton m_ReadHoursIncrease;

	[Token(Token = "0x4004132")]
	[FieldOffset(Offset = "0x388")]
	public UIButton m_ReadHoursDecrease;

	[Token(Token = "0x4004133")]
	[FieldOffset(Offset = "0x390")]
	public UISprite m_GamepadReadHoursSpriteIncrease;

	[Token(Token = "0x4004134")]
	[FieldOffset(Offset = "0x398")]
	public UISprite m_GamepadReadHoursSpriteDecrease;

	[Token(Token = "0x4004135")]
	[FieldOffset(Offset = "0x3A0")]
	public float m_ReadTimeSeconds;

	[Token(Token = "0x4004136")]
	[FieldOffset(Offset = "0x3A8")]
	public GameObject m_BonusFeatRoot;

	[Header("Tools")]
	[Token(Token = "0x4004137")]
	[FieldOffset(Offset = "0x3B0")]
	public UILabel m_Tool_ConfirmButtonLabel;

	[Header("Item Stats")]
	[Token(Token = "0x4004138")]
	[FieldOffset(Offset = "0x3B8")]
	public GameObject m_ItemConditionObject;

	[Token(Token = "0x4004139")]
	[FieldOffset(Offset = "0x3C0")]
	public UISprite m_ConditionSprite;

	[Token(Token = "0x400413A")]
	[FieldOffset(Offset = "0x3C8")]
	public UILabel m_ConditionLabel;

	[Token(Token = "0x400413B")]
	[FieldOffset(Offset = "0x3D0")]
	public UILabel m_WeightLabel;

	[Header("Harvest")]
	[Token(Token = "0x400413C")]
	[FieldOffset(Offset = "0x3D8")]
	public UILabel m_HarvestItemName_Label;

	[Token(Token = "0x400413D")]
	[FieldOffset(Offset = "0x3E0")]
	public UILabel m_HarvestTime_Label;

	[SerializeField]
	[Token(Token = "0x400413E")]
	[FieldOffset(Offset = "0x3E8")]
	private float m_HarvestTwoYieldSpacing;

	[SerializeField]
	[Token(Token = "0x400413F")]
	[FieldOffset(Offset = "0x3EC")]
	private float m_HarvestThreeYieldSpacing;

	[Token(Token = "0x4004140")]
	[FieldOffset(Offset = "0x3F0")]
	public HarvestRepairMaterial[] m_HarvestYields;

	[Token(Token = "0x4004141")]
	[FieldOffset(Offset = "0x3F8")]
	public float m_HarvestTimeSeconds;

	[Token(Token = "0x4004142")]
	[FieldOffset(Offset = "0x400")]
	public UILabel m_HarvestRequiresToolLabel;

	[Header("Refuel")]
	[SerializeField]
	[Token(Token = "0x4004143")]
	[FieldOffset(Offset = "0x408")]
	private LiquidType m_Kerosene;

	[Token(Token = "0x4004144")]
	[FieldOffset(Offset = "0x410")]
	public GameObject m_RefuelPanel;

	[Token(Token = "0x4004145")]
	[FieldOffset(Offset = "0x418")]
	public UISprite m_Refuel_X;

	[Token(Token = "0x4004146")]
	[FieldOffset(Offset = "0x420")]
	public GameObject m_RequiresFuelMessage;

	[Token(Token = "0x4004147")]
	[FieldOffset(Offset = "0x428")]
	public GameObject m_ControllerRefuelButton;

	[Token(Token = "0x4004148")]
	[FieldOffset(Offset = "0x430")]
	public GameObject m_MouseRefuelButton;

	[Token(Token = "0x4004149")]
	[FieldOffset(Offset = "0x438")]
	public UILabel m_LanternFuelAmountLabel;

	[Token(Token = "0x400414A")]
	[FieldOffset(Offset = "0x440")]
	public UILabel m_FuelSupplyAmountLabel;

	[Header("Progress Bar")]
	[Token(Token = "0x400414B")]
	[FieldOffset(Offset = "0x448")]
	public UISlider m_Slider_ActionProgress;

	[Token(Token = "0x400414C")]
	[FieldOffset(Offset = "0x450")]
	public UILabel m_ProgressBarLabelRepair;

	[Token(Token = "0x400414D")]
	[FieldOffset(Offset = "0x458")]
	public UILabel m_ProgressBarLabelHarvest;

	[Token(Token = "0x400414E")]
	[FieldOffset(Offset = "0x460")]
	public GameObject[] m_ButtonsToDisableDuringProgressBar;

	[Header("Progress Icons")]
	[Token(Token = "0x400414F")]
	[FieldOffset(Offset = "0x468")]
	public string m_IconNameHarvestingItem;

	[Token(Token = "0x4004150")]
	[FieldOffset(Offset = "0x470")]
	public string m_IconNameRepairingItem;

	[Token(Token = "0x4004151")]
	[FieldOffset(Offset = "0x478")]
	public string m_IconNameSafehouseCustomizatioRepairing;

	[Token(Token = "0x4004152")]
	[FieldOffset(Offset = "0x480")]
	public string m_IconNameCleaningRifle;

	[Token(Token = "0x4004153")]
	[FieldOffset(Offset = "0x488")]
	public string m_IconNameSharpening;

	[Token(Token = "0x4004154")]
	[FieldOffset(Offset = "0x490")]
	public string m_IconNameResearching;

	[Header("Panel References")]
	[SerializeField]
	[Token(Token = "0x4004155")]
	[FieldOffset(Offset = "0x498")]
	private PanelReference<Panel_Clothing> m_Clothing;

	[SerializeField]
	[Token(Token = "0x4004156")]
	[FieldOffset(Offset = "0x4A0")]
	private PanelReference<Panel_GenericProgressBar> m_GenericProgressBar;

	[SerializeField]
	[Token(Token = "0x4004157")]
	[FieldOffset(Offset = "0x4A8")]
	private PanelReference<Panel_Inventory> m_Inventory;

	[Token(Token = "0x4004158")]
	[FieldOffset(Offset = "0x4B0")]
	private GearItem m_GearItem;

	[HideInInspector]
	[Token(Token = "0x4004159")]
	[FieldOffset(Offset = "0x4B8")]
	public IRepairable m_Repairable;

	[HideInInspector]
	[Token(Token = "0x400415A")]
	[FieldOffset(Offset = "0x4C0")]
	public bool m_EnableInventoryOnBack;

	[Token(Token = "0x400415B")]
	[FieldOffset(Offset = "0x4C1")]
	private bool m_HarvestInProgress;

	[Token(Token = "0x400415C")]
	[FieldOffset(Offset = "0x4C4")]
	private int m_NumUnitsLeftToHarvest;

	[Token(Token = "0x400415D")]
	[FieldOffset(Offset = "0x4C8")]
	private bool m_ItemHarvestable;

	[Token(Token = "0x400415E")]
	[FieldOffset(Offset = "0x4CC")]
	private float m_ElapsedProgressBarSeconds;

	[Token(Token = "0x400415F")]
	[FieldOffset(Offset = "0x4D0")]
	private float m_ProgressBarTimeSeconds;

	[Token(Token = "0x4004160")]
	[FieldOffset(Offset = "0x4D4")]
	private uint m_ProgressBarAudio;

	[Token(Token = "0x4004161")]
	[FieldOffset(Offset = "0x4D8")]
	private bool m_ItemSharpenable;

	[Token(Token = "0x4004162")]
	[FieldOffset(Offset = "0x4D9")]
	private bool m_SharpenInProgress;

	[Token(Token = "0x4004163")]
	[FieldOffset(Offset = "0x4DA")]
	private bool m_ReadInProgress;

	[Token(Token = "0x4004164")]
	[FieldOffset(Offset = "0x4DC")]
	private int m_HoursToRead;

	[Token(Token = "0x4004165")]
	[FieldOffset(Offset = "0x4E0")]
	private bool m_GearItemRepair;

	[Token(Token = "0x4004166")]
	[FieldOffset(Offset = "0x4E1")]
	private bool m_SafehouseCustomizationRepair;

	[Token(Token = "0x4004167")]
	[FieldOffset(Offset = "0x4E2")]
	private bool m_RepairInProgress;

	[Token(Token = "0x4004168")]
	[FieldOffset(Offset = "0x4E3")]
	private bool m_RepairWillSucceed;

	[Token(Token = "0x4004169")]
	[FieldOffset(Offset = "0x4E4")]
	private bool m_ItemCleanable;

	[Token(Token = "0x400416A")]
	[FieldOffset(Offset = "0x4E5")]
	private bool m_CleanInProgress;

	[Token(Token = "0x400416B")]
	[FieldOffset(Offset = "0x4E8")]
	private int m_SelectedToolIndex;

	[Token(Token = "0x400416C")]
	[FieldOffset(Offset = "0x4EC")]
	private float m_FailureAtProgressPercentage;

	[Token(Token = "0x400416D")]
	[FieldOffset(Offset = "0x4F0")]
	private float m_DayLengthScaleBeforeRepair;

	[Token(Token = "0x400416E")]
	[FieldOffset(Offset = "0x4F4")]
	private bool m_TimeAccelerated;

	[Token(Token = "0x400416F")]
	[FieldOffset(Offset = "0x4F8")]
	private Panel_Inventory_Examine_MenuItem m_MenuItemClean;

	[Token(Token = "0x4004170")]
	[FieldOffset(Offset = "0x500")]
	private Panel_Inventory_Examine_MenuItem m_MenuItemHarvest;

	[Token(Token = "0x4004171")]
	[FieldOffset(Offset = "0x508")]
	private Panel_Inventory_Examine_MenuItem m_MenuItemRefuel;

	[Token(Token = "0x4004172")]
	[FieldOffset(Offset = "0x510")]
	private Panel_Inventory_Examine_MenuItem m_MenuItemRepair;

	[Token(Token = "0x4004173")]
	[FieldOffset(Offset = "0x518")]
	private Panel_Inventory_Examine_MenuItem m_MenuItemSafehouseCustomizationRepair;

	[Token(Token = "0x4004174")]
	[FieldOffset(Offset = "0x520")]
	private Panel_Inventory_Examine_MenuItem m_MenuItemSharpen;

	[Token(Token = "0x4004175")]
	[FieldOffset(Offset = "0x528")]
	private Panel_Inventory_Examine_MenuItem m_MenuItemUnload;

	[Token(Token = "0x4004176")]
	[FieldOffset(Offset = "0x530")]
	private List<UIButton> m_Buttons;

	[Token(Token = "0x4004177")]
	[FieldOffset(Offset = "0x538")]
	private List<Panel_Inventory_Examine_MenuItem> m_ButtonsMenuItems;

	[Token(Token = "0x4004178")]
	[FieldOffset(Offset = "0x540")]
	private List<OnMethod> m_ButtonDelegates;

	[Token(Token = "0x4004179")]
	[FieldOffset(Offset = "0x548")]
	private int m_SelectedButtonIndex;

	[Token(Token = "0x400417A")]
	[FieldOffset(Offset = "0x54C")]
	private bool m_IsInInspectGearMode;

	[Token(Token = "0x400417B")]
	[FieldOffset(Offset = "0x550")]
	private ComingFromScreenCategory m_CameFromScreenCategory;

	[Token(Token = "0x400417C")]
	[FieldOffset(Offset = "0x554")]
	private bool m_ToolWindowActive;

	[Token(Token = "0x170002FD")]
	public GearItem GearItem
	{
		[Token(Token = "0x60035AB")]
		[Address(RVA = "0xA8A380", Offset = "0xA89180", Length = "0x8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60035AC")]
	[Address(RVA = "0xA8A390", Offset = "0xA89190", Length = "0x19")]
	private UILabel GetToolsRequiredLabel()
	{
		return null;
	}

	[Token(Token = "0x60035AD")]
	[Address(RVA = "0xA8A3B0", Offset = "0xA891B0", Length = "0x19")]
	private ToolsList GetToolsList()
	{
		return null;
	}

	[Token(Token = "0x60035AE")]
	[Address(RVA = "0xA8A3D0", Offset = "0xA891D0", Length = "0x19")]
	private UILabel GetRepairSkillLabel()
	{
		return null;
	}

	[Token(Token = "0x60035AF")]
	[Address(RVA = "0xA8A3F0", Offset = "0xA891F0", Length = "0x19")]
	private UILabel GetRepairTimeLabel()
	{
		return null;
	}

	[Token(Token = "0x60035B0")]
	[Address(RVA = "0xA8A410", Offset = "0xA89210", Length = "0x16")]
	private GameObject GetRepairPanel()
	{
		return null;
	}

	[Token(Token = "0x60035B1")]
	[Address(RVA = "0xA8A430", Offset = "0xA89230", Length = "0x19")]
	private MaterialsTable GetMaterialsTable()
	{
		return null;
	}

	[Token(Token = "0x60035B2")]
	[Address(RVA = "0xA8A450", Offset = "0xA89250", Length = "0x32")]
	private GameObject GetActionToolSelect()
	{
		return null;
	}

	[Token(Token = "0x60035B3")]
	[Address(RVA = "0xA8A490", Offset = "0xA89290", Length = "0xFE2")]
	public override void Initialize()
	{
	}

	[Token(Token = "0x60035B4")]
	[Address(RVA = "0xA8B480", Offset = "0xA8A280", Length = "0xB")]
	public override void Enable(bool enable)
	{
	}

	[Token(Token = "0x60035B5")]
	[Address(RVA = "0xA8B490", Offset = "0xA8A290", Length = "0x520")]
	public void Enable(bool enable, ComingFromScreenCategory cameFrom)
	{
	}

	[Token(Token = "0x60035B6")]
	[Address(RVA = "0xA8B9C0", Offset = "0xA8A7C0", Length = "0x8")]
	public bool IsHarvesting()
	{
		return false;
	}

	[Token(Token = "0x60035B7")]
	[Address(RVA = "0xA8B9D0", Offset = "0xA8A7D0", Length = "0x8")]
	public bool IsRepairing()
	{
		return false;
	}

	[Token(Token = "0x60035B8")]
	[Address(RVA = "0xA8B9E0", Offset = "0xA8A7E0", Length = "0x8")]
	public bool IsCleaning()
	{
		return false;
	}

	[Token(Token = "0x60035B9")]
	[Address(RVA = "0xA8B9F0", Offset = "0xA8A7F0", Length = "0x8")]
	public bool IsSharpening()
	{
		return false;
	}

	[Token(Token = "0x60035BA")]
	[Address(RVA = "0xA8BA00", Offset = "0xA8A800", Length = "0x8")]
	public bool IsReading()
	{
		return false;
	}

	[Token(Token = "0x60035BB")]
	[Address(RVA = "0xA8BA10", Offset = "0xA8A810", Length = "0x680")]
	private void Update()
	{
	}

	[Token(Token = "0x60035BC")]
	[Address(RVA = "0xA8C0A0", Offset = "0xA8AEA0", Length = "0x4ED")]
	private void UpdateLabels()
	{
	}

	[Token(Token = "0x60035BD")]
	[Address(RVA = "0xA8C590", Offset = "0xA8B390", Length = "0x8F1")]
	private void UpdateMainWindowNavigation()
	{
	}

	[Token(Token = "0x60035BE")]
	[Address(RVA = "0xA8CE90", Offset = "0xA8BC90", Length = "0x2A9")]
	private void UpdateReadPanelNavigation()
	{
	}

	[Token(Token = "0x60035BF")]
	[Address(RVA = "0xA8D140", Offset = "0xA8BF40", Length = "0x364")]
	private void CheckSelectedButton()
	{
	}

	[Token(Token = "0x60035C0")]
	[Address(RVA = "0xA8D4B0", Offset = "0xA8C2B0", Length = "0xC")]
	public void OnToolSelectBack()
	{
	}

	[Token(Token = "0x60035C1")]
	[Address(RVA = "0xA8D4C0", Offset = "0xA8C2C0", Length = "0x891")]
	private void UpdateMainAndToolHybrid()
	{
	}

	[Token(Token = "0x60035C2")]
	[Address(RVA = "0xA8DD60", Offset = "0xA8CB60", Length = "0x119")]
	private void SetRepairInProgress(bool on)
	{
	}

	[Token(Token = "0x60035C3")]
	[Address(RVA = "0xA8DE80", Offset = "0xA8CC80", Length = "0x10B")]
	private void SetHarvestInProgress(bool on)
	{
	}

	[Token(Token = "0x60035C4")]
	[Address(RVA = "0xA8DF90", Offset = "0xA8CD90", Length = "0x119")]
	private void SetCleanInProgress(bool on)
	{
	}

	[Token(Token = "0x60035C5")]
	[Address(RVA = "0xA8E0B0", Offset = "0xA8CEB0", Length = "0x119")]
	private void SetSharpenInProgress(bool on)
	{
	}

	[Token(Token = "0x60035C6")]
	[Address(RVA = "0xA8E1D0", Offset = "0xA8CFD0", Length = "0x119")]
	private void SetReadInProgress(bool on)
	{
	}

	[Token(Token = "0x60035C7")]
	[Address(RVA = "0xA8E2F0", Offset = "0xA8D0F0", Length = "0x7A9")]
	private void UpdateActionProgressBar()
	{
	}

	[Token(Token = "0x60035C8")]
	[Address(RVA = "0xA8EAA0", Offset = "0xA8D8A0", Length = "0x77")]
	private void RestoreTimeOfDay()
	{
	}

	[Token(Token = "0x60035C9")]
	[Address(RVA = "0xA8EB20", Offset = "0xA8D920", Length = "0xB8")]
	private void AccelerateTimeOfDay(int minutes, bool doFadeout)
	{
	}

	[Token(Token = "0x60035CA")]
	[Address(RVA = "0xA8EBE0", Offset = "0xA8D9E0", Length = "0x3AA")]
	private void DegradeToolUsedForAction()
	{
	}

	[Token(Token = "0x60035CB")]
	[Address(RVA = "0xA8EF90", Offset = "0xA8DD90", Length = "0x39A")]
	private void ConsumeMaterialsUsedForRepair()
	{
	}

	[Token(Token = "0x60035CC")]
	[Address(RVA = "0xA8F330", Offset = "0xA8E130", Length = "0x57")]
	private void StopProgressBarAudio()
	{
	}

	[Token(Token = "0x60035CD")]
	[Address(RVA = "0xA8F390", Offset = "0xA8E190", Length = "0x1E6")]
	private void RepairFinished()
	{
	}

	[Token(Token = "0x60035CE")]
	[Address(RVA = "0xA8F580", Offset = "0xA8E380", Length = "0x11F")]
	private void RepairFailed()
	{
	}

	[Token(Token = "0x60035CF")]
	[Address(RVA = "0xA8F6A0", Offset = "0xA8E4A0", Length = "0x5CD")]
	private void RepairSuccessful()
	{
	}

	[Token(Token = "0x60035D0")]
	[Address(RVA = "0xA8FC70", Offset = "0xA8EA70", Length = "0x6A")]
	private void UpdateClothingSkillAfterRepair(GearItem gi)
	{
	}

	[Token(Token = "0x60035D1")]
	[Address(RVA = "0xA8FCE0", Offset = "0xA8EAE0", Length = "0xA7")]
	private void UpdateSkillAfterRepair(bool success)
	{
	}

	[Token(Token = "0x60035D2")]
	[Address(RVA = "0xA8FD90", Offset = "0xA8EB90", Length = "0xC7")]
	private void CleanFinished()
	{
	}

	[Token(Token = "0x60035D3")]
	[Address(RVA = "0xA8FE60", Offset = "0xA8EC60", Length = "0x365")]
	private void CleanSuccessful()
	{
	}

	[Token(Token = "0x60035D4")]
	[Address(RVA = "0xA901D0", Offset = "0xA8EFD0", Length = "0x1A8")]
	private void UpdateSkillAfterClean(bool success)
	{
	}

	[Token(Token = "0x60035D5")]
	[Address(RVA = "0xA90380", Offset = "0xA8F180", Length = "0xC7")]
	private void SharpenFinished()
	{
	}

	[Token(Token = "0x60035D6")]
	[Address(RVA = "0xA90450", Offset = "0xA8F250", Length = "0x36B")]
	private void SharpenSuccessful()
	{
	}

	[Token(Token = "0x60035D7")]
	[Address(RVA = "0xA907C0", Offset = "0xA8F5C0", Length = "0x1AE")]
	private void UpdateSkillAfterSharpen(bool success)
	{
	}

	[Token(Token = "0x60035D8")]
	[Address(RVA = "0xA90970", Offset = "0xA8F770", Length = "0x63")]
	private bool RepairHasRequiredTool()
	{
		return false;
	}

	[Token(Token = "0x60035D9")]
	[Address(RVA = "0xA909E0", Offset = "0xA8F7E0", Length = "0x918")]
	private void UpdateRepairLabels()
	{
	}

	[Token(Token = "0x60035DA")]
	[Address(RVA = "0xA91300", Offset = "0xA90100", Length = "0x738")]
	private void UpdateCleanLabels()
	{
	}

	[Token(Token = "0x60035DB")]
	[Address(RVA = "0xA91A40", Offset = "0xA90840", Length = "0x3EE")]
	private void UpdateWeightAndConditionLabels()
	{
	}

	[Token(Token = "0x60035DC")]
	[Address(RVA = "0xA91E30", Offset = "0xA90C30", Length = "0x52F")]
	private void GetCleanConditionIncreaseAndDuration(out float conditionIncrease, out int durationMinutes)
	{
		conditionIncrease = default(float);
		durationMinutes = default(int);
	}

	[Token(Token = "0x60035DD")]
	[Address(RVA = "0xA92360", Offset = "0xA91160", Length = "0x764")]
	private void UpdateSharpenLabels()
	{
	}

	[Token(Token = "0x60035DE")]
	[Address(RVA = "0xA92AD0", Offset = "0xA918D0", Length = "0x206")]
	private void GetSharpenConditionIncreaseAndDuration(out float conditionIncrease, out int durationMinutes)
	{
		conditionIncrease = default(float);
		durationMinutes = default(int);
	}

	[Token(Token = "0x60035DF")]
	[Address(RVA = "0xA92CE0", Offset = "0xA91AE0", Length = "0x59C")]
	private void RefreshSafehouseCustomizationRepairPanel()
	{
	}

	[Token(Token = "0x60035E0")]
	[Address(RVA = "0xA93280", Offset = "0xA92080", Length = "0x2CE")]
	private void RefreshRepairPanel()
	{
	}

	[Token(Token = "0x60035E1")]
	[Address(RVA = "0xA93550", Offset = "0xA92350", Length = "0x10A")]
	private void RefreshCleanPanel()
	{
	}

	[Token(Token = "0x60035E2")]
	[Address(RVA = "0xA90970", Offset = "0xA8F770", Length = "0x63")]
	private bool CleanHasRequiredTool()
	{
		return false;
	}

	[Token(Token = "0x60035E3")]
	[Address(RVA = "0xA93660", Offset = "0xA92460", Length = "0x2C3")]
	private void RefreshSharpenPanel()
	{
	}

	[Token(Token = "0x60035E4")]
	[Address(RVA = "0xA93930", Offset = "0xA92730", Length = "0x5DB")]
	private void RefreshRefuelPanel()
	{
	}

	[Token(Token = "0x60035E5")]
	[Address(RVA = "0xA93F10", Offset = "0xA92D10", Length = "0xCEE")]
	private void RefreshReadPanel()
	{
	}

	[Token(Token = "0x60035E6")]
	[Address(RVA = "0xA94C00", Offset = "0xA93A00", Length = "0x299")]
	private void RefreshHoursToRead()
	{
	}

	[Token(Token = "0x60035E7")]
	[Address(RVA = "0xA90970", Offset = "0xA8F770", Length = "0x63")]
	private bool SharpenHasRequiredTool()
	{
		return false;
	}

	[Token(Token = "0x60035E8")]
	[Address(RVA = "0xA94EA0", Offset = "0xA93CA0", Length = "0xED")]
	private bool CanRefuel()
	{
		return false;
	}

	[Token(Token = "0x60035E9")]
	[Address(RVA = "0xA94F90", Offset = "0xA93D90", Length = "0x18C")]
	private bool IsResearchItem()
	{
		return false;
	}

	[Token(Token = "0x60035EA")]
	[Address(RVA = "0xA95120", Offset = "0xA93F20", Length = "0xEAC")]
	public void RefreshMainWindow()
	{
	}

	[Token(Token = "0x60035EB")]
	[Address(RVA = "0xA95FD0", Offset = "0xA94DD0", Length = "0x5A")]
	public void OnSelectHarvestButton()
	{
	}

	[Token(Token = "0x60035EC")]
	[Address(RVA = "0xA96030", Offset = "0xA94E30", Length = "0x64")]
	public void OnSelectRepairButton()
	{
	}

	[Token(Token = "0x60035ED")]
	[Address(RVA = "0xA960A0", Offset = "0xA94EA0", Length = "0x58")]
	public void OnSelectRefuelButton()
	{
	}

	[Token(Token = "0x60035EE")]
	[Address(RVA = "0xA96100", Offset = "0xA94F00", Length = "0x5A")]
	public void OnSelectCleanButton()
	{
	}

	[Token(Token = "0x60035EF")]
	[Address(RVA = "0xA96160", Offset = "0xA94F60", Length = "0x5A")]
	public void OnSelectSharpenButton()
	{
	}

	[Token(Token = "0x60035F0")]
	[Address(RVA = "0xA961C0", Offset = "0xA94FC0", Length = "0x3F")]
	public void SelectHarvestButton(bool selected)
	{
	}

	[Token(Token = "0x60035F1")]
	[Address(RVA = "0xA96200", Offset = "0xA95000", Length = "0x47")]
	public void SelectRepairButton(bool selected)
	{
	}

	[Token(Token = "0x60035F2")]
	[Address(RVA = "0xA96250", Offset = "0xA95050", Length = "0x4A")]
	public void SelectSafehouseCustomizationRepairButton(bool selected)
	{
	}

	[Token(Token = "0x60035F3")]
	[Address(RVA = "0xA962A0", Offset = "0xA950A0", Length = "0x21")]
	public void SelectRefuelButton(bool selected)
	{
	}

	[Token(Token = "0x60035F4")]
	[Address(RVA = "0xA962D0", Offset = "0xA950D0", Length = "0x116")]
	public void SelectCleanButton(bool selected)
	{
	}

	[Token(Token = "0x60035F5")]
	[Address(RVA = "0xA963F0", Offset = "0xA951F0", Length = "0x1E")]
	public void SelectUnloadButton(bool selected)
	{
	}

	[Token(Token = "0x60035F6")]
	[Address(RVA = "0xA96410", Offset = "0xA95210", Length = "0x116")]
	public void SelectSharpenButton(bool selected)
	{
	}

	[Token(Token = "0x60035F7")]
	[Address(RVA = "0xA96530", Offset = "0xA95330", Length = "0x21E")]
	private void SelectButton(int index)
	{
	}

	[Token(Token = "0x60035F8")]
	[Address(RVA = "0xA96750", Offset = "0xA95550", Length = "0x1041")]
	private void RefreshButton()
	{
	}

	[Token(Token = "0x60035F9")]
	[Address(RVA = "0xA977A0", Offset = "0xA965A0", Length = "0xD3")]
	public void OnEquip()
	{
	}

	[Token(Token = "0x60035FA")]
	[Address(RVA = "0xA97880", Offset = "0xA96680", Length = "0x20A")]
	public void OnHarvest()
	{
	}

	[Token(Token = "0x60035FB")]
	[Address(RVA = "0xA97A90", Offset = "0xA96890", Length = "0x34B")]
	private bool RepairRequiresSewingKit()
	{
		return false;
	}

	[Token(Token = "0x60035FC")]
	[Address(RVA = "0xA97DE0", Offset = "0xA96BE0", Length = "0x2B6")]
	private bool RepairHasRequiredMaterial()
	{
		return false;
	}

	[Token(Token = "0x60035FD")]
	[Address(RVA = "0xA980A0", Offset = "0xA96EA0", Length = "0x7A")]
	private bool CanRepair()
	{
		return false;
	}

	[Token(Token = "0x60035FE")]
	[Address(RVA = "0xA98120", Offset = "0xA96F20", Length = "0x19C")]
	public void OnRepair()
	{
	}

	[Token(Token = "0x60035FF")]
	[Address(RVA = "0xA982C0", Offset = "0xA970C0", Length = "0x37A")]
	public void OnProgressBarCancel()
	{
	}

	[Token(Token = "0x6003600")]
	[Address(RVA = "0xA98640", Offset = "0xA97440", Length = "0x228")]
	public void OnSelectActionTool()
	{
	}

	[Token(Token = "0x6003601")]
	[Address(RVA = "0xA98870", Offset = "0xA97670", Length = "0xAFA")]
	public void OnSelectRepairTool()
	{
	}

	[Token(Token = "0x6003602")]
	[Address(RVA = "0xA99370", Offset = "0xA98170", Length = "0x418")]
	private void StartRepair(int durationMinutes, string repairAudio)
	{
	}

	[Token(Token = "0x6003603")]
	[Address(RVA = "0xA99790", Offset = "0xA98590", Length = "0x14")]
	private int GetModifiedRepairDuration(GearItem gi, int baseMinutes, float conditionIncreaseFromRepair)
	{
		return 0;
	}

	[Token(Token = "0x6003604")]
	[Address(RVA = "0xA997B0", Offset = "0xA985B0", Length = "0x88")]
	private int GetModifiedCleanDuration(Cleanable c, float conditionIncrease, int baseMinutes)
	{
		return 0;
	}

	[Token(Token = "0x6003605")]
	[Address(RVA = "0xA99840", Offset = "0xA98640", Length = "0x88")]
	private int GetModifiedSharpenDuration(Sharpenable s, float conditionIncrease, int baseMinutes)
	{
		return 0;
	}

	[Token(Token = "0x6003606")]
	[Address(RVA = "0xA998D0", Offset = "0xA986D0", Length = "0x4D7")]
	private int GetModifiedActionDuration(GearItem gi, float conditionIncrease, int baseMinutes)
	{
		return 0;
	}

	[Token(Token = "0x6003607")]
	[Address(RVA = "0xA99DB0", Offset = "0xA98BB0", Length = "0x8F")]
	private bool RollForActionSuccess(float chanceSuccess)
	{
		return false;
	}

	[Token(Token = "0x6003608")]
	[Address(RVA = "0xA99E40", Offset = "0xA98C40", Length = "0x420")]
	public void OnRefuel()
	{
	}

	[Token(Token = "0x6003609")]
	[Address(RVA = "0xA9A270", Offset = "0xA99070", Length = "0x258")]
	public void RefuelFinished(bool success, bool playerCancel, float progress)
	{
	}

	[Token(Token = "0x600360A")]
	[Address(RVA = "0xA9A4D0", Offset = "0xA992D0", Length = "0x5A")]
	public void OnSelectUnload()
	{
	}

	[Token(Token = "0x600360B")]
	[Address(RVA = "0xA9A530", Offset = "0xA99330", Length = "0xAE")]
	public void OnUnload()
	{
	}

	[Token(Token = "0x600360C")]
	[Address(RVA = "0xA9A5E0", Offset = "0xA993E0", Length = "0x312")]
	public bool DoUnload()
	{
		return false;
	}

	[Token(Token = "0x600360D")]
	[Address(RVA = "0xA9A900", Offset = "0xA99700", Length = "0x17A")]
	public void OnClean()
	{
	}

	[Token(Token = "0x600360E")]
	[Address(RVA = "0xA9AA80", Offset = "0xA99880", Length = "0x2A7")]
	public void OnSelectCleanTool()
	{
	}

	[Token(Token = "0x600360F")]
	[Address(RVA = "0xA9AD30", Offset = "0xA99B30", Length = "0x113")]
	private void StartClean(int durationMinutes, string cleanAudio)
	{
	}

	[Token(Token = "0x6003610")]
	[Address(RVA = "0xA9AE50", Offset = "0xA99C50", Length = "0x17A")]
	public void OnSharpen()
	{
	}

	[Token(Token = "0x6003611")]
	[Address(RVA = "0xA9AFD0", Offset = "0xA99DD0", Length = "0x54D")]
	public void OnRead()
	{
	}

	[Token(Token = "0x6003612")]
	[Address(RVA = "0xA9B520", Offset = "0xA9A320", Length = "0x23B")]
	public void ReadComplete(float normalizedProgress)
	{
	}

	[Token(Token = "0x6003613")]
	[Address(RVA = "0xA9B760", Offset = "0xA9A560", Length = "0xB8")]
	public void OnReadHoursIncrease()
	{
	}

	[Token(Token = "0x6003614")]
	[Address(RVA = "0xA9B820", Offset = "0xA9A620", Length = "0x89")]
	public void OnReadHoursDecrease()
	{
	}

	[Token(Token = "0x6003615")]
	[Address(RVA = "0xA9B8B0", Offset = "0xA9A6B0", Length = "0x2B7")]
	public void OnSelectSharpenTool()
	{
	}

	[Token(Token = "0x6003616")]
	[Address(RVA = "0xA9BB70", Offset = "0xA9A970", Length = "0x113")]
	private void StartSharpen(int durationMinutes, string sharpenAudio)
	{
	}

	[Token(Token = "0x6003617")]
	[Address(RVA = "0xA9BC90", Offset = "0xA9AA90", Length = "0x18F")]
	private void StartRead(int durationMinutes, string readAudio)
	{
	}

	[Token(Token = "0x6003618")]
	[Address(RVA = "0xA9BE20", Offset = "0xA9AC20", Length = "0x522")]
	public void OnBack()
	{
	}

	[Token(Token = "0x6003619")]
	[Address(RVA = "0xA9C350", Offset = "0xA9B150", Length = "0xC7C")]
	private void SelectWindow(GameObject window)
	{
	}

	[Token(Token = "0x600361A")]
	[Address(RVA = "0xA9CFD0", Offset = "0xA9BDD0", Length = "0xC9")]
	public void SelectToolByIndex(int index)
	{
	}

	[Token(Token = "0x600361B")]
	[Address(RVA = "0xA9D0A0", Offset = "0xA9BEA0", Length = "0x2D4")]
	public void StartHarvest()
	{
	}

	[Token(Token = "0x600361C")]
	[Address(RVA = "0xA9D380", Offset = "0xA9C180", Length = "0x260")]
	private bool CanHarvest()
	{
		return false;
	}

	[Token(Token = "0x600361D")]
	[Address(RVA = "0xA9D5F0", Offset = "0xA9C3F0", Length = "0xDBE")]
	private void RefreshHarvest()
	{
	}

	[Token(Token = "0x600361E")]
	[Address(RVA = "0xA9E3B0", Offset = "0xA9D1B0", Length = "0x4A0")]
	private bool MaybeDrawFuelOrAmmoHarvestYield(GearItem gearItem, HarvestRepairMaterial harvestRepairMaterial)
	{
		return false;
	}

	[Token(Token = "0x600361F")]
	[Address(RVA = "0xA9E860", Offset = "0xA9D660", Length = "0xCF")]
	private bool CheckForHarvestSuccess(HarvestBase harvest)
	{
		return false;
	}

	[Token(Token = "0x6003620")]
	[Address(RVA = "0xA9E930", Offset = "0xA9D730", Length = "0xB91")]
	private void HarvestSuccessful()
	{
	}

	[Token(Token = "0x6003621")]
	[Address(RVA = "0xA9F4D0", Offset = "0xA9E2D0", Length = "0x796")]
	private void MaybeReturnAmmoOrFuelToInventory(GearItem gi)
	{
	}

	[Token(Token = "0x6003622")]
	[Address(RVA = "0xA9FC70", Offset = "0xA9EA70", Length = "0x373")]
	private void EnterInspectGearMode()
	{
	}

	[Token(Token = "0x6003623")]
	[Address(RVA = "0xA9FFF0", Offset = "0xA9EDF0", Length = "0x324")]
	public void ExitInspectGearMode()
	{
	}

	[Token(Token = "0x6003624")]
	[Address(RVA = "0xAA0320", Offset = "0xA9F120", Length = "0x1AA")]
	public static bool CanClean(GearItem gi)
	{
		return false;
	}

	[Token(Token = "0x6003625")]
	[Address(RVA = "0xAA04D0", Offset = "0xA9F2D0", Length = "0xA25")]
	private void UpdateButtonLegend()
	{
	}

	[Token(Token = "0x6003626")]
	[Address(RVA = "0xAA0F00", Offset = "0xA9FD00", Length = "0x31F")]
	private bool MaybeAbortReadingWithHUDMessage()
	{
		return false;
	}

	[Token(Token = "0x6003627")]
	[Address(RVA = "0xAA1220", Offset = "0xAA0020", Length = "0x18B")]
	private void SetInventoryAlpha(float alpha)
	{
	}

	[Token(Token = "0x6003628")]
	[Address(RVA = "0xAA13B0", Offset = "0xAA01B0", Length = "0x98")]
	public bool IsAcceleratingTime()
	{
		return false;
	}

	[Token(Token = "0x6003629")]
	[Address(RVA = "0xAA1450", Offset = "0xAA0250", Length = "0x197")]
	public string GetActionText()
	{
		return null;
	}

	[Token(Token = "0x600362A")]
	[Address(RVA = "0xAA15F0", Offset = "0xAA03F0", Length = "0x78")]
	public string GetSpriteName()
	{
		return null;
	}

	[Token(Token = "0x600362B")]
	[Address(RVA = "0x4A7D60", Offset = "0x4A6B60", Length = "0x5")]
	public UIRect GetElementToFade()
	{
		return null;
	}

	[Token(Token = "0x600362C")]
	[Address(RVA = "0xAA1670", Offset = "0xAA0470", Length = "0x71")]
	public Action GetCancelAction()
	{
		return null;
	}

	[Token(Token = "0x600362D")]
	[Address(RVA = "0xAA16F0", Offset = "0xAA04F0", Length = "0x4C")]
	public UIProgressBar GetActionProgress()
	{
		return null;
	}

	[Token(Token = "0x600362E")]
	[Address(RVA = "0x430B50", Offset = "0x42F950", Length = "0x3")]
	public bool ShowCameraEffects()
	{
		return false;
	}

	[Token(Token = "0x600362F")]
	[Address(RVA = "0xAA1740", Offset = "0xAA0540", Length = "0x223")]
	public void SetGearItem(GearItem Item)
	{
	}

	[Token(Token = "0x6003630")]
	[Address(RVA = "0xAA1970", Offset = "0xAA0770", Length = "0xAC")]
	public void SetRepairable(IRepairable repairable)
	{
	}

	[Token(Token = "0x6003631")]
	[Address(RVA = "0xAA1A20", Offset = "0xAA0820", Length = "0x541")]
	public Panel_Inventory_Examine()
	{
	}
}
