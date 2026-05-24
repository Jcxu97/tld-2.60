using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200039C")]
public struct SnowImprint
{
	[Token(Token = "0x4002050")]
	[FieldOffset(Offset = "0x0")]
	private byte m_P0;

	[Token(Token = "0x4002051")]
	[FieldOffset(Offset = "0x1")]
	private byte m_P1;

	[Token(Token = "0x4002052")]
	[FieldOffset(Offset = "0x2")]
	private byte m_P2;

	[Token(Token = "0x4002053")]
	[FieldOffset(Offset = "0x3")]
	private byte m_P3;

	[Token(Token = "0x4002054")]
	[FieldOffset(Offset = "0x4")]
	private byte m_P4;

	[Token(Token = "0x4002055")]
	[FieldOffset(Offset = "0x5")]
	private byte m_P5;

	[Token(Token = "0x4002056")]
	[FieldOffset(Offset = "0x6")]
	private byte m_P6;

	[Token(Token = "0x4002057")]
	[FieldOffset(Offset = "0x7")]
	private byte m_P7;

	[Token(Token = "0x4002058")]
	[FieldOffset(Offset = "0x8")]
	private byte m_P8;

	[Token(Token = "0x4002059")]
	[FieldOffset(Offset = "0x9")]
	private sbyte m_N0D;

	[Token(Token = "0x400205A")]
	[FieldOffset(Offset = "0xA")]
	private sbyte m_N1D;

	[Token(Token = "0x400205B")]
	[FieldOffset(Offset = "0xB")]
	private sbyte m_N2D;

	[Token(Token = "0x400205C")]
	[FieldOffset(Offset = "0xC")]
	private uint m_MiscInfo;

	[Token(Token = "0x400205D")]
	public const int SERIALIZED_NUM_UINTS = 4;

