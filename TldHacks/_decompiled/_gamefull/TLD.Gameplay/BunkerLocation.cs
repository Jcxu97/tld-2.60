using Cpp2ILInjected;
using TLD.Scenes.ObjectReferences;
using UnityEngine;

namespace TLD.Gameplay;

[DisallowMultipleComponent]
[Token(Token = "0x2001460")]
public class BunkerLocation : MonoBehaviour
{
	[SerializeField]
	[SceneObjectReferenceOwner("Assets/ScriptableObjects/Gameplay/BunkerLocations")]
	[Token(Token = "0x40093EC")]
	[FieldOffset(Offset = "0x20")]
	private BunkerLocationReference m_SceneObject;

	[Token(Token = "0x60081B5")]
	[Address(RVA = "0x1224600", Offset = "0x1223400", Length = "0xF0")]
	private void Awake()
	{
	}

	[Token(Token = "0x60081B6")]
	[Address(RVA = "0x1224700", Offset = "0x1223500", Length = "0xE2")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60081B7")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public BunkerLocation()
	{
	}
}
