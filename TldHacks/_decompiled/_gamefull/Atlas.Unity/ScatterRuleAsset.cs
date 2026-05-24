using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

namespace Atlas.Unity;

[CreateAssetMenu(fileName = "ScatterRule", menuName = "Atlas/Unity/Scatter Rule", order = 1)]
[Token(Token = "0x2000D21")]
public class ScatterRuleAsset : ScriptableObject
{
	[Serializable]
	[Token(Token = "0x2000D22")]
	public class ScatterPass
	{
		[HideInInspector]
		[Token(Token = "0x40081E3")]
		[FieldOffset(Offset = "0x10")]
		public int[] treePrototypeIndexes;

		[HideInInspector]
		[Token(Token = "0x40081E4")]
		[FieldOffset(Offset = "0x18")]
		public bool folded;

		[Token(Token = "0x40081E5")]
		[FieldOffset(Offset = "0x20")]
		public GameObject[] prefabs;

		[Token(Token = "0x40081E6")]
		[FieldOffset(Offset = "0x28")]
		public int mode;

		[Tooltip("Radius where other trees will be removed to counter overlap.")]
		[Range(0f, 200f)]
		[Token(Token = "0x40081E7")]
		[FieldOffset(Offset = "0x2C")]
		public float cullRadius;

		[Tooltip("Radius where details will be removed to counter overlap.")]
		[Range(0f, 200f)]
		[Token(Token = "0x40081E8")]
		[FieldOffset(Offset = "0x30")]
		public float detailCullRadius;

		[Range(0f, 200f)]
		[Token(Token = "0x40081E9")]
		[FieldOffset(Offset = "0x34")]
		public float spawnRadius;

		[Tooltip("How many children are spawned within spawnRadius.")]
		[Range(0f, 20f)]
		[Token(Token = "0x40081EA")]
		[FieldOffset(Offset = "0x38")]
		public int childCount;

		[Tooltip("Minimum value of the scale multiplier.")]
		[Range(0.1f, 10f)]
		[Token(Token = "0x40081EB")]
		[FieldOffset(Offset = "0x3C")]
		public float scaleMultiplierMin;

		[Tooltip("Maximum value of the scale multiplier.")]
		[Range(0.1f, 10f)]
		[Token(Token = "0x40081EC")]
		[FieldOffset(Offset = "0x40")]
		public float scaleMultiplierMax;

		[Tooltip("Minimum value of the height scale.")]
		[Range(0.1f, 10f)]
		[Token(Token = "0x40081ED")]
		[FieldOffset(Offset = "0x44")]
		public float heightScaleMin;

		[Tooltip("Maximum value of the height scale.")]
		[Range(0.1f, 10f)]
		[Token(Token = "0x40081EE")]
		[FieldOffset(Offset = "0x48")]
		public float heightScaleMax;

		[Tooltip("Minimum value of the width scale.")]
		[Range(0.1f, 10f)]
		[Token(Token = "0x40081EF")]
		[FieldOffset(Offset = "0x4C")]
		public float widthScaleMin;

		[Tooltip("Maximum value of the width scale.")]
		[Range(0.1f, 10f)]
		[Token(Token = "0x40081F0")]
		[FieldOffset(Offset = "0x50")]
		public float widthScaleMax;

		[Tooltip("Scale multiplier based on distance from parent.")]
		[Range(0.1f, 10f)]
		[Token(Token = "0x40081F1")]
		[FieldOffset(Offset = "0x54")]
		public float distanceScaleMultiplier;

		[Tooltip("How much the prefab will align with the terrain slope.")]
		[Range(0f, 1f)]
		[Token(Token = "0x40081F2")]
		[FieldOffset(Offset = "0x58")]
		public float alignment;

		[Tooltip("Minimum value of the height offset.")]
		[Range(-5f, 5f)]
		[Token(Token = "0x40081F3")]
		[FieldOffset(Offset = "0x5C")]
		public float heightOffsetMin;

		[Tooltip("Maximum value of the width offset.")]
		[Range(-5f, 5f)]
		[Token(Token = "0x40081F4")]
		[FieldOffset(Offset = "0x60")]
		public float heightOffsetMax;

		[Token(Token = "0x40081F5")]
		[FieldOffset(Offset = "0x64")]
		public bool inspectorInitialized;

		[Token(Token = "0x6006795")]
		[Address(RVA = "0x104B2B0", Offset = "0x104A0B0", Length = "0x4E")]
		public ScatterPass()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000D23")]
	public class DetailPass
	{
		[HideInInspector]
		[Token(Token = "0x40081F6")]
		[FieldOffset(Offset = "0x10")]
		public int[] detailPrototypeIndexes;

		[HideInInspector]
		[Token(Token = "0x40081F7")]
		[FieldOffset(Offset = "0x18")]
		public bool folded;

		[Token(Token = "0x40081F8")]
		[FieldOffset(Offset = "0x20")]
		public Texture2D[] textures;

		[Token(Token = "0x40081F9")]
		[FieldOffset(Offset = "0x28")]
		public GameObject[] prefabs;

