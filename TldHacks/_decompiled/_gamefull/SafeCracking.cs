using System;
using Cpp2ILInjected;
using TLD.UI.Generics;
using UnityEngine;

[Token(Token = "0x200043F")]
public class SafeCracking : MonoBehaviour
{
	[Token(Token = "0x400261D")]
	[FieldOffset(Offset = "0x20")]
	public SafeDifficulty m_Difficulty;

	[Token(Token = "0x400261E")]
	[FieldOffset(Offset = "0x24")]
	public bool m_Cracked;

	[Token(Token = "0x400261F")]
	[FieldOffset(Offset = "0x28")]
	public GameObject m_DialObjectPrefab;

	[Token(Token = "0x4002620")]
	[FieldOffset(Offset = "0x30")]
	public float touchRotationScale;

	[Token(Token = "0x4002621")]
	[FieldOffset(Offset = "0x34")]
	public float m_MinRotateDegreesPerSecond;

	[Token(Token = "0x4002622")]
	[FieldOffset(Offset = "0x38")]
	public float m_MaxRotateDegreesPerSecond;

	[Token(Token = "0x4002623")]
	[FieldOffset(Offset = "0x3C")]
	public float m_RotateRampUpTime;

	[Token(Token = "0x4002624")]
	[FieldOffset(Offset = "0x40")]
	public int m_NumTicksOnDial;

	[Token(Token = "0x4002625")]
	[FieldOffset(Offset = "0x44")]
	public bool m_RollCombination;

	[Token(Token = "0x4002626")]
	[FieldOffset(Offset = "0x48")]
	public int[] m_Combination;

	[HideInInspector]
	[Token(Token = "0x4002627")]
	[FieldOffset(Offset = "0x50")]
	public GameObject m_DialObject;

	[Token(Token = "0x4002628")]
	[FieldOffset(Offset = "0x58")]
	public string m_DialSpinAudio;

	[Token(Token = "0x4002629")]
	[FieldOffset(Offset = "0x60")]
	public string m_SafeClickAudio;

	[Token(Token = "0x400262A")]
	[FieldOffset(Offset = "0x68")]
	public string m_TumblerFallAudio;

	[Token(Token = "0x400262B")]
	[FieldOffset(Offset = "0x70")]
	public string m_TumblerResetAudio;

	[Header("Behavior")]
	[Token(Token = "0x400262C")]
	[FieldOffset(Offset = "0x78")]
	public bool m_DisableCollisionDuringAnimation;

	[Header("Panel References")]
	[SerializeField]
	[Token(Token = "0x400262D")]
	[FieldOffset(Offset = "0x80")]
	private PanelReference<Panel_SafeCracking> m_SafeCracking;

	[Token(Token = "0x400262E")]
	[FieldOffset(Offset = "0x88")]
	private uint m_dialSpinPlayingID;

	[Token(Token = "0x400262F")]
	[FieldOffset(Offset = "0x8C")]
	private uint m_safeClickPlayingID;

	[Token(Token = "0x4002630")]
	[FieldOffset(Offset = "0x90")]
	private int m_NumTumblers;

	[Token(Token = "0x4002631")]
	[FieldOffset(Offset = "0x98")]
	private Tumbler[] m_Tumblers;

	[Token(Token = "0x4002632")]
	[FieldOffset(Offset = "0xA0")]
	private float m_DegreesPerTick;

	[Token(Token = "0x4002633")]
	[FieldOffset(Offset = "0xA4")]
	private int m_CurrentTumblerIndex;

	[Token(Token = "0x4002634")]
	[FieldOffset(Offset = "0xA8")]
	private bool m_ReturnToZeroRequired;

	[Token(Token = "0x4002635")]
	[FieldOffset(Offset = "0xAC")]
	private float m_RotateStartTime;

	[Token(Token = "0x4002636")]
	[FieldOffset(Offset = "0xB0")]
	private float m_LastDialEulerAnglesZ;

	[Token(Token = "0x4002637")]
	[FieldOffset(Offset = "0xB8")]
	private vp_Timer m_PlayTumblerSoundTimer;

	[Token(Token = "0x4002638")]
	[FieldOffset(Offset = "0xC0")]
	private vp_Timer m_ShowOpenButtonTimer;

	[Token(Token = "0x4002639")]
	private static SafeCrackingSaveDataProxy m_SafeCrackingSaveDataProxy;

	[Token(Token = "0x400263A")]
	[FieldOffset(Offset = "0xC8")]
	private OpenClose m_OpenClose;

