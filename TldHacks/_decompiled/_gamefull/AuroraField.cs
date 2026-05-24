using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.ModularElectrolizer;
using UnityEngine;

[Token(Token = "0x20001C1")]
public class AuroraField : MonoBehaviour
{
	[Flags]
	[Token(Token = "0x20001C2")]
	public enum ControlledComponents
	{
		[Token(Token = "0x4000F5E")]
		None = 0,
		[Token(Token = "0x4000F5F")]
		Electrolizer = 1,
		[Token(Token = "0x4000F60")]
		Toggle = 2
	}

	[Space(10f)]
	[Range(0f, 100f)]
	[Token(Token = "0x4000F4F")]
	[FieldOffset(Offset = "0x20")]
	public float m_ChanceActive;

	[Token(Token = "0x4000F50")]
	[FieldOffset(Offset = "0x24")]
	public bool m_IsStaticField;

	[Header("Dimensions")]
	[Token(Token = "0x4000F51")]
	[FieldOffset(Offset = "0x28")]
	public float m_Radius;

	[Token(Token = "0x4000F52")]
	[FieldOffset(Offset = "0x2C")]
	private bool m_IsActive;

	[Token(Token = "0x4000F53")]
	[FieldOffset(Offset = "0x2D")]
	private bool m_CanRollChance;

	[Token(Token = "0x4000F54")]
	[FieldOffset(Offset = "0x30")]
	private Collider[] m_Colliders;

	[Token(Token = "0x4000F55")]
	private static AuroraFieldDataProxy m_AuroraFieldDataProxy;

	[Token(Token = "0x4000F56")]
	[FieldOffset(Offset = "0x38")]
	private float m_ExtentRadius;

	[Token(Token = "0x4000F57")]
	private const float m_Margin = 0.5f;

	[Token(Token = "0x4000F58")]
	[FieldOffset(Offset = "0x3C")]
	private ControlledComponents m_ControlledComponents;

	[Token(Token = "0x4000F59")]
	[FieldOffset(Offset = "0x40")]
	private float m_InvSqrRootOfTwo;

	[Header("Influenced objects")]
	[Token(Token = "0x4000F5A")]
	[FieldOffset(Offset = "0x48")]
	public List<GameObject> m_InfluencedObjects;

	[Token(Token = "0x4000F5B")]
	[FieldOffset(Offset = "0x50")]
	private List<AuroraModularElectrolizer> m_InfluencedAuroraElectrolizers;

	[Token(Token = "0x4000F5C")]
	[FieldOffset(Offset = "0x58")]
	private List<AuroraActivatedToggle> m_InfluencedAAuroraActivatedToggles;

	[Token(Token = "0x6001026")]
	[Address(RVA = "0x6203F0", Offset = "0x61F1F0", Length = "0x3AC")]
	public void Awake()
	{
	}

	[Token(Token = "0x6001027")]
	[Address(RVA = "0x6207A0", Offset = "0x61F5A0", Length = "0x4E")]
	public void OnDestroy()
	{
	}

	[Token(Token = "0x6001028")]
	[Address(RVA = "0x6207F0", Offset = "0x61F5F0", Length = "0xB9")]
	public void Start()
	{
	}

	[Token(Token = "0x6001029")]
	[Address(RVA = "0x6208B0", Offset = "0x61F6B0", Length = "0x6")]
	public float GetExtentRadius()
	{
		return 0f;
	}

