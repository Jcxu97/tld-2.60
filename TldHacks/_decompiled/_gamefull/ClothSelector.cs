using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000378")]
public class ClothSelector : MonoBehaviour
{
	[Token(Token = "0x2000379")]
	public enum ClothType
	{
		[Token(Token = "0x4001EC2")]
		Physics,
		[Token(Token = "0x4001EC3")]
		Fast
	}

	[SerializeField]
	[Token(Token = "0x4001EBD")]
	[FieldOffset(Offset = "0x20")]
	private Cloth m_PhysicsCloth;

	[SerializeField]
	[Token(Token = "0x4001EBE")]
	[FieldOffset(Offset = "0x28")]
	private FastCloth m_FastCloth;

	[SerializeField]
	[Token(Token = "0x4001EBF")]
	[FieldOffset(Offset = "0x30")]
	private ClothType m_Default;

	[SerializeField]
	[Token(Token = "0x4001EC0")]
	[FieldOffset(Offset = "0x34")]
	private ClothType m_NintendoSwitch;

	[Token(Token = "0x6001C03")]
	[Address(RVA = "0x7704C0", Offset = "0x76F2C0", Length = "0x3CF")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6001C04")]
	[Address(RVA = "0x770890", Offset = "0x76F690", Length = "0x4A")]
	public ClothSelector()
	{
	}
}
