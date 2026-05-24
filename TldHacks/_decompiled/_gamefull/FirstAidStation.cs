using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200057F")]
public class FirstAidStation : MonoBehaviour
{
	[Token(Token = "0x40032B9")]
	[FieldOffset(Offset = "0x20")]
	public LocalizedString m_LocalizedDisplayName;

	[Token(Token = "0x170002C0")]
	public string m_DisplayName
	{
		[Token(Token = "0x6002A5E")]
		[Address(RVA = "0x87E130", Offset = "0x87CF30", Length = "0x5D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6002A5F")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	private void Start()
	{
	}

	[Token(Token = "0x6002A60")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public FirstAidStation()
	{
	}
}
