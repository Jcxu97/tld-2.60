using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Timeline;

[Token(Token = "0x2000841")]
public class ScriptLight : MonoBehaviour, ITimeControl
{
	[Token(Token = "0x2000842")]
	public enum ScriptLightState
	{
		[Token(Token = "0x400566F")]
		Off,
		[Token(Token = "0x4005670")]
		TurnedOn,
		[Token(Token = "0x4005671")]
		FadingOut
	}

	[Token(Token = "0x2000843")]
	private struct LightInfo
	{
		[Token(Token = "0x4005672")]
		[FieldOffset(Offset = "0x0")]
		public Light m_Light;

		[Token(Token = "0x4005673")]
		[FieldOffset(Offset = "0x8")]
		public float m_StartIntensity;
	}

	[Token(Token = "0x2000844")]
	public class ScriptLightSaveData
	{
		[Token(Token = "0x4005674")]
		[FieldOffset(Offset = "0x10")]
		public ScriptLightState m_State;

		[Token(Token = "0x4005675")]
		[FieldOffset(Offset = "0x18")]
		public string m_GUID;

		[Token(Token = "0x6004CA3")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public ScriptLightSaveData()
		{
		}
	}

	[Token(Token = "0x400565A")]
	[FieldOffset(Offset = "0x20")]
	public float m_TimelineFadeoutDurationSeconds;

	[Token(Token = "0x400565B")]
	[FieldOffset(Offset = "0x24")]
	public bool m_TurnOnOnStart;

	[Token(Token = "0x400565C")]
	[FieldOffset(Offset = "0x25")]
	public bool m_FadeoutWithDistance;

	[Token(Token = "0x400565D")]
	[FieldOffset(Offset = "0x28")]
	public float m_FadeOutStartDistance;

	[Token(Token = "0x400565E")]
	[FieldOffset(Offset = "0x2C")]
	public float m_FadeOutEndDistance;

	[Token(Token = "0x400565F")]
	[FieldOffset(Offset = "0x30")]
	public List<Light> m_Lights;

	[Token(Token = "0x4005660")]
	[FieldOffset(Offset = "0x38")]
	public GameObject m_FadeOutReference;

	[Token(Token = "0x4005661")]
	[FieldOffset(Offset = "0x40")]
	private float m_TimerFadeOutDuration;

	[Token(Token = "0x4005662")]
	[FieldOffset(Offset = "0x44")]
	private bool m_FadeOutStartTimeRequested;

	[Token(Token = "0x4005663")]
	[FieldOffset(Offset = "0x48")]
	private float m_FadeOutStartTime;

	[Token(Token = "0x4005664")]
	[FieldOffset(Offset = "0x4C")]
	private float m_TimelineFadeValue;

	[Token(Token = "0x4005665")]
	[FieldOffset(Offset = "0x50")]
	private float m_DistanceFadeValue;

	[Token(Token = "0x4005666")]
	[FieldOffset(Offset = "0x54")]
	private bool m_IsControlledByTimeline;

	[Token(Token = "0x4005667")]
	[FieldOffset(Offset = "0x58")]
	private List<LightInfo> m_LightInfos;

	[Token(Token = "0x4005668")]
	[FieldOffset(Offset = "0x60")]
	private bool m_IsTimerControlled;

	[Token(Token = "0x4005669")]
	[FieldOffset(Offset = "0x64")]
	private float m_TimerControlledValue;

	[Token(Token = "0x400566A")]
	[FieldOffset(Offset = "0x68")]
	private float m_TimeElapsed;

	[Token(Token = "0x400566B")]
	[FieldOffset(Offset = "0x6C")]
	private ScriptLightState m_State;

	[Token(Token = "0x400566C")]
	[FieldOffset(Offset = "0x70")]
	private string m_GUID;

	[Token(Token = "0x400566D")]
	private static List<ScriptLight> s_ActiveScriptLights;

	[Token(Token = "0x6004C8D")]
	[Address(RVA = "0xD73480", Offset = "0xD72280", Length = "0x4F9")]
	public void Awake()
	{
	}

