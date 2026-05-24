using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000024")]
public class StartAndStopTween : MonoBehaviour
{
	[Token(Token = "0x4000220")]
	[FieldOffset(Offset = "0x20")]
	public GameObject target;

	[Token(Token = "0x60001DE")]
	[Address(RVA = "0x883A40", Offset = "0x882840", Length = "0x1B8")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x60001DF")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public StartAndStopTween()
	{
	}
}
