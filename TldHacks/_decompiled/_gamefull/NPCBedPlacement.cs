using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200083B")]
public class NPCBedPlacement : MonoBehaviour
{
	[Tooltip("Offset the vertical positioning of the item placed on the bed")]
	[Token(Token = "0x4005634")]
	[FieldOffset(Offset = "0x20")]
	public float YOffset;

	[Token(Token = "0x6004C6F")]
	[Address(RVA = "0xD70330", Offset = "0xD6F130", Length = "0x3D8")]
	private void OnTriggerEnter(Collider c)
	{
	}

	[Token(Token = "0x6004C70")]
	[Address(RVA = "0xD70710", Offset = "0xD6F510", Length = "0x4A")]
	public NPCBedPlacement()
	{
	}
}
