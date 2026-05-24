using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20002A7")]
public class ShaderToggle : MonoBehaviour
{
	[SerializeField]
	[Token(Token = "0x40017B8")]
	[FieldOffset(Offset = "0x20")]
	private ShaderComparison[] m_Shaders;

	[Token(Token = "0x40017B9")]
	private static ShaderToggle m_Instance;

	[Token(Token = "0x6001696")]
	[Address(RVA = "0x6BC900", Offset = "0x6BB700", Length = "0x97")]
	private void Start()
	{
	}

	[Token(Token = "0x6001697")]
	[Address(RVA = "0x6BC9A0", Offset = "0x6BB7A0", Length = "0x190")]
	public static void Toggle(string tag)
	{
	}

	[Token(Token = "0x6001698")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public ShaderToggle()
	{
	}
}
