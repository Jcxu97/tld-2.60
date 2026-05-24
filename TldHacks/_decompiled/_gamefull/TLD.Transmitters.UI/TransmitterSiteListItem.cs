using Cpp2ILInjected;
using InteractiveObjects;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace TLD.Transmitters.UI;

[Token(Token = "0x20013E9")]
public class TransmitterSiteListItem : MonoBehaviour
{
	[SerializeField]
	[Token(Token = "0x40091BD")]
	[FieldOffset(Offset = "0x20")]
	private UITexture m_RegionTexture;

	[SerializeField]
	[Token(Token = "0x40091BE")]
	[FieldOffset(Offset = "0x28")]
	private UILabel m_TransmitterName;

	[SerializeField]
	[Token(Token = "0x40091BF")]
	[FieldOffset(Offset = "0x30")]
	private UILabel m_TransmitterDescription;

	[SerializeField]
	[Token(Token = "0x40091C0")]
	[FieldOffset(Offset = "0x38")]
	private UILabel m_UndiscoveredLabel;

	[SerializeField]
	[Token(Token = "0x40091C1")]
	[FieldOffset(Offset = "0x40")]
	private UILabel m_NeedsRepairLabel;

	[Token(Token = "0x40091C3")]
	[FieldOffset(Offset = "0x50")]
	private AsyncOperationHandle<Texture2D> m_textureLoadOperation;

	[Token(Token = "0x17000AD5")]
	[field: Token(Token = "0x40091C2")]
	[field: FieldOffset(Offset = "0x48")]
	public TransmitterData Data
	{
		[Token(Token = "0x6007EEB")]
		[Address(RVA = "0x4B2FE0", Offset = "0x4B1DE0", Length = "0x5")]
		get;
		[Token(Token = "0x6007EEC")]
		[Address(RVA = "0x4D0B60", Offset = "0x4CF960", Length = "0x52")]
		private set;
	}

	[Token(Token = "0x6007EED")]
	[Address(RVA = "0x11E9860", Offset = "0x11E8660", Length = "0x429")]
	public void SetTransmitter(TransmitterData transmitter)
	{
	}

	[Token(Token = "0x6007EEE")]
	[Address(RVA = "0x11E9C90", Offset = "0x11E8A90", Length = "0x223")]
	public static int Compare(TransmitterSiteListItem xItem, TransmitterSiteListItem yItem)
	{
		return 0;
	}

	[Token(Token = "0x6007EEF")]
	[Address(RVA = "0x11E9EC0", Offset = "0x11E8CC0", Length = "0x95")]
	private void OnRegionTextureLoaded(AsyncOperationHandle<Texture2D> op)
	{
	}

	[Token(Token = "0x6007EF0")]
	[Address(RVA = "0x11E9F60", Offset = "0x11E8D60", Length = "0xF0")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6007EF1")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public TransmitterSiteListItem()
	{
	}
}
