using Cpp2ILInjected;

namespace TLD.Placement;

[Token(Token = "0x200137D")]
public static class PlaceMeshRulesExtensions
{
	[Token(Token = "0x4008F45")]
	private const PlaceMeshRules FORCE_FLOOR_MASK = PlaceMeshRules.Default | PlaceMeshRules.AllowWallPlacement;

	[Token(Token = "0x4008F46")]
	private const PlaceMeshRules FORCE_WALL_MASK = PlaceMeshRules.Default | PlaceMeshRules.AllowFloorPlacement;

	[Token(Token = "0x6007C73")]
	[Address(RVA = "0x11B82D0", Offset = "0x11B70D0", Length = "0x7")]
	public static bool AllowWallPlacement(this PlaceMeshRules rules)
	{
		return false;
	}

	[Token(Token = "0x6007C74")]
	[Address(RVA = "0x11B82E0", Offset = "0x11B70E0", Length = "0xF")]
	public static bool ForceWallPlacement(this PlaceMeshRules rules)
	{
		return false;
	}

	[Token(Token = "0x6007C75")]
	[Address(RVA = "0x11B82F0", Offset = "0x11B70F0", Length = "0x7")]
	public static bool AllowFloorPlacement(this PlaceMeshRules rules)
	{
		return false;
	}

	[Token(Token = "0x6007C76")]
	[Address(RVA = "0x11B8300", Offset = "0x11B7100", Length = "0xF")]
	public static bool ForceFloorPlacement(this PlaceMeshRules rules)
	{
		return false;
	}
}
