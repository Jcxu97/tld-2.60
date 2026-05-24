using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
[Token(Token = "0x2000009")]
public class vp_Explosion : MonoBehaviour
{
	[Token(Token = "0x4000032")]
	[FieldOffset(Offset = "0x20")]
	public float Radius;

	[Token(Token = "0x4000033")]
	[FieldOffset(Offset = "0x24")]
	public float Force;

	[Token(Token = "0x4000034")]
	[FieldOffset(Offset = "0x28")]
	public float UpForce;

	[Token(Token = "0x4000035")]
	[FieldOffset(Offset = "0x2C")]
	public float Damage;

	[Token(Token = "0x4000036")]
	[FieldOffset(Offset = "0x30")]
	public float CameraShake;

	[Token(Token = "0x4000037")]
	[FieldOffset(Offset = "0x38")]
	public string DamageMethodName;

	[Token(Token = "0x4000038")]
	[FieldOffset(Offset = "0x40")]
	public AudioClip Sound;

	[Token(Token = "0x4000039")]
	[FieldOffset(Offset = "0x48")]
	public float SoundMinPitch;

	[Token(Token = "0x400003A")]
	[FieldOffset(Offset = "0x4C")]
	public float SoundMaxPitch;

	[Token(Token = "0x400003B")]
	[FieldOffset(Offset = "0x50")]
	public List<GameObject> FXPrefabs;

	[Token(Token = "0x600004D")]
	[Address(RVA = "0x547E20", Offset = "0x546C20", Length = "0x12F7")]
	private void Awake()
	{
	}

	[Token(Token = "0x600004E")]
	[Address(RVA = "0x549120", Offset = "0x547F20", Length = "0x15B")]
	private void Update()
	{
	}

	[Token(Token = "0x600004F")]
	[Address(RVA = "0x549280", Offset = "0x548080", Length = "0x1A1")]
	public vp_Explosion()
	{
	}
}
