using Cpp2ILInjected;
using UnityEngine;

[RequireComponent(typeof(BoxCollider))]
[Token(Token = "0x2000599")]
public class OpenCloseTrigger : MonoBehaviour
{
	[SerializeField]
	[Token(Token = "0x40033AA")]
	[FieldOffset(Offset = "0x20")]
	private OpenClose m_OpenClose;

	[SerializeField]
	[Token(Token = "0x40033AB")]
	[FieldOffset(Offset = "0x28")]
	private bool m_IsImmediate;

	[SerializeField]
	[Token(Token = "0x40033AC")]
	[FieldOffset(Offset = "0x29")]
	private bool m_OpenOnTriggerEnter;

	[SerializeField]
	[Token(Token = "0x40033AD")]
	[FieldOffset(Offset = "0x2A")]
	private bool m_CloseOnTriggerExit;

	[Token(Token = "0x6002B48")]
	[Address(RVA = "0x917BE0", Offset = "0x9169E0", Length = "0x123")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6002B49")]
	[Address(RVA = "0x917D10", Offset = "0x916B10", Length = "0x123")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x6002B4A")]
	[Address(RVA = "0x7B2E60", Offset = "0x7B1C60", Length = "0x47")]
	public OpenCloseTrigger()
	{
	}
}
