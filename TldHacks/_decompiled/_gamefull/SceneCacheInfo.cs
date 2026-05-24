using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200030C")]
public class SceneCacheInfo : MonoBehaviour
{
	[Token(Token = "0x4001AA7")]
	[FieldOffset(Offset = "0x20")]
	public int m_NumCommonCachesActiveAtStart;

	[Token(Token = "0x4001AA8")]
	[FieldOffset(Offset = "0x24")]
	public int m_NumRareCachesActiveAtStart;

	[Token(Token = "0x60018E6")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public SceneCacheInfo()
	{
	}
}
