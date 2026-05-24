using System;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20008F5")]
public class RenderTextureGrabber : MonoBehaviour
{
	[Token(Token = "0x4005DC4")]
	[FieldOffset(Offset = "0x20")]
	public Action OnRenderCompleted;

	[Token(Token = "0x4005DC5")]
	[FieldOffset(Offset = "0x28")]
	public RenderTexture m_RenderTexture;

	[Token(Token = "0x4005DC6")]
	[FieldOffset(Offset = "0x30")]
	public Camera m_Camera;

	[Token(Token = "0x4005DC7")]
	[FieldOffset(Offset = "0x38")]
	public Renderer m_LocalDisplay;

	[SerializeField]
	[Token(Token = "0x4005DC8")]
	[FieldOffset(Offset = "0x40")]
	private int m_RenderTextureWidth;

	[SerializeField]
	[Token(Token = "0x4005DC9")]
	[FieldOffset(Offset = "0x44")]
	private int m_RenderTextureHeight;

	[Token(Token = "0x4005DCA")]
	[FieldOffset(Offset = "0x48")]
	private GameObject m_DisplayInterface;

	[Token(Token = "0x6005224")]
	[Address(RVA = "0xE3D110", Offset = "0xE3BF10", Length = "0x35E")]
	private void CreateRenderTexture()
	{
	}

	[Token(Token = "0x6005225")]
	[Address(RVA = "0xE3D470", Offset = "0xE3C270", Length = "0xD4")]
	private void Start()
	{
	}

	[Token(Token = "0x6005226")]
	[Address(RVA = "0x4D0B60", Offset = "0x4CF960", Length = "0x52")]
	public void SetDisplayInterface(GameObject displayInterface)
	{
	}

	[Token(Token = "0x6005227")]
	[Address(RVA = "0xE3D550", Offset = "0xE3C350", Length = "0xD4")]
	public void Update()
	{
	}

	[Token(Token = "0x6005228")]
	[Address(RVA = "0xE3D630", Offset = "0xE3C430", Length = "0x70")]
	public void SetDirty()
	{
	}

	[Token(Token = "0x6005229")]
	[Address(RVA = "0xE3CE50", Offset = "0xE3BC50", Length = "0x16")]
	private void HandleOnRenderCompleted()
	{
	}

	[Token(Token = "0x600522A")]
	[Address(RVA = "0xE3D6B0", Offset = "0xE3C4B0", Length = "0x2DF")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600522B")]
	[Address(RVA = "0xE3D990", Offset = "0xE3C790", Length = "0x51")]
	public RenderTextureGrabber()
	{
	}
}
