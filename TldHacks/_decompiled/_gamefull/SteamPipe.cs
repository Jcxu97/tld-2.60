using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200095F")]
public class SteamPipe : MonoBehaviour
{
	[Tooltip("The amount of steam to flow as an arbitrary value. Could be litres or percent.")]
	[Range(0f, 100f)]
	[Token(Token = "0x4006163")]
	[FieldOffset(Offset = "0x20")]
	public float m_SourceFlowValue;

	[Tooltip("This value determines how much of the flow value is passed onto the next pipe. Potentially attached to a player interactable object.")]
	[Range(0f, 100f)]
	[Token(Token = "0x4006164")]
	[FieldOffset(Offset = "0x24")]
	public float m_ValveOpenPercent;

	[Tooltip("All in flowing pipes connecting to this one. No inputs is a starting pipe, usually with source steam flow.")]
	[Token(Token = "0x4006165")]
	[FieldOffset(Offset = "0x28")]
	public List<SteamPipeSocket> m_Inputs;

	[Tooltip("All out flowing pipes connecting to this one. No output is usually connected to a steam exhaust.")]
	[Token(Token = "0x4006166")]
	[FieldOffset(Offset = "0x30")]
	public List<SteamPipe> m_Outputs;

	[Tooltip("If another connected pipe is open, it is leaking steam flow and will reduce flow to this pipe.")]
	[Token(Token = "0x4006167")]
	[FieldOffset(Offset = "0x38")]
	public List<SteamPipe> m_BleedPipes;

	[Token(Token = "0x4006168")]
	[FieldOffset(Offset = "0x40")]
	public List<SteamPipeSocket> m_BleedPipeSockets;

	[Tooltip("If there is more than this amount of flow, a frozen pipe becomes unfrozen.")]
	[Token(Token = "0x4006169")]
	[FieldOffset(Offset = "0x48")]
	public float m_UnfrozenFlowValue;

	[Tooltip("If there's different art for frozen specified and the pipe is closed, this game object will be enabled.")]
	[Token(Token = "0x400616A")]
	[FieldOffset(Offset = "0x50")]
	public GameObject m_FrozenPipe;

	[Tooltip("If there's different art for frozen specified and the pipe is opened, this game object will be enabled.")]
	[Token(Token = "0x400616B")]
	[FieldOffset(Offset = "0x58")]
	public GameObject m_UnfrozenPipe;

	[Token(Token = "0x400616C")]
	[FieldOffset(Offset = "0x60")]
	public SteamPipeEffect[] m_VisualEffectPipes;

	[Tooltip("The amount of steam flow required for audio to play.")]
	[Token(Token = "0x400616D")]
	[FieldOffset(Offset = "0x68")]
	public float m_SteamFlowValueAudio;

	[Tooltip("Audio to play when flow is passing through the pipe.")]
	[Token(Token = "0x400616E")]
	[FieldOffset(Offset = "0x70")]
	public string m_SteamFlowAudio;

	[Tooltip("Audio to play when the valve is opening.")]
	[Token(Token = "0x400616F")]
	[FieldOffset(Offset = "0x78")]
	public string m_SteamFlowOpeningAudio;

	[Tooltip("Audio to play when the valve is closing.")]
	[Token(Token = "0x4006170")]
	[FieldOffset(Offset = "0x80")]
	public string m_SteamFlowClosingAudio;

	[NonSerialized]
	[Token(Token = "0x4006171")]
	[FieldOffset(Offset = "0x88")]
	public float m_OutputFlowValue;

	[NonSerialized]
	[Token(Token = "0x4006172")]
	[FieldOffset(Offset = "0x8C")]
	public float m_InternalFlowValue;

	[Token(Token = "0x4006174")]
	public static bool s_Debug;

	[Token(Token = "0x4006175")]
	public static string s_DebugSteamPipeByName;

	[Token(Token = "0x4006176")]
	[FieldOffset(Offset = "0x98")]
	private SteamPipe m_StartPipe;

	[Token(Token = "0x4006177")]
	[FieldOffset(Offset = "0xA0")]
	private bool m_MaybeFrozen;

	[Token(Token = "0x4006178")]
	[FieldOffset(Offset = "0xA4")]
	private uint m_SteamFlowAudioId;

