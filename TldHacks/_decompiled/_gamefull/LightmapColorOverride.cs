using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000307")]
public class LightmapColorOverride : MonoBehaviour
{
	[ColorUsage(false, true)]
	[Token(Token = "0x4001A91")]
	[FieldOffset(Offset = "0x20")]
	public Color m_Color;

	[Token(Token = "0x60018DD")]
	[Address(RVA = "0x6F7370", Offset = "0x6F6170", Length = "0xBF")]
	public bool IsEnabled()
	{
		return false;
	}

	[Token(Token = "0x60018DE")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public LightmapColorOverride()
	{
	}
}
