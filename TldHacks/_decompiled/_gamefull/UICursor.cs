using Cpp2ILInjected;
using UnityEngine;

[RequireComponent(typeof(UISprite))]
[AddComponentMenu("NGUI/Examples/UI Cursor")]
[Token(Token = "0x200003C")]
public class UICursor : MonoBehaviour
{
	[Token(Token = "0x40002F1")]
	public static UICursor instance;

	[Token(Token = "0x40002F2")]
	[FieldOffset(Offset = "0x20")]
	public Camera uiCamera;

	[Token(Token = "0x40002F3")]
	[FieldOffset(Offset = "0x28")]
	private Transform mTrans;

	[Token(Token = "0x40002F4")]
	[FieldOffset(Offset = "0x30")]
	private UISprite mSprite;

	[Token(Token = "0x40002F5")]
	[FieldOffset(Offset = "0x38")]
	private UIAtlas mAtlas;

	[Token(Token = "0x40002F6")]
	[FieldOffset(Offset = "0x40")]
	private string mSpriteName;

	[Token(Token = "0x600031B")]
	[Address(RVA = "0xA170A0", Offset = "0xA15EA0", Length = "0x97")]
	private void Awake()
	{
	}

	[Token(Token = "0x600031C")]
	[Address(RVA = "0xA17140", Offset = "0xA15F40", Length = "0x96")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600031D")]
	[Address(RVA = "0xA171E0", Offset = "0xA15FE0", Length = "0x3F7")]
	private void Start()
	{
	}

	[Token(Token = "0x600031E")]
	[Address(RVA = "0xA175E0", Offset = "0xA163E0", Length = "0x6A5")]
	private void Update()
	{
	}

	[Token(Token = "0x600031F")]
	[Address(RVA = "0xA17C90", Offset = "0xA16A90", Length = "0x1BF")]
	public static void Clear()
	{
	}

	[Token(Token = "0x6000320")]
	[Address(RVA = "0xA17E50", Offset = "0xA16C50", Length = "0x25D")]
	public static void Set(UIAtlas atlas, string sprite)
	{
	}

	[Token(Token = "0x6000321")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public UICursor()
	{
	}
}
