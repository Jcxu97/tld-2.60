using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000596")]
public class ObjectAnim : MonoBehaviour
{
	[Token(Token = "0x400337D")]
	[FieldOffset(Offset = "0x20")]
	public GameObject m_Target;

	[Token(Token = "0x400337E")]
	[FieldOffset(Offset = "0x28")]
	private iTweenEvent[] m_Events;

	[Token(Token = "0x6002B1B")]
	[Address(RVA = "0x913BA0", Offset = "0x9129A0", Length = "0x7")]
	private void Start()
	{
	}

	[Token(Token = "0x6002B1C")]
	[Address(RVA = "0x913BB0", Offset = "0x9129B0", Length = "0x176")]
	public void Initialize()
	{
	}

	[Token(Token = "0x6002B1D")]
	[Address(RVA = "0x913D30", Offset = "0x912B30", Length = "0x162")]
	public bool IsAnimating()
	{
		return false;
	}

	[Token(Token = "0x6002B1E")]
	[Address(RVA = "0x913EA0", Offset = "0x912CA0", Length = "0x2C1")]
	public bool Play(string name)
	{
		return false;
	}

	[Token(Token = "0x6002B1F")]
	[Address(RVA = "0x914170", Offset = "0x912F70", Length = "0x168")]
	public void GoToEndImmediate()
	{
	}

	[Token(Token = "0x6002B20")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public ObjectAnim()
	{
	}
}
