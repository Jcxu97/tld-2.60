using Cpp2ILInjected;
using UnityEngine;

namespace TLD.UI;

[Token(Token = "0x2001392")]
public abstract class Panel_AutoReferenced : Panel_Base
{
	[SerializeField]
	[PanelReferenceSource]
	[Token(Token = "0x4008FB5")]
	[FieldOffset(Offset = "0x28")]
	protected PanelReference m_SelfReference;

	[Token(Token = "0x17000A94")]
	public PanelReference SelfReference
	{
		[Token(Token = "0x6007CFF")]
		[Address(RVA = "0x413AB0", Offset = "0x4128B0", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007D00")]
	[Address(RVA = "0x11C2C90", Offset = "0x11C1A90", Length = "0x1C3")]
	protected virtual void Awake()
	{
	}

	[Token(Token = "0x6007D01")]
	[Address(RVA = "0x11C2E60", Offset = "0x11C1C60", Length = "0x6B")]
	protected virtual void OnDestroy()
	{
	}

	[Token(Token = "0x6007D02")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	protected Panel_AutoReferenced()
	{
	}
}
