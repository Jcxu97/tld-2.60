using Cpp2ILInjected;
using TLD.Gear;
using UnityEngine;

[Token(Token = "0x2000261")]
public class MaterialsTable : MonoBehaviour
{
	[Token(Token = "0x40015A1")]
	[FieldOffset(Offset = "0x20")]
	public HarvestRepairMaterial[] m_RequiredMaterials;

	[Token(Token = "0x40015A2")]
	[FieldOffset(Offset = "0x28")]
	public Color m_RequiredMaterialsLabelDefaultColor;

	[Token(Token = "0x40015A3")]
	[FieldOffset(Offset = "0x38")]
	public UILabel m_Repair_RequiredMaterialsLabel;

	[Token(Token = "0x40015A4")]
	[FieldOffset(Offset = "0x40")]
	public float m_RequiredMaterialSpacing;

	[Token(Token = "0x60014E4")]
	[Address(RVA = "0x696670", Offset = "0x695470", Length = "0x6C2")]
	public void RefreshMaterials(IRepairable repairable)
	{
	}

	[Token(Token = "0x60014E5")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public MaterialsTable()
	{
	}
}
