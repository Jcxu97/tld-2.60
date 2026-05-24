using System;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Serialization;

namespace VLB;

[ExecuteInEditMode]
[HelpURL("http://saladgamer.com/vlb-doc/comp-dynocclusion-raycasting/")]
[Token(Token = "0x2000BC1")]
public class DynamicOcclusionRaycasting : DynamicOcclusionAbstractBase
{
	[Token(Token = "0x2000BC2")]
	public class HitResult
	{
		[Token(Token = "0x40078E1")]
		[FieldOffset(Offset = "0x10")]
		public Vector3 point;

		[Token(Token = "0x40078E2")]
		[FieldOffset(Offset = "0x1C")]
		public Vector3 normal;

		[Token(Token = "0x40078E3")]
		[FieldOffset(Offset = "0x28")]
		public float distance;

		[Token(Token = "0x40078E4")]
		[FieldOffset(Offset = "0x30")]
		private Collider2D collider2D;

		[Token(Token = "0x40078E5")]
		[FieldOffset(Offset = "0x38")]
		private Collider collider3D;

		[Token(Token = "0x170003D8")]
		public bool hasCollider
		{
			[Token(Token = "0x6005D84")]
			[Address(RVA = "0xF65710", Offset = "0xF64510", Length = "0x176")]
			get
			{
				return false;
			}
		}

