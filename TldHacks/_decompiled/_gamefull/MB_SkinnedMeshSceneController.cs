using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000AEA")]
public class MB_SkinnedMeshSceneController : MonoBehaviour
{
	[Token(Token = "0x400695D")]
	[FieldOffset(Offset = "0x20")]
	public GameObject swordPrefab;

	[Token(Token = "0x400695E")]
	[FieldOffset(Offset = "0x28")]
	public GameObject hatPrefab;

	[Token(Token = "0x400695F")]
	[FieldOffset(Offset = "0x30")]
	public GameObject glassesPrefab;

	[Token(Token = "0x4006960")]
	[FieldOffset(Offset = "0x38")]
	public GameObject workerPrefab;

	[Token(Token = "0x4006961")]
	[FieldOffset(Offset = "0x40")]
	public GameObject targetCharacter;

	[Token(Token = "0x4006962")]
	[FieldOffset(Offset = "0x48")]
	public MB3_MeshBaker skinnedMeshBaker;

	[Token(Token = "0x4006963")]
	[FieldOffset(Offset = "0x50")]
	private GameObject swordInstance;

	[Token(Token = "0x4006964")]
	[FieldOffset(Offset = "0x58")]
	private GameObject glassesInstance;

	[Token(Token = "0x4006965")]
	[FieldOffset(Offset = "0x60")]
	private GameObject hatInstance;

	[Token(Token = "0x6005CDB")]
	[Address(RVA = "0xF57700", Offset = "0xF56500", Length = "0x376")]
	private void Start()
	{
	}

	[Token(Token = "0x6005CDC")]
	[Address(RVA = "0xF57A80", Offset = "0xF56880", Length = "0x13BC")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x6005CDD")]
	[Address(RVA = "0xF58E40", Offset = "0xF57C40", Length = "0x20C")]
	public Transform SearchHierarchyForBone(Transform current, string name)
	{
		return null;
	}

	[Token(Token = "0x6005CDE")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public MB_SkinnedMeshSceneController()
	{
	}
}
