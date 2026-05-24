using System.Collections.Generic;
using System.Threading;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000A3A")]
public class ThreadedImageWriter : MonoBehaviour
{
	[Token(Token = "0x400669B")]
	[FieldOffset(Offset = "0x20")]
	private Thread[] writerThreads;

	[Token(Token = "0x400669C")]
	[FieldOffset(Offset = "0x28")]
	private Queue<ImageWriteRequest>[] writerQueues;

	[Token(Token = "0x400669D")]
	[FieldOffset(Offset = "0x30")]
	private int nextWriterQueue;

	[Token(Token = "0x400669E")]
	private const int NUM_WRITER_THREADS = 4;

	[Token(Token = "0x6005926")]
	[Address(RVA = "0xEF11B0", Offset = "0xEEFFB0", Length = "0x612")]
	private void Start()
	{
	}

	[Token(Token = "0x6005927")]
	[Address(RVA = "0xEF17D0", Offset = "0xEF05D0", Length = "0x30F")]
	public void AddWriteRequest(string filename, Color[] image, uint width, uint height, ImageWriteRequest.Type type, float farClip)
	{
	}

	[Token(Token = "0x6005928")]
	[Address(RVA = "0xEF1AE0", Offset = "0xEF08E0", Length = "0x2FE")]
	public void AddWriteRequest(string filename, Color[] image, uint width, uint height, ImageWriteRequest.Type type)
	{
	}

	[Token(Token = "0x6005929")]
	[Address(RVA = "0xEF1DE0", Offset = "0xEF0BE0", Length = "0x2FE")]
	public void AddWriteRequest(string filename, byte[] image, uint width, uint height, ImageWriteRequest.Type type)
	{
	}

	[Token(Token = "0x600592A")]
	[Address(RVA = "0xEF20E0", Offset = "0xEF0EE0", Length = "0x80")]
	public bool IsFallingBehind()
	{
		return false;
	}

	[Token(Token = "0x600592B")]
	[Address(RVA = "0xEF2170", Offset = "0xEF0F70", Length = "0xAE2")]
	private void ImageWriter(object obj)
	{
	}

	[Token(Token = "0x600592C")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public ThreadedImageWriter()
	{
	}
}
