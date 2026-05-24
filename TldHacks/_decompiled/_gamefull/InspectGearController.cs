using Cpp2ILInjected;
using TLD.UI.Generics;
using UnityEngine;

[Token(Token = "0x2000250")]
public class InspectGearController : MonoBehaviour
{
	[SerializeField]
	[Token(Token = "0x4001482")]
	[FieldOffset(Offset = "0x20")]
	private PanelReference<Panel_Log> m_Log;

	[SerializeField]
	[Token(Token = "0x4001483")]
	[FieldOffset(Offset = "0x28")]
	private PanelReference<Panel_GenericProgressBar> m_GenericProgressBar;

	[Token(Token = "0x4001484")]
	[FieldOffset(Offset = "0x30")]
	private GearItem m_GearItem;

	[Token(Token = "0x4001485")]
	[FieldOffset(Offset = "0x38")]
	private bool m_MouseDownPreviousFrame;

	[Token(Token = "0x4001486")]
	[FieldOffset(Offset = "0x39")]
	private bool m_DragActive;

	[Token(Token = "0x600144C")]
	[Address(RVA = "0x6816D0", Offset = "0x6804D0", Length = "0x792")]
	private void Update()
	{
	}

	[Token(Token = "0x600144D")]
	[Address(RVA = "0x4B1CB0", Offset = "0x4B0AB0", Length = "0x52")]
	public void SetGearItem(GearItem gi)
	{
	}

	[Token(Token = "0x600144E")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public InspectGearController()
	{
	}
}
