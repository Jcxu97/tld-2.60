using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceProviders;
using UnityEngine.SceneManagement;

[Token(Token = "0x20007D2")]
public class SceneManager : ScriptableObject
{
	[Token(Token = "0x20007D3")]
	public struct SceneManagerSaveData
	{
		[Token(Token = "0x400540A")]
		[FieldOffset(Offset = "0x0")]
		public List<string> m_AdditiveLayers;
	}

	[Token(Token = "0x4005407")]
	public static List<string> s_AdditiveLayers;

	[Token(Token = "0x4005408")]
	private static SceneManager s_Instance;

	[Token(Token = "0x4005409")]
	[FieldOffset(Offset = "0x18")]
	private int m_LoadingCount;

	[Token(Token = "0x6004A00")]
	[Address(RVA = "0xD2C360", Offset = "0xD2B160", Length = "0x1BE")]
	private static SceneManager GetInstance()
	{
		return null;
	}

	[Token(Token = "0x6004A01")]
	[Address(RVA = "0xD2C520", Offset = "0xD2B320", Length = "0x8")]
	private void Awake()
	{
	}

	[Token(Token = "0x6004A02")]
	[Address(RVA = "0xD2C530", Offset = "0xD2B330", Length = "0xB6")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6004A03")]
	[Address(RVA = "0xD2C5F0", Offset = "0xD2B3F0", Length = "0x89")]
	public static void LoadEmptyScene()
	{
	}

	[Token(Token = "0x6004A04")]
	[Address(RVA = "0xD2C680", Offset = "0xD2B480", Length = "0xA9")]
	public static void LoadScene(string sceneName, LoadSceneMode mode = LoadSceneMode.Single)
	{
	}

	[Token(Token = "0x6004A05")]
	[Address(RVA = "0xD2C730", Offset = "0xD2B530", Length = "0x162")]
	public static AsyncOperationHandle<SceneInstance> LoadSceneAsync(string sceneName, LoadSceneMode mode = LoadSceneMode.Single, bool activateOnLoad = true)
	{
		return default(AsyncOperationHandle<SceneInstance>);
	}

	[Token(Token = "0x6004A06")]
	[Address(RVA = "0xD2C8A0", Offset = "0xD2B6A0", Length = "0x448")]
	public static void RegisterLoadingScenes(ICollection<AsyncOperationHandle<SceneInstance>> scenes)
	{
	}

	[Token(Token = "0x6004A07")]
	[Address(RVA = "0xD2CCF0", Offset = "0xD2BAF0", Length = "0x57")]
	public static bool IsLoading()
	{
		return false;
	}

	[Token(Token = "0x6004A08")]
	[Address(RVA = "0xD2CD50", Offset = "0xD2BB50", Length = "0xF0")]
	public static void AddLayer(string name)
	{
	}

	[Token(Token = "0x6004A09")]
	[Address(RVA = "0xD2CE50", Offset = "0xD2BC50", Length = "0x95")]
	public static bool ContainsLayer(string name)
	{
		return false;
	}

	[Token(Token = "0x6004A0A")]
	[Address(RVA = "0xD2CEF0", Offset = "0xD2BCF0", Length = "0xF0")]
	public static void RemoveLayer(string name)
	{
	}

	[Token(Token = "0x6004A0B")]
	[Address(RVA = "0xD2CFF0", Offset = "0xD2BDF0", Length = "0x1E7")]
	public static void Deserialize(string serialized)
	{
	}

	[Token(Token = "0x6004A0C")]
	[Address(RVA = "0xD2D1E0", Offset = "0xD2BFE0", Length = "0x1DA")]
	public static string Serialize()
	{
		return null;
	}

	[Token(Token = "0x6004A0D")]
	[Address(RVA = "0xD2D3C0", Offset = "0xD2C1C0", Length = "0x93")]
	public static void ResetLayers()
	{
	}

	[Token(Token = "0x6004A0E")]
	[Address(RVA = "0xD2D460", Offset = "0xD2C260", Length = "0x206")]
	private void OnSceneLoaded(AsyncOperationHandle<SceneInstance> handle)
	{
	}

	[Token(Token = "0x6004A0F")]
	[Address(RVA = "0xD2D670", Offset = "0xD2C470", Length = "0x19")]
	private static string SanitizeLayerName(string name)
	{
		return null;
	}

	[Token(Token = "0x6004A10")]
	[Address(RVA = "0x4A22A0", Offset = "0x4A10A0", Length = "0x7")]
	public SceneManager()
	{
	}
}
