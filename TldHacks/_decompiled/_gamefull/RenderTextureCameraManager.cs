using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20008F3")]
public class RenderTextureCameraManager : MonoBehaviour
{
	[Token(Token = "0x20008F4")]
	public class RenderTextureManagedCamera
	{
		[Token(Token = "0x4005DBD")]
		[FieldOffset(Offset = "0x10")]
		public readonly GameObject m_DisplayInterface;

		[Token(Token = "0x4005DBE")]
		[FieldOffset(Offset = "0x18")]
		public readonly Camera m_Camera;

		[Token(Token = "0x4005DC0")]
		[FieldOffset(Offset = "0x28")]
		private bool m_IsDirty;

		[Token(Token = "0x4005DC1")]
		[FieldOffset(Offset = "0x29")]
		private bool m_WasInterfaceActive;

		[Token(Token = "0x4005DC2")]
		[FieldOffset(Offset = "0x2C")]
		private int m_Index;

		[Token(Token = "0x4005DC3")]
		private const int LAYER_UI = 32;

		[Token(Token = "0x14000015")]
		private event Action m_OnRenderCompleted
		{
			[CompilerGenerated]
			[Token(Token = "0x6005219")]
			[Address(RVA = "0xE3CA00", Offset = "0xE3B800", Length = "0xEB")]
			add
			{
			}
			[CompilerGenerated]
			[Token(Token = "0x600521A")]
			[Address(RVA = "0xE3CAF0", Offset = "0xE3B8F0", Length = "0xEB")]
			remove
			{
			}
		}

		[Token(Token = "0x600521B")]
		[Address(RVA = "0xE3CBE0", Offset = "0xE3B9E0", Length = "0x150")]
		public RenderTextureManagedCamera(Camera camera, GameObject displayInterface)
		{
		}

		[Token(Token = "0x600521C")]
		[Address(RVA = "0xE3CD40", Offset = "0xE3BB40", Length = "0x4")]
		public void SetDirty(bool isDirty)
		{
		}

		[Token(Token = "0x600521D")]
		[Address(RVA = "0xB97C80", Offset = "0xB96A80", Length = "0x5")]
		public bool IsDirty()
		{
			return false;
		}

		[Token(Token = "0x600521E")]
		[Address(RVA = "0xB97C90", Offset = "0xB96A90", Length = "0x5")]
		public void OnEnable()
		{
		}

		[Token(Token = "0x600521F")]
		[Address(RVA = "0xE3CD50", Offset = "0xE3BB50", Length = "0xFD")]
		public void Update(int index, float displayOffset)
		{
		}

		[Token(Token = "0x6005220")]
		[Address(RVA = "0xE3CE50", Offset = "0xE3BC50", Length = "0x16")]
		public void OnRenderCompleted()
		{
		}

		[Token(Token = "0x6005221")]
		[Address(RVA = "0xE3CA00", Offset = "0xE3B800", Length = "0xEB")]
		public void RegisterOnRenderCompletedAction(Action action)
		{
		}

		[Token(Token = "0x6005222")]
		[Address(RVA = "0xE3CAF0", Offset = "0xE3B8F0", Length = "0xEB")]
		public void UnRegisterOnRenderCompletedAction(Action action)
		{
		}

		[Token(Token = "0x6005223")]
		[Address(RVA = "0xE3CE70", Offset = "0xE3BC70", Length = "0x296")]
		private void MaybeUpdateUICamera(int index, float displayOffset)
		{
		}
	}

	[Token(Token = "0x4005DBA")]
	[FieldOffset(Offset = "0x20")]
	private List<RenderTextureManagedCamera> m_RegisteredRenderTextureManagedCamera;

	[Token(Token = "0x4005DBB")]
	[FieldOffset(Offset = "0x28")]
	private float m_DisplayOffsetForRender;

	[Token(Token = "0x4005DBC")]
	[FieldOffset(Offset = "0x2C")]
	private bool m_HasShownRenderWarning;

	[Token(Token = "0x600520E")]
	[Address(RVA = "0xE3B980", Offset = "0xE3A780", Length = "0xEC")]
	private void Deactivate(RenderTextureManagedCamera renderTextureManagedCamera)
	{
	}

	[Token(Token = "0x600520F")]
	[Address(RVA = "0xE3BA70", Offset = "0xE3A870", Length = "0xE9")]
	private void Render(RenderTextureManagedCamera renderTextureManagedCamera)
	{
	}

	[Token(Token = "0x6005210")]
	[Address(RVA = "0xE3BB60", Offset = "0xE3A960", Length = "0x2B9")]
	public void LateUpdate()
	{
	}

	[Token(Token = "0x6005211")]
	[Address(RVA = "0xE3BE20", Offset = "0xE3AC20", Length = "0x223")]
	public void Render()
	{
	}

	[Token(Token = "0x6005212")]
	[Address(RVA = "0xE3C050", Offset = "0xE3AE50", Length = "0x2DF")]
	public void RegisterCamera(Camera camera, GameObject displayInterface)
	{
	}

	[Token(Token = "0x6005213")]
	[Address(RVA = "0xE3C330", Offset = "0xE3B130", Length = "0xFA")]
	public void RegisterOnRenderCompletedAction(Camera camera, GameObject displayInterface, Action onRenderCompletedAction)
	{
	}

	[Token(Token = "0x6005214")]
	[Address(RVA = "0xE3C430", Offset = "0xE3B230", Length = "0xFA")]
	public void UnRegisterOnRenderCompletedAction(Camera camera, GameObject displayInterface, Action onRenderCompletedAction)
	{
	}

	[Token(Token = "0x6005215")]
	[Address(RVA = "0xE3C530", Offset = "0xE3B330", Length = "0x33B")]
	private RenderTextureManagedCamera GetRenderTextureManagedCamera(Camera camera, GameObject displayInterface)
	{
		return null;
	}

	[Token(Token = "0x6005216")]
	[Address(RVA = "0xE3C870", Offset = "0xE3B670", Length = "0x1A")]
	public void SetDirty(Camera camera, GameObject displayInterface)
	{
	}

	[Token(Token = "0x6005217")]
	[Address(RVA = "0xE3C890", Offset = "0xE3B690", Length = "0x7C")]
	public void UnregisterCamera(Camera camera, GameObject displayInterface)
	{
	}

	[Token(Token = "0x6005218")]
	[Address(RVA = "0xE3C910", Offset = "0xE3B710", Length = "0xEB")]
	public RenderTextureCameraManager()
	{
	}
}
