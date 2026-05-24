using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20005E4")]
public class HUDChapter : MonoBehaviour
{
	[Token(Token = "0x4003670")]
	[FieldOffset(Offset = "0x20")]
	public UILabel m_ChapterName;

	[Token(Token = "0x4003671")]
	[FieldOffset(Offset = "0x28")]
	public UILabel m_ChapterNumber;

	[HideInInspector]
	[Token(Token = "0x4003672")]
	[FieldOffset(Offset = "0x30")]
	public bool m_RestoreDisplay;

	[Token(Token = "0x4003673")]
	[FieldOffset(Offset = "0x34")]
	private int m_ActiveTweens;

	[Token(Token = "0x4003674")]
	[FieldOffset(Offset = "0x38")]
	private List<UITweener> m_Tweens;

	[Token(Token = "0x6002DA1")]
	[Address(RVA = "0x951910", Offset = "0x950710", Length = "0x399")]
	public void Disable()
	{
	}

	[Token(Token = "0x6002DA2")]
	[Address(RVA = "0x951CB0", Offset = "0x950AB0", Length = "0x427")]
	public void Enqueue(string id)
	{
	}

	[Token(Token = "0x6002DA3")]
	[Address(RVA = "0x9520E0", Offset = "0x950EE0", Length = "0x113")]
	public string GetDebugText()
	{
		return null;
	}

	[Token(Token = "0x6002DA4")]
	[Address(RVA = "0x952200", Offset = "0x951000", Length = "0x62")]
	public void HideDisplay()
	{
	}

	[Token(Token = "0x6002DA5")]
	[Address(RVA = "0x952270", Offset = "0x951070", Length = "0x9F")]
	public bool IsActive()
	{
		return false;
	}

	[Token(Token = "0x6002DA6")]
	[Address(RVA = "0x952310", Offset = "0x951110", Length = "0x6E")]
	public void RestoreDisplay()
	{
	}

	[Token(Token = "0x6002DA7")]
	[Address(RVA = "0x952380", Offset = "0x951180", Length = "0x510")]
	private void Awake()
	{
	}

	[Token(Token = "0x6002DA8")]
	[Address(RVA = "0x9528A0", Offset = "0x9516A0", Length = "0x347")]
	private void OnTweenComplete()
	{
	}

	[Token(Token = "0x6002DA9")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public HUDChapter()
	{
	}
}
