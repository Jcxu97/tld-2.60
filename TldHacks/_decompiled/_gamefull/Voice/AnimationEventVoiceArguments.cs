using AK.Wwise;
using Cpp2ILInjected;
using UnityEngine;

namespace Voice;

[CreateAssetMenu(menuName = "The Long Dark/Audio/Voice Animation Event Arguments")]
[Token(Token = "0x200132E")]
public class AnimationEventVoiceArguments : ScriptableObject
{
	[SerializeField]
	[Token(Token = "0x4008DA0")]
	[FieldOffset(Offset = "0x18")]
	private AK.Wwise.Event m_Event;

	[SerializeField]
	[Token(Token = "0x4008DA1")]
	[FieldOffset(Offset = "0x20")]
	private Priority m_Priority;

	[SerializeField]
	[Token(Token = "0x4008DA2")]
	[FieldOffset(Offset = "0x24")]
	private PlayerVoice.Options m_Options;

	[Token(Token = "0x17000A47")]
	public AK.Wwise.Event Event
	{
		[Token(Token = "0x6007AFE")]
		[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A48")]
	public Priority Priority
	{
		[Token(Token = "0x6007AFF")]
		[Address(RVA = "0x4571E0", Offset = "0x455FE0", Length = "0x4")]
		get
		{
			return default(Priority);
		}
	}

	[Token(Token = "0x17000A49")]
	public PlayerVoice.Options Options
	{
		[Token(Token = "0x6007B00")]
		[Address(RVA = "0x4AA8A0", Offset = "0x4A96A0", Length = "0x4")]
		get
		{
			return default(PlayerVoice.Options);
		}
	}

	[Token(Token = "0x6007B01")]
	[Address(RVA = "0x4A22A0", Offset = "0x4A10A0", Length = "0x7")]
	public AnimationEventVoiceArguments()
	{
	}
}
