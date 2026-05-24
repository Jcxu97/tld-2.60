using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000A38")]
public class ImageWriteRequest
{
	[Token(Token = "0x2000A39")]
	public enum Type
	{
		[Token(Token = "0x4006698")]
		PNG,
		[Token(Token = "0x4006699")]
		EXR,
		[Token(Token = "0x400669A")]
		EXR_Depth
	}

	[Token(Token = "0x4006690")]
	[FieldOffset(Offset = "0x10")]
	internal string filename;

	[Token(Token = "0x4006691")]
	[FieldOffset(Offset = "0x18")]
	internal Color[] imageColors;

	[Token(Token = "0x4006692")]
	[FieldOffset(Offset = "0x20")]
	internal byte[] imageBytes;

	[Token(Token = "0x4006693")]
	[FieldOffset(Offset = "0x28")]
	internal uint width;

	[Token(Token = "0x4006694")]
	[FieldOffset(Offset = "0x2C")]
	internal uint height;

	[Token(Token = "0x4006695")]
	[FieldOffset(Offset = "0x30")]
	internal Type type;

	[Token(Token = "0x4006696")]
	[FieldOffset(Offset = "0x34")]
	internal float farClip;

	[Token(Token = "0x6005923")]
	[Address(RVA = "0xEF0F00", Offset = "0xEEFD00", Length = "0xE6")]
	internal ImageWriteRequest(string _filename, Color[] _image, uint _width, uint _height, Type _type, float _farClip)
	{
	}

	[Token(Token = "0x6005924")]
	[Address(RVA = "0xEF0FF0", Offset = "0xEEFDF0", Length = "0xD8")]
	internal ImageWriteRequest(string _filename, Color[] _image, uint _width, uint _height, Type _type)
	{
	}

	[Token(Token = "0x6005925")]
	[Address(RVA = "0xEF10D0", Offset = "0xEEFED0", Length = "0xD8")]
	internal ImageWriteRequest(string _filename, byte[] _image, uint _width, uint _height, Type _type)
	{
	}
}
