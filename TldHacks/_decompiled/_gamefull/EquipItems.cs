using Cpp2ILInjected;
using UnityEngine;

[AddComponentMenu("NGUI/Examples/Equip Items")]
[Token(Token = "0x200003A")]
public class EquipItems : MonoBehaviour
{
	[Token(Token = "0x40002EF")]
	[FieldOffset(Offset = "0x20")]
	public int[] itemIDs;

	[Token(Token = "0x6000317")]
	[Address(RVA = "0xA16A70", Offset = "0xA15870", Length = "0x356")]
	private void Start()
	{
	}

	[Token(Token = "0x6000318")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public EquipItems()
	{
	}
}
