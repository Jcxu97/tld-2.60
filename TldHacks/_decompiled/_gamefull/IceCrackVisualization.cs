using Cpp2ILInjected;
using TLD.Events;
using UnityEngine;
using UnityEngine.Rendering;

[Token(Token = "0x20003B1")]
public class IceCrackVisualization : MonoBehaviour
{
	[Token(Token = "0x20003B2")]
	private class DecalData
	{
		[Token(Token = "0x400210B")]
		[FieldOffset(Offset = "0x10")]
		public StaticDecal m_Decal;

		[Token(Token = "0x400210C")]
		[FieldOffset(Offset = "0x18")]
		public float m_CrackAmount;

		[Token(Token = "0x400210D")]
		[FieldOffset(Offset = "0x1C")]
		public float m_LastUpdateTime;

		[Token(Token = "0x400210E")]
		[FieldOffset(Offset = "0x20")]
		public float m_Lifetime;

		[Token(Token = "0x6001D2C")]
		[Address(RVA = "0x797910", Offset = "0x796710", Length = "0x87")]
		public DecalData()
		{
		}

		[Token(Token = "0x6001D2D")]
		[Address(RVA = "0x7979A0", Offset = "0x7967A0", Length = "0x7")]
		public void Reset()
		{
		}
	}

	[SerializeField]
	[Token(Token = "0x4002108")]
	[FieldOffset(Offset = "0x20")]
	private IceCrackingEvent m_IceCrackingEvent;

	[SerializeField]
	[Token(Token = "0x4002109")]
	[FieldOffset(Offset = "0x28")]
	private IceCrackVisualizationData m_Data;

	[Token(Token = "0x400210A")]
	[FieldOffset(Offset = "0x30")]
	private DecalData[] m_Decals;

	[Token(Token = "0x6001D26")]
	[Address(RVA = "0x7967E0", Offset = "0x7955E0", Length = "0x229")]
	private void Awake()
	{
	}

	[Token(Token = "0x6001D27")]
	[Address(RVA = "0x796A10", Offset = "0x795810", Length = "0x136")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6001D28")]
	[Address(RVA = "0x796B50", Offset = "0x795950", Length = "0x165")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6001D29")]
	[Address(RVA = "0x796CC0", Offset = "0x795AC0", Length = "0x8D9")]
	private void OnIceCracked()
	{
	}

	[Token(Token = "0x6001D2A")]
	[Address(RVA = "0x7975A0", Offset = "0x7963A0", Length = "0x290")]
	private void OnProcessCommandBuffer(DecalData decalData, CommandBuffer commandBuffer)
	{
	}

	[Token(Token = "0x6001D2B")]
	[Address(RVA = "0x797840", Offset = "0x796640", Length = "0xC2")]
	public IceCrackVisualization()
	{
	}
}
