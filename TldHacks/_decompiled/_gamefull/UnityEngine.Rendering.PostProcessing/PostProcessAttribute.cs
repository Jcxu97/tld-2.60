using System;
using Cpp2ILInjected;

namespace UnityEngine.Rendering.PostProcessing;

[AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
[Token(Token = "0x2000C7B")]
public sealed class PostProcessAttribute : Attribute
{
	[Token(Token = "0x4007DBE")]
	[FieldOffset(Offset = "0x10")]
	public readonly Type renderer;

	[Token(Token = "0x4007DBF")]
	[FieldOffset(Offset = "0x18")]
	public readonly PostProcessEvent eventType;

	[Token(Token = "0x4007DC0")]
	[FieldOffset(Offset = "0x20")]
	public readonly string menuItem;

	[Token(Token = "0x4007DC1")]
	[FieldOffset(Offset = "0x28")]
	public readonly bool allowInSceneView;

	[Token(Token = "0x4007DC2")]
	[FieldOffset(Offset = "0x29")]
	internal readonly bool builtinEffect;

	[Token(Token = "0x6006481")]
	[Address(RVA = "0xFE8300", Offset = "0xFE7100", Length = "0xBD")]
	public PostProcessAttribute(Type renderer, PostProcessEvent eventType, string menuItem, bool allowInSceneView = true)
	{
	}

	[Token(Token = "0x6006482")]
	[Address(RVA = "0xFE83C0", Offset = "0xFE71C0", Length = "0xCD")]
	internal PostProcessAttribute(Type renderer, string menuItem, bool allowInSceneView = true)
	{
	}
}
