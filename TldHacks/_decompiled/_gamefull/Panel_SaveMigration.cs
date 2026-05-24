using System;
using Cpp2ILInjected;
using TLD.UI;
using TLD.UI.Generics;
using TLD.UI.Scroll;
using UnityEngine;

[Token(Token = "0x20006E4")]
public class Panel_SaveMigration : Panel_AutoReferenced, IScrollModel
{
	[Token(Token = "0x20006E5")]
	public class SaveItem
	{
		[Token(Token = "0x400498C")]
		[FieldOffset(Offset = "0x10")]
		public string Name;

		[Token(Token = "0x400498D")]
		[FieldOffset(Offset = "0x18")]
		public string DisplayName;

		[Token(Token = "0x400498E")]
		[FieldOffset(Offset = "0x20")]
		public string ExtraInfo;

		[Token(Token = "0x400498F")]
		[FieldOffset(Offset = "0x28")]
		public DateTime LastSaved;

		[Token(Token = "0x4004990")]
		[FieldOffset(Offset = "0x30")]
		public Texture2D ScreenShot;

		[Token(Token = "0x4004991")]
		[FieldOffset(Offset = "0x38")]
		public float Size;

		[Token(Token = "0x6003CB9")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public SaveItem()
		{
		}
	}

	[Token(Token = "0x400496B")]
	private const string MIGRATION_AVAILABLE_SAVES = "GAMEPLAY_MigrationAvailableSaves";

	[Token(Token = "0x400496C")]
	private const string MIGRATION_MIGRATED_SAVES = "GAMEPLAY_MigrationMigratedSaves";

	[Token(Token = "0x400496D")]
	private const string OPEN_SUPPORT = "GAMEPLAY_OpenSupport";

	[Token(Token = "0x400496E")]
	private const string MIGRATION_STOP = "GAMEPLAY_MigrationStop";

	[Token(Token = "0x400496F")]
	private const string MIGRATION_EXIT_PROMPT = "GAMEPLAY_ExitMigrationPrompt";

	[Token(Token = "0x4004970")]
	private const string SANDBOX = "GAMEPLAY_SANDBOX";

	[Token(Token = "0x4004971")]
	private const string BUTTON_NEXT = "GAMEPLAY_ButtonNext";

	[Token(Token = "0x4004972")]
	private const string BUTTON_CONFIRM = "GAMEPLAY_Confirm";

	[Token(Token = "0x4004973")]
	private const string BUTTON_SELECT = "GAMEPLAY_Select";

	[Token(Token = "0x4004974")]
	private const string BUTTON_BACK = "GAMEPLAY_ButtonBack";

	[SerializeField]
	[Token(Token = "0x4004975")]
	[FieldOffset(Offset = "0x30")]
	private ButtonLegendContainer m_ButtonLegendContainer;

	[Header("Screens")]
	[SerializeField]
	[Token(Token = "0x4004976")]
	[FieldOffset(Offset = "0x38")]
	private GameObject m_Preamble;

	[SerializeField]
	[Token(Token = "0x4004977")]
	[FieldOffset(Offset = "0x40")]
	private GameObject m_Migration;

	[SerializeField]
	[Token(Token = "0x4004978")]
	[FieldOffset(Offset = "0x48")]
	private GameObject m_Filtering;

	[SerializeField]
	[Token(Token = "0x4004979")]
	[FieldOffset(Offset = "0x50")]
	private GameObject m_Support;

	[SerializeField]
	[Token(Token = "0x400497A")]
	[FieldOffset(Offset = "0x58")]
	private GameObject m_Complete;

	[Header("Migration")]
	[SerializeField]
	[Token(Token = "0x400497B")]
	[FieldOffset(Offset = "0x60")]
	private UILabel m_MigrationLabel;

	[SerializeField]
	[Token(Token = "0x400497C")]
	[FieldOffset(Offset = "0x68")]
	private LocalizedString m_DefaultLocalization;

	[Header("Filtering")]
	[SerializeField]
	[Token(Token = "0x400497D")]
	[FieldOffset(Offset = "0x70")]
	private ScrollBehaviour m_SkippedTable;

	[SerializeField]
	[Token(Token = "0x400497E")]
	[FieldOffset(Offset = "0x78")]
	private ScrollBehaviour m_MigratedTable;

	[SerializeField]
	[Token(Token = "0x400497F")]
	[FieldOffset(Offset = "0x80")]
	private UILabel m_UsedSizeLabel;

	[SerializeField]
	[Token(Token = "0x4004980")]
	[FieldOffset(Offset = "0x88")]
	private UISprite m_UsedSizeSprite;

	[SerializeField]
	[Token(Token = "0x4004981")]
	[FieldOffset(Offset = "0x90")]
	private UISprite m_RequiredSizeSprite;

	[SerializeField]
	[Token(Token = "0x4004982")]
	[FieldOffset(Offset = "0x98")]
	private UISprite m_CurrentSaveSizeSprite;

	[Header("Support")]
	[SerializeField]
	[Token(Token = "0x4004983")]
	[FieldOffset(Offset = "0xA0")]
	private string m_SupportURL;

	[SerializeField]
	[Token(Token = "0x4004984")]
	[FieldOffset(Offset = "0xA8")]
	private GameObject m_ErrorText;

	[SerializeField]
	[Token(Token = "0x4004985")]
	[FieldOffset(Offset = "0xB0")]
	private GameObject m_NotAllSavesText;

	[SerializeField]
	[Token(Token = "0x4004986")]
	[FieldOffset(Offset = "0xB8")]
	private GameObject m_NoSavesFoundText;

	[Header("Focus Visualization")]
	[SerializeField]
	[Token(Token = "0x4004987")]
	[FieldOffset(Offset = "0xC0")]
	private UIWidget m_SkippedTableWidget;

	[SerializeField]
	[Token(Token = "0x4004988")]
	[FieldOffset(Offset = "0xC8")]
	private UIWidget m_MigratedTableWidget;

	[SerializeField]
	[Range(0f, 1f)]
	[Token(Token = "0x4004989")]
	[FieldOffset(Offset = "0xD0")]
	protected float m_AlphaUnselectedSide;

	[SerializeField]
	[Token(Token = "0x400498A")]
	[FieldOffset(Offset = "0xD8")]
	private UISprite m_ArrowButtonSprite;

	[Header("Panel References")]
	[SerializeField]
	[Token(Token = "0x400498B")]
	[FieldOffset(Offset = "0xE0")]
	private PanelReference<Panel_Confirmation> m_Confirmation;

	[Token(Token = "0x6003CB6")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public void BuildItem(ScrollBehaviour scrollBehaviour, ScrollBehaviourItem item, int index)
	{
	}

	[Token(Token = "0x6003CB7")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public void UpdateSelected(ScrollBehaviour scrollBehaviour, ScrollBehaviourItem selectedItem, int selectedIndex)
	{
	}

	[Token(Token = "0x6003CB8")]
	[Address(RVA = "0xB835D0", Offset = "0xB823D0", Length = "0xC3")]
	public Panel_SaveMigration()
	{
	}
}