	[Token(Token = "0x4006179")]
	[FieldOffset(Offset = "0xA8")]
	private uint m_SteamFlowOpeningAudioId;

	[Token(Token = "0x400617A")]
	[FieldOffset(Offset = "0xAC")]
	private uint m_SteamFlowClosingAudioId;

	[Token(Token = "0x400617B")]
	[FieldOffset(Offset = "0xB0")]
	private string m_Guid;

	[Token(Token = "0x400617C")]
	[FieldOffset(Offset = "0xB8")]
	private float m_LastInternalFlowValue;

	[Token(Token = "0x400617D")]
	[FieldOffset(Offset = "0xBC")]
	private int m_FlowChangeUpdateCounter;

	[Token(Token = "0x400617E")]
	[FieldOffset(Offset = "0xC0")]
	private int m_FlowSettleFrameCounter;

	[Token(Token = "0x14000018")]
	public event Action<float> InternalFlowValueChanged
	{
		[CompilerGenerated]
		[Token(Token = "0x60054B1")]
		[Address(RVA = "0xE8C6C0", Offset = "0xE8B4C0", Length = "0x166")]
		add
		{
		}
		[CompilerGenerated]
		[Token(Token = "0x60054B2")]
		[Address(RVA = "0xE8C830", Offset = "0xE8B630", Length = "0x166")]
		remove
		{
		}
	}

	[Token(Token = "0x60054B3")]
	[Address(RVA = "0xE8C9A0", Offset = "0xE8B7A0", Length = "0x69")]
	public void Awake()
	{
	}

	[Token(Token = "0x60054B4")]
	[Address(RVA = "0x502310", Offset = "0x501110", Length = "0x8")]
	public string GetGuid()
	{
		return null;
	}

	[Token(Token = "0x60054B5")]
	[Address(RVA = "0xE8CA10", Offset = "0xE8B810", Length = "0x321")]
	private void Start()
	{
	}

	[Token(Token = "0x60054B6")]
	[Address(RVA = "0xE8CD40", Offset = "0xE8BB40", Length = "0xB5")]
	public void OnDestroy()
	{
	}

	[Token(Token = "0x60054B7")]
	[Address(RVA = "0xE8CE00", Offset = "0xE8BC00", Length = "0x794")]
	private void UpdateSteamPipeValues()
	{
	}

	[Token(Token = "0x60054B8")]
	[Address(RVA = "0xE8D5A0", Offset = "0xE8C3A0", Length = "0x16B")]
	public void InteractValve(float percent = 100f)
	{
	}

	[Token(Token = "0x60054B9")]
	[Address(RVA = "0xE8D710", Offset = "0xE8C510", Length = "0x10F")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x60054BA")]
	[Address(RVA = "0xE8D820", Offset = "0xE8C620", Length = "0xFD")]
	public void Deserialize(string text)
	{
	}

	[Token(Token = "0x60054BB")]
	[Address(RVA = "0xE8D920", Offset = "0xE8C720", Length = "0x148")]
	private void MaybePlayOpenCloseAudio()
	{
	}

	[Token(Token = "0x60054BC")]
	[Address(RVA = "0xE8DA70", Offset = "0xE8C870", Length = "0xCD")]
	private void MaybePlaySteamFlowAudio()
	{
	}

	[Token(Token = "0x60054BD")]
	[Address(RVA = "0xE8DB40", Offset = "0xE8C940", Length = "0x20")]
	private void MaybeShowFrozenPipe(bool immediate)
	{
	}

	[Token(Token = "0x60054BE")]
	[Address(RVA = "0xE8DB60", Offset = "0xE8C960", Length = "0x2AB")]
	private void ThawPipes(bool immediate)
	{
	}

	[Token(Token = "0x60054BF")]
	[Address(RVA = "0xE8DE10", Offset = "0xE8CC10", Length = "0xE5")]
	private void Update()
	{
	}

	[Token(Token = "0x60054C0")]
	[Address(RVA = "0xE8DF00", Offset = "0xE8CD00", Length = "0x150")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x60054C1")]
	[Address(RVA = "0xE8E050", Offset = "0xE8CE50", Length = "0x69")]
	public SteamPipe()
	{
	}
}
