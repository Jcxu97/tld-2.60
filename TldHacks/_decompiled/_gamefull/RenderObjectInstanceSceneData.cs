using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20008F0")]
public class RenderObjectInstanceSceneData : MonoBehaviour
{
	[Token(Token = "0x4005DA8")]
	[FieldOffset(Offset = "0x20")]
	public RenderObjectInstance.Category m_Category;

	[Token(Token = "0x4005DA9")]
	[FieldOffset(Offset = "0x24")]
	public bool m_IgnoreDisabledObjects;

	[Token(Token = "0x4005DAA")]
	[FieldOffset(Offset = "0x28")]
	public List<GameObject> m_ObjectParents;

	[Tooltip("A lit of objects to find within the scene, regardless of where they are in the hierarchy. Useful for finding objects within a nested hierarchy without disrupting the parent prefab.")]
	[SerializeField]
	[Token(Token = "0x4005DAB")]
	[FieldOffset(Offset = "0x30")]
	private List<GameObject> m_GlobalObjects;

	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x4005DAC")]
	[FieldOffset(Offset = "0x38")]
	public List<string> m_InstancedMeshNames;

	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x4005DAD")]
	[FieldOffset(Offset = "0x40")]
	public List<int> m_InstancedMeshCounts;

	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x4005DAE")]
	[FieldOffset(Offset = "0x48")]
	public Bounds m_Bounds;

	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x4005DAF")]
	[FieldOffset(Offset = "0x60")]
	public int m_NumInstances;

	[Token(Token = "0x4005DB0")]
	public static bool s_EnableWarningLogs;

	[HideInInspector]
	[SerializeField]
	[Token(Token = "0x4005DB1")]
	[FieldOffset(Offset = "0x68")]
	public List<Mesh> m_UniqueMeshes;

	[Token(Token = "0x17000373")]
	public List<GameObject> GlobalObjects
	{
		[Token(Token = "0x6005200")]
		[Address(RVA = "0x457420", Offset = "0x456220", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6005201")]
	[Address(RVA = "0xE3A3F0", Offset = "0xE391F0", Length = "0x452")]
	public void RegenerateInstanceLists()
	{
	}

	[Token(Token = "0x6005202")]
	[Address(RVA = "0xE3A850", Offset = "0xE39650", Length = "0x45A")]
	private int FindRenderers(KeyValuePair<int, List<Renderer>> kvp)
	{
		return 0;
	}

	[Token(Token = "0x6005203")]
	[Address(RVA = "0xE3ACB0", Offset = "0xE39AB0", Length = "0x1EC")]
	public int GetRenderBatchCount()
	{
		return 0;
	}

	[Token(Token = "0x6005204")]
	[Address(RVA = "0xE3AEA0", Offset = "0xE39CA0", Length = "0x21F")]
	public RenderObjectInstanceSceneData()
	{
	}
}
