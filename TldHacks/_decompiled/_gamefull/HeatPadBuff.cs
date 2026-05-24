using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20004FE")]
public class HeatPadBuff : MonoBehaviour
{
	[Token(Token = "0x4002DC4")]
	[FieldOffset(Offset = "0x20")]
	private readonly List<GearItem> m_AllActiveItems;

	[Token(Token = "0x4002DC5")]
	[FieldOffset(Offset = "0x28")]
	private int m_MaxHeatPadDurationMinutes;

	[Token(Token = "0x4002DC6")]
	[FieldOffset(Offset = "0x2C")]
	private int m_MaxHeatPadNormalizedDuration;

	[Token(Token = "0x4002DC7")]
	[FieldOffset(Offset = "0x30")]
	private float m_MaxHeatPadBonus;

	[Token(Token = "0x4002DC8")]
	[FieldOffset(Offset = "0x38")]
	private GearItem m_WarmestHeatPad;

	[Token(Token = "0x4002DC9")]
	[FieldOffset(Offset = "0x40")]
	private bool m_ShownHeatPadBuffState;

	[Token(Token = "0x1700025B")]
	private string DisplayNameLocID
	{
		[Token(Token = "0x60025DB")]
		[Address(RVA = "0x8990C0", Offset = "0x897EC0", Length = "0x48")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700025C")]
	private string IconSpriteName
	{
		[Token(Token = "0x60025DC")]
		[Address(RVA = "0x899110", Offset = "0x897F10", Length = "0x48")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60025DD")]
	[Address(RVA = "0x899160", Offset = "0x897F60", Length = "0x1B1")]
	public void AddActiveHeatPad(GearItem gearItem)
	{
	}

	[Token(Token = "0x60025DE")]
	[Address(RVA = "0x899320", Offset = "0x898120", Length = "0x133")]
	public bool IsWarmestHeatPad(GearItem gearItem)
	{
		return false;
	}

	[Token(Token = "0x60025DF")]
	[Address(RVA = "0x899460", Offset = "0x898260", Length = "0x45")]
	public bool HasHeatPadBuff()
	{
		return false;
	}

	[Token(Token = "0x60025E0")]
	[Address(RVA = "0x8994B0", Offset = "0x8982B0", Length = "0x9")]
	public float GetHeatPadBuffDurationNormalized()
	{
		return 0f;
	}

	[Token(Token = "0x60025E1")]
	[Address(RVA = "0x4588A0", Offset = "0x4576A0", Length = "0x4")]
	public int GetHeatPadBuffDurationMinutes()
	{
		return 0;
	}

	[Token(Token = "0x60025E2")]
	[Address(RVA = "0x5093E0", Offset = "0x5081E0", Length = "0x6")]
	public float GetCurrentHeatPadBonus()
	{
		return 0f;
	}

	[Token(Token = "0x60025E3")]
	[Address(RVA = "0x8994C0", Offset = "0x8982C0", Length = "0x27A")]
	private void Update()
	{
	}

	[Token(Token = "0x60025E4")]
	[Address(RVA = "0x899740", Offset = "0x898540", Length = "0x2C4")]
	private void UpdateActiveHeatPads()
	{
	}

	[Token(Token = "0x60025E5")]
	[Address(RVA = "0x899A10", Offset = "0x898810", Length = "0xFF")]
	private bool ShouldUpdateBuffNotification()
	{
		return false;
	}

	[Token(Token = "0x60025E6")]
	[Address(RVA = "0x899B10", Offset = "0x898910", Length = "0xE3")]
	public HeatPadBuff()
	{
	}
}
