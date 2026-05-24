using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

namespace Atlas.Unity;

[Token(Token = "0x2000D24")]
public class SplineStamp : StampBase
{
	[Serializable]
	[Token(Token = "0x2000D25")]
	public struct SplinePoint
	{
		[Token(Token = "0x4008213")]
		[FieldOffset(Offset = "0x0")]
		public Vector3 point;

		[Token(Token = "0x4008214")]
		[FieldOffset(Offset = "0xC")]
		public float scale;

		[Token(Token = "0x60067AB")]
		[Address(RVA = "0x10506E0", Offset = "0x104F4E0", Length = "0x14")]
		public SplinePoint(Vector3 point, float scale)
		{
			this.point = default(Vector3);
			this.scale = 0f;
		}
	}

	[Token(Token = "0x2000D26")]
	public enum SplineQuality
	{
		[Token(Token = "0x4008216")]
		FastPreview,
		[Token(Token = "0x4008217")]
		AccuratePreview,
		[Token(Token = "0x4008218")]
		Export,
		[Token(Token = "0x4008219")]
		Custom
	}

	[Token(Token = "0x2000D27")]
	public enum EditMode
	{
		[Token(Token = "0x400821B")]
		Add,
		[Token(Token = "0x400821C")]
		Move,
		[Token(Token = "0x400821D")]
		Scale
	}

	[Serializable]
	[Token(Token = "0x2000D28")]
	public class SplineQualitySettings
	{
		[Token(Token = "0x400821E")]
		[FieldOffset(Offset = "0x10")]
		public float maxLength;

		[Token(Token = "0x400821F")]
		[FieldOffset(Offset = "0x14")]
		public int maxDistanceBetweenPoints;

		[Token(Token = "0x4008220")]
		[FieldOffset(Offset = "0x18")]
		public int widthSegments;

		[Token(Token = "0x4008221")]
		public static SplineQualitySettings[] splineQualitySettings;

		[Token(Token = "0x60067AC")]
		[Address(RVA = "0x1050700", Offset = "0x104F500", Length = "0x16")]
		public SplineQualitySettings()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000D29")]
	public class SplineToMeshQualitySettings
	{
		[Tooltip("Width of the spline.")]
		[Token(Token = "0x4008222")]
		[FieldOffset(Offset = "0x10")]
		public float width;

		[Tooltip("Preferred distance between vertices along the length.")]
		[Range(0.1f, 100f)]
		[Token(Token = "0x4008223")]
		[FieldOffset(Offset = "0x14")]
		public float maxDistanceBetweenPoints;

		[Tooltip("Maximum vertices count along the length.")]
		[Token(Token = "0x4008224")]
		[FieldOffset(Offset = "0x18")]
		public int maxPoints;

		[Tooltip("Vertex count along the width.")]
		[Range(4f, 21f)]
		[Token(Token = "0x4008225")]
		[FieldOffset(Offset = "0x1C")]
		public int widthSegments;

		[Tooltip("Amount by which UV will tile.")]
		[Token(Token = "0x4008226")]
		[FieldOffset(Offset = "0x20")]
		public float tiling;

		[Tooltip("Starting fade of the spline where a value of 0 means no fading.")]
		[Range(0f, 1f)]
		[Token(Token = "0x4008227")]
		[FieldOffset(Offset = "0x24")]
		public float fadeStart;

		[Tooltip("Ending fade of the spline where a value of 1 means no fading.")]
		[Range(0f, 1f)]
		[Token(Token = "0x4008228")]
		[FieldOffset(Offset = "0x28")]
		public float fadeEnd;

		[Tooltip("How far the edge vertices should be pushed down.")]
		[Token(Token = "0x4008229")]
		[FieldOffset(Offset = "0x2C")]
		public float edgePushDown;

		[Tooltip("How far the middle vertices should be pushed up.")]
		[Token(Token = "0x400822A")]
		[FieldOffset(Offset = "0x30")]
		public float midPushUp;

		[Tooltip("Material of the mesh that will be generated.")]
		[Token(Token = "0x400822B")]
		[FieldOffset(Offset = "0x38")]
		public Material material;

		[Token(Token = "0x60067AE")]
		[Address(RVA = "0x1050900", Offset = "0x104F700", Length = "0x40")]
		public SplineToMeshQualitySettings()
		{
		}
	}

	[Token(Token = "0x2000D2A")]
	public class SplineValue
	{
		[Token(Token = "0x2000D2B")]
		public class SplinePoint
		{
			[Token(Token = "0x400822D")]
			[FieldOffset(Offset = "0x10")]
			public float uv1;

