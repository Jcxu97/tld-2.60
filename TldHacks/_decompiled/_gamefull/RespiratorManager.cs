using System.Diagnostics;
using AK.Wwise;
using Cpp2ILInjected;
using TLD.Events;
using TLD.Gear;
using TLD.Logging;
using UnityEngine;
using Voice;

[Token(Token = "0x20007C9")]
public class RespiratorManager : MonoBehaviour
{
	[Token(Token = "0x40053AA")]
	public static bool s_ShowDebugInfo;

	[Token(Token = "0x40053AB")]
	public static readonly LogFilter s_LogFilter;

	[Header("Game Events")]
	[SerializeField]
	[Token(Token = "0x40053AC")]
	[FieldOffset(Offset = "0x20")]
	private GameEvent m_EquippedEvent;

	[SerializeField]
	[Token(Token = "0x40053AD")]
	[FieldOffset(Offset = "0x28")]
	private GameEvent m_SwapCanisterEvent;

	[SerializeField]
	[Token(Token = "0x40053AE")]
	[FieldOffset(Offset = "0x30")]
	private GameEvent m_UnequippedEvent;

	[Header("Audio")]
	[SerializeField]
	[Token(Token = "0x40053AF")]
	[FieldOffset(Offset = "0x38")]
	private State m_EquippedStateOn;

	[SerializeField]
	[Token(Token = "0x40053B0")]
	[FieldOffset(Offset = "0x40")]
	private State m_EquippedStateOff;

	[SerializeField]
	[Token(Token = "0x40053B1")]
	[FieldOffset(Offset = "0x48")]
	private AK.Wwise.Event m_EatOrDrinkBlockedVOEvent;

	[SerializeField]
	[Token(Token = "0x40053B2")]
	[FieldOffset(Offset = "0x50")]
	private Priority m_EatOrDrinkBlockedVOPriority;

	[Header("Localization")]
	[SerializeField]
	[Token(Token = "0x40053B3")]
	[FieldOffset(Offset = "0x58")]
	private LocalizedString m_EatOrDrinkBlocked;

	[Token(Token = "0x40053B4")]
	private static bool s_CanisterSwapEnabled;

	[Token(Token = "0x40053B5")]
	private static bool s_EffectsReady;

	[Token(Token = "0x40053B6")]
	private static Respirator s_EquippedInstance;

	[Token(Token = "0x40053B7")]
	private static bool s_CanisterCountNeedsUpdate;

	[Token(Token = "0x40053B8")]
	private static int s_ValidCanistersInInventory;

