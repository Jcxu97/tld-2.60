using Cpp2ILInjected;
using UnityEngine;

[CreateAssetMenu(order = 10001)]
[Token(Token = "0x20009BB")]
public class TerrainLayerTemplate : ScriptableObject
{
	[Token(Token = "0x20009BC")]
	public enum TerrainType
	{
		[Token(Token = "0x400635A")]
		Snow,
		[Token(Token = "0x400635B")]
		Ice,
		[Token(Token = "0x400635C")]
		Cave
	}

	[Token(Token = "0x4006356")]
	[FieldOffset(Offset = "0x18")]
	public string m_TemplateName;

	[Token(Token = "0x4006357")]
	[FieldOffset(Offset = "0x20")]
	public TerrainType m_TerrainType;

	[Token(Token = "0x4006358")]
	[FieldOffset(Offset = "0x28")]
	public TerrainLayer[] m_Layers;

	[Token(Token = "0x600564C")]
	[Address(RVA = "0x4A22A0", Offset = "0x4A10A0", Length = "0x7")]
	public TerrainLayerTemplate()
	{
	}
}
