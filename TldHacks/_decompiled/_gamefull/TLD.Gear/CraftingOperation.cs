using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using TLD.UI.Generics;
using UnityEngine;

namespace TLD.Gear;

[Token(Token = "0x2001415")]
public class CraftingOperation
{
	[Token(Token = "0x400929D")]
	[FieldOffset(Offset = "0x40")]
	private PanelReference<Panel_HUD> m_HUD;

	[Token(Token = "0x400929E")]
	[FieldOffset(Offset = "0x48")]
	private MonoBehaviour m_Context;

	[Token(Token = "0x400929F")]
	[FieldOffset(Offset = "0x50")]
	private CraftingLocationInterface m_Location;

	[Token(Token = "0x40092A0")]
	[FieldOffset(Offset = "0x58")]
	private InProgressCraftItem m_WorkInProgress;

	[Token(Token = "0x40092A1")]
	[FieldOffset(Offset = "0x60")]
	private float m_StoredDayLengthScale;

	[Token(Token = "0x40092A2")]
	[FieldOffset(Offset = "0x64")]
	private float m_RealTimeDuration;

	[Token(Token = "0x40092A3")]
	[FieldOffset(Offset = "0x68")]
	private float m_RealTimeElapsed;

	[Token(Token = "0x40092A4")]
	[FieldOffset(Offset = "0x6C")]
	private float m_HoursToSpendCrafting;

	[Token(Token = "0x40092A5")]
	[FieldOffset(Offset = "0x70")]
	private int m_TargetQuantity;

	[Token(Token = "0x40092A6")]
	[FieldOffset(Offset = "0x74")]
	private int m_UnitsCompleted;

	[Token(Token = "0x40092A7")]
	[FieldOffset(Offset = "0x78")]
	private float m_NextUnitProgress;

	[Token(Token = "0x40092A8")]
	[FieldOffset(Offset = "0x80")]
	private ICraftingResult m_LastCraftedItem;

	[Token(Token = "0x40092A9")]
	[FieldOffset(Offset = "0x88")]
	private GearItem m_Tool;

	[Token(Token = "0x40092AA")]
	[FieldOffset(Offset = "0x90")]
	private uint m_AudioID;

	[Token(Token = "0x17000AE8")]
	[field: Token(Token = "0x4009296")]
	[field: FieldOffset(Offset = "0x10")]
	public float SkillIncreaseChanceOnSuccess
	{
		[Token(Token = "0x6007FE2")]
		[Address(RVA = "0x4A7A20", Offset = "0x4A6820", Length = "0x6")]
		get;
		[Token(Token = "0x6007FE3")]
		[Address(RVA = "0x4A7A10", Offset = "0x4A6810", Length = "0x6")]
		set;
	}

	[Token(Token = "0x17000AE9")]
	[field: Token(Token = "0x4009297")]
	[field: FieldOffset(Offset = "0x14")]
	public float SkillIncreaseChanceOnFailure
	{
		[Token(Token = "0x6007FE4")]
		[Address(RVA = "0x4A7A40", Offset = "0x4A6840", Length = "0x6")]
		get;
		[Token(Token = "0x6007FE5")]
		[Address(RVA = "0x4A7A30", Offset = "0x4A6830", Length = "0x6")]
		set;
	}

	[Token(Token = "0x17000AEA")]
	[field: Token(Token = "0x4009298")]
	[field: FieldOffset(Offset = "0x18")]
	public bool InProgress
	{
		[Token(Token = "0x6007FE6")]
		[Address(RVA = "0xC880B0", Offset = "0xC86EB0", Length = "0x5")]
		get;
		[Token(Token = "0x6007FE7")]
		[Address(RVA = "0xF79F70", Offset = "0xF78D70", Length = "0x4")]
		private set;
	}

	[Token(Token = "0x17000AEB")]
	[field: Token(Token = "0x4009299")]
	[field: FieldOffset(Offset = "0x20")]
	public BlueprintData Blueprint
	{
		[Token(Token = "0x6007FE8")]
		[Address(RVA = "0x40E110", Offset = "0x40CF10", Length = "0x5")]
		get;
		[Token(Token = "0x6007FE9")]
		[Address(RVA = "0x40E120", Offset = "0x40CF20", Length = "0x52")]
		private set;
	}