	[Token(Token = "0x1700033C")]
	public static Respirator CurrentEquipped
	{
		[Token(Token = "0x6004988")]
		[Address(RVA = "0xD20840", Offset = "0xD1F640", Length = "0x54")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700033D")]
	public static bool IsEquipped
	{
		[Token(Token = "0x6004989")]
		[Address(RVA = "0xD208A0", Offset = "0xD1F6A0", Length = "0xFE")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x1700033E")]
	public static bool EffectsReady
	{
		[Token(Token = "0x600498A")]
		[Address(RVA = "0xD209A0", Offset = "0xD1F7A0", Length = "0x54")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x1700033F")]
	public static bool ShowEffects
	{
		[Token(Token = "0x600498B")]
		[Address(RVA = "0xD20A00", Offset = "0xD1F800", Length = "0xAC")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x600498C")]
	[Address(RVA = "0x60B830", Offset = "0x60A630", Length = "0x12")]
	public static string GetDebugText()
	{
		return null;
	}

	[Token(Token = "0x600498D")]
	[Address(RVA = "0xD20AB0", Offset = "0xD1F8B0", Length = "0x57")]
	public static int GetNumCanistersInInventory()
	{
		return 0;
	}

	[Token(Token = "0x600498E")]
	[Address(RVA = "0xD20B10", Offset = "0xD1F910", Length = "0x1BF")]
	public static void HandleEatOrDrinkBlocked()
	{
	}

	[Token(Token = "0x600498F")]
	[Address(RVA = "0xD20CD0", Offset = "0xD1FAD0", Length = "0x1DD")]
	public static void Initialize()
	{
	}

	[Token(Token = "0x6004990")]
	[Address(RVA = "0xD20EB0", Offset = "0xD1FCB0", Length = "0x22D")]
	public static void InterruptAnimations()
	{
	}

	[Token(Token = "0x6004991")]
	[Address(RVA = "0xD210E0", Offset = "0xD1FEE0", Length = "0x2C5")]
	public static bool IsProtectionActive()
	{
		return false;
	}

	[Token(Token = "0x6004992")]
	[Address(RVA = "0xD213B0", Offset = "0xD201B0", Length = "0x3FC")]
	public static bool IsSwapAllowed()
	{
		return false;
	}

	[Token(Token = "0x6004993")]
	[Address(RVA = "0xD217B0", Offset = "0xD205B0", Length = "0x304")]
	public static void MaybeForceExpireCanister()
	{
	}

	[Token(Token = "0x6004994")]
	[Address(RVA = "0xD21AC0", Offset = "0xD208C0", Length = "0x131")]
	public static bool MaybeUnequipCurrentInstance()
	{
		return false;
	}

	[Token(Token = "0x6004995")]
	[Address(RVA = "0xD21C00", Offset = "0xD20A00", Length = "0xFA")]
	public static void ResetGlobals()
	{
	}

	[Token(Token = "0x6004996")]
	[Address(RVA = "0xD21D00", Offset = "0xD20B00", Length = "0x59")]
	public static void SetCanisterSwapEnable(bool enabled)
	{
	}

	[Token(Token = "0x6004997")]
	[Address(RVA = "0xD21D60", Offset = "0xD20B60", Length = "0x59")]
	public static void SetEffectsReady(bool isReady)
	{
	}

	[Token(Token = "0x6004998")]
	[Address(RVA = "0xD21DC0", Offset = "0xD20BC0", Length = "0xF4")]
	public static void SetEquipped(Respirator instance)
	{
	}

	[Token(Token = "0x6004999")]
	[Address(RVA = "0xD21EC0", Offset = "0xD20CC0", Length = "0x15F")]
	public static void TriggerSwap()
	{
	}

	[Token(Token = "0x600499A")]
	[Address(RVA = "0xD22020", Offset = "0xD20E20", Length = "0x215")]
	private void ConnectEventListeners()
	{
	}

	[Token(Token = "0x600499B")]
	[Address(RVA = "0xD22240", Offset = "0xD21040", Length = "0x277")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600499C")]
	[Address(RVA = "0xD224C0", Offset = "0xD212C0", Length = "0x12F")]
	private void Update()
	{
	}

	[Token(Token = "0x600499D")]
	[Address(RVA = "0xD225F0", Offset = "0xD213F0", Length = "0x1E4")]
	private void SetupEquippedState()
	{
	}

	[Token(Token = "0x600499E")]
	[Address(RVA = "0xD227E0", Offset = "0xD215E0", Length = "0xDF")]
	private void TriggerSwapEvent()
	{
	}

	[Token(Token = "0x600499F")]
	[Address(RVA = "0xD228C0", Offset = "0xD216C0", Length = "0x16A")]
	private static bool DoesLockedControlModeBlockSwap()
	{
		return false;
	}

	[Token(Token = "0x60049A0")]
	[Address(RVA = "0xD22A30", Offset = "0xD21830", Length = "0x54")]
	private static void OnAnimationEquipped()
	{
	}

	[Token(Token = "0x60049A1")]
	[Address(RVA = "0xD22A90", Offset = "0xD21890", Length = "0x54")]
	private static void OnAnimationUnequipped()
	{
	}

	[Token(Token = "0x60049A2")]
	[Address(RVA = "0xD22AF0", Offset = "0xD218F0", Length = "0x215")]
	private static void MaybeUpdateCanisterCount()
	{
	}

	[Token(Token = "0x60049A3")]
	[Address(RVA = "0xD22D10", Offset = "0xD21B10", Length = "0x1A7")]
	private static void OnInventoryUpdated(GearItem obj)
	{
	}

	[Conditional("__DEBUG")]
	[Token(Token = "0x60049A4")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	private static void Debug_SwapAllowed()
	{
	}

	[Conditional("__DEBUG")]
	[Token(Token = "0x60049A5")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	private static void Debug_SwapDenied(string reason)
	{
	}

	[Token(Token = "0x60049A6")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public RespiratorManager()
	{
	}
}
