using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace TLD.Gameplay;

[Token(Token = "0x2001465")]
public abstract class ChallengeLockCondition : ScriptableObject
{
	[Header("Alternate UI Data")]
	[Token(Token = "0x4009402")]
	[FieldOffset(Offset = "0x18")]
	public AssetReferenceTexture2D m_AltChallengeTexture;

	[Token(Token = "0x4009403")]
	[FieldOffset(Offset = "0x20")]
	public string m_AltSpriteName;

	[Token(Token = "0x4009404")]
	[FieldOffset(Offset = "0x28")]
	public LocalizedString m_AltHeader;

	[Token(Token = "0x4009405")]
	[FieldOffset(Offset = "0x30")]
	public LocalizedString m_AltDescription;

	[Token(Token = "0x4009406")]
	[FieldOffset(Offset = "0x38")]
	public LocalizedString m_AltInstructions;

	[Token(Token = "0x60081CC")]
	public abstract bool IsLocked();

	[Token(Token = "0x60081CD")]
	[Address(RVA = "0x4A22A0", Offset = "0x4A10A0", Length = "0x7")]
	protected ChallengeLockCondition()
	{
	}
}
