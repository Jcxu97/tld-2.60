using Cpp2ILInjected;

namespace UnityEngine.Rendering.PostProcessing;

[Token(Token = "0x2000CF0")]
public class HableCurve
{
	[Token(Token = "0x2000CF1")]
	private class Segment
	{
		[Token(Token = "0x4008035")]
		[FieldOffset(Offset = "0x10")]
		public float offsetX;

		[Token(Token = "0x4008036")]
		[FieldOffset(Offset = "0x14")]
		public float offsetY;

		[Token(Token = "0x4008037")]
		[FieldOffset(Offset = "0x18")]
		public float scaleX;

		[Token(Token = "0x4008038")]
		[FieldOffset(Offset = "0x1C")]
		public float scaleY;

		[Token(Token = "0x4008039")]
		[FieldOffset(Offset = "0x20")]
		public float lnA;

		[Token(Token = "0x400803A")]
		[FieldOffset(Offset = "0x24")]
		public float B;

		[Token(Token = "0x6006672")]
		[Address(RVA = "0x1028B40", Offset = "0x1027940", Length = "0x42")]
		public float Eval(float x)
		{
			return 0f;
		}

		[Token(Token = "0x6006673")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public Segment()
		{
		}
	}

	[Token(Token = "0x2000CF2")]
	private struct DirectParams
	{
		[Token(Token = "0x400803B")]
		[FieldOffset(Offset = "0x0")]
		internal float x0;

		[Token(Token = "0x400803C")]
		[FieldOffset(Offset = "0x4")]
		internal float y0;

		[Token(Token = "0x400803D")]
		[FieldOffset(Offset = "0x8")]
		internal float x1;

		[Token(Token = "0x400803E")]
		[FieldOffset(Offset = "0xC")]
		internal float y1;

		[Token(Token = "0x400803F")]
		[FieldOffset(Offset = "0x10")]
		internal float W;

		[Token(Token = "0x4008040")]
		[FieldOffset(Offset = "0x14")]
		internal float overshootX;

		[Token(Token = "0x4008041")]
		[FieldOffset(Offset = "0x18")]
		internal float overshootY;

		[Token(Token = "0x4008042")]
		[FieldOffset(Offset = "0x1C")]
		internal float gamma;
	}

	[Token(Token = "0x2000CF3")]
	public class Uniforms
	{
		[Token(Token = "0x4008043")]
		[FieldOffset(Offset = "0x10")]
		private HableCurve parent;

		[Token(Token = "0x170006EC")]
		public Vector4 curve
		{
			[Token(Token = "0x6006675")]
			[Address(RVA = "0x1028B90", Offset = "0x1027990", Length = "0x35")]
			get
			{
				return default(Vector4);
			}
		}

		[Token(Token = "0x170006ED")]
		public Vector4 toeSegmentA
		{
			[Token(Token = "0x6006676")]
			[Address(RVA = "0x1028BD0", Offset = "0x10279D0", Length = "0x56")]
			get
			{
				return default(Vector4);
			}
		}

		[Token(Token = "0x170006EE")]
		public Vector4 toeSegmentB
		{
			[Token(Token = "0x6006677")]
			[Address(RVA = "0x1028C30", Offset = "0x1027A30", Length = "0x49")]
			get
			{
				return default(Vector4);
			}
		}

		[Token(Token = "0x170006EF")]
		public Vector4 midSegmentA
		{
			[Token(Token = "0x6006678")]
			[Address(RVA = "0x1028C80", Offset = "0x1027A80", Length = "0x56")]
			get
			{
				return default(Vector4);
			}
		}

		[Token(Token = "0x170006F0")]
		public Vector4 midSegmentB
		{
			[Token(Token = "0x6006679")]
			[Address(RVA = "0x1028CE0", Offset = "0x1027AE0", Length = "0x49")]
			get
			{
				return default(Vector4);
			}
		}

		[Token(Token = "0x170006F1")]
		public Vector4 shoSegmentA
		{
			[Token(Token = "0x600667A")]
			[Address(RVA = "0x1028D30", Offset = "0x1027B30", Length = "0x56")]
			get
			{
				return default(Vector4);
			}
		}

		[Token(Token = "0x170006F2")]
		public Vector4 shoSegmentB
		{
			[Token(Token = "0x600667B")]
			[Address(RVA = "0x1028D90", Offset = "0x1027B90", Length = "0x49")]
			get
			{
				return default(Vector4);
			}
		}

