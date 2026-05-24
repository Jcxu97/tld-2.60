using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200054E")]
public class BodyHarvestModel : MonoBehaviour
{
	[Header("Mesh Swapping")]
	[SerializeField]
	[Token(Token = "0x4003122")]
	[FieldOffset(Offset = "0x20")]
	private GameObject m_DefaultMeshRoot;

	[SerializeField]
	[Token(Token = "0x4003123")]
	[FieldOffset(Offset = "0x28")]
	private GameObject m_CarcassMeshRoot;

	[Header("Freezing")]
	[SerializeField]
	[Token(Token = "0x4003124")]
	[FieldOffset(Offset = "0x30")]
	private Renderer[] m_FreezingRenderers;

	[Token(Token = "0x4003125")]
	[FieldOffset(Offset = "0x38")]
	private MaterialPropertyBlock m_FreezingPropertyBlock;

	[Token(Token = "0x4003126")]
	private static readonly int s_FrozenAmountShaderID;

	[Token(Token = "0x4003128")]
	[FieldOffset(Offset = "0x41")]
	private bool m_CarcassMeshEnabled;

	[Token(Token = "0x1700029E")]
	[field: Token(Token = "0x4003127")]
	[field: FieldOffset(Offset = "0x40")]
	public bool IsEnabled
	{
		[Token(Token = "0x60028BA")]
		[Address(RVA = "0x667FB0", Offset = "0x666DB0", Length = "0x5")]
		get;
		[Token(Token = "0x60028BB")]
		[Address(RVA = "0x8D0360", Offset = "0x8CF160", Length = "0x4")]
		private set;
	}

	[Token(Token = "0x60028BC")]
	[Address(RVA = "0x8D0370", Offset = "0x8CF170", Length = "0xA")]
	public void SetModelEnabled(bool enabled)
	{
	}

	[Token(Token = "0x60028BD")]
	[Address(RVA = "0x8D0380", Offset = "0x8CF180", Length = "0xA")]
	public void SetCarcassMeshEnabled(bool carcassMeshEnabled)
	{
	}

	[Token(Token = "0x60028BE")]
	[Address(RVA = "0x8D0390", Offset = "0x8CF190", Length = "0x1AD")]
	private void UpdateMeshState()
	{
	}

	[Token(Token = "0x60028BF")]
	[Address(RVA = "0x8D0540", Offset = "0x8CF340", Length = "0x2E2")]
	public void UpdateFrozenShader(float percentFrozen)
	{
	}

	[Token(Token = "0x60028C0")]
	[Address(RVA = "0x8D0830", Offset = "0x8CF630", Length = "0x47")]
	public BodyHarvestModel()
	{
	}
}
