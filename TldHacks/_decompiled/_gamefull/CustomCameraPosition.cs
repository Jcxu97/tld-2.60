using System;
using Cpp2ILInjected;
using TLD.Interactions;
using TLD.ModularElectrolizer;
using TLD.UI.Generics;
using UnityEngine;

[Token(Token = "0x2000575")]
public class CustomCameraPosition : MonoBehaviour
{
	[Token(Token = "0x2000576")]
	public enum State
	{
		[Token(Token = "0x400323A")]
		Inactive,
		[Token(Token = "0x400323B")]
		Activating,
		[Token(Token = "0x400323C")]
		Active
	}

	[SerializeField]
	[Token(Token = "0x4003233")]
	[FieldOffset(Offset = "0x20")]
	private PanelReference<Panel_HUD> m_HUD;

	[SerializeField]
	[Token(Token = "0x4003234")]
	[FieldOffset(Offset = "0x28")]
	private bool m_InteractOnlyFromFront;

	[SerializeField]
	[Token(Token = "0x4003235")]
	[FieldOffset(Offset = "0x30")]
	private Transform m_CameraTarget;

	[HideInInspector]
	[Token(Token = "0x4003236")]
	[FieldOffset(Offset = "0x38")]
	public Action<State> m_OnStateChange;

	[Token(Token = "0x4003237")]
	[FieldOffset(Offset = "0x40")]
	private State m_State;

	[Token(Token = "0x4003238")]
	[FieldOffset(Offset = "0x48")]
	private AuroraModularElectrolizer m_Electrolizer;

	[Token(Token = "0x6002A01")]
	[Address(RVA = "0x8F7590", Offset = "0x8F6390", Length = "0x8C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6002A02")]
	[Address(RVA = "0x8F7620", Offset = "0x8F6420", Length = "0xA")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6002A03")]
	[Address(RVA = "0x8F7630", Offset = "0x8F6430", Length = "0x16A")]
	private void Update()
	{
	}

	[Token(Token = "0x6002A04")]
	[Address(RVA = "0x8F77A0", Offset = "0x8F65A0", Length = "0x256")]
	private bool AnyButtonsOrKeysPressed()
	{
		return false;
	}

	[Token(Token = "0x6002A05")]
	[Address(RVA = "0x8F7A00", Offset = "0x8F6800", Length = "0x97")]
	private void SetState(State newState)
	{
	}

	[Token(Token = "0x6002A06")]
	[Address(RVA = "0x8F7AA0", Offset = "0x8F68A0", Length = "0x11B")]
	public void UpdateInteraction(BaseInteraction baseInteraction)
	{
	}

	[Token(Token = "0x6002A07")]
	[Address(RVA = "0x8F7BC0", Offset = "0x8F69C0", Length = "0xFB")]
	private bool CanInteract()
	{
		return false;
	}

	[Token(Token = "0x6002A08")]
	[Address(RVA = "0x8F7CC0", Offset = "0x8F6AC0", Length = "0x91")]
	public void PerformInteraction()
	{
	}

	[Token(Token = "0x6002A09")]
	[Address(RVA = "0x8F7D60", Offset = "0x8F6B60", Length = "0x8")]
	public bool GetIsActive()
	{
		return false;
	}

	[Token(Token = "0x6002A0A")]
	[Address(RVA = "0x8F7D70", Offset = "0x8F6B70", Length = "0x26D")]
	private bool IsPlayerCameraPositionValid()
	{
		return false;
	}

	[Token(Token = "0x6002A0B")]
	[Address(RVA = "0x8F7FE0", Offset = "0x8F6DE0", Length = "0xF3")]
	private bool IsInteractible()
	{
		return false;
	}

	[Token(Token = "0x6002A0C")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public CustomCameraPosition()
	{
	}
}
