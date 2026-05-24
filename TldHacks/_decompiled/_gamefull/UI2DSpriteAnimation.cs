using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20000F0")]
public class UI2DSpriteAnimation : MonoBehaviour
{
	[SerializeField]
	[Token(Token = "0x400076B")]
	[FieldOffset(Offset = "0x20")]
	protected int framerate;

	[Token(Token = "0x400076C")]
	[FieldOffset(Offset = "0x24")]
	public bool ignoreTimeScale;

	[Token(Token = "0x400076D")]
	[FieldOffset(Offset = "0x25")]
	public bool loop;

	[Token(Token = "0x400076E")]
	[FieldOffset(Offset = "0x28")]
	public Sprite[] frames;

	[Token(Token = "0x400076F")]
	[FieldOffset(Offset = "0x30")]
	private SpriteRenderer mUnitySprite;

	[Token(Token = "0x4000770")]
	[FieldOffset(Offset = "0x38")]
	private UI2DSprite mNguiSprite;

	[Token(Token = "0x4000771")]
	[FieldOffset(Offset = "0x40")]
	private int mIndex;

	[Token(Token = "0x4000772")]
	[FieldOffset(Offset = "0x44")]
	private float mUpdate;

	[Token(Token = "0x170000FC")]
	public bool isPlaying
	{
		[Token(Token = "0x60008AA")]
		[Address(RVA = "0x8EC8D0", Offset = "0x8EB6D0", Length = "0x98")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x170000FD")]
	public int framesPerSecond
	{
		[Token(Token = "0x60008AB")]
		[Address(RVA = "0x4571E0", Offset = "0x455FE0", Length = "0x4")]
		get
		{
			return 0;
		}
		[Token(Token = "0x60008AC")]
		[Address(RVA = "0x509350", Offset = "0x508150", Length = "0x4")]
		set
		{
		}
	}

	[Token(Token = "0x60008AD")]
	[Address(RVA = "0x112F370", Offset = "0x112E170", Length = "0x8E")]
	public void Play()
	{
	}

	[Token(Token = "0x60008AE")]
	[Address(RVA = "0xE3D9F0", Offset = "0xE3C7F0", Length = "0xA")]
	public void Pause()
	{
	}

	[Token(Token = "0x60008AF")]
	[Address(RVA = "0x112F400", Offset = "0x112E200", Length = "0x3B")]
	public void ResetToBeginning()
	{
	}

	[Token(Token = "0x60008B0")]
	[Address(RVA = "0x112F370", Offset = "0x112E170", Length = "0x8E")]
	private void Start()
	{
	}

	[Token(Token = "0x60008B1")]
	[Address(RVA = "0x112F440", Offset = "0x112E240", Length = "0xE9")]
	private void Update()
	{
	}

	[Token(Token = "0x60008B2")]
	[Address(RVA = "0x112F530", Offset = "0x112E330", Length = "0x6F0")]
	private void UpdateSprite()
	{
	}

	[Token(Token = "0x60008B3")]
	[Address(RVA = "0x112FC30", Offset = "0x112EA30", Length = "0x50")]
	public UI2DSpriteAnimation()
	{
	}
}
