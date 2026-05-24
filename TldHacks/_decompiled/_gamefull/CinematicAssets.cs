using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20002B3")]
public class CinematicAssets : MonoBehaviour
{
	[Token(Token = "0x20002B4")]
	public enum PermanentPropId
	{
		[Token(Token = "0x40017FD")]
		None,
		[Token(Token = "0x40017FE")]
		GM_Rifle,
		[Token(Token = "0x40017FF")]
		HOB_Knife,
		[Token(Token = "0x4001800")]
		MET_Stick,
		[Token(Token = "0x4001801")]
		JER_Radio
	}

	[Serializable]
	[Token(Token = "0x20002B5")]
	public class PropDataInfo
	{
		[Token(Token = "0x4001802")]
		[FieldOffset(Offset = "0x10")]
		public GameObject m_PropPrefab;

		[Token(Token = "0x4001803")]
		[FieldOffset(Offset = "0x18")]
		public PropOwnerType m_AssetType;

		[Token(Token = "0x4001804")]
		[FieldOffset(Offset = "0x1C")]
		public PermanentPropId m_PermanentPropId;

		[Token(Token = "0x4001805")]
		[FieldOffset(Offset = "0x20")]
		public string m_PermanentPropMissionId;

		[Token(Token = "0x6001709")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public PropDataInfo()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x20002B6")]
	public class PermanentPropInfo
	{
		[Token(Token = "0x4001806")]
		[FieldOffset(Offset = "0x10")]
		public PermanentPropId m_PermanentPropId;

		[Token(Token = "0x4001807")]
		[FieldOffset(Offset = "0x18")]
		public Animator m_Animator;

		[HideInInspector]
		[Token(Token = "0x4001808")]
		[FieldOffset(Offset = "0x20")]
		public RuntimeAnimatorController m_OriginalController;

		[Token(Token = "0x600170A")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public PermanentPropInfo()
		{
		}
	}

	[Token(Token = "0x20002B7")]
	public class DialogueProp
	{
		[Token(Token = "0x4001809")]
		[FieldOffset(Offset = "0x10")]
		public PropDataInfo m_Data;

		[Token(Token = "0x400180A")]
		[FieldOffset(Offset = "0x18")]
		public GameObject m_LoadedPropAsset;

		[Token(Token = "0x400180B")]
		[FieldOffset(Offset = "0x20")]
		public Animator m_LoadedAnimator;

		[Token(Token = "0x400180C")]
		[FieldOffset(Offset = "0x28")]
		public PermanentPropInfo m_PermanentProp;

		[Token(Token = "0x600170B")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public DialogueProp()
		{
		}
	}

	[Token(Token = "0x20002B8")]
	public enum PropOwnerType
	{
		[Token(Token = "0x400180E")]
		NPC,
		[Token(Token = "0x400180F")]
		Player
	}

	[Token(Token = "0x40017F6")]
	[FieldOffset(Offset = "0x20")]
	public Animator m_NPC_Animator;

	[Token(Token = "0x40017F7")]
	[FieldOffset(Offset = "0x28")]
	public Animator m_Player_Animator;

	[Token(Token = "0x40017F8")]
	[FieldOffset(Offset = "0x30")]
	public List<PropDataInfo> m_Props;

	[Token(Token = "0x40017F9")]
	[FieldOffset(Offset = "0x38")]
	private List<DialogueProp> m_TransientProps;

	[Token(Token = "0x40017FA")]
	[FieldOffset(Offset = "0x40")]
	private List<DialogueProp> m_PermananentProps;

	[Token(Token = "0x40017FB")]
	[FieldOffset(Offset = "0x48")]
	private bool m_ArePropsLoaded;

	[Token(Token = "0x60016F8")]
	[Address(RVA = "0x5C6C80", Offset = "0x5C5A80", Length = "0x5")]
	public bool ArePropsLoaded()
	{
		return false;
	}

	[Token(Token = "0x60016F9")]
	[Address(RVA = "0x6C5A80", Offset = "0x6C4880", Length = "0x1D9")]
	public PermanentPropInfo TryGetPermanentPropInfoFromMissionId(string missionId)
	{
		return null;
	}

	[Token(Token = "0x60016FA")]
	[Address(RVA = "0x6C5C60", Offset = "0x6C4A60", Length = "0xCD")]
	public PermanentPropInfo GetPermanentPropInfo(PermanentPropId value, List<PermanentPropInfo> props)
	{
		return null;
	}

	[Token(Token = "0x60016FB")]
	[Address(RVA = "0x6C5D30", Offset = "0x6C4B30", Length = "0x3AA")]
	private bool LoadTransientProp(DialogueProp dialogueProp)
	{
		return false;
	}

	[Token(Token = "0x60016FC")]
	[Address(RVA = "0x6C60E0", Offset = "0x6C4EE0", Length = "0x433")]
	private bool LoadPermanentProp(DialogueProp prop, List<PermanentPropInfo> permanentProps)
	{
		return false;
	}

	[Token(Token = "0x60016FD")]
	[Address(RVA = "0x6C6520", Offset = "0x6C5320", Length = "0xAF")]
	private void LoadProp(DialogueProp prop, List<PermanentPropInfo> permanentProps)
	{
	}

	[Token(Token = "0x60016FE")]
	[Address(RVA = "0x6C65D0", Offset = "0x6C53D0", Length = "0x285")]
	public void LoadProps(List<PermanentPropInfo> permanentProps)
	{
	}

	[Token(Token = "0x60016FF")]
	[Address(RVA = "0x6C6860", Offset = "0x6C5660", Length = "0x4A7")]
	public void ReParentProp(PropOwnerType typeAsset, GameObject newParent)
	{
	}

	[Token(Token = "0x6001700")]
	[Address(RVA = "0x6C6D10", Offset = "0x6C5B10", Length = "0x34D")]
	public void UnloadProps()
	{
	}

	[Token(Token = "0x6001701")]
	[Address(RVA = "0x6C7060", Offset = "0x6C5E60", Length = "0x283")]
	public void SetTriggerOnLoadedPermanentProps(string trigger)
	{
	}

	[Token(Token = "0x6001702")]
	[Address(RVA = "0x6C72F0", Offset = "0x6C60F0", Length = "0x1EC")]
	private void RegisterAnimators(DialogueProp dialogueProp)
	{
	}

	[Token(Token = "0x6001703")]
	[Address(RVA = "0x6C74E0", Offset = "0x6C62E0", Length = "0x17D")]
	private void UnRegisterAnimators(DialogueProp dialogueProp)
	{
	}

	[Token(Token = "0x6001704")]
	[Address(RVA = "0x6C7660", Offset = "0x6C6460", Length = "0x255")]
	public void UseLoadedControllerAndResumeState()
	{
	}

	[Token(Token = "0x6001705")]
	[Address(RVA = "0x6C78C0", Offset = "0x6C66C0", Length = "0x24F")]
	public void RestoreOriginalControllerAndResumeState()
	{
	}

	[Token(Token = "0x6001706")]
	[Address(RVA = "0x6C7B10", Offset = "0x6C6910", Length = "0x1A5")]
	private void SynchronizePropAnimation(Animator animator, PlayEventMonitor playEventMonitor, float currentTime)
	{
	}

	[Token(Token = "0x6001707")]
	[Address(RVA = "0x6C7CC0", Offset = "0x6C6AC0", Length = "0x1FC")]
	public void LateSynchronizeAnimators(PropOwnerType typeAsset, float currentTime, PlayEventMonitor playEventMonitor)
	{
	}

	[Token(Token = "0x6001708")]
	[Address(RVA = "0x6C7EC0", Offset = "0x6C6CC0", Length = "0x16F")]
	public CinematicAssets()
	{
	}
}
