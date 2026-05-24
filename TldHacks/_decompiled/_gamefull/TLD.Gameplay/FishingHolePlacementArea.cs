using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

namespace TLD.Gameplay;

[RequireComponent(typeof(Collider))]
[Token(Token = "0x2001453")]
public class FishingHolePlacementArea : MonoBehaviour
{
	[Token(Token = "0x40093BC")]
	[FieldOffset(Offset = "0x20")]
	public FishingHolePlacementSettings m_FishingHolePlacementSettings;

	[Token(Token = "0x40093BD")]
	private static List<FishingHolePlacementArea> s_ActiveFishingHolePlacementAreaList;

	[AutoComponent(ComponentRequirement.Required)]
	[SerializeField]
	[Token(Token = "0x40093BE")]
	[FieldOffset(Offset = "0x28")]
	private Collider m_Collider;

	[Token(Token = "0x6008166")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	private void OnValidate()
	{
	}

	[Token(Token = "0x6008167")]
	[Address(RVA = "0x121CB10", Offset = "0x121B910", Length = "0xE8")]
	public static FishingHolePlacementSettings GetActivePlacementSettings()
	{
		return null;
	}

	[Token(Token = "0x6008168")]
	[Address(RVA = "0x121CC00", Offset = "0x121BA00", Length = "0x224")]
	public static bool IsPointInside(Vector3 point)
	{
		return false;
	}

	[Token(Token = "0x6008169")]
	[Address(RVA = "0x121CE30", Offset = "0x121BC30", Length = "0x20")]
	private void Awake()
	{
	}

	[Token(Token = "0x600816A")]
	[Address(RVA = "0x121CE60", Offset = "0x121BC60", Length = "0xBD")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x600816B")]
	[Address(RVA = "0x121CF20", Offset = "0x121BD20", Length = "0x82")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x600816C")]
	[Address(RVA = "0x121CFB0", Offset = "0x121BDB0", Length = "0x82")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600816D")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public FishingHolePlacementArea()
	{
	}
}
