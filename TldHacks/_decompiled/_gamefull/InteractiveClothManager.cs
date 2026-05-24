using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200076D")]
public class InteractiveClothManager : MonoBehaviour
{
	[Token(Token = "0x4004F88")]
	[FieldOffset(Offset = "0x20")]
	public List<Cloth> m_Items;

	[Token(Token = "0x4004F89")]
	[FieldOffset(Offset = "0x28")]
	public List<float> m_SimulationDistance;

	[Token(Token = "0x4004F8A")]
	[FieldOffset(Offset = "0x30")]
	private Transform m_PlayerCameraTransform;

	[Token(Token = "0x4004F8B")]
	[FieldOffset(Offset = "0x38")]
	private bool m_Initialized;

	[Token(Token = "0x4004F8C")]
	[FieldOffset(Offset = "0x3C")]
	private Vector3 m_lastExternalAcceleration;

	[Token(Token = "0x4004F8D")]
	[FieldOffset(Offset = "0x48")]
	private Vector3 m_lastRandomAcceleration;

	[Token(Token = "0x6004572")]
	[Address(RVA = "0xC88120", Offset = "0xC86F20", Length = "0x767")]
	public void Initialize()
	{
	}

	[Token(Token = "0x6004573")]
	[Address(RVA = "0xC88890", Offset = "0xC87690", Length = "0x342")]
	private void Update()
	{
	}

	[Token(Token = "0x6004574")]
	[Address(RVA = "0xC88BE0", Offset = "0xC879E0", Length = "0x2C2")]
	public void SetAcceleration(Vector3 externalAcceleration, Vector3 randomAcceleration)
	{
	}

	[Token(Token = "0x6004575")]
	[Address(RVA = "0xC88EB0", Offset = "0xC87CB0", Length = "0x198")]
	public void EnableAll(bool enable)
	{
	}

	[Token(Token = "0x6004576")]
	[Address(RVA = "0xC89050", Offset = "0xC87E50", Length = "0x18F")]
	public InteractiveClothManager()
	{
	}
}
