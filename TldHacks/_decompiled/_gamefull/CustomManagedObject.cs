using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000812")]
public class CustomManagedObject : MonoBehaviour
{
	[AutoComponent(ComponentRequirement.Required)]
	[SerializeField]
	[Token(Token = "0x400554D")]
	[FieldOffset(Offset = "0x20")]
	private MissionObjectIdentifier m_MissionObjectIdentifier;

	[SerializeField]
	[Token(Token = "0x400554E")]
	[FieldOffset(Offset = "0x28")]
	private bool m_DefaultActiveState;

	[Token(Token = "0x400554F")]
	[FieldOffset(Offset = "0x29")]
	private bool m_IsRegistered;

	[Token(Token = "0x6004B49")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	private void OnValidate()
	{
	}

	[Token(Token = "0x6004B4A")]
	[Address(RVA = "0xD50ED0", Offset = "0xD4FCD0", Length = "0xB8")]
	public void PersistState()
	{
	}

	[Token(Token = "0x6004B4B")]
	[Address(RVA = "0xD50F90", Offset = "0xD4FD90", Length = "0x8")]
	public void PersistState(bool state)
	{
	}

	[Token(Token = "0x6004B4C")]
	[Address(RVA = "0xD50FA0", Offset = "0xD4FDA0", Length = "0x251")]
	private void Update()
	{
	}

	[Token(Token = "0x6004B4D")]
	[Address(RVA = "0xD51200", Offset = "0xD50000", Length = "0x12E")]
	private void UpdateManagedObject(bool managedState)
	{
	}

	[Token(Token = "0x6004B4E")]
	[Address(RVA = "0x80BB20", Offset = "0x80A920", Length = "0x47")]
	public CustomManagedObject()
	{
	}
}
