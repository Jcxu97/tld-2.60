using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[CreateAssetMenu(order = 10001)]
[Token(Token = "0x20007D8")]
public class SceneNameMapping : ScriptableObject
{
	[Serializable]
	[Token(Token = "0x20007D9")]
	public class SceneNameMapEntry
	{
		[Token(Token = "0x400542A")]
		[FieldOffset(Offset = "0x10")]
		public string m_SceneName;

		[Token(Token = "0x400542B")]
		[FieldOffset(Offset = "0x18")]
		public string m_LocId;

		[Token(Token = "0x400542C")]
		[FieldOffset(Offset = "0x20")]
		public string m_Region;

		[Token(Token = "0x6004A29")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public SceneNameMapEntry()
		{
		}
	}

	[SerializeField]
	[Token(Token = "0x4005427")]
	[FieldOffset(Offset = "0x18")]
	private List<SceneNameMapEntry> m_Scenes;

	[Token(Token = "0x4005428")]
	[FieldOffset(Offset = "0x20")]
	private Dictionary<string, string> m_SceneNameMapping;

	[Token(Token = "0x4005429")]
	[FieldOffset(Offset = "0x28")]
	private Dictionary<string, string> m_SceneRegionMapping;

	[Token(Token = "0x6004A20")]
	[Address(RVA = "0xD2EA10", Offset = "0xD2D810", Length = "0x1F7")]
	public void OnEnable()
	{
	}

	[Token(Token = "0x6004A21")]
	[Address(RVA = "0x4582A0", Offset = "0x4570A0", Length = "0x3")]
	public static string FindLocalizedSceneNamesPath()
	{
		return null;
	}

	[Token(Token = "0x6004A22")]
	[Address(RVA = "0x4582A0", Offset = "0x4570A0", Length = "0x3")]
	public static SceneNameMapping GetRefOrLoad(string sceneNamesFilePath = null)
	{
		return null;
	}

	[Token(Token = "0x6004A23")]
	[Address(RVA = "0xD2EC10", Offset = "0xD2DA10", Length = "0x25C")]
	public string GetLocIDForScene(string sceneName)
	{
		return null;
	}

	[Token(Token = "0x6004A24")]
	[Address(RVA = "0xD2EE70", Offset = "0xD2DC70", Length = "0x115")]
	public string GetRegionForScene(string sceneName)
	{
		return null;
	}

	[Token(Token = "0x6004A25")]
	[Address(RVA = "0xD2EF90", Offset = "0xD2DD90", Length = "0x282")]
	private void AddEntry(string sceneName)
	{
	}

	[Token(Token = "0x6004A26")]
	[Address(RVA = "0xD2F220", Offset = "0xD2E020", Length = "0x4A6")]
	public void AddEntry(string sceneName, string locId, string region)
	{
	}

	[Token(Token = "0x6004A27")]
	[Address(RVA = "0xD2F6D0", Offset = "0xD2E4D0", Length = "0x653")]
	public static bool IsChildOfAnother(string sceneName)
	{
		return false;
	}

	[Token(Token = "0x6004A28")]
	[Address(RVA = "0xD2FD30", Offset = "0xD2EB30", Length = "0x1D2")]
	public SceneNameMapping()
	{
	}
}
