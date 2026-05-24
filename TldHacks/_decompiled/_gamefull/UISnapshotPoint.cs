using Cpp2ILInjected;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("NGUI/Internal/Snapshot Point")]
[Token(Token = "0x20000D5")]
public class UISnapshotPoint : MonoBehaviour
{
	[Token(Token = "0x40006CA")]
	[FieldOffset(Offset = "0x20")]
	public bool isOrthographic;

	[Token(Token = "0x40006CB")]
	[FieldOffset(Offset = "0x24")]
	public float nearClip;

	[Token(Token = "0x40006CC")]
	[FieldOffset(Offset = "0x28")]
	public float farClip;

	[Range(10f, 80f)]
	[Token(Token = "0x40006CD")]
	[FieldOffset(Offset = "0x2C")]
	public int fieldOfView;

	[Token(Token = "0x40006CE")]
	[FieldOffset(Offset = "0x30")]
	public float orthoSize;

	[Token(Token = "0x40006CF")]
	[FieldOffset(Offset = "0x38")]
	public Texture2D thumbnail;

	[Token(Token = "0x600079E")]
	[Address(RVA = "0x111BFC0", Offset = "0x111ADC0", Length = "0xAE")]
	private void Start()
	{
	}

	[Token(Token = "0x600079F")]
	[Address(RVA = "0x111C070", Offset = "0x111AE70", Length = "0x63")]
	public UISnapshotPoint()
	{
	}
}
