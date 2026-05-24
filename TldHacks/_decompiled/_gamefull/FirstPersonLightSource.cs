using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000892")]
public class FirstPersonLightSource : MonoBehaviour
{
	[Token(Token = "0x4005867")]
	[FieldOffset(Offset = "0x20")]
	public GameObject m_FXGameObject;

	[Token(Token = "0x4005868")]
	[FieldOffset(Offset = "0x28")]
	public GameObject m_TurningOnFX;

	[Token(Token = "0x4005869")]
	[FieldOffset(Offset = "0x30")]
	public Light m_LightIndoor;

	[Token(Token = "0x400586A")]
	[FieldOffset(Offset = "0x38")]
	public Light m_LightOutdoor;

	[Token(Token = "0x400586B")]
	[FieldOffset(Offset = "0x40")]
	public GameObject m_LightPosition;

	[Token(Token = "0x400586C")]
	[FieldOffset(Offset = "0x48")]
	public GameObject m_LightContainer;

	[Token(Token = "0x400586D")]
	[FieldOffset(Offset = "0x50")]
	public float m_LightCollisionRadius;

	[Token(Token = "0x400586E")]
	[FieldOffset(Offset = "0x58")]
	public GameObject[] m_MeshObjectsFresh;

	[Token(Token = "0x400586F")]
	[FieldOffset(Offset = "0x60")]
	public GameObject[] m_MeshObjectsUsed;

	[Token(Token = "0x6004E41")]
	[Address(RVA = "0xDA0F50", Offset = "0xD9FD50", Length = "0x7")]
	public void LateUpdate()
	{
	}

	[Token(Token = "0x6004E42")]
	[Address(RVA = "0xDA0F60", Offset = "0xD9FD60", Length = "0x980")]
	private void UpdateLightPosition()
	{
	}

	[Token(Token = "0x6004E43")]
	[Address(RVA = "0xDA18F0", Offset = "0xDA06F0", Length = "0x8B8")]
	public void TurnOnEffects()
	{
	}

	[Token(Token = "0x6004E44")]
	[Address(RVA = "0xDA21B0", Offset = "0xDA0FB0", Length = "0xE2")]
	public void DisableEffectsObject()
	{
	}

	[Token(Token = "0x6004E45")]
	[Address(RVA = "0xDA22A0", Offset = "0xDA10A0", Length = "0x364")]
	public void TurnOffEffects(bool hardStop)
	{
	}

	[Token(Token = "0x6004E46")]
	[Address(RVA = "0xDA2610", Offset = "0xDA1410", Length = "0x273")]
	public void Reset()
	{
	}

	[Token(Token = "0x6004E47")]
	[Address(RVA = "0xDA2890", Offset = "0xDA1690", Length = "0x231")]
	public void SetFresh(bool fresh)
	{
	}

	[Token(Token = "0x6004E48")]
	[Address(RVA = "0xDA2AD0", Offset = "0xDA18D0", Length = "0x389")]
	private void TurnOffParticleSystems(Transform parent, bool hardStop)
	{
	}

	[Token(Token = "0x6004E49")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public FirstPersonLightSource()
	{
	}
}
