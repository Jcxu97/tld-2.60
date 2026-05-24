using Cpp2ILInjected;
using UnityEngine;

[RequireComponent(typeof(UISlider))]
[AddComponentMenu("NGUI/Interaction/Sound Volume")]
[Token(Token = "0x200009C")]
public class UISoundVolume : MonoBehaviour
{
	[Token(Token = "0x600054B")]
	[Address(RVA = "0xBEFB30", Offset = "0xBEE930", Length = "0x154")]
	private void Awake()
	{
	}

	[Token(Token = "0x600054C")]
	[Address(RVA = "0xBEFC90", Offset = "0xBEEA90", Length = "0x15B")]
	private void OnChange()
	{
	}

	[Token(Token = "0x600054D")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public UISoundVolume()
	{
	}
}
