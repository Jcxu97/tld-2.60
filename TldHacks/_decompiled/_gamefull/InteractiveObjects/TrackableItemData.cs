using System.Collections.Generic;
using System.ComponentModel;
using Cpp2ILInjected;
using TLD.Scenes.ObjectReferences;
using TLD.Utility;
using UnityEngine;

namespace InteractiveObjects;

[Token(Token = "0x2001322")]
public class TrackableItemData : SceneObjectReference
{
	[SerializeField]
	[EditorReadOnly]
	[Token(Token = "0x4008D64")]
	[FieldOffset(Offset = "0x38")]
	private string m_Guid;

	[SerializeField]
	[EditorReadOnly]
	[Token(Token = "0x4008D65")]
	[FieldOffset(Offset = "0x40")]
	private string m_ActivityTags;

	[Token(Token = "0x4008D66")]
	[FieldOffset(Offset = "0x48")]
	public TrackableItemType m_TrackableItemType;

	[Token(Token = "0x4008D67")]
	[FieldOffset(Offset = "0x50")]
	public TransmitterData m_TransmitterData;

	[Header("Tracking Range")]
	[DefaultValue(250f)]
	[Range(0f, 1000f)]
	[Tooltip("Outermost range of the tracker, in meters. Beyond this it will not detect a trackable cache. Must be the largest range.")]
	[Token(Token = "0x4008D68")]
	[FieldOffset(Offset = "0x58")]
	public float m_MaximumRange;

	[DefaultValue(150f)]
	[Range(0f, 1000f)]
	[Tooltip("Audio starts to play in this range. Must be between the min and max ranges.")]
	[Token(Token = "0x4008D69")]
	[FieldOffset(Offset = "0x5C")]
	public float m_AudioRange;

	[DefaultValue(25f)]
	[Range(0f, 1000f)]
	[Tooltip("This range and below will always show full signal visuals. Must be the smallest ranger.")]
	[Token(Token = "0x4008D6A")]
	[FieldOffset(Offset = "0x60")]
	public float m_FullSignalRange;

	[Token(Token = "0x4008D6B")]
	[FieldOffset(Offset = "0x68")]
	private readonly List<string> m_ResearchSets;

	[Token(Token = "0x17000A35")]
	public string Guid
	{
		[Token(Token = "0x6007AA6")]
		[Address(RVA = "0x4A7D50", Offset = "0x4A6B50", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007AA7")]
	[Address(RVA = "0x1195720", Offset = "0x1194520", Length = "0x80")]
	public bool IsActiveDueToResearchSet(string activeResearchSet)
	{
		return false;
	}

	[Token(Token = "0x6007AA8")]
	[Address(RVA = "0x11957B0", Offset = "0x11945B0", Length = "0x146")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6007AA9")]
	[Address(RVA = "0x1195900", Offset = "0x1194700", Length = "0x20")]
	private void OnValidate()
	{
	}

	[Token(Token = "0x6007AAA")]
	[Address(RVA = "0x1195920", Offset = "0x1194720", Length = "0xEA")]
	public TrackableItemData()
	{
	}
}
