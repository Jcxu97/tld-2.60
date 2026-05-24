using Cpp2ILInjected;
using TLD.UI.Generics;
using UnityEngine;

[Token(Token = "0x20008BB")]
public class PlayerInVehicle : MonoBehaviour
{
	[SerializeField]
	[Token(Token = "0x4005B16")]
	[FieldOffset(Offset = "0x20")]
	private PanelReference<Panel_Rest> m_Rest;

	[Token(Token = "0x4005B17")]
	[FieldOffset(Offset = "0x28")]
	public float m_TempIncrease;

	[Token(Token = "0x4005B18")]
	[FieldOffset(Offset = "0x2C")]
	public float m_FOV;

	[Token(Token = "0x4005B19")]
	[FieldOffset(Offset = "0x30")]
	public Vector2 m_PitchLimitDegrees;

	[Token(Token = "0x4005B1A")]
	[FieldOffset(Offset = "0x38")]
	public Vector2 m_YawLimitDegrees;

	[Token(Token = "0x4005B1B")]
	[FieldOffset(Offset = "0x40")]
	public float m_FadeOutSeconds;

	[Token(Token = "0x4005B1C")]
	[FieldOffset(Offset = "0x44")]
	public float m_FadeInSeconds;

	[Token(Token = "0x4005B1D")]
	[FieldOffset(Offset = "0x48")]
	private float m_StartCameraFOV;

	[Token(Token = "0x4005B1E")]
	[FieldOffset(Offset = "0x4C")]
	private Quaternion m_StartCameraRotation;

	[Token(Token = "0x4005B1F")]
	[FieldOffset(Offset = "0x5C")]
	private bool m_InVehicle;

	[Token(Token = "0x4005B20")]
	[FieldOffset(Offset = "0x5D")]
	private bool m_EnteringVehicle;

	[Token(Token = "0x4005B21")]
	[FieldOffset(Offset = "0x60")]
	private Vector2 m_StartPitchLimit;

	[Token(Token = "0x4005B22")]
	[FieldOffset(Offset = "0x68")]
	private Vector2 m_StartYawLimit;

	[Token(Token = "0x4005B23")]
	[FieldOffset(Offset = "0x70")]
	private VehicleDoor m_VehicleDoorUsed;

	[Token(Token = "0x17000367")]
	[field: Token(Token = "0x4005B24")]
	[field: FieldOffset(Offset = "0x78")]
	public bool IsTransitioning
	{
		[Token(Token = "0x600502C")]
		[Address(RVA = "0x502700", Offset = "0x501500", Length = "0x5")]
		get;
		[Token(Token = "0x600502D")]
		[Address(RVA = "0x502710", Offset = "0x501510", Length = "0x4")]
		private set;
	}

	[Token(Token = "0x600502E")]
	[Address(RVA = "0xE00820", Offset = "0xDFF620", Length = "0xFF")]
	public bool BlockSavingWhileInside()
	{
		return false;
	}

	[Token(Token = "0x600502F")]
	[Address(RVA = "0xE00920", Offset = "0xDFF720", Length = "0x1E2")]
	public void EnterVehicle(VehicleDoor vd)
	{
	}

	[Token(Token = "0x6005030")]
	[Address(RVA = "0xE00B10", Offset = "0xDFF910", Length = "0x1D7")]
	public void ExitVehicle(VehicleDoor vd)
	{
	}

	[Token(Token = "0x6005031")]
	[Address(RVA = "0xE00CF0", Offset = "0xDFFAF0", Length = "0x5")]
	public bool IsInside()
	{
		return false;
	}

	[Token(Token = "0x6005032")]
	[Address(RVA = "0xE00D00", Offset = "0xDFFB00", Length = "0x5")]
	public bool IsEntering()
	{
		return false;
	}

	[Token(Token = "0x6005033")]
	[Address(RVA = "0xE00D10", Offset = "0xDFFB10", Length = "0x186")]
	public bool HasBuiltInBed()
	{
		return false;
	}

	[Token(Token = "0x6005034")]
	[Address(RVA = "0xE00EA0", Offset = "0xDFFCA0", Length = "0x10")]
	public float GetTempIncrease()
	{
		return 0f;
	}

	[Token(Token = "0x6005035")]
	[Address(RVA = "0xE00EB0", Offset = "0xDFFCB0", Length = "0x148")]
	public void OnBedroll(GearItem gi = null)
	{
	}

	[Token(Token = "0x6005036")]
	[Address(RVA = "0xE01000", Offset = "0xDFFE00", Length = "0x515")]
	public void ForceIntoVehicleSilent(Vector3 cameraPos)
	{
	}

	[Token(Token = "0x6005037")]
	[Address(RVA = "0xE01520", Offset = "0xE00320", Length = "0x313")]
	public Vector3 GetDropItemLocationForLastDoor()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6005038")]
	[Address(RVA = "0xE01840", Offset = "0xE00640", Length = "0x186")]
	public bool HasDropLocationForLastDoor()
	{
		return false;
	}

	[Token(Token = "0x6005039")]
	[Address(RVA = "0xE019D0", Offset = "0xE007D0", Length = "0x20C")]
	private void EnterVehicleAfterFadeOut()
	{
	}

	[Token(Token = "0x600503A")]
	[Address(RVA = "0xE01BE0", Offset = "0xE009E0", Length = "0xAF2")]
	private void EnterVehicleCommon()
	{
	}

	[Token(Token = "0x600503B")]
	[Address(RVA = "0xE026E0", Offset = "0xE014E0", Length = "0xABC")]
	private void ExitVehicleAfterFadeOut()
	{
	}

	[Token(Token = "0x600503C")]
	[Address(RVA = "0xE031A0", Offset = "0xE01FA0", Length = "0x3C6")]
	private VehicleDoor GetVehicleDoorFromCollider(Collider c)
	{
		return null;
	}

	[Token(Token = "0x600503D")]
	[Address(RVA = "0xE03570", Offset = "0xE02370", Length = "0x5")]
	private void OnDoneTransitioning()
	{
	}

	[Token(Token = "0x600503E")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public PlayerInVehicle()
	{
	}
}
