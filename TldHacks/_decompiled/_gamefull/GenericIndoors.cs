using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000937")]
public class GenericIndoors : MonoBehaviour
{
	[Token(Token = "0x4006014")]
	[FieldOffset(Offset = "0x20")]
	public Texture2D m_ColourGradingLUT;

	[Token(Token = "0x4006015")]
	[FieldOffset(Offset = "0x28")]
	public ColorGradingSettings m_ColourGradingSettings;

	[Token(Token = "0x4006016")]
	public static List<GenericIndoors> m_GenericIndoorsList;

	[Token(Token = "0x60053CD")]
	[Address(RVA = "0xE76DB0", Offset = "0xE75BB0", Length = "0x2F7")]
	private void Start()
	{
	}

	[Token(Token = "0x60053CE")]
	[Address(RVA = "0xE770B0", Offset = "0xE75EB0", Length = "0x93")]
	public static void Reset()
	{
	}

	[Token(Token = "0x60053CF")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public GenericIndoors()
	{
	}
}
