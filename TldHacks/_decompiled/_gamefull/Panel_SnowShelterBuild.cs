using System;
using Cpp2ILInjected;
using TLD.UI;
using TLD.UI.Generics;
using UnityEngine;

[Token(Token = "0x20006CC")]
public class Panel_SnowShelterBuild : Panel_AutoReferenced, IAccelerateTimeProvider
{
	[Token(Token = "0x4004866")]
	[FieldOffset(Offset = "0x30")]
	public ButtonLegendContainer m_ButtonLegendContainer;

	[Token(Token = "0x4004867")]
	[FieldOffset(Offset = "0x38")]
	public float m_RealtimeSecondsToBuild;

	[Token(Token = "0x4004868")]
	[FieldOffset(Offset = "0x40")]
	public UILabel m_DurationLabel;

	[Token(Token = "0x4004869")]
	[FieldOffset(Offset = "0x48")]
	public UILabel m_EstimatedCaloriesBurnedLabel;

	[Token(Token = "0x400486A")]
	[FieldOffset(Offset = "0x50")]
	public UILabel m_CurrentCaloriesLabel;

	[Token(Token = "0x400486B")]
	[FieldOffset(Offset = "0x58")]
	public UILabel m_CurrentCaloriesValLabel;

	[Token(Token = "0x400486C")]
	[FieldOffset(Offset = "0x60")]
	public GameObject m_PanelElements;

	[Token(Token = "0x400486D")]
	[FieldOffset(Offset = "0x68")]
	public HarvestRepairMaterial[] m_RequiredMaterialsObjects;

	[Token(Token = "0x400486E")]
	[FieldOffset(Offset = "0x70")]
	public GameObject m_BuildButton;

	[Token(Token = "0x400486F")]
	[FieldOffset(Offset = "0x78")]
	public string m_IconAccelerateTime;

	[Header("Panel References")]
	[SerializeField]
	[Token(Token = "0x4004870")]
	[FieldOffset(Offset = "0x80")]
	private PanelReference<Panel_HUD> m_HUD;

	[HideInInspector]
	[Token(Token = "0x4004871")]
	[FieldOffset(Offset = "0x88")]
	private SnowShelter m_SnowShelter;

	[Token(Token = "0x4004872")]
	[FieldOffset(Offset = "0x90")]
	private float m_DurationHours;

	[Token(Token = "0x4004873")]
	[FieldOffset(Offset = "0x94")]
	private bool m_IsBuilding;

	[Token(Token = "0x4004874")]
	[FieldOffset(Offset = "0x98")]
	private float m_RealtimeSecondsSpentBuilding;

	[Token(Token = "0x4004875")]
	[FieldOffset(Offset = "0x9C")]
	private bool m_TimeIsAccelerated;

	[Token(Token = "0x4004876")]
	[FieldOffset(Offset = "0xA0")]
	private float m_StoredDayLengthScale;

	[Token(Token = "0x4004877")]
	[FieldOffset(Offset = "0xA4")]
	private int m_FramesInPanel;

	[Token(Token = "0x4004878")]
	[FieldOffset(Offset = "0xA8")]
	private uint m_BuildAudioID;

	[Token(Token = "0x6003BA2")]
	[Address(RVA = "0x67CA50", Offset = "0x67B850", Length = "0x44")]
	public override void Initialize()
	{
	}

	[Token(Token = "0x6003BA3")]
	[Address(RVA = "0xB68CC0", Offset = "0xB67AC0", Length = "0x613")]
	private void Update()
	{
	}

	[Token(Token = "0x6003BA4")]
	[Address(RVA = "0xB692E0", Offset = "0xB680E0", Length = "0x35")]
	public override void CloseSelf()
	{
	}

	[Token(Token = "0x6003BA5")]
	[Address(RVA = "0xB69320", Offset = "0xB68120", Length = "0x2D2")]
	public override void Enable(bool enable)
	{
	}

	[Token(Token = "0x6003BA6")]
	[Address(RVA = "0xB69600", Offset = "0xB68400", Length = "0x52")]
	public void SetSnowShelterInstance(SnowShelter ss)
	{
	}

