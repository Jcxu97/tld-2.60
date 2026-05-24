using Cpp2ILInjected;
using TLD.UI.Generics;
using UnityEngine;

[Token(Token = "0x2000867")]
public class NPCDisableConditionUpdateEnforcer : MonoBehaviour
{
	[SerializeField]
	[Token(Token = "0x4005710")]
	[FieldOffset(Offset = "0x20")]
	private PanelReference<Panel_Loading> m_Loading;

	[Token(Token = "0x6004D2F")]
	[Address(RVA = "0xD84AF0", Offset = "0xD838F0", Length = "0x3A4")]
	public void Update()
	{
	}

	[Token(Token = "0x6004D30")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public NPCDisableConditionUpdateEnforcer()
	{
	}
}
