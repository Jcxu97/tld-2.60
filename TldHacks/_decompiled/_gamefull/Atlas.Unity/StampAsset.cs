using Cpp2ILInjected;
using UnityEngine;

namespace Atlas.Unity;

[CreateAssetMenu(fileName = "StampAsset", menuName = "Atlas/Unity/Stamp Asset", order = 0)]
[Token(Token = "0x2000D2F")]
public class StampAsset : ScriptableObject
{
	[Token(Token = "0x400823F")]
	[FieldOffset(Offset = "0x18")]
	public Texture2D height;

	[Token(Token = "0x4008240")]
	[FieldOffset(Offset = "0x20")]
	public Texture2D color;

	[Tooltip("Main mask of the stamp.")]
	[Token(Token = "0x4008241")]
	[FieldOffset(Offset = "0x28")]
	public Texture2D mask;

	[Token(Token = "0x4008242")]
	[FieldOffset(Offset = "0x30")]
	public Texture2D splat1;

	[Token(Token = "0x4008243")]
	[FieldOffset(Offset = "0x38")]
	public Texture2D splat2;

	[Tooltip("Used exclusively for road blending, this mask is usually a copy of the main mask but narrower.")]
	[Token(Token = "0x4008244")]
	[FieldOffset(Offset = "0x40")]
	public Texture2D roadMask;

	[Token(Token = "0x60067C5")]
	[Address(RVA = "0x4A22A0", Offset = "0x4A10A0", Length = "0x7")]
	public StampAsset()
	{
	}
}
