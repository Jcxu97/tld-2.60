using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000359")]
public class AuroraElectrolizerController : MonoBehaviour
{
	[Token(Token = "0x200035A")]
	public class AuroraElectrolizerControllerSaveData
	{
		[Token(Token = "0x200035B")]
		public struct VolumeSaveData
		{
			[Token(Token = "0x4001D9B")]
			[FieldOffset(Offset = "0x0")]
			public string m_VolumeName;

			[Token(Token = "0x4001D9C")]
			[FieldOffset(Offset = "0x8")]
			public bool m_IsActive;
		}

		[Token(Token = "0x4001D99")]
		[FieldOffset(Offset = "0x10")]
		public List<VolumeSaveData> m_VolumeSaveDataList;

		[Token(Token = "0x4001D9A")]
		[FieldOffset(Offset = "0x18")]
		public string m_Id;

		[Token(Token = "0x6001B61")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public AuroraElectrolizerControllerSaveData()
		{
		}
	}

	[Token(Token = "0x4001D95")]
	[FieldOffset(Offset = "0x20")]
	public List<AuroraElectrolizerControlVolume> m_ControlVolumeList;

	[Token(Token = "0x4001D96")]
	[FieldOffset(Offset = "0x28")]
	public GameObject m_ArtParent;

	[Token(Token = "0x4001D97")]
	[FieldOffset(Offset = "0x30")]
	private string m_Id;

	[Token(Token = "0x4001D98")]
	public static List<AuroraElectrolizerController> s_AuroraElectrolizerControllerList;

	[Token(Token = "0x6001B52")]
	[Address(RVA = "0x75CFF0", Offset = "0x75BDF0", Length = "0x28C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6001B53")]
	[Address(RVA = "0x75D280", Offset = "0x75C080", Length = "0x82")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6001B54")]
	[Address(RVA = "0x75D310", Offset = "0x75C110", Length = "0x2C8")]
	private void Start()
	{
	}

	[Token(Token = "0x6001B55")]
	[Address(RVA = "0x75D5E0", Offset = "0x75C3E0", Length = "0x5E6")]
	private void PopulateVolumes()
	{
	}

	[Token(Token = "0x6001B56")]
	[Address(RVA = "0x75DBD0", Offset = "0x75C9D0", Length = "0x1EA")]
	private Renderer FindRenderer(GameObject obj)
	{
		return null;
	}

	[Token(Token = "0x6001B57")]
	[Address(RVA = "0x75DDC0", Offset = "0x75CBC0", Length = "0x1A5")]
	public void SetPowerState(string volumeName, bool isActive)
	{
	}

	[Token(Token = "0x6001B58")]
	[Address(RVA = "0x75DF70", Offset = "0x75CD70", Length = "0x171")]
	public void SetPowerState(int volumeID, bool isActive)
	{
	}

	[Token(Token = "0x6001B59")]
	[Address(RVA = "0x75E0F0", Offset = "0x75CEF0", Length = "0x157")]
	public void SetPowerStateAll(bool isActive)
	{
	}

	[Token(Token = "0x6001B5A")]
	[Address(RVA = "0x75E250", Offset = "0x75D050", Length = "0x668")]
	public static string SerializeAll()
	{
		return null;
	}

	[Token(Token = "0x6001B5B")]
	[Address(RVA = "0x75E8C0", Offset = "0x75D6C0", Length = "0x442")]
	public static void DeserializeAll(string text)
	{
	}

	[Token(Token = "0x6001B5C")]
	[Address(RVA = "0x75ED10", Offset = "0x75DB10", Length = "0x258")]
	private void Initialize()
	{
	}

	[Token(Token = "0x6001B5D")]
	[Address(RVA = "0x75EF70", Offset = "0x75DD70", Length = "0x93")]
	public static void Reset()
	{
	}

	[Token(Token = "0x6001B5E")]
	[Address(RVA = "0x75F010", Offset = "0x75DE10", Length = "0x1DB")]
	private void Update()
	{
	}

	[Token(Token = "0x6001B5F")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public AuroraElectrolizerController()
	{
	}
}
