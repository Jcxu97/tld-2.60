using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

namespace TLD.Gameplay;

[Token(Token = "0x200148A")]
public class MiseryHUD : MonoBehaviour
{
	[SerializeField]
	[Token(Token = "0x4009513")]
	[FieldOffset(Offset = "0x20")]
	private GameObject m_ElementParent;

	[SerializeField]
	[Token(Token = "0x4009514")]
	[FieldOffset(Offset = "0x28")]
	private UILabel m_StageLabel;

	[SerializeField]
	[Token(Token = "0x4009515")]
	[FieldOffset(Offset = "0x30")]
	private UILabel m_StageNameLabel;

	[SerializeField]
	[Token(Token = "0x4009516")]
	[FieldOffset(Offset = "0x38")]
	private LocalizedString m_StageText;

	[Token(Token = "0x4009517")]
	[FieldOffset(Offset = "0x40")]
	private int m_QueuedStage;

	[Token(Token = "0x4009518")]
	[FieldOffset(Offset = "0x48")]
	private string m_QueuedStageNameLocId;

	[Token(Token = "0x4009519")]
	[FieldOffset(Offset = "0x50")]
	private int m_ActiveTweens;

	[Token(Token = "0x400951A")]
	[FieldOffset(Offset = "0x58")]
	private readonly List<UITweener> m_Tweens;

	[Token(Token = "0x17000B54")]
	private bool IsShowing
	{
		[Token(Token = "0x6008275")]
		[Address(RVA = "0x1239160", Offset = "0x1237F60", Length = "0x8")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x6008276")]
	[Address(RVA = "0x1239170", Offset = "0x1237F70", Length = "0x387")]
	private void Awake()
	{
	}

	[Token(Token = "0x6008277")]
	[Address(RVA = "0x1239500", Offset = "0x1238300", Length = "0x81")]
	public void EnqueueStage(int stage, string stageNameLocId)
	{
	}

	[Token(Token = "0x6008278")]
	[Address(RVA = "0x1239590", Offset = "0x1238390", Length = "0xAD")]
	private void Update()
	{
	}

	[Token(Token = "0x6008279")]
	[Address(RVA = "0x1239640", Offset = "0x1238440", Length = "0x73")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x600827A")]
	[Address(RVA = "0x12396C0", Offset = "0x12384C0", Length = "0x372")]
	private void ShowQueuedStageUI()
	{
	}

	[Token(Token = "0x600827B")]
	[Address(RVA = "0x1239A40", Offset = "0x1238840", Length = "0x11")]
	private void OnTweenComplete()
	{
	}

	[Token(Token = "0x600827C")]
	[Address(RVA = "0x1239A60", Offset = "0x1238860", Length = "0x34A")]
	private void ResetAndDisable()
	{
	}

	[Token(Token = "0x600827D")]
	[Address(RVA = "0x1239DB0", Offset = "0x1238BB0", Length = "0xF2")]
	public MiseryHUD()
	{
	}
}
