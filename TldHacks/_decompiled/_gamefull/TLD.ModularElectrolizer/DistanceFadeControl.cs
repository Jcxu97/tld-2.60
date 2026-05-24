using Cpp2ILInjected;

namespace TLD.ModularElectrolizer;

[Token(Token = "0x20013CC")]
public class DistanceFadeControl
{
	[Token(Token = "0x4009128")]
	[FieldOffset(Offset = "0x10")]
	private DistanceParameters m_OutdoorDistance;

	[Token(Token = "0x4009129")]
	[FieldOffset(Offset = "0x18")]
	private DistanceParameters m_IndoorDistance;

	[Token(Token = "0x400912A")]
	[FieldOffset(Offset = "0x20")]
	private float m_MaxCullDistSqr;

	[Token(Token = "0x400912B")]
	[FieldOffset(Offset = "0x24")]
	private float m_MaxFadeDistSqr;

	[Token(Token = "0x400912C")]
	[FieldOffset(Offset = "0x28")]
	private float m_DistanceIntensity;

	[Token(Token = "0x400912D")]
	[FieldOffset(Offset = "0x2C")]
	private QualityLodBias m_CachedQualitySetting;

	[Token(Token = "0x17000ACB")]
	public float DistanceIntensity
	{
		[Token(Token = "0x6007E87")]
		[Address(RVA = "0x504290", Offset = "0x503090", Length = "0x6")]
		get
		{
			return 0f;
		}
	}

	[Token(Token = "0x17000ACC")]
	public float MaxDistanceSqr
	{
		[Token(Token = "0x6007E88")]
		[Address(RVA = "0x5042F0", Offset = "0x5030F0", Length = "0x6")]
		get
		{
			return 0f;
		}
	}

	[Token(Token = "0x17000ACD")]
	public float MaxFadeSqr
	{
		[Token(Token = "0x6007E89")]
		[Address(RVA = "0x504310", Offset = "0x503110", Length = "0x6")]
		get
		{
			return 0f;
		}
	}

	[Token(Token = "0x6007E8A")]
	[Address(RVA = "0x409520", Offset = "0x408320", Length = "0xAA")]
	public DistanceFadeControl(DistanceParameters outdoor, DistanceParameters indoor)
	{
	}

	[Token(Token = "0x6007E8B")]
	[Address(RVA = "0x11E1C60", Offset = "0x11E0A60", Length = "0xE8")]
	public void SetLocationDistances(bool useOutdoorValues, QualityLodBias quality, bool forceUpdate = false)
	{
	}

	[Token(Token = "0x6007E8C")]
	[Address(RVA = "0x11E1D50", Offset = "0x11E0B50", Length = "0x7E")]
	public void CalculateDistanceIntensity(float camDistSqr)
	{
	}
}
