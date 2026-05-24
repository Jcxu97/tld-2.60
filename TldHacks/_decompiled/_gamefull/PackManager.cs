using System.Collections.Generic;
using System.Diagnostics;
using Cpp2ILInjected;
using TLD.AI;
using UnityEngine;

[Token(Token = "0x2000181")]
public class PackManager : MonoBehaviour
{
	[Token(Token = "0x4000DD4")]
	[FieldOffset(Offset = "0x20")]
	public PackSettings m_DefaultPackSettings;

	[Token(Token = "0x4000DD5")]
	[FieldOffset(Offset = "0x28")]
	private List<PackAnimal> m_PackAnimals;

	[Token(Token = "0x4000DD6")]
	[FieldOffset(Offset = "0x30")]
	private Dictionary<PackAnimal, PackGroup> m_PackAnimalGroupByLeader;

	[Token(Token = "0x4000DD7")]
	[FieldOffset(Offset = "0x38")]
	private List<PackGroup> m_FreePackGroups;

	[Token(Token = "0x4000DD8")]
	[FieldOffset(Offset = "0x40")]
	private List<PackAnimal> m_RemoveAnimalList;

	[Token(Token = "0x4000DD9")]
	[FieldOffset(Offset = "0x48")]
	public int m_MaxPackSize;

	[Token(Token = "0x4000DDA")]
	[FieldOffset(Offset = "0x4C")]
	public float m_PackReformDisplayTimeSeconds;

	[Token(Token = "0x4000DDB")]
	[FieldOffset(Offset = "0x50")]
	private float m_PackReformDisplayTimer;

	[Header("Pack Nearby Sound For Interiors")]
	[Token(Token = "0x4000DDC")]
	[FieldOffset(Offset = "0x54")]
	public float m_PackNearbyRange;

	[Token(Token = "0x4000DDD")]
	[FieldOffset(Offset = "0x58")]
	public string m_PackNearbySoundName;

	[Header("Combat Restricted Mode")]
	[Token(Token = "0x4000DDE")]
	[FieldOffset(Offset = "0x60")]
	public float m_MinCombatRestrictedDistance;

	[Token(Token = "0x4000DDF")]
	[FieldOffset(Offset = "0x64")]
	public float m_MinPlayerDistanceToHoldGroundPoint;

	[Token(Token = "0x4000DE0")]
	[FieldOffset(Offset = "0x68")]
	public float m_MaxPlayerDistanceToHoldGroundPoint;

	[Tooltip("Don't choose markups that would cause animal to cross paths with player. Need this angle difference.")]
	[Token(Token = "0x4000DE1")]
	[FieldOffset(Offset = "0x6C")]
	public float m_MinAngleBetweenPlayerAndMarkup;

	[Token(Token = "0x4000DE2")]
	[FieldOffset(Offset = "0x70")]
	public float m_QueueCombatRestrictedAttackDelay;

	[Token(Token = "0x4000DE3")]
	[FieldOffset(Offset = "0x74")]
	public float m_AiModeSwitchDelayDuringRepositioningSeconds;

	[Token(Token = "0x4000DE4")]
	[FieldOffset(Offset = "0x78")]
	public float m_MinDistanceToPlayerDuringReposition;

	[Token(Token = "0x4000DE5")]
	[FieldOffset(Offset = "0x7C")]
	public float m_AcceptanceDistanceToHoldGround;

	[Token(Token = "0x4000DE6")]
	[FieldOffset(Offset = "0x80")]
	public float m_MinMovedDistance;

	[Token(Token = "0x4000DE7")]
	[FieldOffset(Offset = "0x84")]
	private bool m_EnablePacksOnLoad;

	[Token(Token = "0x4000DE8")]
	[FieldOffset(Offset = "0x85")]
	private bool m_PlayerInPackCombatTrigger;

	[Tooltip("To prevent going in and out of buildings from automatically resetting game time elapsed.")]
	[Token(Token = "0x4000DE9")]
	[FieldOffset(Offset = "0x88")]
	public float m_DeserializeDelayTimeSeconds;

	[Token(Token = "0x4000DEA")]
	[FieldOffset(Offset = "0x8C")]
	private float m_DeserializeDelayTimer;

	[Token(Token = "0x4000DEB")]
	[FieldOffset(Offset = "0x90")]
	private Vector3 m_PlayerLastKnownPosition;

