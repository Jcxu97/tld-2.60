using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000880")]
public class SyncNode : MonoBehaviour
{
	[SerializeField]
	[Token(Token = "0x40057CA")]
	[FieldOffset(Offset = "0x20")]
	private Bounds m_Bounds;

	[Token(Token = "0x40057CB")]
	private static Collider[] s_Results;

	[Token(Token = "0x6004DBD")]
	[Address(RVA = "0xD90EA0", Offset = "0xD8FCA0", Length = "0x5D5")]
	public bool OverlapsObjects()
	{
		return false;
	}

	[Token(Token = "0x6004DBE")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public SyncNode()
	{
	}
}