			[Token(Token = "0x400822E")]
			[FieldOffset(Offset = "0x14")]
			public float uv2;

			[Token(Token = "0x400822F")]
			[FieldOffset(Offset = "0x18")]
			public float fadef1;

			[Token(Token = "0x4008230")]
			[FieldOffset(Offset = "0x1C")]
			public float fadef2;

			[Token(Token = "0x4008231")]
			[FieldOffset(Offset = "0x20")]
			public float f1;

			[Token(Token = "0x4008232")]
			[FieldOffset(Offset = "0x24")]
			public float f2;

			[Token(Token = "0x4008233")]
			[FieldOffset(Offset = "0x28")]
			public Vector3 p0f;

			[Token(Token = "0x4008234")]
			[FieldOffset(Offset = "0x34")]
			public Vector3 p1f;

			[Token(Token = "0x4008235")]
			[FieldOffset(Offset = "0x40")]
			public Vector3 p2f;

			[Token(Token = "0x4008236")]
			[FieldOffset(Offset = "0x4C")]
			public Vector3 p3f;

			[Token(Token = "0x4008237")]
			[FieldOffset(Offset = "0x58")]
			public Vector3 p0t;

			[Token(Token = "0x4008238")]
			[FieldOffset(Offset = "0x64")]
			public Vector3 p1t;

			[Token(Token = "0x4008239")]
			[FieldOffset(Offset = "0x70")]
			public Vector3 p2t;

			[Token(Token = "0x400823A")]
			[FieldOffset(Offset = "0x7C")]
			public Vector3 p3t;

			[Token(Token = "0x60067B0")]
			[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
			public SplinePoint()
			{
			}
		}

		[Token(Token = "0x400822C")]
		[FieldOffset(Offset = "0x10")]
		public List<SplinePoint> widthPoints;

		[Token(Token = "0x60067AF")]
		[Address(RVA = "0x1050940", Offset = "0x104F740", Length = "0xAD")]
		public SplineValue()
		{
		}
	}

	[Token(Token = "0x2000D2C")]
	public enum NodeMovementMode
	{
		[Token(Token = "0x400823C")]
		DragGizmo,
		[Token(Token = "0x400823D")]
		TransformationGizmo
	}

	[Tooltip("Width of the spline.")]
	[Token(Token = "0x4008204")]
	[FieldOffset(Offset = "0x78")]
	public float width;

	[Tooltip("How many times the stamp will repeat itself along the spline.")]
	[Token(Token = "0x4008205")]
	[FieldOffset(Offset = "0x7C")]
	public float tiling;

	[Tooltip("Starting fade of the spline where a value of 0 means no fading.")]
	[Range(0f, 1f)]
	[Token(Token = "0x4008206")]
	[FieldOffset(Offset = "0x80")]
	public float fadeStart;

	[Tooltip("Ending fade of the spline where a value of 1 means no fading.")]
	[Range(0f, 1f)]
	[Token(Token = "0x4008207")]
	[FieldOffset(Offset = "0x84")]
	public float fadeEnd;

	[Tooltip("When enabled the spline will be a closed loop.")]
	[Token(Token = "0x4008208")]
	[FieldOffset(Offset = "0x88")]
	public bool closed;

	[Tooltip("Quality of the spline while editing, when we stop editing the terrain maximum quality automatically applies.")]
	[Token(Token = "0x4008209")]
	[FieldOffset(Offset = "0x8C")]
	public SplineQuality quality;

	[Token(Token = "0x400820A")]
	[FieldOffset(Offset = "0x90")]
	public SplineQualitySettings qualitySettings;

	[Token(Token = "0x400820B")]
	[FieldOffset(Offset = "0x98")]
	public SplineToMeshQualitySettings meshExportSettings;

	[Token(Token = "0x400820C")]
	[FieldOffset(Offset = "0xA0")]
	public EditMode editMode;

	[Token(Token = "0x400820D")]
	[FieldOffset(Offset = "0xA8")]
	public List<SplinePoint> points;

	[Token(Token = "0x400820E")]
	[FieldOffset(Offset = "0xB0")]
	private List<SplineValue> splineValues;

	[Token(Token = "0x400820F")]
	[FieldOffset(Offset = "0xB8")]
	private SplineQuality beforeRenderForExportSplineQuality;

	[Token(Token = "0x4008210")]
	[FieldOffset(Offset = "0xBC")]
	private int lastRenderTick;

