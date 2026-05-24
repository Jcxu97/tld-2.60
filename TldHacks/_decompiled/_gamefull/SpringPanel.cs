using Cpp2ILInjected;
using UnityEngine;

[RequireComponent(typeof(UIPanel))]
[AddComponentMenu("NGUI/Internal/Spring Panel")]
[Token(Token = "0x20000C0")]
public class SpringPanel : MonoBehaviour
{
	[Token(Token = "0x20000C1")]
	public delegate void OnFinished();

	[Token(Token = "0x400063C")]
	public static SpringPanel current;

	[Token(Token = "0x400063D")]
	[FieldOffset(Offset = "0x20")]
	public Vector3 target;

	[Token(Token = "0x400063E")]
	[FieldOffset(Offset = "0x2C")]
	public float strength;

	[Token(Token = "0x400063F")]
	[FieldOffset(Offset = "0x30")]
	public OnFinished onFinished;

	[Token(Token = "0x4000640")]
	[FieldOffset(Offset = "0x38")]
	private UIPanel mPanel;

	[Token(Token = "0x4000641")]
	[FieldOffset(Offset = "0x40")]
	private Transform mTrans;

	[Token(Token = "0x4000642")]
	[FieldOffset(Offset = "0x48")]
	private UIScrollView mDrag;

	[Token(Token = "0x60006F0")]
	[Address(RVA = "0xF95720", Offset = "0xF94520", Length = "0x16A")]
	private void Start()
	{
	}

	[Token(Token = "0x60006F1")]
	[Address(RVA = "0x5325D0", Offset = "0x5313D0", Length = "0x11")]
	private void Update()
	{
	}

	[Token(Token = "0x60006F2")]
	[Address(RVA = "0xF95890", Offset = "0xF94690", Length = "0x59E")]
	protected virtual void AdvanceTowardsPosition()
	{
	}

	[Token(Token = "0x60006F3")]
	[Address(RVA = "0xF95E30", Offset = "0xF94C30", Length = "0x1AD")]
	public static SpringPanel Begin(GameObject go, Vector3 pos, float strength)
	{
		return null;
	}

	[Token(Token = "0x60006F4")]
	[Address(RVA = "0xF95FE0", Offset = "0xF94DE0", Length = "0x8F")]
	public SpringPanel()
	{
	}
}