		[Token(Token = "0x40081FA")]
		[FieldOffset(Offset = "0x30")]
		public bool useMesh;

		[Tooltip("Detail scattering density.")]
		[Range(1f, 100f)]
		[Token(Token = "0x40081FB")]
		[FieldOffset(Offset = "0x34")]
		public int density;

		[Tooltip("Minimum height.")]
		[Range(0.1f, 10f)]
		[Token(Token = "0x40081FC")]
		[FieldOffset(Offset = "0x38")]
		public float minHeight;

		[Tooltip("Maximum height.")]
		[Range(0.1f, 10f)]
		[Token(Token = "0x40081FD")]
		[FieldOffset(Offset = "0x3C")]
		public float maxHeight;

		[Tooltip("Minimum width.")]
		[Range(0.1f, 10f)]
		[Token(Token = "0x40081FE")]
		[FieldOffset(Offset = "0x40")]
		public float minWidth;

		[Tooltip("Maximum width.")]
		[Range(0.1f, 10f)]
		[Token(Token = "0x40081FF")]
		[FieldOffset(Offset = "0x44")]
		public float maxWidth;

		[Tooltip("The distance from terrain holes where no detail will be added.")]
		[Range(0.1f, 10f)]
		[Token(Token = "0x4008200")]
		[FieldOffset(Offset = "0x48")]
		public float holeEdgePadding;

		[Tooltip("Allows you to select a render mode for details.")]
		[Token(Token = "0x4008201")]
		[FieldOffset(Offset = "0x4C")]
		public DetailRenderMode renderMode;

		[Tooltip("Enables instancing on the detail objects.")]
		[Token(Token = "0x4008202")]
		[FieldOffset(Offset = "0x50")]
		public bool useInstancing;

		[Token(Token = "0x4008203")]
		[FieldOffset(Offset = "0x51")]
		public bool inspectorInitialized;

		[Token(Token = "0x6006796")]
		[Address(RVA = "0x104B300", Offset = "0x104A100", Length = "0x2F")]
		public DetailPass()
		{
		}
	}

	[Header("Splatmap")]
	[Tooltip("The target splatmap on which you want to scatter the objects.")]
	[Token(Token = "0x40081D5")]
	[FieldOffset(Offset = "0x18")]
	public StampBase.StampMap.StampTargetType target;

	[Tooltip("The minimum value that the mask should be.")]
	[Range(0f, 1f)]
	[Token(Token = "0x40081D6")]
	[FieldOffset(Offset = "0x1C")]
	public float maskFactorMin;

	[Tooltip("The maximum value that the mask should be.")]
	[Range(0f, 1f)]
	[Token(Token = "0x40081D7")]
	[FieldOffset(Offset = "0x20")]
	public float maskFactorMax;

	[Header("Objects")]
	[Tooltip("Objects won't be placed on objects with this tag name.")]
	[Token(Token = "0x40081D8")]
	[FieldOffset(Offset = "0x28")]
	public string blockTagLayer;

	[Tooltip("When enabled objects will only be placed on colliders with tagName.")]
	[Token(Token = "0x40081D9")]
	[FieldOffset(Offset = "0x30")]
	public bool invertTagLayer;

	[Header("Slope")]
	[Tooltip("Minimum slope value.")]
	[Range(0f, 90f)]
	[Token(Token = "0x40081DA")]
	[FieldOffset(Offset = "0x34")]
	public float slopeMin;

	[Tooltip("Maximum slope value.")]
	[Range(0f, 90f)]
	[Token(Token = "0x40081DB")]
	[FieldOffset(Offset = "0x38")]
	public float slopeMax;

	[Header("Height")]
	[Tooltip("Minimum height value.")]
	[Range(0f, 10000f)]
	[Token(Token = "0x40081DC")]
	[FieldOffset(Offset = "0x3C")]
	public float heightMin;

	[Tooltip("Maximum height value.")]
	[Range(0f, 10000f)]
	[Token(Token = "0x40081DD")]
	[FieldOffset(Offset = "0x40")]
	public float heightMax;

	[Header("Placement")]
	[Range(0.1f, 200f)]
	[Tooltip("Spacing of the first layer of scattering in Unity units.")]
	[Token(Token = "0x40081DE")]
	[FieldOffset(Offset = "0x44")]
	public float spacing;

	[Tooltip("The seed used for generating random values.")]
	[Token(Token = "0x40081DF")]
	[FieldOffset(Offset = "0x48")]
	public int seed;

	[Tooltip("When enabled the scattered objects will cull each other.")]
	[Token(Token = "0x40081E0")]
	[FieldOffset(Offset = "0x4C")]
	public bool selfCulling;

	[Token(Token = "0x40081E1")]
	[FieldOffset(Offset = "0x50")]
	public List<ScatterPass> scatterStack;

	[Token(Token = "0x40081E2")]
	[FieldOffset(Offset = "0x58")]
	public List<DetailPass> detailStack;

	[Token(Token = "0x6006794")]
	[Address(RVA = "0x104B270", Offset = "0x104A070", Length = "0x31")]
	public ScatterRuleAsset()
	{
	}
}
