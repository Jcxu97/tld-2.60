using Cpp2ILInjected;
using TLD.OptionalContent;
using UnityEngine;

namespace TLD.Rendering;

[Token(Token = "0x200136D")]
public class DynamicResolutionConfig : ScriptableObject
{
	[Header("Static Scaling")]
	[SerializeField]
	[Token(Token = "0x4008EDD")]
	[FieldOffset(Offset = "0x18")]
	private float m_StaticScalingMin;

	[SerializeField]
	[Token(Token = "0x4008EDE")]
	[FieldOffset(Offset = "0x1C")]
	private float m_StaticScalingMax;

	[Header("Platform Configs")]
	[SerializeField]
	[Token(Token = "0x4008EDF")]
	[FieldOffset(Offset = "0x20")]
	private DynamicResolutionPlatformConfig m_XboxOne;

	[SerializeField]
	[Token(Token = "0x4008EE0")]
	[FieldOffset(Offset = "0x28")]
	private DynamicResolutionPlatformConfig m_XboxOneS;

	[SerializeField]
	[Token(Token = "0x4008EE1")]
	[FieldOffset(Offset = "0x30")]
	private DynamicResolutionPlatformConfig m_XboxOneX;

	[SerializeField]
	[Token(Token = "0x4008EE2")]
	[FieldOffset(Offset = "0x38")]
	private DynamicResolutionPlatformConfig m_XboxSeriesS;

	[SerializeField]
	[Token(Token = "0x4008EE3")]
	[FieldOffset(Offset = "0x40")]
	private DynamicResolutionPlatformConfig m_XboxSeriesX;

	[SerializeField]
	[Token(Token = "0x4008EE4")]
	[FieldOffset(Offset = "0x48")]
	private DynamicResolutionPlatformConfig m_PS4;

	[SerializeField]
	[Token(Token = "0x4008EE5")]
	[FieldOffset(Offset = "0x50")]
	private DynamicResolutionPlatformConfig m_PS4Pro;

	[SerializeField]
	[Token(Token = "0x4008EE6")]
	[FieldOffset(Offset = "0x58")]
	private DynamicResolutionPlatformConfig m_PS5;

	[SerializeField]
	[Token(Token = "0x4008EE7")]
	[FieldOffset(Offset = "0x60")]
	private DynamicResolutionPlatformConfig m_SwitchHandheld;

	[SerializeField]
	[Token(Token = "0x4008EE8")]
	[FieldOffset(Offset = "0x68")]
	private DynamicResolutionPlatformConfig m_SwitchDocked;

	[SerializeField]
	[Token(Token = "0x4008EE9")]
	[FieldOffset(Offset = "0x70")]
	private DynamicResolutionPlatformConfig m_SwitchDockedBaseGameOnly;

	[SerializeField]
	[Token(Token = "0x4008EEA")]
	[FieldOffset(Offset = "0x78")]
	private DynamicResolutionPlatformConfig m_SteamDeck;

	[Header("DLC Config")]
	[SerializeField]
	[Token(Token = "0x4008EEB")]
	[FieldOffset(Offset = "0x80")]
	private OptionalContentConfig m_DLCConfig;

	[Token(Token = "0x17000A77")]
	public float StaticScalingMin
	{
		[Token(Token = "0x6007C12")]
		[Address(RVA = "0x4A7A60", Offset = "0x4A6860", Length = "0x6")]
		get
		{
			return 0f;
		}
	}

	[Token(Token = "0x17000A78")]
	public float StaticScalingMax
	{
		[Token(Token = "0x6007C13")]
		[Address(RVA = "0x5042D0", Offset = "0x5030D0", Length = "0x6")]
		get
		{
			return 0f;
		}
	}

	[Token(Token = "0x6007C14")]
	[Address(RVA = "0x11AF000", Offset = "0x11ADE00", Length = "0x9B")]
	public DynamicResolutionPlatformConfig GetPlatformConfig()
	{
		return null;
	}

	[Token(Token = "0x6007C15")]
	[Address(RVA = "0x11AF0A0", Offset = "0x11ADEA0", Length = "0x15")]
	public DynamicResolutionConfig()
	{
	}
}
