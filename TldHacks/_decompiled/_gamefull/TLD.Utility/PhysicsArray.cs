using Cpp2ILInjected;

namespace TLD.Utility;

[Token(Token = "0x200134A")]
public class PhysicsArray<T>
{
	[Token(Token = "0x4008E2C")]
	private const int MAX_PHYSICS_HITS = 32;

	[Token(Token = "0x4008E2D")]
	[FieldOffset(Offset = "0x0")]
	private readonly T[] m_Array;

	[Token(Token = "0x17000A4F")]
	public T[] Array
	{
		[Token(Token = "0x6007B71")]
		[Address(RVA = "0x49DED0", Offset = "0x49CCD0", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007B72")]
	[Address(RVA = "0x1E6ADD0", Offset = "0x1E69BD0", Length = "0x87")]
	public PhysicsArray()
	{
	}
}
