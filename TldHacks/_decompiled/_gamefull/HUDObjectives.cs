using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20005ED")]
public class HUDObjectives : MonoBehaviour
{
	[Token(Token = "0x20005EE")]
	public delegate void OnCompleteDelegate();

	[Token(Token = "0x20005EF")]
	private enum State
	{
		[Token(Token = "0x40036D9")]
		Inactive,
		[Token(Token = "0x40036DA")]
		Delay,
		[Token(Token = "0x40036DB")]
		Active,
		[Token(Token = "0x40036DC")]
		Hide
	}

	[Token(Token = "0x20005F0")]
	private struct StatusUpdate
	{
		[Token(Token = "0x40036DD")]
		[FieldOffset(Offset = "0x0")]
		public bool isSideMission;

		[Token(Token = "0x40036DE")]
		[FieldOffset(Offset = "0x8")]
		public string mission;

		[Token(Token = "0x40036DF")]
		[FieldOffset(Offset = "0x10")]
		public string objective;

		[Token(Token = "0x40036E0")]
		[FieldOffset(Offset = "0x18")]
		public MissionStatusType type;

		[Token(Token = "0x6002DEE")]
		[Address(RVA = "0x95B810", Offset = "0x95A610", Length = "0xB2")]
		public void Clear()
		{
		}

		[Token(Token = "0x6002DEF")]
		[Address(RVA = "0x95B8D0", Offset = "0x95A6D0", Length = "0x24")]
		public bool IsValid()
		{
			return false;
		}
	}

	[SerializeField]
	[Token(Token = "0x40036C3")]
	[FieldOffset(Offset = "0x20")]
	private Panel_HUD m_HUD;

	[Token(Token = "0x40036C4")]
	[FieldOffset(Offset = "0x28")]
	public UILabel m_DetailsLabel;

	[Token(Token = "0x40036C5")]
	[FieldOffset(Offset = "0x30")]
	public UILabel m_MapHotkeyLabel;

	[Token(Token = "0x40036C6")]
	[FieldOffset(Offset = "0x38")]
	public Vector3 m_DetailsLabelOffset;

	[Token(Token = "0x40036C7")]
	[FieldOffset(Offset = "0x44")]
	public float m_DetailsLabelMoveDuration;

	[Tooltip("Time to wait before displaying objective updates. Time is in seconds.")]
	[Range(0f, 60f)]
	[Token(Token = "0x40036C8")]
	[FieldOffset(Offset = "0x48")]
	public float m_InitialDisplayDelay;

	[Token(Token = "0x40036C9")]
	[FieldOffset(Offset = "0x50")]
	public MissionStatusDisplaySettings m_ObjectiveDisplaySettings;

	[Token(Token = "0x40036CA")]
	[FieldOffset(Offset = "0xD0")]
	public MissionStatusDisplaySettings m_SideMissionDisplaySettings;

	[Token(Token = "0x40036CB")]
	[FieldOffset(Offset = "0x150")]
	public List<ObjectiveInfoDisplay> m_ObjectiveDisplays;

	[Token(Token = "0x40036CC")]
	[FieldOffset(Offset = "0x158")]
	public int m_EffectGroupHide;

	[Token(Token = "0x40036CD")]
	[FieldOffset(Offset = "0x15C")]
	public int m_EffectGroupShow;

	[HideInInspector]
	[Token(Token = "0x40036CE")]
	[FieldOffset(Offset = "0x160")]
	public bool m_RestoreDisplay;

	[Token(Token = "0x40036CF")]
	[FieldOffset(Offset = "0x168")]
	public OnCompleteDelegate m_OnComplete;

	[Token(Token = "0x40036D0")]
	[FieldOffset(Offset = "0x170")]
	private List<UITweener> m_HideTweens;

	[Token(Token = "0x40036D1")]
	[FieldOffset(Offset = "0x178")]
	private List<UITweener> m_ShowTweens;

	[Token(Token = "0x40036D2")]
	[FieldOffset(Offset = "0x180")]
	private int m_ActiveTweens;

	[Token(Token = "0x40036D3")]
	[FieldOffset(Offset = "0x184")]
	private int m_ActiveDisplays;

