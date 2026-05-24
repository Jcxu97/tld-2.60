using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000AEC")]
public static class MaterialModifier
{
	[Token(Token = "0x2000AED")]
	public interface Interface
	{
		[Token(Token = "0x6005CE3")]
		void SetMaterialProp(int nameID, float value);

		[Token(Token = "0x6005CE4")]
		void SetMaterialProp(int nameID, Vector4 value);

		[Token(Token = "0x6005CE5")]
		void SetMaterialProp(int nameID, Color value);

		[Token(Token = "0x6005CE6")]
		void SetMaterialProp(int nameID, Matrix4x4 value);

		[Token(Token = "0x6005CE7")]
		void SetMaterialProp(int nameID, Texture value);
	}

	[Token(Token = "0x2000AEE")]
	public delegate void Callback(Interface owner);
}
