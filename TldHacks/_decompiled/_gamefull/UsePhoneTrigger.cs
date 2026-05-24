using Cpp2ILInjected;
using TLD.UI.Generics;
using UnityEngine;

[Token(Token = "0x20009D7")]
public class UsePhoneTrigger : MonoBehaviour
{
	[SerializeField]
	[Token(Token = "0x40063D6")]
	[FieldOffset(Offset = "0x20")]
	private PanelReference<Panel_Loading> m_Loading;

	[Token(Token = "0x40063D7")]
	[FieldOffset(Offset = "0x28")]
	public string m_PhoneObjectId;

	[Token(Token = "0x60056CF")]
	[Address(RVA = "0xEC0F40", Offset = "0xEBFD40", Length = "0x18C")]
	private void MaybeUsePhone(Collider c)
	{
	}

	[Token(Token = "0x60056D0")]
	[Address(RVA = "0xEC10D0", Offset = "0xEBFED0", Length = "0x8")]
	private void OnTriggerStay(Collider c)
	{
	}

	[Token(Token = "0x60056D1")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public UsePhoneTrigger()
	{
	}
}
