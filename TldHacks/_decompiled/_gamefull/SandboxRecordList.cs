using Cpp2ILInjected;
using TLD.Gameplay;
using TLD.Scenes;
using TLD.Stats;
using TLD.UI.Scroll;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;

[Token(Token = "0x20005F5")]
public class SandboxRecordList : MonoBehaviour, IScrollModel
{
	[SerializeField]
	[Token(Token = "0x40036F2")]
	[FieldOffset(Offset = "0x20")]
	private ScrollBehaviour m_ScrollBehaviour;

	[Header("Side Elements")]
	[SerializeField]
	[Token(Token = "0x40036F3")]
	[FieldOffset(Offset = "0x28")]
	private UILabel m_SandboxHeader;

	[SerializeField]
	[Token(Token = "0x40036F4")]
	[FieldOffset(Offset = "0x30")]
	private UILabel m_SurvivalRecordText;

	[SerializeField]
	[Token(Token = "0x40036F5")]
	[FieldOffset(Offset = "0x38")]
	private UILabel m_DiedFromText;

	[SerializeField]
	[Token(Token = "0x40036F6")]
	[FieldOffset(Offset = "0x40")]
	private UISprite m_ExperienceModeSprite;

	[SerializeField]
	[Token(Token = "0x40036F7")]
	[FieldOffset(Offset = "0x48")]
	private UITexture m_TOCRegionTexture;

	[SerializeField]
	[Token(Token = "0x40036F8")]
	[FieldOffset(Offset = "0x50")]
	private UILabel m_EndDateText;

	[Token(Token = "0x40036FC")]
	[FieldOffset(Offset = "0x70")]
	private AsyncOperationHandle<RegionSpecification> m_SandboxRecordStartRegionHandle;

	[Token(Token = "0x40036FD")]
	[FieldOffset(Offset = "0x88")]
	private AsyncOperationHandle<GameModeConfig> m_SandboxRecordGameModeHandle;

	[Token(Token = "0x170002D8")]
	[field: Token(Token = "0x40036F9")]
	[field: FieldOffset(Offset = "0x58")]
	public SandboxRecordData SelectedSandboxRecord
	{
		[Token(Token = "0x6002E08")]
		[Address(RVA = "0x6BCD40", Offset = "0x6BBB40", Length = "0x5")]
		get;
		[Token(Token = "0x6002E09")]
		[Address(RVA = "0x95D320", Offset = "0x95C120", Length = "0x52")]
		private set;
	}

	[Token(Token = "0x170002D9")]
	[field: Token(Token = "0x40036FA")]
	[field: FieldOffset(Offset = "0x60")]
	public RegionSpecification SelectedSandboxRecordStartRegion
	{
		[Token(Token = "0x6002E0A")]
		[Address(RVA = "0x6E2FE0", Offset = "0x6E1DE0", Length = "0x5")]
		get;
		[Token(Token = "0x6002E0B")]
		[Address(RVA = "0x8F4D50", Offset = "0x8F3B50", Length = "0x52")]
		private set;
	}

	[Token(Token = "0x170002DA")]
	[field: Token(Token = "0x40036FB")]
	[field: FieldOffset(Offset = "0x68")]
	public GameModeConfig SelectedSandboxRecordGameMode
	{
		[Token(Token = "0x6002E0C")]
		[Address(RVA = "0x65D9D0", Offset = "0x65C7D0", Length = "0x5")]
		get;
		[Token(Token = "0x6002E0D")]
		[Address(RVA = "0x8F4DB0", Offset = "0x8F3BB0", Length = "0x52")]
		private set;
	}

	[Token(Token = "0x6002E0E")]
	[Address(RVA = "0x95D380", Offset = "0x95C180", Length = "0x24")]
	private void Awake()
	{
	}

	[Token(Token = "0x6002E0F")]
	[Address(RVA = "0x95D3B0", Offset = "0x95C1B0", Length = "0xC5")]
	public void RebuildList()
	{
	}

	[Token(Token = "0x6002E10")]
	[Address(RVA = "0x95D480", Offset = "0x95C280", Length = "0x1D")]
	public void RefreshList()
	{
	}

	[Token(Token = "0x6002E11")]
	[Address(RVA = "0x95D4A0", Offset = "0x95C2A0", Length = "0x1D")]
	public void UpdateListControls()
	{
	}

	[Token(Token = "0x6002E12")]
	[Address(RVA = "0x95D4C0", Offset = "0x95C2C0", Length = "0x1B8")]
	public void BuildItem(ScrollBehaviour scrollBehaviour, ScrollBehaviourItem item, int index)
	{
	}

	[Token(Token = "0x6002E13")]
	[Address(RVA = "0x95D680", Offset = "0x95C480", Length = "0x316")]
	public void UpdateSelected(ScrollBehaviour scrollBehaviour, ScrollBehaviourItem selectedItem, int selectedIndex)
	{
	}

	[Token(Token = "0x6002E14")]
	[Address(RVA = "0x95D9A0", Offset = "0x95C7A0", Length = "0x390")]
	public void CleanupSelectedSandboxRecord()
	{
	}

	[Token(Token = "0x6002E15")]
	[Address(RVA = "0x95DD30", Offset = "0x95CB30", Length = "0x3E7")]
	private void UpdateSideElements()
	{
	}

	[Token(Token = "0x6002E16")]
	[Address(RVA = "0x95E120", Offset = "0x95CF20", Length = "0x433")]
	private string GetSurvivalRecordSummaryText(SandboxRecordData record, Color boldColor)
	{
		return null;
	}

	[Token(Token = "0x6002E17")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public SandboxRecordList()
	{
	}
}
