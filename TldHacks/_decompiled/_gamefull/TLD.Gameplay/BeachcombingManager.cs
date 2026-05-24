using Cpp2ILInjected;
using TLD.Events;
using TLD.Logging;
using UnityEngine;

namespace TLD.Gameplay;

[Token(Token = "0x2001459")]
public class BeachcombingManager : MonoBehaviour
{
	[Token(Token = "0x40093C9")]
	public static LogFilter s_LogFilter;

	[SerializeField]
	[Token(Token = "0x40093CA")]
	[FieldOffset(Offset = "0x20")]
	private WeatherStageChangeEvent m_WeatherStageChangeEvent;

	[Token(Token = "0x40093CB")]
	private static BeachcombingManagerSaveData m_CurrentState;

	[Token(Token = "0x40093CD")]
	[FieldOffset(Offset = "0x28")]
	private WeatherStage m_CurrentWeatherStage;

	[Token(Token = "0x17000B32")]
	public static int BlizzardID
	{
		[Token(Token = "0x600817F")]
		[Address(RVA = "0x121DC70", Offset = "0x121CA70", Length = "0x61")]
		get
		{
			return 0;
		}
	}

	[Token(Token = "0x17000B33")]
	public static float TimeSinceLastBlizzard
	{
		[Token(Token = "0x6008180")]
		[Address(RVA = "0x121DCE0", Offset = "0x121CAE0", Length = "0xB2")]
		get
		{
			return 0f;
		}
	}

	[Token(Token = "0x17000B34")]
	[field: Token(Token = "0x40093CC")]
	public static bool IsFakeBlizzard
	{
		[Token(Token = "0x6008181")]
		[Address(RVA = "0x121DDA0", Offset = "0x121CBA0", Length = "0x54")]
		get;
		[Token(Token = "0x6008182")]
		[Address(RVA = "0x121DE00", Offset = "0x121CC00", Length = "0x59")]
		private set;
	}

	[Token(Token = "0x6008183")]
	[Address(RVA = "0x121DE60", Offset = "0x121CC60", Length = "0x136")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6008184")]
	[Address(RVA = "0x121DFA0", Offset = "0x121CDA0", Length = "0x21C")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6008185")]
	[Address(RVA = "0x121E1C0", Offset = "0x121CFC0", Length = "0x121")]
	private void OnWeatherChanged()
	{
	}

	[Token(Token = "0x6008186")]
	[Address(RVA = "0x121E2F0", Offset = "0x121D0F0", Length = "0xD6")]
	private void Update()
	{
	}

	[Token(Token = "0x6008187")]
	[Address(RVA = "0x121E3D0", Offset = "0x121D1D0", Length = "0xE4")]
	private static void StartNewBlizzard()
	{
	}

	[Token(Token = "0x6008188")]
	[Address(RVA = "0x121E4C0", Offset = "0x121D2C0", Length = "0x86")]
	public static string Serialize()
	{
		return null;
	}

	[Token(Token = "0x6008189")]
	[Address(RVA = "0x121E550", Offset = "0x121D350", Length = "0x146")]
	public static void Deserialize(string text)
	{
	}

	[Token(Token = "0x600818A")]
	[Address(RVA = "0x121E6A0", Offset = "0x121D4A0", Length = "0xE0")]
	public static void DebugForceBlizzard(bool active)
	{
	}

	[Token(Token = "0x600818B")]
	[Address(RVA = "0x121E790", Offset = "0x121D590", Length = "0x250")]
	public static string GetDebugString()
	{
		return null;
	}

	[Token(Token = "0x600818C")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public BeachcombingManager()
	{
	}
}