	[Token(Token = "0x600102A")]
	[Address(RVA = "0x6208C0", Offset = "0x61F6C0", Length = "0x101")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x600102B")]
	[Address(RVA = "0x6209D0", Offset = "0x61F7D0", Length = "0x9C")]
	public void Deserialize(string text)
	{
	}

	[Token(Token = "0x600102C")]
	[Address(RVA = "0x620A70", Offset = "0x61F870", Length = "0x20F")]
	public void SetDynamic(bool isDynamic)
	{
	}

	[Token(Token = "0x600102D")]
	[Address(RVA = "0x620C80", Offset = "0x61FA80", Length = "0x4")]
	public void SetControlledComponents(ControlledComponents controlledComponentFlags)
	{
	}

	[Token(Token = "0x600102E")]
	[Address(RVA = "0x620C90", Offset = "0x61FA90", Length = "0x7")]
	public bool DoesFieldControlComponents(ControlledComponents flag)
	{
		return false;
	}

	[Token(Token = "0x600102F")]
	[Address(RVA = "0x620CA0", Offset = "0x61FAA0", Length = "0x6")]
	public void UnsetControlledComponents(ControlledComponents flag)
	{
	}

	[Token(Token = "0x6001030")]
	[Address(RVA = "0x620CB0", Offset = "0x61FAB0", Length = "0x5")]
	public bool IsActive()
	{
		return false;
	}

	[Token(Token = "0x6001031")]
	[Address(RVA = "0x620CC0", Offset = "0x61FAC0", Length = "0x38B")]
	public Vector3 GetClosestPointOnFieldExtent(Vector3 position, float margin)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6001032")]
	[Address(RVA = "0x621050", Offset = "0x61FE50", Length = "0x6BF")]
	public Vector3 GetClosestPointOnFieldBorder(Vector3 position)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6001033")]
	[Address(RVA = "0x621710", Offset = "0x620510", Length = "0x76")]
	public void OnAuroraEnabled()
	{
	}

	[Token(Token = "0x6001034")]
	[Address(RVA = "0x621790", Offset = "0x620590", Length = "0x4A")]
	public void OnAuroraDisabled()
	{
	}

	[Token(Token = "0x6001035")]
	[Address(RVA = "0x6217E0", Offset = "0x6205E0", Length = "0x337")]
	public bool Contains(Vector3 position)
	{
		return false;
	}

	[Token(Token = "0x6001036")]
	[Address(RVA = "0x621B20", Offset = "0x620920", Length = "0x316")]
	public bool Contains(Vector3 position, float radius)
	{
		return false;
	}

	[Token(Token = "0x6001037")]
	[Address(RVA = "0x621E40", Offset = "0x620C40", Length = "0xC")]
	public void Enable(bool enabled)
	{
	}

	[Token(Token = "0x6001038")]
	[Address(RVA = "0x621E50", Offset = "0x620C50", Length = "0x5")]
	public bool IsStaticField()
	{
		return false;
	}

	[Token(Token = "0x6001039")]
	[Address(RVA = "0x621E60", Offset = "0x620C60", Length = "0x1B5")]
	public static void ResetAllAuroraFieldLayerToDefault(GameObject rootObject)
	{
	}

	[Token(Token = "0x600103A")]
	[Address(RVA = "0x622020", Offset = "0x620E20", Length = "0x14A")]
	private void SetFieldActive(bool enabled)
	{
	}

	[Token(Token = "0x600103B")]
	[Address(RVA = "0x622170", Offset = "0x620F70", Length = "0x62")]
	private bool ShouldActivate()
	{
		return false;
	}

	[Token(Token = "0x600103C")]
	[Address(RVA = "0x6221E0", Offset = "0x620FE0", Length = "0x240")]
	private void ActivateElectrolizers(bool enabled)
	{
	}

	[Token(Token = "0x600103D")]
	[Address(RVA = "0x622430", Offset = "0x621230", Length = "0x2F0")]
	private void ActivateToggles(bool enabled)
	{
	}

	[Token(Token = "0x600103E")]
	[Address(RVA = "0x622730", Offset = "0x621530", Length = "0x134")]
	private void OnFieldEnableChanged(bool enabled)
	{
	}

	[Token(Token = "0x600103F")]
	[Address(RVA = "0x622870", Offset = "0x621670", Length = "0x556")]
	private void ComputeRadiusExtent()
	{
	}

	[Token(Token = "0x6001040")]
	[Address(RVA = "0x622DD0", Offset = "0x621BD0", Length = "0x1D1")]
	public AuroraField()
	{
	}
}
