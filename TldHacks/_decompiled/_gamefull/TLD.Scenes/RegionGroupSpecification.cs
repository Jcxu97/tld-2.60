using Cpp2ILInjected;
using UnityEngine;

namespace TLD.Scenes;

[CreateAssetMenu(menuName = "The Long Dark/Scenes/Region Group")]
[Token(Token = "0x200135D")]
public class RegionGroupSpecification : ScriptableObject
{
	[SerializeField]
	[Token(Token = "0x4008E96")]
	[FieldOffset(Offset = "0x18")]
	private LocalizedString m_GroupName;

	[Token(Token = "0x17000A56")]
	public string Name
	{
		[Token(Token = "0x6007BA6")]
		[Address(RVA = "0x11A8400", Offset = "0x11A7200", Length = "0x1B")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A57")]
	public string LocalizedName
	{
		[Token(Token = "0x6007BA7")]
		[Address(RVA = "0xD90180", Offset = "0xD8EF80", Length = "0x5D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007BA8")]
	[Address(RVA = "0x4A22A0", Offset = "0x4A10A0", Length = "0x7")]
	public RegionGroupSpecification()
	{
	}
}
