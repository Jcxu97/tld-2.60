using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000209")]
public class ButtonLegend : MonoBehaviour
{
	[Token(Token = "0x4001274")]
	[FieldOffset(Offset = "0x20")]
	public GameObject ButtonLegendItemPrefab;

	[Token(Token = "0x4001275")]
	[FieldOffset(Offset = "0x28")]
	public ButtonLegendAtlas m_ButtonLegendAtlas;

	[HideInInspector]
	[Token(Token = "0x4001276")]
	[FieldOffset(Offset = "0x30")]
	public bool m_OverrideIsControllerActive;

	[Token(Token = "0x4001277")]
	[FieldOffset(Offset = "0x38")]
	public UITable m_Table;

	[Token(Token = "0x4001278")]
	[FieldOffset(Offset = "0x40")]
	public bool m_OverrideDepth;

	[Token(Token = "0x4001279")]
	[FieldOffset(Offset = "0x44")]
	public int m_Depth;

	[Token(Token = "0x400127A")]
	[FieldOffset(Offset = "0x48")]
	private Dictionary<string, ButtonLegendItem> m_ButtonLegendItems;

	[Token(Token = "0x400127B")]
	[FieldOffset(Offset = "0x50")]
	private bool m_UpdateInProgress;

	[Token(Token = "0x400127C")]
	[FieldOffset(Offset = "0x51")]
	private bool m_Reposition;

	[Token(Token = "0x400127D")]
	[FieldOffset(Offset = "0x52")]
	private bool m_LastFrameWasController;

	[Token(Token = "0x400127E")]
	[FieldOffset(Offset = "0x53")]
	private bool m_IsDirty;

	[Token(Token = "0x600126F")]
	[Address(RVA = "0x651240", Offset = "0x650040", Length = "0xE6")]
	public void Awake()
	{
	}

	[Token(Token = "0x6001270")]
	[Address(RVA = "0x651330", Offset = "0x650130", Length = "0x59C")]
	public void LateUpdate()
	{
	}

	[Token(Token = "0x6001271")]
	[Address(RVA = "0x6518D0", Offset = "0x6506D0", Length = "0x3BC")]
	public void Clear()
	{
	}

	[Token(Token = "0x6001272")]
	[Address(RVA = "0x651C90", Offset = "0x650A90", Length = "0x9")]
	public void BeginUpdate()
	{
	}

	[Token(Token = "0x6001273")]
	[Address(RVA = "0x651CA0", Offset = "0x650AA0", Length = "0x29")]
	public void UpdateButton(string action, string localizationKey, bool active, int priority, bool localize)
	{
	}

	[Token(Token = "0x6001274")]
	[Address(RVA = "0x651CD0", Offset = "0x650AD0", Length = "0x1E")]
	public ButtonIcon GetButtonIconSpriteName(string action)
	{
		return null;
	}

	[Token(Token = "0x6001275")]
	[Address(RVA = "0x651CF0", Offset = "0x650AF0", Length = "0x5E")]
	public void ConfigureButtonIconSpriteName(string action, ref UISprite buttonSprite)
	{
	}

	[Token(Token = "0x6001276")]
	[Address(RVA = "0x651D50", Offset = "0x650B50", Length = "0x1D")]
	public void ForceButtonSpriteName(string spriteName, ref UISprite buttonSprite)
	{
	}

	[Token(Token = "0x6001277")]
	[Address(RVA = "0x651D70", Offset = "0x650B70", Length = "0x2D1")]
	public void AddButton(string action, string localizationKey, int priority, bool localize)
	{
	}

	[Token(Token = "0x6001278")]
	[Address(RVA = "0x652050", Offset = "0x650E50", Length = "0x468")]
	public void RemoveButton(string action)
	{
	}

	[Token(Token = "0x6001279")]
	[Address(RVA = "0x6524C0", Offset = "0x6512C0", Length = "0x93")]
	public void EndUpdate()
	{
	}

	[Token(Token = "0x600127A")]
	[Address(RVA = "0x652560", Offset = "0x651360", Length = "0x504")]
	private ButtonLegendItem CreatePrefab()
	{
		return null;
	}

	[Token(Token = "0x600127B")]
	[Address(RVA = "0x652A70", Offset = "0x651870", Length = "0x212")]
	private int OnSort(Transform a, Transform b)
	{
		return 0;
	}

	[Token(Token = "0x600127C")]
	[Address(RVA = "0x652C90", Offset = "0x651A90", Length = "0x37")]
	private void RepositionTable()
	{
	}

	[Token(Token = "0x600127D")]
	[Address(RVA = "0x652CD0", Offset = "0x651AD0", Length = "0xE3")]
	public ButtonLegend()
	{
	}
}
