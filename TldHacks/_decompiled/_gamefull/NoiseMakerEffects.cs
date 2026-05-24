using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20003DB")]
public class NoiseMakerEffects : MonoBehaviour
{
	[SerializeField]
	[Token(Token = "0x40022CA")]
	[FieldOffset(Offset = "0x20")]
	private Renderer m_FuseRenderer;

	[SerializeField]
	[Token(Token = "0x40022CB")]
	[FieldOffset(Offset = "0x28")]
	private Transform[] m_WickTransformChain;

	[SerializeField]
	[Token(Token = "0x40022CC")]
	[FieldOffset(Offset = "0x30")]
	private Transform m_WickFXRoot;

	[SerializeField]
	[Token(Token = "0x40022CD")]
	[FieldOffset(Offset = "0x38")]
	private ParticleSystem m_WickFX;

	[SerializeField]
	[Token(Token = "0x40022CE")]
	[FieldOffset(Offset = "0x40")]
	private ParticleSystem m_DetonateFX;

	[SerializeField]
	[Token(Token = "0x40022CF")]
	[FieldOffset(Offset = "0x48")]
	private GearItem m_GearItem;

	[Token(Token = "0x40022D0")]
	private static readonly int s_BurnStrengthPropertyID;

	[Token(Token = "0x40022D1")]
	private static readonly int s_BurnPositionPropertyID;

	[Token(Token = "0x40022D2")]
	[FieldOffset(Offset = "0x50")]
	private MaterialPropertyBlock m_FuseBurnPropertyBlock;

	[Token(Token = "0x40022D3")]
	[FieldOffset(Offset = "0x58")]
	private NoiseMakerState m_LastState;

	[Token(Token = "0x6001DF5")]
	[Address(RVA = "0x7AF920", Offset = "0x7AE720", Length = "0x6C")]
	public void SetEffectsHidden(bool isHidden)
	{
	}

	[Token(Token = "0x6001DF6")]
	[Address(RVA = "0x7AF990", Offset = "0x7AE790", Length = "0x13")]
	public GameObject GetDetonateEffectObject()
	{
		return null;
	}

	[Token(Token = "0x6001DF7")]
	[Address(RVA = "0x7AF9B0", Offset = "0x7AE7B0", Length = "0xD2")]
	private void Awake()
	{
	}

	[Token(Token = "0x6001DF8")]
	[Address(RVA = "0x7AFA90", Offset = "0x7AE890", Length = "0x796")]
	private void Update()
	{
	}

	[Token(Token = "0x6001DF9")]
	[Address(RVA = "0x7B0230", Offset = "0x7AF030", Length = "0x3CF")]
	private void PlayDetonateInHand()
	{
	}

	[Token(Token = "0x6001DFA")]
	[Address(RVA = "0x7B0600", Offset = "0x7AF400", Length = "0x1CD")]
	private void EnableDisconnectedEffect(ParticleSystem effect, bool isEnabled)
	{
	}

	[Token(Token = "0x6001DFB")]
	[Address(RVA = "0x7B07D0", Offset = "0x7AF5D0", Length = "0x10D")]
	private void EnableEffect(ParticleSystem effect, bool isEnabled)
	{
	}

	[Token(Token = "0x6001DFC")]
	[Address(RVA = "0x7B08E0", Offset = "0x7AF6E0", Length = "0x2AC")]
	private void MaybeLeaveScorchMarkOnGround()
	{
	}

	[Token(Token = "0x6001DFD")]
	[Address(RVA = "0x7B0B90", Offset = "0x7AF990", Length = "0x378")]
	private static void LeaveScorchMark(RaycastHit hit)
	{
	}

	[Token(Token = "0x6001DFE")]
	[Address(RVA = "0x7B0F30", Offset = "0x7AFD30", Length = "0x445")]
	private static ScorchImpactEffectType GetImpactEffectTypeBasedOnMaterial(string tag)
	{
		return default(ScorchImpactEffectType);
	}

	[Token(Token = "0x6001DFF")]
	[Address(RVA = "0x7B1380", Offset = "0x7B0180", Length = "0x20C")]
	private void UpdateFuseBurnEffect(float burnPosition, float burnStrength)
	{
	}

	[Token(Token = "0x6001E00")]
	[Address(RVA = "0x7B1590", Offset = "0x7B0390", Length = "0x50D")]
	private Vector3 GetInterpolatedPointAlongWick(float ratio)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6001E01")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public NoiseMakerEffects()
	{
	}
}
