using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.Gear;
using TLD.UI.Generics;
using UnityEngine;
using UnityEngine.AddressableAssets;

[Token(Token = "0x20005DB")]
public class GearMessage : MonoBehaviour
{
	[Token(Token = "0x20005DC")]
	public enum QuickKey
	{
		[Token(Token = "0x400363C")]
		None,
		[Token(Token = "0x400363D")]
		Journal,
		[Token(Token = "0x400363E")]
		Map
	}

	[Token(Token = "0x20005DD")]
	public class GearMessageInfo
	{
		[Token(Token = "0x400363F")]
		[FieldOffset(Offset = "0x10")]
		public GearItem m_GearItem;

		[Token(Token = "0x4003640")]
		[FieldOffset(Offset = "0x18")]
		public AssetReferenceTexture2D m_IconReference;

		[Token(Token = "0x4003641")]
		[FieldOffset(Offset = "0x20")]
		public string m_GearPrefabName;

		[Token(Token = "0x4003642")]
		[FieldOffset(Offset = "0x28")]
		public string m_HeaderText;

		[Token(Token = "0x4003643")]
		[FieldOffset(Offset = "0x30")]
		public string m_Text;

		[Token(Token = "0x4003644")]
		[FieldOffset(Offset = "0x38")]
		public Color m_Color;

		[Token(Token = "0x4003645")]
		[FieldOffset(Offset = "0x48")]
		public float m_DisplayTime;

		[Token(Token = "0x4003646")]
		[FieldOffset(Offset = "0x4C")]
		public float m_StartAlpha;

		[Token(Token = "0x4003647")]
		[FieldOffset(Offset = "0x50")]
		public bool m_GearIsOpened;

		[Token(Token = "0x4003648")]
		[FieldOffset(Offset = "0x54")]
		public QuickKey m_EnableQuickKey;

		[Token(Token = "0x4003649")]
		[FieldOffset(Offset = "0x58")]
		public bool m_ShowOnHUDOnly;

		[Token(Token = "0x6002D85")]
		[Address(RVA = "0x94ED50", Offset = "0x94DB50", Length = "0x336")]
		public GearMessageInfo(string prefabName, string header, string text, GearItem gearItem = null, AssetReferenceTexture2D iconReference = null)
		{
		}
	}

	[Token(Token = "0x20005DE")]
	public class JournalMessageInfo
	{
		[Token(Token = "0x400364A")]
		[FieldOffset(Offset = "0x10")]
		public string m_CategoryLocID;

		[Token(Token = "0x400364B")]
		[FieldOffset(Offset = "0x18")]
		public KnowledgeCateogry m_Category;

		[Token(Token = "0x400364C")]
		[FieldOffset(Offset = "0x20")]
		public string m_NameLocID;

		[Token(Token = "0x6002D86")]
		[Address(RVA = "0x94F090", Offset = "0x94DE90", Length = "0xBF")]
		public void Set(string categoryLocID, KnowledgeCateogry category, string nameLocID)
		{
		}

		[Token(Token = "0x6002D87")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public JournalMessageInfo()
		{
		}
	}

	[Header("Panel References")]
	[SerializeField]
	[Token(Token = "0x4003629")]
	[FieldOffset(Offset = "0x20")]
	private PanelReference<Panel_Actions> m_Actions;

	[SerializeField]
	[Token(Token = "0x400362A")]
	[FieldOffset(Offset = "0x28")]
	private PanelReference<Panel_ActionsRadial> m_ActionsRadial;

	[SerializeField]
	[Token(Token = "0x400362B")]
	[FieldOffset(Offset = "0x30")]
	private PanelReference<Panel_FeedFire> m_FeedFire;

	[SerializeField]
	[Token(Token = "0x400362C")]
	[FieldOffset(Offset = "0x38")]
	private PanelReference<Panel_FirstAid> m_FirstAid;

	[SerializeField]
	[Token(Token = "0x400362D")]
	[FieldOffset(Offset = "0x40")]
	private PanelReference<Panel_HUD> m_HUD;

