using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200042F")]
public class Lock : MonoBehaviour
{
	[Token(Token = "0x2000430")]
	public delegate void OnLockStateBroken();

	[Token(Token = "0x4002590")]
	private static LockSaveDataProxy m_LockSaveDataProxy;

	[Token(Token = "0x4002591")]
	private static List<string> m_UnlockedCompanionGuids;

	[Token(Token = "0x4002592")]
	[FieldOffset(Offset = "0x20")]
	public GameModeFilter m_ModeFilter;

	[Range(0f, 100f)]
	[Token(Token = "0x4002593")]
	[FieldOffset(Offset = "0x24")]
	public float m_ChanceLocked;

	[Token(Token = "0x4002594")]
	[FieldOffset(Offset = "0x28")]
	public string m_CompanionLockGuid;

	[Token(Token = "0x4002595")]
	[FieldOffset(Offset = "0x30")]
	public string m_LockedAudio;

	[Token(Token = "0x4002596")]
	[FieldOffset(Offset = "0x38")]
	public string m_UnlockAudio;

	[Header("Keypad")]
	[Token(Token = "0x4002597")]
	[FieldOffset(Offset = "0x40")]
	public Keypad m_AttachedKeypad;

	[Token(Token = "0x4002598")]
	[FieldOffset(Offset = "0x48")]
	public LocalizedString m_LockedKeypadText;

	[Header("Force Lock")]
	[Range(0f, 10f)]
	[Token(Token = "0x4002599")]
	[FieldOffset(Offset = "0x50")]
	public float m_ForceLockDurationSecondsMin;

	[Range(0f, 10f)]
	[Token(Token = "0x400259A")]
	[FieldOffset(Offset = "0x54")]
	public float m_ForceLockDurationSecondsMax;

	[Token(Token = "0x400259B")]
	[FieldOffset(Offset = "0x58")]
	public GearItem m_GearPrefabToForceLock;

	[Tooltip("Hide Tool Required To Force Open Hint Text")]
	[Token(Token = "0x400259C")]
	[FieldOffset(Offset = "0x60")]
	public bool m_HideToolRequiredToForceOpenHintText;

	[Tooltip("Use the custom Hover Text Lock/Unlock colors")]
	[Token(Token = "0x400259D")]
	[FieldOffset(Offset = "0x61")]
	public bool m_UseHoverTextColor;

	[Header("Animation")]
	[Token(Token = "0x400259E")]
	[FieldOffset(Offset = "0x68")]
	public AnimatedInteraction m_AnimatedInteraction;

	[Token(Token = "0x400259F")]
	[FieldOffset(Offset = "0x70")]
	public Animator m_AnimatedObjectAnimator;

	[Token(Token = "0x40025A0")]
	[FieldOffset(Offset = "0x78")]
	public string m_AnimatedObjectTrackName;

	[Token(Token = "0x40025A1")]
	[FieldOffset(Offset = "0x80")]
	private GearItem m_GearUsedToForceLock;

	[Token(Token = "0x40025A2")]
	[FieldOffset(Offset = "0x88")]
	private LockState m_LockState;

	[Token(Token = "0x40025A3")]
	[FieldOffset(Offset = "0x8C")]
	private bool m_AttemptedToOpen;

	[Token(Token = "0x40025A4")]
	[FieldOffset(Offset = "0x8D")]
	private bool m_LockStateRolled;

	[Token(Token = "0x40025A5")]
	[FieldOffset(Offset = "0x8E")]
	private bool m_BreakOnUse;

	[Token(Token = "0x40025A6")]
	[FieldOffset(Offset = "0x90")]
	private ObjectGuid m_ObjectGuid;

	[Token(Token = "0x40025A7")]
	[FieldOffset(Offset = "0x98")]
	private uint m_ForceLockAudioID;

	[Token(Token = "0x40025A8")]
	[FieldOffset(Offset = "0x9C")]
	private bool m_WasEverLocked;

	[Token(Token = "0x17000211")]
	[field: Token(Token = "0x40025A9")]
	[field: FieldOffset(Offset = "0xA0")]
	public float ForceTime
	{
		[Token(Token = "0x6001F62")]
		[Address(RVA = "0x507A50", Offset = "0x506850", Length = "0x9")]
		get;
		[Token(Token = "0x6001F63")]
		[Address(RVA = "0x7DA4A0", Offset = "0x7D92A0", Length = "0x9")]
		private set;
	}

	[Token(Token = "0x17000212")]
	[field: Token(Token = "0x40025AA")]
	[field: FieldOffset(Offset = "0xA4")]
	public float FailureTime
	{
		[Token(Token = "0x6001F64")]
		[Address(RVA = "0x7DA4B0", Offset = "0x7D92B0", Length = "0x9")]
		get;
		[Token(Token = "0x6001F65")]
		[Address(RVA = "0x7DA4C0", Offset = "0x7D92C0", Length = "0x9")]
		private set;
	}

