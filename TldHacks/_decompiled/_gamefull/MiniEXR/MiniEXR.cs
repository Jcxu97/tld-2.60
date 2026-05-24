using Cpp2ILInjected;
using UnityEngine;

namespace MiniEXR;

[Token(Token = "0x2000D41")]
public static class MiniEXR
{
	[Token(Token = "0x40082C1")]
	private static byte[] kHeader;

	[Token(Token = "0x60067FA")]
	[Address(RVA = "0x105CA50", Offset = "0x105B850", Length = "0x344")]
	public static void MiniEXRWrite(string _filePath, uint _width, uint _height, Color[] _colorArray)
	{
	}

	[Token(Token = "0x60067FB")]
	[Address(RVA = "0x105CDA0", Offset = "0x105BBA0", Length = "0x1E9")]
	public static byte[] MiniEXRWrite(uint _width, uint _height, Color[] _colorArray)
	{
		return null;
	}

	[Token(Token = "0x60067FC")]
	[Address(RVA = "0x105CF90", Offset = "0x105BD90", Length = "0x1A4")]
	public static void MiniEXRWrite_Depth(string _filePath, uint _width, uint _height, Color[] _colorArray, float _farClip)
	{
	}

	[Token(Token = "0x60067FD")]
	[Address(RVA = "0x105D140", Offset = "0x105BF40", Length = "0x1D9")]
	public static byte[] MiniEXRWrite_Depth(uint _width, uint _height, Color[] _colorArray, float farClip)
	{
		return null;
	}

	[Token(Token = "0x60067FE")]
	[Address(RVA = "0x105D320", Offset = "0x105C120", Length = "0x36E")]
	public static byte[] BuildEXRHeader(uint _width, uint _height, out int bufI)
	{
		bufI = default(int);
		return null;
	}

	[Token(Token = "0x60067FF")]
	[Address(RVA = "0x105D690", Offset = "0x105C490", Length = "0x3D1")]
	public static byte[] MiniEXRWrite(uint _width, uint _height, uint _channels, float[] _rgbaArray)
	{
		return null;
	}

	[Token(Token = "0x6006800")]
	[Address(RVA = "0x105DA70", Offset = "0x105C870", Length = "0x2E6")]
	public static byte[] MiniEXRWrite_Depth(uint _width, uint _height, float[] _rArray)
	{
		return null;
	}
}
