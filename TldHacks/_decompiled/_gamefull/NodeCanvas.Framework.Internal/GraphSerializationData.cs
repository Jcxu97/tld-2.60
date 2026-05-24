using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

namespace NodeCanvas.Framework.Internal;

[Serializable]
[Token(Token = "0x200108E")]
public class GraphSerializationData
{
	[Token(Token = "0x40085DB")]
	public const float FRAMEWORK_VERSION = 2.91f;

	[Token(Token = "0x40085DC")]
	[FieldOffset(Offset = "0x10")]
	public float version;

	[Token(Token = "0x40085DD")]
	[FieldOffset(Offset = "0x18")]
	public Type type;

	[Token(Token = "0x40085DE")]
	[FieldOffset(Offset = "0x20")]
	public string name;

	[Token(Token = "0x40085DF")]
	[FieldOffset(Offset = "0x28")]
	public string category;

	[Token(Token = "0x40085E0")]
	[FieldOffset(Offset = "0x30")]
	public string comments;

	[Token(Token = "0x40085E1")]
	[FieldOffset(Offset = "0x38")]
	public Vector2 translation;

	[Token(Token = "0x40085E2")]
	[FieldOffset(Offset = "0x40")]
	public float zoomFactor;

	[Token(Token = "0x40085E3")]
	[FieldOffset(Offset = "0x48")]
	public List<Node> nodes;

	[Token(Token = "0x40085E4")]
	[FieldOffset(Offset = "0x50")]
	public List<Connection> connections;

	[Token(Token = "0x40085E5")]
	[FieldOffset(Offset = "0x58")]
	public List<CanvasGroup> canvasGroups;

	[Token(Token = "0x40085E6")]
	[FieldOffset(Offset = "0x60")]
	public BlackboardSource localBlackboard;

	[Token(Token = "0x40085E7")]
	[FieldOffset(Offset = "0x68")]
	public object derivedData;

	[Token(Token = "0x60070A8")]
	[Address(RVA = "0x10CF280", Offset = "0x10CE080", Length = "0x27B")]
	public GraphSerializationData()
	{
	}

	[Token(Token = "0x60070A9")]
	[Address(RVA = "0x10CF500", Offset = "0x10CE300", Length = "0x6AD")]
	public GraphSerializationData(Graph graph)
	{
	}

	[Token(Token = "0x60070AA")]
	[Address(RVA = "0x10CFBB0", Offset = "0x10CE9B0", Length = "0x3A3")]
	public void Reconstruct(Graph graph)
	{
	}
}
