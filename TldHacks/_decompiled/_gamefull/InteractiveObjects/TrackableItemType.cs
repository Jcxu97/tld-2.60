using AK.Wwise;
using Cpp2ILInjected;
using UnityEngine;

namespace InteractiveObjects;

[CreateAssetMenu(menuName = "The Long Dark/Trackable Item/Create a Trackable Item Type")]
[Token(Token = "0x2001327")]
public class TrackableItemType : ScriptableObject
{
	[Token(Token = "0x4008D7D")]
	[FieldOffset(Offset = "0x18")]
	public string m_SpriteName;

	[Token(Token = "0x4008D7E")]
	[FieldOffset(Offset = "0x20")]
	public Color m_ShortwaveLightColor;

	[Token(Token = "0x4008D7F")]
	[FieldOffset(Offset = "0x30")]
	public AK.Wwise.Event m_SwitchTrackingModeAudioEvent;

	[Token(Token = "0x6007AC7")]
	[Address(RVA = "0x4A22A0", Offset = "0x4A10A0", Length = "0x7")]
	public TrackableItemType()
	{
	}
}
