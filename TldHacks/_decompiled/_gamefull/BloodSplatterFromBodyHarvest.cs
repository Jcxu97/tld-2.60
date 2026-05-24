using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.Events;
using UnityEngine;

[Token(Token = "0x2000364")]
public class BloodSplatterFromBodyHarvest : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000365")]
	public class SplatterStage
	{
		[Token(Token = "0x4001DE5")]
		[FieldOffset(Offset = "0x10")]
		public GameEvent m_GameEvent;

		[Token(Token = "0x4001DE6")]
		[FieldOffset(Offset = "0x18")]
		public string m_ShaderPropertyName;

		[Range(0f, 1f)]
		[Token(Token = "0x4001DE7")]
		[FieldOffset(Offset = "0x20")]
		public float m_Strength;

		[Token(Token = "0x6001B90")]
		[Address(RVA = "0x763100", Offset = "0x761F00", Length = "0x8")]
		public SplatterStage()
		{
		}
	}

	[SerializeField]
	[Token(Token = "0x4001DDE")]
	[FieldOffset(Offset = "0x20")]
	private int m_SharedSplatterID;

	[SerializeField]
	[Token(Token = "0x4001DDF")]
	[FieldOffset(Offset = "0x28")]
	private SplatterStage[] m_SplatterStages;

	[SerializeField]
	[Token(Token = "0x4001DE0")]
	[FieldOffset(Offset = "0x30")]
	private GameEvent m_ResetEvent;

	[SerializeField]
	[Token(Token = "0x4001DE1")]
	[FieldOffset(Offset = "0x38")]
	private Renderer[] m_AffectedRenderers;

	[Token(Token = "0x4001DE2")]
	[FieldOffset(Offset = "0x40")]
	private MaterialPropertyBlock m_PropertyBlock;

	[Token(Token = "0x4001DE3")]
	[FieldOffset(Offset = "0x48")]
	private Dictionary<Action, GameEvent> m_GameEventSubscriptions;

	[Token(Token = "0x4001DE4")]
	private static Dictionary<int, HashSet<int>> s_ActivatedSplatterStagesPerID;

	[Token(Token = "0x6001B8A")]
	[Address(RVA = "0x761EA0", Offset = "0x760CA0", Length = "0x782")]
	private void Start()
	{
	}

	[Token(Token = "0x6001B8B")]
	[Address(RVA = "0x762630", Offset = "0x761430", Length = "0x327")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6001B8C")]
	[Address(RVA = "0x762960", Offset = "0x761760", Length = "0x343")]
	private void OnSplatter(int stageIndex)
	{
	}

	[Token(Token = "0x6001B8D")]
	[Address(RVA = "0x762CB0", Offset = "0x761AB0", Length = "0x27A")]
	private void OnReset()
	{
	}

	[Token(Token = "0x6001B8E")]
	[Address(RVA = "0x762F30", Offset = "0x761D30", Length = "0xE3")]
	public BloodSplatterFromBodyHarvest()
	{
	}
}
