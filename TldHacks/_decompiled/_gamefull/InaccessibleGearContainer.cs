using Cpp2ILInjected;
using UnityEngine;

[RequireComponent(typeof(Container))]
[Token(Token = "0x200058F")]
public class InaccessibleGearContainer : MonoBehaviour
{
	[Token(Token = "0x400334C")]
	private static InaccessibleGearContainer[] s_InaccessibleGearContainers;

	[Token(Token = "0x400334D")]
	[FieldOffset(Offset = "0x20")]
	private Container m_Container;

	[Token(Token = "0x400334E")]
	[FieldOffset(Offset = "0x28")]
	private Vector3 m_Position;

	[Token(Token = "0x6002AEB")]
	[Address(RVA = "0x90FBA0", Offset = "0x90E9A0", Length = "0x167")]
	private void Initialize()
	{
	}

	[Token(Token = "0x6002AEC")]
	[Address(RVA = "0x90FD10", Offset = "0x90EB10", Length = "0xF0")]
	private void AddGearToContainer(GearItem gi)
	{
	}

	[Token(Token = "0x6002AED")]
	[Address(RVA = "0x90FE10", Offset = "0x90EC10", Length = "0x5A")]
	private float SqrDistanceFrom(Vector3 pos)
	{
		return 0f;
	}

	[Token(Token = "0x6002AEE")]
	[Address(RVA = "0x90FE70", Offset = "0x90EC70", Length = "0x447")]
	public static void InitializeAllForCurrentScene()
	{
	}

	[Token(Token = "0x6002AEF")]
	[Address(RVA = "0x9102C0", Offset = "0x90F0C0", Length = "0x16E")]
	public static void UpdateVisibilityForAll()
	{
	}

	[Token(Token = "0x6002AF0")]
	[Address(RVA = "0x910430", Offset = "0x90F230", Length = "0x19D")]
	public static void AddGearToNearestContainer(GearItem gi)
	{
	}

	[Token(Token = "0x6002AF1")]
	[Address(RVA = "0x9105D0", Offset = "0x90F3D0", Length = "0x1AD")]
	public static void AddGearToNearestContainer(GearItem gi, Vector3 pos)
	{
	}

	[Token(Token = "0x6002AF2")]
	[Address(RVA = "0x910780", Offset = "0x90F580", Length = "0x393")]
	public static void LoadSceneIntoNearestContainer(string guid, Vector3 pos)
	{
	}

	[Token(Token = "0x6002AF3")]
	[Address(RVA = "0x910B20", Offset = "0x90F920", Length = "0x1DF")]
	private static InaccessibleGearContainer FindNearest(Vector3 pos)
	{
		return null;
	}

	[Token(Token = "0x6002AF4")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public InaccessibleGearContainer()
	{
	}
}