	[Token(Token = "0x4000DEC")]
	[FieldOffset(Offset = "0xA0")]
	private List<AreaMarkup> m_PrunedAreaMarkupList;

	[Token(Token = "0x4000DED")]
	[FieldOffset(Offset = "0xA8")]
	private Dictionary<AreaMarkup, PackAnimal> m_PackAnimalByHoldGroundHint;

	[Token(Token = "0x4000DEE")]
	[FieldOffset(Offset = "0xB0")]
	private Dictionary<PackAnimal, AreaMarkup> m_HoldGroundHintByPackAnimal;

	[Token(Token = "0x4000DEF")]
	[FieldOffset(Offset = "0xB8")]
	private Dictionary<string, Vector3> m_LonerWanderLocationByGroupId;

	[Token(Token = "0x4000DF0")]
	[FieldOffset(Offset = "0xC0")]
	private bool m_IsPackNearby;

	[Token(Token = "0x4000DF1")]
	[FieldOffset(Offset = "0xC1")]
	private bool m_WasPackNearby;

	[Token(Token = "0x4000DF2")]
	[FieldOffset(Offset = "0xC4")]
	private float m_HoursPlayedAtStart;

	[Token(Token = "0x4000DF3")]
	[FieldOffset(Offset = "0xC8")]
	private bool m_SystemEnabled;

	[Token(Token = "0x6000E80")]
	[Address(RVA = "0x5F1C60", Offset = "0x5F0A60", Length = "0x200")]
	private PackSettings GetPackSettings()
	{
		return null;
	}

	[Token(Token = "0x6000E81")]
	[Address(RVA = "0x5F1E70", Offset = "0x5F0C70", Length = "0xC1")]
	public string SerializeGlobal()
	{
		return null;
	}

	[Token(Token = "0x6000E82")]
	[Address(RVA = "0x5F1F40", Offset = "0x5F0D40", Length = "0x92")]
	public void DeserializeGlobal(string serialized)
	{
	}

