using Cpp2ILInjected;
using UnityEngine;

[AddComponentMenu("NGUI/Tween/Spring Position")]
[Token(Token = "0x20000DF")]
public class SpringPosition : MonoBehaviour
{
	[Token(Token = "0x20000E0")]
	public delegate void OnFinished();

	[Token(Token = "0x4000704")]
	public static SpringPosition current;

	[Token(Token = "0x4000705")]
	[FieldOffset(Offset = "0x20")]
	public Vector3 target;

	[Token(Token = "0x4000706")]
	[FieldOffset(Offset = "0x2C")]
	public float strength;

	[Token(Token = "0x4000707")]
	[FieldOffset(Offset = "0x30")]
	public bool worldSpace;

	[Token(Token = "0x4000708")]
	[FieldOffset(Offset = "0x31")]
	public bool ignoreTimeScale;

	[Token(Token = "0x4000709")]
	[FieldOffset(Offset = "0x32")]
	public bool updateScrollView;

	[Token(Token = "0x400070A")]
	[FieldOffset(Offset = "0x38")]
	public OnFinished onFinished;

	[SerializeField]
	[HideInInspector]
	[Token(Token = "0x400070B")]
	[FieldOffset(Offset = "0x40")]
	private GameObject eventReceiver;

	[SerializeField]
	[HideInInspector]
	[Token(Token = "0x400070C")]
	[FieldOffset(Offset = "0x48")]
	public string callWhenFinished;

	[Token(Token = "0x400070D")]
	[FieldOffset(Offset = "0x50")]
	private Transform mTrans;

	[Token(Token = "0x400070E")]
	[FieldOffset(Offset = "0x58")]
	private float mThreshold;

	[Token(Token = "0x400070F")]
	[FieldOffset(Offset = "0x60")]
	private UIScrollView mSv;

	[Token(Token = "0x60007FF")]
	[Address(RVA = "0x1124110", Offset = "0x1122F10", Length = "0x159")]
	private void Start()
	{
	}

	[Token(Token = "0x6000800")]
	[Address(RVA = "0x1124270", Offset = "0x1123070", Length = "0xA6E")]
	private void Update()
	{
	}

	[Token(Token = "0x6000801")]
	[Address(RVA = "0x1124CE0", Offset = "0x1123AE0", Length = "0x21E")]
	private void NotifyListeners()
	{
	}

	[Token(Token = "0x6000802")]
	[Address(RVA = "0x1124F00", Offset = "0x1123D00", Length = "0x228")]
	public static SpringPosition Begin(GameObject go, Vector3 pos, float strength)
	{
		return null;
	}

	[Token(Token = "0x6000803")]
	[Address(RVA = "0xF95FE0", Offset = "0xF94DE0", Length = "0x8F")]
	public SpringPosition()
	{
	}
}
