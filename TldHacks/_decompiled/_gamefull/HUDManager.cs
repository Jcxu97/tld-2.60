using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using TLD.Logging;
using TLD.UI.Generics;
using UnityEngine;

[Token(Token = "0x200075A")]
public class HUDManager : MonoBehaviour
{
	[CompilerGenerated]
	[Token(Token = "0x200075B")]
	private sealed class _003CWaitToShowLocationReveal_003Ed__27 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4004E7F")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4004E80")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4004E81")]
		[FieldOffset(Offset = "0x20")]
		public HUDManager _003C_003E4__this;

		[Token(Token = "0x17000322")]
		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			[Token(Token = "0x60043AD")]
			[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000323")]
		object IEnumerator.Current
		{
			[DebuggerHidden]
			[Token(Token = "0x60043AF")]
			[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		[Token(Token = "0x60043AA")]
		[Address(RVA = "0x4096E0", Offset = "0x4084E0", Length = "0x4")]
		public _003CWaitToShowLocationReveal_003Ed__27(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[Token(Token = "0x60043AB")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		void IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60043AC")]
		[Address(RVA = "0xC5DDB0", Offset = "0xC5CBB0", Length = "0x67B")]
		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		[Token(Token = "0x60043AE")]
		[Address(RVA = "0xC5E430", Offset = "0xC5D230", Length = "0x3E")]
		void IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4004E73")]
	private static LogFilter s_LogFilter;

	[SerializeField]
	[Token(Token = "0x4004E74")]
	[FieldOffset(Offset = "0x20")]
	private PanelReference<Panel_HUD> m_HUD;

	[SerializeField]
	[Token(Token = "0x4004E75")]
	[FieldOffset(Offset = "0x28")]
	private PanelReference<Panel_Loading> m_Loading;

	[SerializeField]
	[Token(Token = "0x4004E76")]
	[FieldOffset(Offset = "0x30")]
	private PanelReference<Panel_OptionsMenu> m_OptionsMenu;

	[Token(Token = "0x4004E78")]
	public static float m_AmmoGaugeDisplayTime;

	[Token(Token = "0x4004E79")]
	public static bool m_ShowDebugInfo;

	[Token(Token = "0x4004E7A")]
	public static bool m_ShowDaysSurvived;

	[Token(Token = "0x4004E7B")]
	private static string m_SlotToLoadOnStart;

	[Token(Token = "0x4004E7C")]
	[FieldOffset(Offset = "0x38")]
	private float m_CrosshairAlpha;

	[Token(Token = "0x4004E7D")]
	[FieldOffset(Offset = "0x3C")]
	private float Crosshair_FadeTimeSeconds;

	[Token(Token = "0x4004E7E")]
	private static HudManagerSaveDataProxy m_HudManagerSaveDataProxy;

	[Token(Token = "0x17000321")]
	[field: Token(Token = "0x4004E77")]
	public static HudDisplayMode HudDisplayMode
	{
		[Token(Token = "0x6004397")]
		[Address(RVA = "0xC5AED0", Offset = "0xC59CD0", Length = "0x53")]
		get;
		[Token(Token = "0x6004398")]
		[Address(RVA = "0xC5AF30", Offset = "0xC59D30", Length = "0x58")]
		private set;
	}

	[Token(Token = "0x6004399")]
	[Address(RVA = "0xC5AF90", Offset = "0xC59D90", Length = "0x171")]
	public IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x600439A")]
	[Address(RVA = "0xC5B110", Offset = "0xC59F10", Length = "0x178")]
	public void Update()
	{
	}

	[Token(Token = "0x600439B")]
	[Address(RVA = "0xC5B290", Offset = "0xC5A090", Length = "0x95")]
	public void LateUpdate()
	{
	}

	[Token(Token = "0x600439C")]
	[Address(RVA = "0xC5B330", Offset = "0xC5A130", Length = "0xE6")]
	public static string Serialize()
	{
		return null;
	}

	[Token(Token = "0x600439D")]
	[Address(RVA = "0xC5B420", Offset = "0xC5A220", Length = "0x188")]
	public static void Deserialize(string text)
	{
	}

	[Token(Token = "0x600439E")]
	[Address(RVA = "0xC5B5B0", Offset = "0xC5A3B0", Length = "0x1920")]
	public void UpdateDebugLines(Panel_HUD hud)
	{
	}

	[Token(Token = "0x600439F")]
	[Address(RVA = "0xC5CEE0", Offset = "0xC5BCE0", Length = "0xC2")]
	public static bool DoNotRenderHUD()
	{
		return false;
	}

	[Token(Token = "0x60043A0")]
	[Address(RVA = "0xC5CFB0", Offset = "0xC5BDB0", Length = "0x98")]
	public static void SetHUDDisplayMode(HudDisplayMode newDisplayMode)
	{
	}

	[Token(Token = "0x60043A1")]
	[Address(RVA = "0xC5D050", Offset = "0xC5BE50", Length = "0xD2")]
	public static void DisplayAmmoOnHUDForTime(float seconds)
	{
	}

	[Token(Token = "0x60043A2")]
	[Address(RVA = "0xC5D130", Offset = "0xC5BF30", Length = "0x701")]
	private void UpdateCrosshair(Panel_HUD hud)
	{
	}

	[Token(Token = "0x60043A3")]
	[Address(RVA = "0xC5D840", Offset = "0xC5C640", Length = "0xF8")]
	private bool ShouldHideCrossHairs(Panel_HUD hud)
	{
		return false;
	}

	[Token(Token = "0x60043A4")]
	[Address(RVA = "0x430B50", Offset = "0x42F950", Length = "0x3")]
	private bool CanEnableHud()
	{
		return false;
	}

	[IteratorStateMachine(typeof(_003CWaitToShowLocationReveal_003Ed__27))]
	[Token(Token = "0x60043A5")]
	[Address(RVA = "0xC5D940", Offset = "0xC5C740", Length = "0x9A")]
	private IEnumerator WaitToShowLocationReveal()
	{
		return null;
	}

	[Token(Token = "0x60043A6")]
	[Address(RVA = "0xC5D9E0", Offset = "0xC5C7E0", Length = "0xDC")]
	private void TrackIndoorLocation(string location, bool isLocationNew)
	{
	}

	[Token(Token = "0x60043A7")]
	[Address(RVA = "0xC5DAC0", Offset = "0xC5C8C0", Length = "0xE3")]
	private bool CheckIfLoadingNewLocation()
	{
		return false;
	}

	[Token(Token = "0x60043A8")]
	[Address(RVA = "0xC5DBB0", Offset = "0xC5C9B0", Length = "0x4A")]
	public HUDManager()
	{
	}
}
