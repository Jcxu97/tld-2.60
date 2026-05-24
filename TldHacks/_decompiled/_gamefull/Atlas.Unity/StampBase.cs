using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

namespace Atlas.Unity;

[AddComponentMenu(null)]
[ExecuteInEditMode]
[Token(Token = "0x2000D30")]
public class StampBase : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000D31")]
	public class StampMap
	{
		[Serializable]
		[Token(Token = "0x2000D32")]
		public class Modifier
		{
			[Token(Token = "0x2000D33")]
			public enum BlendMode
			{
				[Token(Token = "0x4008266")]
				Blend,
				[Token(Token = "0x4008267")]
				Min,
				[Token(Token = "0x4008268")]
				Max,
				[Token(Token = "0x4008269")]
				Add,
				[Token(Token = "0x400826A")]
				Sub
			}

			[Token(Token = "0x2000D34")]
			public enum ModifierType
			{
				[Token(Token = "0x400826C")]
				Height,
				[Token(Token = "0x400826D")]
				Color,
				[Token(Token = "0x400826E")]
				Mask,
				[Token(Token = "0x400826F")]
				Other
			}

			[Token(Token = "0x4008255")]
			[FieldOffset(Offset = "0x10")]
			public ModifierType modifierType;

			[Tooltip("How this layer will blend.\n[Blend]: value will lerp towards the target value.\n[Min]: minimum value will be applied.\n[Max]: maximum value will be applied.\n[Add]: target value will be added.\n[Sub]: target value will be subtracted.")]
			[Token(Token = "0x4008256")]
			[FieldOffset(Offset = "0x14")]
			public BlendMode blendMode;

			[Tooltip("How much the value will be blended towards the target value.")]
			[Range(0f, 1f)]
			[Token(Token = "0x4008257")]
			[FieldOffset(Offset = "0x18")]
			public float blendRatio;

			[Tooltip("This will define how smooth the edge will blend with surroundings; a low value like '0.05' works well here.")]
			[Range(0f, 1f)]
			[Token(Token = "0x4008258")]
			[FieldOffset(Offset = "0x1C")]
			public float edgeBlend;

			[Tooltip("Controls overall opacity.")]
			[Range(0f, 1f)]
			[Token(Token = "0x4008259")]
			[FieldOffset(Offset = "0x20")]
			public float opacity;

			[Tooltip("A higher value results in more steepness.")]
			[Range(0.2f, 5f)]
			[Token(Token = "0x400825A")]
			[FieldOffset(Offset = "0x24")]
			public float power;

			[Tooltip("Erases the edges.")]
			[Range(0f, 1f)]
			[Token(Token = "0x400825B")]
			[FieldOffset(Offset = "0x28")]
			public float edgeErase;

			[Tooltip("Controls overall offset.")]
			[Range(-1f, 1f)]
			[Token(Token = "0x400825C")]
			[FieldOffset(Offset = "0x2C")]
			public float offset;

			[Tooltip("Multiplies the mask value.")]
			[Range(0f, 10f)]
			[Token(Token = "0x400825D")]
			[FieldOffset(Offset = "0x30")]
			public float multiplier;

			[Tooltip("Cuts off minimum value.")]
			[Range(0f, 1f)]
			[Token(Token = "0x400825E")]
			[FieldOffset(Offset = "0x34")]
			public float cutoffMin;

			[Tooltip("Cuts off maximum value.")]
			[Range(0f, 1f)]
			[Token(Token = "0x400825F")]
			[FieldOffset(Offset = "0x38")]
			public float cutoffMax;

			[Tooltip("Inverts the value.")]
			[Token(Token = "0x4008260")]
			[FieldOffset(Offset = "0x3C")]
			public bool invert;

			[Tooltip("Controls brightness value.")]
			[Range(0f, 3f)]
			[Token(Token = "0x4008261")]
			[FieldOffset(Offset = "0x40")]
			public float brightness;

			[Tooltip("Controls contrast value.")]
			[Range(0f, 3f)]
			[Token(Token = "0x4008262")]
			[FieldOffset(Offset = "0x44")]
			public float contrast;

			[Tooltip("Controls saturation value.")]
			[Range(0f, 3f)]
			[Token(Token = "0x4008263")]
			[FieldOffset(Offset = "0x48")]
			public float saturation;

			[Tooltip("Shifts the color.")]
			[Range(0f, 1f)]
			[Token(Token = "0x4008264")]
			[FieldOffset(Offset = "0x4C")]
			public float hue;

			[Token(Token = "0x60067DA")]
			[Address(RVA = "0x10580F0", Offset = "0x1056EF0", Length = "0x40")]
			public Modifier()
			{
			}
		}

		[Token(Token = "0x2000D35")]
		public enum StampTexture
		{
			[Token(Token = "0x4008271")]
			None,
			[Token(Token = "0x4008272")]
			Height,
			[Token(Token = "0x4008273")]
			Color,
			[Token(Token = "0x4008274")]
			Mask,
			[Token(Token = "0x4008275")]
			SplatMask1,
			[Token(Token = "0x4008276")]
			SplatMask2,
			[Token(Token = "0x4008277")]
			SplatMask3,
			[Token(Token = "0x4008278")]
			SplatMask4,
			[Token(Token = "0x4008279")]
			SplatMask5,
			[Token(Token = "0x400827A")]
			SplatMask6,
			[Token(Token = "0x400827B")]
			SplatMask7,
			[Token(Token = "0x400827C")]
			SplatMask8,
			[Token(Token = "0x400827D")]
			RoadMask
		}

		[Token(Token = "0x2000D36")]
		public enum StampMapType
		{
			[Token(Token = "0x400827F")]
			Height,
			[Token(Token = "0x4008280")]
			Color,
			[Token(Token = "0x4008281")]
			Mask,
			[Token(Token = "0x4008282")]
			Other,
			[Token(Token = "0x4008283")]
			RoadMask
		}

		[Token(Token = "0x2000D37")]
		public enum StampTargetType
		{
			[Token(Token = "0x4008285")]
			None,
			[Token(Token = "0x4008286")]
			Height,
			[Token(Token = "0x4008287")]
			Color,
			[Token(Token = "0x4008288")]
			Splat1,
			[Token(Token = "0x4008289")]
			Splat2,
			[Token(Token = "0x400828A")]
			Splat3,
			[Token(Token = "0x400828B")]
			Splat4,
			[Token(Token = "0x400828C")]
			Splat5,
			[Token(Token = "0x400828D")]
			Splat6,
			[Token(Token = "0x400828E")]
			Splat7,
			[Token(Token = "0x400828F")]
			Splat8,
			[Token(Token = "0x4008290")]
			Splat9,
			[Token(Token = "0x4008291")]
			Splat10,
			[Token(Token = "0x4008292")]
			Splat11,
			[Token(Token = "0x4008293")]
			Splat12,
			[Token(Token = "0x4008294")]
			Splat13,
			[Token(Token = "0x4008295")]
			Splat14,
			[Token(Token = "0x4008296")]
			Splat15,
			[Token(Token = "0x4008297")]
			Splat16
		}

		[Token(Token = "0x400824F")]
		[FieldOffset(Offset = "0x10")]
		public StampMapType mapType;

		[Tooltip("Select an input from your stamp asset.")]
		[Token(Token = "0x4008250")]
		[FieldOffset(Offset = "0x14")]
		public StampTexture input;

		[Tooltip("Set the target splatmap to your terrain.")]
		[Token(Token = "0x4008251")]
		[FieldOffset(Offset = "0x18")]
		public StampTargetType target;

		[Token(Token = "0x4008252")]
		[FieldOffset(Offset = "0x20")]
		public Modifier modifier;

		[Token(Token = "0x4008253")]
		[FieldOffset(Offset = "0x28")]
		public bool inspectorInitialized;

		[HideInInspector]
		[Token(Token = "0x4008254")]
		[FieldOffset(Offset = "0x2C")]
		public int selfIndex;

		[Token(Token = "0x60067D4")]
		[Address(RVA = "0x1057390", Offset = "0x1056190", Length = "0x25E")]
		public void ConfigureMaterialForMerge(RenderTexture pre, RenderTexture mask, Material mat, RenderTexture persistantMask = null)
		{
		}

		[Token(Token = "0x60067D5")]
		[Address(RVA = "0x10575F0", Offset = "0x10563F0", Length = "0x6C4")]
		public void ConfigureMaterialForRender(StampAsset stamp, StampBase stampBase, Material mat, float selected = 0f)
		{
		}

		[Token(Token = "0x60067D6")]
		[Address(RVA = "0x1057CE0", Offset = "0x1056AE0", Length = "0xE8")]
		public Texture GetStampTexture(StampAsset stamp, StampBase stampBase)
		{
			return null;
		}

		[Token(Token = "0x60067D7")]
		[Address(RVA = "0x1057F40", Offset = "0x1056D40", Length = "0x38")]
		public int GetStampInputChannelIndex()
		{
			return 0;
		}

		[Token(Token = "0x60067D8")]
		[Address(RVA = "0x1057FA0", Offset = "0x1056DA0", Length = "0x38")]
		public int GetStampTargetChannelIndex()
		{
			return 0;
		}

		[Token(Token = "0x60067D9")]
		[Address(RVA = "0x1058020", Offset = "0x1056E20", Length = "0xC9")]
		public StampMap()
		{
		}
	}

	[Tooltip("Stamp asset.")]
	[Token(Token = "0x4008245")]
	[FieldOffset(Offset = "0x20")]
	public StampAsset stamp;

	[Token(Token = "0x4008246")]
	[FieldOffset(Offset = "0x28")]
	public Texture maskOverride;

	[Tooltip("Mask settings\n\nThe entire stamp will fade based on this mask.")]
	[Token(Token = "0x4008247")]
	[FieldOffset(Offset = "0x30")]
	public StampMap maskMap;

	[Tooltip("Heightmap settings\n\nHow the stamp will alter the height of your terrain.")]
	[Token(Token = "0x4008248")]
	[FieldOffset(Offset = "0x38")]
	public StampMap heightMap;

	[Tooltip("Colormap settings\n\nThe built-in unity terrain doesn't support a global colormap. If you happen to have a shader that supports this you can retrieve the global colormap through the 'AtlasUnityTerrainRenderer' component which is assigned to your terrain.")]
	[Token(Token = "0x4008249")]
	[FieldOffset(Offset = "0x40")]
	public StampMap colorMap;

	[Token(Token = "0x400824A")]
	[FieldOffset(Offset = "0x48")]
	public StampMap roadMaskMap;

	[Tooltip("Splatmap settings\n\nChoose an input from your stamp and write to a target splatmap of your terrain.\n\nAdd multiple layers for intriguing results.")]
	[Token(Token = "0x400824B")]
	[FieldOffset(Offset = "0x50")]
	public List<StampMap> stampMaps;

	[Token(Token = "0x400824C")]
	[FieldOffset(Offset = "0x58")]
	public Vector3 center;

	[Tooltip("Stamp size.")]
	[Token(Token = "0x400824D")]
	[FieldOffset(Offset = "0x64")]
	public Vector3 size;

	[Tooltip("When enabled the stamp will use its 'road mask' to make intersections possible.")]
	[Token(Token = "0x400824E")]
	[FieldOffset(Offset = "0x70")]
	public bool roadBlending;

	[Token(Token = "0x17000726")]
	public float _selected
	{
		[Token(Token = "0x60067C6")]
		[Address(RVA = "0x699F10", Offset = "0x698D10", Length = "0x4")]
		get
		{
			return 0f;
		}
	}

	[Token(Token = "0x60067C7")]
	[Address(RVA = "0x1055010", Offset = "0x1053E10", Length = "0x45")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60067C8")]
	[Address(RVA = "0x1055060", Offset = "0x1053E60", Length = "0x45")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60067C9")]
	[Address(RVA = "0x10550B0", Offset = "0x1053EB0", Length = "0x45")]
	private void OnValidate()
	{
	}

	[Token(Token = "0x60067CA")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x60067CB")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public virtual void DrawGizmos()
	{
	}

	[Token(Token = "0x60067CC")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public virtual void OnBeforeRenderForExport()
	{
	}

	[Token(Token = "0x60067CD")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public virtual void OnAfterRenderForExport()
	{
	}

	[Token(Token = "0x60067CE")]
	[Address(RVA = "0xF1D490", Offset = "0xF1C290", Length = "0x54")]
	public virtual bool MayDrawIcon(out string path)
	{
		path = null;
		return false;
	}

	[Token(Token = "0x60067CF")]
	[Address(RVA = "0x4A2140", Offset = "0x4A0F40", Length = "0x3")]
	public virtual bool MayRender()
	{
		return false;
	}

	[Token(Token = "0x60067D0")]
	[Address(RVA = "0x4A2140", Offset = "0x4A0F40", Length = "0x3")]
	public virtual bool SkipMask()
	{
		return false;
	}

	[Token(Token = "0x60067D1")]
	[Address(RVA = "0x1055100", Offset = "0x1053F00", Length = "0x1B7C")]
	public virtual void Render(AtlasStamper stampTerrainBase)
	{
	}

	[Token(Token = "0x60067D2")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public virtual void DrawMesh(AtlasStamper stampTerrainBase, bool forMask = false)
	{
	}

	[Token(Token = "0x60067D3")]
	[Address(RVA = "0x1056CC0", Offset = "0x1055AC0", Length = "0x6C8")]
	public StampBase()
	{
	}
}
