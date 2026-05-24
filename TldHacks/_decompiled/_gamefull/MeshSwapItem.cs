using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20004BF")]
public class MeshSwapItem : MonoBehaviour
{
	[Token(Token = "0x4002BA1")]
	[FieldOffset(Offset = "0x20")]
	public GameObject m_MeshObjUnopened;

	[Token(Token = "0x4002BA2")]
	[FieldOffset(Offset = "0x28")]
	public GameObject m_MeshObjOpened;

	[Token(Token = "0x4002BA3")]
	[FieldOffset(Offset = "0x30")]
	public GameObject m_MeshObjCookingReady;

	[Token(Token = "0x4002BA4")]
	[FieldOffset(Offset = "0x38")]
	private GearItem m_GearItem;

	[Token(Token = "0x4002BA5")]
	[FieldOffset(Offset = "0x40")]
	private bool m_InCookingReadyState;

	[Token(Token = "0x4002BA6")]
	[FieldOffset(Offset = "0x41")]
	private bool m_HasUnopenedMesh;

	[Token(Token = "0x4002BA7")]
	[FieldOffset(Offset = "0x42")]
	private bool m_HasOpenedMesh;

	[Token(Token = "0x4002BA8")]
	[FieldOffset(Offset = "0x43")]
	private bool m_HasCookingMesh;

	[Token(Token = "0x4002BA9")]
	[FieldOffset(Offset = "0x44")]
	private bool m_HasGearItem;

	[Token(Token = "0x4002BAA")]
	[FieldOffset(Offset = "0x45")]
	private bool m_HasFoodItem;

	[Token(Token = "0x4002BAB")]
	[FieldOffset(Offset = "0x46")]
	private bool m_HasSmashableItem;

	[Token(Token = "0x600243C")]
	[Address(RVA = "0x8648B0", Offset = "0x8636B0", Length = "0x410")]
	private void Start()
	{
	}

	[Token(Token = "0x600243D")]
	[Address(RVA = "0x864CD0", Offset = "0x863AD0", Length = "0xF2")]
	private void Update()
	{
	}

	[Token(Token = "0x600243E")]
	[Address(RVA = "0x864DD0", Offset = "0x863BD0", Length = "0xDB")]
	public void SetCookingReady(bool isCookingReady)
	{
	}

	[Token(Token = "0x600243F")]
	[Address(RVA = "0x864EB0", Offset = "0x863CB0", Length = "0x37F")]
	private void EnableMesh(GameObject go)
	{
	}

	[Token(Token = "0x6002440")]
	[Address(RVA = "0x865230", Offset = "0x864030", Length = "0x62")]
	private bool IsOpened()
	{
		return false;
	}

	[Token(Token = "0x6002441")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public MeshSwapItem()
	{
	}
}
