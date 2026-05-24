using System;
using Cpp2ILInjected;
using UnityEngine;

namespace VLB;

[ExecuteInEditMode]
[DisallowMultipleComponent]
[RequireComponent(typeof(VolumetricLightBeam))]
[HelpURL("http://saladgamer.com/vlb-doc/comp-dustparticles/")]
[Token(Token = "0x2000BF0")]
public class VolumetricDustParticles : MonoBehaviour
{
	[Range(0f, 1f)]
	[Token(Token = "0x40079A8")]
	[FieldOffset(Offset = "0x20")]
	public float alpha;

	[Range(0.0001f, 0.1f)]
	[Token(Token = "0x40079A9")]
	[FieldOffset(Offset = "0x24")]
	public float size;

	[Token(Token = "0x40079AA")]
	[FieldOffset(Offset = "0x28")]
	public ParticlesDirection direction;

	[Token(Token = "0x40079AB")]
	[FieldOffset(Offset = "0x2C")]
	public Vector3 velocity;

	[Obsolete("Use 'velocity' instead")]
	[Token(Token = "0x40079AC")]
	[FieldOffset(Offset = "0x38")]
	public float speed;

	[Token(Token = "0x40079AD")]
	[FieldOffset(Offset = "0x3C")]
	public float density;

	[Range(0f, 1f)]
	[Token(Token = "0x40079AE")]
	[FieldOffset(Offset = "0x40")]
	public float spawnMinDistance;

	[Range(0f, 1f)]
	[Token(Token = "0x40079AF")]
	[FieldOffset(Offset = "0x44")]
	public float spawnMaxDistance;

	[Token(Token = "0x40079B0")]
	[FieldOffset(Offset = "0x48")]
	public bool cullingEnabled;

	[Token(Token = "0x40079B1")]
	[FieldOffset(Offset = "0x4C")]
	public float cullingMaxDistance;

	[Token(Token = "0x40079B3")]
	public static bool isFeatureSupported;

	[Token(Token = "0x40079B4")]
	[FieldOffset(Offset = "0x58")]
	private ParticleSystem m_Particles;

	[Token(Token = "0x40079B5")]
	[FieldOffset(Offset = "0x60")]
	private ParticleSystemRenderer m_Renderer;

	[Token(Token = "0x40079B6")]
	private static bool ms_NoMainCameraLogged;

	[Token(Token = "0x40079B7")]
	private static Camera ms_MainCamera;

	[Token(Token = "0x40079B8")]
	[FieldOffset(Offset = "0x68")]
	private float m_CachedAlpha;

	[Token(Token = "0x40079B9")]
	[FieldOffset(Offset = "0x70")]
	private Gradient m_CachedGradient;

	[Token(Token = "0x40079BA")]
	[FieldOffset(Offset = "0x78")]
	private VolumetricLightBeam m_Master;

	[Token(Token = "0x170003EA")]
	[field: Token(Token = "0x40079B2")]
	[field: FieldOffset(Offset = "0x50")]
	public bool isCulled
	{
		[Token(Token = "0x6005DF4")]
		[Address(RVA = "0x6674B0", Offset = "0x6662B0", Length = "0x5")]
		get;
		[Token(Token = "0x6005DF5")]
		[Address(RVA = "0xB854B0", Offset = "0xB842B0", Length = "0x4")]
		private set;
	}

	[Token(Token = "0x170003EB")]
	public bool particlesAreInstantiated
	{
		[Token(Token = "0x6005DF6")]
		[Address(RVA = "0xF6CED0", Offset = "0xF6BCD0", Length = "0xCA")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x170003EC")]
	public int particlesCurrentCount
	{
		[Token(Token = "0x6005DF7")]
		[Address(RVA = "0xF6CFA0", Offset = "0xF6BDA0", Length = "0xEB")]
		get
		{
			return 0;
		}
	}

	[Token(Token = "0x170003ED")]
	public int particlesMaxCount
	{
		[Token(Token = "0x6005DF8")]
		[Address(RVA = "0xF6D090", Offset = "0xF6BE90", Length = "0x18A")]
		get
		{
			return 0;
		}
	}

	[Token(Token = "0x170003EE")]
	public Camera mainCamera
	{
		[Token(Token = "0x6005DF9")]
		[Address(RVA = "0xF6D220", Offset = "0xF6C020", Length = "0x33F")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6005DFA")]
	[Address(RVA = "0xF6D560", Offset = "0xF6C360", Length = "0xF7")]
	private void Start()
	{
	}

	[Token(Token = "0x6005DFB")]
	[Address(RVA = "0xF6D660", Offset = "0xF6C460", Length = "0x778")]
	private void InstantiateParticleSystem()
	{
	}

	[Token(Token = "0x6005DFC")]
	[Address(RVA = "0xF6DDE0", Offset = "0xF6CBE0", Length = "0x7")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6005DFD")]
	[Address(RVA = "0xF6DDF0", Offset = "0xF6CBF0", Length = "0x10E")]
	private void SetActiveAndPlay()
	{
	}

	[Token(Token = "0x6005DFE")]
	[Address(RVA = "0xF6DF00", Offset = "0xF6CD00", Length = "0xF1")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6005DFF")]
	[Address(RVA = "0xF6E000", Offset = "0xF6CE00", Length = "0x191")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6005E00")]
	[Address(RVA = "0xF6E1A0", Offset = "0xF6CFA0", Length = "0x98")]
	private void Update()
	{
	}

	[Token(Token = "0x6005E01")]
	[Address(RVA = "0xF6E240", Offset = "0xF6D040", Length = "0x1550")]
	private void SetParticleProperties()
	{
	}

	[Token(Token = "0x6005E02")]
	[Address(RVA = "0xF6F7A0", Offset = "0xF6E5A0", Length = "0x46")]
	private void HandleBackwardCompatibility(int serializedVersion, int newVersion)
	{
	}

	[Token(Token = "0x6005E03")]
	[Address(RVA = "0xF6F7F0", Offset = "0xF6E5F0", Length = "0x46A")]
	private void UpdateCulling()
	{
	}

	[Token(Token = "0x6005E04")]
	[Address(RVA = "0xF6FC60", Offset = "0xF6EA60", Length = "0x16A")]
	public VolumetricDustParticles()
	{
	}
}
