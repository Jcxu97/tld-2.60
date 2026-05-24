using Cpp2ILInjected;
using SuperSplines;
using UnityEngine;

[Token(Token = "0x20001BD")]
public class SplineAudioClip : MonoBehaviour
{
	[Token(Token = "0x4000F3D")]
	[FieldOffset(Offset = "0x20")]
	public string m_SoundID;

	[Token(Token = "0x4000F3E")]
	[FieldOffset(Offset = "0x28")]
	public Spline m_Spline;

	[Token(Token = "0x4000F3F")]
	[FieldOffset(Offset = "0x30")]
	private int m_StartAudioFrameCountdown;

	[Token(Token = "0x4000F40")]
	[FieldOffset(Offset = "0x38")]
	private Utils.FastSpline m_FastSpline;

	[Token(Token = "0x4000F41")]
	[FieldOffset(Offset = "0x98")]
	private bool m_ClosestPointOnSplineRequested;

	[Token(Token = "0x4000F42")]
	[FieldOffset(Offset = "0x9C")]
	private int m_JobIndex;

	[Token(Token = "0x4000F43")]
	[FieldOffset(Offset = "0xA0")]
	private bool m_CanUseJobSystem;

	[Token(Token = "0x600100E")]
	[Address(RVA = "0x61E6E0", Offset = "0x61D4E0", Length = "0x217")]
	public void Awake()
	{
	}

	[Token(Token = "0x600100F")]
	[Address(RVA = "0x61E900", Offset = "0x61D700", Length = "0x153")]
	public void OnDestroy()
	{
	}

	[Token(Token = "0x6001010")]
	[Address(RVA = "0x61EA60", Offset = "0x61D860", Length = "0x1D")]
	public void Start()
	{
	}

	[Token(Token = "0x6001011")]
	[Address(RVA = "0x61EA80", Offset = "0x61D880", Length = "0xDD")]
	public void EarlyUpdate()
	{
	}

	[Token(Token = "0x6001012")]
	[Address(RVA = "0x61EB60", Offset = "0x61D960", Length = "0x35D")]
	private void RequestClosestPointOnSpline()
	{
	}

	[Token(Token = "0x6001013")]
	[Address(RVA = "0x61EEC0", Offset = "0x61DCC0", Length = "0x6C")]
	private void PlaySplineAudioClip()
	{
	}

	[Token(Token = "0x6001014")]
	[Address(RVA = "0x61EF30", Offset = "0x61DD30", Length = "0x265")]
	private void DisableSplineMeshUpdating()
	{
	}

	[Token(Token = "0x6001015")]
	[Address(RVA = "0x61F1A0", Offset = "0x61DFA0", Length = "0xC8")]
	public void Update()
	{
	}

	[Token(Token = "0x6001016")]
	[Address(RVA = "0x61F270", Offset = "0x61E070", Length = "0x29B")]
	public void UpdateSplineAudioClipPosition_Legacy()
	{
	}

	[Token(Token = "0x6001017")]
	[Address(RVA = "0x61F510", Offset = "0x61E310", Length = "0x42")]
	public void ManualUpdate()
	{
	}

	[Token(Token = "0x6001018")]
	[Address(RVA = "0x61F560", Offset = "0x61E360", Length = "0x2C4")]
	private void FetchClosestPointOnSplineResult()
	{
	}

	[Token(Token = "0x6001019")]
	[Address(RVA = "0x61F830", Offset = "0x61E630", Length = "0x273")]
	public void Initialize()
	{
	}

	[Token(Token = "0x600101A")]
	[Address(RVA = "0x61FAB0", Offset = "0x61E8B0", Length = "0x4F")]
	public void Terminate()
	{
	}

	[Token(Token = "0x600101B")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public SplineAudioClip()
	{
	}
}
