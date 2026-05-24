using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20007DB")]
public class SkillsManager : MonoBehaviour
{
	[Token(Token = "0x20007DC")]
	public enum PointAssignmentMode
	{
		[Token(Token = "0x400544C")]
		AssignOnlyInSandbox,
		[Token(Token = "0x400544D")]
		AssignInAnyMode
	}

	[Token(Token = "0x4005436")]
	[FieldOffset(Offset = "0x20")]
	public LocalizedString[] m_TierNames;

	[Token(Token = "0x4005437")]
	[FieldOffset(Offset = "0x28")]
	public GameObject m_Skill_Firestarting_Prefab;

	[Token(Token = "0x4005438")]
	[FieldOffset(Offset = "0x30")]
	public GameObject m_Skill_CarcassHarvesting_Prefab;

	[Token(Token = "0x4005439")]
	[FieldOffset(Offset = "0x38")]
	public GameObject m_Skill_Cooking_Prefab;

	[Token(Token = "0x400543A")]
	[FieldOffset(Offset = "0x40")]
	public GameObject m_Skill_IceFishing_Prefab;

	[Token(Token = "0x400543B")]
	[FieldOffset(Offset = "0x48")]
	public GameObject m_Skill_Rifle_Prefab;

	[Token(Token = "0x400543C")]
	[FieldOffset(Offset = "0x50")]
	public GameObject m_Skill_Archery_Prefab;

	[Token(Token = "0x400543D")]
	[FieldOffset(Offset = "0x58")]
	public GameObject m_Skill_ClothingRepair_Prefab;

	[Token(Token = "0x400543E")]
	[FieldOffset(Offset = "0x60")]
	public GameObject m_Skill_Revolver_Prefab;

	[Token(Token = "0x400543F")]
	[FieldOffset(Offset = "0x68")]
	public GameObject m_Skill_Gunsmithing_Prefab;

	[HideInInspector]
	[Token(Token = "0x4005440")]
	[FieldOffset(Offset = "0x70")]
	public Skill_Firestarting m_Skill_Firestarting;

	[HideInInspector]
	[Token(Token = "0x4005441")]
	[FieldOffset(Offset = "0x78")]
	public Skill_CarcassHarvesting m_Skill_CarcassHarvesting;

	[HideInInspector]
	[Token(Token = "0x4005442")]
	[FieldOffset(Offset = "0x80")]
	public Skill_Cooking m_Skill_Cooking;

	[HideInInspector]
	[Token(Token = "0x4005443")]
	[FieldOffset(Offset = "0x88")]
	public Skill_IceFishing m_Skill_IceFishing;

	[HideInInspector]
	[Token(Token = "0x4005444")]
	[FieldOffset(Offset = "0x90")]
	public Skill_Rifle m_Skill_Rifle;

	[HideInInspector]
	[Token(Token = "0x4005445")]
	[FieldOffset(Offset = "0x98")]
	public Skill_Archery m_Skill_Archery;

	[HideInInspector]
	[Token(Token = "0x4005446")]
	[FieldOffset(Offset = "0xA0")]
	public Skill_ClothingRepair m_Skill_ClothingRepair;

	[HideInInspector]
	[Token(Token = "0x4005447")]
	[FieldOffset(Offset = "0xA8")]
	public Skill_Revolver m_Skill_Revolver;

	[HideInInspector]
	[Token(Token = "0x4005448")]
	[FieldOffset(Offset = "0xB0")]
	public Skill_Gunsmithing m_Skill_Gunsmithing;

	[Token(Token = "0x4005449")]
	[FieldOffset(Offset = "0xB8")]
	private List<Skill> m_Skills;

	[Token(Token = "0x400544A")]
	private static SkillsManagerSaveData m_SkillsManagerSaveData;

	[Token(Token = "0x6004A2B")]
	[Address(RVA = "0xD2FF10", Offset = "0xD2ED10", Length = "0x4DE")]
	private void Awake()
	{
	}

	[Token(Token = "0x6004A2C")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	private void Start()
	{
	}

	[Token(Token = "0x6004A2D")]
	[Address(RVA = "0xD303F0", Offset = "0xD2F1F0", Length = "0xCAF")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x6004A2E")]
	[Address(RVA = "0xD310A0", Offset = "0xD2FEA0", Length = "0x86B")]
	public void Deserialize(string text)
	{
	}

	[Token(Token = "0x6004A2F")]
	[Address(RVA = "0xD31910", Offset = "0xD30710", Length = "0x64")]
	public Skill GetSkill(SkillType skillType)
	{
		return null;
	}

	[Token(Token = "0x6004A30")]
	[Address(RVA = "0xD319A0", Offset = "0xD307A0", Length = "0x97")]
	public Skill GetSkillFromIndex(int index)
	{
		return null;
	}

	[Token(Token = "0x6004A31")]
	[Address(RVA = "0xD31A40", Offset = "0xD30840", Length = "0x44")]
	public int GetNumSkills()
	{
		return 0;
	}

	[Token(Token = "0x6004A32")]
	[Address(RVA = "0xD31A90", Offset = "0xD30890", Length = "0x88")]
	public string GetTierName(int index)
	{
		return null;
	}

	[Token(Token = "0x6004A33")]
	[Address(RVA = "0xD31B20", Offset = "0xD30920", Length = "0x1BC")]
	public bool AllSkillsAtMaxmiumLevel()
	{
		return false;
	}

	[Token(Token = "0x6004A34")]
	[Address(RVA = "0xD31CE0", Offset = "0xD30AE0", Length = "0x295")]
	public void IncrementPointsAndNotify(SkillType skillType, int numPoints, PointAssignmentMode mode)
	{
	}

	[Token(Token = "0x6004A35")]
	[Address(RVA = "0xD31F80", Offset = "0xD30D80", Length = "0x251")]
	private GameObject InstantiateSkillPrefab(GameObject prefab)
	{
		return null;
	}

	[Token(Token = "0x6004A36")]
	[Address(RVA = "0xD321E0", Offset = "0xD30FE0", Length = "0x16F")]
	public SkillsManager()
	{
	}
}
