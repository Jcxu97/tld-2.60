using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

[ExecuteInEditMode]
[Token(Token = "0x200059E")]
public class PrefabSpawn : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x200059F")]
	public class Element
	{
		[Token(Token = "0x40033E7")]
		[FieldOffset(Offset = "0x10")]
		public GameObject m_Prefab;

		[Token(Token = "0x40033E8")]
		[FieldOffset(Offset = "0x18")]
		public Vector3 m_Offset;

		[Token(Token = "0x40033E9")]
		[FieldOffset(Offset = "0x24")]
		public Vector3 m_Rotation;

		[Token(Token = "0x40033EA")]
		[FieldOffset(Offset = "0x30")]
		public Vector3 m_Scale;

		[Token(Token = "0x40033EB")]
		[FieldOffset(Offset = "0x3C")]
		public int m_SpawnWeight;

		[Token(Token = "0x40033EC")]
		[FieldOffset(Offset = "0x40")]
		public uint m_LodMask;

		[Token(Token = "0x40033ED")]
		[FieldOffset(Offset = "0x44")]
		public int m_SetId;

		[NonSerialized]
		[Token(Token = "0x40033EE")]
		[FieldOffset(Offset = "0x48")]
		public bool m_ShowTransform;

		[NonSerialized]
		[Token(Token = "0x40033EF")]
		[FieldOffset(Offset = "0x50")]
		public GameObject m_PreviewObject;

		[Token(Token = "0x6002B87")]
		[Address(RVA = "0x91DAB0", Offset = "0x91C8B0", Length = "0xCF")]
		public Element()
		{
		}

		[Token(Token = "0x6002B88")]
		[Address(RVA = "0x91DB80", Offset = "0x91C980", Length = "0xB9")]
		public void Set(Element other)
		{
		}
	}

	[Token(Token = "0x20005A0")]
	public class PrefabSpawnSaveData
	{
		[Token(Token = "0x40033F0")]
		[FieldOffset(Offset = "0x10")]
		public string m_Guid;

		[Token(Token = "0x40033F1")]
		[FieldOffset(Offset = "0x18")]
		public bool m_SpawnComplete;

		[Token(Token = "0x6002B89")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public PrefabSpawnSaveData()
		{
		}
	}

	[HideInInspector]
	[Token(Token = "0x40033DC")]
	[FieldOffset(Offset = "0x20")]
	public Element[] m_PrefabList;

	[HideInInspector]
	[Token(Token = "0x40033DD")]
	[FieldOffset(Offset = "0x28")]
	public float[] m_LodHeights;

	[HideInInspector]
	[Token(Token = "0x40033DE")]
	[FieldOffset(Offset = "0x30")]
	public int m_NumToSpawnMin;

	[HideInInspector]
	[Token(Token = "0x40033DF")]
	[FieldOffset(Offset = "0x34")]
	public int m_NumToSpawnMax;

	[HideInInspector]
	[Token(Token = "0x40033E0")]
	[FieldOffset(Offset = "0x38")]
	public int m_ChanceOfNoSpawn;

	[HideInInspector]
	[Token(Token = "0x40033E1")]
	[FieldOffset(Offset = "0x3C")]
	public bool m_TakePrefabScale;

	[HideInInspector]
	[Token(Token = "0x40033E2")]
	[FieldOffset(Offset = "0x3D")]
	public bool m_SpawnComplete;

	[Tooltip("WARNING: Only enable this on new objects that are not enabled by default!")]
	[Token(Token = "0x40033E3")]
	[FieldOffset(Offset = "0x3E")]
	public bool m_UseSerialization;

	[Token(Token = "0x40033E5")]
	[FieldOffset(Offset = "0x48")]
	private string m_Guid;

	[Token(Token = "0x40033E6")]
	private static readonly List<PrefabSpawn> s_SerializeSpawners;

	[Token(Token = "0x14000005")]
	public event Action<List<GameObject>> SpawnCompleted
	{
		[CompilerGenerated]
		[Token(Token = "0x6002B77")]
		[Address(RVA = "0x91B600", Offset = "0x91A400", Length = "0x166")]
		add
		{
		}
		[CompilerGenerated]
		[Token(Token = "0x6002B78")]
		[Address(RVA = "0x91B770", Offset = "0x91A570", Length = "0x166")]
		remove
		{
		}
	}

	[Token(Token = "0x6002B79")]
	[Address(RVA = "0x91B8E0", Offset = "0x91A6E0", Length = "0x18C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6002B7A")]
	[Address(RVA = "0x91BA70", Offset = "0x91A870", Length = "0xC5")]
	private void Update()
	{
	}

	[Token(Token = "0x6002B7B")]
	[Address(RVA = "0x91BB40", Offset = "0x91A940", Length = "0xD3")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6002B7C")]
	[Address(RVA = "0x91BC20", Offset = "0x91AA20", Length = "0xA45")]
	public GameObject SpawnObjects()
	{
		return null;
	}

	[Token(Token = "0x6002B7D")]
	[Address(RVA = "0x91C670", Offset = "0x91B470", Length = "0x14E")]
	public List<int> CalculateSetWeights(out int sumOfAllWeights)
	{
		sumOfAllWeights = default(int);
		return null;
	}

	[Token(Token = "0x6002B7E")]
	[Address(RVA = "0x91C7C0", Offset = "0x91B5C0", Length = "0x656")]
	public GameObject SpawnObject(Element spawnElement)
	{
		return null;
	}

	[Token(Token = "0x6002B7F")]
	[Address(RVA = "0x91CE20", Offset = "0x91BC20", Length = "0x12E")]
	public static string GetNameFromValue(string text)
	{
		return null;
	}

	[Token(Token = "0x6002B80")]
	[Address(RVA = "0x91CF50", Offset = "0x91BD50", Length = "0x1D4")]
	public static int GetIndexFromValue(string text)
	{
		return 0;
	}

	[Token(Token = "0x6002B81")]
	[Address(RVA = "0x91D130", Offset = "0x91BF30", Length = "0x64")]
	public static string GetNewKeyFromNameAndIndex(string text, int index)
	{
		return null;
	}

	[Token(Token = "0x6002B82")]
	[Address(RVA = "0x91D1A0", Offset = "0x91BFA0", Length = "0x3A9")]
	public static void DeserializeAll(string serialized)
	{
	}

	[Token(Token = "0x6002B83")]
	[Address(RVA = "0x91D550", Offset = "0x91C350", Length = "0x93")]
	public static void ResetAll()
	{
	}

	[Token(Token = "0x6002B84")]
	[Address(RVA = "0x91D5F0", Offset = "0x91C3F0", Length = "0x374")]
	public static string SerializeAll()
	{
		return null;
	}

	[Token(Token = "0x6002B85")]
	[Address(RVA = "0x91D970", Offset = "0x91C770", Length = "0x55")]
	public PrefabSpawn()
	{
	}
}
