using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20000D1")]
public class UIGeometry
{
	[Token(Token = "0x400069F")]
	[FieldOffset(Offset = "0x10")]
	public BetterList<Vector3> verts;

	[Token(Token = "0x40006A0")]
	[FieldOffset(Offset = "0x18")]
	public BetterList<Vector2> uvs;

	[Token(Token = "0x40006A1")]
	[FieldOffset(Offset = "0x20")]
	public BetterList<Color32> cols;

	[Token(Token = "0x40006A2")]
	[FieldOffset(Offset = "0x28")]
	private BetterList<Vector3> mRtpVerts;

	[Token(Token = "0x40006A3")]
	[FieldOffset(Offset = "0x30")]
	private Vector3 mRtpNormal;

	[Token(Token = "0x40006A4")]
	[FieldOffset(Offset = "0x3C")]
	private Vector4 mRtpTan;

	[Token(Token = "0x170000AA")]
	public bool hasVertices
	{
		[Token(Token = "0x6000769")]
		[Address(RVA = "0xFA1F70", Offset = "0xFA0D70", Length = "0x1E")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x170000AB")]
	public bool hasTransformed
	{
		[Token(Token = "0x600076A")]
		[Address(RVA = "0xFA1F90", Offset = "0xFA0D90", Length = "0x36")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x600076B")]
	[Address(RVA = "0xFA1FD0", Offset = "0xFA0DD0", Length = "0x89")]
	public void Clear()
	{
	}

	[Token(Token = "0x600076C")]
	[Address(RVA = "0xFA2060", Offset = "0xFA0E60", Length = "0x529")]
	public void ApplyTransform(Matrix4x4 widgetToPanel)
	{
	}

	[Token(Token = "0x600076D")]
	[Address(RVA = "0xFA2590", Offset = "0xFA1390", Length = "0x5A8")]
	public void WriteToBuffers(BetterList<Vector3> v, BetterList<Vector2> u, BetterList<Color32> c, BetterList<Vector3> n, BetterList<Vector4> t)
	{
	}

	[Token(Token = "0x600076E")]
	[Address(RVA = "0xFA2B40", Offset = "0xFA1940", Length = "0x219")]
	public UIGeometry()
	{
	}
}
