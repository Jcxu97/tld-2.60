using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20009C3")]
public class IceCrackingTrigger : MonoBehaviour
{
	[Token(Token = "0x4006371")]
	[FieldOffset(Offset = "0x20")]
	public float m_SecondsBeforeIceCracks;

	[Token(Token = "0x4006372")]
	[FieldOffset(Offset = "0x28")]
	public string m_FallThroughIceAudio;

	[Token(Token = "0x4006373")]
	[FieldOffset(Offset = "0x30")]
	public bool m_KillPlayer;

	[Token(Token = "0x4006374")]
	[FieldOffset(Offset = "0x38")]
	public string m_KillPlayerDeathCauseLocId;

	[Token(Token = "0x4006375")]
	[FieldOffset(Offset = "0x40")]
	public List<ClothingRegion> m_ClothingRegionsToMakeWet;

	[Token(Token = "0x4006376")]
	[FieldOffset(Offset = "0x48")]
	public bool m_SetLayerToTriggerIgnoreRaycast;

	[Token(Token = "0x4006377")]
	[FieldOffset(Offset = "0x49")]
	private bool m_PlayerInTrigger;

	[Token(Token = "0x4006378")]
	[FieldOffset(Offset = "0x4C")]
	private float m_IceCrackingTimer;

	[Token(Token = "0x4006379")]
	[FieldOffset(Offset = "0x50")]
	private Vector3 m_RespawnLocation;

	[Token(Token = "0x400637A")]
	private static bool m_FallingIntoWater;

	[Token(Token = "0x400637B")]
	[FieldOffset(Offset = "0x60")]
	private Collider[] m_Colliders;

	[Token(Token = "0x6005661")]
	[Address(RVA = "0xEB7A40", Offset = "0xEB6840", Length = "0x8C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6005662")]
	[Address(RVA = "0xEB7AD0", Offset = "0xEB68D0", Length = "0x154")]
	private void Start()
	{
	}

	[Token(Token = "0x6005663")]
	[Address(RVA = "0xEB7C30", Offset = "0xEB6A30", Length = "0xC5")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6005664")]
	[Address(RVA = "0xEB7D00", Offset = "0xEB6B00", Length = "0x125")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6005665")]
	[Address(RVA = "0xEB7E30", Offset = "0xEB6C30", Length = "0xB2")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x6005666")]
	[Address(RVA = "0xEB7EF0", Offset = "0xEB6CF0", Length = "0xC8")]
	public bool TryUpdateTimer()
	{
		return false;
	}

	[Token(Token = "0x6005667")]
	[Address(RVA = "0xEB7FC0", Offset = "0xEB6DC0", Length = "0xB")]
	public bool IsTimerFinished()
	{
		return false;
	}

	[Token(Token = "0x6005668")]
	[Address(RVA = "0xEB7FD0", Offset = "0xEB6DD0", Length = "0x213")]
	public bool Overlaps(Collider testedCollider)
	{
		return false;
	}

	[Token(Token = "0x6005669")]
	[Address(RVA = "0xEB81F0", Offset = "0xEB6FF0", Length = "0x2C1")]
	public void FallInWater()
	{
	}

	[Token(Token = "0x600566A")]
	[Address(RVA = "0xEB84C0", Offset = "0xEB72C0", Length = "0x610")]
	private void DidFallThroughIceFadeOut()
	{
	}

	[Token(Token = "0x600566B")]
	[Address(RVA = "0xEB8AE0", Offset = "0xEB78E0", Length = "0x112")]
	private void DidFallThroughIceFadeIn()
	{
	}

	[Token(Token = "0x600566C")]
	[Address(RVA = "0xEB8C00", Offset = "0xEB7A00", Length = "0x89")]
	private void ExitStruggleIfActive()
	{
	}

	[Token(Token = "0x600566D")]
	[Address(RVA = "0xEB8C90", Offset = "0xEB7A90", Length = "0x475")]
	private void ExtinguishLitItemInHands()
	{
	}

	[Token(Token = "0x600566E")]
	[Address(RVA = "0xEB9110", Offset = "0xEB7F10", Length = "0x242")]
	private void BreakIce()
	{
	}

	[Token(Token = "0x600566F")]
	[Address(RVA = "0xEB9360", Offset = "0xEB8160", Length = "0x2B1")]
	private void MakeClothesWet()
	{
	}

	[Token(Token = "0x6005670")]
	[Address(RVA = "0xEB9620", Offset = "0xEB8420", Length = "0xC6")]
	public IceCrackingTrigger()
	{
	}
}