	[Token(Token = "0x17000202")]
	public Vector3 Position
	{
		[Token(Token = "0x6001C98")]
		[Address(RVA = "0x7874C0", Offset = "0x7862C0", Length = "0xCF")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6001C99")]
		[Address(RVA = "0x787590", Offset = "0x786390", Length = "0x8B")]
		set
		{
		}
	}

	[Token(Token = "0x17000203")]
	public Vector3 Normal
	{
		[Token(Token = "0x6001C9A")]
		[Address(RVA = "0x787620", Offset = "0x786420", Length = "0x59")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6001C9B")]
		[Address(RVA = "0x787680", Offset = "0x786480", Length = "0x4D")]
		set
		{
		}
	}

	[Token(Token = "0x17000204")]
	public float Depth
	{
		[Token(Token = "0x6001C9C")]
		[Address(RVA = "0x7876D0", Offset = "0x7864D0", Length = "0x2F")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6001C9D")]
		[Address(RVA = "0x787700", Offset = "0x786500", Length = "0x37")]
		set
		{
		}
	}

	[Token(Token = "0x17000205")]
	public float InitialSnowDepth
	{
		[Token(Token = "0x6001C9E")]
		[Address(RVA = "0x787740", Offset = "0x786540", Length = "0x33")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6001C9F")]
		[Address(RVA = "0x787780", Offset = "0x786580", Length = "0x5D")]
		set
		{
		}
	}

	[Token(Token = "0x17000206")]
	public float Angle
	{
		[Token(Token = "0x6001CA0")]
		[Address(RVA = "0x7877E0", Offset = "0x7865E0", Length = "0x20")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6001CA1")]
		[Address(RVA = "0x787800", Offset = "0x786600", Length = "0x82")]
		set
		{
		}
	}

	[Token(Token = "0x17000207")]
	public SnowImprintType Type
	{
		[Token(Token = "0x6001CA2")]
		[Address(RVA = "0x787890", Offset = "0x786690", Length = "0xA")]
		get
		{
			return default(SnowImprintType);
		}
		[Token(Token = "0x6001CA3")]
		[Address(RVA = "0x7878A0", Offset = "0x7866A0", Length = "0xE")]
		set
		{
		}
	}

	[Token(Token = "0x17000208")]
	public int VariantIndex
	{
		[Token(Token = "0x6001CA4")]
		[Address(RVA = "0x7878B0", Offset = "0x7866B0", Length = "0xA")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6001CA5")]
		[Address(RVA = "0x7878C0", Offset = "0x7866C0", Length = "0x11")]
		set
		{
		}
	}

	[Token(Token = "0x17000209")]
	public bool Flip
	{
		[Token(Token = "0x6001CA6")]
		[Address(RVA = "0x7878E0", Offset = "0x7866E0", Length = "0xB")]
		get
		{
			return false;
		}
		[Token(Token = "0x6001CA7")]
		[Address(RVA = "0x7878F0", Offset = "0x7866F0", Length = "0x13")]
		set
		{
		}
	}

	[Token(Token = "0x1700020A")]
	public bool HasHeightMap
	{
		[Token(Token = "0x6001CA8")]
		[Address(RVA = "0x787910", Offset = "0x786710", Length = "0xB")]
		get
		{
			return false;
		}
		[Token(Token = "0x6001CA9")]
		[Address(RVA = "0x787920", Offset = "0x786720", Length = "0x13")]
		set
		{
		}
	}

	[Token(Token = "0x1700020B")]
	public bool HasBumpDecal
	{
		[Token(Token = "0x6001CAA")]
		[Address(RVA = "0x787940", Offset = "0x786740", Length = "0xB")]
		get
		{
			return false;
		}
		[Token(Token = "0x6001CAB")]
		[Address(RVA = "0x787950", Offset = "0x786750", Length = "0x1B")]
		set
		{
		}
	}

	[Token(Token = "0x6001C96")]
	[Address(RVA = "0x7870B0", Offset = "0x785EB0", Length = "0x2BE")]
	public SnowImprint(SnowImprintType type, Vector3 pos, Vector3 normal, float yRotation, float depth, bool flip, int variant)
	{
		m_P0 = 0;
		m_P1 = 0;
		m_P2 = 0;
		m_P3 = 0;
		m_P4 = 0;
		m_P5 = 0;
		m_P6 = 0;
		m_P7 = 0;
		m_P8 = 0;
		m_N0D = 0;
		m_N1D = 0;
		m_N2D = 0;
		m_MiscInfo = 0u;
	}

	[Token(Token = "0x6001C97")]
	[Address(RVA = "0x787370", Offset = "0x786170", Length = "0x14C")]
	public SnowImprint(List<uint> serializedList, ref int index)
	{
		m_P0 = 0;
		m_P1 = 0;
		m_P2 = 0;
		m_P3 = 0;
		m_P4 = 0;
		m_P5 = 0;
		m_P6 = 0;
		m_P7 = 0;
		m_P8 = 0;
		m_N0D = 0;
		m_N1D = 0;
		m_N2D = 0;
		m_MiscInfo = 0u;
	}

	[Token(Token = "0x6001CAC")]
	[Address(RVA = "0x787970", Offset = "0x786770", Length = "0x39")]
	private float FloatFromBytes(byte b0, byte b1, byte b2)
	{
		return 0f;
	}

	[Token(Token = "0x6001CAD")]
	[Address(RVA = "0x7879B0", Offset = "0x7867B0", Length = "0x78")]
	private void FloatToBytes(float f, out byte b0, out byte b1, out byte b2)
	{
		b0 = default(byte);
		b1 = default(byte);
		b2 = default(byte);
	}

	[Token(Token = "0x6001CAE")]
	[Address(RVA = "0x787A30", Offset = "0x786830", Length = "0x1ED")]
	public void AddForSerialize(List<uint> list)
	{
	}

	[Token(Token = "0x6001CAF")]
	[Address(RVA = "0x787C20", Offset = "0x786A20", Length = "0x2F4")]
	public override string ToString()
	{
		return null;
	}
}
