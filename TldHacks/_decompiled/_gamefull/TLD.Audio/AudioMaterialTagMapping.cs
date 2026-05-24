using AK.Wwise;
using Cpp2ILInjected;
using UnityEngine;

namespace TLD.Audio;

[CreateAssetMenu(menuName = "The Long Dark/Audio/Tag Mapping")]
[Token(Token = "0x20014E9")]
public class AudioMaterialTagMapping : ScriptableObject
{
	[SerializeField]
	[Token(Token = "0x4009743")]
	[FieldOffset(Offset = "0x18")]
	private AK.Wwise.Switch m_Default;

	[SerializeField]
	[Token(Token = "0x4009744")]
	[FieldOffset(Offset = "0x20")]
	private string[] m_Tags;

	[SerializeField]
	[Token(Token = "0x4009745")]
	[FieldOffset(Offset = "0x28")]
	private AK.Wwise.Switch[] m_Switches;

	[Token(Token = "0x6008415")]
	[Address(RVA = "0x1258B30", Offset = "0x1257930", Length = "0x1BF")]
	public void SetSwitchByTag(string tag, GameObject emitter)
	{
	}

	[Token(Token = "0x6008416")]
	[Address(RVA = "0x4A22A0", Offset = "0x4A10A0", Length = "0x7")]
	public AudioMaterialTagMapping()
	{
	}
}
