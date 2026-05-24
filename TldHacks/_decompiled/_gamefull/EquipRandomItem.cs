using Cpp2ILInjected;
using UnityEngine;

[AddComponentMenu("NGUI/Examples/Equip Random Item")]
[Token(Token = "0x200003B")]
public class EquipRandomItem : MonoBehaviour
{
	[Token(Token = "0x40002F0")]
	[FieldOffset(Offset = "0x20")]
	public InvEquipment equipment;

	[Token(Token = "0x6000319")]
	[Address(RVA = "0xA16DD0", Offset = "0xA15BD0", Length = "0x2C0")]
	private void OnClick()
	{
	}

	[Token(Token = "0x600031A")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public EquipRandomItem()
	{
	}
}
