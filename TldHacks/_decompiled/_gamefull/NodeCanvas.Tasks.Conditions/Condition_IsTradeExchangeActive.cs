using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using TLD.Trader;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace NodeCanvas.Tasks.Conditions;

[Name("Is Trade Exchange Active", 0)]
[Description("Checks if a specific trade exchange is in the active trade")]
[Category("TLD Conditions/Trader")]
[Token(Token = "0x2001145")]
public class Condition_IsTradeExchangeActive : ConditionTask
{
	[Token(Token = "0x40087B1")]
	[FieldOffset(Offset = "0x68")]
	public AssetReferenceTradeExchange m_TradeExchangeReference;

	[Token(Token = "0x40087B2")]
	[FieldOffset(Offset = "0x70")]
	private AsyncOperationHandle<TradeExchange> m_TradeExchangeHandle;

	[Token(Token = "0x600745D")]
	[Address(RVA = "0x10FCCF0", Offset = "0x10FBAF0", Length = "0x26B")]
	protected override bool OnCheck()
	{
		return false;
	}

	[Token(Token = "0x600745E")]
	[Address(RVA = "0x10C6920", Offset = "0x10C5720", Length = "0x8")]
	public Condition_IsTradeExchangeActive()
	{
	}
}
