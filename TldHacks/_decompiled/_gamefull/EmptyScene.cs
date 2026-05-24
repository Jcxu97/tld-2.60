using Cpp2ILInjected;
using Interface.PanelRequest;
using TLD.OptionalContent;
using TLD.Platform;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceProviders;

[Token(Token = "0x20006F3")]
public class EmptyScene : MonoBehaviour
{
	[Token(Token = "0x20006F4")]
	private enum State
	{
		[Token(Token = "0x40049ED")]
		Error = -1,
		[Token(Token = "0x40049EE")]
		Transitioning,
		[Token(Token = "0x40049EF")]
		WaitingForUserSignIn,
		[Token(Token = "0x40049F0")]
		WaitingForOptionalContent,
		[Token(Token = "0x40049F1")]
		WaitingForAddressables,
		[Token(Token = "0x40049F2")]
		WaitingForSaves,
		[Token(Token = "0x40049F3")]
		WaitingForMainMenu,
		[Token(Token = "0x40049F4")]
		WaitingForBootPanel
	}

	[Token(Token = "0x40049E0")]
	public const string SAVE_FILE_FLAG = "-savefile";

	[Token(Token = "0x40049E1")]
	public const string SKIP_INTRO_FLAG = "-skipintro";

	[SerializeField]
	[Token(Token = "0x40049E2")]
	[FieldOffset(Offset = "0x20")]
	private AssetReferenceGameObject m_WiseAudioPrefab;

	[SerializeField]
	[Token(Token = "0x40049E3")]
	[FieldOffset(Offset = "0x28")]
	private AssetReferenceGameObject m_GameManagerPrefab;

	[Token(Token = "0x40049E4")]
	public static string s_SceneLoadFromEmpty;

	[Token(Token = "0x40049E5")]
	[FieldOffset(Offset = "0x30")]
	private State m_State;

	[Token(Token = "0x40049E6")]
	[FieldOffset(Offset = "0x38")]
	private ILoadPanelRequest m_LoadAllPanelsRequest;

	[Token(Token = "0x40049E7")]
	[FieldOffset(Offset = "0x40")]
	private AsyncOperationHandle<SceneInstance> m_MainMenuAsyncOp;

	[Token(Token = "0x40049E8")]
	[FieldOffset(Offset = "0x58")]
	private Panel_Boot m_BootPanel;

	[Token(Token = "0x40049E9")]
	[FieldOffset(Offset = "0x60")]
	private OptionalContentProviderResult m_ErrorResult;

	[Token(Token = "0x40049EA")]
	[FieldOffset(Offset = "0x68")]
	private string m_PendingSaveName;

	[Token(Token = "0x40049EB")]
	[FieldOffset(Offset = "0x70")]
	private SaveSlotInfo m_PendingSave;

	[Token(Token = "0x6003CF8")]
	[Address(RVA = "0xB88850", Offset = "0xB87650", Length = "0x21F")]
	private void Start()
	{
	}

	[Token(Token = "0x6003CF9")]
	[Address(RVA = "0xB88A70", Offset = "0xB87870", Length = "0x67C")]
	private void Update()
	{
	}

	[Token(Token = "0x6003CFA")]
	[Address(RVA = "0xB89110", Offset = "0xB87F10", Length = "0x325")]
	private void InitializeSystems()
	{
	}

	[Token(Token = "0x6003CFB")]
	[Address(RVA = "0xB89440", Offset = "0xB88240", Length = "0x2B0")]
	private void ForceSystemLanguage()
	{
	}

	[Token(Token = "0x6003CFC")]
	[Address(RVA = "0xB89700", Offset = "0xB88500", Length = "0x1C0")]
	private void SignInUser()
	{
	}

	[Token(Token = "0x6003CFD")]
	[Address(RVA = "0xB898D0", Offset = "0xB886D0", Length = "0x1C")]
	private void OnUserLoggedIn(IPlatformProvider provider, bool succeeded)
	{
	}

	[Token(Token = "0x6003CFE")]
	[Address(RVA = "0xB898F0", Offset = "0xB886F0", Length = "0x41A")]
	private void PreloadAddressables()
	{
	}

	[Token(Token = "0x6003CFF")]
	[Address(RVA = "0xB89D10", Offset = "0xB88B10", Length = "0x1C2")]
	private void LoadScene(string scene)
	{
	}

	[Token(Token = "0x6003D00")]
	[Address(RVA = "0xB89EE0", Offset = "0xB88CE0", Length = "0x1AA")]
	private bool IsSaveSystemInitialized()
	{
		return false;
	}

	[Token(Token = "0x6003D01")]
	[Address(RVA = "0xB8A090", Offset = "0xB88E90", Length = "0xD3")]
	private SaveSlotInfo PreparePendingSave()
	{
		return null;
	}

	[Token(Token = "0x6003D02")]
	[Address(RVA = "0xB8A170", Offset = "0xB88F70", Length = "0x30D")]
	private bool LoadPendingSave()
	{
		return false;
	}

	[Token(Token = "0x6003D03")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public EmptyScene()
	{
	}
}
