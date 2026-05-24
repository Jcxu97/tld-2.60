using Cpp2ILInjected;
using UnityEngine;

namespace TLD.AI;

[Token(Token = "0x20014FF")]
public class CougarIntroScene : MonoBehaviour
{
	[Token(Token = "0x40097BB")]
	[FieldOffset(Offset = "0x20")]
	public GameObject m_SceneAssets;

	[Token(Token = "0x60084B0")]
	[Address(RVA = "0x12661E0", Offset = "0x1264FE0", Length = "0x1CE")]
	private void Start()
	{
	}

	[Token(Token = "0x60084B1")]
	[Address(RVA = "0x12663B0", Offset = "0x12651B0", Length = "0x1E")]
	public void ActivateSceneAssets(bool enable)
	{
	}

	[Token(Token = "0x60084B2")]
	[Address(RVA = "0x12663D0", Offset = "0x12651D0", Length = "0xB6")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60084B3")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public CougarIntroScene()
	{
	}
}
