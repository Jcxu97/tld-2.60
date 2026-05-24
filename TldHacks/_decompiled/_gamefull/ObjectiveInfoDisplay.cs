using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20005FF")]
public class ObjectiveInfoDisplay : MonoBehaviour
{
	[Token(Token = "0x2000600")]
	public delegate void OnObjectiveDisplayComplete();

	[Token(Token = "0x4003747")]
	[FieldOffset(Offset = "0x20")]
	public UILabel m_Info;

	[Token(Token = "0x4003748")]
	[FieldOffset(Offset = "0x28")]
	public UILabel m_Status;

	[Token(Token = "0x4003749")]
	[FieldOffset(Offset = "0x30")]
	public OnObjectiveDisplayComplete m_CompleteDelegate;

	[HideInInspector]
	[Token(Token = "0x400374A")]
	[FieldOffset(Offset = "0x38")]
	public string m_MissionId;

	[Token(Token = "0x400374B")]
	[FieldOffset(Offset = "0x40")]
	private int m_ActiveTweens;

	[Token(Token = "0x400374C")]
	[FieldOffset(Offset = "0x48")]
	private List<UITweener> m_Tweens;

	[Token(Token = "0x6002E5B")]
	[Address(RVA = "0x964B30", Offset = "0x963930", Length = "0x426")]
	public void Awake()
	{
	}

	[Token(Token = "0x6002E5C")]
	[Address(RVA = "0x964F60", Offset = "0x963D60", Length = "0x3EF")]
	public void Disable()
	{
	}

	[Token(Token = "0x6002E5D")]
	[Address(RVA = "0x965350", Offset = "0x964150", Length = "0x8")]
	public bool IsActive()
	{
		return false;
	}

	[Token(Token = "0x6002E5E")]
	[Address(RVA = "0x965360", Offset = "0x964160", Length = "0x359")]
	public void Show(string statusLocID, Color statusColor, string infoLocID, string missionId)
	{
	}

	[Token(Token = "0x6002E5F")]
	[Address(RVA = "0x9656C0", Offset = "0x9644C0", Length = "0x3E")]
	private void OnTweenComplete()
	{
	}

	[Token(Token = "0x6002E60")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public ObjectiveInfoDisplay()
	{
	}
}
