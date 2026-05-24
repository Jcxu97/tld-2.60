using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace InteractiveObjects;

[Token(Token = "0x200132B")]
public class TransmitterManager : MonoBehaviour
{
	[SerializeField]
	[Token(Token = "0x4008D93")]
	[FieldOffset(Offset = "0x20")]
	private AssetLabelReference m_TransmitterAssetLabel;

	[Token(Token = "0x4008D95")]
	[FieldOffset(Offset = "0x28")]
	private AsyncOperationHandle<IList<TransmitterData>> m_TransmitterDataHandle;

	[Token(Token = "0x4008D96")]
	[FieldOffset(Offset = "0x40")]
	private readonly Dictionary<string, TransmitterRuntimeState> m_TransmitterSaveData;

	[Token(Token = "0x4008D97")]
	public static bool s_ShowDebug;

	[Token(Token = "0x17000A45")]
	[field: Token(Token = "0x4008D94")]
	public static TransmitterManager Instance
	{
		[Token(Token = "0x6007AE6")]
		[Address(RVA = "0x1199D80", Offset = "0x1198B80", Length = "0x3B")]
		get;
		[Token(Token = "0x6007AE7")]
		[Address(RVA = "0x1199DC0", Offset = "0x1198BC0", Length = "0x97")]
		private set;
	}

	[Token(Token = "0x6007AE8")]
	[Address(RVA = "0x1199E60", Offset = "0x1198C60", Length = "0xDC")]
	private void Awake()
	{
	}

	[Token(Token = "0x6007AE9")]
	[Address(RVA = "0x1199F40", Offset = "0x1198D40", Length = "0x121")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6007AEA")]
	[Address(RVA = "0x119A070", Offset = "0x1198E70", Length = "0x1B0")]
	public static string SerializeAll()
	{
		return null;
	}

	[Token(Token = "0x6007AEB")]
	[Address(RVA = "0x119A230", Offset = "0x1199030", Length = "0x4A4")]
	public static void DeserializeAll(string text)
	{
	}

	[Token(Token = "0x6007AEC")]
	[Address(RVA = "0x119A6E0", Offset = "0x11994E0", Length = "0x81")]
	public bool HasAnyTransmitters()
	{
		return false;
	}

	[Token(Token = "0x6007AED")]
	[Address(RVA = "0x119A770", Offset = "0x1199570", Length = "0x3F")]
	public IList<TransmitterData> GetAllTransmitters()
	{
		return null;
	}

	[Token(Token = "0x6007AEE")]
	[Address(RVA = "0x60B830", Offset = "0x60A630", Length = "0x12")]
	public static string GetDebugText()
	{
		return null;
	}

	[Token(Token = "0x6007AEF")]
	[Address(RVA = "0x119A7B0", Offset = "0x11995B0", Length = "0x197")]
	public TransmitterRuntimeState GetTransmitterState(TransmitterData transmitterData)
	{
		return null;
	}

	[Token(Token = "0x6007AF0")]
	[Address(RVA = "0x119A950", Offset = "0x1199750", Length = "0x1F3")]
	private TransmitterData GetTransmitterDataByGuid(string transmitterId)
	{
		return null;
	}

	[Token(Token = "0x6007AF1")]
	[Address(RVA = "0x119AB50", Offset = "0x1199950", Length = "0xE3")]
	public TransmitterManager()
	{
	}
}
