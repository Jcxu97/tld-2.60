using System;
using Cpp2ILInjected;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions;

[Name("Set Cinematic Properties", 0)]
[Description("Set Cinematic Properties.")]
[Category("TLD Actions/Cinematic")]
[Token(Token = "0x2001233")]
public class Action_SetCinematicProperties : ActionTask
{
	[Token(Token = "0x2001234")]
	public enum CinematicPropertyType
	{
		[Token(Token = "0x4008A36")]
		Invulnerable,
		[Token(Token = "0x4008A37")]
		LockPlayer,
		[Token(Token = "0x4008A38")]
		PreventRadialUse,
		[Token(Token = "0x4008A39")]
		PassesTime,
		[Token(Token = "0x4008A3A")]
		HidesHUD,
		[Token(Token = "0x4008A3B")]
		HidesGameplayUIEffects,
		[Token(Token = "0x4008A3C")]
		StowItems,
		[Token(Token = "0x4008A3D")]
		DisableDiscoveryText,
		[Token(Token = "0x4008A3E")]
		ForceWildlifeToFlee,
		[Token(Token = "0x4008A3F")]
		SuspendPlayerConditionUpdate,
		[Token(Token = "0x4008A40")]
		DisableAllSystemSpeech,
		[Token(Token = "0x4008A41")]
		BoostAurora
	}

	[Token(Token = "0x2001235")]
	public enum LockPlayerType
	{
		[Token(Token = "0x4008A43")]
		All,
		[Token(Token = "0x4008A44")]
		MovementOnly,
		[Token(Token = "0x4008A45")]
		Unlocked
	}

	[Serializable]
	[Token(Token = "0x2001236")]
	public class Properties
	{
		[Token(Token = "0x4008A46")]
		[FieldOffset(Offset = "0x10")]
		public bool invulnerable;

		[Token(Token = "0x4008A47")]
		[FieldOffset(Offset = "0x11")]
		public bool lockPlayer;

		[Token(Token = "0x4008A48")]
		[FieldOffset(Offset = "0x14")]
		public LockPlayerType lockingType;

		[Token(Token = "0x4008A49")]
		[FieldOffset(Offset = "0x18")]
		public bool preventRadialUse;

		[Token(Token = "0x4008A4A")]
		[FieldOffset(Offset = "0x19")]
		public bool passesTime;

		[Token(Token = "0x4008A4B")]
		[FieldOffset(Offset = "0x1C")]
		public int timePassedHours;

		[Token(Token = "0x4008A4C")]
		[FieldOffset(Offset = "0x20")]
		public bool hidesHUD;

		[Token(Token = "0x4008A4D")]
		[FieldOffset(Offset = "0x21")]
		public bool hidesGameplayUIEffects;

		[Token(Token = "0x4008A4E")]
		[FieldOffset(Offset = "0x22")]
		public bool stowItems;

		[Token(Token = "0x4008A4F")]
		[FieldOffset(Offset = "0x23")]
		public bool disableDiscoveryText;

		[Token(Token = "0x4008A50")]
		[FieldOffset(Offset = "0x24")]
		public bool forceWildlifeToFlee;

		[Token(Token = "0x4008A51")]
		[FieldOffset(Offset = "0x25")]
		public bool suspendPlayerConditionUpdate;

		[Token(Token = "0x4008A52")]
		[FieldOffset(Offset = "0x26")]
		public bool disableAllSystemSpeech;

		[Token(Token = "0x4008A53")]
		[FieldOffset(Offset = "0x27")]
		public bool boostAurora;

		[Token(Token = "0x600776E")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public Properties()
		{
		}
	}

	[Token(Token = "0x4008A32")]
	[FieldOffset(Offset = "0x68")]
	public bool setState;

	[Token(Token = "0x4008A33")]
	[FieldOffset(Offset = "0x70")]
	public Properties properties;

	[Token(Token = "0x4008A34")]
	private static Rest.PassTimeHelper s_PassTimeHelper;

	[Token(Token = "0x17000987")]
	protected override string info
	{
		[Token(Token = "0x6007767")]
		[Address(RVA = "0x115BCC0", Offset = "0x115AAC0", Length = "0x54")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007768")]
	[Address(RVA = "0x115BD20", Offset = "0x115AB20", Length = "0x726")]
	protected override void OnExecute()
	{
	}

	[Token(Token = "0x6007769")]
	[Address(RVA = "0x115C450", Offset = "0x115B250", Length = "0x6C")]
	protected override void OnUpdate()
	{
	}

	[Token(Token = "0x600776A")]
	[Address(RVA = "0x115C4C0", Offset = "0x115B2C0", Length = "0x9C")]
	public static void SetProperty(CinematicPropertyType type, bool isSet, int argValue)
	{
	}

	[Token(Token = "0x600776B")]
	[Address(RVA = "0x179CBB0", Offset = "0x179B9B0", Length = "0x52")]
	private static bool TryGetPanel<T>(out T panel) where T : Panel_Base
	{
		panel = null;
		return false;
	}

	[Token(Token = "0x600776C")]
	[Address(RVA = "0xD769F0", Offset = "0xD757F0", Length = "0x8")]
	public Action_SetCinematicProperties()
	{
	}
}