	[SerializeField]
	[Token(Token = "0x400362E")]
	[FieldOffset(Offset = "0x48")]
	private PanelReference<Panel_Log> m_Log;

	[SerializeField]
	[Token(Token = "0x400362F")]
	[FieldOffset(Offset = "0x50")]
	private PanelReference<Panel_Map> m_Map;

	[Token(Token = "0x4003630")]
	private static List<GearMessageInfo> m_GearMessageQueue;

	[Token(Token = "0x4003631")]
	private static List<string> m_JournalMessageQueue;

	[Token(Token = "0x4003632")]
	public static JournalMessageInfo m_JournalQuickKeyInfo;

	[Token(Token = "0x4003633")]
	public static bool m_JournalQuickKeyActive;

	[Token(Token = "0x4003634")]
	public static bool m_MapQuickKeyActive;

	[Token(Token = "0x4003635")]
	private static float m_MessageLabelDisplayTimeSeconds;

	[Token(Token = "0x4003636")]
	private static float m_MessageLabelElapsedDisplayTimeSeconds;

	[Token(Token = "0x4003637")]
	private static float m_MessageLabelAlpha;

	[Token(Token = "0x4003638")]
	private static float m_MessageLabelFadeTimeSeconds;

	[Token(Token = "0x4003639")]
	private static bool m_MessageShowOnHUDOnly;

	[Token(Token = "0x400363A")]
	private static int m_JournalMessageQueueFrameCounter;

	[Token(Token = "0x6002D6A")]
	[Address(RVA = "0x94B070", Offset = "0x949E70", Length = "0x181")]
	public void Start()
	{
	}

