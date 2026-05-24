using System;
using Cpp2ILInjected;
using UnityEngine;

namespace TLD.UI.Generics;

[Serializable]
[Token(Token = "0x200139B")]
public struct PanelReference<T> where T : Panel_Base
{
	[SerializeField]
	[Token(Token = "0x4008FDE")]
	[FieldOffset(Offset = "0x0")]
	private PanelReference m_PanelReference;

	[Token(Token = "0x6007D2E")]
	[Address(RVA = "0x1E5D230", Offset = "0x1E5C030", Length = "0x14A")]
	public T GetPanel()
	{
		return null;
	}

	[Token(Token = "0x6007D2F")]
	[Address(RVA = "0x1E5D380", Offset = "0x1E5C180", Length = "0x164")]
	public bool TryGetPanel(out T panel)
	{
		panel = null;
		return false;
	}

	[Token(Token = "0x6007D30")]
	[Address(RVA = "0x1E5D4F0", Offset = "0x1E5C2F0", Length = "0x71")]
	public bool IsEnabled()
	{
		return false;
	}

	[Token(Token = "0x6007D31")]
	[Address(RVA = "0x1E5D570", Offset = "0x1E5C370", Length = "0x77")]
	public void TrySetEnabled(bool enable)
	{
	}

	[Token(Token = "0x6007D32")]
	[Address(RVA = "0x1E5D5F0", Offset = "0x1E5C3F0", Length = "0x77")]
	private void InitializeReference()
	{
	}
}
