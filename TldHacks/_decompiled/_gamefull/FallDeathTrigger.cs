using Cpp2ILInjected;
using TLD.UI.Generics;
using UnityEngine;

[Token(Token = "0x20009C1")]
public class FallDeathTrigger : MonoBehaviour
{
	[SerializeField]
	[Token(Token = "0x400636F")]
	[FieldOffset(Offset = "0x20")]
	private PanelReference<Panel_Loading> m_Loading;

	[Token(Token = "0x600565C")]
	[Address(RVA = "0xEB77D0", Offset = "0xEB65D0", Length = "0xC4")]
	private void OnTriggerEnter(Collider c)
	{
	}

	[Token(Token = "0x600565D")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public FallDeathTrigger()
	{
	}
}
