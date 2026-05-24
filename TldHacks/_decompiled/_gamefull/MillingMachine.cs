using Cpp2ILInjected;
using TLD.Interactions;
using TLD.UI.Generics;
using UnityEngine;

[Token(Token = "0x2000595")]
public class MillingMachine : MonoBehaviour
{
	[Header("Audio")]
	[Token(Token = "0x4003378")]
	[FieldOffset(Offset = "0x20")]
	public string m_IdleAudioPlay;

	[Token(Token = "0x4003379")]
	[FieldOffset(Offset = "0x28")]
	public string m_IdleAudioStop;

	[Token(Token = "0x400337A")]
	[FieldOffset(Offset = "0x30")]
	public string m_RepairAudioLoop;

	[Header("Panel Reference")]
	[SerializeField]
	[Token(Token = "0x400337B")]
	[FieldOffset(Offset = "0x38")]
	private PanelReference<Panel_Milling> m_MillingPanel;

	[Token(Token = "0x400337C")]
	[FieldOffset(Offset = "0x40")]
	private uint m_IdleAudioPlayingId;

	[Token(Token = "0x6002B17")]
	[Address(RVA = "0x9136A0", Offset = "0x9124A0", Length = "0x1EB")]
	private void Update()
	{
	}

	[Token(Token = "0x6002B18")]
	[Address(RVA = "0x913890", Offset = "0x912690", Length = "0xA9")]
	public void InitializeInteraction(BaseInteraction baseInteraction)
	{
	}

	[Token(Token = "0x6002B19")]
	[Address(RVA = "0x913940", Offset = "0x912740", Length = "0x25D")]
	public void PerformInteraction()
	{
	}

	[Token(Token = "0x6002B1A")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public MillingMachine()
	{
	}
}
