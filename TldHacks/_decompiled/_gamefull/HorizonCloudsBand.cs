using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20009DA")]
public class HorizonCloudsBand : MonoBehaviour
{
	[Token(Token = "0x20009DB")]
	public enum HorizonBandId
	{
		[Token(Token = "0x40063F7")]
		Band1,
		[Token(Token = "0x40063F8")]
		Band2,
		[Token(Token = "0x40063F9")]
		Band3,
		[Token(Token = "0x40063FA")]
		Grad,
		[Token(Token = "0x40063FB")]
		SkyCloudEdge1,
		[Token(Token = "0x40063FC")]
		SkyCloudEdge2
	}

	[Token(Token = "0x40063F5")]
	[FieldOffset(Offset = "0x20")]
	public HorizonBandId m_HorizonBandId;

	[Token(Token = "0x60056E0")]
	[Address(RVA = "0xEC25F0", Offset = "0xEC13F0", Length = "0x218")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60056E1")]
	[Address(RVA = "0xEC2820", Offset = "0xEC1620", Length = "0x1C0")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60056E2")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public HorizonCloudsBand()
	{
	}
}
