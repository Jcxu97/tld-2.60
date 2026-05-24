using Cpp2ILInjected;
using UnityEngine;

[AddComponentMenu("NGUI/Examples/Item Attachment Point")]
[Token(Token = "0x2000041")]
public class InvAttachmentPoint : MonoBehaviour
{
	[Token(Token = "0x400030C")]
	[FieldOffset(Offset = "0x20")]
	public InvBaseItem.Slot slot;

	[Token(Token = "0x400030D")]
	[FieldOffset(Offset = "0x28")]
	private GameObject mPrefab;

	[Token(Token = "0x400030E")]
	[FieldOffset(Offset = "0x30")]
	private GameObject mChild;

	[Token(Token = "0x6000336")]
	[Address(RVA = "0xA1A340", Offset = "0xA19140", Length = "0x767")]
	public GameObject Attach(GameObject prefab)
	{
		return null;
	}

	[Token(Token = "0x6000337")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public InvAttachmentPoint()
	{
	}
}
