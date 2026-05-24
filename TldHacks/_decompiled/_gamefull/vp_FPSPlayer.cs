using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.Gameplay;
using TLD.UI.Generics;
using UnityEngine;

[RequireComponent(typeof(vp_FPSController))]
[Token(Token = "0x2000010")]
public class vp_FPSPlayer : MonoBehaviour
{
	[Flags]
	[Token(Token = "0x2000011")]
	public enum UnCrouchOptions
	{
		[Token(Token = "0x4000102")]
		None = 0,
		[Token(Token = "0x4000103")]
		CheckHeadroom = 1
	}

	[SerializeField]
	[Token(Token = "0x40000F0")]
	[FieldOffset(Offset = "0x20")]
	private PanelReference<Panel_Loading> m_Loading;

	[HideInInspector]
	[Token(Token = "0x40000F1")]
	[FieldOffset(Offset = "0x28")]
	public vp_FPSCamera FPSCamera;

	[HideInInspector]
	[Token(Token = "0x40000F2")]
	[FieldOffset(Offset = "0x30")]
	public vp_FPSController Controller;

	[HideInInspector]
	[Token(Token = "0x40000F3")]
	[FieldOffset(Offset = "0x38")]
	public BloodTrail m_BloodTrail;

	[Token(Token = "0x40000F4")]
	[FieldOffset(Offset = "0x40")]
	protected vp_Timer m_ReenableWeaponStatesTimer;

	[Token(Token = "0x40000F5")]
	[FieldOffset(Offset = "0x48")]
	protected List<GameObject> m_AvailableWeapons;

	[HideInInspector]
	[Token(Token = "0x40000F6")]
	[FieldOffset(Offset = "0x50")]
	public bool m_CrouchToggleOn;

	[HideInInspector]
	[Token(Token = "0x40000F7")]
	[FieldOffset(Offset = "0x51")]
	public bool m_MovementInputLastFrame;

	[HideInInspector]
	[Token(Token = "0x40000F8")]
	[FieldOffset(Offset = "0x52")]
	public bool m_AltFireReleaseRequiredBeforeZoom;

	[HideInInspector]
	[Token(Token = "0x40000F9")]
	[FieldOffset(Offset = "0x53")]
	public bool m_InteractReleaseRequiredBeforeSpearZoom;

	[Token(Token = "0x40000FA")]
	[FieldOffset(Offset = "0x54")]
	private bool m_CancelSpearZoomRequested;

	[Token(Token = "0x40000FB")]
	[FieldOffset(Offset = "0x55")]
	private bool m_InZoom;

	[Token(Token = "0x40000FC")]
	[FieldOffset(Offset = "0x58")]
	private Vector3 m_StrafingRightDirection;

	[Token(Token = "0x40000FD")]
	[FieldOffset(Offset = "0x64")]
	private Vector3 m_StrafingCenter;

	[Token(Token = "0x40000FE")]
	[FieldOffset(Offset = "0x70")]
	private float m_StrafingDistanceLimit;

	[Token(Token = "0x40000FF")]
	[FieldOffset(Offset = "0x74")]
	private bool m_SpearZoomRequested;

	[Token(Token = "0x4000100")]
	[FieldOffset(Offset = "0x75")]
	private bool m_AutoWalking;

