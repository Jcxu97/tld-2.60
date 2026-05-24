using Cpp2ILInjected;
using UnityEngine;

[RequireComponent(typeof(UIPopupList))]
[AddComponentMenu("NGUI/Interaction/Language Selection")]
[Token(Token = "0x200005D")]
public class LanguageSelection : MonoBehaviour
{
	[Token(Token = "0x4000387")]
	[FieldOffset(Offset = "0x20")]
	private UIPopupList mList;

	[Token(Token = "0x6000393")]
	[Address(RVA = "0xA223E0", Offset = "0xA211E0", Length = "0x95")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000394")]
	[Address(RVA = "0xA22480", Offset = "0xA21280", Length = "0x1C1")]
	private void Start()
	{
	}

	[Token(Token = "0x6000395")]
	[Address(RVA = "0xA22650", Offset = "0xA21450", Length = "0x225")]
	public void Refresh()
	{
	}

	[Token(Token = "0x6000396")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public LanguageSelection()
	{
	}
}
