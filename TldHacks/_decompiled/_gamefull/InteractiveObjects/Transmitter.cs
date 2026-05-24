using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.Scenes.ObjectReferences;
using UnityEngine;

namespace InteractiveObjects;

[Token(Token = "0x2001328")]
public class Transmitter : MonoBehaviour
{
	[SceneObjectReferenceOwner("Assets/ScriptableObjects/Transmitters")]
	[SerializeField]
	[Token(Token = "0x4008D80")]
	[FieldOffset(Offset = "0x20")]
	private TransmitterData m_TransmitterData;

	[SerializeField]
	[Token(Token = "0x4008D81")]
	[FieldOffset(Offset = "0x28")]
	private OpenClose m_SwitchHandle;

	[Header("Force Aurora Setting")]
	[Tooltip("Forces Aurora to occur at the next opportunity. Leave duration override values at zero to use the existing min/max values for aurora duration. Early window is late afternoon to midnight, late window is midnight to ~4 AM.")]
	[SerializeField]
	[Token(Token = "0x4008D82")]
	[FieldOffset(Offset = "0x30")]
	private bool m_EarlyWindowStartAllowed;

	[SerializeField]
	[Token(Token = "0x4008D83")]
	[FieldOffset(Offset = "0x31")]
	private bool m_LateWindowStartAllowed;

	[SerializeField]
	[Token(Token = "0x4008D84")]
	[FieldOffset(Offset = "0x34")]
	private float m_DurationOverrideHoursMin;

	[SerializeField]
	[Token(Token = "0x4008D85")]
	[FieldOffset(Offset = "0x38")]
	private float m_DurationOverrideHoursMax;

	[Token(Token = "0x4008D86")]
	[FieldOffset(Offset = "0x40")]
	private readonly List<RepairableInteractiveItem> m_ChildrenRepairables;

	[Token(Token = "0x4008D87")]
	[FieldOffset(Offset = "0x48")]
	private TransmitterRuntimeState m_RuntimeState;

	[Token(Token = "0x17000A39")]
	public TransmitterData TransmitterData
	{
		[Token(Token = "0x6007AC8")]
		[Address(RVA = "0x40E110", Offset = "0x40CF10", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A3A")]
	public bool IsFixed
	{
		[Token(Token = "0x6007AC9")]
		[Address(RVA = "0x11982A0", Offset = "0x11970A0", Length = "0xF")]
		get
		{
			return false;
		}
		[Token(Token = "0x6007ACA")]
		[Address(RVA = "0x11982B0", Offset = "0x11970B0", Length = "0x122")]
		private set
		{
		}
	}

	[Token(Token = "0x17000A3B")]
	public bool IsOpen
	{
		[Token(Token = "0x6007ACB")]
		[Address(RVA = "0x11983E0", Offset = "0x11971E0", Length = "0xF")]
		get
		{
			return false;
		}
		[Token(Token = "0x6007ACC")]
		[Address(RVA = "0x11983F0", Offset = "0x11971F0", Length = "0x12")]
		private set
		{
		}
	}

	[Token(Token = "0x17000A3C")]
	public bool IsDiscovered
	{
		[Token(Token = "0x6007ACD")]
		[Address(RVA = "0x1198410", Offset = "0x1197210", Length = "0xF")]
		get
		{
			return false;
		}
		[Token(Token = "0x6007ACE")]
		[Address(RVA = "0x1198420", Offset = "0x1197220", Length = "0x12")]
		private set
		{
		}
	}

	[Token(Token = "0x17000A3D")]
	public bool IsActive
	{
		[Token(Token = "0x6007ACF")]
		[Address(RVA = "0x1198440", Offset = "0x1197240", Length = "0x63")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x6007AD0")]
	[Address(RVA = "0x11984B0", Offset = "0x11972B0", Length = "0x42B")]
	private void Awake()
	{
	}

	[Token(Token = "0x6007AD1")]
	[Address(RVA = "0x11988E0", Offset = "0x11976E0", Length = "0xF9")]
	private void Start()
	{
	}

	[Token(Token = "0x6007AD2")]
	[Address(RVA = "0x11989E0", Offset = "0x11977E0", Length = "0x418")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6007AD3")]
	[Address(RVA = "0x1198E00", Offset = "0x1197C00", Length = "0x1A")]
	public void OnOpenSwitch()
	{
	}

	[Token(Token = "0x6007AD4")]
	[Address(RVA = "0x1198E20", Offset = "0x1197C20", Length = "0x14")]
	public void OnCloseSwitch()
	{
	}

	[Token(Token = "0x6007AD5")]
	[Address(RVA = "0x1198E40", Offset = "0x1197C40", Length = "0x14")]
	public void OnOpenTransmitterDoor()
	{
	}

	[Token(Token = "0x6007AD6")]
	[Address(RVA = "0x1198E60", Offset = "0x1197C60", Length = "0x438")]
	public void UpdateRuntimeState()
	{
	}

	[Token(Token = "0x6007AD7")]
	[Address(RVA = "0x11992A0", Offset = "0x11980A0", Length = "0x3FD")]
	private void OnItemRepaired(RepairableInteractiveItem item)
	{
	}

	[Token(Token = "0x6007AD8")]
	[Address(RVA = "0x11996A0", Offset = "0x11984A0", Length = "0x101")]
	private void ForceAurora()
	{
	}

	[Token(Token = "0x6007AD9")]
	[Address(RVA = "0x11997B0", Offset = "0x11985B0", Length = "0xE3")]
	public Transmitter()
	{
	}
}
