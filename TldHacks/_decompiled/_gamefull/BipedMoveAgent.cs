using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Playables;

[Token(Token = "0x2000870")]
public class BipedMoveAgent : MonoBehaviour
{
	[Token(Token = "0x400573E")]
	[FieldOffset(Offset = "0x20")]
	public NavMeshAgent m_NavMeshAgent;

	[Token(Token = "0x400573F")]
	[FieldOffset(Offset = "0x28")]
	public Animator m_Animator;

	[Header("NavMesh")]
	[Token(Token = "0x4005740")]
	[FieldOffset(Offset = "0x30")]
	public Transform m_ObjectSyncPointTransform;

	[Token(Token = "0x4005741")]
	[FieldOffset(Offset = "0x38")]
	public AnimationCurve m_AnimationCurve;

	[Range(0.1f, 30f)]
	[Token(Token = "0x4005742")]
	[FieldOffset(Offset = "0x40")]
	public float m_BlendOutTime;

	[Range(0f, 3f)]
	[Token(Token = "0x4005743")]
	[FieldOffset(Offset = "0x44")]
	public float m_BlendOutDistance;

	[Range(0f, 2f)]
	[Token(Token = "0x4005744")]
	[FieldOffset(Offset = "0x48")]
	public float m_MinPathDistance;

	[Header("Head Tracking")]
	[Token(Token = "0x4005745")]
	[FieldOffset(Offset = "0x50")]
	public GameObject m_LookAtGameObject;

	[Range(0f, 1f)]
	[Token(Token = "0x4005746")]
	[FieldOffset(Offset = "0x58")]
	public float m_DesiredTargetWeight;

	[Range(0f, 1f)]
	[Token(Token = "0x4005747")]
	[FieldOffset(Offset = "0x5C")]
	public float m_DesiredTargetWeightBody;

	[Range(0f, 1f)]
	[Token(Token = "0x4005748")]
	[FieldOffset(Offset = "0x60")]
	public float m_DesiredTargetWeightHead;

	[Range(0f, 1f)]
	[Token(Token = "0x4005749")]
	[FieldOffset(Offset = "0x64")]
	public float m_DesiredTargetWeightEyes;

	[Range(0f, 1f)]
	[Token(Token = "0x400574A")]
	[FieldOffset(Offset = "0x68")]
	public float m_DesiredTargetWeightClamp;

	[Range(0f, 30f)]
	[Token(Token = "0x400574B")]
	[FieldOffset(Offset = "0x6C")]
	public float m_TargetWeightTime;

	[Range(0f, 30f)]
	[Token(Token = "0x400574C")]
	[FieldOffset(Offset = "0x70")]
	public float m_TargetWeightBodyTime;

	[Range(0f, 30f)]
	[Token(Token = "0x400574D")]
	[FieldOffset(Offset = "0x74")]
	public float m_TargetWeightHeadTime;

	[Range(0f, 30f)]
	[Token(Token = "0x400574E")]
	[FieldOffset(Offset = "0x78")]
	public float m_TargetWeightEyesTime;

	[Range(0f, 30f)]
	[Token(Token = "0x400574F")]
	[FieldOffset(Offset = "0x7C")]
	public float m_TargetWeightClampTime;

	[Range(0f, 30f)]
	[Token(Token = "0x4005750")]
	[FieldOffset(Offset = "0x80")]
	public float m_ChangeTargetTime;

	[Header("Animator Variables")]
	[HideInInspector]
	[Token(Token = "0x4005751")]
	[FieldOffset(Offset = "0x84")]
	public int m_AnimParameter_BipedTurning;

	[HideInInspector]
	[Token(Token = "0x4005752")]
	[FieldOffset(Offset = "0x88")]
	public int m_AnimParameter_BipedTargetDistance;

	[HideInInspector]
	[Token(Token = "0x4005753")]
	[FieldOffset(Offset = "0x8C")]
	public int m_AnimParameter_BipedIsMoving;

	[HideInInspector]
	[Token(Token = "0x4005754")]
	[FieldOffset(Offset = "0x90")]
	public int m_AnimParameter_BipedStopAngle;

	[HideInInspector]
	[Token(Token = "0x4005755")]
	[FieldOffset(Offset = "0x94")]
	public int m_AnimParameter_BipedIsSmallStep;

	[HideInInspector]
	[Token(Token = "0x4005756")]
	[FieldOffset(Offset = "0x98")]
	public int m_AnimParameter_BipedStartAngle;

	[HideInInspector]
	[Token(Token = "0x4005757")]
	[FieldOffset(Offset = "0x9C")]
	public int m_AnimParameter_BipedInterrupted;

	[Token(Token = "0x4005758")]
	[FieldOffset(Offset = "0xA0")]
	private Vector3 m_Destination;

	[Token(Token = "0x4005759")]
	[FieldOffset(Offset = "0xAC")]
	private Vector3 m_LastPosition;

	[Token(Token = "0x400575A")]
	[FieldOffset(Offset = "0xB8")]
	private float m_BlendOutTimer;

	[Token(Token = "0x400575B")]
	[FieldOffset(Offset = "0xBC")]
	private bool m_IsSmallStep;

	[Token(Token = "0x400575C")]
	[FieldOffset(Offset = "0xBD")]
	private bool m_IsNavigating;

