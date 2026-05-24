using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20005CC")]
public class ConsoleComboBox : MonoBehaviour
{
	[Token(Token = "0x4003575")]
	[FieldOffset(Offset = "0x20")]
	public GameObject m_Background;

	[Token(Token = "0x4003576")]
	[FieldOffset(Offset = "0x28")]
	public UIButton m_ButtonIncrease;

	[Token(Token = "0x4003577")]
	[FieldOffset(Offset = "0x30")]
	public UIButton m_ButtonDecrease;

	[Token(Token = "0x4003578")]
	[FieldOffset(Offset = "0x38")]
	public UILabel m_LableValue;

	[Token(Token = "0x4003579")]
	[FieldOffset(Offset = "0x40")]
	public UILabel m_LableName;

	[Token(Token = "0x400357A")]
	[FieldOffset(Offset = "0x48")]
	public LocalizedString m_LocalizedToolTip;

	[Token(Token = "0x400357B")]
	[FieldOffset(Offset = "0x50")]
	public List<string> items;

	[Token(Token = "0x400357C")]
	[FieldOffset(Offset = "0x58")]
	public bool m_UseCustomItems;

	[Token(Token = "0x400357D")]
	[FieldOffset(Offset = "0x60")]
	public List<GameObject> m_CustomItems;

	[Token(Token = "0x400357E")]
	[FieldOffset(Offset = "0x68")]
	public bool m_Localize;

	[Token(Token = "0x400357F")]
	[FieldOffset(Offset = "0x6C")]
	private int m_CurrentIndex;

	[Token(Token = "0x4003580")]
	[FieldOffset(Offset = "0x70")]
	private string m_SelectedItem;

	[Token(Token = "0x4003581")]
	[FieldOffset(Offset = "0x78")]
	private bool m_HasStarted;

	[Token(Token = "0x4003582")]
	[FieldOffset(Offset = "0x79")]
	private bool m_Locked;

	[Token(Token = "0x4003583")]
	[FieldOffset(Offset = "0x80")]
	public List<EventDelegate> onChange;

	[Token(Token = "0x4003584")]
	[FieldOffset(Offset = "0x88")]
	private string m_OriginalToolTipLocId;

	[Token(Token = "0x170002D2")]
	public string m_ToolTip
	{
		[Token(Token = "0x6002CEB")]
		[Address(RVA = "0x87D670", Offset = "0x87C470", Length = "0x5D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002D3")]
	public string value
	{
		[Token(Token = "0x6002CEC")]
		[Address(RVA = "0x502690", Offset = "0x501490", Length = "0x5")]
		get
		{
			return null;
		}
		[Token(Token = "0x6002CED")]
		[Address(RVA = "0x93D380", Offset = "0x93C180", Length = "0x14F")]
		set
		{
		}
	}

	[Token(Token = "0x6002CEE")]
	[Address(RVA = "0x93D4D0", Offset = "0x93C2D0", Length = "0xB")]
	public virtual void Start()
	{
	}

	[Token(Token = "0x6002CEF")]
	[Address(RVA = "0x93D4E0", Offset = "0x93C2E0", Length = "0xA0")]
	private void Refresh()
	{
	}

	[Token(Token = "0x6002CF0")]
	[Address(RVA = "0x93D590", Offset = "0x93C390", Length = "0x465")]
	private void RefreshCustomItems()
	{
	}

	[Token(Token = "0x6002CF1")]
	[Address(RVA = "0x8A8580", Offset = "0x8A7380", Length = "0x4")]
	public void Lock(bool locked)
	{
	}

	[Token(Token = "0x6002CF2")]
	[Address(RVA = "0x93DA00", Offset = "0x93C800", Length = "0x232")]
	public void OnIncrease()
	{
	}

	[Token(Token = "0x6002CF3")]
	[Address(RVA = "0x93DC40", Offset = "0x93CA40", Length = "0x232")]
	public void OnDecrease()
	{
	}

	[Token(Token = "0x6002CF4")]
	[Address(RVA = "0x5025C0", Offset = "0x5013C0", Length = "0x4")]
	public int GetCurrentIndex()
	{
		return 0;
	}

	[Token(Token = "0x6002CF5")]
	[Address(RVA = "0x93DE80", Offset = "0x93CC80", Length = "0x57F")]
	public void InitializeLockableOptionUI(bool isUnlocked)
	{
	}

	[Token(Token = "0x6002CF6")]
	[Address(RVA = "0x93E400", Offset = "0x93D200", Length = "0xE")]
	private void OnLocalize()
	{
	}

	[Token(Token = "0x6002CF7")]
	[Address(RVA = "0x93E400", Offset = "0x93D200", Length = "0xE")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6002CF8")]
	[Address(RVA = "0x93E410", Offset = "0x93D210", Length = "0xF2")]
	public ConsoleComboBox()
	{
	}
}