		[Token(Token = "0x170003D9")]
		public string name
		{
			[Token(Token = "0x6005D85")]
			[Address(RVA = "0xF65890", Offset = "0xF64690", Length = "0x19F")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170003DA")]
		public Bounds bounds
		{
			[Token(Token = "0x6005D86")]
			[Address(RVA = "0xF65A30", Offset = "0xF64830", Length = "0x2F1")]
			get
			{
				return default(Bounds);
			}
		}

		[Token(Token = "0x6005D81")]
		[Address(RVA = "0xF65390", Offset = "0xF64190", Length = "0xF6")]
		public HitResult(RaycastHit hit3D)
		{
		}

		[Token(Token = "0x6005D82")]
		[Address(RVA = "0xF65490", Offset = "0xF64290", Length = "0x126")]
		public HitResult(RaycastHit2D hit2D)
		{
		}

		[Token(Token = "0x6005D83")]
		[Address(RVA = "0xF655C0", Offset = "0xF643C0", Length = "0x141")]
		public HitResult()
		{
		}
	}

	[Token(Token = "0x2000BC3")]
	private enum Direction
	{
		[Token(Token = "0x40078E7")]
		Up = 0,
		[Token(Token = "0x40078E8")]
		Down = 1,
		[Token(Token = "0x40078E9")]
		Left = 2,
		[Token(Token = "0x40078EA")]
		Right = 3,
		[Token(Token = "0x40078EB")]
		Max2D = 1,
		[Token(Token = "0x40078EC")]
		Max3D = 3
	}

	[Token(Token = "0x40078D4")]
	[FieldOffset(Offset = "0x48")]
	public Dimensions dimensions;

	[Token(Token = "0x40078D5")]
	[FieldOffset(Offset = "0x4C")]
	public LayerMask layerMask;

	[Token(Token = "0x40078D6")]
	[FieldOffset(Offset = "0x50")]
	public bool considerTriggers;

	[Token(Token = "0x40078D7")]
	[FieldOffset(Offset = "0x54")]
	public float minOccluderArea;

	[Token(Token = "0x40078D8")]
	[FieldOffset(Offset = "0x58")]
	public float minSurfaceRatio;

	[Token(Token = "0x40078D9")]
	[FieldOffset(Offset = "0x5C")]
	public float maxSurfaceDot;

	[Token(Token = "0x40078DA")]
	[FieldOffset(Offset = "0x60")]
	public PlaneAlignment planeAlignment;

	[Token(Token = "0x40078DB")]
	[FieldOffset(Offset = "0x64")]
	public float planeOffset;

	[FormerlySerializedAs("fadeDistanceToPlane")]
	[Token(Token = "0x40078DC")]
	[FieldOffset(Offset = "0x68")]
	public float fadeDistanceToSurface;

	[Token(Token = "0x40078DE")]
	[FieldOffset(Offset = "0x78")]
	private float m_RangeMultiplier;

	[Token(Token = "0x40078E0")]
	[FieldOffset(Offset = "0x8C")]
	private uint m_PrevNonSubHitDirectionId;

	[Obsolete("Use 'fadeDistanceToSurface' instead")]
	[Token(Token = "0x170003D3")]
	public float fadeDistanceToPlane
	{
		[Token(Token = "0x6005D64")]
		[Address(RVA = "0x502590", Offset = "0x501390", Length = "0x6")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x6005D65")]
		[Address(RVA = "0x5025A0", Offset = "0x5013A0", Length = "0x6")]
		set
		{
		}
	}

	[Token(Token = "0x170003D4")]
	[field: Token(Token = "0x40078DD")]
	[field: FieldOffset(Offset = "0x70")]
	public HitResult currentHit
	{
		[Token(Token = "0x6005D67")]
		[Address(RVA = "0x502690", Offset = "0x501490", Length = "0x5")]
		get;
		[Token(Token = "0x6005D68")]
		[Address(RVA = "0x5026A0", Offset = "0x5014A0", Length = "0x52")]
		private set;
	}

	[Token(Token = "0x170003D5")]
	[field: Token(Token = "0x40078DF")]
	[field: FieldOffset(Offset = "0x7C")]
	public Plane planeEquationWS
	{
		[Token(Token = "0x6005D6B")]
		[Address(RVA = "0xF62D50", Offset = "0xF61B50", Length = "0xB")]
		get;
		[Token(Token = "0x6005D6C")]
		[Address(RVA = "0xF62D60", Offset = "0xF61B60", Length = "0x8")]
		private set;
	}

	[Token(Token = "0x170003D6")]
	private QueryTriggerInteraction queryTriggerInteraction
	{
		[Token(Token = "0x6005D72")]
		[Address(RVA = "0xF63110", Offset = "0xF61F10", Length = "0xB")]
		get
		{
			return default(QueryTriggerInteraction);
		}
	}

	[Token(Token = "0x170003D7")]
	private float raycastMaxDistance
	{
		[Token(Token = "0x6005D73")]
		[Address(RVA = "0xF63120", Offset = "0xF61F20", Length = "0x62")]
		get
		{
			return 0f;
		}
	}

	[Token(Token = "0x6005D66")]
	[Address(RVA = "0xF62AD0", Offset = "0xF618D0", Length = "0x236")]
	public bool IsColliderHiddenByDynamicOccluder(Collider collider)
	{
		return false;
	}

	[Token(Token = "0x6005D69")]
	[Address(RVA = "0xF62D10", Offset = "0xF61B10", Length = "0x31")]
	protected override string GetShaderKeyword()
	{
		return null;
	}

	[Token(Token = "0x6005D6A")]
	[Address(RVA = "0x457110", Offset = "0x455F10", Length = "0x6")]
	protected override MaterialManager.DynamicOcclusion GetDynamicOcclusionMode()
	{
		return default(MaterialManager.DynamicOcclusion);
	}

	[Token(Token = "0x6005D6D")]
	[Address(RVA = "0xF62D70", Offset = "0xF61B70", Length = "0x3C")]
	protected override void OnValidateProperties()
	{
	}

	[Token(Token = "0x6005D6E")]
	[Address(RVA = "0xF62DB0", Offset = "0xF61BB0", Length = "0x52")]
	protected override void OnEnablePostValidate()
	{
	}

	[Token(Token = "0x6005D6F")]
	[Address(RVA = "0xF62E10", Offset = "0xF61C10", Length = "0x22")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x6005D70")]
	[Address(RVA = "0xF62E40", Offset = "0xF61C40", Length = "0x16A")]
	private void Start()
	{
	}

	[Token(Token = "0x6005D71")]
	[Address(RVA = "0xF62FB0", Offset = "0xF61DB0", Length = "0x159")]
	private Vector3 GetRandomVectorAround(Vector3 direction, float angleDiff)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6005D74")]
	[Address(RVA = "0xF63190", Offset = "0xF61F90", Length = "0x74")]
	private HitResult GetBestHit(Vector3 rayPos, Vector3 rayDir)
	{
		return null;
	}

	[Token(Token = "0x6005D75")]
	[Address(RVA = "0xF63210", Offset = "0xF62010", Length = "0x6AF")]
	private HitResult GetBestHit3D(Vector3 rayPos, Vector3 rayDir)
	{
		return null;
	}

	[Token(Token = "0x6005D76")]
	[Address(RVA = "0xF638C0", Offset = "0xF626C0", Length = "0x69B")]
	private HitResult GetBestHit2D(Vector3 rayPos, Vector3 rayDir)
	{
		return null;
	}

	[Token(Token = "0x6005D77")]
	[Address(RVA = "0xF63F60", Offset = "0xF62D60", Length = "0x12")]
	private uint GetDirectionCount()
	{
		return 0u;
	}

	[Token(Token = "0x6005D78")]
	[Address(RVA = "0xF63F80", Offset = "0xF62D80", Length = "0x157")]
	private Vector3 GetDirection(uint dirInt)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6005D79")]
	[Address(RVA = "0xF640E0", Offset = "0xF62EE0", Length = "0x1EA")]
	private bool IsHitValid(HitResult hit, Vector3 forwardVec)
	{
		return false;
	}

	[Token(Token = "0x6005D7A")]
	[Address(RVA = "0xF642D0", Offset = "0xF630D0", Length = "0x8F6")]
	protected override bool OnProcessOcclusion(ProcessOcclusionSource source)
	{
		return false;
	}

	[Token(Token = "0x6005D7B")]
	[Address(RVA = "0xF64BD0", Offset = "0xF639D0", Length = "0x291")]
	private void SetHit(HitResult hit)
	{
	}

	[Token(Token = "0x6005D7C")]
	[Address(RVA = "0xF64E70", Offset = "0xF63C70", Length = "0x151")]
	protected override void OnModifyMaterialCallback(MaterialModifier.Interface owner)
	{
	}

	[Token(Token = "0x6005D7D")]
	[Address(RVA = "0xF64FD0", Offset = "0xF63DD0", Length = "0x269")]
	private void SetClippingPlane(Plane planeWS)
	{
	}

	[Token(Token = "0x6005D7E")]
	[Address(RVA = "0xF65240", Offset = "0xF64040", Length = "0x44")]
	private void SetClippingPlaneOff()
	{
	}

	[Token(Token = "0x6005D7F")]
	[Address(RVA = "0xF62D60", Offset = "0xF61B60", Length = "0x8")]
	private void SetPlaneWS(Plane planeWS)
	{
	}

	[Token(Token = "0x6005D80")]
	[Address(RVA = "0xF65290", Offset = "0xF64090", Length = "0xF5")]
	public DynamicOcclusionRaycasting()
	{
	}
}
