using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000385")]
public class ElectrifiedWater : MonoBehaviour
{
	[SerializeField]
	[Token(Token = "0x4001F7B")]
	[FieldOffset(Offset = "0x20")]
	private bool m_ElectrifiedOnAwake;

	[SerializeField]
	[Token(Token = "0x4001F7C")]
	[FieldOffset(Offset = "0x28")]
	private Renderer m_Renderer;

	[Token(Token = "0x4001F7D")]
	[FieldOffset(Offset = "0x30")]
	private int m_ElectrictyAmountShaderID;

	[Token(Token = "0x4001F7E")]
	[FieldOffset(Offset = "0x34")]
	private bool m_HasInitialized;

	[Token(Token = "0x6001C43")]
	[Address(RVA = "0x77C5B0", Offset = "0x77B3B0", Length = "0x8")]
	public void SetExternalPowerState(bool isActive)
	{
	}

	[Token(Token = "0x6001C44")]
	[Address(RVA = "0x77C5C0", Offset = "0x77B3C0", Length = "0x25")]
	public void Initialize()
	{
	}

	[Token(Token = "0x6001C45")]
	[Address(RVA = "0x77C5C0", Offset = "0x77B3C0", Length = "0x25")]
	private void Awake()
	{
	}

	[Token(Token = "0x6001C46")]
	[Address(RVA = "0x77C5F0", Offset = "0x77B3F0", Length = "0x262")]
	private void SetElectrified(bool isElectrified)
	{
	}

	[Token(Token = "0x6001C47")]
	[Address(RVA = "0x77C860", Offset = "0x77B660", Length = "0x7C")]
	public ElectrifiedWater()
	{
	}
}
