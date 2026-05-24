using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.Logging;
using UnityEngine.AddressableAssets.ResourceLocators;

namespace TLD.Scenes;

[Token(Token = "0x2001364")]
public static class SceneSetManager
{
	[Token(Token = "0x4008EB6")]
	public static LogFilter s_LogFilter;

	[Token(Token = "0x4008EB7")]
	private static bool m_IsInitialized;

	[Token(Token = "0x4008EB8")]
	private static List<SceneSet> m_ExtendedSceneSets;

	[Token(Token = "0x6007BD0")]
	[Address(RVA = "0x11AB1E0", Offset = "0x11A9FE0", Length = "0x293")]
	public static void InitializeSceneSetManager()
	{
	}

	[Token(Token = "0x6007BD1")]
	[Address(RVA = "0x11AB480", Offset = "0x11AA280", Length = "0x51")]
	public static SceneSet FindSceneSetForSceneName(string name)
	{
		return null;
	}

	[Token(Token = "0x6007BD2")]
	[Address(RVA = "0x11AB4E0", Offset = "0x11AA2E0", Length = "0xC7")]
	public static SceneSet FindSceneSetForSceneName(string name, bool warnIfNotAvailable)
	{
		return null;
	}

	[Token(Token = "0x6007BD3")]
	[Address(RVA = "0x11AB5B0", Offset = "0x11AA3B0", Length = "0x22A")]
	private static void HandleOnOptionalContentLoaded(IResourceLocator optionalContentLocator)
	{
	}

	[Token(Token = "0x6007BD4")]
	[Address(RVA = "0x11AB7E0", Offset = "0x11AA5E0", Length = "0x26E")]
	private static void HandleSceneExtensionLoaded(SceneSetExtension sceneSetExtension)
	{
	}
}
