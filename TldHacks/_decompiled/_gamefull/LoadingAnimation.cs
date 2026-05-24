using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;

[Token(Token = "0x20005F3")]
public class LoadingAnimation : MonoBehaviour
{
	[Token(Token = "0x40036E9")]
	[FieldOffset(Offset = "0x20")]
	private UISpriteAnimation m_SpriteAnimation;

	[Token(Token = "0x40036EA")]
	[FieldOffset(Offset = "0x28")]
	private UIAtlas m_Atlas;

	[Token(Token = "0x40036EB")]
	[FieldOffset(Offset = "0x30")]
	private AsyncOperationHandle<GameObject> m_AtlasHandle;

	[Token(Token = "0x40036EC")]
	[FieldOffset(Offset = "0x48")]
	private bool m_RebuildSprites;

	[Token(Token = "0x6002DFF")]
	[Address(RVA = "0x95CA20", Offset = "0x95B820", Length = "0x233")]
	private void Awake()
	{
	}

	[Token(Token = "0x6002E00")]
	[Address(RVA = "0x95CC60", Offset = "0x95BA60", Length = "0x398")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6002E01")]
	[Address(RVA = "0x95D000", Offset = "0x95BE00", Length = "0x108")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6002E02")]
	[Address(RVA = "0x95D110", Offset = "0x95BF10", Length = "0x81")]
	private void Update()
	{
	}

	[Token(Token = "0x6002E03")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public LoadingAnimation()
	{
	}
}
