using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200060C")]
public class Panel_Base : MonoBehaviour
{
	[Token(Token = "0x400387C")]
	[FieldOffset(Offset = "0x20")]
	protected UIPanel m_Panel;

	[Token(Token = "0x170002DB")]
	public virtual bool RenderGameCamera
	{
		[Token(Token = "0x6002F56")]
		[Address(RVA = "0x430B50", Offset = "0x42F950", Length = "0x3")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x6002F57")]
	[Address(RVA = "0x988500", Offset = "0x987300", Length = "0x8C")]
	public virtual void Initialize()
	{
	}

	[Token(Token = "0x6002F58")]
	[Address(RVA = "0x649950", Offset = "0x648750", Length = "0x9F")]
	public virtual bool IsEnabled()
	{
		return false;
	}

	[Token(Token = "0x6002F59")]
	[Address(RVA = "0x988590", Offset = "0x987390", Length = "0xA5")]
	public virtual void Enable(bool enable)
	{
	}

	[Token(Token = "0x6002F5A")]
	[Address(RVA = "0x430B50", Offset = "0x42F950", Length = "0x3")]
	public virtual bool IsOverlayPanel()
	{
		return false;
	}

	[Token(Token = "0x6002F5B")]
	[Address(RVA = "0x430B50", Offset = "0x42F950", Length = "0x3")]
	public virtual bool CanBeDestroyed()
	{
		return false;
	}

	[Token(Token = "0x6002F5C")]
	[Address(RVA = "0x988640", Offset = "0x987440", Length = "0x41")]
	public virtual void CloseSelf()
	{
	}

	[Token(Token = "0x6002F5D")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public Panel_Base()
	{
	}
}
