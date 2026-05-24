using Cpp2ILInjected;
using UnityEngine;

namespace VLB;

[Token(Token = "0x2000BE1")]
public class PolygonHelper : MonoBehaviour
{
	[Token(Token = "0x2000BE2")]
	public struct Plane2D
	{
		[Token(Token = "0x400795C")]
		[FieldOffset(Offset = "0x0")]
		public Vector2 normal;

		[Token(Token = "0x400795D")]
		[FieldOffset(Offset = "0x8")]
		public float distance;

		[Token(Token = "0x6005DAC")]
		[Address(RVA = "0xF690B0", Offset = "0xF67EB0", Length = "0x2E")]
		public float Distance(Vector2 point)
		{
			return 0f;
		}

		[Token(Token = "0x6005DAD")]
		[Address(RVA = "0xF690E0", Offset = "0xF67EE0", Length = "0x69")]
		public Vector2 ClosestPoint(Vector2 pt)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6005DAE")]
		[Address(RVA = "0xF69150", Offset = "0xF67F50", Length = "0xE8")]
		public Vector2 Intersect(Vector2 p1, Vector2 p2)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6005DAF")]
		[Address(RVA = "0xF69240", Offset = "0xF68040", Length = "0x37")]
		public bool GetSide(Vector2 point)
		{
			return false;
		}

		[Token(Token = "0x6005DB0")]
		[Address(RVA = "0xF69280", Offset = "0xF68080", Length = "0x14B")]
		public static Plane2D FromPoints(Vector3 p1, Vector3 p2)
		{
			return default(Plane2D);
		}

		[Token(Token = "0x6005DB1")]
		[Address(RVA = "0xF693D0", Offset = "0xF681D0", Length = "0x44")]
		public static Plane2D FromNormalAndPoint(Vector3 normalizedNormal, Vector3 p1)
		{
			return default(Plane2D);
		}

		[Token(Token = "0x6005DB2")]
		[Address(RVA = "0xF69420", Offset = "0xF68220", Length = "0x2C")]
		public void Flip()
		{
		}

		[Token(Token = "0x6005DB3")]
		[Address(RVA = "0xF69450", Offset = "0xF68250", Length = "0x24C")]
		public Vector2[] CutConvex(Vector2[] poly)
		{
			return null;
		}

		[Token(Token = "0x6005DB4")]
		[Address(RVA = "0xF696A0", Offset = "0xF684A0", Length = "0x106")]
		public override string ToString()
		{
			return null;
		}
	}

	[Token(Token = "0x6005DAB")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public PolygonHelper()
	{
	}
}
