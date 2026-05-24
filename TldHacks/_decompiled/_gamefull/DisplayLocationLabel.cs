using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.UI.Generics;
using UnityEngine;

[Token(Token = "0x20005D7")]
public class DisplayLocationLabel : MonoBehaviour
{
	[Token(Token = "0x40035E2")]
	[FieldOffset(Offset = "0x20")]
	public LocalizedString m_LocalizedLabel;

	[SerializeField]
	[Token(Token = "0x40035E3")]
	[FieldOffset(Offset = "0x28")]
	private PanelReference<Panel_HUD> m_HUD;

	[Token(Token = "0x40035E4")]
	[FieldOffset(Offset = "0x30")]
	private bool m_DisplayedLabel;

	[Token(Token = "0x40035E5")]
	[FieldOffset(Offset = "0x31")]
	private bool m_Logged;

	[Token(Token = "0x40035E6")]
	[FieldOffset(Offset = "0x32")]
	private bool m_PlayedStinger;

	[Token(Token = "0x40035E7")]
	[FieldOffset(Offset = "0x34")]
	private float m_NextValidDisplayTime;

	[Token(Token = "0x40035E8")]
	[FieldOffset(Offset = "0x38")]
	private bool m_HasDoneFirstFrame;

	[Token(Token = "0x40035E9")]
	[FieldOffset(Offset = "0x39")]
	private bool m_DoUpdate;

	[Token(Token = "0x40035EA")]
	[FieldOffset(Offset = "0x3A")]
	private bool m_StartHasBeenCalled;

	[Token(Token = "0x40035EB")]
	private static DisplayLocationLabelSaveDataProxy m_DisplayLocationLabelSaveDataProxy;

	[Token(Token = "0x40035EC")]
	private static List<DisplayLocationLabel> m_DisplayLocationLabels;

	[Token(Token = "0x170002D6")]
	public string m_Label
	{
		[Token(Token = "0x6002D41")]
		[Address(RVA = "0x87E130", Offset = "0x87CF30", Length = "0x5D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6002D42")]
	[Address(RVA = "0x944D10", Offset = "0x943B10", Length = "0x10D")]
	private void Awake()
	{
	}

	[Token(Token = "0x6002D43")]
	[Address(RVA = "0x944E20", Offset = "0x943C20", Length = "0x6F")]
	public void Start()
	{
	}

	[Token(Token = "0x6002D44")]
	[Address(RVA = "0x944E90", Offset = "0x943C90", Length = "0x6A")]
	private void Update()
	{
	}

	[Token(Token = "0x6002D45")]
	[Address(RVA = "0x944F00", Offset = "0x943D00", Length = "0x2E0")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x6002D46")]
	[Address(RVA = "0x9451F0", Offset = "0x943FF0", Length = "0x145")]
	public void Deserialize(string text)
	{
	}

	[Token(Token = "0x6002D47")]
	[Address(RVA = "0x945340", Offset = "0x944140", Length = "0x94")]
	public static void Reset()
	{
	}

	[Token(Token = "0x6002D48")]
	[Address(RVA = "0x9453E0", Offset = "0x9441E0", Length = "0x3A0")]
	public static string SerializeAll()
	{
		return null;
	}

	[Token(Token = "0x6002D49")]
	[Address(RVA = "0x945790", Offset = "0x944590", Length = "0x222")]
	public static void DeserializeAll(string text)
	{
	}

	[Token(Token = "0x6002D4A")]
	[Address(RVA = "0x678030", Offset = "0x676E30", Length = "0x5")]
	public bool IsLogged()
	{
		return false;
	}

	[Token(Token = "0x6002D4B")]
	[Address(RVA = "0x9459C0", Offset = "0x9447C0", Length = "0x5")]
	public void DebugMarkLogged()
	{
	}

	[Token(Token = "0x6002D4C")]
	[Address(RVA = "0x9459D0", Offset = "0x9447D0", Length = "0x68F")]
	private void OnTriggerEnter(Collider c)
	{
	}

	[Token(Token = "0x6002D4D")]
	[Address(RVA = "0x946060", Offset = "0x944E60", Length = "0x185")]
	private void OnTriggerExit(Collider c)
	{
	}

	[Token(Token = "0x6002D4E")]
	[Address(RVA = "0x9461F0", Offset = "0x944FF0", Length = "0x33E")]
	private static DisplayLocationLabel FindDisplayLocationLabelByPosition(DisplayLocationLabelSaveDataProxy proxy)
	{
		return null;
	}

	[Token(Token = "0x6002D4F")]
	[Address(RVA = "0x946530", Offset = "0x945330", Length = "0x117")]
	private static DisplayLocationLabel FindDisplayLocationLabelByGuid(string guid)
	{
		return null;
	}

	[Token(Token = "0x6002D50")]
	[Address(RVA = "0x946650", Offset = "0x945450", Length = "0x144")]
	private void MaybeUnlockKnowledge()
	{
	}

	[Token(Token = "0x6002D51")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public DisplayLocationLabel()
	{
	}
}
