using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Serialization;

[Token(Token = "0x20009D1")]
public class PlayAudioTrigger : MonoBehaviour
{
	[Token(Token = "0x40063AB")]
	[FieldOffset(Offset = "0x20")]
	public TimeToPlay m_TimeOfDayToPlay;

	[FormerlySerializedAs("m_Audio")]
	[Token(Token = "0x40063AC")]
	[FieldOffset(Offset = "0x28")]
	public string m_AudioFirstTime;

	[Token(Token = "0x40063AD")]
	[FieldOffset(Offset = "0x30")]
	public string m_AudioSubsequentTimes;

	[Token(Token = "0x40063AE")]
	[FieldOffset(Offset = "0x38")]
	public bool m_PlayOnlyOnce;

	[Tooltip("This object will match the enabled/disabled state of its Object Link")]
	[Token(Token = "0x40063AF")]
	[FieldOffset(Offset = "0x40")]
	public GameObject m_ObjectLink;

	[Token(Token = "0x40063B0")]
	[FieldOffset(Offset = "0x48")]
	private int m_NumPlays;

	[Token(Token = "0x40063B1")]
	[FieldOffset(Offset = "0x4C")]
	private uint m_AudioID;

	[Token(Token = "0x40063B2")]
	[FieldOffset(Offset = "0x50")]
	private uint m_NumUpdatesSinceSceneLoad;

	[Token(Token = "0x40063B3")]
	[FieldOffset(Offset = "0x54")]
	private bool m_DidObjectLink;

	[Token(Token = "0x40063B4")]
	[FieldOffset(Offset = "0x58")]
	private string m_ObjectLinkGuid;

	[Token(Token = "0x40063B5")]
	[FieldOffset(Offset = "0x60")]
	private bool m_StartHasBeenCalled;

	[Token(Token = "0x40063B6")]
	private static PlayMusicTriggerSaveDataProxy m_PlayMusicTriggerSaveDataProxy;

	[Token(Token = "0x40063B7")]
	private static List<PlayAudioTrigger> m_PlayAudioTriggers;

	[Token(Token = "0x60056A4")]
	[Address(RVA = "0xEBC820", Offset = "0xEBB620", Length = "0x14F")]
	private void Awake()
	{
	}

	[Token(Token = "0x60056A5")]
	[Address(RVA = "0xEBC970", Offset = "0xEBB770", Length = "0x164")]
	public void Start()
	{
	}

	[Token(Token = "0x60056A6")]
	[Address(RVA = "0xEBCAE0", Offset = "0xEBB8E0", Length = "0x232")]
	public void Update()
	{
	}

	[Token(Token = "0x60056A7")]
	[Address(RVA = "0xEBCD20", Offset = "0xEBBB20", Length = "0x2CA")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x60056A8")]
	[Address(RVA = "0xEBCFF0", Offset = "0xEBBDF0", Length = "0x1EE")]
	public void Deserialize(string text)
	{
	}

	[Token(Token = "0x60056A9")]
	[Address(RVA = "0xEBD1E0", Offset = "0xEBBFE0", Length = "0x94")]
	public static void Reset()
	{
	}

	[Token(Token = "0x60056AA")]
	[Address(RVA = "0xEBD280", Offset = "0xEBC080", Length = "0x32F")]
	public static string SerializeAll()
	{
		return null;
	}

	[Token(Token = "0x60056AB")]
	[Address(RVA = "0xEBD5B0", Offset = "0xEBC3B0", Length = "0x1F3")]
	public static void DeserializeAll(string text)
	{
	}

	[Token(Token = "0x60056AC")]
	[Address(RVA = "0xEBD7B0", Offset = "0xEBC5B0", Length = "0x1BD")]
	public static void PlayAudioTriggerEndCallback(object in_cookie, AkCallbackType in_type, object in_info)
	{
	}

	[Token(Token = "0x60056AD")]
	[Address(RVA = "0xEBD970", Offset = "0xEBC770", Length = "0x1EA")]
	public void Play()
	{
	}

	[Token(Token = "0x60056AE")]
	[Address(RVA = "0xEBDB60", Offset = "0xEBC960", Length = "0x7B")]
	private void OnTriggerEnter(Collider c)
	{
	}

	[Token(Token = "0x60056AF")]
	[Address(RVA = "0xEBDBE0", Offset = "0xEBC9E0", Length = "0x33E")]
	private static PlayAudioTrigger FindPlayAudioTriggerByPosition(PlayMusicTriggerSaveDataProxy proxy)
	{
		return null;
	}

	[Token(Token = "0x60056B0")]
	[Address(RVA = "0xEBDF20", Offset = "0xEBCD20", Length = "0x117")]
	private static PlayAudioTrigger FindPlayAudioTriggerByGuid(string guid)
	{
		return null;
	}

	[Token(Token = "0x60056B1")]
	[Address(RVA = "0xEBE040", Offset = "0xEBCE40", Length = "0xC2")]
	public PlayAudioTrigger()
	{
	}
}
