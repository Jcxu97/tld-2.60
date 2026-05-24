using Cpp2ILInjected;
using UnityEngine;

namespace TLD.Gameplay;

[Token(Token = "0x200146D")]
public class CustomSpawnedItemChild : MonoBehaviour
{
	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x4009455")]
	[FieldOffset(Offset = "0x20")]
	private string m_LocalGuid;

	[Token(Token = "0x17000B41")]
	[field: Token(Token = "0x4009456")]
	[field: FieldOffset(Offset = "0x28")]
	public string Guid
	{
		[Token(Token = "0x6008205")]
		[Address(RVA = "0x413AB0", Offset = "0x4128B0", Length = "0x5")]
		get;
		[Token(Token = "0x6008206")]
		[Address(RVA = "0x4A9DB0", Offset = "0x4A8BB0", Length = "0x52")]
		private set;
	}

	[Token(Token = "0x17000B42")]
	public string LocalGuid
	{
		[Token(Token = "0x6008207")]
		[Address(RVA = "0x40E110", Offset = "0x40CF10", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6008208")]
	[Address(RVA = "0x122B320", Offset = "0x122A120", Length = "0x69")]
	private void Awake()
	{
	}

	[Token(Token = "0x6008209")]
	[Address(RVA = "0x122B390", Offset = "0x122A190", Length = "0xE7")]
	private void OnValidate()
	{
	}

	[Token(Token = "0x600820A")]
	[Address(RVA = "0x122B480", Offset = "0x122A280", Length = "0xDE")]
	public void SetGuid(string guid)
	{
	}

	[Token(Token = "0x600820B")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public CustomSpawnedItemChild()
	{
	}
}
