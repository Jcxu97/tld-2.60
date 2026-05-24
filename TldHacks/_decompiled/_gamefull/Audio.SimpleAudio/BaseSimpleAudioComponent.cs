using Cpp2ILInjected;
using UnityEngine;

namespace Audio.SimpleAudio;

[Token(Token = "0x2001332")]
public class BaseSimpleAudioComponent : MonoBehaviour
{
	[HideInInspector]
	[Token(Token = "0x4008DB7")]
	[FieldOffset(Offset = "0x20")]
	public bool m_IsGameObjectStatic;

	[Token(Token = "0x6007B17")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public virtual void OnValidate()
	{
	}

	[Token(Token = "0x6007B18")]
	[Address(RVA = "0x4D3E60", Offset = "0x4D2C60", Length = "0x5")]
	public bool IsStatic()
	{
		return false;
	}

	[Token(Token = "0x6007B19")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public BaseSimpleAudioComponent()
	{
	}
}
