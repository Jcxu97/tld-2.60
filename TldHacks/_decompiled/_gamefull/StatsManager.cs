using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.Gameplay;
using TLD.IntBackedUnit;
using TLD.OptionalContent;
using TLD.SaveState;
using TLD.Stats;
using UnityEngine;

[Token(Token = "0x20007E7")]
public class StatsManager : MonoBehaviour
{
	[Token(Token = "0x20007E8")]
	public delegate void IncrementStatDelegate(StatID id, float amount);

	[Token(Token = "0x20007E9")]
	public delegate void SetStatDelegate(StatID id, float previous, float current);

	[Header("DLC")]
	[SerializeField]
	[Token(Token = "0x4005493")]
	[FieldOffset(Offset = "0x20")]
	private OptionalContentConfig m_ContentConfig;

	[Token(Token = "0x4005494")]
	private static readonly Dictionary<int, StatInfo> m_StatInfo;

	[HideInInspector]
	[Token(Token = "0x4005495")]
	public static StatContainer m_CurrentSessionStatsContainer;

	[HideInInspector]
	[Token(Token = "0x4005496")]
	public static List<StatContainer> m_AllTimeStatsContainer;

	[Token(Token = "0x4005497")]
	public static IncrementStatDelegate OnIncrementStat;

	[Token(Token = "0x4005498")]
	public static SetStatDelegate OnSetStat;

	[Token(Token = "0x4005499")]
	private static readonly string[] s_OrderedSandboxNames;

	[Token(Token = "0x400549A")]
	private static readonly SandboxConfig[] s_OrderedSandboxModes;

	[Token(Token = "0x6004A7D")]
	[Address(RVA = "0xD3B230", Offset = "0xD3A030", Length = "0x171F")]
	public void Start()
	{
	}

	[Token(Token = "0x6004A7E")]
	[Address(RVA = "0xD3C950", Offset = "0xD3B750", Length = "0xBC")]
	public static string SerializeCurrentSession()
	{
		return null;
	}

	[Token(Token = "0x6004A7F")]
	[Address(RVA = "0xD3CA10", Offset = "0xD3B810", Length = "0x168")]
	public static void DeserializeCurrentSession(string text)
	{
	}

	[Token(Token = "0x6004A80")]
	[Address(RVA = "0xD3CB80", Offset = "0xD3B980", Length = "0x121")]
	private static void SerializeAllTimeStats(ProfileState profileState)
	{
	}

	[Token(Token = "0x6004A81")]
	[Address(RVA = "0xD3CCB0", Offset = "0xD3BAB0", Length = "0x137")]
	private static void DeserializeAllTimeStats(ProfileState profileState)
	{
	}

	[Token(Token = "0x6004A82")]
	[Address(RVA = "0xD3CDF0", Offset = "0xD3BBF0", Length = "0xD7")]
	public static void Reset()
	{
	}

	[Token(Token = "0x6004A83")]
	[Address(RVA = "0xD3CED0", Offset = "0xD3BCD0", Length = "0x163")]
	private void SetStatInfo(StatID statId, string locId, string spriteName, StatInfo.Format format, bool hidden)
	{
	}

	[Token(Token = "0x6004A84")]
	[Address(RVA = "0xD3D040", Offset = "0xD3BE40", Length = "0x2D2")]
	private static void MaybeInitializeSandboxModes()
	{
	}

	[Token(Token = "0x6004A85")]
	[Address(RVA = "0xD3D320", Offset = "0xD3C120", Length = "0x160")]
	private static void MaybeInitializeAllTimeBestStats()
	{
	}

	[Token(Token = "0x6004A86")]
	[Address(RVA = "0xD3D490", Offset = "0xD3C290", Length = "0x352")]
	private static void MaybeUpdateAllTimeBestStat(StatID id, float value)
	{
	}

	[Token(Token = "0x6004A87")]
	[Address(RVA = "0xD3D7F0", Offset = "0xD3C5F0", Length = "0x6C")]
	public static float GetValue(StatID id)
	{
		return 0f;
	}

	[Token(Token = "0x6004A88")]
	[Address(RVA = "0xD3D860", Offset = "0xD3C660", Length = "0x107")]
	private static bool CanTrackStats()
	{
		return false;
	}

	[Token(Token = "0x6004A89")]
	[Address(RVA = "0xD3D970", Offset = "0xD3C770", Length = "0x140")]
	public static void SetValue(StatID id, float value)
	{
	}

	[Token(Token = "0x6004A8A")]
	[Address(RVA = "0xD3DAC0", Offset = "0xD3C8C0", Length = "0xA7")]
	public static float IncrementValue(StatID id, ItemWeight increment)
	{
		return 0f;
	}

	[Token(Token = "0x6004A8B")]
	[Address(RVA = "0xD3DB70", Offset = "0xD3C970", Length = "0x298")]
	public static float IncrementValue(StatID id, float increment = 1f)
	{
		return 0f;
	}

	[Token(Token = "0x6004A8C")]
	[Address(RVA = "0xD3DE10", Offset = "0xD3CC10", Length = "0x2AE")]
	private static void MaybeComputeDependentStats(StatID id)
	{
	}

	[Token(Token = "0x6004A8D")]
	[Address(RVA = "0xD3E0C0", Offset = "0xD3CEC0", Length = "0x5F4")]
	public static void CheckBurntHousesInCoastal()
	{
	}

	[Token(Token = "0x6004A8E")]
	[Address(RVA = "0xD3E6C0", Offset = "0xD3D4C0", Length = "0x16E")]
	public static StatInfo GetStatInfo(StatID statId)
	{
		return null;
	}

	[Token(Token = "0x6004A8F")]
	[Address(RVA = "0xD3E830", Offset = "0xD3D630", Length = "0xC4")]
	public static void FixUpCurrentSessionLongestBurningFireStat()
	{
	}

	[Token(Token = "0x6004A90")]
	[Address(RVA = "0xD3E900", Offset = "0xD3D700", Length = "0x174")]
	public static void MigrateSavedData(string serialized)
	{
	}

	[Token(Token = "0x6004A91")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public StatsManager()
	{
	}
}
