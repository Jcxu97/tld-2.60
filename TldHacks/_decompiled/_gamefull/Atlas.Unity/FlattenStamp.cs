using Cpp2ILInjected;
using UnityEngine;

namespace Atlas.Unity;

[AddComponentMenu(null)]
[Token(Token = "0x2000D20")]
public class FlattenStamp : StampBase
{
	[Token(Token = "0x600678E")]
	[Address(RVA = "0xF1D490", Offset = "0xF1C290", Length = "0x54")]
	public override bool MayDrawIcon(out string fileName)
	{
		fileName = null;
		return false;
	}

	[Token(Token = "0x600678F")]
	[Address(RVA = "0x430B50", Offset = "0x42F950", Length = "0x3")]
	public override bool MayRender()
	{
		return false;
	}

	[Token(Token = "0x6006790")]
	[Address(RVA = "0x104A610", Offset = "0x1049410", Length = "0x969")]
	public override void DrawMesh(AtlasStamper stampTerrainBase, bool forMask = false)
	{
	}

	[Token(Token = "0x6006791")]
	[Address(RVA = "0x104AF80", Offset = "0x1049D80", Length = "0xBD")]
	public void GetCorners(out Vector3 p1, out Vector3 p2, out Vector3 p3, out Vector3 p4)
	{
		p1 = default(Vector3);
		p2 = default(Vector3);
		p3 = default(Vector3);
		p4 = default(Vector3);
	}

	[Token(Token = "0x6006792")]
	[Address(RVA = "0x104B040", Offset = "0x1049E40", Length = "0x21F")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x6006793")]
	[Address(RVA = "0x104B260", Offset = "0x104A060", Length = "0x7")]
	public FlattenStamp()
	{
	}
}
