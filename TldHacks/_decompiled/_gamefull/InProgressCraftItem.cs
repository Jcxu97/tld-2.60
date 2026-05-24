using Cpp2ILInjected;
using TLD.Gear;
using TLD.IntBackedUnit;
using UnityEngine;

[Token(Token = "0x20004B2")]
public class InProgressCraftItem : MonoBehaviour
{
	[Token(Token = "0x20004B3")]
	public class InProgressCraftItemSaveDataProxy
	{
		[Token(Token = "0x4002B60")]
		[FieldOffset(Offset = "0x10")]
		public float m_PercentComplete;

		[Token(Token = "0x4002B61")]
		[FieldOffset(Offset = "0x18")]
		public ItemWeight m_Weight;

		[Token(Token = "0x60023FF")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public InProgressCraftItemSaveDataProxy()
		{
		}
	}

	[Token(Token = "0x4002B5D")]
	[FieldOffset(Offset = "0x20")]
	private float m_PercentComplete;

	[Token(Token = "0x4002B5E")]
	[FieldOffset(Offset = "0x28")]
	private ItemWeight m_Weight;

	[Token(Token = "0x4002B5F")]
	private static InProgressCraftItemSaveDataProxy m_InProgressCraftItemSaveDataProxy;

	[Token(Token = "0x60023F0")]
	[Address(RVA = "0x85F0C0", Offset = "0x85DEC0", Length = "0xE7")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x60023F1")]
	[Address(RVA = "0x85F1B0", Offset = "0x85DFB0", Length = "0x21")]
	public void Serialize(InProgressCraftItemSaveDataProxy proxy)
	{
	}

	[Token(Token = "0x60023F2")]
	[Address(RVA = "0x85F1E0", Offset = "0x85DFE0", Length = "0x8F")]
	public void Deserialize(string text)
	{
	}

	[Token(Token = "0x60023F3")]
	[Address(RVA = "0x85F270", Offset = "0x85E070", Length = "0x14")]
	public void Deserialize(InProgressCraftItemSaveDataProxy proxy)
	{
	}

	[Token(Token = "0x60023F4")]
	[Address(RVA = "0x85F290", Offset = "0x85E090", Length = "0x1A0")]
	public void UpdateWeight(BlueprintData bp)
	{
	}

	[Token(Token = "0x60023F5")]
	[Address(RVA = "0x413AB0", Offset = "0x4128B0", Length = "0x5")]
	public ItemWeight GetWeight()
	{
		return default(ItemWeight);
	}

	[Token(Token = "0x60023F6")]
	[Address(RVA = "0x85F440", Offset = "0x85E240", Length = "0x26")]
	public void IncrementProgress(float percentagePoints)
	{
	}

	[Token(Token = "0x60023F7")]
	[Address(RVA = "0x85F470", Offset = "0x85E270", Length = "0xA7")]
	public bool IsProgressComplete()
	{
		return false;
	}

	[Token(Token = "0x60023F8")]
	[Address(RVA = "0x85F520", Offset = "0x85E320", Length = "0x10")]
	public bool ProgressHasStarted()
	{
		return false;
	}

	[Token(Token = "0x60023F9")]
	[Address(RVA = "0x85F530", Offset = "0x85E330", Length = "0x47")]
	public float GetPercentRemainingNormalized()
	{
		return 0f;
	}

	[Token(Token = "0x60023FA")]
	[Address(RVA = "0x85F580", Offset = "0x85E380", Length = "0x2A")]
	public float GetPercentCompleteNormalized()
	{
		return 0f;
	}

	[Token(Token = "0x60023FB")]
	[Address(RVA = "0x18EF0D0", Offset = "0x18EDED0", Length = "0x177")]
	public static InProgressCraftItem InitializeCraftInProgress<T>(T item) where T : Component
	{
		return null;
	}

	[Token(Token = "0x60023FC")]
	[Address(RVA = "0x85F5B0", Offset = "0x85E3B0", Length = "0x86")]
	private static InProgressCraftItem InitializeCraftInProgress(GameObject item)
	{
		return null;
	}

	[Token(Token = "0x60023FD")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public InProgressCraftItem()
	{
	}
}
