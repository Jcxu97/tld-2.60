using Cpp2ILInjected;
using UnityEngine;

namespace TLD.Gameplay;

[Token(Token = "0x2001481")]
public class LifeAfterDeathSpawnPoint : MonoBehaviour
{
	[SerializeField]
	[Token(Token = "0x40094E1")]
	[FieldOffset(Offset = "0x20")]
	private LifeAfterDeathSpawnPointType m_SpawnPointType;

	[Token(Token = "0x17000B51")]
	public LifeAfterDeathSpawnPointType SpawnPointType
	{
		[Token(Token = "0x6008260")]
		[Address(RVA = "0x4571E0", Offset = "0x455FE0", Length = "0x4")]
		get
		{
			return default(LifeAfterDeathSpawnPointType);
		}
	}

	[Token(Token = "0x6008261")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public LifeAfterDeathSpawnPoint()
	{
	}
}
