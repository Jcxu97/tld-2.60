using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20002ED")]
public class AutoForceLod : MonoBehaviour
{
	[Token(Token = "0x40019A6")]
	[FieldOffset(Offset = "0x20")]
	public int m_LodLevel;

	[Token(Token = "0x6001857")]
	[Address(RVA = "0x6E60D0", Offset = "0x6E4ED0", Length = "0x159")]
	private void Start()
	{
	}

	[Token(Token = "0x6001858")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public AutoForceLod()
	{
	}
}
