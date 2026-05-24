using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20003EC")]
public class ParticleFadeFire : MonoBehaviour
{
	[Token(Token = "0x4002310")]
	[FieldOffset(Offset = "0x20")]
	public Fire sourceFire;

	[Token(Token = "0x4002311")]
	[FieldOffset(Offset = "0x28")]
	public float fullOnMinutes;

	[Token(Token = "0x4002312")]
	[FieldOffset(Offset = "0x2C")]
	public float fullOffMinutes;

	[Token(Token = "0x4002313")]
	[FieldOffset(Offset = "0x30")]
	public List<ParticleSystem> emitters;

	[Tooltip("Auto stop emitter below minimum time")]
	[Token(Token = "0x4002314")]
	[FieldOffset(Offset = "0x38")]
	public bool autoStop;

	[Tooltip("Auto play emitter above minimum time")]
	[Token(Token = "0x4002315")]
	[FieldOffset(Offset = "0x39")]
	public bool autoPlay;

	[Token(Token = "0x4002316")]
	[FieldOffset(Offset = "0x40")]
	private ParticleInfo[] allPS;

	[Token(Token = "0x4002317")]
	[FieldOffset(Offset = "0x48")]
	private float maxTimeSec;

	[Token(Token = "0x4002318")]
	[FieldOffset(Offset = "0x4C")]
	private float minTimeSec;

	[Token(Token = "0x4002319")]
	[FieldOffset(Offset = "0x50")]
	private float fireTime;

	[Token(Token = "0x400231A")]
	[FieldOffset(Offset = "0x54")]
	private float fadeTimeNormalized;

	[Token(Token = "0x400231B")]
	[FieldOffset(Offset = "0x58")]
	private float fadeTimeDifference;

	[Token(Token = "0x400231C")]
	[FieldOffset(Offset = "0x5C")]
	private float fadeTimeStep;

	[Token(Token = "0x6001E34")]
	[Address(RVA = "0x7B5F00", Offset = "0x7B4D00", Length = "0x432")]
	private void Start()
	{
	}

	[Token(Token = "0x6001E35")]
	[Address(RVA = "0x7B6340", Offset = "0x7B5140", Length = "0x6E1")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6001E36")]
	[Address(RVA = "0x7B6A30", Offset = "0x7B5830", Length = "0x4A")]
	public ParticleFadeFire()
	{
	}
}
