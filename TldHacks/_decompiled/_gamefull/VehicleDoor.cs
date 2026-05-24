using Cpp2ILInjected;
using TLD.Interactions;
using UnityEngine;

[Token(Token = "0x20005BF")]
public class VehicleDoor : TimedHoldInteraction
{
	[Token(Token = "0x4003512")]
	[FieldOffset(Offset = "0x68")]
	public string m_OpenAudio;

	[Token(Token = "0x4003513")]
	[FieldOffset(Offset = "0x70")]
	public string m_CloseAudio;

	[Token(Token = "0x4003514")]
	[FieldOffset(Offset = "0x78")]
	public GameObject m_CameraDummy;

	[Token(Token = "0x4003515")]
	[FieldOffset(Offset = "0x80")]
	public GameObject m_ExitPoint;

	[Token(Token = "0x4003516")]
	[FieldOffset(Offset = "0x88")]
	public BoxCollider m_ItemDropBox;

	[Token(Token = "0x4003517")]
	[FieldOffset(Offset = "0x90")]
	public Bed m_Bed;

	[Token(Token = "0x4003518")]
	[FieldOffset(Offset = "0x98")]
	public bool m_BlockSavingWhileInside;

	[Token(Token = "0x170002D0")]
	public override bool CanInteract
	{
		[Token(Token = "0x6002C76")]
		[Address(RVA = "0x9368B0", Offset = "0x9356B0", Length = "0x9D")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x6002C77")]
	[Address(RVA = "0x936950", Offset = "0x935750", Length = "0x166")]
	private void Awake()
	{
	}

	[Token(Token = "0x6002C78")]
	[Address(RVA = "0x936AC0", Offset = "0x9358C0", Length = "0x2D0")]
	public override void InitializeInteraction()
	{
	}

	[Token(Token = "0x6002C79")]
	[Address(RVA = "0x936DA0", Offset = "0x935BA0", Length = "0xED")]
	public override bool PerformInteraction()
	{
		return false;
	}

	[Token(Token = "0x6002C7A")]
	[Address(RVA = "0x8F4D40", Offset = "0x8F3B40", Length = "0x7")]
	public VehicleDoor()
	{
	}
}