	[Token(Token = "0x40036D4")]
	[FieldOffset(Offset = "0x188")]
	private float m_DisplayDelayTimer;

	[Token(Token = "0x40036D5")]
	[FieldOffset(Offset = "0x18C")]
	private int m_PeakDisplays;

	[Token(Token = "0x40036D6")]
	[FieldOffset(Offset = "0x190")]
	private State m_State;

	[Token(Token = "0x40036D7")]
	[FieldOffset(Offset = "0x198")]
	private Queue<StatusUpdate> m_Queue;

	[Token(Token = "0x6002DD7")]
	[Address(RVA = "0x957960", Offset = "0x956760", Length = "0x899")]
	public void Disable()
	{
	}

	[Token(Token = "0x6002DD8")]
	[Address(RVA = "0x958200", Offset = "0x957000", Length = "0x22E")]
	public void EnqueueObjective(MissionStatusType type, string id)
	{
	}

	[Token(Token = "0x6002DD9")]
	[Address(RVA = "0x958430", Offset = "0x957230", Length = "0x1CF")]
	public void EnqueueSideMission(MissionStatusType type, string id)
	{
	}

	[Token(Token = "0x6002DDA")]
	[Address(RVA = "0x958600", Offset = "0x957400", Length = "0x496")]
	public string GetDebugText()
	{
		return null;
	}

	[Token(Token = "0x6002DDB")]
	[Address(RVA = "0x958AA0", Offset = "0x9578A0", Length = "0x344")]
	public void HideDisplay()
	{
	}

	[Token(Token = "0x6002DDC")]
	[Address(RVA = "0x958DF0", Offset = "0x957BF0", Length = "0xB")]
	public bool IsActive()
	{
		return false;
	}

	[Token(Token = "0x6002DDD")]
	[Address(RVA = "0x958E00", Offset = "0x957C00", Length = "0x227")]
	public void ManualUpdate()
	{
	}

	[Token(Token = "0x6002DDE")]
	[Address(RVA = "0x959030", Offset = "0x957E30", Length = "0x25E")]
	public void RestoreDisplay()
	{
	}

	[Token(Token = "0x6002DDF")]
	[Address(RVA = "0x959290", Offset = "0x958090", Length = "0x97")]
	private bool ShowMapHotkey()
	{
		return false;
	}

	[Token(Token = "0x6002DE0")]
	[Address(RVA = "0x959330", Offset = "0x958130", Length = "0x11")]
	public void Setup()
	{
	}

	[Token(Token = "0x6002DE1")]
	[Address(RVA = "0x959350", Offset = "0x958150", Length = "0x15")]
	public bool WantsUpdates()
	{
		return false;
	}

	[Token(Token = "0x6002DE2")]
	[Address(RVA = "0x959370", Offset = "0x958170", Length = "0x1E0")]
	public string GetMissionId()
	{
		return null;
	}

	[Token(Token = "0x6002DE3")]
	[Address(RVA = "0x959560", Offset = "0x958360", Length = "0x908")]
	private void Awake()
	{
	}

	[Token(Token = "0x6002DE4")]
	[Address(RVA = "0x959E70", Offset = "0x958C70", Length = "0xFD1")]
	private void Dequeue()
	{
	}

	[Token(Token = "0x6002DE5")]
	[Address(RVA = "0x95AE50", Offset = "0x959C50", Length = "0x2EA")]
	private void Hide()
	{
	}

	[Token(Token = "0x6002DE6")]
	[Address(RVA = "0x95B140", Offset = "0x959F40", Length = "0x95")]
	private void OnHideTweenComplete()
	{
	}

	[Token(Token = "0x6002DE7")]
	[Address(RVA = "0x95B1E0", Offset = "0x959FE0", Length = "0x28")]
	private void OnObjectiveDisplayComplete()
	{
	}

	[Token(Token = "0x6002DE8")]
	[Address(RVA = "0x95B210", Offset = "0x95A010", Length = "0x362")]
	private void Show()
	{
	}

	[Token(Token = "0x6002DE9")]
	[Address(RVA = "0x95B580", Offset = "0x95A380", Length = "0x284")]
	public HUDObjectives()
	{
	}
}
