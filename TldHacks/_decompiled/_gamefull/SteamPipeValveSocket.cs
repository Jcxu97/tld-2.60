using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.Interactions;
using TLD.UI.Generics;
using UnityEngine;
using UnityEngine.Serialization;

[Token(Token = "0x2000967")]
public class SteamPipeValveSocket : MonoBehaviour
{
	[Token(Token = "0x40061D0")]
	private const int HANDLE_INTERACTION = 0;

	[Token(Token = "0x40061D1")]
	private const int SOCKET_INTERACTION = 1;

	[Tooltip("The steam pipe this valve socket should be connected to and influence.")]
	[Token(Token = "0x40061D2")]
	[FieldOffset(Offset = "0x20")]
	public SteamPipe m_SteamPipe;

	[Tooltip("The actual valve this valve socket should be connected to and influence.")]
	[Token(Token = "0x40061D3")]
	[FieldOffset(Offset = "0x28")]
	public SteamPipeValve m_SteamPipeValve;

	[Tooltip("The hover text displayed during interaction.")]
	[Token(Token = "0x40061D4")]
	[FieldOffset(Offset = "0x30")]
	public LocalizedString m_LocalizedDisplayName;

	[Tooltip("Collider to use when no handle is attached.")]
	[Token(Token = "0x40061D5")]
	[FieldOffset(Offset = "0x38")]
	public Collider m_SocketCollider;

	[Tooltip("Collider to use when a handle is attached.")]
	[Token(Token = "0x40061D6")]
	[FieldOffset(Offset = "0x40")]
	public Collider m_AttachedHandleCollider;

	[Tooltip("Gear items required in player's inventory before interaction is allowed.")]
	[Token(Token = "0x40061D7")]
	[FieldOffset(Offset = "0x48")]
	public List<GearItem> m_RequiredGearItems;

	[Tooltip("Gear items taken from the player's inventory during activation/attach interaction.")]
	[Token(Token = "0x40061D8")]
	[FieldOffset(Offset = "0x50")]
	public List<GearItem> m_RemoveFromInventory;

	[Tooltip("Gear items returned to the player's inventory during deactivation/dismantle interaction.")]
	[Token(Token = "0x40061D9")]
	[FieldOffset(Offset = "0x58")]
	public List<GearItem> m_ReturnToInventory;

	[Tooltip("Is the valve connected to this socket be active/attached initially?")]
	[Token(Token = "0x40061DA")]
	[FieldOffset(Offset = "0x60")]
	public bool m_SteamPipeValveActive;

	[Tooltip("Should the valve open/closed state be reset on deactivation/dismantle?")]
	[Token(Token = "0x40061DB")]
	[FieldOffset(Offset = "0x61")]
	public bool m_SetOpenStateOnDismantle;

	[Tooltip("If the valve open/closed state should be reset, what state?")]
	[Token(Token = "0x40061DC")]
	[FieldOffset(Offset = "0x62")]
	public bool m_IsOpenOnDismantle;

	[Tooltip("If the valve can be dismantled after placing")]
	[Token(Token = "0x40061DD")]
	[FieldOffset(Offset = "0x63")]
	public bool m_CanDismantle;

	[Tooltip("If the valve can be dismantled when frozen")]
	[Token(Token = "0x40061DE")]
	[FieldOffset(Offset = "0x64")]
	public bool m_CanDismantleWhenFrozen;

	[Tooltip("If the valve can be attached when frozen")]
	[Token(Token = "0x40061DF")]
	[FieldOffset(Offset = "0x65")]
	public bool m_CanAttachWhenFrozen;

	[Tooltip("Attach and open as one action")]
	[Token(Token = "0x40061E0")]
	[FieldOffset(Offset = "0x66")]
	public bool m_AttachAndOpen;

	[Tooltip("automatically attach handle without prompt")]
	[FormerlySerializedAs("m_AutoamticAttach")]
	[Token(Token = "0x40061E1")]
	[FieldOffset(Offset = "0x67")]
	public bool m_AutomaticAttach;

	[Tooltip("If there's different art for frozen specified and the pipe is closed, this game object will be enabled.")]
	[Token(Token = "0x40061E2")]
	[FieldOffset(Offset = "0x68")]
	public GameObject m_FrozenValveSocket;

	[Tooltip("If there's different art for frozen specified and the pipe is opened, this game object will be enabled.")]
	[Token(Token = "0x40061E3")]
	[FieldOffset(Offset = "0x70")]
	public GameObject m_UnfrozenValveSocket;

	[Token(Token = "0x40061E4")]
	[FieldOffset(Offset = "0x78")]
	public AnimatedInteraction m_AttachValveInteraction;

	[Token(Token = "0x40061E5")]
	[FieldOffset(Offset = "0x80")]
	public AnimatedInteraction m_DetachValveInteraction;

