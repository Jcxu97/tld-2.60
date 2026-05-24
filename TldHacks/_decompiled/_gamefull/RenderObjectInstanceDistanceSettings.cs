using Cpp2ILInjected;
using UnityEngine;

[CreateAssetMenu(menuName = "The Long Dark/Rendering/Object Instance Settings")]
[Token(Token = "0x20008EE")]
public class RenderObjectInstanceDistanceSettings : ScriptableObject
{
	[SerializeField]
	[Token(Token = "0x4005D8F")]
	[FieldOffset(Offset = "0x18")]
	private float m_Lod1Distances;

	[SerializeField]
	[Token(Token = "0x4005D90")]
	[FieldOffset(Offset = "0x1C")]
	private float m_Lod2Distances;

	[SerializeField]
	[Token(Token = "0x4005D91")]
	[FieldOffset(Offset = "0x20")]
	private float m_Lod3Distances;

	[SerializeField]
	[Token(Token = "0x4005D92")]
	[FieldOffset(Offset = "0x28")]
	private MinMax m_CullMultiplier;

	[SerializeField]
	[Token(Token = "0x4005D93")]
	[FieldOffset(Offset = "0x30")]
	private MinMax m_HeightAdjust;

	[Token(Token = "0x1700036E")]
	public float Lod1Distance
	{
		[Token(Token = "0x60051F9")]
		[Address(RVA = "0x4A7A60", Offset = "0x4A6860", Length = "0x6")]
		get
		{
			return 0f;
		}
	}

	[Token(Token = "0x1700036F")]
	public float Lod2Distance
	{
		[Token(Token = "0x60051FA")]
		[Address(RVA = "0x5042D0", Offset = "0x5030D0", Length = "0x6")]
		get
		{
			return 0f;
		}
	}

	[Token(Token = "0x17000370")]
	public float Lod3Distance
	{
		[Token(Token = "0x60051FB")]
		[Address(RVA = "0x5042F0", Offset = "0x5030F0", Length = "0x6")]
		get
		{
			return 0f;
		}
	}

	[Token(Token = "0x17000371")]
	public MinMax CullMultiplier
	{
		[Token(Token = "0x60051FC")]
		[Address(RVA = "0x413AB0", Offset = "0x4128B0", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000372")]
	public MinMax HeightAdjust
	{
		[Token(Token = "0x60051FD")]
		[Address(RVA = "0x457420", Offset = "0x456220", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60051FE")]
	[Address(RVA = "0xE39F90", Offset = "0xE38D90", Length = "0x13F")]
	public RenderObjectInstanceDistanceSettings()
	{
	}
}
