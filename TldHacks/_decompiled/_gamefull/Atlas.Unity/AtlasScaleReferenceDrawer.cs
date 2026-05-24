using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

namespace Atlas.Unity;

[Token(Token = "0x2000D12")]
public class AtlasScaleReferenceDrawer
{
	[Token(Token = "0x2000D13")]
	public enum ScaleReferenceType
	{
		[Token(Token = "0x4008178")]
		Human,
		[Token(Token = "0x4008179")]
		Tree,
		[Token(Token = "0x400817A")]
		Bush,
		[Token(Token = "0x400817B")]
		House
	}

	[Token(Token = "0x4008170")]
	[FieldOffset(Offset = "0x28")]
	public HideFlags subHideFlags;

	[Token(Token = "0x4008174")]
	[FieldOffset(Offset = "0x40")]
	private ScaleReferenceType preScaleReferenceType;

	[Token(Token = "0x4008175")]
	[FieldOffset(Offset = "0x44")]
	private Vector3 lastCameraPosition;

	[Token(Token = "0x4008176")]
	[FieldOffset(Offset = "0x50")]
	private int tick;

	[Token(Token = "0x1700071B")]
	[field: Token(Token = "0x400816D")]
	[field: FieldOffset(Offset = "0x10")]
	public bool isDrawing
	{
		[Token(Token = "0x600672F")]
		[Address(RVA = "0x504260", Offset = "0x503060", Length = "0x5")]
		get;
		[Token(Token = "0x6006730")]
		[Address(RVA = "0x4B7B30", Offset = "0x4B6930", Length = "0x4")]
		private set;
	}

	[Token(Token = "0x1700071C")]
	[field: Token(Token = "0x400816E")]
	[field: FieldOffset(Offset = "0x18")]
	public Transform parent
	{
		[Token(Token = "0x6006731")]
		[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
		get;
		[Token(Token = "0x6006732")]
		[Address(RVA = "0x49DEE0", Offset = "0x49CCE0", Length = "0x52")]
		private set;
	}

	[Token(Token = "0x1700071D")]
	[field: Token(Token = "0x400816F")]
	[field: FieldOffset(Offset = "0x20")]
	public List<GameObject> gameObjects
	{
		[Token(Token = "0x6006733")]
		[Address(RVA = "0x40E110", Offset = "0x40CF10", Length = "0x5")]
		get;
		[Token(Token = "0x6006734")]
		[Address(RVA = "0x40E120", Offset = "0x40CF20", Length = "0x52")]
		private set;
	}

	[Token(Token = "0x1700071E")]
	[field: Token(Token = "0x4008171")]
	[field: FieldOffset(Offset = "0x2C")]
	public float spacing
	{
		[Token(Token = "0x6006735")]
		[Address(RVA = "0x5093C0", Offset = "0x5081C0", Length = "0x6")]
		get;
		[Token(Token = "0x6006736")]
		[Address(RVA = "0x5093D0", Offset = "0x5081D0", Length = "0x6")]
		private set;
	}

	[Token(Token = "0x1700071F")]
	[field: Token(Token = "0x4008172")]
	[field: FieldOffset(Offset = "0x30")]
	public int cellCount
	{
		[Token(Token = "0x6006737")]
		[Address(RVA = "0x677F80", Offset = "0x676D80", Length = "0x4")]
		get;
		[Token(Token = "0x6006738")]
		[Address(RVA = "0xD7E9C0", Offset = "0xD7D7C0", Length = "0x4")]
		private set;
	}

	[Token(Token = "0x17000720")]
	[field: Token(Token = "0x4008173")]
	[field: FieldOffset(Offset = "0x38")]
	public GameObject prefab
	{
		[Token(Token = "0x6006739")]
		[Address(RVA = "0x4A7D50", Offset = "0x4A6B50", Length = "0x5")]
		get;
		[Token(Token = "0x600673A")]
		[Address(RVA = "0x509400", Offset = "0x508200", Length = "0x52")]
		private set;
	}

	[Token(Token = "0x600673B")]
	[Address(RVA = "0x103C8C0", Offset = "0x103B6C0", Length = "0x12B")]
	public AtlasScaleReferenceDrawer(Transform parent)
	{
	}

	[Token(Token = "0x600673C")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public void ForceDraw(ScaleReferenceType scaleReferenceType = ScaleReferenceType.Human)
	{
	}

	[Token(Token = "0x600673D")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public void Update(bool draw, ScaleReferenceType scaleReferenceType = ScaleReferenceType.Human, bool force = false)
	{
	}

	[Token(Token = "0x600673E")]
	[Address(RVA = "0x103C9F0", Offset = "0x103B7F0", Length = "0x1A")]
	public void OnDisable()
	{
	}

	[Token(Token = "0x600673F")]
	[Address(RVA = "0x103CA10", Offset = "0x103B810", Length = "0x3F4")]
	private void CreateGameObjects(ScaleReferenceType scaleReferenceType)
	{
	}

	[Token(Token = "0x6006740")]
	[Address(RVA = "0x103CE10", Offset = "0x103BC10", Length = "0x1C5")]
	private void DestroyGameObjects()
	{
	}

	[Token(Token = "0x6006741")]
	[Address(RVA = "0x4582A0", Offset = "0x4570A0", Length = "0x3")]
	private GameObject FindScaleReferencePrefab(string pattern)
	{
		return null;
	}
}