	[Token(Token = "0x17000213")]
	[field: Token(Token = "0x40025AB")]
	[field: FieldOffset(Offset = "0xA8")]
	public string ForceText
	{
		[Token(Token = "0x6001F66")]
		[Address(RVA = "0x636F10", Offset = "0x635D10", Length = "0x8")]
		get;
		[Token(Token = "0x6001F67")]
		[Address(RVA = "0x6BCEA0", Offset = "0x6BBCA0", Length = "0x52")]
		private set;
	}

	[Token(Token = "0x6001F68")]
	[Address(RVA = "0x7DA4D0", Offset = "0x7D92D0", Length = "0x284")]
	public void Awake()
	{
	}

	[Token(Token = "0x6001F69")]
	[Address(RVA = "0x7DA760", Offset = "0x7D9560", Length = "0x106")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x6001F6A")]
	[Address(RVA = "0x7DA870", Offset = "0x7D9670", Length = "0x99")]
	public void Deserialize(string text)
	{
	}

	[Token(Token = "0x6001F6B")]
	[Address(RVA = "0x7DA910", Offset = "0x7D9710", Length = "0x110")]
	public static string SerializeUnlockedCompanionGuids()
	{
		return null;
	}

	[Token(Token = "0x6001F6C")]
	[Address(RVA = "0x7DAA30", Offset = "0x7D9830", Length = "0x15C")]
	public static void DeserializeUnlockedCompanionGuids(string text)
	{
	}

	[Token(Token = "0x6001F6D")]
	[Address(RVA = "0x7DAB90", Offset = "0x7D9990", Length = "0xB")]
	public bool IsLocked()
	{
		return false;
	}

	[Token(Token = "0x6001F6E")]
	[Address(RVA = "0x5DEE70", Offset = "0x5DDC70", Length = "0x8")]
	public bool WasEverLocked()
	{
		return false;
	}

	[Token(Token = "0x6001F6F")]
	[Address(RVA = "0x7DABA0", Offset = "0x7D99A0", Length = "0x12")]
	public void SetLockState(LockState state)
	{
	}

	[Token(Token = "0x6001F70")]
	[Address(RVA = "0x7DABC0", Offset = "0x7D99C0", Length = "0x98")]
	public void RollLockedState()
	{
	}

	[Token(Token = "0x6001F71")]
	[Address(RVA = "0x7DAC60", Offset = "0x7D9A60", Length = "0xCA")]
	public bool RequiresToolToUnlock()
	{
		return false;
	}

	[Token(Token = "0x6001F72")]
	[Address(RVA = "0x7DAD30", Offset = "0x7D9B30", Length = "0xD3")]
	public bool PlayerHasRequiredToolToUnlock()
	{
		return false;
	}

	[Token(Token = "0x6001F73")]
	[Address(RVA = "0x7DAE10", Offset = "0x7D9C10", Length = "0x416")]
	public bool CanForceLock()
	{
		return false;
	}

	[Token(Token = "0x6001F74")]
	[Address(RVA = "0x7DB230", Offset = "0x7DA030", Length = "0x2C2")]
	public void PrepareForceLock()
	{
	}

	[Token(Token = "0x6001F75")]
	[Address(RVA = "0x7DB500", Offset = "0x7DA300", Length = "0x24D")]
	public void FinishForceLock(bool complete)
	{
	}

	[Token(Token = "0x6001F76")]
	[Address(RVA = "0x7DB750", Offset = "0x7DA550", Length = "0x4CD")]
	public GearItem GetGearItemToForceLock()
	{
		return null;
	}

	[Token(Token = "0x6001F77")]
	[Address(RVA = "0x7DBC20", Offset = "0x7DAA20", Length = "0xEE")]
	public void UnlockCompanionLock()
	{
	}

	[Token(Token = "0x6001F78")]
	[Address(RVA = "0x7DBD10", Offset = "0x7DAB10", Length = "0x1B3")]
	private void MaybeUnlockDueToCompanionBeingUnlocked()
	{
	}

	[Token(Token = "0x6001F79")]
	[Address(RVA = "0x7DBED0", Offset = "0x7DACD0", Length = "0x9B")]
	private void PlayLockedAudio()
	{
	}

	[Token(Token = "0x6001F7A")]
	[Address(RVA = "0x7DBF70", Offset = "0x7DAD70", Length = "0x80")]
	private void PlayUnlockAudio()
	{
	}

	[Token(Token = "0x6001F7B")]
	[Address(RVA = "0x7DC000", Offset = "0x7DAE00", Length = "0x208")]
	private void AssignBindingOverrides()
	{
	}

	[Token(Token = "0x6001F7C")]
	[Address(RVA = "0x7DC210", Offset = "0x7DB010", Length = "0x51")]
	public Lock()
	{
	}
}