	[Token(Token = "0x6003BA7")]
	[Address(RVA = "0x5DEE70", Offset = "0x5DDC70", Length = "0x8")]
	public bool IsTimeAccelerated()
	{
		return false;
	}

	[Token(Token = "0x6003BA8")]
	[Address(RVA = "0xB69660", Offset = "0xB68460", Length = "0x8")]
	public bool IsBuilding()
	{
		return false;
	}

	[Token(Token = "0x6003BA9")]
	[Address(RVA = "0x7F6DB0", Offset = "0x7F5BB0", Length = "0x13")]
	private void ExitInterface()
	{
	}

	[Token(Token = "0x6003BAA")]
	[Address(RVA = "0xB69670", Offset = "0xB68470", Length = "0x26E")]
	public void OnCancel()
	{
	}

	[Token(Token = "0x6003BAB")]
	[Address(RVA = "0xB698E0", Offset = "0xB686E0", Length = "0x17C")]
	public void OnBuild()
	{
	}

	[Token(Token = "0x6003BAC")]
	[Address(RVA = "0xB69A60", Offset = "0xB68860", Length = "0x15D")]
	private void BuildFinished()
	{
	}

	[Token(Token = "0x6003BAD")]
	[Address(RVA = "0xB69BC0", Offset = "0xB689C0", Length = "0x198")]
	private void UpdateDurationLabel()
	{
	}

	[Token(Token = "0x6003BAE")]
	[Address(RVA = "0xB69D60", Offset = "0xB68B60", Length = "0x269")]
	private void UpdateEstimatedCaloriesBurnedLabel()
	{
	}

	[Token(Token = "0x6003BAF")]
	[Address(RVA = "0xB69FD0", Offset = "0xB68DD0", Length = "0x215")]
	private void UpdateCurrentCaloriesLabel()
	{
	}

	[Token(Token = "0x6003BB0")]
	[Address(RVA = "0xB6A1F0", Offset = "0xB68FF0", Length = "0x8F")]
	private string GetSignedInt(int value)
	{
		return null;
	}

	[Token(Token = "0x6003BB1")]
	[Address(RVA = "0xB6A280", Offset = "0xB69080", Length = "0x216")]
	private string GetSignedPercentage(float value)
	{
		return null;
	}

	[Token(Token = "0x6003BB2")]
	[Address(RVA = "0xB6A4A0", Offset = "0xB692A0", Length = "0x94")]
	private void RefreshRequiredMaterials()
	{
	}

	[Token(Token = "0x6003BB3")]
	[Address(RVA = "0xB6A540", Offset = "0xB69340", Length = "0x109")]
	private void UpdateButtonLegend()
	{
	}

	[Token(Token = "0x6003BB4")]
	[Address(RVA = "0xB6A650", Offset = "0xB69450", Length = "0xAE")]
	public bool IsAcceleratingTime()
	{
		return false;
	}

	[Token(Token = "0x6003BB5")]
	[Address(RVA = "0xB6A700", Offset = "0xB69500", Length = "0x5D")]
	public string GetActionText()
	{
		return null;
	}

	[Token(Token = "0x6003BB6")]
	[Address(RVA = "0x664E10", Offset = "0x663C10", Length = "0x5")]
	public string GetSpriteName()
	{
		return null;
	}

	[Token(Token = "0x6003BB7")]
	[Address(RVA = "0x4582A0", Offset = "0x4570A0", Length = "0x3")]
	public UIRect GetElementToFade()
	{
		return null;
	}

	[Token(Token = "0x6003BB8")]
	[Address(RVA = "0xB6A760", Offset = "0xB69560", Length = "0x71")]
	public Action GetCancelAction()
	{
		return null;
	}

	[Token(Token = "0x6003BB9")]
	[Address(RVA = "0x4582A0", Offset = "0x4570A0", Length = "0x3")]
	public UIProgressBar GetActionProgress()
	{
		return null;
	}

	[Token(Token = "0x6003BBA")]
	[Address(RVA = "0x430B50", Offset = "0x42F950", Length = "0x3")]
	public bool ShowCameraEffects()
	{
		return false;
	}

	[Token(Token = "0x6003BBB")]
	[Address(RVA = "0xB6A7E0", Offset = "0xB695E0", Length = "0x13C")]
	public Panel_SnowShelterBuild()
	{
	}
}
