using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(CapsuleCollider))]
[RequireComponent(typeof(AudioSource))]
[Token(Token = "0x200001A")]
public class vp_Shell : MonoBehaviour
{
	[Token(Token = "0x200001B")]
	public delegate void RestAngleFunc();

	[Token(Token = "0x40001F2")]
	[FieldOffset(Offset = "0x20")]
	public float LifeTime;

	[Token(Token = "0x40001F3")]
	[FieldOffset(Offset = "0x24")]
	protected float m_RemoveTime;

	[Token(Token = "0x40001F4")]
	[FieldOffset(Offset = "0x28")]
	public float m_Persistence;

	[Token(Token = "0x40001F5")]
	[FieldOffset(Offset = "0x30")]
	protected RestAngleFunc m_RestAngleFunc;

	[Token(Token = "0x40001F6")]
	[FieldOffset(Offset = "0x38")]
	protected float m_RestTime;

	[Token(Token = "0x40001F7")]
	[FieldOffset(Offset = "0x40")]
	public List<AudioClip> m_BounceSounds;

	[Token(Token = "0x600019E")]
	[Address(RVA = "0x577C50", Offset = "0x576A50", Length = "0x19A")]
	private void Start()
	{
	}

	[Token(Token = "0x600019F")]
	[Address(RVA = "0x577DF0", Offset = "0x576BF0", Length = "0x42E")]
	private void Update()
	{
	}

	[Token(Token = "0x60001A0")]
	[Address(RVA = "0x578220", Offset = "0x577020", Length = "0x611")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x60001A1")]
	[Address(RVA = "0x578840", Offset = "0x577640", Length = "0x4FF")]
	protected void DecideRestAngle()
	{
	}

	[Token(Token = "0x60001A2")]
	[Address(RVA = "0x578D40", Offset = "0x577B40", Length = "0x45C")]
	protected void UpRight()
	{
	}

	[Token(Token = "0x60001A3")]
	[Address(RVA = "0x5791A0", Offset = "0x577FA0", Length = "0x37C")]
	protected void TippedOver()
	{
	}

	[Token(Token = "0x60001A4")]
	[Address(RVA = "0x579520", Offset = "0x578320", Length = "0xF4")]
	public vp_Shell()
	{
	}
}
