using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[RequireComponent(typeof(MeshRenderer))]
[RequireComponent(typeof(MeshFilter))]
[ExecuteInEditMode]
[Token(Token = "0x2000130")]
public class qd_Decal : MonoBehaviour
{
	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x400095E")]
	[FieldOffset(Offset = "0x20")]
	private Texture2D _texture;

	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x400095F")]
	[FieldOffset(Offset = "0x28")]
	private Rect _rect;

	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x4000960")]
	[FieldOffset(Offset = "0x38")]
	private float _scale;

	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x4000961")]
	[FieldOffset(Offset = "0x40")]
	private string _decalId;

	[Token(Token = "0x4000962")]
	[FieldOffset(Offset = "0x48")]
	public Material m_fullscreenDecalMaterial;

	[Token(Token = "0x4000963")]
	[FieldOffset(Offset = "0x50")]
	public int m_Layer;

	[Token(Token = "0x4000964")]
	[FieldOffset(Offset = "0x54")]
	public float m_ClipAngleDegrees;

	[Token(Token = "0x4000965")]
	[FieldOffset(Offset = "0x58")]
	private StaticDecal m_StaticDecal;

	[Token(Token = "0x4000966")]
	public static int ID_DecalZTestModeID;

	[Token(Token = "0x4000967")]
	private static Dictionary<Texture, Material> m_QuickDecalMaterials;

	[Token(Token = "0x4000968")]
	private static Dictionary<Texture, Material> m_StaticDecalMaterials;

	[Token(Token = "0x4000969")]
	private static Dictionary<Texture, Material> m_CameraClippedStaticDecalMaterials;

	[Token(Token = "0x170001A0")]
	public Texture2D texture
	{
		[Token(Token = "0x6000B0B")]
		[Address(RVA = "0x40E110", Offset = "0x40CF10", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000B0C")]
	[Address(RVA = "0x5CF2D0", Offset = "0x5CE0D0", Length = "0x1F")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000B0D")]
	[Address(RVA = "0x5CF2F0", Offset = "0x5CE0F0", Length = "0x159")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000B0E")]
	[Address(RVA = "0x5CF450", Offset = "0x5CE250", Length = "0x159")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000B0F")]
	[Address(RVA = "0x5CF5B0", Offset = "0x5CE3B0", Length = "0x6")]
	public void SetScale(float scale)
	{
	}

	[Token(Token = "0x6000B10")]
	[Address(RVA = "0x40E120", Offset = "0x40CF20", Length = "0x52")]
	public void SetTexture(Texture2D tex)
	{
	}

	[Token(Token = "0x6000B11")]
	[Address(RVA = "0x4D0B00", Offset = "0x4CF900", Length = "0x52")]
	public void SetDecalId(string decalId)
	{
	}

	[Token(Token = "0x6000B12")]
	[Address(RVA = "0x4A7D60", Offset = "0x4A6B60", Length = "0x5")]
	public string GetDecalId()
	{
		return null;
	}

	[Token(Token = "0x6000B13")]
	[Address(RVA = "0x4D0B60", Offset = "0x4CF960", Length = "0x52")]
	public void SetFullScreenDecalMaterial(Material mat)
	{
	}

	[Token(Token = "0x6000B14")]
	[Address(RVA = "0x5CF5C0", Offset = "0x5CE3C0", Length = "0x187")]
	public void SetUVRect(Rect r)
	{
	}

	[Token(Token = "0x6000B15")]
	[Address(RVA = "0x5CF750", Offset = "0x5CE550", Length = "0x3C6")]
	public void FreezeTransform()
	{
	}

	[Token(Token = "0x6000B16")]
	[Address(RVA = "0x5CFB20", Offset = "0x5CE920", Length = "0x50D")]
	public void Verify()
	{
	}

	[Token(Token = "0x6000B17")]
	[Address(RVA = "0x5D0030", Offset = "0x5CEE30", Length = "0x143")]
	private void MaybeUpdateUvsFromDecalManager()
	{
	}

	[Token(Token = "0x6000B18")]
	[Address(RVA = "0x5D0180", Offset = "0x5CEF80", Length = "0x9FC")]
	private void RefreshStaticDecal()
	{
	}

	[Token(Token = "0x6000B19")]
	[Address(RVA = "0x5D0B80", Offset = "0x5CF980", Length = "0xF")]
	public Material GetStaticDecalMaterial()
	{
		return null;
	}

	[Token(Token = "0x6000B1A")]
	[Address(RVA = "0x5D0B90", Offset = "0x5CF990", Length = "0x18D")]
	public static Material GetQuickDecalMaterial(Texture texture)
	{
		return null;
	}

	[Token(Token = "0x6000B1B")]
	[Address(RVA = "0x5D0D20", Offset = "0x5CFB20", Length = "0x63")]
	public static string GetAtlasUvPathWithoutExtensionFromPngPath(string texturePath)
	{
		return null;
	}

	[Token(Token = "0x6000B1C")]
	[Address(RVA = "0x5D0D90", Offset = "0x5CFB90", Length = "0x307")]
	private Vector3 GetDecalScale()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000B1D")]
	[Address(RVA = "0x5D10A0", Offset = "0x5CFEA0", Length = "0xC4")]
	public qd_Decal()
	{
	}
}