	[Header("Panel References")]
	[SerializeField]
	[Token(Token = "0x40061E6")]
	[FieldOffset(Offset = "0x88")]
	private PanelReference<Panel_HUD> m_HUD;

	[Token(Token = "0x40061E7")]
	[FieldOffset(Offset = "0x90")]
	private string m_Guid;

	[Token(Token = "0x40061E8")]
	[FieldOffset(Offset = "0x98")]
	private bool m_MaybeFrozen;

	[Token(Token = "0x60054F3")]
	[Address(RVA = "0xE92000", Offset = "0xE90E00", Length = "0x23E")]
	private void Awake()
	{
	}

	[Token(Token = "0x60054F4")]
	[Address(RVA = "0x40DA00", Offset = "0x40C800", Length = "0x8")]
	public string GetGuid()
	{
		return null;
	}

	[Token(Token = "0x60054F5")]
	[Address(RVA = "0xE92240", Offset = "0xE91040", Length = "0x2E3")]
	private void Start()
	{
	}

	[Token(Token = "0x60054F6")]
	[Address(RVA = "0xE92530", Offset = "0xE91330", Length = "0x87")]
	private void Update()
	{
	}

	[Token(Token = "0x60054F7")]
	[Address(RVA = "0xE925C0", Offset = "0xE913C0", Length = "0xB6")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60054F8")]
	[Address(RVA = "0xE92680", Offset = "0xE91480", Length = "0x1B1")]
	private void OnValidate()
	{
	}

	[Token(Token = "0x60054F9")]
	[Address(RVA = "0xE92840", Offset = "0xE91640", Length = "0x7")]
	public void InitializeInteraction()
	{
	}

	[Token(Token = "0x60054FA")]
	[Address(RVA = "0xE92850", Offset = "0xE91650", Length = "0x6C")]
	public void UpdateInteraction(BaseInteraction baseInteraction)
	{
	}

	[Token(Token = "0x60054FB")]
	[Address(RVA = "0xE928C0", Offset = "0xE916C0", Length = "0x14A")]
	private string GetHoverText()
	{
		return null;
	}

	[Token(Token = "0x60054FC")]
	[Address(RVA = "0xE92A10", Offset = "0xE91810", Length = "0x4DD")]
	private void ShowHoverButtonPrompts()
	{
	}

	[Token(Token = "0x60054FD")]
	[Address(RVA = "0xE92EF0", Offset = "0xE91CF0", Length = "0x68E")]
	public void PerformInteraction()
	{
	}

	[Token(Token = "0x60054FE")]
	[Address(RVA = "0xE93580", Offset = "0xE92380", Length = "0xC8")]
	public void HideInteraction()
	{
	}

	[Token(Token = "0x60054FF")]
	[Address(RVA = "0xE93650", Offset = "0xE92450", Length = "0x7")]
	private void OnCancel()
	{
	}

	[Token(Token = "0x6005500")]
	[Address(RVA = "0xE93660", Offset = "0xE92460", Length = "0x252")]
	private bool HasValveHandleInInventory(Inventory inventory)
	{
		return false;
	}

	[Token(Token = "0x6005501")]
	[Address(RVA = "0xE938C0", Offset = "0xE926C0", Length = "0x3E9")]
	private void HandleInteractionChoice(int choice)
	{
	}

	[Token(Token = "0x6005502")]
	[Address(RVA = "0xE93CB0", Offset = "0xE92AB0", Length = "0x10C")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x6005503")]
	[Address(RVA = "0xE93DC0", Offset = "0xE92BC0", Length = "0x10E")]
	public void Deserialize(string text)
	{
	}

	[Token(Token = "0x6005504")]
	[Address(RVA = "0xE93ED0", Offset = "0xE92CD0", Length = "0x1A7")]
	private void MaybeShowFrozenValveSocket()
	{
	}

	[Token(Token = "0x6005505")]
	[Address(RVA = "0xE94080", Offset = "0xE92E80", Length = "0x70")]
	private void SetSteamPipeValveActive(bool active)
	{
	}

	[Token(Token = "0x6005506")]
	[Address(RVA = "0xE94100", Offset = "0xE92F00", Length = "0x22C")]
	private void OnValveActivateInteraction(bool activate)
	{
	}

	[Token(Token = "0x6005507")]
	[Address(RVA = "0xE94330", Offset = "0xE93130", Length = "0x9E")]
	private void OnAttachValveComplete()
	{
	}

	[Token(Token = "0x6005508")]
	[Address(RVA = "0xE943D0", Offset = "0xE931D0", Length = "0x6D")]
	private void OnDetachValveComplete()
	{
	}

	[Token(Token = "0x6005509")]
	[Address(RVA = "0xE94440", Offset = "0xE93240", Length = "0x54")]
	public SteamPipeValveSocket()
	{
	}
}
