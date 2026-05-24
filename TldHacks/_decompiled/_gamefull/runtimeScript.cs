using Cpp2ILInjected;
using EasyRoads3Dv3;
using UnityEngine;

[Token(Token = "0x2000AA0")]
public class runtimeScript : MonoBehaviour
{
	[Token(Token = "0x4006865")]
	[FieldOffset(Offset = "0x20")]
	public ERRoadNetwork roadNetwork;

	[Token(Token = "0x4006866")]
	[FieldOffset(Offset = "0x28")]
	public ERRoad road;

	[Token(Token = "0x4006867")]
	[FieldOffset(Offset = "0x30")]
	public GameObject go;

	[Token(Token = "0x4006868")]
	[FieldOffset(Offset = "0x38")]
	public int currentElement;

	[Token(Token = "0x4006869")]
	[FieldOffset(Offset = "0x3C")]
	public float distance;

	[Token(Token = "0x400686A")]
	[FieldOffset(Offset = "0x40")]
	public float speed;

	[Token(Token = "0x6005C4E")]
	[Address(RVA = "0xF3BCF0", Offset = "0xF3AAF0", Length = "0x18C")]
	private void Start()
	{
	}

	[Token(Token = "0x6005C4F")]
	[Address(RVA = "0xF3BE80", Offset = "0xF3AC80", Length = "0x575")]
	private void CreateNewRoadNetwork()
	{
	}

	[Token(Token = "0x6005C50")]
	[Address(RVA = "0xF3C400", Offset = "0xF3B200", Length = "0x4D5")]
	private void CreateRoadNetwork()
	{
	}

	[Token(Token = "0x6005C51")]
	[Address(RVA = "0xF3C8E0", Offset = "0xF3B6E0", Length = "0x1F0")]
	private void Update()
	{
	}

	[Token(Token = "0x6005C52")]
	[Address(RVA = "0xF3CAE0", Offset = "0xF3B8E0", Length = "0xA4")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6005C53")]
	[Address(RVA = "0xF3CB90", Offset = "0xF3B990", Length = "0x4A")]
	public runtimeScript()
	{
	}
}