	[Token(Token = "0x400263B")]
	[FieldOffset(Offset = "0xD0")]
	private Action<bool> m_OnDoneSafeCracking;

	[Token(Token = "0x6001FE8")]
	[Address(RVA = "0x7E5750", Offset = "0x7E4550", Length = "0x8D")]
	private void Awake()
	{
	}

	[Token(Token = "0x6001FE9")]
	[Address(RVA = "0x7E57E0", Offset = "0x7E45E0", Length = "0x68D")]
	public void Start()
	{
	}

	[Token(Token = "0x6001FEA")]
	[Address(RVA = "0x7E5E70", Offset = "0x7E4C70", Length = "0x411")]
	public void Update()
	{
	}

	[Token(Token = "0x6001FEB")]
	[Address(RVA = "0x7E6290", Offset = "0x7E5090", Length = "0xF2")]
	public bool IsOpen()
	{
		return false;
	}

	[Token(Token = "0x6001FEC")]
	[Address(RVA = "0x7E6390", Offset = "0x7E5190", Length = "0xE0")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x6001FED")]
	[Address(RVA = "0x7E6480", Offset = "0x7E5280", Length = "0x8D")]
	public void Deserialize(string text)
	{
	}

	[Token(Token = "0x6001FEE")]
	[Address(RVA = "0x7E6510", Offset = "0x7E5310", Length = "0x38F")]
	private float GetDialDelta()
	{
		return 0f;
	}

	[Token(Token = "0x6001FEF")]
	[Address(RVA = "0x7E68A0", Offset = "0x7E56A0", Length = "0x3B0")]
	public void UpdateDial(Panel_SafeCracking safeCracking)
	{
	}

	[Token(Token = "0x6001FF0")]
	[Address(RVA = "0x7E6C60", Offset = "0x7E5A60", Length = "0x445")]
	private void ResetTumblers(Panel_SafeCracking safeCracking)
	{
	}

	[Token(Token = "0x6001FF1")]
	[Address(RVA = "0x7E70B0", Offset = "0x7E5EB0", Length = "0x78")]
	private void UnlockSafe()
	{
	}

	[Token(Token = "0x6001FF2")]
	[Address(RVA = "0x7E7130", Offset = "0x7E5F30", Length = "0x2B0")]
	private void UnlockCurrentTumbler(Panel_SafeCracking safeCracking)
	{
	}

	[Token(Token = "0x6001FF3")]
	[Address(RVA = "0x7E73F0", Offset = "0x7E61F0", Length = "0x1EE")]
	private void HitTick(Panel_SafeCracking safeCracking, float deltaDegrees)
	{
	}

	[Token(Token = "0x6001FF4")]
	[Address(RVA = "0x7E75E0", Offset = "0x7E63E0", Length = "0x19")]
	private void ResetSafe(Panel_SafeCracking safeCracking)
	{
	}

	[Token(Token = "0x6001FF5")]
	[Address(RVA = "0x7E7600", Offset = "0x7E6400", Length = "0x8D")]
	public void PlayDialSpinClick()
	{
	}

	[Token(Token = "0x6001FF6")]
	[Address(RVA = "0x7E7690", Offset = "0x7E6490", Length = "0x6C")]
	public void PlayResetTumblersSound()
	{
	}

	[Token(Token = "0x6001FF7")]
	[Address(RVA = "0x7E7700", Offset = "0x7E6500", Length = "0x8D")]
	public void PlaySafeClickSound()
	{
	}

	[Token(Token = "0x6001FF8")]
	[Address(RVA = "0x7E7790", Offset = "0x7E6590", Length = "0x6C")]
	public void PlayTumblerFallSound()
	{
	}

	[Token(Token = "0x6001FF9")]
	[Address(RVA = "0x7E7800", Offset = "0x7E6600", Length = "0x68")]
	private int TickToDialNumber(float tick)
	{
		return 0;
	}

	[Token(Token = "0x6001FFA")]
	[Address(RVA = "0x7E7870", Offset = "0x7E6670", Length = "0x3E3")]
	public void EnableSafeCrackingInterface(Action<bool> onDoneSafecracking = null)
	{
	}

	[Token(Token = "0x6001FFB")]
	[Address(RVA = "0x7E7C60", Offset = "0x7E6A60", Length = "0x191")]
	public void HandleOnDoneSafeCracking(bool openSafe)
	{
	}

	[Token(Token = "0x6001FFC")]
	[Address(RVA = "0x7E7E00", Offset = "0x7E6C00", Length = "0x4E")]
	public SafeCracking()
	{
	}
}
