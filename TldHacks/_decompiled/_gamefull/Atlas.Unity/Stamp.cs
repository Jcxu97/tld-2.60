using Cpp2ILInjected;
using UnityEngine;

namespace Atlas.Unity;

[Token(Token = "0x2000D2E")]
public class Stamp : StampBase
{
	[Token(Token = "0x60067BE")]
	[Address(RVA = "0x1053E10", Offset = "0x1052C10", Length = "0x79")]
	public override bool MayDrawIcon(out string path)
	{
		path = null;
		return false;
	}

	[Token(Token = "0x60067BF")]
	[Address(RVA = "0x1053E90", Offset = "0x1052C90", Length = "0xCA")]
	public override bool MayRender()
	{
		return false;
	}

	[Token(Token = "0x60067C0")]
	[Address(RVA = "0x1053F60", Offset = "0x1052D60", Length = "0x30B")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x60067C1")]
	[Address(RVA = "0x1054270", Offset = "0x1053070", Length = "0x42F")]
	public override void DrawGizmos()
	{
	}

	[Token(Token = "0x60067C2")]
	[Address(RVA = "0x10546A0", Offset = "0x10534A0", Length = "0x969")]
	public override void DrawMesh(AtlasStamper stampTerrainBase, bool forMask = false)
	{
	}

	[Token(Token = "0x60067C3")]
	[Address(RVA = "0x104AF80", Offset = "0x1049D80", Length = "0xBD")]
	public void GetCorners(out Vector3 p1, out Vector3 p2, out Vector3 p3, out Vector3 p4)
	{
		p1 = default(Vector3);
		p2 = default(Vector3);
		p3 = default(Vector3);
		p4 = default(Vector3);
	}

	[Token(Token = "0x60067C4")]
	[Address(RVA = "0x104B260", Offset = "0x104A060", Length = "0x7")]
	public Stamp()
	{
	}
}
