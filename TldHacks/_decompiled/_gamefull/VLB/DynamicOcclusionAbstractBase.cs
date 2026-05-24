using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Serialization;

namespace VLB;

[AddComponentMenu(null)]
[DisallowMultipleComponent]
[RequireComponent(typeof(VolumetricLightBeam))]
[Token(Token = "0x2000BBE")]
public abstract class DynamicOcclusionAbstractBase : MonoBehaviour
{
	[Token(Token = "0x2000BBF")]
	protected enum ProcessOcclusionSource
	{
		[Token(Token = "0x40078CA")]
		RenderLoop,
		[Token(Token = "0x40078CB")]
		OnEnable,
		[Token(Token = "0x40078CC")]
		EditorUpdate,
		[Token(Token = "0x40078CD")]
		User
	}

	[Token(Token = "0x40078C2")]
	[FieldOffset(Offset = "0x20")]
	public DynamicOcclusionUpdateRate updateRate;

	[FormerlySerializedAs("waitFrameCount")]
	[Token(Token = "0x40078C3")]
	[FieldOffset(Offset = "0x24")]
	public int waitXFrames;

	[Token(Token = "0x40078C5")]
	public static bool _INTERNAL_ApplyRandomFrameOffset;

	[Token(Token = "0x40078C6")]
	[FieldOffset(Offset = "0x30")]
	private TransformUtils.Packed m_TransformPacked;

	[Token(Token = "0x40078C7")]
	[FieldOffset(Offset = "0x38")]
	private int m_LastFrameRendered;

	[Token(Token = "0x40078C8")]
	[FieldOffset(Offset = "0x40")]
	protected VolumetricLightBeam m_Master;

	[Token(Token = "0x170003D2")]
	public int _INTERNAL_LastFrameRendered
	{
		[Token(Token = "0x6005D44")]
		[Address(RVA = "0x502760", Offset = "0x501560", Length = "0x4")]
		get
		{
			return 0;
		}
	}

	[Token(Token = "0x1400001A")]
	public event Action onOcclusionProcessed
	{
		[CompilerGenerated]
		[Token(Token = "0x6005D41")]
		[Address(RVA = "0xF60B80", Offset = "0xF5F980", Length = "0xEB")]
		add
		{
		}
		[CompilerGenerated]
		[Token(Token = "0x6005D42")]
		[Address(RVA = "0xF60C70", Offset = "0xF5FA70", Length = "0xEB")]
		remove
		{
		}
	}

	[Token(Token = "0x6005D40")]
	[Address(RVA = "0xF60B70", Offset = "0xF5F970", Length = "0xC")]
	public void ProcessOcclusionManually()
	{
	}

	[Token(Token = "0x6005D43")]
	[Address(RVA = "0xF60D60", Offset = "0xF5FB60", Length = "0x2B7")]
	protected void ProcessOcclusion(ProcessOcclusionSource source)
	{
	}

	[Token(Token = "0x6005D45")]
	protected abstract string GetShaderKeyword();

	[Token(Token = "0x6005D46")]
	protected abstract MaterialManager.DynamicOcclusion GetDynamicOcclusionMode();

	[Token(Token = "0x6005D47")]
	protected abstract bool OnProcessOcclusion(ProcessOcclusionSource source);

	[Token(Token = "0x6005D48")]
	protected abstract void OnModifyMaterialCallback(MaterialModifier.Interface owner);

	[Token(Token = "0x6005D49")]
	protected abstract void OnEnablePostValidate();

	[Token(Token = "0x6005D4A")]
	[Address(RVA = "0xF61020", Offset = "0xF5FE20", Length = "0x21")]
	protected virtual void OnValidateProperties()
	{
	}

	[Token(Token = "0x6005D4B")]
	[Address(RVA = "0xF61050", Offset = "0xF5FE50", Length = "0xC6")]
	protected virtual void Awake()
	{
	}

	[Token(Token = "0x6005D4C")]
	[Address(RVA = "0xF61120", Offset = "0xF5FF20", Length = "0x50")]
	protected virtual void OnDestroy()
	{
	}

	[Token(Token = "0x6005D4D")]
	[Address(RVA = "0xF61180", Offset = "0xF5FF80", Length = "0x28C")]
	protected virtual void OnEnable()
	{
	}

	[Token(Token = "0x6005D4E")]
	[Address(RVA = "0xF61410", Offset = "0xF60210", Length = "0x17F")]
	protected virtual void OnDisable()
	{
	}

	[Token(Token = "0x6005D4F")]
	[Address(RVA = "0xF61590", Offset = "0xF60390", Length = "0x167")]
	private void OnWillCameraRender(Camera cam)
	{
	}

	[Token(Token = "0x6005D50")]
	[Address(RVA = "0xF61700", Offset = "0xF60500", Length = "0x3D")]
	private void DisableOcclusion()
	{
	}

	[Token(Token = "0x6005D51")]
	[Address(RVA = "0xF61740", Offset = "0xF60540", Length = "0x58")]
	protected DynamicOcclusionAbstractBase()
	{
	}
}