	[Token(Token = "0x17000AEC")]
	public InProgressCraftItem CurrentWorkInProgress
	{
		[Token(Token = "0x6007FEA")]
		[Address(RVA = "0x6BCD40", Offset = "0x6BBB40", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000AED")]
	public ICraftingResult LastCraftedItem
	{
		[Token(Token = "0x6007FEB")]
		[Address(RVA = "0x502330", Offset = "0x501130", Length = "0x8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x14000046")]
	public event Action<CraftingInterruptReason> Interrupted
	{
		[CompilerGenerated]
		[Token(Token = "0x6007FEC")]
		[Address(RVA = "0x11FE9C0", Offset = "0x11FD7C0", Length = "0x166")]
		add
		{
		}
		[CompilerGenerated]
		[Token(Token = "0x6007FED")]
		[Address(RVA = "0x11FEB30", Offset = "0x11FD930", Length = "0x166")]
		remove
		{
		}
	}

	[Token(Token = "0x14000047")]
	public event Action Success
	{
		[CompilerGenerated]
		[Token(Token = "0x6007FEE")]
		[Address(RVA = "0x11FECA0", Offset = "0x11FDAA0", Length = "0xEB")]
		add
		{
		}
		[CompilerGenerated]
		[Token(Token = "0x6007FEF")]
		[Address(RVA = "0x11FED90", Offset = "0x11FDB90", Length = "0xEB")]
		remove
		{
		}
	}

	[Token(Token = "0x14000048")]
	public event Action End
	{
		[CompilerGenerated]
		[Token(Token = "0x6007FF0")]
		[Address(RVA = "0x11FEE80", Offset = "0x11FDC80", Length = "0xEB")]
		add
		{
		}
		[CompilerGenerated]
		[Token(Token = "0x6007FF1")]
		[Address(RVA = "0x11FEF70", Offset = "0x11FDD70", Length = "0xEB")]
		remove
		{
		}
	}

	[Token(Token = "0x6007FF2")]
	[Address(RVA = "0x11FF060", Offset = "0x11FDE60", Length = "0x8B6")]
	public void StartCrafting(MonoBehaviour context, CraftingLocationInterface craftingLocation, BlueprintData blueprintData, InProgressCraftItem workInProgress, float realTimeCraftingDuration, float hoursToSpendCrafting, GearItem tool, int targetQuantity = 1)
	{
	}

	[Token(Token = "0x6007FF3")]
	[Address(RVA = "0x11FF920", Offset = "0x11FE720", Length = "0x8")]
	public void Interrupt(CraftingInterruptReason reason)
	{
	}

	[Token(Token = "0x6007FF4")]
	[Address(RVA = "0x11FF930", Offset = "0x11FE730", Length = "0x39B")]
	public void Update()
	{
	}

	[Token(Token = "0x6007FF5")]
	[Address(RVA = "0x11FFCD0", Offset = "0x11FEAD0", Length = "0x3B8")]
	private void HandleInterrupt(CraftingInterruptReason reason)
	{
	}

	[Token(Token = "0x6007FF6")]
	[Address(RVA = "0x1200090", Offset = "0x11FEE90", Length = "0x66")]
	private void HandleSuccess()
	{
	}

	[Token(Token = "0x6007FF7")]
	[Address(RVA = "0x1200100", Offset = "0x11FEF00", Length = "0xBE")]
	private void HandleEnd()
	{
	}

	[Token(Token = "0x6007FF8")]
	[Address(RVA = "0x12001C0", Offset = "0x11FEFC0", Length = "0x107")]
	private void DegradeTools(float hoursSpentCrafting)
	{
	}

	[Token(Token = "0x6007FF9")]
	[Address(RVA = "0x12002D0", Offset = "0x11FF0D0", Length = "0x886")]
	private void ConsumeMaterialsUsedForCrafting(float hoursSpentCrafting)
	{
	}

	[Token(Token = "0x6007FFA")]
	[Address(RVA = "0x1200B60", Offset = "0x11FF960", Length = "0xBD9")]
	private void ApplyCraftingProgress(float hoursSpentCrafting)
	{
	}

	[Token(Token = "0x6007FFB")]
	[Address(RVA = "0x1201740", Offset = "0x1200540", Length = "0x1B0")]
	private void UpdateSkillAfterCrafting(bool success)
	{
	}

	[Token(Token = "0x6007FFC")]
	[Address(RVA = "0x1201900", Offset = "0x1200700", Length = "0x138")]
	private int GetModifiedCraftingDuration(int baseMinutes)
	{
		return 0;
	}

	[Token(Token = "0x6007FFD")]
	[Address(RVA = "0x1201A40", Offset = "0x1200840", Length = "0x1D7")]
	public static Container GetDestinationContainer(ICraftingResult destinationCraftingResult, CraftingLocationInterface location)
	{
		return null;
	}

	[Token(Token = "0x6007FFE")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public CraftingOperation()
	{
	}
}
