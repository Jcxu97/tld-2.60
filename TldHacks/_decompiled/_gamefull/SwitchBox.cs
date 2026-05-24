using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20005B8")]
public class SwitchBox : MonoBehaviour
{
	[Token(Token = "0x40034CA")]
	[FieldOffset(Offset = "0x20")]
	public LocalizedString m_LocalizedDisplayName;

	[Token(Token = "0x40034CB")]
	[FieldOffset(Offset = "0x28")]
	public SwitchToggleState m_SwitchToggleState;

	[Token(Token = "0x40034CC")]
	[FieldOffset(Offset = "0x2C")]
	public bool m_IsLocked;

	[Token(Token = "0x40034CD")]
	[FieldOffset(Offset = "0x30")]
	public float m_AuroraThreshold;

	[Token(Token = "0x40034CE")]
	[FieldOffset(Offset = "0x38")]
	public GameObject m_BoxBase;

	[Token(Token = "0x40034CF")]
	[FieldOffset(Offset = "0x40")]
	public GameObject m_PowerLever;

	[Token(Token = "0x40034D0")]
	[FieldOffset(Offset = "0x48")]
	public Light m_LightOn;

	[Token(Token = "0x40034D1")]
	[FieldOffset(Offset = "0x50")]
	public Light m_LightOff;

	[Token(Token = "0x40034D2")]
	[FieldOffset(Offset = "0x58")]
	public float m_TransitionTime;

	[Token(Token = "0x40034D3")]
	[FieldOffset(Offset = "0x5C")]
	public float m_NeedleAngle;

	[Token(Token = "0x40034D4")]
	[FieldOffset(Offset = "0x60")]
	public string m_LoopAudio;

	[Token(Token = "0x40034D5")]
	[FieldOffset(Offset = "0x68")]
	public string m_TurnOffAudio;

	[Token(Token = "0x40034D6")]
	[FieldOffset(Offset = "0x70")]
	private float m_Timer;

	[Token(Token = "0x40034D7")]
	[FieldOffset(Offset = "0x74")]
	private Vector3 m_NeedleOn;

	[Token(Token = "0x40034D8")]
	[FieldOffset(Offset = "0x80")]
	private Vector3 m_NeedleOff;

	[Token(Token = "0x40034D9")]
	[FieldOffset(Offset = "0x90")]
	private Renderer m_SwitchBox;

	[Token(Token = "0x40034DA")]
	[FieldOffset(Offset = "0x98")]
	private uint m_LoopAudioID;

	[Token(Token = "0x40034DB")]
	[FieldOffset(Offset = "0x9C")]
	private bool m_UpdateImmediate;

	[Token(Token = "0x40034DC")]
	private static SwitchBoxSaveDataProxy s_SwitchBoxSaveDataProxy;

	[Token(Token = "0x6002C32")]
	[Address(RVA = "0x92FB60", Offset = "0x92E960", Length = "0x153")]
	private void Awake()
	{
	}

	[Token(Token = "0x6002C33")]
	[Address(RVA = "0x92FCC0", Offset = "0x92EAC0", Length = "0xF1")]
	private void Start()
	{
	}

	[Token(Token = "0x6002C34")]
	[Address(RVA = "0x92FDC0", Offset = "0x92EBC0", Length = "0x14F")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6002C35")]
	[Address(RVA = "0x92FF10", Offset = "0x92ED10", Length = "0x4")]
	public void SetState(SwitchToggleState state)
	{
	}

	[Token(Token = "0x6002C36")]
	[Address(RVA = "0x880620", Offset = "0x87F420", Length = "0x4")]
	public void SetLocked(bool isLocked)
	{
	}

	[Token(Token = "0x6002C37")]
	[Address(RVA = "0x92FF20", Offset = "0x92ED20", Length = "0x150")]
	private void Update()
	{
	}

	[Token(Token = "0x6002C38")]
	[Address(RVA = "0x930070", Offset = "0x92EE70", Length = "0x239")]
	private void UpdateLights()
	{
	}

	[Token(Token = "0x6002C39")]
	[Address(RVA = "0x9302B0", Offset = "0x92F0B0", Length = "0xFC")]
	private void UpdateHandle(float lerpTime)
	{
	}

	[Token(Token = "0x6002C3A")]
	[Address(RVA = "0x9303B0", Offset = "0x92F1B0", Length = "0x181")]
	public void PerformInteraction()
	{
	}

	[Token(Token = "0x6002C3B")]
	[Address(RVA = "0x930540", Offset = "0x92F340", Length = "0x8F")]
	private void TurnOn()
	{
	}

	[Token(Token = "0x6002C3C")]
	[Address(RVA = "0x9305D0", Offset = "0x92F3D0", Length = "0xB1")]
	private void TurnOff()
	{
	}

	[Token(Token = "0x6002C3D")]
	[Address(RVA = "0x930690", Offset = "0x92F490", Length = "0x88")]
	private void TurnAudioOn()
	{
	}

	[Token(Token = "0x6002C3E")]
	[Address(RVA = "0x930720", Offset = "0x92F520", Length = "0xAA")]
	private void TurnAudioOff()
	{
	}

	[Token(Token = "0x6002C3F")]
	[Address(RVA = "0x9307D0", Offset = "0x92F5D0", Length = "0x183")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x6002C40")]
	[Address(RVA = "0x930960", Offset = "0x92F760", Length = "0x9A")]
	public void Deserialize(string text)
	{
	}

	[Token(Token = "0x6002C41")]
	[Address(RVA = "0x930A00", Offset = "0x92F800", Length = "0x58")]
	public SwitchBox()
	{
	}
}
