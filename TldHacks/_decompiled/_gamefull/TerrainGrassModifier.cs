using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000400")]
public class TerrainGrassModifier : MonoBehaviour
{
	[Token(Token = "0x2000401")]
	private class ModifiedRegion
	{
		[Token(Token = "0x4002406")]
		[FieldOffset(Offset = "0x10")]
		public int m_Id;

		[Token(Token = "0x4002407")]
		[FieldOffset(Offset = "0x14")]
		public int m_DetailLayer;

		[Token(Token = "0x4002408")]
		[FieldOffset(Offset = "0x18")]
		public int m_X;

		[Token(Token = "0x4002409")]
		[FieldOffset(Offset = "0x1C")]
		public int m_Y;

		[Token(Token = "0x400240A")]
		[FieldOffset(Offset = "0x20")]
		public int[,] m_CellData;

		[Token(Token = "0x400240B")]
		public static int m_NextId;

		[Token(Token = "0x6001E97")]
		[Address(RVA = "0x7C33C0", Offset = "0x7C21C0", Length = "0xC6")]
		public ModifiedRegion(int layer, int x, int y, int[,] cellData)
		{
		}
	}

	[Token(Token = "0x4002404")]
	[FieldOffset(Offset = "0x20")]
	private Terrain m_Terrain;

	[Token(Token = "0x4002405")]
	[FieldOffset(Offset = "0x28")]
	private List<ModifiedRegion> m_ModifiedRegions;

	[Token(Token = "0x6001E90")]
	[Address(RVA = "0x7C2430", Offset = "0x7C1230", Length = "0x218")]
	private void Start()
	{
	}

	[Token(Token = "0x6001E91")]
	[Address(RVA = "0x7C2650", Offset = "0x7C1450", Length = "0x25E")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6001E92")]
	[Address(RVA = "0x7C28B0", Offset = "0x7C16B0", Length = "0x35")]
	public void AddGrass(Vector3 position, float radius, int value, int layerIndex)
	{
	}

	[Token(Token = "0x6001E93")]
	[Address(RVA = "0x7C28F0", Offset = "0x7C16F0", Length = "0x38")]
	public void RemoveGrass(Vector3 position, float radius)
	{
	}

	[Token(Token = "0x6001E94")]
	[Address(RVA = "0x7C2930", Offset = "0x7C1730", Length = "0x25A")]
	public void UndoLastOperation()
	{
	}

	[Token(Token = "0x6001E95")]
	[Address(RVA = "0x7C2B90", Offset = "0x7C1990", Length = "0x823")]
	private void DrawToMap(Vector3 position, float radius, int value, int layerIndex = -1)
	{
	}

	[Token(Token = "0x6001E96")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public TerrainGrassModifier()
	{
	}
}
