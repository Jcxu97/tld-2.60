using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000319")]
public class TodMaterial : MonoBehaviour
{
	[Token(Token = "0x4001B55")]
	[FieldOffset(Offset = "0x20")]
	public Material m_Material;

	[Token(Token = "0x4001B56")]
	[FieldOffset(Offset = "0x28")]
	public Color m_DayColor;

	[Token(Token = "0x4001B57")]
	[FieldOffset(Offset = "0x38")]
	public Color m_NightColor;

	[Token(Token = "0x4001B58")]
	[FieldOffset(Offset = "0x48")]
	public bool m_StoryOnly;

	[Token(Token = "0x4001B59")]
	[FieldOffset(Offset = "0x4C")]
	private int m_MaterialIndex;

	[Token(Token = "0x4001B5A")]
	[FieldOffset(Offset = "0x50")]
	private bool m_ForcedUpdate;

	[Token(Token = "0x4001B5B")]
	[FieldOffset(Offset = "0x58")]
	private Renderer m_Renderer;

	[Token(Token = "0x4001B5C")]
	private static List<TodMaterial> m_TodMaterials;

	[Token(Token = "0x600194C")]
	[Address(RVA = "0x731190", Offset = "0x72FF90", Length = "0x557")]
	public void Awake()
	{
	}

	[Token(Token = "0x600194D")]
	[Address(RVA = "0x7316F0", Offset = "0x7304F0", Length = "0x204")]
	public void ForceUpdate()
	{
	}

	[Token(Token = "0x600194E")]
	[Address(RVA = "0x731900", Offset = "0x730700", Length = "0x93")]
	public static void Reset()
	{
	}

	[Token(Token = "0x600194F")]
	[Address(RVA = "0x7319A0", Offset = "0x7307A0", Length = "0x22E")]
	public static void UpdateAll()
	{
	}

	[Token(Token = "0x6001950")]
	[Address(RVA = "0x731BD0", Offset = "0x7309D0", Length = "0x1EA")]
	public static void ForceUpdateAll()
	{
	}

	[Token(Token = "0x6001951")]
	[Address(RVA = "0x731DC0", Offset = "0x730BC0", Length = "0xC6")]
	private void UpdateMaterial()
	{
	}

	[Token(Token = "0x6001952")]
	[Address(RVA = "0x731E90", Offset = "0x730C90", Length = "0x2DA")]
	private void UpdateForDawn()
	{
	}

	[Token(Token = "0x6001953")]
	[Address(RVA = "0x732170", Offset = "0x730F70", Length = "0x2DA")]
	private void UpdateForDusk()
	{
	}

	[Token(Token = "0x6001954")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public TodMaterial()
	{
	}
}
