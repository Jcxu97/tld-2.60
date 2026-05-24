using Cpp2ILInjected;
using UnityEngine;

[AddComponentMenu("NGUI/Interaction/Drag and Drop Root")]
[Token(Token = "0x2000073")]
public class UIDragDropRoot : MonoBehaviour
{
	[Token(Token = "0x4000401")]
	public static Transform root;

	[Token(Token = "0x6000411")]
	[Address(RVA = "0xA304A0", Offset = "0xA2F2A0", Length = "0x97")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000412")]
	[Address(RVA = "0xA30540", Offset = "0xA2F340", Length = "0x1B1")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000413")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public UIDragDropRoot()
	{
	}
}
