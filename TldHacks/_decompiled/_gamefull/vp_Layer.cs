using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000015")]
public sealed class vp_Layer
{
	[Token(Token = "0x40001B1")]
	public static readonly vp_Layer instance;

	[Token(Token = "0x40001B2")]
	public const int TriggerReverb = 31;

	[Token(Token = "0x40001B3")]
	public const int TriggerCollideCapsule = 30;

	[Token(Token = "0x40001B4")]
	public const int InspectGear = 29;

	[Token(Token = "0x40001B5")]
	public const int GroundNoNavmesh = 28;

	[Token(Token = "0x40001B6")]
	public const int NPCBones = 27;

	[Token(Token = "0x40001B7")]
	public const int CharacterControllerCollideOnly = 26;

	[Token(Token = "0x40001B8")]
	public const int TriggerIgnoreRaycast = 25;

	[Token(Token = "0x40001B9")]
	public const int InteractivePropNoCollidePlayer = 24;

	[Token(Token = "0x40001BA")]
	public const int Weapon = 23;

	[Token(Token = "0x40001BB")]
	public const int SoundEmitter = 22;

	[Token(Token = "0x40001BC")]
	public const int Trigger = 21;

	[Token(Token = "0x40001BD")]
	public const int Corpse = 20;

	[Token(Token = "0x40001BE")]
	public const int InteractiveProp = 19;

	[Token(Token = "0x40001BF")]
	public const int Container = 18;

	[Token(Token = "0x40001C0")]
	public const int Gear = 17;

	[Token(Token = "0x40001C1")]
	public const int NPC = 16;

	[Token(Token = "0x40001C2")]
	public const int NoCollidePlayer = 15;

	[Token(Token = "0x40001C3")]
	public const int Player = 14;

	[Token(Token = "0x40001C4")]
	public const int ParticleKiller = 13;

	[Token(Token = "0x40001C5")]
	public const int InteractivePropNoCollideGear = 12;

	[Token(Token = "0x40001C6")]
	public const int Buildings = 11;

	[Token(Token = "0x40001C7")]
	public const int NPC_Trigger = 10;

	[Token(Token = "0x40001C8")]
	public const int TerrainObject = 9;

	[Token(Token = "0x40001C9")]
	public const int Ground = 8;

	[Token(Token = "0x40001CA")]
	public const int Decoration = 6;

	[Token(Token = "0x40001CB")]
	public const int UI = 5;

	[Token(Token = "0x40001CC")]
	public const int Water = 4;

	[Token(Token = "0x40001CD")]
	public const int IgnoreRaycast = 2;

	[Token(Token = "0x40001CE")]
	public const int TransparentFX = 1;

	[Token(Token = "0x40001CF")]
	public const int Default = 0;

	[Token(Token = "0x6000178")]
	[Address(RVA = "0x573490", Offset = "0x572290", Length = "0x96")]
	static vp_Layer()
	{
	}

	[Token(Token = "0x6000179")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	private vp_Layer()
	{
	}

	[Token(Token = "0x600017A")]
	[Address(RVA = "0x573530", Offset = "0x572330", Length = "0x28F")]
	public static void Set(GameObject obj, int layer, bool recursive = false)
	{
	}
}
