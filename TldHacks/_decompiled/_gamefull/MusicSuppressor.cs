using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20001BB")]
public class MusicSuppressor : MonoBehaviour
{
	[Token(Token = "0x4000F3A")]
	[FieldOffset(Offset = "0x20")]
	public float m_Distance;

	[Token(Token = "0x6001007")]
	[Address(RVA = "0x61E280", Offset = "0x61D080", Length = "0x1D8")]
	private void Awake()
	{
	}

	[Token(Token = "0x6001008")]
	[Address(RVA = "0x61E460", Offset = "0x61D260", Length = "0x194")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6001009")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public MusicSuppressor()
	{
	}
}
