using Cpp2ILInjected;
using TLD.IntBackedUnit;
using TLD.UI.Generics;
using UnityEngine;

[Token(Token = "0x20005C1")]
public class WaterSource : MonoBehaviour
{
	[SerializeField]
	[Token(Token = "0x400351C")]
	[FieldOffset(Offset = "0x20")]
	private ItemLiquidVolume m_MinStarting;

	[SerializeField]
	[Token(Token = "0x400351D")]
	[FieldOffset(Offset = "0x28")]
	private ItemLiquidVolume m_MaxStarting;

	[SerializeField]
	[Token(Token = "0x400351E")]
	[FieldOffset(Offset = "0x30")]
	private ItemLiquidVolume m_Capacity;

	[Token(Token = "0x400351F")]
	[FieldOffset(Offset = "0x38")]
	public float m_ChanceContaminated;

	[Token(Token = "0x4003520")]
	[FieldOffset(Offset = "0x40")]
	public string m_OpenAudio;

	[Token(Token = "0x4003521")]
	[FieldOffset(Offset = "0x48")]
	public string m_TakeAudio;

	[Token(Token = "0x4003522")]
	[FieldOffset(Offset = "0x50")]
	public float m_SpawnChance;

	[SerializeField]
	[Token(Token = "0x4003523")]
	[FieldOffset(Offset = "0x58")]
	private PanelReference<Panel_PickWater> m_PickWater;

	[Token(Token = "0x4003524")]
	[FieldOffset(Offset = "0x60")]
	private ItemLiquidVolume m_CurrentLiters;

	[Token(Token = "0x4003525")]
	[FieldOffset(Offset = "0x68")]
	private LiquidQuality m_CurrentLiquidQuality;

	[Token(Token = "0x4003526")]
	[FieldOffset(Offset = "0x6C")]
	private bool m_RolledSpawnChance;

	[Token(Token = "0x4003527")]
	[FieldOffset(Offset = "0x6D")]
	private bool m_StartHasBeenCalled;

	[Token(Token = "0x4003528")]
	private static WaterSourceSaveDataProxy m_WaterSourceSaveDataProxy;

	[Token(Token = "0x6002C7C")]
	[Address(RVA = "0x936E90", Offset = "0x935C90", Length = "0x14D")]
	private void Awake()
	{
	}

	[Token(Token = "0x6002C7D")]
	[Address(RVA = "0x936FE0", Offset = "0x935DE0", Length = "0xC6")]
	private void Start()
	{
	}

	[Token(Token = "0x6002C7E")]
	[Address(RVA = "0x9370B0", Offset = "0x935EB0", Length = "0xAF")]
	private void Update()
	{
	}

	[Token(Token = "0x6002C7F")]
	[Address(RVA = "0x6E2FE0", Offset = "0x6E1DE0", Length = "0x5")]
	public ItemLiquidVolume GetVolumeLiters()
	{
		return default(ItemLiquidVolume);
	}

	[Token(Token = "0x6002C80")]
	[Address(RVA = "0x937160", Offset = "0x935F60", Length = "0x4")]
	public LiquidQuality GetQuality()
	{
		return default(LiquidQuality);
	}

	[Token(Token = "0x6002C81")]
	[Address(RVA = "0x937170", Offset = "0x935F70", Length = "0xC9")]
	public ItemLiquidVolume RemoveLiters(ItemLiquidVolume liters)
	{
		return default(ItemLiquidVolume);
	}

	[Token(Token = "0x6002C82")]
	[Address(RVA = "0x937240", Offset = "0x936040", Length = "0x346")]
	public void PerformInteraction()
	{
	}

	[Token(Token = "0x6002C83")]
	[Address(RVA = "0x937590", Offset = "0x936390", Length = "0x122")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x6002C84")]
	[Address(RVA = "0x9376C0", Offset = "0x9364C0", Length = "0x15A")]
	public void Deserialize(string text)
	{
	}

	[Token(Token = "0x6002C85")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public WaterSource()
	{
	}
}