	[Token(Token = "0x6004C8E")]
	[Address(RVA = "0xD73980", Offset = "0xD72780", Length = "0x8")]
	public void TurnOn()
	{
	}

	[Token(Token = "0x6004C8F")]
	[Address(RVA = "0xD73990", Offset = "0xD72790", Length = "0xCF")]
	public void SetTime(double time)
	{
	}

	[Token(Token = "0x6004C90")]
	[Address(RVA = "0xD73A60", Offset = "0xD72860", Length = "0x10")]
	public void OnControlTimeStart()
	{
	}

	[Token(Token = "0x6004C91")]
	[Address(RVA = "0xD73A70", Offset = "0xD72870", Length = "0xC")]
	public void OnControlTimeStop()
	{
	}

	[Token(Token = "0x6004C92")]
	[Address(RVA = "0xD73A80", Offset = "0xD72880", Length = "0x11C")]
	public void Update()
	{
	}

	[Token(Token = "0x6004C93")]
	[Address(RVA = "0xD73BA0", Offset = "0xD729A0", Length = "0x136")]
	public void LateUpdate()
	{
	}

	[Token(Token = "0x6004C94")]
	[Address(RVA = "0xD73CE0", Offset = "0xD72AE0", Length = "0x19")]
	public void StartTimerFadeOut(float fadeoutDuration)
	{
	}

	[Token(Token = "0x6004C95")]
	[Address(RVA = "0x8051B0", Offset = "0x803FB0", Length = "0x8")]
	public bool IsTurnedOff()
	{
		return false;
	}

	[Token(Token = "0x6004C96")]
	[Address(RVA = "0xD73D00", Offset = "0xD72B00", Length = "0x93")]
	public static void Reset()
	{
	}

	[Token(Token = "0x6004C97")]
	[Address(RVA = "0xD73DA0", Offset = "0xD72BA0", Length = "0x3B3")]
	public static string SerializeAll()
	{
		return null;
	}

	[Token(Token = "0x6004C98")]
	[Address(RVA = "0xD74160", Offset = "0xD72F60", Length = "0x1C8")]
	public static ScriptLight GetScriptLight(Light l)
	{
		return null;
	}

	[Token(Token = "0x6004C99")]
	[Address(RVA = "0xD74330", Offset = "0xD73130", Length = "0x31D")]
	public static void DeserializeAll(string text)
	{
	}

	[Token(Token = "0x6004C9A")]
	[Address(RVA = "0xD74650", Offset = "0xD73450", Length = "0x9B")]
	private void Update_FadeOut()
	{
	}

	[Token(Token = "0x6004C9B")]
	[Address(RVA = "0xD746F0", Offset = "0xD734F0", Length = "0x225")]
	private void Update_TurnedOff()
	{
	}

	[Token(Token = "0x6004C9C")]
	[Address(RVA = "0xD74920", Offset = "0xD73720", Length = "0x23")]
	private void Update_TurnedOn()
	{
	}

	[Token(Token = "0x6004C9D")]
	[Address(RVA = "0xD74950", Offset = "0xD73750", Length = "0x2A0")]
	private void UpdateLights(float fadeValue)
	{
	}

	[Token(Token = "0x6004C9E")]
	[Address(RVA = "0xD74C00", Offset = "0xD73A00", Length = "0x41A")]
	private float GetFadeDistanceValue()
	{
		return 0f;
	}

	[Token(Token = "0x6004C9F")]
	[Address(RVA = "0xD73A60", Offset = "0xD72860", Length = "0x10")]
	private void StartTimelineFadeout()
	{
	}

	[Token(Token = "0x6004CA0")]
	[Address(RVA = "0xD75020", Offset = "0xD73E20", Length = "0x117")]
	private static ScriptLight FindActiveScriptLightById(string guid)
	{
		return null;
	}

	[Token(Token = "0x6004CA1")]
	[Address(RVA = "0xD75140", Offset = "0xD73F40", Length = "0xF2")]
	public ScriptLight()
	{
	}
}