	[Token(Token = "0x6000E83")]
	[Address(RVA = "0x5F1FE0", Offset = "0x5F0DE0", Length = "0x9CC")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x6000E84")]
	[Address(RVA = "0x5F29B0", Offset = "0x5F17B0", Length = "0xBA6")]
	public void Deserialize(string text)
	{
	}

	[Token(Token = "0x6000E85")]
	[Address(RVA = "0x5F3560", Offset = "0x5F2360", Length = "0x15B")]
	public void RegisterPackAnimal(PackAnimal pa)
	{
	}

	[Token(Token = "0x6000E86")]
	[Address(RVA = "0x5F36C0", Offset = "0x5F24C0", Length = "0x58F")]
	private void RemoveGroup(PackAnimal leader, bool setReformTimer)
	{
	}

	[Token(Token = "0x6000E87")]
	[Address(RVA = "0x5F3C50", Offset = "0x5F2A50", Length = "0x1D4")]
	private PackAnimal FindPackGroupLeaderByGroupId(string groupId)
	{
		return null;
	}

	[Token(Token = "0x6000E88")]
	[Address(RVA = "0x5F3E30", Offset = "0x5F2C30", Length = "0x446")]
	private PackAnimal MaybeAddOrUpdateGroup(PackAnimal newLeader)
	{
		return null;
	}

	[Token(Token = "0x6000E89")]
	[Address(RVA = "0x5F4280", Offset = "0x5F3080", Length = "0x22")]
	private bool IsMismatchWildlifeMode(PackAnimal animal)
	{
		return false;
	}

	[Token(Token = "0x6000E8A")]
	[Address(RVA = "0x5F42B0", Offset = "0x5F30B0", Length = "0x1A7")]
	private bool CanAnimalFormGroup(PackAnimal animal)
	{
		return false;
	}

	[Token(Token = "0x6000E8B")]
	[Address(RVA = "0x5F4460", Offset = "0x5F3260", Length = "0x9BA")]
	public bool MaybeFormGroup(PackAnimal newLeader)
	{
		return false;
	}

	[Token(Token = "0x6000E8C")]
	[Address(RVA = "0x5F4E20", Offset = "0x5F3C20", Length = "0x358")]
	public void MaybeAlertMembers(PackAnimal animal)
	{
	}

	[Token(Token = "0x6000E8D")]
	[Address(RVA = "0x5F5180", Offset = "0x5F3F80", Length = "0x39B")]
	public void MaybeStartHowl(PackAnimal animal)
	{
	}

	[Token(Token = "0x6000E8E")]
	[Address(RVA = "0x5F5520", Offset = "0x5F4320", Length = "0x196")]
	public bool DisbandGroup(PackAnimal pa, bool setReformTimer)
	{
		return false;
	}

	[Token(Token = "0x6000E8F")]
	[Address(RVA = "0x5F56C0", Offset = "0x5F44C0", Length = "0x160")]
	public PackAnimal ChooseLeader(PackGroup pack)
	{
		return null;
	}

	[Token(Token = "0x6000E90")]
	[Address(RVA = "0x5F5830", Offset = "0x5F4630", Length = "0x614")]
	public void UnregisterPackAnimal(PackAnimal pa, bool onDeath)
	{
	}

	[Token(Token = "0x6000E91")]
	[Address(RVA = "0x5F5E50", Offset = "0x5F4C50", Length = "0x15F")]
	public static bool InPack(PackAnimal animal)
	{
		return false;
	}

	[Token(Token = "0x6000E92")]
	[Address(RVA = "0x5F5FB0", Offset = "0x5F4DB0", Length = "0x17A")]
	public static bool IsLeader(PackAnimal animal)
	{
		return false;
	}

	[Token(Token = "0x6000E93")]
	[Address(RVA = "0x5F6130", Offset = "0x5F4F30", Length = "0xE4")]
	public static bool IsValidPackTarget(AiTarget target)
	{
		return false;
	}

	[Token(Token = "0x6000E94")]
	[Address(RVA = "0x5F6220", Offset = "0x5F5020", Length = "0x435")]
	public bool IsPointCloseToPackMembers(PackAnimal animal, Vector3 point, float radius)
	{
		return false;
	}

	[Token(Token = "0x6000E95")]
	[Address(RVA = "0x5F6660", Offset = "0x5F5460", Length = "0x1A3")]
	public float GroupMoraleHeuristic(PackAnimal animal)
	{
		return 0f;
	}

	[Conditional("__DEBUG")]
	[Token(Token = "0x6000E96")]
	[Address(RVA = "0x5F6810", Offset = "0x5F5610", Length = "0x43")]
	private void DebugMoraleReport(string text, float value)
	{
	}

	[Token(Token = "0x6000E97")]
	[Address(RVA = "0x5F6860", Offset = "0x5F5660", Length = "0x7A")]
	public void ModifyGroupMoraleOnDamage(PackAnimal animal)
	{
	}

	[Token(Token = "0x6000E98")]
	[Address(RVA = "0x5F68E0", Offset = "0x5F56E0", Length = "0x5B")]
	public void ModifyGroupMoraleOnNearMissGunshot(PackAnimal animal)
	{
	}

	[Token(Token = "0x6000E99")]
	[Address(RVA = "0x5F6940", Offset = "0x5F5740", Length = "0x72")]
	public void ModifyGroupMoraleOnFlareGunRound(PackAnimal animal, bool isStuckInAnimal)
	{
	}

	[Token(Token = "0x6000E9A")]
	[Address(RVA = "0x5F69C0", Offset = "0x5F57C0", Length = "0x393")]
	public void ModifyGroupMoraleOnGunshot(PackAnimal animal)
	{
	}

	[Token(Token = "0x6000E9B")]
	[Address(RVA = "0x5F6D60", Offset = "0x5F5B60", Length = "0x63")]
	public void ModifyGroupMoraleOnFlashLightHighBeam(PackAnimal animal)
	{
	}

	[Token(Token = "0x6000E9C")]
	[Address(RVA = "0x5F6DD0", Offset = "0x5F5BD0", Length = "0x23F")]
	public void ModifyGroupMoraleOnHitWithItem(PackAnimal animal, GearItem item)
	{
	}

	[Token(Token = "0x6000E9D")]
	[Address(RVA = "0x5F7010", Offset = "0x5F5E10", Length = "0x2B5")]
	public void ModifyGroupMoraleOnThrownItem(PackAnimal animal, GearItem item)
	{
	}

	[Token(Token = "0x6000E9E")]
	[Address(RVA = "0x5F72D0", Offset = "0x5F60D0", Length = "0x262")]
	public bool ModifyGroupMorale(PackSettings modeSettings, PackAnimal animal, float percent, MoraleModifierType eventType)
	{
		return false;
	}

	[Token(Token = "0x6000E9F")]
	[Address(RVA = "0x5F7540", Offset = "0x5F6340", Length = "0xF9")]
	public PackAnimal GetPackLeader(BaseAi ai)
	{
		return null;
	}

	[Token(Token = "0x6000EA0")]
	[Address(RVA = "0x5F7640", Offset = "0x5F6440", Length = "0x9F")]
	public int GetMemberCount(PackAnimal leader)
	{
		return 0;
	}

	[Token(Token = "0x6000EA1")]
	[Address(RVA = "0x5F76E0", Offset = "0x5F64E0", Length = "0x7")]
	public void SetPackCombatRestricted(bool enable)
	{
	}

	[Token(Token = "0x6000EA2")]
	[Address(RVA = "0x5F76F0", Offset = "0x5F64F0", Length = "0x28C")]
	public bool IsPackCombatRestricted(PackAnimal animal)
	{
		return false;
	}

	[Token(Token = "0x6000EA3")]
	[Address(RVA = "0x5F7980", Offset = "0x5F6780", Length = "0x85")]
	public int GetFormationCount(PackAnimal leader)
	{
		return 0;
	}

	[Token(Token = "0x6000EA4")]
	[Address(RVA = "0x5F7A10", Offset = "0x5F6810", Length = "0x566")]
	public bool ShouldAnimalFlee(PackAnimal animal)
	{
		return false;
	}

	[Token(Token = "0x6000EA5")]
	[Address(RVA = "0x5F7F80", Offset = "0x5F6D80", Length = "0x1F")]
	public float GetMoraleThreshold()
	{
		return 0f;
	}

	[Token(Token = "0x6000EA6")]
	[Address(RVA = "0x5F7FA0", Offset = "0x5F6DA0", Length = "0x25B")]
	public bool ShouldAnimalFleeChance(PackAnimal animal)
	{
		return false;
	}

	[Token(Token = "0x6000EA7")]
	[Address(RVA = "0x5F8200", Offset = "0x5F7000", Length = "0x478")]
	public bool CanAttack(PackAnimal animal, bool pathChecked = false)
	{
		return false;
	}

	[Token(Token = "0x6000EA8")]
	[Address(RVA = "0x5F8680", Offset = "0x5F7480", Length = "0x19C")]
	public void ClearAttackCooldownTimeOnAttackFailed(PackAnimal animal)
	{
	}

	[Token(Token = "0x6000EA9")]
	[Address(RVA = "0x5F8820", Offset = "0x5F7620", Length = "0x1F7")]
	public void MaybeSetPackAttackCooldownTime(PackAnimal animal)
	{
	}

	[Token(Token = "0x6000EAA")]
	[Address(RVA = "0x5F8A20", Offset = "0x5F7820", Length = "0x4DC")]
	private void MaybeForceAttackInCombatRestrictedArea(PackSettings modeSettings)
	{
	}

	[Token(Token = "0x6000EAB")]
	[Address(RVA = "0x5F8F00", Offset = "0x5F7D00", Length = "0x91B")]
	private void MaybeCleanupDeadPackAnimals(PackSettings modeSettings)
	{
	}

	[Token(Token = "0x6000EAC")]
	[Address(RVA = "0x5F9820", Offset = "0x5F8620", Length = "0x680")]
	private void MaybeDisbandGroupOnTargetLost(PackSettings modeSettings)
	{
	}

	[Token(Token = "0x6000EAD")]
	[Address(RVA = "0x5F9EB0", Offset = "0x5F8CB0", Length = "0x170")]
	private void MaybeSetAuroraMaterialsOnFlee(BaseAi ai)
	{
	}

	[Token(Token = "0x6000EAE")]
	[Address(RVA = "0x5FA030", Offset = "0x5F8E30", Length = "0x654")]
	private void MaybeFleeAndDisbandOnMoraleCheck()
	{
	}

	[Token(Token = "0x6000EAF")]
	[Address(RVA = "0x5FA690", Offset = "0x5F9490", Length = "0x766")]
	private void MaybeFleeAndDisbandOnBearOrMooseCheck(PackSettings modeSettings)
	{
	}

	[Token(Token = "0x6000EB0")]
	[Address(RVA = "0x5FAE00", Offset = "0x5F9C00", Length = "0x5AD")]
	private void MaybeForceMoveMembers(PackSettings modeSettings)
	{
	}

	[Token(Token = "0x6000EB1")]
	[Address(RVA = "0x5FB3B0", Offset = "0x5FA1B0", Length = "0x73")]
	public bool IsMovingToHoldGroundPosition(PackAnimal animal)
	{
		return false;
	}

	[Token(Token = "0x6000EB2")]
	[Address(RVA = "0x5FB430", Offset = "0x5FA230", Length = "0x7C")]
	private bool MaybePickAndMoveToHoldGroundHint(PackAnimal member)
	{
		return false;
	}

	[Token(Token = "0x6000EB3")]
	[Address(RVA = "0x5FB4B0", Offset = "0x5FA2B0", Length = "0x900")]
	private void MaybeForceHoldGroundAfterReposition(PackSettings modeSettings)
	{
	}

	[Token(Token = "0x6000EB4")]
	[Address(RVA = "0x5FBDC0", Offset = "0x5FABC0", Length = "0x502")]
	private void MaybeMoveToNewHoldGroundPosition(PackSettings modeSettings)
	{
	}

	[Token(Token = "0x6000EB5")]
	[Address(RVA = "0x5FC2D0", Offset = "0x5FB0D0", Length = "0x2B")]
	private static bool IsTaggedGroupAnimal(PackAnimal animal)
	{
		return false;
	}

	[Token(Token = "0x6000EB6")]
	[Address(RVA = "0x5FC300", Offset = "0x5FB100", Length = "0x5B")]
	private static bool AreSameTaggedGroupAnimals(PackAnimal a, PackAnimal b)
	{
		return false;
	}

	[Token(Token = "0x6000EB7")]
	[Address(RVA = "0x5FC360", Offset = "0x5FB160", Length = "0xBF9")]
	private void MaybeKeepLonersWithinRadius()
	{
	}

	[Token(Token = "0x6000EB8")]
	[Address(RVA = "0x5FCF60", Offset = "0x5FBD60", Length = "0x504")]
	private void MaybeFormGroupOnPlayerDetectionRange(PackSettings modeSettings)
	{
	}

	[Token(Token = "0x6000EB9")]
	[Address(RVA = "0x5FD470", Offset = "0x5FC270", Length = "0x15E4")]
	private bool MaybePickHoldGroundHint(PackAnimal animal, out Vector3 point)
	{
		point = default(Vector3);
		return false;
	}

	[Token(Token = "0x6000EBA")]
	[Address(RVA = "0x5FEA60", Offset = "0x5FD860", Length = "0x24D")]
	public float GetHighestPackMorale(out float modifier, out int memberCount, out int originalMemberCount)
	{
		modifier = default(float);
		memberCount = default(int);
		originalMemberCount = default(int);
		return 0f;
	}

	[Token(Token = "0x6000EBB")]
	[Address(RVA = "0x5FECB0", Offset = "0x5FDAB0", Length = "0x477")]
	private void MaybeEnableAnimalsOnLoad()
	{
	}

	[Token(Token = "0x6000EBC")]
	[Address(RVA = "0x5FF130", Offset = "0x5FDF30", Length = "0x17B")]
	private void ResetGroupEventFlags()
	{
	}

	[Token(Token = "0x6000EBD")]
	[Address(RVA = "0x5FF2B0", Offset = "0x5FE0B0", Length = "0x587")]
	private void MaybeUpdateInteriorAudio(PackSettings modeSettings)
	{
	}

	[Token(Token = "0x6000EBE")]
	[Address(RVA = "0x5FF840", Offset = "0x5FE640", Length = "0x72")]
	public bool ArePacksAllowed()
	{
		return false;
	}

	[Token(Token = "0x6000EBF")]
	[Address(RVA = "0x5FF8C0", Offset = "0x5FE6C0", Length = "0x1A3")]
	public void Start()
	{
	}

	[Token(Token = "0x6000EC0")]
	[Address(RVA = "0x5FFA70", Offset = "0x5FE870", Length = "0x186")]
	public void Update()
	{
	}

	[Token(Token = "0x6000EC1")]
	[Address(RVA = "0x5FFC00", Offset = "0x5FEA00", Length = "0x666")]
	public PackManager()
	{
	}
}
