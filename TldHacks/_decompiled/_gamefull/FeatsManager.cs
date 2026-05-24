using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.SaveState;
using UnityEngine;

[Token(Token = "0x2000739")]
public class FeatsManager : MonoBehaviour
{
	[Token(Token = "0x4004C7D")]
	[FieldOffset(Offset = "0x20")]
	public GameObject m_Feat_BookSmarts_Prefab;

	[Token(Token = "0x4004C7E")]
	[FieldOffset(Offset = "0x28")]
	public GameObject m_Feat_ColdFusion_Prefab;

	[Token(Token = "0x4004C7F")]
	[FieldOffset(Offset = "0x30")]
	public GameObject m_Feat_EfficientMachine_Prefab;

	[Token(Token = "0x4004C80")]
	[FieldOffset(Offset = "0x38")]
	public GameObject m_Feat_FireMaster_Prefab;

	[Token(Token = "0x4004C81")]
	[FieldOffset(Offset = "0x40")]
	public GameObject m_Feat_FreeRunner_Prefab;

	[Token(Token = "0x4004C82")]
	[FieldOffset(Offset = "0x48")]
	public GameObject m_Feat_SnowWalker_Prefab;

	[Token(Token = "0x4004C83")]
	[FieldOffset(Offset = "0x50")]
	public GameObject m_Feat_ExpertTrapper_Prefab;

	[Token(Token = "0x4004C84")]
	[FieldOffset(Offset = "0x58")]
	public GameObject m_Feat_StraightToHeart_Prefab;

	[Token(Token = "0x4004C85")]
	[FieldOffset(Offset = "0x60")]
	public GameObject m_Feat_BlizzardWalker_Prefab;

	[Token(Token = "0x4004C86")]
	[FieldOffset(Offset = "0x68")]
	public GameObject m_Feat_NightWalker_Prefab;

	[Token(Token = "0x4004C87")]
	[FieldOffset(Offset = "0x70")]
	public GameObject m_Feat_MasterHunter_Prefab;

	[Token(Token = "0x4004C88")]
	[FieldOffset(Offset = "0x78")]
	public GameObject m_Feat_SettledMind_Prefab;

	[Token(Token = "0x4004C89")]
	[FieldOffset(Offset = "0x80")]
	public GameObject m_Feat_CelestialNavigator_Prefab;

	[Token(Token = "0x4004C8A")]
	public static Feat_BookSmarts m_Feat_BookSmarts;

	[Token(Token = "0x4004C8B")]
	public static Feat_ColdFusion m_Feat_ColdFusion;

	[Token(Token = "0x4004C8C")]
	public static Feat_EfficientMachine m_Feat_EfficientMachine;

	[Token(Token = "0x4004C8D")]
	public static Feat_FireMaster m_Feat_FireMaster;

	[Token(Token = "0x4004C8E")]
	public static Feat_FreeRunner m_Feat_FreeRunner;

	[Token(Token = "0x4004C8F")]
	public static Feat_SnowWalker m_Feat_SnowWalker;

	[Token(Token = "0x4004C90")]
	public static Feat_ExpertTrapper m_Feat_ExpertTrapper;

	[Token(Token = "0x4004C91")]
	public static Feat_StraightToHeart m_Feat_StraightToHeart;

	[Token(Token = "0x4004C92")]
	public static Feat_BlizzardWalker m_Feat_BlizzardWalker;

	[Token(Token = "0x4004C93")]
	public static Feat_NightWalker m_Feat_NightWalker;

	[Token(Token = "0x4004C94")]
	public static Feat_MasterHunter m_Feat_MasterHunter;

	[Token(Token = "0x4004C95")]
	public static Feat_SettledMind m_Feat_SettledMind;

	[Token(Token = "0x4004C96")]
	public static Feat_CelestialNavigator m_Feat_CelestialNavigator;

	[Token(Token = "0x4004C97")]
	private static bool m_InsantiatedFeats;

	[Token(Token = "0x4004C98")]
	private static List<Feat> m_Feats;

	[Token(Token = "0x4004C99")]
	private static FeatsManagerSaveData m_FeatsManagerSaveData;

	[Token(Token = "0x600415F")]
	[Address(RVA = "0xC1F150", Offset = "0xC1DF50", Length = "0x9B6")]
	private void Awake()
	{
	}

	[Token(Token = "0x6004160")]
	[Address(RVA = "0xC1FB10", Offset = "0xC1E910", Length = "0x6C")]
	private void HandleSerialization(ProfileState profileState)
	{
	}

	[Token(Token = "0x6004161")]
	[Address(RVA = "0xC1FB80", Offset = "0xC1E980", Length = "0x1E")]
	private void HandleDeserialization(ProfileState profileState)
	{
	}

	[Token(Token = "0x6004162")]
	[Address(RVA = "0xC1FBA0", Offset = "0xC1E9A0", Length = "0x1046")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x6004163")]
	[Address(RVA = "0xC20BF0", Offset = "0xC1F9F0", Length = "0x9B5")]
	public void Deserialize(string text)
	{
	}

	[Token(Token = "0x6004164")]
	[Address(RVA = "0xC215B0", Offset = "0xC203B0", Length = "0x2C0")]
	public Feat GetFeat(FeatType featType)
	{
		return null;
	}

	[Token(Token = "0x6004165")]
	[Address(RVA = "0xC218B0", Offset = "0xC206B0", Length = "0xDF")]
	public Feat GetFeatFromIndex(int index)
	{
		return null;
	}

	[Token(Token = "0x6004166")]
	[Address(RVA = "0xC21990", Offset = "0xC20790", Length = "0x72")]
	public int GetNumFeats()
	{
		return 0;
	}

	[Token(Token = "0x6004167")]
	[Address(RVA = "0xC21A10", Offset = "0xC20810", Length = "0xAF4")]
	public void ValidateSaveData(string serialized)
	{
	}

	[Token(Token = "0x6004168")]
	[Address(RVA = "0xC22510", Offset = "0xC21310", Length = "0x28D")]
	private GameObject InstantiateFeatPrefab(GameObject prefab)
	{
		return null;
	}

	[Token(Token = "0x6004169")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public FeatsManager()
	{
	}
}