	[Token(Token = "0x60000ED")]
	[Address(RVA = "0x55CEB0", Offset = "0x55BCB0", Length = "0x189")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000EE")]
	[Address(RVA = "0x55D040", Offset = "0x55BE40", Length = "0x72")]
	private void Start()
	{
	}

	[Token(Token = "0x60000EF")]
	[Address(RVA = "0x55D0C0", Offset = "0x55BEC0", Length = "0x496")]
	private void Update()
	{
	}

	[Token(Token = "0x60000F0")]
	[Address(RVA = "0x55D560", Offset = "0x55C360", Length = "0x3DC")]
	protected void InputWalk()
	{
	}

	[Token(Token = "0x60000F1")]
	[Address(RVA = "0x55D940", Offset = "0x55C740", Length = "0xF1")]
	protected void InputStrafing()
	{
	}

	[Token(Token = "0x60000F2")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	protected void InputJump()
	{
	}

	[Token(Token = "0x60000F3")]
	[Address(RVA = "0x55DA40", Offset = "0x55C840", Length = "0x3D2")]
	public bool HasHeadRoom()
	{
		return false;
	}

	[Token(Token = "0x60000F4")]
	[Address(RVA = "0x55DE20", Offset = "0x55CC20", Length = "0x99")]
	public void SetAutoWalkingEnabled(bool enabled)
	{
	}

	[Token(Token = "0x60000F5")]
	[Address(RVA = "0x55DEC0", Offset = "0x55CCC0", Length = "0x8A")]
	public Vector2 GetMovementInput()
	{
		return default(Vector2);
	}

	[Token(Token = "0x60000F6")]
	[Address(RVA = "0x55DF50", Offset = "0x55CD50", Length = "0x215")]
	public bool EnableCrouch(bool enabled)
	{
		return false;
	}

	[Token(Token = "0x60000F7")]
	[Address(RVA = "0x55E170", Offset = "0x55CF70", Length = "0x2A7")]
	public bool EnableCrouchImmediate(bool enabled, UnCrouchOptions options)
	{
		return false;
	}

	[Token(Token = "0x60000F8")]
	[Address(RVA = "0x55E420", Offset = "0x55D220", Length = "0x4A")]
	public bool SnapToCrouch(bool enabled, UnCrouchOptions options)
	{
		return false;
	}

	[Token(Token = "0x60000F9")]
	[Address(RVA = "0x55E470", Offset = "0x55D270", Length = "0x6A")]
	protected void InputCrouch()
	{
	}

	[Token(Token = "0x60000FA")]
	[Address(RVA = "0x55E4E0", Offset = "0x55D2E0", Length = "0x49E")]
	public void PullTrigger()
	{
	}

	[Token(Token = "0x60000FB")]
	[Address(RVA = "0x55E980", Offset = "0x55D780", Length = "0x1A3")]
	protected void CheckForFireRelease()
	{
	}

	[Token(Token = "0x60000FC")]
	[Address(RVA = "0x55EB30", Offset = "0x55D930", Length = "0xA44")]
	protected void InputZoom()
	{
	}

	[Token(Token = "0x60000FD")]
	[Address(RVA = "0x55F580", Offset = "0x55E380", Length = "0x2EC")]
	public bool SetWeapon(GearItem gi)
	{
		return false;
	}

	[Token(Token = "0x60000FE")]
	[Address(RVA = "0x55F870", Offset = "0x55E670", Length = "0x39A")]
	public bool CanReload()
	{
		return false;
	}

	[Token(Token = "0x60000FF")]
	[Address(RVA = "0x55FC10", Offset = "0x55EA10", Length = "0x307")]
	public void Reload()
	{
	}

	[Token(Token = "0x6000100")]
	[Address(RVA = "0x55FF20", Offset = "0x55ED20", Length = "0x61")]
	public void CancelZoom()
	{
	}

	[Token(Token = "0x6000101")]
	[Address(RVA = "0x55FF90", Offset = "0x55ED90", Length = "0x4E4")]
	private void MaybeCancelZoomInternal()
	{
	}

	[Token(Token = "0x6000102")]
	[Address(RVA = "0x560480", Offset = "0x55F280", Length = "0x3D5")]
	public void CancelReload()
	{
	}

	[Token(Token = "0x6000103")]
	[Address(RVA = "0x560860", Offset = "0x55F660", Length = "0x579")]
	public void SetState(string state, bool isEnabled)
	{
	}

	[Token(Token = "0x6000104")]
	[Address(RVA = "0x560DE0", Offset = "0x55FBE0", Length = "0x10A")]
	public bool IsStateEnabled(string state)
	{
		return false;
	}

	[Token(Token = "0x6000105")]
	[Address(RVA = "0x560EF0", Offset = "0x55FCF0", Length = "0x1B0")]
	public void UpdateSprintState()
	{
	}

	[Token(Token = "0x6000106")]
	[Address(RVA = "0x5610B0", Offset = "0x55FEB0", Length = "0x1D8")]
	public void AllowState(string state, bool isAllowed)
	{
	}

	[Token(Token = "0x6000107")]
	[Address(RVA = "0x561290", Offset = "0x560090", Length = "0x1AD")]
	public void ReenableWeaponStatesIn(float seconds)
	{
	}

	[Token(Token = "0x6000108")]
	[Address(RVA = "0x561440", Offset = "0x560240", Length = "0x38E")]
	public void ResetState()
	{
	}

	[Token(Token = "0x6000109")]
	[Address(RVA = "0x5617D0", Offset = "0x5605D0", Length = "0x25A")]
	public void SetWeaponAvailable(FPSItem itemData, bool isAvailable)
	{
	}

	[Token(Token = "0x600010A")]
	[Address(RVA = "0x561A30", Offset = "0x560830", Length = "0x124")]
	public bool IsWeaponAvailable(FPSItem itemData)
	{
		return false;
	}

	[Token(Token = "0x600010B")]
	[Address(RVA = "0x561B60", Offset = "0x560960", Length = "0x26")]
	public void SetStrafingParameters(Vector3 strafingRightDirection, Vector3 strafingCenter, float strafingDistanceLimit)
	{
	}

	[Token(Token = "0x600010C")]
	[Address(RVA = "0x561B90", Offset = "0x560990", Length = "0x13")]
	public Vector3 GetStrafingRightDirection()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600010D")]
	[Address(RVA = "0x561BB0", Offset = "0x5609B0", Length = "0x13")]
	public Vector3 GetStrafingCenter()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600010E")]
	[Address(RVA = "0x561BD0", Offset = "0x5609D0", Length = "0x6")]
	public float GetStrafingDistanceLimit()
	{
		return 0f;
	}

	[Token(Token = "0x600010F")]
	[Address(RVA = "0x561BE0", Offset = "0x5609E0", Length = "0x4B4")]
	private void HandleBearSpearInput(PlayerManager pm)
	{
	}

	[Token(Token = "0x6000110")]
	[Address(RVA = "0x5620A0", Offset = "0x560EA0", Length = "0x3EC")]
	private bool ShouldTurnOffZoom()
	{
		return false;
	}

	[Token(Token = "0x6000111")]
	[Address(RVA = "0x562490", Offset = "0x561290", Length = "0xE3")]
	public vp_FPSPlayer()
	{
	}
}
