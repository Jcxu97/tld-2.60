using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000356")]
public class AnimationTriggeredFootsteps : MonoBehaviour
{
	[SerializeField]
	[Token(Token = "0x4001D6F")]
	[FieldOffset(Offset = "0x20")]
	private SnowImprintType m_SnowImprintType;

	[SerializeField]
	[Token(Token = "0x4001D70")]
	[FieldOffset(Offset = "0x28")]
	private string m_FrontLeftBone;

	[SerializeField]
	[Token(Token = "0x4001D71")]
	[FieldOffset(Offset = "0x30")]
	private string m_FrontRightBone;

	[SerializeField]
	[Token(Token = "0x4001D72")]
	[FieldOffset(Offset = "0x38")]
	private string m_BackLeftBone;

	[SerializeField]
	[Token(Token = "0x4001D73")]
	[FieldOffset(Offset = "0x40")]
	private string m_BackRightBone;

	[SerializeField]
	[Token(Token = "0x4001D74")]
	[FieldOffset(Offset = "0x48")]
	private Transform m_FacingReferenceTransform;

	[Token(Token = "0x4001D75")]
	[FieldOffset(Offset = "0x50")]
	private FootstepTrail m_FootstepTrail;

	[Token(Token = "0x4001D76")]
	[FieldOffset(Offset = "0x58")]
	private BaseAi.FootstepInfo[] m_FootstepInfo;

	[Token(Token = "0x6001B35")]
	[Address(RVA = "0x759FA0", Offset = "0x758DA0", Length = "0x431")]
	private void Awake()
	{
	}

	[Token(Token = "0x6001B36")]
	[Address(RVA = "0x75A3E0", Offset = "0x7591E0", Length = "0xC")]
	public void OnFootStepFrontLeft(string audioEventName)
	{
	}

	[Token(Token = "0x6001B37")]
	[Address(RVA = "0x75A3F0", Offset = "0x7591F0", Length = "0xB")]
	public void OnFootStepFrontRight(string audioEventName)
	{
	}

	[Token(Token = "0x6001B38")]
	[Address(RVA = "0x75A400", Offset = "0x759200", Length = "0xC")]
	public void OnFootStepBackLeft(string audioEventName)
	{
	}

	[Token(Token = "0x6001B39")]
	[Address(RVA = "0x75A410", Offset = "0x759210", Length = "0xC")]
	public void OnFootStepBackRight(string audioEventName)
	{
	}

	[Token(Token = "0x6001B3A")]
	[Address(RVA = "0x75A420", Offset = "0x759220", Length = "0xC5")]
	private void HandleFootprint(string audioEvent, BaseAi.Foot foot)
	{
	}

	[Token(Token = "0x6001B3B")]
	[Address(RVA = "0x75A4F0", Offset = "0x7592F0", Length = "0x569")]
	private void PlaceFootPrintDecal(BaseAi.Foot foot)
	{
	}

	[Token(Token = "0x6001B3C")]
	[Address(RVA = "0x75AA60", Offset = "0x759860", Length = "0xBF")]
	private void PlayFootStepAudio(string audioEventName, BaseAi.Foot foot)
	{
	}

	[Token(Token = "0x6001B3D")]
	[Address(RVA = "0x75AB20", Offset = "0x759920", Length = "0x3D")]
	private void OnPlaceFootPrintDecalRaycastCompleted_FrontLeft(RaycastHit hitOut)
	{
	}

	[Token(Token = "0x6001B3E")]
	[Address(RVA = "0x75AB60", Offset = "0x759960", Length = "0x3C")]
	private void OnPlaceFootPrintDecalRaycastCompleted_FrontRight(RaycastHit hitOut)
	{
	}

	[Token(Token = "0x6001B3F")]
	[Address(RVA = "0x75ABA0", Offset = "0x7599A0", Length = "0x3D")]
	private void OnPlaceFootPrintDecalRaycastCompleted_BackLeft(RaycastHit hitOut)
	{
	}

	[Token(Token = "0x6001B40")]
	[Address(RVA = "0x75ABE0", Offset = "0x7599E0", Length = "0x3D")]
	private void OnPlaceFootPrintDecalRaycastCompleted_BackRight(RaycastHit hitOut)
	{
	}

	[Token(Token = "0x6001B41")]
	[Address(RVA = "0x75AC20", Offset = "0x759A20", Length = "0x486")]
	private void OnPlaceFootPrintDecalRaycastCompleted(RaycastHit hitOut, BaseAi.Foot foot)
	{
	}

	[Token(Token = "0x6001B42")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public AnimationTriggeredFootsteps()
	{
	}
}
