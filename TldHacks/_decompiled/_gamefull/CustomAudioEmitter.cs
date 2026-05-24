using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20001B8")]
public class CustomAudioEmitter : MonoBehaviour
{
	[Token(Token = "0x4000F34")]
	[FieldOffset(Offset = "0x20")]
	public CustomEmitterType m_CustomEmitterType;

	[Token(Token = "0x4000F35")]
	[FieldOffset(Offset = "0x28")]
	public string m_SoundName;

	[Token(Token = "0x4000F36")]
	[FieldOffset(Offset = "0x30")]
	private uint m_AudioInstance;

	[Token(Token = "0x4000F37")]
	private static Dictionary<CustomEmitterType, List<CustomAudioEmitter>> s_CustomAudioEmitter;

	[Token(Token = "0x6001000")]
	[Address(RVA = "0x61DBB0", Offset = "0x61C9B0", Length = "0x1CB")]
	public void Start()
	{
	}

	[Token(Token = "0x6001001")]
	[Address(RVA = "0x61DD80", Offset = "0x61CB80", Length = "0x284")]
	public static void Enable(CustomEmitterType type, bool enable)
	{
	}

	[Token(Token = "0x6001002")]
	[Address(RVA = "0x61E010", Offset = "0x61CE10", Length = "0xBF")]
	public void OnDestroy()
	{
	}

	[Token(Token = "0x6001003")]
	[Address(RVA = "0x61E0D0", Offset = "0x61CED0", Length = "0xC2")]
	public CustomAudioEmitter()
	{
	}
}
