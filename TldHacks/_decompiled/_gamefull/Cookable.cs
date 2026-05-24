using AK.Wwise;
using Cpp2ILInjected;
using TLD.IntBackedUnit;
using TLD.UI.Generics;
using UnityEngine;
using UnityEngine.Serialization;

[Token(Token = "0x2000473")]
public class Cookable : MonoBehaviour
{
	[Token(Token = "0x2000474")]
	public enum CookableType
	{
		[Token(Token = "0x4002844")]
		Meat,
		[Token(Token = "0x4002845")]
		Grub,
		[Token(Token = "0x4002846")]
		Liquid
	}

	[SerializeField]
	[Token(Token = "0x400282C")]
	[FieldOffset(Offset = "0x20")]
	private PanelReference<Panel_Inventory> m_Inventory;

	[Token(Token = "0x400282D")]
	[FieldOffset(Offset = "0x28")]
	public GearItem m_CookedPrefab;

	[Token(Token = "0x400282E")]
	[FieldOffset(Offset = "0x30")]
	public float m_CookTimeMinutes;

	[Token(Token = "0x400282F")]
	[FieldOffset(Offset = "0x34")]
	public float m_ReadyTimeMinutes;

	[FormerlySerializedAs("m_CanBePickedUpRaw")]
	[Token(Token = "0x4002830")]
	[FieldOffset(Offset = "0x38")]
	public bool m_CanBePickedUpWhileCooking;

	[Token(Token = "0x4002831")]
	[FieldOffset(Offset = "0x40")]
	public ItemLiquidVolume m_PotableWaterRequired;

	[Token(Token = "0x4002832")]
	[FieldOffset(Offset = "0x48")]
	public int m_NumUnitsRequired;

	[Token(Token = "0x4002833")]
	[FieldOffset(Offset = "0x4C")]
	public float m_LitersLampOilPerKG;

	[Token(Token = "0x4002834")]
	[FieldOffset(Offset = "0x50")]
	public CookableType m_CookableType;

	[Token(Token = "0x4002835")]
	[FieldOffset(Offset = "0x54")]
	public float m_WarmUpNearFireRange;

	[Token(Token = "0x4002836")]
	[FieldOffset(Offset = "0x58")]
	public MeshRenderer m_LiquidMeshRenderer;

	[Header("Audio")]
	[SerializeField]
	[Token(Token = "0x4002837")]
	[FieldOffset(Offset = "0x60")]
	private AK.Wwise.Event m_PutInPotEvent;

	[SerializeField]
	[Token(Token = "0x4002838")]
	[FieldOffset(Offset = "0x68")]
	private AK.Wwise.Event m_CookEvent;

	[HideInInspector]
	[Token(Token = "0x4002839")]
	[FieldOffset(Offset = "0x70")]
	public bool m_DoNotCookWhenDropped;

	[Header("Rendering")]
	[Token(Token = "0x400283A")]
	[FieldOffset(Offset = "0x78")]
	public Material[] m_CookingPotMaterialsList;

	[Token(Token = "0x400283B")]
	[FieldOffset(Offset = "0x80")]
	public Material[] m_CookingPotRawMaterialsList;

	[Token(Token = "0x400283C")]
	[FieldOffset(Offset = "0x88")]
	public Material[] m_RuinedMaterials;

	[Token(Token = "0x400283D")]
	[FieldOffset(Offset = "0x90")]
	public Mesh m_MeshPotStyle;

	[Token(Token = "0x400283E")]
	[FieldOffset(Offset = "0x98")]
	public Mesh m_MeshRawPotStyle;

	[Token(Token = "0x400283F")]
	[FieldOffset(Offset = "0xA0")]
	public Mesh m_MeshCanStyle;

	[Token(Token = "0x4002840")]
	[FieldOffset(Offset = "0xA8")]
	public Mesh m_MeshRawCanStyle;

	[Token(Token = "0x4002841")]
	[FieldOffset(Offset = "0xB0")]
	public Mesh m_MeshFryingPanStyle;

	[Token(Token = "0x4002842")]
	[FieldOffset(Offset = "0xB8")]
	public Mesh m_MeshRawFryingPanStyle;

	[Token(Token = "0x17000221")]
	public AK.Wwise.Event PutInPotAudio
	{
		[Token(Token = "0x6002176")]
		[Address(RVA = "0x6E2FE0", Offset = "0x6E1DE0", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000222")]
	public AK.Wwise.Event CookAudio
	{
		[Token(Token = "0x6002177")]
		[Address(RVA = "0x65D9D0", Offset = "0x65C7D0", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6002178")]
	[Address(RVA = "0x8113F0", Offset = "0x8101F0", Length = "0x549")]
	public void MaybeStartWarmingUpDueToNearbyFire()
	{
	}

	[Token(Token = "0x6002179")]
	[Address(RVA = "0x811940", Offset = "0x810740", Length = "0x2F2")]
	public void MaybeReattachToNearbyFire(CookingPotItem cookingPot)
	{
	}

	[Token(Token = "0x600217A")]
	[Address(RVA = "0x811C40", Offset = "0x810A40", Length = "0x142")]
	public bool IsNearFire()
	{
		return false;
	}

	[Token(Token = "0x600217B")]
	[Address(RVA = "0x811D90", Offset = "0x810B90", Length = "0x293")]
	public float GetCookTimeMinutesForCaloriesRemaining()
	{
		return 0f;
	}

	[Token(Token = "0x600217C")]
	[Address(RVA = "0x812030", Offset = "0x810E30", Length = "0x55")]
	public Cookable()
	{
	}
}
