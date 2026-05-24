using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20002B2")]
public class FramedPhoto : DecorationItem
{
	[Token(Token = "0x40017F0")]
	private static readonly List<FramedPhoto> s_AllFramedPhotos;

	[Header("Framed Photo")]
	[SerializeField]
	[Token(Token = "0x40017F1")]
	[FieldOffset(Offset = "0x108")]
	private MeshRenderer m_PhotoRenderer;

	[SerializeField]
	[Token(Token = "0x40017F2")]
	[FieldOffset(Offset = "0x110")]
	private int m_PhotoMaterialIndex;

	[Token(Token = "0x40017F3")]
	[FieldOffset(Offset = "0x118")]
	private FramedPhotoState m_State;

	[Token(Token = "0x40017F4")]
	[FieldOffset(Offset = "0x120")]
	private Material[] m_Materials;

	[Token(Token = "0x170001F0")]
	[field: Token(Token = "0x40017F5")]
	[field: FieldOffset(Offset = "0x128")]
	public Texture PhotoTexture
	{
		[Token(Token = "0x60016ED")]
		[Address(RVA = "0x6C49F0", Offset = "0x6C37F0", Length = "0x8")]
		get;
		[Token(Token = "0x60016EE")]
		[Address(RVA = "0x6C4A00", Offset = "0x6C3800", Length = "0x52")]
		private set;
	}

	[Token(Token = "0x60016EF")]
	[Address(RVA = "0x6C4A60", Offset = "0x6C3860", Length = "0x493")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x60016F0")]
	[Address(RVA = "0x6C4F00", Offset = "0x6C3D00", Length = "0x374")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x60016F1")]
	[Address(RVA = "0x6C5280", Offset = "0x6C4080", Length = "0x245")]
	public static List<FramedPhotoState> SerializeFramedPhotos()
	{
		return null;
	}

	[Token(Token = "0x60016F2")]
	[Address(RVA = "0x6C54D0", Offset = "0x6C42D0", Length = "0x25A")]
	public static void DeserializeFramedPhotos(List<FramedPhotoState> states)
	{
	}

	[Token(Token = "0x60016F3")]
	[Address(RVA = "0x699260", Offset = "0x698060", Length = "0x8")]
	private FramedPhotoState Serialize()
	{
		return null;
	}

	[Token(Token = "0x60016F4")]
	[Address(RVA = "0x6C5730", Offset = "0x6C4530", Length = "0xCA")]
	private void Deserialize(FramedPhotoState state)
	{
	}

	[Token(Token = "0x60016F5")]
	[Address(RVA = "0x6C5800", Offset = "0x6C4600", Length = "0xDA")]
	public void SetPhoto(string photoID)
	{
	}

	[Token(Token = "0x60016F6")]
	[Address(RVA = "0x6C58E0", Offset = "0x6C46E0", Length = "0xBA")]
	public FramedPhoto()
	{
	}
}
