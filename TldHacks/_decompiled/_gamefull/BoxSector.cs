using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20009AD")]
public class BoxSector : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x20009AE")]
	public struct ObjectDef
	{
		[Token(Token = "0x400630F")]
		[FieldOffset(Offset = "0x0")]
		public GameObject m_Object;

		[Token(Token = "0x4006310")]
		[FieldOffset(Offset = "0x8")]
		public Renderer m_Renderer;

		[Token(Token = "0x4006311")]
		[FieldOffset(Offset = "0x10")]
		public LODGroup m_ObjectLodGroup;
	}

	[Token(Token = "0x4006306")]
	[FieldOffset(Offset = "0x20")]
	private BoxSectorManager m_MyManager;

	[Header("Local objects")]
	[Token(Token = "0x4006307")]
	[FieldOffset(Offset = "0x28")]
	public List<ObjectDef> m_GameObjects;

	[Token(Token = "0x4006308")]
	[FieldOffset(Offset = "0x30")]
	public List<ObjectDef> m_StructureObjects;

	[Header("Visibility")]
	[Tooltip("Defined other sectors that will be visible when the player enters this sector")]
	[Token(Token = "0x4006309")]
	[FieldOffset(Offset = "0x38")]
	public List<BoxSector> m_VisibilityList;

	[Token(Token = "0x400630A")]
	[FieldOffset(Offset = "0x40")]
	public List<BoxSector> m_StructureVisList;

	[Header("Collider")]
	[Token(Token = "0x400630B")]
	[FieldOffset(Offset = "0x48")]
	public BoxCollider m_LocalCollider;

	[Token(Token = "0x400630C")]
	[FieldOffset(Offset = "0x50")]
	public bool m_IsActive;

	[Token(Token = "0x400630D")]
	[FieldOffset(Offset = "0x51")]
	private bool m_HasInitializedCollider;

	[Tooltip("This sector gets skipped and ignored when determining decoration item serialization in Safehouse Customization mode")]
	[SerializeField]
	[Token(Token = "0x400630E")]
	[FieldOffset(Offset = "0x52")]
	private bool m_IgnoreDecorations;

	[Token(Token = "0x1700037F")]
	public BoxSectorManager MyManager
	{
		[Token(Token = "0x600561F")]
		[Address(RVA = "0x40E120", Offset = "0x40CF20", Length = "0x52")]
		set
		{
		}
	}

	[Token(Token = "0x17000380")]
	public bool IgnoreDecorations
	{
		[Token(Token = "0x6005620")]
		[Address(RVA = "0xEB0A00", Offset = "0xEAF800", Length = "0x5")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x6005621")]
	[Address(RVA = "0xEB0A10", Offset = "0xEAF810", Length = "0x7")]
	private void Start()
	{
	}

	[Token(Token = "0x6005622")]
	[Address(RVA = "0xEB0A20", Offset = "0xEAF820", Length = "0x10D")]
	public void MaybeInitializeCollider()
	{
	}

	[Token(Token = "0x6005623")]
	[Address(RVA = "0xEB0B30", Offset = "0xEAF930", Length = "0x2DE")]
	public void ShowObject(BoxSectorManager.SectorCullMode cullMode)
	{
	}

	[Token(Token = "0x6005624")]
	[Address(RVA = "0xEB0E10", Offset = "0xEAFC10", Length = "0x2DE")]
	public void HideObject(BoxSectorManager.SectorCullMode cullMode)
	{
	}

	[Token(Token = "0x6005625")]
	[Address(RVA = "0xEB10F0", Offset = "0xEAFEF0", Length = "0x2EE")]
	public void ShowStructure(BoxSectorManager.SectorCullMode cullMode)
	{
	}

	[Token(Token = "0x6005626")]
	[Address(RVA = "0xEB13E0", Offset = "0xEB01E0", Length = "0x2EE")]
	public void HideStructure(BoxSectorManager.SectorCullMode cullMode)
	{
	}

	[Token(Token = "0x6005627")]
	[Address(RVA = "0xEB16D0", Offset = "0xEB04D0", Length = "0x1D9")]
	public void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6005628")]
	[Address(RVA = "0xEB18B0", Offset = "0xEB06B0", Length = "0x199")]
	public void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x6005629")]
	[Address(RVA = "0xEB1A50", Offset = "0xEB0850", Length = "0x32F")]
	public void AddDecorationItem(DecorationItem decor)
	{
	}

	[Token(Token = "0x600562A")]
	[Address(RVA = "0xEB1D80", Offset = "0xEB0B80", Length = "0x2BF")]
	public void RemoveDecorationItem(DecorationItem decor)
	{
	}

	[Token(Token = "0x600562B")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public BoxSector()
	{
	}
}
