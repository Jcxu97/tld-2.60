using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000495")]
public class ForceLockItem : MonoBehaviour
{
	[Token(Token = "0x40029DE")]
	[FieldOffset(Offset = "0x20")]
	public string m_ForceLockAudio;

	[Token(Token = "0x40029DF")]
	[FieldOffset(Offset = "0x28")]
	public LocalizedString m_LocalizedProgressText;

	[Token(Token = "0x17000224")]
	public string m_ProgressText
	{
		[Token(Token = "0x600228E")]
		[Address(RVA = "0x74FB70", Offset = "0x74E970", Length = "0x5D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600228D")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public void Start()
	{
	}

	[Token(Token = "0x600228F")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public ForceLockItem()
	{
	}
}
