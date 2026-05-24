using Cpp2ILInjected;
using UnityEngine;

[RequireComponent(typeof(FirstPersonLightSource))]
[Token(Token = "0x200038F")]
public class FirstPersonFlashlight : MonoBehaviour
{
	[SerializeField]
	[Token(Token = "0x4001FD0")]
	[FieldOffset(Offset = "0x20")]
	private GameObject m_LowFxGameObject;

	[SerializeField]
	[Token(Token = "0x4001FD1")]
	[FieldOffset(Offset = "0x28")]
	private GameObject m_HighFxGameObject;

	[SerializeField]
	[Token(Token = "0x4001FD2")]
	[FieldOffset(Offset = "0x30")]
	private Light m_LightIndoorsLow;

	[SerializeField]
	[Token(Token = "0x4001FD3")]
	[FieldOffset(Offset = "0x38")]
	private Light m_LightIndoorsHigh;

	[SerializeField]
	[Token(Token = "0x4001FD4")]
	[FieldOffset(Offset = "0x40")]
	private Light m_LightOutdoorsLow;

	[SerializeField]
	[Token(Token = "0x4001FD5")]
	[FieldOffset(Offset = "0x48")]
	private Light m_LightOutdoorsHigh;

	[Token(Token = "0x6001C73")]
	[Address(RVA = "0x7818A0", Offset = "0x7806A0", Length = "0x725")]
	private void Update()
	{
	}

	[Token(Token = "0x6001C74")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public FirstPersonFlashlight()
	{
	}
}
