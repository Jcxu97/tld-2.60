using Cpp2ILInjected;
using UnityEngine;

namespace VLB;

[DisallowMultipleComponent]
[RequireComponent(typeof(VolumetricLightBeam))]
[HelpURL("http://saladgamer.com/vlb-doc/comp-triggerzone/")]
[Token(Token = "0x2000BEB")]
public class TriggerZone : MonoBehaviour
{
	[Token(Token = "0x2000BEC")]
	private enum TriggerZoneUpdateRate
	{
		[Token(Token = "0x400799F")]
		OnEnable,
		[Token(Token = "0x40079A0")]
		OnOcclusionChange
	}

	[Token(Token = "0x4007998")]
	[FieldOffset(Offset = "0x20")]
	public bool setIsTrigger;

	[Token(Token = "0x4007999")]
	[FieldOffset(Offset = "0x24")]
	public float rangeMultiplier;

	[Token(Token = "0x400799A")]
	private const int kMeshColliderNumSides = 8;

	[Token(Token = "0x400799B")]
	[FieldOffset(Offset = "0x28")]
	private VolumetricLightBeam m_Beam;

	[Token(Token = "0x400799C")]
	[FieldOffset(Offset = "0x30")]
	private DynamicOcclusionRaycasting m_DynamicOcclusionRaycasting;

	[Token(Token = "0x400799D")]
	[FieldOffset(Offset = "0x38")]
	private PolygonCollider2D m_PolygonCollider2D;

	[Token(Token = "0x170003E9")]
	private TriggerZoneUpdateRate updateRate
	{
		[Token(Token = "0x6005DCD")]
		[Address(RVA = "0xF6B090", Offset = "0xF69E90", Length = "0xED")]
		get
		{
			return default(TriggerZoneUpdateRate);
		}
	}

	[Token(Token = "0x6005DCE")]
	[Address(RVA = "0xF6B180", Offset = "0xF69F80", Length = "0x384")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6005DCF")]
	[Address(RVA = "0xF6B510", Offset = "0xF6A310", Length = "0x7")]
	private void OnOcclusionProcessed()
	{
	}

	[Token(Token = "0x6005DD0")]
	[Address(RVA = "0xF6B520", Offset = "0xF6A320", Length = "0xBF2")]
	private void ComputeZone()
	{
	}

	[Token(Token = "0x6005DD1")]
	[Address(RVA = "0xF6C120", Offset = "0xF6AF20", Length = "0x4E")]
	public TriggerZone()
	{
	}
}
