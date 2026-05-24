using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Rendering;

namespace VLB;

[AddComponentMenu(null)]
[ExecuteInEditMode]
[HelpURL("http://saladgamer.com/vlb-doc/comp-lightbeam/")]
[Token(Token = "0x2000BB8")]
public class BeamGeometry : MonoBehaviour, MaterialModifier.Interface
{
	[CompilerGenerated]
	[Token(Token = "0x2000BB9")]
	private sealed class _003CCoUpdateFadeOut_003Ed__31 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4007850")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4007851")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4007852")]
		[FieldOffset(Offset = "0x20")]
		public BeamGeometry _003C_003E4__this;

		[Token(Token = "0x170003C6")]
		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			[Token(Token = "0x6005D24")]
			[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170003C7")]
		object IEnumerator.Current
		{
			[DebuggerHidden]
			[Token(Token = "0x6005D26")]
			[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		[Token(Token = "0x6005D21")]
		[Address(RVA = "0x4096E0", Offset = "0x4084E0", Length = "0x4")]
		public _003CCoUpdateFadeOut_003Ed__31(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[Token(Token = "0x6005D22")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		void IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6005D23")]
		[Address(RVA = "0xF5F110", Offset = "0xF5DF10", Length = "0x24D")]
		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		[Token(Token = "0x6005D25")]
		[Address(RVA = "0xF5F360", Offset = "0xF5E160", Length = "0x3E")]
		void IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4007845")]
	[FieldOffset(Offset = "0x20")]
	private VolumetricLightBeam m_Master;

	[Token(Token = "0x4007846")]
	[FieldOffset(Offset = "0x28")]
	private Matrix4x4 m_ColorGradientMatrix;

	[Token(Token = "0x4007847")]
	[FieldOffset(Offset = "0x68")]
	private MeshType m_CurrentMeshType;

	[Token(Token = "0x4007848")]
	[FieldOffset(Offset = "0x70")]
	private Material m_CustomMaterial;

	[Token(Token = "0x4007849")]
	[FieldOffset(Offset = "0x78")]
	private MaterialModifier.Callback m_MaterialModifierCallback;

	[Token(Token = "0x400784A")]
	[FieldOffset(Offset = "0x80")]
	private Coroutine m_CoFadeOut;

	[Token(Token = "0x400784B")]
	[FieldOffset(Offset = "0x88")]
	private MaterialManager.StaticProperties m_StaticProperties;

	[Token(Token = "0x400784F")]
	[FieldOffset(Offset = "0xA8")]
	private Camera m_CurrentCameraRenderingSRP;

	[Token(Token = "0x170003BB")]
	[field: Token(Token = "0x400784C")]
	[field: FieldOffset(Offset = "0x90")]
	public MeshRenderer meshRenderer
	{
		[Token(Token = "0x6005CF4")]
		[Address(RVA = "0x40DA00", Offset = "0x40C800", Length = "0x8")]
		get;
		[Token(Token = "0x6005CF5")]
		[Address(RVA = "0x40DA10", Offset = "0x40C810", Length = "0x52")]
		private set;
	}

	[Token(Token = "0x170003BC")]
	[field: Token(Token = "0x400784D")]
	[field: FieldOffset(Offset = "0x98")]
	public MeshFilter meshFilter
	{
		[Token(Token = "0x6005CF6")]
		[Address(RVA = "0x4B3EA0", Offset = "0x4B2CA0", Length = "0x8")]
		get;
		[Token(Token = "0x6005CF7")]
		[Address(RVA = "0x760E50", Offset = "0x75FC50", Length = "0x52")]
		private set;
	}

	[Token(Token = "0x170003BD")]
	[field: Token(Token = "0x400784E")]
	[field: FieldOffset(Offset = "0xA0")]
	public Mesh coneMesh
	{
		[Token(Token = "0x6005CF8")]
		[Address(RVA = "0x40DAB0", Offset = "0x40C8B0", Length = "0x8")]
		get;
		[Token(Token = "0x6005CF9")]
		[Address(RVA = "0x40DAC0", Offset = "0x40C8C0", Length = "0x52")]
		private set;
	}

	[Token(Token = "0x170003BE")]
	public bool visible
	{
		[Token(Token = "0x6005CFA")]
		[Address(RVA = "0xF5A690", Offset = "0xF59490", Length = "0x9C")]
		get
		{
			return false;
		}
		[Token(Token = "0x6005CFB")]
		[Address(RVA = "0xF5A730", Offset = "0xF59530", Length = "0x21")]
		set
		{
		}
	}

	[Token(Token = "0x170003BF")]
	public int sortingLayerID
	{
		[Token(Token = "0x6005CFC")]
		[Address(RVA = "0xF5A760", Offset = "0xF59560", Length = "0x9C")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6005CFD")]
		[Address(RVA = "0xF5A800", Offset = "0xF59600", Length = "0x21")]
		set
		{
		}
	}

	[Token(Token = "0x170003C0")]
	public int sortingOrder
	{
		[Token(Token = "0x6005CFE")]
		[Address(RVA = "0xF5A830", Offset = "0xF59630", Length = "0x9C")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6005CFF")]
		[Address(RVA = "0xF5A8D0", Offset = "0xF596D0", Length = "0x21")]
		set
		{
		}
	}

	[Token(Token = "0x170003C1")]
	public bool _INTERNAL_IsFadeOutCoroutineRunning
	{
		[Token(Token = "0x6005D00")]
		[Address(RVA = "0xF5A900", Offset = "0xF59700", Length = "0xC")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x170003C2")]
	public static bool isCustomRenderPipelineSupported
	{
		[Token(Token = "0x6005D09")]
		[Address(RVA = "0x430B50", Offset = "0x42F950", Length = "0x3")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x170003C3")]
	private bool shouldUseGPUInstancedMaterial
	{
		[Token(Token = "0x6005D0A")]
		[Address(RVA = "0xF5B410", Offset = "0xF5A210", Length = "0xA1")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x170003C4")]
	private bool isNoiseEnabled
	{
		[Token(Token = "0x6005D0F")]
		[Address(RVA = "0xF5C310", Offset = "0xF5B110", Length = "0x3D")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x170003C5")]
	private bool isDepthBlendEnabled
	{
		[Token(Token = "0x6005D10")]
		[Address(RVA = "0xF5C350", Offset = "0xF5B150", Length = "0x41")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x6005D01")]
	[Address(RVA = "0xF5A910", Offset = "0xF59710", Length = "0x23D")]
	private float ComputeFadeOutFactor(Transform camTransform)
	{
		return 0f;
	}

	[IteratorStateMachine(typeof(_003CCoUpdateFadeOut_003Ed__31))]
	[Token(Token = "0x6005D02")]
	[Address(RVA = "0xF5AB50", Offset = "0xF59950", Length = "0x9A")]
	private IEnumerator CoUpdateFadeOut()
	{
		return null;
	}

	[Token(Token = "0x6005D03")]
	[Address(RVA = "0xF5ABF0", Offset = "0xF599F0", Length = "0x123")]
	private void ComputeFadeOutFactor()
	{
	}

	[Token(Token = "0x6005D04")]
	[Address(RVA = "0xF5AD20", Offset = "0xF59B20", Length = "0xC2")]
	private void SetFadeOutFactorProp(float value)
	{
	}

	[Token(Token = "0x6005D05")]
	[Address(RVA = "0xF5ADF0", Offset = "0xF59BF0", Length = "0x266")]
	public void RestartFadeOutCoroutine()
	{
	}

	[Token(Token = "0x6005D06")]
	[Address(RVA = "0xF5B060", Offset = "0xF59E60", Length = "0x12F")]
	private void Start()
	{
	}

	[Token(Token = "0x6005D07")]
	[Address(RVA = "0xF5B190", Offset = "0xF59F90", Length = "0x17C")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6005D08")]
	[Address(RVA = "0xF5B310", Offset = "0xF5A110", Length = "0xFC")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6005D0B")]
	[Address(RVA = "0xF5B4C0", Offset = "0xF5A2C0", Length = "0xC3")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6005D0C")]
	[Address(RVA = "0xF5B590", Offset = "0xF5A390", Length = "0x685")]
	public void Initialize(VolumetricLightBeam master)
	{
	}

	[Token(Token = "0x6005D0D")]
	[Address(RVA = "0xF5BC20", Offset = "0xF5AA20", Length = "0x3C6")]
	public void RegenerateMesh()
	{
	}

	[Token(Token = "0x6005D0E")]
	[Address(RVA = "0xF5BFF0", Offset = "0xF5ADF0", Length = "0x317")]
	private Vector3 ComputeLocalMatrix()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6005D11")]
	[Address(RVA = "0xF5C3A0", Offset = "0xF5B1A0", Length = "0x327")]
	private bool ApplyMaterial()
	{
		return false;
	}

	[Token(Token = "0x6005D12")]
	[Address(RVA = "0xF5C6D0", Offset = "0xF5B4D0", Length = "0x199")]
	public void SetMaterialProp(int nameID, float value)
	{
	}

	[Token(Token = "0x6005D13")]
	[Address(RVA = "0xF5C870", Offset = "0xF5B670", Length = "0x1B0")]
	public void SetMaterialProp(int nameID, Vector4 value)
	{
	}

	[Token(Token = "0x6005D14")]
	[Address(RVA = "0xF5CA30", Offset = "0xF5B830", Length = "0x251")]
	public void SetMaterialProp(int nameID, Color value)
	{
	}

	[Token(Token = "0x6005D15")]
	[Address(RVA = "0xF5CC90", Offset = "0xF5BA90", Length = "0x1E9")]
	public void SetMaterialProp(int nameID, Matrix4x4 value)
	{
	}

	[Token(Token = "0x6005D16")]
	[Address(RVA = "0xF5CE80", Offset = "0xF5BC80", Length = "0x145")]
	public void SetMaterialProp(int nameID, Texture value)
	{
	}

	[Token(Token = "0x6005D17")]
	[Address(RVA = "0xF5CFD0", Offset = "0xF5BDD0", Length = "0x120")]
	private void MaterialChangeStart()
	{
	}

	[Token(Token = "0x6005D18")]
	[Address(RVA = "0xF5D100", Offset = "0xF5BF00", Length = "0x1AC")]
	private void MaterialChangeStop()
	{
	}

	[Token(Token = "0x6005D19")]
	[Address(RVA = "0xF5D2B0", Offset = "0xF5C0B0", Length = "0x176")]
	public void SetDynamicOcclusionCallback(string shaderKeyword, MaterialModifier.Callback cb)
	{
	}

	[Token(Token = "0x6005D1A")]
	[Address(RVA = "0xF5D430", Offset = "0xF5C230", Length = "0xDD0")]
	public void UpdateMaterialAndBounds()
	{
	}

	[Token(Token = "0x6005D1B")]
	[Address(RVA = "0xF5E210", Offset = "0xF5D010", Length = "0x2E6")]
	private void UpdateMatricesPropertiesForGPUInstancingSRP()
	{
	}

	[Token(Token = "0x6005D1C")]
	[Address(RVA = "0xF5E500", Offset = "0xF5D300", Length = "0x52")]
	private void OnBeginCameraRenderingSRP(ScriptableRenderContext context, Camera cam)
	{
	}

	[Token(Token = "0x6005D1D")]
	[Address(RVA = "0xF5E560", Offset = "0xF5D360", Length = "0x1DD")]
	private void OnWillRenderObject()
	{
	}

	[Token(Token = "0x6005D1E")]
	[Address(RVA = "0xF5E740", Offset = "0xF5D540", Length = "0x1A2")]
	private void OnWillCameraRenderThisBeam(Camera cam)
	{
	}

	[Token(Token = "0x6005D1F")]
	[Address(RVA = "0xF5E8F0", Offset = "0xF5D6F0", Length = "0x624")]
	private void UpdateCameraRelatedProperties(Camera cam)
	{
	}

	[Token(Token = "0x6005D20")]
	[Address(RVA = "0xF5EF20", Offset = "0xF5DD20", Length = "0xC2")]
	public BeamGeometry()
	{
	}
}
