using System;
using Cpp2ILInjected;
using UnityEngine;

namespace TLD.Scenes;

[Serializable]
[Token(Token = "0x2001368")]
public struct WorldToMap
{
	[Token(Token = "0x4008ECB")]
	[FieldOffset(Offset = "0x0")]
	public Vector3 m_CenterOfScene;

	[Token(Token = "0x4008ECC")]
	[FieldOffset(Offset = "0xC")]
	public Vector3 m_RadiusOfScene;

	[Token(Token = "0x4008ECD")]
	[FieldOffset(Offset = "0x18")]
	public float m_Angle;
}
