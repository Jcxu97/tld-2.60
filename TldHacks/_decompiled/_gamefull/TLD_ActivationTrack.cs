using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

[Token(Token = "0x2000995")]
public class TLD_ActivationTrack : ActivationTrack, TLD_IDynamicBindableTrack, TLD_ITrack
{
	[Header("Binding")]
	[Token(Token = "0x4006284")]
	[FieldOffset(Offset = "0xB0")]
	public string m_MissionObjectId;

	[Token(Token = "0x4006285")]
	[FieldOffset(Offset = "0xB8")]
	public string m_ChildObjectName;

	[Header("Custom Managed Object")]
	[Token(Token = "0x4006286")]
	[FieldOffset(Offset = "0xC0")]
	public bool m_PersistState;

	[Token(Token = "0x4006287")]
	[FieldOffset(Offset = "0xC8")]
	private GameObject m_BindingObject;

	[Token(Token = "0x4006288")]
	[FieldOffset(Offset = "0xD0")]
	private bool m_InitialBindingObjectState;

	[Token(Token = "0x6005591")]
	[Address(RVA = "0xE9F600", Offset = "0xE9E400", Length = "0x1D1")]
	public void DoDynamicBinding(PlayableDirector director)
	{
	}

	[Token(Token = "0x6005592")]
	[Address(RVA = "0xE9F7E0", Offset = "0xE9E5E0", Length = "0x16A")]
	public void Stop()
	{
	}

	[Token(Token = "0x6005593")]
	[Address(RVA = "0xE9F950", Offset = "0xE9E750", Length = "0x4E")]
	private bool GetPersistedState()
	{
		return false;
	}

	[Token(Token = "0x6005594")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public void Play()
	{
	}

	[Token(Token = "0x6005595")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public void UpdatePlay()
	{
	}

	[Token(Token = "0x6005596")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public void LateUpdatePlay()
	{
	}

	[Token(Token = "0x6005597")]
	[Address(RVA = "0xE9F9A0", Offset = "0xE9E7A0", Length = "0x58")]
	public TLD_ActivationTrack()
	{
	}
}
