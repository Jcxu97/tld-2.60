using AK.Wwise;
using Cpp2ILInjected;
using UnityEngine;

namespace Audio.SimpleAudio;

[Token(Token = "0x200133A")]
public abstract class BaseTracker
{
	[Token(Token = "0x4008DDF")]
	private const float MAX_PLAY_DISTANCE = 500f;

	[Token(Token = "0x4008DE0")]
	[FieldOffset(Offset = "0x10")]
	public float m_Delta;

	[Token(Token = "0x4008DE1")]
	[FieldOffset(Offset = "0x18")]
	protected GameObject m_GameObject;

	[Token(Token = "0x4008DE2")]
	[FieldOffset(Offset = "0x20")]
	protected Vector3 m_Pos;

	[Token(Token = "0x4008DE3")]
	[FieldOffset(Offset = "0x2C")]
	protected float m_Radius;

	[Token(Token = "0x4008DE4")]
	[FieldOffset(Offset = "0x30")]
	protected bool m_StopWhenDisabled;

	[Token(Token = "0x6007B3D")]
	public abstract void Cleanup();

	[Token(Token = "0x6007B3E")]
	public abstract bool HasProxy();

	[Token(Token = "0x6007B3F")]
	public abstract bool IsActive();

	[Token(Token = "0x6007B40")]
	protected abstract void Start();

	[Token(Token = "0x6007B41")]
	protected abstract void Stop();

	[Token(Token = "0x6007B42")]
	[Address(RVA = "0x119F0B0", Offset = "0x119DEB0", Length = "0x14F")]
	protected BaseTracker(GameObject go, float radius, bool stopWhenDisabled)
	{
	}

	[Token(Token = "0x6007B43")]
	[Address(RVA = "0x119F200", Offset = "0x119E000", Length = "0x133")]
	public virtual bool Matches(GameObject go, AK.Wwise.Event akEvent)
	{
		return false;
	}

	[Token(Token = "0x6007B44")]
	[Address(RVA = "0x119F340", Offset = "0x119E140", Length = "0x32")]
	public void Reset()
	{
	}

	[Token(Token = "0x6007B45")]
	[Address(RVA = "0x119F380", Offset = "0x119E180", Length = "0x1D3")]
	public int MaybeStartOrStop(Vector3 listenerPos)
	{
		return 0;
	}

	[Token(Token = "0x6007B46")]
	[Address(RVA = "0x119F560", Offset = "0x119E360", Length = "0x53")]
	private bool ShouldStart()
	{
		return false;
	}

	[Token(Token = "0x6007B47")]
	[Address(RVA = "0x119F5C0", Offset = "0x119E3C0", Length = "0x6A")]
	private bool ShouldStop()
	{
		return false;
	}
}
