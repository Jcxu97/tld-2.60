using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20007D0")]
public class RockCacheManager : MonoBehaviour
{
	[Header("Build")]
	[Token(Token = "0x40053CA")]
	[FieldOffset(Offset = "0x20")]
	public RockCache m_RockCachePrefab;

	[Token(Token = "0x40053CB")]
	[FieldOffset(Offset = "0x28")]
	public float m_BuildRangeMin;

	[Token(Token = "0x40053CC")]
	[FieldOffset(Offset = "0x2C")]
	public float m_BuildRangeMax;

	[Token(Token = "0x40053CD")]
	[FieldOffset(Offset = "0x30")]
	public int m_MaxRockCachesPerRegion;

	[Token(Token = "0x40053CE")]
	[FieldOffset(Offset = "0x34")]
	public float m_MinDistanceBetweenRockCaches;

	[Header("Misc")]
	[Token(Token = "0x40053CF")]
	[FieldOffset(Offset = "0x38")]
	public float m_FOV;

	[Token(Token = "0x40053D0")]
	[FieldOffset(Offset = "0x3C")]
	public Vector2 m_PitchLimitDegrees;

	[Token(Token = "0x40053D1")]
	[FieldOffset(Offset = "0x44")]
	public Vector2 m_YawLimitDegrees;

	[Token(Token = "0x40053D2")]
	[FieldOffset(Offset = "0x4C")]
	public float m_FadeOutSeconds;

	[Token(Token = "0x40053D3")]
	[FieldOffset(Offset = "0x50")]
	public float m_FadeInSeconds;

	[Header("Audio")]
	[Token(Token = "0x40053D4")]
	[FieldOffset(Offset = "0x58")]
	public string m_BuildAudio;

	[Token(Token = "0x40053D5")]
	[FieldOffset(Offset = "0x60")]
	public string m_DismantleAudio;

	[Token(Token = "0x40053D6")]
	public static bool s_Locked;

	[Token(Token = "0x40053D7")]
	public static bool s_RockCachesUnlockedInStory;

	[Token(Token = "0x40053D8")]
	[FieldOffset(Offset = "0x68")]
	private float m_StartCameraFOV;

	[Token(Token = "0x40053D9")]
	[FieldOffset(Offset = "0x6C")]
	private Vector2 m_StartPitchLimit;

	[Token(Token = "0x40053DA")]
	[FieldOffset(Offset = "0x74")]
	private Vector2 m_StartYawLimit;

	[Token(Token = "0x40053DB")]
	public static Dictionary<string, RockCacheInfo> s_RockCacheInfoByGuid;

	[Token(Token = "0x40053DC")]
	private static List<RockCache> s_RockCacheList;

	[Token(Token = "0x40053DD")]
	private static Dictionary<string, List<string>> s_DestroyedRockCacheInScene;

	[Token(Token = "0x40053DE")]
	public static bool s_IsDeserializing;

	[Token(Token = "0x40053DF")]
	private static int s_RockCacheIndex;

	[Token(Token = "0x60049B0")]
	[Address(RVA = "0xD233C0", Offset = "0xD221C0", Length = "0x135")]
	private void Start()
	{
	}

	[Token(Token = "0x60049B1")]
	[Address(RVA = "0xD23500", Offset = "0xD22300", Length = "0xDD")]
	public string GenerateRockCacheName()
	{
		return null;
	}

	[Token(Token = "0x60049B2")]
	[Address(RVA = "0xD235E0", Offset = "0xD223E0", Length = "0x3AE")]
	private static void AddRockCacheInfo(RockCache rc)
	{
	}

	[Token(Token = "0x60049B3")]
	[Address(RVA = "0xD23990", Offset = "0xD22790", Length = "0x12C")]
	public static void Add(RockCache rc)
	{
	}

	[Token(Token = "0x60049B4")]
	[Address(RVA = "0xD23AC0", Offset = "0xD228C0", Length = "0x119")]
	private static void RemoveRockCacheInfo(RockCache rc)
	{
	}

	[Token(Token = "0x60049B5")]
	[Address(RVA = "0xD23BE0", Offset = "0xD229E0", Length = "0x1EF")]
	public static void Remove(RockCache rc)
	{
	}

	[Token(Token = "0x60049B6")]
	[Address(RVA = "0xD23DD0", Offset = "0xD22BD0", Length = "0x1DE")]
	public static void TrackDestroyedRockCacheInScene(string sceneName, string guid)
	{
	}

	[Token(Token = "0x60049B7")]
	[Address(RVA = "0xD23FB0", Offset = "0xD22DB0", Length = "0xD2")]
	public static bool WasDestroyed(string sceneName, string guid)
	{
		return false;
	}

	[Token(Token = "0x60049B8")]
	[Address(RVA = "0xD24090", Offset = "0xD22E90", Length = "0xC2")]
	public static string GetRockCacheNameFromGuid(string guid)
	{
		return null;
	}

	[Token(Token = "0x60049B9")]
	[Address(RVA = "0xD24160", Offset = "0xD22F60", Length = "0xBB")]
	public static string GetRockCacheSceneNameFromGuid(string guid)
	{
		return null;
	}

