using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("NGUI/UI/Root")]
[Token(Token = "0x200011E")]
public class UIRoot : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x200011F")]
	public class EmbeddedIcon
	{
		[Token(Token = "0x40008F5")]
		[FieldOffset(Offset = "0x10")]
		public string spriteName;

		[Token(Token = "0x40008F6")]
		[FieldOffset(Offset = "0x18")]
		public UIAtlas atlas;

		[Token(Token = "0x6000A9F")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public EmbeddedIcon()
		{
		}
	}

	[Token(Token = "0x2000120")]
	public enum Scaling
	{
		[Token(Token = "0x40008F8")]
		Flexible,
		[Token(Token = "0x40008F9")]
		Constrained,
		[Token(Token = "0x40008FA")]
		ConstrainedOnMobiles
	}

	[Token(Token = "0x2000121")]
	public enum Constraint
	{
		[Token(Token = "0x40008FC")]
		Fit,
		[Token(Token = "0x40008FD")]
		Fill,
		[Token(Token = "0x40008FE")]
		FitWidth,
		[Token(Token = "0x40008FF")]
		FitHeight
	}

	[HideInInspector]
	[Token(Token = "0x40008E3")]
	[FieldOffset(Offset = "0x20")]
	public bool DO_UI_RESCALING;

	[HideInInspector]
	[Token(Token = "0x40008E4")]
	[FieldOffset(Offset = "0x24")]
	public float m_AspectRatioForScaling;

	[Token(Token = "0x40008E5")]
	[FieldOffset(Offset = "0x28")]
	public List<EmbeddedIcon> m_EmbeddedIcons;

	[HideInInspector]
	[Token(Token = "0x40008E6")]
	[FieldOffset(Offset = "0x30")]
	public float m_AspectRatioOverride;

	[Token(Token = "0x40008E7")]
	public const int DEFAULTPANELDEPTH = 10000;

	[Token(Token = "0x40008E8")]
	public static List<UIRoot> list;

	[HideInInspector]
	[Token(Token = "0x40008E9")]
	[FieldOffset(Offset = "0x34")]
	public Scaling scalingStyle;

	[HideInInspector]
	[Token(Token = "0x40008EA")]
	[FieldOffset(Offset = "0x38")]
	public int manualWidth;

	[HideInInspector]
	[Token(Token = "0x40008EB")]
	[FieldOffset(Offset = "0x3C")]
	public int manualHeight;

	[HideInInspector]
	[Token(Token = "0x40008EC")]
	[FieldOffset(Offset = "0x40")]
	public int minimumHeight;

	[HideInInspector]
	[Token(Token = "0x40008ED")]
	[FieldOffset(Offset = "0x44")]
	public int maximumHeight;

	[HideInInspector]
	[Token(Token = "0x40008EE")]
	[FieldOffset(Offset = "0x48")]
	public bool fitWidth;

	[HideInInspector]
	[Token(Token = "0x40008EF")]
	[FieldOffset(Offset = "0x49")]
	public bool fitHeight;

	[HideInInspector]
	[Token(Token = "0x40008F0")]
	[FieldOffset(Offset = "0x4A")]
	public bool adjustByDPI;

	[HideInInspector]
	[Token(Token = "0x40008F1")]
	[FieldOffset(Offset = "0x4B")]
	public bool shrinkPortraitUI;

	[Token(Token = "0x40008F2")]
	[FieldOffset(Offset = "0x4C")]
	private int manualHeightOriginal;

	[Token(Token = "0x40008F3")]
	[FieldOffset(Offset = "0x50")]
	private Transform mTrans;

	[Token(Token = "0x40008F4")]
	[FieldOffset(Offset = "0x58")]
	private BetterList<UISprite> mDynamicSymbolSpritePool;

	[Token(Token = "0x1700017D")]
	public Constraint constraint
	{
		[Token(Token = "0x6000A8A")]
		[Address(RVA = "0x5C2FC0", Offset = "0x5C1DC0", Length = "0x27")]
		get
		{
			return default(Constraint);
		}
	}

	[Token(Token = "0x1700017E")]
	public Scaling activeScaling
	{
		[Token(Token = "0x6000A8B")]
		[Address(RVA = "0x5C2FF0", Offset = "0x5C1DF0", Length = "0xB")]
		get
		{
			return default(Scaling);
		}
	}

	[Token(Token = "0x1700017F")]
	public int activeHeight
	{
		[Token(Token = "0x6000A8C")]
		[Address(RVA = "0x5C3000", Offset = "0x5C1E00", Length = "0x31F")]
		get
		{
			return 0;
		}
	}

	[Token(Token = "0x17000180")]
	public float pixelSizeAdjustment
	{
		[Token(Token = "0x6000A8D")]
		[Address(RVA = "0x5C3320", Offset = "0x5C2120", Length = "0x137")]
		get
		{
			return 0f;
		}
	}

	[Token(Token = "0x6000A8E")]
	[Address(RVA = "0x5C3460", Offset = "0x5C2260", Length = "0x11D")]
	public static float GetPixelSizeAdjustment(GameObject go)
	{
		return 0f;
	}

	[Token(Token = "0x6000A8F")]
	[Address(RVA = "0x5C3580", Offset = "0x5C2380", Length = "0x59")]
	public float GetPixelSizeAdjustment(int height)
	{
		return 0f;
	}

	[Token(Token = "0x6000A90")]
	[Address(RVA = "0x5C35E0", Offset = "0x5C23E0", Length = "0x274")]
	protected virtual void Awake()
	{
	}

	[Token(Token = "0x6000A91")]
	[Address(RVA = "0x5C3860", Offset = "0x5C2660", Length = "0xBD")]
	protected virtual void OnEnable()
	{
	}

	[Token(Token = "0x6000A92")]
	[Address(RVA = "0x5C3920", Offset = "0x5C2720", Length = "0x82")]
	protected virtual void OnDisable()
	{
	}

	[Token(Token = "0x6000A93")]
	[Address(RVA = "0x5C39B0", Offset = "0x5C27B0", Length = "0x23F")]
	protected virtual void Start()
	{
	}

	[Token(Token = "0x6000A94")]
	[Address(RVA = "0x5C3BF0", Offset = "0x5C29F0", Length = "0xA")]
	private void Update()
	{
	}

	[Token(Token = "0x6000A95")]
	[Address(RVA = "0x5C3C00", Offset = "0x5C2A00", Length = "0x3DB")]
	public void UpdateScale(bool updateAnchors = true)
	{
	}

	[Token(Token = "0x6000A96")]
	[Address(RVA = "0x5C3FE0", Offset = "0x5C2DE0", Length = "0x15")]
	public float GetAspectRatioBonusSize()
	{
		return 0f;
	}

	[Token(Token = "0x6000A97")]
	[Address(RVA = "0x5C4000", Offset = "0x5C2E00", Length = "0x1E3")]
	public static void Broadcast(string funcName)
	{
	}

	[Token(Token = "0x6000A98")]
	[Address(RVA = "0x5C41F0", Offset = "0x5C2FF0", Length = "0x23E")]
	public static void Broadcast(string funcName, object param)
	{
	}

	[Token(Token = "0x6000A99")]
	[Address(RVA = "0x5C4430", Offset = "0x5C3230", Length = "0x189")]
	public UISprite GetDynamicSymbolSpriteFromPool()
	{
		return null;
	}

	[Token(Token = "0x6000A9A")]
	[Address(RVA = "0x5C45C0", Offset = "0x5C33C0", Length = "0x1FF")]
	public void ReturnDynamicSymbolSpriteToPool(UISprite uiSprite)
	{
	}

	[Token(Token = "0x6000A9B")]
	[Address(RVA = "0x5C47C0", Offset = "0x5C35C0", Length = "0xA4")]
	private void InitDynamicSymbolSpritePool()
	{
	}

	[Token(Token = "0x6000A9C")]
	[Address(RVA = "0x5C4870", Offset = "0x5C3670", Length = "0x1E9")]
	private void CreateDynamicSymbolSprite()
	{
	}

	[Token(Token = "0x6000A9D")]
	[Address(RVA = "0x5C4A60", Offset = "0x5C3860", Length = "0xF5")]
	public UIRoot()
	{
	}
}
