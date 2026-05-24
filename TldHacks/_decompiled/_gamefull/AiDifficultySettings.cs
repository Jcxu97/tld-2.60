using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200013F")]
public class AiDifficultySettings : MonoBehaviour
{
	[Token(Token = "0x40009F7")]
	[FieldOffset(Offset = "0x20")]
	private readonly List<AiDifficultySetting> m_Settings;

	[Token(Token = "0x6000B60")]
	[Address(RVA = "0x5D3DF0", Offset = "0x5D2BF0", Length = "0x165")]
	public AiDifficultySetting GetSetting(AiDifficulty difficulty, AiSubType ast)
	{
		return null;
	}

	[Token(Token = "0x6000B61")]
	[Address(RVA = "0x5D3F60", Offset = "0x5D2D60", Length = "0x71")]
	private void InitializeSettings()
	{
	}

	[Token(Token = "0x6000B62")]
	[Address(RVA = "0x5D3FE0", Offset = "0x5D2DE0", Length = "0x16F")]
	public AiDifficultySettings()
	{
	}
}
