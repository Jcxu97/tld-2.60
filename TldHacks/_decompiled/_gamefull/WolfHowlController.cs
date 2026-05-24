using System.Collections.Generic;
using System.Diagnostics;
using Cpp2ILInjected;
using TLD.AI;
using TLD.UI.Generics;
using UnityEngine;

[Token(Token = "0x200018E")]
public class WolfHowlController : MonoBehaviour
{
	[Token(Token = "0x4000E74")]
	private const int INVALID_HOWL_ID = -1;

	[Token(Token = "0x4000E75")]
	private const int FIRST_HOWL_ID = 1;

	[SerializeField]
	[Token(Token = "0x4000E76")]
	[FieldOffset(Offset = "0x20")]
	private PanelReference<Panel_Loading> m_Loading;

	[Tooltip("Minimum number of wolves that must exist before howl will activate. 0 will ignore this.")]
	[Token(Token = "0x4000E77")]
	[FieldOffset(Offset = "0x28")]
	public uint m_MinimumNumberOfWolves;

	[Tooltip("A wolf must be a minimum of this distance away from the player in order to howl. Distance in meters.")]
	[Token(Token = "0x4000E78")]
	[FieldOffset(Offset = "0x2C")]
	public float m_MinimumPlayerDistance;

	[Tooltip("A wolf must be a maximum of this distance away from the player in order to howl. Distance in meters.")]
	[Token(Token = "0x4000E79")]
	[FieldOffset(Offset = "0x30")]
	public float m_MaxiumumPlayerDistance;

	[Tooltip("Minimum delay between each attempted howl. Next howl time is randomized between minimum and maximum delay time. Time in seconds.")]
	[Token(Token = "0x4000E7A")]
	[FieldOffset(Offset = "0x34")]
	public int m_HowlMinimumDelay;

	[Tooltip("Maximum delay between each attempted howl. Next howl time is randomized between minimum and maximum delay time. Time in seconds.")]
	[Token(Token = "0x4000E7B")]
	[FieldOffset(Offset = "0x38")]
	public int m_HowlMaximumDelay;

	[Tooltip("Maximum number of wolves, excluding the howl starter, that will respond.")]
	[Token(Token = "0x4000E7C")]
	[FieldOffset(Offset = "0x3C")]
	public int m_MaximumNumberOfResponses;

	[Token(Token = "0x4000E7D")]
	[FieldOffset(Offset = "0x40")]
	private bool m_Debug;

	[Token(Token = "0x4000E7E")]
	[FieldOffset(Offset = "0x48")]
	private AiBaseWolf m_LastHowler;

	[Token(Token = "0x4000E7F")]
	[FieldOffset(Offset = "0x50")]
	private List<AiBaseWolf> m_RespondersList;

	[Token(Token = "0x4000E80")]
	[FieldOffset(Offset = "0x58")]
	private List<AiBaseWolf> m_Wolves;

	[Token(Token = "0x4000E81")]
	[FieldOffset(Offset = "0x60")]
	private int m_CurrentHowl;

	[Token(Token = "0x4000E82")]
	[FieldOffset(Offset = "0x64")]
	private int m_NextHowl;

	[Token(Token = "0x4000E83")]
	[FieldOffset(Offset = "0x68")]
	private float m_NextHowlTimer;

	[Token(Token = "0x6000F24")]
	[Address(RVA = "0x60B760", Offset = "0x60A560", Length = "0xBB")]
	public void Add(AiBaseWolf wolf)
	{
	}

	[Token(Token = "0x6000F25")]
	[Address(RVA = "0x60B820", Offset = "0x60A620", Length = "0x8")]
	public void ForceNextHowl()
	{
	}

	[Token(Token = "0x6000F26")]
	[Address(RVA = "0x60B830", Offset = "0x60A630", Length = "0x12")]
	public string GetDebugTimerText()
	{
		return null;
	}

	[Token(Token = "0x6000F27")]
	[Address(RVA = "0x60B830", Offset = "0x60A630", Length = "0x12")]
	public string GetDebugWolfListTest()
	{
		return null;
	}

	[Token(Token = "0x6000F28")]
	[Address(RVA = "0x60B850", Offset = "0x60A650", Length = "0x58")]
	public void Remove(AiBaseWolf wolf)
	{
	}

	[Token(Token = "0x6000F29")]
	[Address(RVA = "0x60B8B0", Offset = "0x60A6B0", Length = "0x17F")]
	public void RequestHowl(AiBaseWolf wolf, bool isLead)
	{
	}

	[Token(Token = "0x6000F2A")]
	[Address(RVA = "0x60BA30", Offset = "0x60A830", Length = "0x64")]
	public void Reset()
	{
	}

	[Token(Token = "0x6000F2B")]
	[Address(RVA = "0x60BAA0", Offset = "0x60A8A0", Length = "0x131")]
	public void Update()
	{
	}

	[Conditional("__DEBUG")]
	[Token(Token = "0x6000F2C")]
	[Address(RVA = "0x60BBE0", Offset = "0x60A9E0", Length = "0x3")]
	private void DebugLog(string message)
	{
	}

	[Token(Token = "0x6000F2D")]
	[Address(RVA = "0x60BBF0", Offset = "0x60A9F0", Length = "0x8E")]
	private void StartLeadHowl(AiBaseWolf wolf)
	{
	}

	[Token(Token = "0x6000F2E")]
	[Address(RVA = "0x60BC80", Offset = "0x60AA80", Length = "0x80")]
	private float StartResponseHowl(AiBaseWolf wolf, float baseTime)
	{
		return 0f;
	}

	[Token(Token = "0x6000F2F")]
	[Address(RVA = "0x60BD10", Offset = "0x60AB10", Length = "0x74")]
	private void SetNextTimer()
	{
	}

	[Token(Token = "0x6000F30")]
	[Address(RVA = "0x60BD90", Offset = "0x60AB90", Length = "0x284")]
	private void UpdateCurrentHowl()
	{
	}

	[Token(Token = "0x6000F31")]
	[Address(RVA = "0x60C020", Offset = "0x60AE20", Length = "0xA1A")]
	private void UpdateTimer()
	{
	}

	[Token(Token = "0x6000F32")]
	[Address(RVA = "0x60CA40", Offset = "0x60B840", Length = "0x17D")]
	public WolfHowlController()
	{
	}
}
