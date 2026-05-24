using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20001BF")]
public class AuroraActivatedToggle : MonoBehaviour
{
	[Token(Token = "0x4000F47")]
	[FieldOffset(Offset = "0x20")]
	public AuroraActivatedToggleState m_ToggleState;

	[Token(Token = "0x4000F48")]
	[FieldOffset(Offset = "0x28")]
	public string m_ToggleOnAudio;

	[Token(Token = "0x4000F49")]
	[FieldOffset(Offset = "0x30")]
	public string m_ToggleOffAudio;

	[Token(Token = "0x4000F4A")]
	[FieldOffset(Offset = "0x38")]
	private bool m_ChildrenEnabled;

	[Token(Token = "0x4000F4B")]
	[FieldOffset(Offset = "0x40")]
	private AuroraField m_ActiveAuroraField;

	[Token(Token = "0x4000F4C")]
	[FieldOffset(Offset = "0x48")]
	public bool m_RequiresAuroraField;

	[Token(Token = "0x600101C")]
	[Address(RVA = "0x61FB00", Offset = "0x61E900", Length = "0xF2")]
	private void Awake()
	{
	}

	[Token(Token = "0x600101D")]
	[Address(RVA = "0x61FC00", Offset = "0x61EA00", Length = "0xA")]
	private void Start()
	{
	}

	[Token(Token = "0x600101E")]
	[Address(RVA = "0x61FC10", Offset = "0x61EA10", Length = "0x6E")]
	private void Update()
	{
	}

	[Token(Token = "0x600101F")]
	[Address(RVA = "0x4D0B00", Offset = "0x4CF900", Length = "0x52")]
	public void SetAuroraField(AuroraField auroraField)
	{
	}

	[Token(Token = "0x6001020")]
	[Address(RVA = "0x61FC80", Offset = "0x61EA80", Length = "0xAD")]
	public void PerformInteraction()
	{
	}

	[Token(Token = "0x6001021")]
	[Address(RVA = "0x61FD30", Offset = "0x61EB30", Length = "0x7B")]
	private void SetState(AuroraActivatedToggleState state)
	{
	}

	[Token(Token = "0x6001022")]
	[Address(RVA = "0x61FDB0", Offset = "0x61EBB0", Length = "0x4B4")]
	private void UpdateChildStatus(bool forceUpdate)
	{
	}

	[Token(Token = "0x6001023")]
	[Address(RVA = "0x620270", Offset = "0x61F070", Length = "0x12C")]
	private bool ShouldEnableChildren()
	{
		return false;
	}

	[Token(Token = "0x6001024")]
	[Address(RVA = "0x6203A0", Offset = "0x61F1A0", Length = "0x4A")]
	public AuroraActivatedToggle()
	{
	}
}
