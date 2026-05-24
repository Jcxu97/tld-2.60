using Cpp2ILInjected;
using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
[Token(Token = "0x20003FA")]
public class SmokeTrail : MonoBehaviour
{
	[Token(Token = "0x400239D")]
	private const string MAT_PROPERTY_COLOR = "_Color";

	[Token(Token = "0x400239E")]
	[FieldOffset(Offset = "0x20")]
	public int numberOfPoints;

	[Token(Token = "0x400239F")]
	[FieldOffset(Offset = "0x24")]
	public float updateSpeed;

	[Token(Token = "0x40023A0")]
	[FieldOffset(Offset = "0x28")]
	public float riseSpeed;

	[Token(Token = "0x40023A1")]
	[FieldOffset(Offset = "0x2C")]
	public float spread;

	[Tooltip("A \"realistic\" world value is 300, but higher is better for the game")]
	[Token(Token = "0x40023A2")]
	[FieldOffset(Offset = "0x30")]
	public bool applySpeedAndDir;

	[Token(Token = "0x40023A3")]
	[FieldOffset(Offset = "0x34")]
	public float windForceDivider;

	[Token(Token = "0x40023A4")]
	[FieldOffset(Offset = "0x38")]
	public bool affectRiseSpeed;

	[Token(Token = "0x40023A5")]
	[FieldOffset(Offset = "0x3C")]
	public float riseRateDivider;

	[Token(Token = "0x40023A6")]
	[FieldOffset(Offset = "0x40")]
	public bool affectSpread;

	[Token(Token = "0x40023A7")]
	[FieldOffset(Offset = "0x44")]
	public float spreadDivider;

	[Tooltip("Fadeout smoke based on duration.")]
	[Token(Token = "0x40023A8")]
	[FieldOffset(Offset = "0x48")]
	public bool useFadeout;

	[Tooltip("Total life time of the smoke trail, in real time")]
	[Token(Token = "0x40023A9")]
	[FieldOffset(Offset = "0x4C")]
	public float duration;

	[Tooltip("How long it takes to fade to fully transparent, within the total life time. Real time.")]
	[Token(Token = "0x40023AA")]
	[FieldOffset(Offset = "0x50")]
	public float fadeDuration;

	[Tooltip("Start the smoke effect automatically")]
	[Token(Token = "0x40023AB")]
	[FieldOffset(Offset = "0x54")]
	public bool playOnAwake;

	[Tooltip("Kill the smoke once it's reached it's lifetime duaraion. Must use fadeout and duration.")]
	[Token(Token = "0x40023AC")]
	[FieldOffset(Offset = "0x55")]
	public bool autoDestroy;

	[Tooltip("Link the smoke to a fire.")]
	[Token(Token = "0x40023AD")]
	[FieldOffset(Offset = "0x58")]
	public Fire m_SourceFire;

	[Tooltip("Fade the smoke based on fire duration, from 0 to fade start. 0 or less = no fade. In gametime minutes.")]
	[Token(Token = "0x40023AE")]
	[FieldOffset(Offset = "0x60")]
	public float m_SourceFireFadeStart;

	[Tooltip("The number of parent levels to traverse.")]
	[Token(Token = "0x40023AF")]
	[FieldOffset(Offset = "0x64")]
	public int m_ParentLevels;

	[Token(Token = "0x40023B0")]
	[FieldOffset(Offset = "0x68")]
	private LineRenderer line;

	[Token(Token = "0x40023B1")]
	[FieldOffset(Offset = "0x70")]
	private Transform tr;

	[Token(Token = "0x40023B2")]
	[FieldOffset(Offset = "0x78")]
	private Vector3[] positions;

	[Token(Token = "0x40023B3")]
	[FieldOffset(Offset = "0x80")]
	private Vector3[] directions;

	[Token(Token = "0x40023B4")]
	[FieldOffset(Offset = "0x88")]
	private int i;

	[Token(Token = "0x40023B5")]
	[FieldOffset(Offset = "0x8C")]
	private float timeSinceUpdate;

	[Token(Token = "0x40023B6")]
	[FieldOffset(Offset = "0x90")]
	private Material lineMaterial;

	[Token(Token = "0x40023B7")]
	[FieldOffset(Offset = "0x98")]
	private float lineSegment;

	[Token(Token = "0x40023B8")]
	[FieldOffset(Offset = "0x9C")]
	private int currentNumberOfPoints;

