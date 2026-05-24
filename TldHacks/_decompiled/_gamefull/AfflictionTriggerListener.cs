using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20009ED")]
public abstract class AfflictionTriggerListener : MonoBehaviour
{
	[Token(Token = "0x4006522")]
	[FieldOffset(Offset = "0x20")]
	private int m_ActiveZones;

	[Token(Token = "0x17000383")]
	public bool HasActiveZones
	{
		[Token(Token = "0x600577D")]
		[Address(RVA = "0xED5560", Offset = "0xED4360", Length = "0x8")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x17000384")]
	public int NumActiveZones
	{
		[Token(Token = "0x600577E")]
		[Address(RVA = "0x4571E0", Offset = "0x455FE0", Length = "0x4")]
		get
		{
			return 0;
		}
	}

	[Token(Token = "0x600577F")]
	protected abstract bool IsSupportedType(AfflictionType afflictionType);

	[Token(Token = "0x6005780")]
	public abstract void OnStartAffliction();

	[Token(Token = "0x6005781")]
	public abstract void OnStopAffliction();

	[Token(Token = "0x6005782")]
	[Address(RVA = "0xED5570", Offset = "0xED4370", Length = "0x3E1")]
	protected void Awake()
	{
	}

	[Token(Token = "0x6005783")]
	[Address(RVA = "0xED5960", Offset = "0xED4760", Length = "0x3E1")]
	protected void OnDestroy()
	{
	}

	[Token(Token = "0x6005784")]
	[Address(RVA = "0xED5D50", Offset = "0xED4B50", Length = "0x29")]
	private void DecrementActiveZones()
	{
	}

	[Token(Token = "0x6005785")]
	[Address(RVA = "0xED5D80", Offset = "0xED4B80", Length = "0x1B")]
	private void IncrementActiveZones()
	{
	}

	[Token(Token = "0x6005786")]
	[Address(RVA = "0xED5DA0", Offset = "0xED4BA0", Length = "0x56")]
	private void OnTriggerEventDisable(AfflictionType afflictionType)
	{
	}

	[Token(Token = "0x6005787")]
	[Address(RVA = "0xED5E00", Offset = "0xED4C00", Length = "0x48")]
	private void OnTriggerEventEnter(AfflictionType afflictionType)
	{
	}

	[Token(Token = "0x6005788")]
	[Address(RVA = "0xED5DA0", Offset = "0xED4BA0", Length = "0x56")]
	private void OnTriggerEventExit(AfflictionType afflictionType)
	{
	}

	[Token(Token = "0x6005789")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	protected AfflictionTriggerListener()
	{
	}
}