	[Token(Token = "0x400575D")]
	[FieldOffset(Offset = "0xC0")]
	private float m_CurrentTargetWeight;

	[Token(Token = "0x400575E")]
	[FieldOffset(Offset = "0xC4")]
	private float m_CurrentTargetWeightBody;

	[Token(Token = "0x400575F")]
	[FieldOffset(Offset = "0xC8")]
	private float m_CurrentTargetWeightHead;

	[Token(Token = "0x4005760")]
	[FieldOffset(Offset = "0xCC")]
	private float m_CurrentTargetWeightEyes;

	[Token(Token = "0x4005761")]
	[FieldOffset(Offset = "0xD0")]
	private float m_CurrentTargetWeightClamp;

	[Token(Token = "0x4005762")]
	[FieldOffset(Offset = "0xD4")]
	private Vector3 m_LastTargetPosition;

	[Token(Token = "0x4005763")]
	[FieldOffset(Offset = "0xE0")]
	private float m_ChangeTargetWeight;

	[Token(Token = "0x4005764")]
	[FieldOffset(Offset = "0xE8")]
	private PlayableDirector m_PlayableDirector;

	[Token(Token = "0x6004D67")]
	[Address(RVA = "0xD88B30", Offset = "0xD87930", Length = "0x446")]
	private void Start()
	{
	}

	[Token(Token = "0x6004D68")]
	[Address(RVA = "0xD88F80", Offset = "0xD87D80", Length = "0xE0")]
	private void Update()
	{
	}

	[Token(Token = "0x6004D69")]
	[Address(RVA = "0xD89060", Offset = "0xD87E60", Length = "0x1F")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6004D6A")]
	[Address(RVA = "0xD89080", Offset = "0xD87E80", Length = "0xEF")]
	public bool IsMoving()
	{
		return false;
	}

	[Token(Token = "0x6004D6B")]
	[Address(RVA = "0xD89170", Offset = "0xD87F70", Length = "0x3CE")]
	private void DoDynamicBinding()
	{
	}

	[Token(Token = "0x6004D6C")]
	[Address(RVA = "0xD89540", Offset = "0xD88340", Length = "0x275")]
	private void MaybePlayInteraction()
	{
	}

	[Token(Token = "0x6004D6D")]
	[Address(RVA = "0xD897C0", Offset = "0xD885C0", Length = "0x1AF")]
	private void StopMoving()
	{
	}

	[Token(Token = "0x6004D6E")]
	[Address(RVA = "0xD89970", Offset = "0xD88770", Length = "0x48")]
	public void StopMovingImmediate()
	{
	}

	[Token(Token = "0x6004D6F")]
	[Address(RVA = "0xD899C0", Offset = "0xD887C0", Length = "0x9A1")]
	public bool SetDestination(Vector3 position, Transform gameObjectTransform = null)
	{
		return false;
	}

	[Token(Token = "0x6004D70")]
	[Address(RVA = "0xD8A370", Offset = "0xD89170", Length = "0x71")]
	public void ClearLookAtGameObject()
	{
	}

	[Token(Token = "0x6004D71")]
	[Address(RVA = "0xD8A3F0", Offset = "0xD891F0", Length = "0x404")]
	public void SetLookAtGameObject(GameObject go)
	{
	}

	[Token(Token = "0x6004D72")]
	[Address(RVA = "0xD8A800", Offset = "0xD89600", Length = "0x8F")]
	public void SetSetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight)
	{
	}

	[Token(Token = "0x6004D73")]
	[Address(RVA = "0xD8A890", Offset = "0xD89690", Length = "0x4AA")]
	public void OnAnimatorIK()
	{
	}

	[Token(Token = "0x6004D74")]
	[Address(RVA = "0xD8AD40", Offset = "0xD89B40", Length = "0x9F9")]
	private void UpdateAnimationBasedOnNavigation()
	{
	}

	[Token(Token = "0x6004D75")]
	[Address(RVA = "0xD8B740", Offset = "0xD8A540", Length = "0x34E")]
	private void UpdateAnimationBlendOut()
	{
	}

	[Token(Token = "0x6004D76")]
	[Address(RVA = "0xD8BA90", Offset = "0xD8A890", Length = "0x39D")]
	private void UpdateStickToGround()
	{
	}

	[Token(Token = "0x6004D77")]
	[Address(RVA = "0xD8BE30", Offset = "0xD8AC30", Length = "0x97")]
	private void MoveToWeight(ref float currentWeight, float desiredWeight, float time)
	{
	}

	[Token(Token = "0x6004D78")]
	[Address(RVA = "0xD8BED0", Offset = "0xD8ACD0", Length = "0xCC")]
	private void UpdateCurrentIKWeights()
	{
	}

	[Token(Token = "0x6004D79")]
	[Address(RVA = "0xD8BFA0", Offset = "0xD8ADA0", Length = "0x1DB")]
	private void OnPlayableDirectorStopped(PlayableDirector pd)
	{
	}

	[Token(Token = "0x6004D7A")]
	[Address(RVA = "0xD8C180", Offset = "0xD8AF80", Length = "0x19B")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6004D7B")]
	[Address(RVA = "0xD8C320", Offset = "0xD8B120", Length = "0x93")]
	public BipedMoveAgent()
	{
	}
}
