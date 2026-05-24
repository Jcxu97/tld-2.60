using System;
using Cpp2ILInjected;
using TLD.AddressableAssets;
using TLD.GameplayTags;
using UnityEngine;

namespace TLD.Gameplay;

[CreateAssetMenu(menuName = "The Long Dark/Gameplay/Body Harvest/Timeline Set")]
[Token(Token = "0x200149E")]
public class BodyHarvestTimelineSet : ScriptableObject
{
	[Serializable]
	[Token(Token = "0x200149F")]
	private struct HarvestTimeline
	{
		[Token(Token = "0x4009580")]
		[FieldOffset(Offset = "0x0")]
		public GameplayTag m_ToolTag;

		[Token(Token = "0x4009581")]
		[FieldOffset(Offset = "0x10")]
		public AssetReferenceTimeline m_TimelineReference;
	}

	[Header("Camera Settings")]
	[SerializeField]
	[Token(Token = "0x400957A")]
	[FieldOffset(Offset = "0x18")]
	private float m_CameraFOV;

	[Header("Timelines")]
	[SerializeField]
	[Token(Token = "0x400957B")]
	[FieldOffset(Offset = "0x20")]
	private AssetReferenceTimeline m_IntroTimeline;

	[SerializeField]
	[Token(Token = "0x400957C")]
	[FieldOffset(Offset = "0x28")]
	private AssetReferenceTimeline m_LoopTimeline;

	[SerializeField]
	[Token(Token = "0x400957D")]
	[FieldOffset(Offset = "0x30")]
	private HarvestTimeline[] m_HarvestTimelines;

	[SerializeField]
	[Token(Token = "0x400957E")]
	[FieldOffset(Offset = "0x38")]
	private AssetReferenceTimeline m_BarehandedHarvestTimeline;

	[SerializeField]
	[Token(Token = "0x400957F")]
	[FieldOffset(Offset = "0x40")]
	private AssetReferenceTimeline m_ExitTimeline;

	[Token(Token = "0x17000B5A")]
	public float CameraFOV
	{
		[Token(Token = "0x60082CF")]
		[Address(RVA = "0x4A7A60", Offset = "0x4A6860", Length = "0x6")]
		get
		{
			return 0f;
		}
	}

	[Token(Token = "0x17000B5B")]
	public AssetReferenceTimeline IntroTimeline
	{
		[Token(Token = "0x60082D0")]
		[Address(RVA = "0x40E110", Offset = "0x40CF10", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000B5C")]
	public AssetReferenceTimeline LoopTimeline
	{
		[Token(Token = "0x60082D1")]
		[Address(RVA = "0x413AB0", Offset = "0x4128B0", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000B5D")]
	public AssetReferenceTimeline ExitTimeline
	{
		[Token(Token = "0x60082D2")]
		[Address(RVA = "0x4A7D60", Offset = "0x4A6B60", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60082D3")]
	[Address(RVA = "0x123E670", Offset = "0x123D470", Length = "0x1EB")]
	public AssetReferenceTimeline GetHarvestTimeline(GearItem toolUsed)
	{
		return null;
	}

	[Token(Token = "0x60082D4")]
	[Address(RVA = "0x4A22A0", Offset = "0x4A10A0", Length = "0x7")]
	public BodyHarvestTimelineSet()
	{
	}
}