	[Token(Token = "0x6002D6B")]
	[Address(RVA = "0x94B200", Offset = "0x94A000", Length = "0x320")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6002D6C")]
	[Address(RVA = "0x94B530", Offset = "0x94A330", Length = "0x320")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6002D6D")]
	[Address(RVA = "0x94B860", Offset = "0x94A660", Length = "0x967")]
	public void Update()
	{
	}

	[Token(Token = "0x6002D6E")]
	[Address(RVA = "0x94C1D0", Offset = "0x94AFD0", Length = "0xB9")]
	private bool ShouldShowNextMessageInQueue()
	{
		return false;
	}

	[Token(Token = "0x6002D6F")]
	[Address(RVA = "0x94C290", Offset = "0x94B090", Length = "0xD0")]
	private bool IsMapOrLogEnabled()
	{
		return false;
	}

	[Token(Token = "0x6002D70")]
	[Address(RVA = "0x94C370", Offset = "0x94B170", Length = "0xF0")]
	private void OnBlueprintUnlocked(BlueprintData bp)
	{
	}

	[Token(Token = "0x6002D71")]
	[Address(RVA = "0x94C470", Offset = "0x94B270", Length = "0x1C6")]
	public static void AddJournalQueueMessage(string categoryLocID)
	{
	}

	[Token(Token = "0x6002D72")]
	[Address(RVA = "0x94C640", Offset = "0x94B440", Length = "0x85")]
	public static void AddJournalQueueMessageWithQuickKey(string categoryLocID, KnowledgeCateogry category, string nameLocID)
	{
	}

	[Token(Token = "0x6002D73")]
	[Address(RVA = "0x94C6D0", Offset = "0x94B4D0", Length = "0x299")]
	public static void AddMessage(GearItem gi, string header, string message, bool highPriority = false, bool showOnHUDOnly = true)
	{
	}

	[Token(Token = "0x6002D74")]
	[Address(RVA = "0x94C970", Offset = "0x94B770", Length = "0x29F")]
	public static void AddMessage(GearItem gi, string header, string message, float numSeconds, bool highPriority = false, bool showOnHUDOnly = true)
	{
	}

	[Token(Token = "0x6002D75")]
	[Address(RVA = "0x94CC10", Offset = "0x94BA10", Length = "0x295")]
	public static void AddMessageFadeIn(GearItem gi, string header, string message, bool highPriority = false, bool showOnHUDOnly = true)
	{
	}

	[Token(Token = "0x6002D76")]
	[Address(RVA = "0x94CEB0", Offset = "0x94BCB0", Length = "0x2A3")]
	public static void AddMessageFadeIn(GearItem gi, string header, string message, float numSeconds, bool highPriority = false, bool showOnHUDOnly = true)
	{
	}

	[Token(Token = "0x6002D77")]
	[Address(RVA = "0x94D160", Offset = "0x94BF60", Length = "0x109")]
	public static void AddMessage(string prefabName, string header, string message, bool highPriority = false, bool showOnHUDOnly = true, GearItem gi = null, AssetReferenceTexture2D iconReference = null)
	{
	}

	[Token(Token = "0x6002D78")]
	[Address(RVA = "0x94D270", Offset = "0x94C070", Length = "0xFE")]
	public static void AddMessageWithQuickKey(string prefabName, string header, string message, QuickKey quickKey, bool highPriority = false, bool showOnHUDOnly = true)
	{
	}

	[Token(Token = "0x6002D79")]
	[Address(RVA = "0x94D370", Offset = "0x94C170", Length = "0x102")]
	public static void AddMessage(string prefabName, string header, string message, Color color, bool highPriority = false, bool showOnHUDOnly = true)
	{
	}

	[Token(Token = "0x6002D7A")]
	[Address(RVA = "0x94D480", Offset = "0x94C280", Length = "0x104")]
	public static void AddMessage(string prefabName, string header, string message, float numSeconds, bool highPriority = false, bool showOnHUDOnly = true)
	{
	}

	[Token(Token = "0x6002D7B")]
	[Address(RVA = "0x94D590", Offset = "0x94C390", Length = "0xFE")]
	public static void AddMessageFadeIn(string prefabName, string header, string message, bool highPriority = false, bool showOnHUDOnly = true)
	{
	}

	[Token(Token = "0x6002D7C")]
	[Address(RVA = "0x94D690", Offset = "0x94C490", Length = "0x115")]
	public static void AddMessageFadeIn(string prefabName, string header, string message, float numSeconds, bool highPriority = false, bool showOnHUDOnly = true)
	{
	}

	[Token(Token = "0x6002D7D")]
	[Address(RVA = "0x94D7B0", Offset = "0x94C5B0", Length = "0x54")]
	public static void SetJournalQuickKey(string categoryLocID, KnowledgeCateogry category, string nameLocID)
	{
	}

	[Token(Token = "0x6002D7E")]
	[Address(RVA = "0x94D810", Offset = "0x94C610", Length = "0x3A9")]
	private static void AddMessageToQueue(Panel_HUD hud, GearMessageInfo newGearMessage, bool highPriority)
	{
	}

	[Token(Token = "0x6002D7F")]
	[Address(RVA = "0x94DBC0", Offset = "0x94C9C0", Length = "0x959")]
	private static void ShowNextMessageInQueue(Panel_HUD hud)
	{
	}

	[Token(Token = "0x6002D80")]
	[Address(RVA = "0x94E520", Offset = "0x94D320", Length = "0x11E")]
	private static bool MessageExistsInQueue(string message)
	{
		return false;
	}

	[Token(Token = "0x6002D81")]
	[Address(RVA = "0x94E640", Offset = "0x94D440", Length = "0xE0")]
	private static bool ShortenMessageTimeDueToQueue()
	{
		return false;
	}

	[Token(Token = "0x6002D82")]
	[Address(RVA = "0x94E730", Offset = "0x94D530", Length = "0x3B0")]
	private static void AddJournalMessage()
	{
	}

	[Token(Token = "0x6002D83")]
	[Address(RVA = "0x94EAF0", Offset = "0x94D8F0", Length = "0x25A")]
	private bool ShouldUseOffsetLocation(Panel_HUD hud, Panel_FeedFire feedFire, Panel_FirstAid firstAid)
	{
		return false;
	}

	[Token(Token = "0x6002D84")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public GearMessage()
	{
	}
}
