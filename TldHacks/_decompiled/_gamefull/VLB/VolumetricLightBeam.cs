using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Serialization;

namespace VLB;

[ExecuteInEditMode]
[DisallowMultipleComponent]
[SelectionBase]
[HelpURL("http://saladgamer.com/vlb-doc/comp-lightbeam/")]
[Token(Token = "0x2000BF1")]
public class VolumetricLightBeam : MonoBehaviour
{
	[Token(Token = "0x2000BF2")]
	public delegate void OnWillCameraRenderCB(Camera cam);

	[Token(Token = "0x2000BF3")]
	public delegate void OnBeamGeometryInitialized();

	[CompilerGenerated]
	[Token(Token = "0x2000BF4")]
	private sealed class _003CCoPlaytimeUpdate_003Ed__184 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40079EE")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40079EF")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40079F0")]
		[FieldOffset(Offset = "0x20")]
		public VolumetricLightBeam _003C_003E4__this;

		[Token(Token = "0x1700041F")]
		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			[Token(Token = "0x6005E6C")]
			[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000420")]
		object IEnumerator.Current
		{
			[DebuggerHidden]
			[Token(Token = "0x6005E6E")]
			[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		[Token(Token = "0x6005E69")]
		[Address(RVA = "0x4096E0", Offset = "0x4084E0", Length = "0x4")]
		public _003CCoPlaytimeUpdate_003Ed__184(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[Token(Token = "0x6005E6A")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		void IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6005E6B")]
		[Address(RVA = "0xF74170", Offset = "0xF72F70", Length = "0x13B")]
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
		[Token(Token = "0x6005E6D")]
		[Address(RVA = "0xF742B0", Offset = "0xF730B0", Length = "0x3E")]
		void IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40079BB")]
	[FieldOffset(Offset = "0x20")]
	public bool colorFromLight;

	[Token(Token = "0x40079BC")]
	[FieldOffset(Offset = "0x24")]
	public ColorMode colorMode;

	[ColorUsage(false, true)]
	[FormerlySerializedAs("colorValue")]
	[Token(Token = "0x40079BD")]
	[FieldOffset(Offset = "0x28")]
	public Color color;

	[Token(Token = "0x40079BE")]
	[FieldOffset(Offset = "0x38")]
	public Gradient colorGradient;

	[Token(Token = "0x40079BF")]
	[FieldOffset(Offset = "0x40")]
	public bool intensityFromLight;

	[Token(Token = "0x40079C0")]
	[FieldOffset(Offset = "0x41")]
	public bool intensityModeAdvanced;

	[FormerlySerializedAs("alphaInside")]
	[Range(0f, 8f)]
	[Token(Token = "0x40079C1")]
	[FieldOffset(Offset = "0x44")]
	public float intensityInside;

	[FormerlySerializedAs("alphaOutside")]
	[FormerlySerializedAs("alpha")]
	[Range(0f, 8f)]
	[Token(Token = "0x40079C2")]
	[FieldOffset(Offset = "0x48")]
	public float intensityOutside;

	[Token(Token = "0x40079C3")]
	[FieldOffset(Offset = "0x4C")]
	public BlendingMode blendingMode;

	[FormerlySerializedAs("angleFromLight")]
	[Token(Token = "0x40079C4")]
	[FieldOffset(Offset = "0x50")]
	public bool spotAngleFromLight;

	[Range(0.1f, 179.9f)]
	[Token(Token = "0x40079C5")]
	[FieldOffset(Offset = "0x54")]
	public float spotAngle;

	[FormerlySerializedAs("radiusStart")]
	[Token(Token = "0x40079C6")]
	[FieldOffset(Offset = "0x58")]
	public float coneRadiusStart;

	[Token(Token = "0x40079C7")]
	[FieldOffset(Offset = "0x5C")]
	public ShaderAccuracy shaderAccuracy;

	[Token(Token = "0x40079C8")]
	[FieldOffset(Offset = "0x60")]
	public MeshType geomMeshType;

	[FormerlySerializedAs("geomSides")]
	[Token(Token = "0x40079C9")]
	[FieldOffset(Offset = "0x64")]
	public int geomCustomSides;

	[Token(Token = "0x40079CA")]
	[FieldOffset(Offset = "0x68")]
	public int geomCustomSegments;

	[Token(Token = "0x40079CB")]
	[FieldOffset(Offset = "0x6C")]
	public Vector3 skewingLocalForwardDirection;

	[Token(Token = "0x40079CC")]
	[FieldOffset(Offset = "0x78")]
	public Transform clippingPlaneTransform;

	[Token(Token = "0x40079CD")]
	[FieldOffset(Offset = "0x80")]
	public bool geomCap;

	[FormerlySerializedAs("fadeEndFromLight")]
	[Token(Token = "0x40079CE")]
	[FieldOffset(Offset = "0x81")]
	public bool fallOffEndFromLight;

	[Token(Token = "0x40079CF")]
	[FieldOffset(Offset = "0x84")]
	public AttenuationEquation attenuationEquation;

	[Range(0f, 1f)]
	[Token(Token = "0x40079D0")]
	[FieldOffset(Offset = "0x88")]
	public float attenuationCustomBlending;

	[FormerlySerializedAs("fadeStart")]
	[Token(Token = "0x40079D1")]
	[FieldOffset(Offset = "0x8C")]
	public float fallOffStart;

	[FormerlySerializedAs("fadeEnd")]
	[Token(Token = "0x40079D2")]
	[FieldOffset(Offset = "0x90")]
	public float fallOffEnd;

	[Token(Token = "0x40079D3")]
	[FieldOffset(Offset = "0x94")]
	public float depthBlendDistance;

	[Token(Token = "0x40079D4")]
	[FieldOffset(Offset = "0x98")]
	public float cameraClippingDistance;

	[Range(0f, 1f)]
	[Token(Token = "0x40079D5")]
	[FieldOffset(Offset = "0x9C")]
	public float glareFrontal;

	[Range(0f, 1f)]
	[Token(Token = "0x40079D6")]
	[FieldOffset(Offset = "0xA0")]
	public float glareBehind;

	[FormerlySerializedAs("fresnelPowOutside")]
	[Token(Token = "0x40079D7")]
	[FieldOffset(Offset = "0xA4")]
	public float fresnelPow;

	[Token(Token = "0x40079D8")]
	[FieldOffset(Offset = "0xA8")]
	public NoiseMode noiseMode;

	[Range(0f, 1f)]
	[Token(Token = "0x40079D9")]
	[FieldOffset(Offset = "0xAC")]
	public float noiseIntensity;

	[Token(Token = "0x40079DA")]
	[FieldOffset(Offset = "0xB0")]
	public bool noiseScaleUseGlobal;

	[Range(0.01f, 2f)]
	[Token(Token = "0x40079DB")]
	[FieldOffset(Offset = "0xB4")]
	public float noiseScaleLocal;

	[Token(Token = "0x40079DC")]
	[FieldOffset(Offset = "0xB8")]
	public bool noiseVelocityUseGlobal;

	[Token(Token = "0x40079DD")]
	[FieldOffset(Offset = "0xBC")]
	public Vector3 noiseVelocityLocal;

	[Token(Token = "0x40079DE")]
	[FieldOffset(Offset = "0xC8")]
	public Dimensions dimensions;

	[Token(Token = "0x40079DF")]
	[FieldOffset(Offset = "0xCC")]
	public Vector2 tiltFactor;

	[Token(Token = "0x40079E0")]
	[FieldOffset(Offset = "0xD4")]
	private MaterialManager.DynamicOcclusion m_INTERNAL_DynamicOcclusionMode;

	[Token(Token = "0x40079E1")]
	[FieldOffset(Offset = "0xD8")]
	private bool m_INTERNAL_DynamicOcclusionMode_Runtime;

	[Token(Token = "0x40079E3")]
	[FieldOffset(Offset = "0xE8")]
	private OnBeamGeometryInitialized m_OnBeamGeometryInitialized;

	[SerializeField]
	[Token(Token = "0x40079E4")]
	[FieldOffset(Offset = "0xF0")]
	private int pluginVersion;

	[FormerlySerializedAs("trackChangesDuringPlaytime")]
	[SerializeField]
	[Token(Token = "0x40079E5")]
	[FieldOffset(Offset = "0xF4")]
	private bool _TrackChangesDuringPlaytime;

	[SerializeField]
	[Token(Token = "0x40079E6")]
	[FieldOffset(Offset = "0xF8")]
	private int _SortingLayerID;

	[SerializeField]
	[Token(Token = "0x40079E7")]
	[FieldOffset(Offset = "0xFC")]
	private int _SortingOrder;

	[FormerlySerializedAs("fadeOutBegin")]
	[SerializeField]
	[Token(Token = "0x40079E8")]
	[FieldOffset(Offset = "0x100")]
	private float _FadeOutBegin;

	[FormerlySerializedAs("fadeOutEnd")]
	[SerializeField]
	[Token(Token = "0x40079E9")]
	[FieldOffset(Offset = "0x104")]
	private float _FadeOutEnd;

	[Token(Token = "0x40079EB")]
	[FieldOffset(Offset = "0x110")]
	private BeamGeometry m_BeamGeom;

	[Token(Token = "0x40079EC")]
	[FieldOffset(Offset = "0x118")]
	private Coroutine m_CoPlaytimeUpdate;

	[Token(Token = "0x40079ED")]
	[FieldOffset(Offset = "0x120")]
	private Light _CachedLight;

	[Token(Token = "0x170003EF")]
	public ColorMode usedColorMode
	{
		[Token(Token = "0x6005E06")]
		[Address(RVA = "0xF6FE90", Offset = "0xF6EC90", Length = "0x33")]
		get
		{
			return default(ColorMode);
		}
	}

	[Obsolete("Use 'intensityGlobal' or 'intensityInside' instead")]
	[Token(Token = "0x170003F0")]
	public float alphaInside
	{
		[Token(Token = "0x6005E07")]
		[Address(RVA = "0x509B50", Offset = "0x508950", Length = "0x6")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6005E08")]
		[Address(RVA = "0xF6FED0", Offset = "0xF6ECD0", Length = "0x6")]
		set
		{
		}
	}

	[Obsolete("Use 'intensityGlobal' or 'intensityOutside' instead")]
	[Token(Token = "0x170003F1")]
	public float alphaOutside
	{
		[Token(Token = "0x6005E09")]
		[Address(RVA = "0x5737C0", Offset = "0x5725C0", Length = "0x6")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6005E0A")]
		[Address(RVA = "0x5737D0", Offset = "0x5725D0", Length = "0x6")]
		set
		{
		}
	}

	[Token(Token = "0x170003F2")]
	public float intensityGlobal
	{
		[Token(Token = "0x6005E0B")]
		[Address(RVA = "0x5737C0", Offset = "0x5725C0", Length = "0x6")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6005E0C")]
		[Address(RVA = "0xF6FEE0", Offset = "0xF6ECE0", Length = "0xB")]
		set
		{
		}
	}

	[Token(Token = "0x170003F3")]
	public float coneAngle
	{
		[Token(Token = "0x6005E0E")]
		[Address(RVA = "0xF6FF60", Offset = "0xF6ED60", Length = "0x7A")]
		get
		{
			return 0f;
		}
	}

	[Token(Token = "0x170003F4")]
	public float coneRadiusEnd
	{
		[Token(Token = "0x6005E0F")]
		[Address(RVA = "0xF6FFE0", Offset = "0xF6EDE0", Length = "0x5E")]
		get
		{
			return 0f;
		}
	}

	[Token(Token = "0x170003F5")]
	public float coneVolume
	{
		[Token(Token = "0x6005E10")]
		[Address(RVA = "0xF70040", Offset = "0xF6EE40", Length = "0x8D")]
		get
		{
			return 0f;
		}
	}

	[Token(Token = "0x170003F6")]
	public float coneApexOffsetZ
	{
		[Token(Token = "0x6005E11")]
		[Address(RVA = "0xF700D0", Offset = "0xF6EED0", Length = "0x9B")]
		get
		{
			return 0f;
		}
	}

	[Token(Token = "0x170003F7")]
	public int geomSides
	{
		[Token(Token = "0x6005E12")]
		[Address(RVA = "0xF70170", Offset = "0xF6EF70", Length = "0x2D")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6005E13")]
		[Address(RVA = "0xF701A0", Offset = "0xF6EFA0", Length = "0x71")]
		set
		{
		}
	}

	[Token(Token = "0x170003F8")]
	public int geomSegments
	{
		[Token(Token = "0x6005E14")]
		[Address(RVA = "0xF70220", Offset = "0xF6F020", Length = "0x2D")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6005E15")]
		[Address(RVA = "0xF70250", Offset = "0xF6F050", Length = "0x71")]
		set
		{
		}
	}

	[Token(Token = "0x170003F9")]
	public Vector3 skewingLocalForwardDirectionNormalized
	{
		[Token(Token = "0x6005E16")]
		[Address(RVA = "0xF702D0", Offset = "0xF6F0D0", Length = "0x174")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x170003FA")]
	public Vector4 additionalClippingPlane
	{
		[Token(Token = "0x6005E17")]
		[Address(RVA = "0xF70450", Offset = "0xF6F250", Length = "0x252")]
		get
		{
			return default(Vector4);
		}
	}

	[Token(Token = "0x170003FB")]
	public bool canHaveMeshSkewing
	{
		[Token(Token = "0x6005E18")]
		[Address(RVA = "0xF706B0", Offset = "0xF6F4B0", Length = "0x8")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x170003FC")]
	public bool hasMeshSkewing
	{
		[Token(Token = "0x6005E19")]
		[Address(RVA = "0xF706C0", Offset = "0xF6F4C0", Length = "0xE0")]
		get
		{
			return false;
		}
	}

	[Obsolete("Use 'fallOffEndFromLight' instead")]
	[Token(Token = "0x170003FD")]
	public bool fadeEndFromLight
	{
		[Token(Token = "0x6005E1A")]
		[Address(RVA = "0x6E2390", Offset = "0x6E1190", Length = "0x8")]
		get
		{
			return false;
		}
		[Token(Token = "0x6005E1B")]
		[Address(RVA = "0x6E2380", Offset = "0x6E1180", Length = "0x7")]
		set
		{
		}
	}

	[Token(Token = "0x170003FE")]
	public float attenuationLerpLinearQuad
	{
		[Token(Token = "0x6005E1C")]
		[Address(RVA = "0xF707B0", Offset = "0xF6F5B0", Length = "0x25")]
		get
		{
			return 0f;
		}
	}

	[Obsolete("Use 'fallOffStart' instead")]
	[Token(Token = "0x170003FF")]
	public float fadeStart
	{
		[Token(Token = "0x6005E1D")]
		[Address(RVA = "0x502360", Offset = "0x501160", Length = "0x9")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6005E1E")]
		[Address(RVA = "0xF707E0", Offset = "0xF6F5E0", Length = "0x9")]
		set
		{
		}
	}

	[Obsolete("Use 'fallOffEnd' instead")]
	[Token(Token = "0x17000400")]
	public float fadeEnd
	{
		[Token(Token = "0x6005E1F")]
		[Address(RVA = "0xF707F0", Offset = "0xF6F5F0", Length = "0x9")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6005E20")]
		[Address(RVA = "0xF70800", Offset = "0xF6F600", Length = "0x9")]
		set
		{
		}
	}

	[Token(Token = "0x17000401")]
	public float maxGeometryDistance
	{
		[Token(Token = "0x6005E21")]
		[Address(RVA = "0xF70810", Offset = "0xF6F610", Length = "0x2D")]
		get
		{
			return 0f;
		}
	}

	[Token(Token = "0x17000402")]
	public bool isNoiseEnabled
	{
		[Token(Token = "0x6005E22")]
		[Address(RVA = "0xF70840", Offset = "0xF6F640", Length = "0xB")]
		get
		{
			return false;
		}
	}

	[Obsolete("Use 'noiseMode' instead")]
	[Token(Token = "0x17000403")]
	public bool noiseEnabled
	{
		[Token(Token = "0x6005E23")]
		[Address(RVA = "0xF70840", Offset = "0xF6F640", Length = "0xB")]
		get
		{
			return false;
		}
		[Token(Token = "0x6005E24")]
		[Address(RVA = "0xF70850", Offset = "0xF6F650", Length = "0x1C")]
		set
		{
		}
	}

	[Token(Token = "0x17000404")]
	public float fadeOutBegin
	{
		[Token(Token = "0x6005E25")]
		[Address(RVA = "0xF70870", Offset = "0xF6F670", Length = "0x9")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6005E26")]
		[Address(RVA = "0xF70880", Offset = "0xF6F680", Length = "0x12")]
		set
		{
		}
	}

	[Token(Token = "0x17000405")]
	public float fadeOutEnd
	{
		[Token(Token = "0x6005E27")]
		[Address(RVA = "0xF708A0", Offset = "0xF6F6A0", Length = "0x9")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6005E28")]
		[Address(RVA = "0xF708B0", Offset = "0xF6F6B0", Length = "0x12")]
		set
		{
		}
	}

	[Token(Token = "0x17000406")]
	public bool isFadeOutEnabled
	{
		[Token(Token = "0x6005E29")]
		[Address(RVA = "0xF708D0", Offset = "0xF6F6D0", Length = "0x22")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x17000407")]
	public bool isTilted
	{
		[Token(Token = "0x6005E2A")]
		[Address(RVA = "0xF70900", Offset = "0xF6F700", Length = "0x7F")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x17000408")]
	public int sortingLayerID
	{
		[Token(Token = "0x6005E2B")]
		[Address(RVA = "0x5027C0", Offset = "0x5015C0", Length = "0x7")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6005E2C")]
		[Address(RVA = "0xF70980", Offset = "0xF6F780", Length = "0x106")]
		set
		{
		}
	}

	[Token(Token = "0x17000409")]
	public string sortingLayerName
	{
		[Token(Token = "0x6005E2D")]
		[Address(RVA = "0xF70A90", Offset = "0xF6F890", Length = "0xD")]
		get
		{
			return null;
		}
		[Token(Token = "0x6005E2E")]
		[Address(RVA = "0xF70AA0", Offset = "0xF6F8A0", Length = "0x113")]
		set
		{
		}
	}

	[Token(Token = "0x1700040A")]
	public int sortingOrder
	{
		[Token(Token = "0x6005E2F")]
		[Address(RVA = "0xF70BC0", Offset = "0xF6F9C0", Length = "0x7")]
		get
		{
			return 0;
		}
		[Token(Token = "0x6005E30")]
		[Address(RVA = "0xF70BD0", Offset = "0xF6F9D0", Length = "0x106")]
		set
		{
		}
	}

	[Token(Token = "0x1700040B")]
	public bool trackChangesDuringPlaytime
	{
		[Token(Token = "0x6005E31")]
		[Address(RVA = "0xF70CE0", Offset = "0xF6FAE0", Length = "0x8")]
		get
		{
			return false;
		}
		[Token(Token = "0x6005E32")]
		[Address(RVA = "0xF70CF0", Offset = "0xF6FAF0", Length = "0xD")]
		set
		{
		}
	}

	[Token(Token = "0x1700040C")]
	public bool isCurrentlyTrackingChanges
	{
		[Token(Token = "0x6005E33")]
		[Address(RVA = "0xF70D00", Offset = "0xF6FB00", Length = "0xC")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x1700040D")]
	public bool hasGeometry
	{
		[Token(Token = "0x6005E34")]
		[Address(RVA = "0xF70D10", Offset = "0xF6FB10", Length = "0xCD")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x1700040E")]
	public Bounds bounds
	{
		[Token(Token = "0x6005E35")]
		[Address(RVA = "0xF70DE0", Offset = "0xF6FBE0", Length = "0x27C")]
		get
		{
			return default(Bounds);
		}
	}

	[Token(Token = "0x1700040F")]
	public int blendingModeAsInt
	{
		[Token(Token = "0x6005E36")]
		[Address(RVA = "0xF71060", Offset = "0xF6FE60", Length = "0x143")]
		get
		{
			return 0;
		}
	}

	[Token(Token = "0x17000410")]
	public Quaternion beamInternalLocalRotation
	{
		[Token(Token = "0x6005E37")]
		[Address(RVA = "0xF711B0", Offset = "0xF6FFB0", Length = "0x14C")]
		get
		{
			return default(Quaternion);
		}
	}

	[Token(Token = "0x17000411")]
	public Vector3 beamLocalForward
	{
		[Token(Token = "0x6005E38")]
		[Address(RVA = "0xF71300", Offset = "0xF70100", Length = "0xA0")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x17000412")]
	public Vector3 lossyScale
	{
		[Token(Token = "0x6005E39")]
		[Address(RVA = "0xF713A0", Offset = "0xF701A0", Length = "0x303")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x17000413")]
	public float raycastDistance
	{
		[Token(Token = "0x6005E3A")]
		[Address(RVA = "0xF716B0", Offset = "0xF704B0", Length = "0xAD")]
		get
		{
			return 0f;
		}
	}

	[Token(Token = "0x17000414")]
	public Vector3 raycastGlobalForward
	{
		[Token(Token = "0x6005E3B")]
		[Address(RVA = "0xF71760", Offset = "0xF70560", Length = "0x1AD")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x17000415")]
	public Vector3 raycastGlobalUp
	{
		[Token(Token = "0x6005E3C")]
		[Address(RVA = "0xF71910", Offset = "0xF70710", Length = "0x98")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x17000416")]
	public Vector3 raycastGlobalRight
	{
		[Token(Token = "0x6005E3D")]
		[Address(RVA = "0xF719B0", Offset = "0xF707B0", Length = "0x98")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x17000417")]
	public MaterialManager.DynamicOcclusion _INTERNAL_DynamicOcclusionMode
	{
		[Token(Token = "0x6005E3E")]
		[Address(RVA = "0xF71A50", Offset = "0xF70850", Length = "0x36")]
		get
		{
			return default(MaterialManager.DynamicOcclusion);
		}
		[Token(Token = "0x6005E3F")]
		[Address(RVA = "0xF71A90", Offset = "0xF70890", Length = "0x7")]
		set
		{
		}
	}

	[Token(Token = "0x17000418")]
	public MaterialManager.DynamicOcclusion _INTERNAL_DynamicOcclusionMode_Runtime
	{
		[Token(Token = "0x6005E40")]
		[Address(RVA = "0xF71AA0", Offset = "0xF708A0", Length = "0x3F")]
		get
		{
			return default(MaterialManager.DynamicOcclusion);
		}
	}

	[Token(Token = "0x17000419")]
	public int _INTERNAL_pluginVersion
	{
		[Token(Token = "0x6005E47")]
		[Address(RVA = "0x5025F0", Offset = "0x5013F0", Length = "0x7")]
		get
		{
			return 0;
		}
	}

	[Token(Token = "0x1700041A")]
	[field: Token(Token = "0x40079EA")]
	[field: FieldOffset(Offset = "0x108")]
	public uint _INTERNAL_InstancedMaterialGroupID
	{
		[Token(Token = "0x6005E4A")]
		[Address(RVA = "0xF723E0", Offset = "0xF711E0", Length = "0x7")]
		get;
		[Token(Token = "0x6005E4B")]
		[Address(RVA = "0xF723F0", Offset = "0xF711F0", Length = "0x7")]
		protected set;
	}

	[Token(Token = "0x1700041B")]
	public string meshStats
	{
		[Token(Token = "0x6005E4C")]
		[Address(RVA = "0xF72400", Offset = "0xF71200", Length = "0x30F")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700041C")]
	public int meshVerticesCount
	{
		[Token(Token = "0x6005E4D")]
		[Address(RVA = "0xF72710", Offset = "0xF71510", Length = "0x1A9")]
		get
		{
			return 0;
		}
	}

	[Token(Token = "0x1700041D")]
	public int meshTrianglesCount
	{
		[Token(Token = "0x6005E4E")]
		[Address(RVA = "0xF728C0", Offset = "0xF716C0", Length = "0x1C1")]
		get
		{
			return 0;
		}
	}

	[Token(Token = "0x1700041E")]
	private Light lightSpotAttached
	{
		[Token(Token = "0x6005E4F")]
		[Address(RVA = "0xF72A90", Offset = "0xF71890", Length = "0x1FE")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1400001B")]
	public event OnWillCameraRenderCB onWillCameraRenderThisBeam
	{
		[CompilerGenerated]
		[Token(Token = "0x6005E42")]
		[Address(RVA = "0xF71D30", Offset = "0xF70B30", Length = "0xEB")]
		add
		{
		}
		[CompilerGenerated]
		[Token(Token = "0x6005E43")]
		[Address(RVA = "0xF71E20", Offset = "0xF70C20", Length = "0xEB")]
		remove
		{
		}
	}

	[Token(Token = "0x6005E0D")]
	[Address(RVA = "0xF6FEF0", Offset = "0xF6ECF0", Length = "0x65")]
	public void GetInsideAndOutsideIntensity(out float inside, out float outside)
	{
		inside = default(float);
		outside = default(float);
	}

	[Token(Token = "0x6005E41")]
	[Address(RVA = "0xF71AE0", Offset = "0xF708E0", Length = "0x246")]
	public void _INTERNAL_SetDynamicOcclusionCallback(string shaderKeyword, MaterialModifier.Callback cb)
	{
	}

	[Token(Token = "0x6005E44")]
	[Address(RVA = "0xF71F10", Offset = "0xF70D10", Length = "0x19")]
	public void _INTERNAL_OnWillCameraRenderThisBeam(Camera cam)
	{
	}

	[Token(Token = "0x6005E45")]
	[Address(RVA = "0xF71F30", Offset = "0xF70D30", Length = "0x1A3")]
	public void RegisterOnBeamGeometryInitializedCallback(OnBeamGeometryInitialized cb)
	{
	}

	[Token(Token = "0x6005E46")]
	[Address(RVA = "0xF720E0", Offset = "0xF70EE0", Length = "0x68")]
	private void CallOnBeamGeometryInitializedCallback()
	{
	}

	[Token(Token = "0x6005E48")]
	[Address(RVA = "0xF72150", Offset = "0xF70F50", Length = "0x164")]
	private void SetFadeOutValue(ref float propToChange, float value)
	{
	}

	[Token(Token = "0x6005E49")]
	[Address(RVA = "0xF722C0", Offset = "0xF710C0", Length = "0x110")]
	private void OnFadeOutStateChanged()
	{
	}

	[Token(Token = "0x6005E50")]
	[Address(RVA = "0xF72C90", Offset = "0xF71A90", Length = "0x100")]
	public float GetInsideBeamFactor(Vector3 posWS)
	{
		return 0f;
	}

	[Token(Token = "0x6005E51")]
	[Address(RVA = "0xF72DA0", Offset = "0xF71BA0", Length = "0x24A")]
	public float GetInsideBeamFactorFromObjectSpacePos(Vector3 posOS)
	{
		return 0f;
	}

	[Obsolete("Use 'GenerateGeometry()' instead")]
	[Token(Token = "0x6005E52")]
	[Address(RVA = "0x5325D0", Offset = "0x5313D0", Length = "0x11")]
	public void Generate()
	{
	}

	[Token(Token = "0x6005E53")]
	[Address(RVA = "0xF72FF0", Offset = "0xF71DF0", Length = "0x410")]
	public virtual void GenerateGeometry()
	{
	}

	[Token(Token = "0x6005E54")]
	[Address(RVA = "0xF73410", Offset = "0xF72210", Length = "0x107")]
	public virtual void UpdateAfterManualPropertyChange()
	{
	}

	[Token(Token = "0x6005E55")]
	[Address(RVA = "0x5325D0", Offset = "0x5313D0", Length = "0x11")]
	private void Start()
	{
	}

	[Token(Token = "0x6005E56")]
	[Address(RVA = "0xF73520", Offset = "0xF72320", Length = "0xFD")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6005E57")]
	[Address(RVA = "0xF73620", Offset = "0xF72420", Length = "0x141")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6005E58")]
	[Address(RVA = "0xF73770", Offset = "0xF72570", Length = "0x153")]
	private void StartPlaytimeUpdateIfNeeded()
	{
	}

	[IteratorStateMachine(typeof(_003CCoPlaytimeUpdate_003Ed__184))]
	[Token(Token = "0x6005E59")]
	[Address(RVA = "0xF738D0", Offset = "0xF726D0", Length = "0x9A")]
	private IEnumerator CoPlaytimeUpdate()
	{
		return null;
	}

	[Token(Token = "0x6005E5A")]
	[Address(RVA = "0xF73970", Offset = "0xF72770", Length = "0x191")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6005E5B")]
	[Address(RVA = "0xF73970", Offset = "0xF72770", Length = "0x191")]
	private void DestroyBeam()
	{
	}

	[Token(Token = "0x6005E5C")]
	[Address(RVA = "0xF73B10", Offset = "0xF72910", Length = "0x1D0")]
	private void AssignPropertiesFromSpotLight(Light lightSpot)
	{
	}

	[Token(Token = "0x6005E5D")]
	[Address(RVA = "0xF73CF0", Offset = "0xF72AF0", Length = "0x1C5")]
	private void ClampProperties()
	{
	}

	[Token(Token = "0x6005E5E")]
	[Address(RVA = "0xF73EC0", Offset = "0xF72CC0", Length = "0x2D")]
	private void ValidateProperties()
	{
	}

	[Token(Token = "0x6005E5F")]
	[Address(RVA = "0xF73EF0", Offset = "0xF72CF0", Length = "0xA6")]
	private void HandleBackwardCompatibility(int serializedVersion, int newVersion)
	{
	}

	[Token(Token = "0x6005E60")]
	[Address(RVA = "0xF73FA0", Offset = "0xF72DA0", Length = "0x1D0")]
	public VolumetricLightBeam()
	{
	}
}
