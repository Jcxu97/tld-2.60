using System;
using Cpp2ILInjected;
using TLD.AddressableAssets;
using UnityEngine;

[Serializable]
[CreateAssetMenu(menuName = "The Long Dark/Vfx/Weather Activated Effect Data")]
[Token(Token = "0x2000411")]
public class WeatherActivatedEffectData : ScriptableObject
{
	[Token(Token = "0x40024C2")]
	[FieldOffset(Offset = "0x18")]
	public WeatherStage m_WeatherStage;

	[Token(Token = "0x40024C3")]
	[FieldOffset(Offset = "0x20")]
	public AssetReferenceWithComponent<WeatherActivatedEffect> m_EffectAsset;

	[Token(Token = "0x40024C4")]
	[FieldOffset(Offset = "0x28")]
	public AssetReferenceWithComponent<WeatherActivatedEffect> m_EffectAssetLowQuality;

	[Token(Token = "0x6001ECF")]
	[Address(RVA = "0x40E110", Offset = "0x40CF10", Length = "0x5")]
	public AssetReferenceWithComponent<WeatherActivatedEffect> GetEffectAsset()
	{
		return null;
	}

	[Token(Token = "0x6001ED0")]
	[Address(RVA = "0x4A22A0", Offset = "0x4A10A0", Length = "0x7")]
	public WeatherActivatedEffectData()
	{
	}
}
