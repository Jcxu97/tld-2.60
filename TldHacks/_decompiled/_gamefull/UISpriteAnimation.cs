using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[ExecuteInEditMode]
[RequireComponent(typeof(UISprite))]
[AddComponentMenu("NGUI/UI/Sprite Animation")]
[Token(Token = "0x2000124")]
public class UISpriteAnimation : MonoBehaviour
{
	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x4000906")]
	[FieldOffset(Offset = "0x20")]
	protected int mFPS;

	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x4000907")]
	[FieldOffset(Offset = "0x28")]
	protected string mPrefix;

	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x4000908")]
	[FieldOffset(Offset = "0x30")]
	protected bool mLoop;

	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x4000909")]
	[FieldOffset(Offset = "0x31")]
	protected bool mSnap;

	[Token(Token = "0x400090A")]
	[FieldOffset(Offset = "0x38")]
	protected UISprite mSprite;

	[Token(Token = "0x400090B")]
	[FieldOffset(Offset = "0x40")]
	protected float mDelta;

	[Token(Token = "0x400090C")]
	[FieldOffset(Offset = "0x44")]
	protected int mIndex;

	[Token(Token = "0x400090D")]
	[FieldOffset(Offset = "0x48")]
	protected bool mActive;

	[Token(Token = "0x400090E")]
	[FieldOffset(Offset = "0x50")]
	protected List<string> mSpriteNames;

	[Token(Token = "0x400090F")]
	[FieldOffset(Offset = "0x58")]
	private bool mIsReversed;

	[Token(Token = "0x1700018C")]
	public int frames
	{
		[Token(Token = "0x6000AB6")]
		[Address(RVA = "0x5C6B80", Offset = "0x5C5980", Length = "0x41")]
		get
		{
			return 0;
		}
	}

	[Token(Token = "0x1700018D")]
	public int framesPerSecond
	{
		[Token(Token = "0x6000AB7")]
		[Address(RVA = "0x4571E0", Offset = "0x455FE0", Length = "0x4")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6000AB8")]
		[Address(RVA = "0x509350", Offset = "0x508150", Length = "0x4")]
		set
		{
		}
	}

	[Token(Token = "0x1700018E")]
	public string namePrefix
	{
		[Token(Token = "0x6000AB9")]
		[Address(RVA = "0x413AB0", Offset = "0x4128B0", Length = "0x5")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000ABA")]
		[Address(RVA = "0x5C6BD0", Offset = "0x5C59D0", Length = "0xAB")]
		set
		{
		}
	}

	[Token(Token = "0x1700018F")]
	public bool loop
	{
		[Token(Token = "0x6000ABB")]
		[Address(RVA = "0x5027A0", Offset = "0x5015A0", Length = "0x5")]
		get
		{
			return false;
		}
		[Token(Token = "0x6000ABC")]
		[Address(RVA = "0x5027B0", Offset = "0x5015B0", Length = "0x4")]
		set
		{
		}
	}

	[Token(Token = "0x17000190")]
	public bool isPlaying
	{
		[Token(Token = "0x6000ABD")]
		[Address(RVA = "0x5C6C80", Offset = "0x5C5A80", Length = "0x5")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x6000ABE")]
	[Address(RVA = "0x5C6C90", Offset = "0x5C5A90", Length = "0x7")]
	protected virtual void Start()
	{
	}

	[Token(Token = "0x6000ABF")]
	[Address(RVA = "0x5C6CA0", Offset = "0x5C5AA0", Length = "0x232")]
	protected virtual void Update()
	{
	}

	[Token(Token = "0x6000AC0")]
	[Address(RVA = "0x5C6EE0", Offset = "0x5C5CE0", Length = "0x445")]
	public void RebuildSpriteList()
	{
	}

	[Token(Token = "0x6000AC1")]
	[Address(RVA = "0x5C7330", Offset = "0x5C6130", Length = "0x5")]
	public void Play()
	{
	}

	[Token(Token = "0x6000AC2")]
	[Address(RVA = "0x5C7340", Offset = "0x5C6140", Length = "0x5")]
	public void Pause()
	{
	}

	[Token(Token = "0x6000AC3")]
	[Address(RVA = "0x5C7350", Offset = "0x5C6150", Length = "0x169")]
	public void PlayReverseFromFrame(int frameVal)
	{
	}

	[Token(Token = "0x6000AC4")]
	[Address(RVA = "0x5C74C0", Offset = "0x5C62C0", Length = "0x58")]
	public int GetCurrentFrame()
	{
		return 0;
	}

	[Token(Token = "0x6000AC5")]
	[Address(RVA = "0x5C7520", Offset = "0x5C6320", Length = "0x169")]
	public void ResetToBeginning()
	{
	}

	[Token(Token = "0x6000AC6")]
	[Address(RVA = "0x5C7690", Offset = "0x5C6490", Length = "0x4")]
	public void SetPixelSnap(bool pixelSnap)
	{
	}

	[Token(Token = "0x6000AC7")]
	[Address(RVA = "0x5C76A0", Offset = "0x5C64A0", Length = "0x171")]
	public UISpriteAnimation()
	{
	}
}
