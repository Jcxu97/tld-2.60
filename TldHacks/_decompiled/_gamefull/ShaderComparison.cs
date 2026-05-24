using System;
using Cpp2ILInjected;
using UnityEngine;

[Serializable]
[Token(Token = "0x20002A5")]
public class ShaderComparison
{
	[Token(Token = "0x20002A6")]
	public enum EnabledShader
	{
		[Token(Token = "0x40017B6")]
		ShaderA,
		[Token(Token = "0x40017B7")]
		ShaderB
	}

	[Token(Token = "0x40017B1")]
	[FieldOffset(Offset = "0x10")]
	public string m_Name;

	[SerializeField]
	[Token(Token = "0x40017B2")]
	[FieldOffset(Offset = "0x18")]
	private EnabledShader m_EnabledShader;

	[SerializeField]
	[Token(Token = "0x40017B3")]
	[FieldOffset(Offset = "0x20")]
	private Shader m_ShaderA;

	[SerializeField]
	[Token(Token = "0x40017B4")]
	[FieldOffset(Offset = "0x28")]
	private Shader m_ShaderB;

	[Token(Token = "0x6001692")]
	[Address(RVA = "0x6BC110", Offset = "0x6BAF10", Length = "0x3A")]
	private void SelectShader(EnabledShader shader)
	{
	}

	[Token(Token = "0x6001693")]
	[Address(RVA = "0x6BC150", Offset = "0x6BAF50", Length = "0x753")]
	public void SetShaderForMaterials(Shader shader)
	{
	}

	[Token(Token = "0x6001694")]
	[Address(RVA = "0x6BC8B0", Offset = "0x6BB6B0", Length = "0x47")]
	public void Toggle()
	{
	}

	[Token(Token = "0x6001695")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public ShaderComparison()
	{
	}
}
