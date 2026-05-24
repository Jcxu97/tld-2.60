using Cpp2ILInjected;
using UnityEngine;

[AddComponentMenu("NGUI/Interaction/Key Navigation")]
[Token(Token = "0x2000083")]
public class UIKeyNavigation : MonoBehaviour
{
	[Token(Token = "0x2000084")]
	public enum Constraint
	{
		[Token(Token = "0x4000495")]
		None,
		[Token(Token = "0x4000496")]
		Vertical,
		[Token(Token = "0x4000497")]
		Horizontal,
		[Token(Token = "0x4000498")]
		Explicit
	}

	[Token(Token = "0x400047F")]
	public static BetterList<UIKeyNavigation> list;

	[Token(Token = "0x4000480")]
	public static KeyCode lastKeycodeUsed;

	[HideInInspector]
	[Token(Token = "0x4000481")]
	[FieldOffset(Offset = "0x20")]
	public Constraint constraint;

	[HideInInspector]
	[Token(Token = "0x4000482")]
	[FieldOffset(Offset = "0x28")]
	public GameObject onUp;

	[HideInInspector]
	[Token(Token = "0x4000483")]
	[FieldOffset(Offset = "0x30")]
	public GameObject onDown;

	[HideInInspector]
	[Token(Token = "0x4000484")]
	[FieldOffset(Offset = "0x38")]
	public GameObject onLeft;

	[HideInInspector]
	[Token(Token = "0x4000485")]
	[FieldOffset(Offset = "0x40")]
	public GameObject onRight;

	[HideInInspector]
	[Token(Token = "0x4000486")]
	[FieldOffset(Offset = "0x48")]
	public GameObject onClick;

	[Token(Token = "0x4000487")]
	[FieldOffset(Offset = "0x50")]
	public GameObject[] onLeftBackup;

	[Token(Token = "0x4000488")]
	[FieldOffset(Offset = "0x58")]
	public GameObject[] onRightBackup;

	[Token(Token = "0x4000489")]
	[FieldOffset(Offset = "0x60")]
	public GameObject[] onUpBackup;

	[Token(Token = "0x400048A")]
	[FieldOffset(Offset = "0x68")]
	public GameObject[] onDownBackup;

	[HideInInspector]
	[Token(Token = "0x400048B")]
	[FieldOffset(Offset = "0x70")]
	public bool startsSelected;

	[Token(Token = "0x400048C")]
	[FieldOffset(Offset = "0x78")]
	private UIKeyNavigation onLeftNav;

	[Token(Token = "0x400048D")]
	[FieldOffset(Offset = "0x80")]
	private UIKeyNavigation onRightNav;

	[Token(Token = "0x400048E")]
	[FieldOffset(Offset = "0x88")]
	private UIKeyNavigation onUpNav;

	[Token(Token = "0x400048F")]
	[FieldOffset(Offset = "0x90")]
	private UIKeyNavigation onDownNav;

	[Token(Token = "0x4000490")]
	[FieldOffset(Offset = "0x98")]
	private BetterList<UIKeyNavigation> onLeftNavBackup;

	[Token(Token = "0x4000491")]
	[FieldOffset(Offset = "0xA0")]
	private BetterList<UIKeyNavigation> onRightNavBackup;

	[Token(Token = "0x4000492")]
	[FieldOffset(Offset = "0xA8")]
	private BetterList<UIKeyNavigation> onUpNavBackup;

	[Token(Token = "0x4000493")]
	[FieldOffset(Offset = "0xB0")]
	private BetterList<UIKeyNavigation> onDownNavBackup;

	[Token(Token = "0x6000473")]
	[Address(RVA = "0xBD65E0", Offset = "0xBD53E0", Length = "0xA5D")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000474")]
	[Address(RVA = "0xBD7040", Offset = "0xBD5E40", Length = "0x1E5")]
	protected virtual void OnEnable()
	{
	}

	[Token(Token = "0x6000475")]
	[Address(RVA = "0xBD7230", Offset = "0xBD6030", Length = "0x82")]
	protected virtual void OnDisable()
	{
	}

	[Token(Token = "0x6000476")]
	[Address(RVA = "0xBD72C0", Offset = "0xBD60C0", Length = "0x292")]
	protected GameObject GetLeft()
	{
		return null;
	}

	[Token(Token = "0x6000477")]
	[Address(RVA = "0xBD7560", Offset = "0xBD6360", Length = "0x2A0")]
	private GameObject GetRight()
	{
		return null;
	}

	[Token(Token = "0x6000478")]
	[Address(RVA = "0xBD7810", Offset = "0xBD6610", Length = "0x29F")]
	protected GameObject GetUp()
	{
		return null;
	}

	[Token(Token = "0x6000479")]
	[Address(RVA = "0xBD7AB0", Offset = "0xBD68B0", Length = "0x29F")]
	protected GameObject GetDown()
	{
		return null;
	}

	[Token(Token = "0x600047A")]
	[Address(RVA = "0xBD7D50", Offset = "0xBD6B50", Length = "0x609")]
	protected GameObject Get(Vector3 myDir, bool horizontal)
	{
		return null;
	}

	[Token(Token = "0x600047B")]
	[Address(RVA = "0xBD8360", Offset = "0xBD7160", Length = "0x669")]
	protected static Vector3 GetCenter(GameObject go)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600047C")]
	[Address(RVA = "0xBD89D0", Offset = "0xBD77D0", Length = "0x5D0")]
	protected virtual void OnKey(KeyCode key)
	{
	}

	[Token(Token = "0x600047D")]
	[Address(RVA = "0xBD8FB0", Offset = "0xBD7DB0", Length = "0xBD")]
	protected virtual void OnClick()
	{
	}

	[Token(Token = "0x600047E")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public UIKeyNavigation()
	{
	}
}
