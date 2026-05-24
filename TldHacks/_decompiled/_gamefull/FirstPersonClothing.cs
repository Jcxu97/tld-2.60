using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200019E")]
public class FirstPersonClothing : MonoBehaviour
{
	[SerializeField]
	[Token(Token = "0x4000EC9")]
	[FieldOffset(Offset = "0x20")]
	private int m_LayerPriority;

	[Token(Token = "0x4000ECA")]
	[FieldOffset(Offset = "0x28")]
	private GearItem m_GearItem;

	[Token(Token = "0x4000ECB")]
	[FieldOffset(Offset = "0x30")]
	private MaterialPropertyBlock m_PropertyBlock;

	[Token(Token = "0x4000ECC")]
	[FieldOffset(Offset = "0x38")]
	private SkinnedMeshRenderer[] m_Renderers;

	[Token(Token = "0x4000ECD")]
	private const int TUCKED_BLENDSHAPE_INDEX = 0;

	[Token(Token = "0x4000ECE")]
	private const float TUCKED_BLENDSHAPE_MAX_VALUE = 100f;

	[Token(Token = "0x6000F5F")]
	[Address(RVA = "0x610AE0", Offset = "0x60F8E0", Length = "0x185")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000F60")]
	[Address(RVA = "0x610C70", Offset = "0x60FA70", Length = "0xAFA")]
	public void Initialize(GearItem gearItem, SkinnedMeshRenderer skinningReference, Transform rootBone)
	{
	}

	[Token(Token = "0x6000F61")]
	[Address(RVA = "0x611770", Offset = "0x610570", Length = "0x29D")]
	public void UpdateTuckedFromLayerPriority(FirstPersonClothing otherClothing)
	{
	}

	[Token(Token = "0x6000F62")]
	[Address(RVA = "0x611A10", Offset = "0x610810", Length = "0x2D")]
	public void SetVisible(bool isVisible)
	{
	}

	[Token(Token = "0x6000F63")]
	[Address(RVA = "0x611A40", Offset = "0x610840", Length = "0x136")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000F64")]
	[Address(RVA = "0x611B80", Offset = "0x610980", Length = "0x7")]
	private void OnGearItemConditionChanged(GearItem gi, float previousHP, float currentHP)
	{
	}

	[Token(Token = "0x6000F65")]
	[Address(RVA = "0x611B90", Offset = "0x610990", Length = "0x23B")]
	private void UpdateDamageState()
	{
	}

	[Token(Token = "0x6000F66")]
	[Address(RVA = "0x611DD0", Offset = "0x610BD0", Length = "0x69E")]
	private void ReskinMesh(SkinnedMeshRenderer reskinned, SkinnedMeshRenderer target)
	{
	}

	[Token(Token = "0x6000F67")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public FirstPersonClothing()
	{
	}
}
