using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200004F")]
public class LagPosition : MonoBehaviour
{
	[Token(Token = "0x4000359")]
	[FieldOffset(Offset = "0x20")]
	public Vector3 speed;

	[Token(Token = "0x400035A")]
	[FieldOffset(Offset = "0x2C")]
	public bool ignoreTimeScale;

	[Token(Token = "0x400035B")]
	[FieldOffset(Offset = "0x30")]
	private Transform mTrans;

	[Token(Token = "0x400035C")]
	[FieldOffset(Offset = "0x38")]
	private Vector3 mRelative;

	[Token(Token = "0x400035D")]
	[FieldOffset(Offset = "0x44")]
	private Vector3 mAbsolute;

	[Token(Token = "0x400035E")]
	[FieldOffset(Offset = "0x50")]
	private bool mStarted;

	[Token(Token = "0x6000363")]
	[Address(RVA = "0xA1D700", Offset = "0xA1C500", Length = "0x10")]
	public void OnRepositionEnd()
	{
	}

	[Token(Token = "0x6000364")]
	[Address(RVA = "0xA1D710", Offset = "0xA1C510", Length = "0x404")]
	private void Interpolate(float delta)
	{
	}

	[Token(Token = "0x6000365")]
	[Address(RVA = "0xA1DB20", Offset = "0xA1C920", Length = "0x57")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000366")]
	[Address(RVA = "0xA1DB80", Offset = "0xA1C980", Length = "0xE")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000367")]
	[Address(RVA = "0xA1DB90", Offset = "0xA1C990", Length = "0xB")]
	private void Start()
	{
	}

	[Token(Token = "0x6000368")]
	[Address(RVA = "0xA1DBA0", Offset = "0xA1C9A0", Length = "0x17B")]
	public void ResetPosition()
	{
	}

	[Token(Token = "0x6000369")]
	[Address(RVA = "0xA1DD20", Offset = "0xA1CB20", Length = "0x9B")]
	private void Update()
	{
	}

	[Token(Token = "0x600036A")]
	[Address(RVA = "0xA1DDC0", Offset = "0xA1CBC0", Length = "0x6B")]
	public LagPosition()
	{
	}
}
