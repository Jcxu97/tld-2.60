using System;
using Cpp2ILInjected;
using UnityEngine;

namespace TLD.Scenes;

[Serializable]
[Token(Token = "0x2001360")]
public class SceneResolutionOverride
{
	[Token(Token = "0x4008EA3")]
	[FieldOffset(Offset = "0x10")]
	public RuntimePlatform m_Platform;

	[Token(Token = "0x4008EA4")]
	[FieldOffset(Offset = "0x14")]
	public int m_MaxResolution;

	[Token(Token = "0x6007BB8")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public SceneResolutionOverride()
	{
	}
}