	[Token(Token = "0x4008211")]
	[FieldOffset(Offset = "0xC0")]
	private AtlasStamper lastRenderBase;

	[Token(Token = "0x4008212")]
	[FieldOffset(Offset = "0xC8")]
	private bool exporting;

	[Token(Token = "0x17000725")]
	private SplineQualitySettings splineQualitySettings
	{
		[Token(Token = "0x6006797")]
		[Address(RVA = "0x104B330", Offset = "0x104A130", Length = "0x11C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6006798")]
	[Address(RVA = "0x104B450", Offset = "0x104A250", Length = "0x8F7")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x6006799")]
	[Address(RVA = "0x104BD50", Offset = "0x104AB50", Length = "0x42D")]
	public void SmoothPointsHeight()
	{
	}

	[Token(Token = "0x600679A")]
	[Address(RVA = "0x104C180", Offset = "0x104AF80", Length = "0x560")]
	public void SmoothPointsLateral()
	{
	}

	[Token(Token = "0x600679B")]
	[Address(RVA = "0x104C6F0", Offset = "0x104B4F0", Length = "0x3D2")]
	public void SmoothScale()
	{
	}

	[Token(Token = "0x600679C")]
	[Address(RVA = "0x104CAD0", Offset = "0x104B8D0", Length = "0x442")]
	public void Subdevide()
	{
	}

	[Token(Token = "0x600679D")]
	[Address(RVA = "0x104CF20", Offset = "0x104BD20", Length = "0xFB")]
	public void UnSubdevide()
	{
	}

	[Token(Token = "0x600679E")]
	[Address(RVA = "0x104D020", Offset = "0x104BE20", Length = "0x5A3")]
	public void DropToFloor()
	{
	}

	[Token(Token = "0x600679F")]
	[Address(RVA = "0x104D5D0", Offset = "0x104C3D0", Length = "0x79")]
	public override bool MayDrawIcon(out string path)
	{
		path = null;
		return false;
	}

	[Token(Token = "0x60067A0")]
	[Address(RVA = "0x104D650", Offset = "0x104C450", Length = "0x1E")]
	public override void OnBeforeRenderForExport()
	{
	}

	[Token(Token = "0x60067A1")]
	[Address(RVA = "0x104D670", Offset = "0x104C470", Length = "0x14")]
	public override void OnAfterRenderForExport()
	{
	}

	[Token(Token = "0x60067A2")]
	[Address(RVA = "0x104D690", Offset = "0x104C490", Length = "0xFB")]
	public override bool MayRender()
	{
		return false;
	}

	[Token(Token = "0x60067A3")]
	[Address(RVA = "0x104D790", Offset = "0x104C590", Length = "0x76A")]
	public override void DrawMesh(AtlasStamper stampTerrainBase, bool forMask = false)
	{
	}

	[ContextMenu("Create Mesh")]
	[Token(Token = "0x60067A4")]
	[Address(RVA = "0x104DF00", Offset = "0x104CD00", Length = "0x14DE")]
	public void CreateMesh()
	{
	}

	[Token(Token = "0x60067A5")]
	[Address(RVA = "0x104F3E0", Offset = "0x104E1E0", Length = "0x192")]
	public void CreateMeshIfCreated()
	{
	}

	[ContextMenu("Clear Mesh")]
	[Token(Token = "0x60067A6")]
	[Address(RVA = "0x104F580", Offset = "0x104E380", Length = "0x1B7")]
	public void ClearMesh()
	{
	}

	[Token(Token = "0x60067A7")]
	[Address(RVA = "0x104F740", Offset = "0x104E540", Length = "0xEAB")]
	public void GetSplineValues(AtlasStamper stampTerrainBase, List<SplinePoint> points, bool closed, SplineQualitySettings splineQualitySettings, out List<SplineValue> splineValues)
	{
		splineValues = null;
	}

	[Token(Token = "0x60067A8")]
	[Address(RVA = "0x10505F0", Offset = "0x104F3F0", Length = "0x8")]
	public float CalcUV(float f, float tiling)
	{
		return 0f;
	}

	[Token(Token = "0x60067A9")]
	[Address(RVA = "0x1050600", Offset = "0x104F400", Length = "0xAB")]
	public float CalcFade(bool closed, float fadeStart, float fadeEnd, float f)
	{
		return 0f;
	}

	[Token(Token = "0x60067AA")]
	[Address(RVA = "0x10506B0", Offset = "0x104F4B0", Length = "0x29")]
	public SplineStamp()
	{
	}
}
