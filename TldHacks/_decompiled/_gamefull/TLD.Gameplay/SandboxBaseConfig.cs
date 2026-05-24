using Cpp2ILInjected;
using TLD.Scenes;
using UnityEngine;

namespace TLD.Gameplay;

[Token(Token = "0x2001495")]
public abstract class SandboxBaseConfig : GameModeConfig
{
	[Token(Token = "0x4009544")]
	private const int NUM_GAMES_BEFORE_INDOOR_START = 1;

	[Token(Token = "0x4009545")]
	private const string DEFAULT_POST_LOAD_COMMMAND = "mission_jump null false";

	[Header("Shared Sandbox Properties")]
	[Range(0f, 1f)]
	[Token(Token = "0x4009546")]
	[FieldOffset(Offset = "0x70")]
	public float m_IndoorStartChance;

	[Token(Token = "0x4009547")]
	[FieldOffset(Offset = "0x78")]
	public RegionSpecification[] m_AvailableStartRegions;

	[Token(Token = "0x4009548")]
	[FieldOffset(Offset = "0x80")]
	public string m_PostLoadCommand;

	[Token(Token = "0x4009549")]
	[FieldOffset(Offset = "0x88")]
	public SceneSet m_ForceSceneLoad;

	[Token(Token = "0x400954A")]
	[FieldOffset(Offset = "0x90")]
	public string m_ForceSpawnPoint;

	[Token(Token = "0x400954B")]
	[FieldOffset(Offset = "0x98")]
	public bool m_SaveAfterLoad;

	[Token(Token = "0x60082AB")]
	[Address(RVA = "0x123BDB0", Offset = "0x123ABB0", Length = "0x16B")]
	public bool IsValidStartingRegion(RegionSpecification region)
	{
		return false;
	}

	[Token(Token = "0x60082AC")]
	[Address(RVA = "0x123BF20", Offset = "0x123AD20", Length = "0x190")]
	public RegionSpecification ValidateStartingRegion(RegionSpecification requestedRegion)
	{
		return null;
	}

	[Token(Token = "0x60082AD")]
	[Address(RVA = "0x123C0C0", Offset = "0x123AEC0", Length = "0x9D")]
	public RegionSpecification GetRandomStartingRegion()
	{
		return null;
	}

	[Token(Token = "0x60082AE")]
	[Address(RVA = "0x123C160", Offset = "0x123AF60", Length = "0x176")]
	public virtual bool CanSpawnIndoors()
	{
		return false;
	}

	[Token(Token = "0x60082AF")]
	[Address(RVA = "0x123C2E0", Offset = "0x123B0E0", Length = "0x2F7")]
	public SceneSet GetSpawnSceneSet(RegionSpecification region)
	{
		return null;
	}

	[Token(Token = "0x60082B0")]
	[Address(RVA = "0x123C5E0", Offset = "0x123B3E0", Length = "0x14E")]
	private bool ShouldSpawnIndoors(RegionSpecification region)
	{
		return false;
	}

	[Token(Token = "0x60082B1")]
	[Address(RVA = "0x123C730", Offset = "0x123B530", Length = "0x3D8")]
	private static RegionSpecification GetRandomRegionFromAllAvailable()
	{
		return null;
	}

	[Token(Token = "0x60082B2")]
	[Address(RVA = "0x123CB10", Offset = "0x123B910", Length = "0xB5")]
	protected SandboxBaseConfig()
	{
	}
}
