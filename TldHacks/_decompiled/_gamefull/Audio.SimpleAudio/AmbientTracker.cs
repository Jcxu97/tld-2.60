using AK.Wwise;
using Cpp2ILInjected;
using UnityEngine;

namespace Audio.SimpleAudio;

[Token(Token = "0x2001339")]
public class AmbientTracker : BaseTracker
{
	[Token(Token = "0x4008DD6")]
	[FieldOffset(Offset = "0x38")]
	public AK.Wwise.Event m_Event;

	[Token(Token = "0x4008DD7")]
	[FieldOffset(Offset = "0x40")]
	public MultiPositionTypeLabel m_MultiPositionType;

	[Token(Token = "0x4008DD8")]
	[FieldOffset(Offset = "0x48")]
	private GameObject m_DynamicGameObject;

	[Token(Token = "0x4008DD9")]
	[FieldOffset(Offset = "0x50")]
	private AkAmbient m_Ambient;

	[Token(Token = "0x4008DDA")]
	[FieldOffset(Offset = "0x58")]
	private AmbientMultiPositionEnvironmentTracker m_EnvironmentTracker;

	[Token(Token = "0x4008DDB")]
	[FieldOffset(Offset = "0x60")]
	private AkGameObj m_AudioObject;

	[Token(Token = "0x4008DDC")]
	[FieldOffset(Offset = "0x68")]
	private bool m_AudioObjectIsDynamic;

	[Token(Token = "0x4008DDD")]
	[FieldOffset(Offset = "0x69")]
	private bool m_RigidBodyIsDynamic;

	[Token(Token = "0x4008DDE")]
	[FieldOffset(Offset = "0x6A")]
	private bool m_ColliderIsDynamic;

	[Token(Token = "0x17000A4B")]
	public GameObject TargetGameObject
	{
		[Token(Token = "0x6007B35")]
		[Address(RVA = "0x119DE10", Offset = "0x119CC10", Length = "0xDD")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007B36")]
	[Address(RVA = "0x119DEF0", Offset = "0x119CCF0", Length = "0x221")]
	public AmbientTracker(AK.Wwise.Event akEvent, MultiPositionTypeLabel multiposition, GameObject go, float radius, bool stopWhenDisabled)
		: base(null, 0f, stopWhenDisabled: false)
	{
	}

	[Token(Token = "0x6007B37")]
	[Address(RVA = "0x119E120", Offset = "0x119CF20", Length = "0x65C")]
	public override void Cleanup()
	{
	}

	[Token(Token = "0x6007B38")]
	[Address(RVA = "0x119E780", Offset = "0x119D580", Length = "0xCA")]
	public override bool HasProxy()
	{
		return false;
	}

	[Token(Token = "0x6007B39")]
	[Address(RVA = "0x119E850", Offset = "0x119D650", Length = "0xCA")]
	public override bool IsActive()
	{
		return false;
	}

	[Token(Token = "0x6007B3A")]
	[Address(RVA = "0x119E920", Offset = "0x119D720", Length = "0x13D")]
	public override bool Matches(GameObject go, AK.Wwise.Event akEvent)
	{
		return false;
	}

	[Token(Token = "0x6007B3B")]
	[Address(RVA = "0x119EA60", Offset = "0x119D860", Length = "0x5D5")]
	protected override void Start()
	{
	}

	[Token(Token = "0x6007B3C")]
	[Address(RVA = "0x119F040", Offset = "0x119DE40", Length = "0x62")]
	protected override void Stop()
	{
	}
}
