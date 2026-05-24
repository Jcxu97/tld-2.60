using Cpp2ILInjected;
using TLD.Interactions;
using UnityEngine;

[RequireComponent(typeof(Harvestable))]
[Token(Token = "0x200056F")]
public class HarvestableInteraction : TimedHoldInteraction
{
	[Token(Token = "0x4003222")]
	[FieldOffset(Offset = "0x68")]
	private Harvestable m_Harvestable;

	[Token(Token = "0x4003223")]
	[FieldOffset(Offset = "0x70")]
	private uint m_HarvestAudioId;

	[Token(Token = "0x170002BA")]
	public override bool CanInteract
	{
		[Token(Token = "0x60029E0")]
		[Address(RVA = "0x8F55F0", Offset = "0x8F43F0", Length = "0x66")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x60029E1")]
	[Address(RVA = "0x8F5660", Offset = "0x8F4460", Length = "0x8C")]
	private void Awake()
	{
	}

	[Token(Token = "0x60029E2")]
	[Address(RVA = "0x8F56F0", Offset = "0x8F44F0", Length = "0x1C4")]
	public override bool PerformHold()
	{
		return false;
	}

	[Token(Token = "0x60029E3")]
	[Address(RVA = "0x8F58C0", Offset = "0x8F46C0", Length = "0x35")]
	public override bool PerformInteraction()
	{
		return false;
	}

	[Token(Token = "0x60029E4")]
	[Address(RVA = "0x8F5900", Offset = "0x8F4700", Length = "0xD3")]
	protected override void BeginHold()
	{
	}

	[Token(Token = "0x60029E5")]
	[Address(RVA = "0x8F59E0", Offset = "0x8F47E0", Length = "0x5E")]
	protected override void EndHold()
	{
	}

	[Token(Token = "0x60029E6")]
	[Address(RVA = "0x8F4D40", Offset = "0x8F3B40", Length = "0x7")]
	public HarvestableInteraction()
	{
	}
}
