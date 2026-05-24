using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000306")]
public class LandmarkLocator : MonoBehaviour
{
	[Token(Token = "0x4001A90")]
	[FieldOffset(Offset = "0x20")]
	public string m_LandmarkName;

	[Token(Token = "0x60018DB")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	private void Start()
	{
	}

	[Token(Token = "0x60018DC")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public LandmarkLocator()
	{
	}
}