	[Token(Token = "0x60049BA")]
	[Address(RVA = "0xD24220", Offset = "0xD23020", Length = "0x81")]
	public static string GetRockCacheUserText(RockCache rc)
	{
		return null;
	}

	[Token(Token = "0x60049BB")]
	[Address(RVA = "0xD242B0", Offset = "0xD230B0", Length = "0xBB")]
	public static string GetRockCacheUserTextFromGuid(string guid)
	{
		return null;
	}

	[Token(Token = "0x60049BC")]
	[Address(RVA = "0xD24370", Offset = "0xD23170", Length = "0x10D")]
	public static Vector3 GetRockCacheLocationFromGuid(string guid)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60049BD")]
	[Address(RVA = "0xD24480", Offset = "0xD23280", Length = "0x81")]
	public static string GetRockCacheName(RockCache rc)
	{
		return null;
	}

	[Token(Token = "0x60049BE")]
	[Address(RVA = "0xD24510", Offset = "0xD23310", Length = "0x101")]
	public static void SetRockCacheRegionName(RockCache rc, string sceneName, string regionName)
	{
	}

	[Token(Token = "0x60049BF")]
	[Address(RVA = "0xD24620", Offset = "0xD23420", Length = "0x6F")]
	public static void UpdateRockCacheName(RockCache rc, string name)
	{
	}

	[Token(Token = "0x60049C0")]
	[Address(RVA = "0xD24690", Offset = "0xD23490", Length = "0x344")]
	public static void UpdateRockCacheName(string rockCacheGuid, string name)
	{
	}

	[Token(Token = "0x60049C1")]
	[Address(RVA = "0xD249E0", Offset = "0xD237E0", Length = "0x6F")]
	public static void UpdateRockCacheUserText(RockCache rc, string userText)
	{
	}

	[Token(Token = "0x60049C2")]
	[Address(RVA = "0xD24A50", Offset = "0xD23850", Length = "0xF1")]
	public static void UpdateRockCacheUserText(string rockCacheGuid, string userText)
	{
	}

	[Token(Token = "0x60049C3")]
	[Address(RVA = "0xD24B50", Offset = "0xD23950", Length = "0x868")]
	public static string SerializeGlobal()
	{
		return null;
	}

	[Token(Token = "0x60049C4")]
	[Address(RVA = "0xD253C0", Offset = "0xD241C0", Length = "0x697")]
	public static void DeserializeGlobal(string serialized)
	{
	}

	[Token(Token = "0x60049C5")]
	[Address(RVA = "0xD25A60", Offset = "0xD24860", Length = "0x94")]
	public static void Reset()
	{
	}

	[Token(Token = "0x60049C6")]
	[Address(RVA = "0xD25B00", Offset = "0xD24900", Length = "0x427")]
	public static string SerializeAll()
	{
		return null;
	}

	[Token(Token = "0x60049C7")]
	[Address(RVA = "0xD25F30", Offset = "0xD24D30", Length = "0x76A")]
	public static void DeserializeAll(string text)
	{
	}

	[Token(Token = "0x60049C8")]
	[Address(RVA = "0xD266A0", Offset = "0xD254A0", Length = "0x2ED")]
	public static void RegisterAnyRockCacheGuid()
	{
	}

	[Token(Token = "0x60049C9")]
	[Address(RVA = "0xD26990", Offset = "0xD25790", Length = "0x54")]
	public void RockCachesUnlockInStory()
	{
	}

	[Token(Token = "0x60049CA")]
	[Address(RVA = "0xD269F0", Offset = "0xD257F0", Length = "0x84")]
	public bool RockCachesAreUnlocked()
	{
		return false;
	}

	[Token(Token = "0x60049CB")]
	[Address(RVA = "0xD26A80", Offset = "0xD25880", Length = "0x313")]
	public int GetNumSticksInInventory()
	{
		return 0;
	}

	[Token(Token = "0x60049CC")]
	[Address(RVA = "0xD26DA0", Offset = "0xD25BA0", Length = "0x313")]
	public int GetNumRocksInInventory()
	{
		return 0;
	}

	[Token(Token = "0x60049CD")]
	[Address(RVA = "0xD270C0", Offset = "0xD25EC0", Length = "0x12F")]
	public string GetMissingMaterialsString()
	{
		return null;
	}

	[Token(Token = "0x60049CE")]
	[Address(RVA = "0xD271F0", Offset = "0xD25FF0", Length = "0x32E")]
	public bool CanPlaceRockCache(RockCache newRockCache)
	{
		return false;
	}

	[Token(Token = "0x60049CF")]
	[Address(RVA = "0x677F80", Offset = "0x676D80", Length = "0x4")]
	public int GetRockCachesPerRegion()
	{
		return 0;
	}

	[Token(Token = "0x60049D0")]
	[Address(RVA = "0xD27520", Offset = "0xD26320", Length = "0x255")]
	public bool HasReachedMaxRockCacheCount()
	{
		return false;
	}

	[Token(Token = "0x60049D1")]
	[Address(RVA = "0xD27780", Offset = "0xD26580", Length = "0x132")]
	public bool CanAttemptToPlaceRockCache()
	{
		return false;
	}

	[Token(Token = "0x60049D2")]
	[Address(RVA = "0xD278C0", Offset = "0xD266C0", Length = "0x51")]
	public RockCacheManager()
	{
	}
}
