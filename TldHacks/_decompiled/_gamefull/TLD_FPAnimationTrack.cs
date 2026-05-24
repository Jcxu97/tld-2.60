using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200099B")]
public class TLD_FPAnimationTrack : TLD_SpawnedAnimationTrack, TLD_IFPAnchoredTrack
{
	[Token(Token = "0x40062C7")]
	[FieldOffset(Offset = "0x168")]
	private Transform m_FPAnchor;

	[Token(Token = "0x40062C8")]
	[FieldOffset(Offset = "0x170")]
	private bool m_HasInitializedExitValues;

	[Token(Token = "0x40062C9")]
	[FieldOffset(Offset = "0x174")]
	private Quaternion m_ExitStartRootObjectOriginalRotation;

	[Token(Token = "0x60055BD")]
	[Address(RVA = "0xB6BAD0", Offset = "0xB6A8D0", Length = "0x52")]
	public void SetFPAnchor(Transform anchor)
	{
	}

	[Token(Token = "0x60055BE")]
	[Address(RVA = "0xEA67A0", Offset = "0xEA55A0", Length = "0x188")]
	protected override void PlayInternal()
	{
	}

	[Token(Token = "0x60055BF")]
	[Address(RVA = "0xEA6930", Offset = "0xEA5730", Length = "0x78B")]
	protected override void UpdateSpawnedObjectRootTransformAndParent()
	{
	}

	[Token(Token = "0x60055C0")]
	[Address(RVA = "0xEA70C0", Offset = "0xEA5EC0", Length = "0x2BC")]
	private void MaybeUpdateTransitionOut()
	{
	}

	[Token(Token = "0x60055C1")]
	[Address(RVA = "0xEA7380", Offset = "0xEA6180", Length = "0x4B2")]
	private void UpdateRotationExit(float progress)
	{
	}

	[Token(Token = "0x60055C2")]
	[Address(RVA = "0xEA7840", Offset = "0xEA6640", Length = "0x84")]
	public TLD_FPAnimationTrack()
	{
	}
}
