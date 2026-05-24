using Cpp2ILInjected;
using UnityEngine;

[AddComponentMenu("NGUI/Examples/Load Level On Click")]
[Token(Token = "0x2000051")]
public class LoadLevelOnClick : MonoBehaviour
{
	[Token(Token = "0x4000364")]
	[FieldOffset(Offset = "0x20")]
	public string levelName;

	[Token(Token = "0x6000370")]
	[Address(RVA = "0xA1E480", Offset = "0xA1D280", Length = "0x61")]
	private void OnClick()
	{
	}

	[Token(Token = "0x6000371")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public LoadLevelOnClick()
	{
	}
}
