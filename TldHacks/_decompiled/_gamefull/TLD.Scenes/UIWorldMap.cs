using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace TLD.Scenes;

[RequireComponent(typeof(UITexture))]
[Token(Token = "0x2001365")]
public class UIWorldMap : MonoBehaviour
{
	[SerializeField]
	[Token(Token = "0x4008EB9")]
	[FieldOffset(Offset = "0x20")]
	private AssetReferenceTexture2D m_MapTexture;

	[Token(Token = "0x4008EBA")]
	[FieldOffset(Offset = "0x28")]
	private UITexture m_target;

	[Token(Token = "0x4008EBB")]
	[FieldOffset(Offset = "0x30")]
	private AsyncOperationHandle<Texture2D> m_asyncOp;

	[Token(Token = "0x6007BD6")]
	[Address(RVA = "0x11ABC30", Offset = "0x11AAA30", Length = "0x42")]
	private void Awake()
	{
	}

	[Token(Token = "0x6007BD7")]
	[Address(RVA = "0x11ABC80", Offset = "0x11AAA80", Length = "0x7")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6007BD8")]
	[Address(RVA = "0x11ABC90", Offset = "0x11AAA90", Length = "0xF0")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6007BD9")]
	[Address(RVA = "0x11ABD80", Offset = "0x11AAB80", Length = "0x204")]
	public void LoadMap()
	{
	}

	[Token(Token = "0x6007BDA")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public UIWorldMap()
	{
	}
}