	[Token(Token = "0x40023B9")]
	[FieldOffset(Offset = "0xA0")]
	private bool allPointsAdded;

	[Token(Token = "0x40023BA")]
	[FieldOffset(Offset = "0xA4")]
	private Color startColour;

	[Token(Token = "0x40023BB")]
	[FieldOffset(Offset = "0xB4")]
	private Vector3 tempVec;

	[Token(Token = "0x40023BC")]
	[FieldOffset(Offset = "0xC0")]
	private float windSpeed;

	[Token(Token = "0x40023BD")]
	[FieldOffset(Offset = "0xC4")]
	private Vector3 windDir;

	[Token(Token = "0x40023BE")]
	[FieldOffset(Offset = "0xD0")]
	private bool isSmoking;

	[Token(Token = "0x40023BF")]
	[FieldOffset(Offset = "0xD4")]
	private float smokeTimer;

	[Token(Token = "0x40023C0")]
	[FieldOffset(Offset = "0xD8")]
	private float smokeFadeStep;

	[Token(Token = "0x40023C1")]
	[FieldOffset(Offset = "0xDC")]
	private bool m_ForceFadeOut;

	[Token(Token = "0x40023C2")]
	[FieldOffset(Offset = "0xE0")]
	private float m_ForceFadeOutSeconds;

	[Token(Token = "0x40023C3")]
	[FieldOffset(Offset = "0xE4")]
	private bool m_Warmed;

	[Token(Token = "0x40023C4")]
	[FieldOffset(Offset = "0xE8")]
	private Color m_currentColor;

	[Token(Token = "0x40023C5")]
	[FieldOffset(Offset = "0xF8")]
	private bool m_IsReset;

	[Token(Token = "0x6001E70")]
	[Address(RVA = "0x7BDF00", Offset = "0x7BCD00", Length = "0x71")]
	private void Start()
	{
	}

	[Token(Token = "0x6001E71")]
	[Address(RVA = "0x7BDF80", Offset = "0x7BCD80", Length = "0x124")]
	public void SetAlpha(float fadePercent)
	{
	}

	[Token(Token = "0x6001E72")]
	[Address(RVA = "0x7BE0B0", Offset = "0x7BCEB0", Length = "0x608")]
	private void FixedUpdateInternal(float deltaTime)
	{
	}

	[Token(Token = "0x6001E73")]
	[Address(RVA = "0x7BE6C0", Offset = "0x7BD4C0", Length = "0x58")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6001E74")]
	[Address(RVA = "0x7BE720", Offset = "0x7BD520", Length = "0x9D7")]
	private void InitEffect(bool resetEffect = false)
	{
	}

	[Token(Token = "0x6001E75")]
	[Address(RVA = "0x7BF100", Offset = "0x7BDF00", Length = "0x8DE")]
	private void UpdateInternal(float deltaTime)
	{
	}

	[Token(Token = "0x6001E76")]
	[Address(RVA = "0x7BF9E0", Offset = "0x7BE7E0", Length = "0x12B")]
	private void UpdateMaterial()
	{
	}

	[Token(Token = "0x6001E77")]
	[Address(RVA = "0x7BFB10", Offset = "0x7BE910", Length = "0x1AA")]
	private Vector3 getSmokeVec()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6001E78")]
	[Address(RVA = "0x7BFCC0", Offset = "0x7BEAC0", Length = "0x20")]
	public void StartSmoke()
	{
	}

	[Token(Token = "0x6001E79")]
	[Address(RVA = "0x7BFCE0", Offset = "0x7BEAE0", Length = "0x20")]
	public void Reset()
	{
	}

	[Token(Token = "0x6001E7A")]
	[Address(RVA = "0x6A2C40", Offset = "0x6A1A40", Length = "0x8")]
	public bool GetSmokeStatus()
	{
		return false;
	}

	[Token(Token = "0x6001E7B")]
	[Address(RVA = "0x7BFD00", Offset = "0x7BEB00", Length = "0x7")]
	public void ForceOff(bool force)
	{
	}

	[Token(Token = "0x6001E7C")]
	[Address(RVA = "0x7BFD10", Offset = "0x7BEB10", Length = "0x5B")]
	public void WarmUpEffect()
	{
	}

	[Token(Token = "0x6001E7D")]
	[Address(RVA = "0x7BFD70", Offset = "0x7BEB70", Length = "0xB4")]
	public SmokeTrail()
	{
	}
}
