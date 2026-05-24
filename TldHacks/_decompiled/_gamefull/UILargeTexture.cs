using Cpp2ILInjected;
using UnityEngine;

[RequireComponent(typeof(UITexture))]
[Token(Token = "0x20006EC")]
internal class UILargeTexture : MonoBehaviour
{
	[Token(Token = "0x40049C7")]
	[FieldOffset(Offset = "0x20")]
	public string m_AssetName;

	[AutoComponent(ComponentRequirement.Required)]
	[SerializeField]
	[Token(Token = "0x40049C8")]
	[FieldOffset(Offset = "0x28")]
	private UITexture m_UITexture;

	[Token(Token = "0x40049C9")]
	[FieldOffset(Offset = "0x30")]
	private Texture2D m_LoadedTexture;

	[Token(Token = "0x6003CE4")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	private void OnValidate()
	{
	}

	[Token(Token = "0x6003CE5")]
	[Address(RVA = "0xB859E0", Offset = "0xB847E0", Length = "0xD3")]
	public void OnEnable()
	{
	}

	[Token(Token = "0x6003CE6")]
	[Address(RVA = "0xB85AC0", Offset = "0xB848C0", Length = "0x79")]
	public void OnDisable()
	{
	}

	[Token(Token = "0x6003CE7")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public UILargeTexture()
	{
	}
}
