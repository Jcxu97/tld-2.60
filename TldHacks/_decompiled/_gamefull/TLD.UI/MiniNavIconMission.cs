using Cpp2ILInjected;
using TLD.UI.Generics;
using UnityEngine;

namespace TLD.UI;

[Token(Token = "0x200138D")]
public class MiniNavIconMission : MonoBehaviour
{
	[Token(Token = "0x4008F9E")]
	private const string m_TalesSpriteName = "ico_TalesObjectives";

	[Token(Token = "0x4008F9F")]
	private const string m_MissionsSpriteName = "ico_map_offscreen";

	[SerializeField]
	[Token(Token = "0x4008FA0")]
	[FieldOffset(Offset = "0x20")]
	private PanelReference<Panel_MissionsStory> m_MissionsStory;

	[Token(Token = "0x6007CE0")]
	[Address(RVA = "0x11C01F0", Offset = "0x11BEFF0", Length = "0x6E")]
	private bool AreTalesAvailable()
	{
		return false;
	}

	[Token(Token = "0x6007CE1")]
	[Address(RVA = "0x11C0260", Offset = "0x11BF060", Length = "0x146")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6007CE2")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public MiniNavIconMission()
	{
	}
}
