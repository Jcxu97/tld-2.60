using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20009F1")]
public class BatchLightingCapture : MonoBehaviour
{
	[Token(Token = "0x20009F2")]
	public enum UpdatePhase
	{
		[Token(Token = "0x400652E")]
		Constant,
		[Token(Token = "0x400652F")]
		Coloured,
		[Token(Token = "0x4006530")]
		Night,
		[Token(Token = "0x4006531")]
		Midday,
		[Token(Token = "0x4006532")]
		NonTOD,
		[Token(Token = "0x4006533")]
		Other
	}

	[Token(Token = "0x400652A")]
	private static Queue<string> m_SceneSetQueue;

	[Token(Token = "0x400652B")]
	private static readonly string m_LightSceneSuffix;

	[Token(Token = "0x400652C")]
	private static readonly string m_SandboxSceneSuffix;

	[Token(Token = "0x6005794")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public static void CaptureLighting(string sceneName)
	{
	}

	[Token(Token = "0x6005795")]
	[Address(RVA = "0xED63A0", Offset = "0xED51A0", Length = "0x64")]
	private static string GetLightSceneName(string scenePath)
	{
		return null;
	}

	[Token(Token = "0x6005796")]
	[Address(RVA = "0xED6410", Offset = "0xED5210", Length = "0x64")]
	private static string GetSandboxSceneName(string scenePath)
	{
		return null;
	}

	[Token(Token = "0x6005797")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public BatchLightingCapture()
	{
	}
}
