using Cpp2ILInjected;
using UnityEngine;

[AddComponentMenu("NGUI/Interaction/Center Scroll View on Child")]
[Token(Token = "0x200006B")]
public class UICenterOnChild : MonoBehaviour
{
	[Token(Token = "0x200006C")]
	public delegate void OnCenterCallback(GameObject centeredObject);

	[Token(Token = "0x40003DE")]
	[FieldOffset(Offset = "0x20")]
	public float springStrength;

	[Token(Token = "0x40003DF")]
	[FieldOffset(Offset = "0x24")]
	public float nextPageThreshold;

	[Token(Token = "0x40003E0")]
	[FieldOffset(Offset = "0x28")]
	public SpringPanel.OnFinished onFinished;

	[Token(Token = "0x40003E1")]
	[FieldOffset(Offset = "0x30")]
	public OnCenterCallback onCenter;

	[Token(Token = "0x40003E2")]
	[FieldOffset(Offset = "0x38")]
	private UIScrollView mScrollView;

	[Token(Token = "0x40003E3")]
	[FieldOffset(Offset = "0x40")]
	private GameObject mCenteredObject;

	[Token(Token = "0x17000038")]
	public GameObject centeredObject
	{
		[Token(Token = "0x60003E6")]
		[Address(RVA = "0x4A7D60", Offset = "0x4A6B60", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60003E7")]
	[Address(RVA = "0xA2AB30", Offset = "0xA29930", Length = "0x7")]
	private void Start()
	{
	}

	[Token(Token = "0x60003E8")]
	[Address(RVA = "0xA2AB40", Offset = "0xA29940", Length = "0x12B")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60003E9")]
	[Address(RVA = "0xA2AC70", Offset = "0xA29A70", Length = "0x122")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60003EA")]
	[Address(RVA = "0xA2ADA0", Offset = "0xA29BA0", Length = "0xA6")]
	private void OnDragFinished()
	{
	}

	[Token(Token = "0x60003EB")]
	[Address(RVA = "0xA2AE50", Offset = "0xA29C50", Length = "0x12")]
	private void OnValidate()
	{
	}

	[ContextMenu("Execute")]
	[Token(Token = "0x60003EC")]
	[Address(RVA = "0xA2AE70", Offset = "0xA29C70", Length = "0x1370")]
	public void Recenter()
	{
	}

	[Token(Token = "0x60003ED")]
	[Address(RVA = "0xA2C1F0", Offset = "0xA2AFF0", Length = "0x67C")]
	private void CenterOn(Transform target, Vector3 panelCenter)
	{
	}

	[Token(Token = "0x60003EE")]
	[Address(RVA = "0xA2C870", Offset = "0xA2B670", Length = "0x254")]
	public void CenterOn(Transform target)
	{
	}

	[Token(Token = "0x60003EF")]
	[Address(RVA = "0xA2CAD0", Offset = "0xA2B8D0", Length = "0x4A")]
	public UICenterOnChild()
	{
	}
}
