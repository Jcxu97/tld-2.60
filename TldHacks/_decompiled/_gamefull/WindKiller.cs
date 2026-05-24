using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000A5D")]
public class WindKiller : MonoBehaviour
{
	[Token(Token = "0x4006759")]
	[FieldOffset(Offset = "0x20")]
	private Collider m_Collider;

	[Token(Token = "0x6005AB6")]
	[Address(RVA = "0xF1C770", Offset = "0xF1B570", Length = "0x281")]
	private void Start()
	{
	}

	[Token(Token = "0x6005AB7")]
	[Address(RVA = "0xF1CA00", Offset = "0xF1B800", Length = "0x207")]
	public bool PointInside(Vector3 pos)
	{
		return false;
	}

	[Token(Token = "0x6005AB8")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public WindKiller()
	{
	}
}
