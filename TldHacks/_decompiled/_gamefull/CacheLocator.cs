using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000558")]
public class CacheLocator : MonoBehaviour
{
	[Token(Token = "0x400315E")]
	[FieldOffset(Offset = "0x20")]
	public LandmarkLocator[] m_NearbyLandmarks;

	[Token(Token = "0x600290F")]
	[Address(RVA = "0x8DB810", Offset = "0x8DA610", Length = "0x7B")]
	public LandmarkLocator ChooseLandmark()
	{
		return null;
	}

	[Token(Token = "0x6002910")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public CacheLocator()
	{
	}
}