		[Token(Token = "0x6006674")]
		[Address(RVA = "0x4094C0", Offset = "0x4082C0", Length = "0x52")]
		internal Uniforms(HableCurve parent)
		{
		}
	}

	[Token(Token = "0x4008033")]
	[FieldOffset(Offset = "0x20")]
	private readonly Segment[] m_Segments;

	[Token(Token = "0x4008034")]
	[FieldOffset(Offset = "0x28")]
	public readonly Uniforms uniforms;

	[Token(Token = "0x170006E8")]
	[field: Token(Token = "0x400802F")]
	[field: FieldOffset(Offset = "0x10")]
	public float whitePoint
	{
		[Token(Token = "0x6006663")]
		[Address(RVA = "0x4A7A20", Offset = "0x4A6820", Length = "0x6")]
		get;
		[Token(Token = "0x6006664")]
		[Address(RVA = "0x4A7A10", Offset = "0x4A6810", Length = "0x6")]
		private set;
	}

	[Token(Token = "0x170006E9")]
	[field: Token(Token = "0x4008030")]
	[field: FieldOffset(Offset = "0x14")]
	public float inverseWhitePoint
	{
		[Token(Token = "0x6006665")]
		[Address(RVA = "0x4A7A40", Offset = "0x4A6840", Length = "0x6")]
		get;
		[Token(Token = "0x6006666")]
		[Address(RVA = "0x4A7A30", Offset = "0x4A6830", Length = "0x6")]
		private set;
	}

	[Token(Token = "0x170006EA")]
	[field: Token(Token = "0x4008031")]
	[field: FieldOffset(Offset = "0x18")]
	internal float x0
	{
		[Token(Token = "0x6006667")]
		[Address(RVA = "0x4A7A60", Offset = "0x4A6860", Length = "0x6")]
		get;
		[Token(Token = "0x6006668")]
		[Address(RVA = "0x4A7A50", Offset = "0x4A6850", Length = "0x6")]
		private set;
	}

	[Token(Token = "0x170006EB")]
	[field: Token(Token = "0x4008032")]
	[field: FieldOffset(Offset = "0x1C")]
	internal float x1
	{
		[Token(Token = "0x6006669")]
		[Address(RVA = "0x5042D0", Offset = "0x5030D0", Length = "0x6")]
		get;
		[Token(Token = "0x600666A")]
		[Address(RVA = "0x5042E0", Offset = "0x5030E0", Length = "0x6")]
		private set;
	}

	[Token(Token = "0x600666B")]
	[Address(RVA = "0x1027F10", Offset = "0x1026D10", Length = "0x2C1")]
	public HableCurve()
	{
	}

	[Token(Token = "0x600666C")]
	[Address(RVA = "0x10281E0", Offset = "0x1026FE0", Length = "0x93")]
	public float Eval(float x)
	{
		return 0f;
	}

	[Token(Token = "0x600666D")]
	[Address(RVA = "0x1028280", Offset = "0x1027080", Length = "0x232")]
	public void Init(float toeStrength, float toeLength, float shoulderStrength, float shoulderLength, float shoulderAngle, float gamma)
	{
	}

	[Token(Token = "0x600666E")]
	[Address(RVA = "0x10284C0", Offset = "0x10272C0", Length = "0x555")]
	private void InitSegments(DirectParams srcParams)
	{
	}

	[Token(Token = "0x600666F")]
	[Address(RVA = "0x1028A20", Offset = "0x1027820", Length = "0x6E")]
	private void SolveAB(out float lnA, out float B, float x0, float y0, float m)
	{
		lnA = default(float);
		B = default(float);
	}

	[Token(Token = "0x6006670")]
	[Address(RVA = "0x1028A90", Offset = "0x1027890", Length = "0x54")]
	private void AsSlopeIntercept(out float m, out float b, float x0, float x1, float y0, float y1)
	{
		m = default(float);
		b = default(float);
	}

	[Token(Token = "0x6006671")]
	[Address(RVA = "0x1028AF0", Offset = "0x10278F0", Length = "0x48")]
	private float EvalDerivativeLinearGamma(float m, float b, float g, float x)
	{
		return 0f;
	}
}
