using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000038")]
public class iTweenPath : MonoBehaviour
{
	[Token(Token = "0x40002E1")]
	[FieldOffset(Offset = "0x20")]
	public string pathName;

	[Token(Token = "0x40002E2")]
	[FieldOffset(Offset = "0x28")]
	public Color pathColor;

	[Token(Token = "0x40002E3")]
	[FieldOffset(Offset = "0x38")]
	public List<Vector3> nodes;

	[Token(Token = "0x40002E4")]
	[FieldOffset(Offset = "0x40")]
	public int nodeCount;

	[Token(Token = "0x40002E5")]
	public static Dictionary<string, iTweenPath> paths;

	[Token(Token = "0x40002E6")]
	[FieldOffset(Offset = "0x44")]
	public bool initialized;

	[Token(Token = "0x40002E7")]
	[FieldOffset(Offset = "0x48")]
	public string initialName;

	[Token(Token = "0x6000311")]
	[Address(RVA = "0x8988C0", Offset = "0x8976C0", Length = "0xBC")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000312")]
	[Address(RVA = "0x898980", Offset = "0x897780", Length = "0x1A1")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x6000313")]
	[Address(RVA = "0x898B30", Offset = "0x897930", Length = "0x16E")]
	public static Vector3[] GetPath(string requestedName)
	{
		return null;
	}

	[Token(Token = "0x6000314")]
	[Address(RVA = "0x898CA0", Offset = "0x897AA0", Length = "0x33D")]
	public iTweenPath()
	{
	}
}
