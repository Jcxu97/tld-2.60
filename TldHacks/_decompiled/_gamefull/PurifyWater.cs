using Cpp2ILInjected;
using TLD.IntBackedUnit;
using UnityEngine;

[Token(Token = "0x20004C9")]
public class PurifyWater : MonoBehaviour
{
	[Token(Token = "0x4002C01")]
	[FieldOffset(Offset = "0x20")]
	public ItemLiquidVolume m_LitersPurify;

	[Token(Token = "0x4002C02")]
	[FieldOffset(Offset = "0x28")]
	public float m_ProgressBarDurationSeconds;

	[Token(Token = "0x4002C03")]
	[FieldOffset(Offset = "0x30")]
	public LocalizedString m_LocalizedProgressBarMessage;

	[Token(Token = "0x4002C04")]
	[FieldOffset(Offset = "0x38")]
	public string m_PurifyAudio;

	[Token(Token = "0x1700024A")]
	public string m_ProgressBarMessage
	{
		[Token(Token = "0x600248A")]
		[Address(RVA = "0x74FF70", Offset = "0x74ED70", Length = "0x5D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600248B")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public void Start()
	{
	}

	[Token(Token = "0x600248C")]
	[Address(RVA = "0x86A870", Offset = "0x869670", Length = "0x194")]
	public ItemLiquidVolume Use()
	{
		return default(ItemLiquidVolume);
	}

	[Token(Token = "0x600248D")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public PurifyWater()
	{
	}
}
