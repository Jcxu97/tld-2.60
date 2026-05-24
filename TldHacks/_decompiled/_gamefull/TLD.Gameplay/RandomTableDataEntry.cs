using System;
using Cpp2ILInjected;
using UnityEngine.AddressableAssets;
using UnityEngine.Serialization;

namespace TLD.Gameplay;

[Serializable]
[Token(Token = "0x2001491")]
public class RandomTableDataEntry<T> where T : AssetReferenceGameObject
{
	[FormerlySerializedAs("m_GearItem")]
	[Token(Token = "0x400953C")]
	[FieldOffset(Offset = "0x0")]
	public T m_Item;

	[Token(Token = "0x400953D")]
	[FieldOffset(Offset = "0x0")]
	public int m_Weight;

	[Token(Token = "0x600828F")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public RandomTableDataEntry()
	{
	}
}
