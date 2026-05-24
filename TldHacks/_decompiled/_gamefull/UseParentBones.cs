using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20001AD")]
public class UseParentBones : MonoBehaviour
{
	[Token(Token = "0x4000F16")]
	[FieldOffset(Offset = "0x20")]
	public GameObject m_TargetSkin;

	[Token(Token = "0x6000F9E")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	private void Start()
	{
	}

	[Token(Token = "0x6000F9F")]
	[Address(RVA = "0x618A90", Offset = "0x617890", Length = "0x7EB")]
	public void DoWork()
	{
	}

	[Token(Token = "0x6000FA0")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public UseParentBones()
	{
	}
}
