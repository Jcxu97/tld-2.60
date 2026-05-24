using Cpp2ILInjected;
using TLD.UI;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

[Token(Token = "0x2000450")]
public class AmmoItem : MonoBehaviour
{
	[Token(Token = "0x4002706")]
	[FieldOffset(Offset = "0x20")]
	public GunType m_AmmoForGunType;

	[SerializeField]
	[Token(Token = "0x4002707")]
	[FieldOffset(Offset = "0x28")]
	private PanelReference m_AimingOverlayPanel;

	[SerializeField]
	[Token(Token = "0x4002708")]
	[FieldOffset(Offset = "0x30")]
	private PostProcessProfile m_AimingPostProcessProfile;

	[SerializeField]
	[Token(Token = "0x4002709")]
	[FieldOffset(Offset = "0x38")]
	private PostProcessProfile m_FiredPostProcessProfile;

	[SerializeField]
	[Token(Token = "0x400270A")]
	[FieldOffset(Offset = "0x40")]
	private string m_TypeHudIconSpriteName;

	[SerializeField]
	[Token(Token = "0x400270B")]
	[FieldOffset(Offset = "0x48")]
	private string m_LoadedHudIconSpriteName;

	[SerializeField]
	[Token(Token = "0x400270C")]
	[FieldOffset(Offset = "0x50")]
	private string m_EmptyHudIconSpriteName;

	[SerializeField]
	[Token(Token = "0x400270D")]
	[FieldOffset(Offset = "0x58")]
	private string m_FirstPersonFXName;

	[Token(Token = "0x17000216")]
	public string TypeHudIconSpriteName
	{
		[Token(Token = "0x600207A")]
		[Address(RVA = "0x4A7D60", Offset = "0x4A6B60", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000217")]
	public string LoadedHudIconSpriteName
	{
		[Token(Token = "0x600207B")]
		[Address(RVA = "0x4B2FE0", Offset = "0x4B1DE0", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000218")]
	public string EmptyHudIconSpriteName
	{
		[Token(Token = "0x600207C")]
		[Address(RVA = "0x669640", Offset = "0x668440", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000219")]
	public string FirstPersonFXName
	{
		[Token(Token = "0x600207D")]
		[Address(RVA = "0x6BCD40", Offset = "0x6BBB40", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600207E")]
	[Address(RVA = "0x7F8A80", Offset = "0x7F7880", Length = "0x162")]
	public void OnStartAiming()
	{
	}

	[Token(Token = "0x600207F")]
	[Address(RVA = "0x7F8BF0", Offset = "0x7F79F0", Length = "0x515")]
	public void OnUpdateAiming()
	{
	}

	[Token(Token = "0x6002080")]
	[Address(RVA = "0x7F9110", Offset = "0x7F7F10", Length = "0x160")]
	public void OnStopAiming()
	{
	}

	[Token(Token = "0x6002081")]
	[Address(RVA = "0x7F9280", Offset = "0x7F8080", Length = "0x62")]
	public void OnFired()
	{
	}

	[Token(Token = "0x6002082")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public AmmoItem()
	{
	}
}
