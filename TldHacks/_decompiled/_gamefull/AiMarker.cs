using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000141")]
public class AiMarker : MonoBehaviour
{
	[Token(Token = "0x2000142")]
	public enum ObjectType
	{
		[Token(Token = "0x40009FC")]
		RifleRack,
		[Token(Token = "0x40009FD")]
		Chair
	}

	[Token(Token = "0x40009F8")]
	[FieldOffset(Offset = "0x20")]
	public string m_AttachToJointName;

	[Token(Token = "0x40009F9")]
	[FieldOffset(Offset = "0x28")]
	public GameObject m_Prop;

	[Token(Token = "0x40009FA")]
	[FieldOffset(Offset = "0x30")]
	public ObjectType m_ObjectType;

	[Token(Token = "0x6000B65")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public AiMarker()
	{
	}
}
