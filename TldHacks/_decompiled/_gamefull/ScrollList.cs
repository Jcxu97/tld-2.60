using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Pool;

[Token(Token = "0x2000276")]
public class ScrollList : MonoBehaviour
{
	[Token(Token = "0x2000277")]
	public enum ScaleFactor
	{
		[Token(Token = "0x400169B")]
		Linear,
		[Token(Token = "0x400169C")]
		Exponential
	}

	[Tooltip("The root object requires an NGUI component, at least a UIWidget")]
	[Token(Token = "0x400167D")]
	[FieldOffset(Offset = "0x20")]
	public GameObject m_PrefabObject;

	[Tooltip("The offset for the two items on each side closest to the center item")]
	[Token(Token = "0x400167E")]
	[FieldOffset(Offset = "0x28")]
	public Vector2 m_OffsetOneAway;

	[Tooltip("The offset for each other item behind the center item")]
	[Token(Token = "0x400167F")]
	[FieldOffset(Offset = "0x30")]
	public Vector2 m_OffsetOthers;

	[Tooltip("Number of items visible before the center item")]
	[Token(Token = "0x4001680")]
	[FieldOffset(Offset = "0x38")]
	public int m_NumVisibleBefore;

	[Tooltip("Number of items visible after the center item")]
	[Token(Token = "0x4001681")]
	[FieldOffset(Offset = "0x3C")]
	public int m_NumVisibleAfter;

	[Tooltip("Scaling value of objects behind the center item")]
	[Token(Token = "0x4001682")]
	[FieldOffset(Offset = "0x40")]
	public float m_SizeBehindCenter;

	[Tooltip("Scaling value of objects that are fading in/out of visibility")]
	[Token(Token = "0x4001683")]
	[FieldOffset(Offset = "0x44")]
	public float m_SizeFadeAway;

	[Token(Token = "0x4001684")]
	[FieldOffset(Offset = "0x48")]
	public float m_AlphaScaleValue;

	[Token(Token = "0x4001685")]
	[FieldOffset(Offset = "0x4C")]
	public ScaleFactor m_AlphaScaleFactor;

	[Token(Token = "0x4001686")]
	[FieldOffset(Offset = "0x50")]
	public float m_TweenTime;

	[Token(Token = "0x4001687")]
	[FieldOffset(Offset = "0x54")]
	public UITweener.Method m_TweenMethod;

	[Token(Token = "0x4001688")]
	[FieldOffset(Offset = "0x58")]
	public bool m_AddButtonsToObjects;

	[Token(Token = "0x4001689")]
	[FieldOffset(Offset = "0x60")]
	public GameObject m_CallbackObject;

	[Token(Token = "0x400168A")]
	[FieldOffset(Offset = "0x68")]
	public string m_CallbackMessage;

	[Token(Token = "0x400168B")]
	[FieldOffset(Offset = "0x70")]
	public Vector3 m_ButtonColliderOffset;

	[Token(Token = "0x400168C")]
	[FieldOffset(Offset = "0x7C")]
	public Vector3 m_ButtonColliderSize;

	[Tooltip("Check this if scroll list items won't overlap and thus won't need to worry about depth")]
	[Token(Token = "0x400168D")]
	[FieldOffset(Offset = "0x88")]
	public bool m_IgnoreDepth;

	[Token(Token = "0x400168E")]
	[FieldOffset(Offset = "0x89")]
	public bool m_AddDoubleClick;

	[Token(Token = "0x400168F")]
	[FieldOffset(Offset = "0x90")]
	public List<EventDelegate> m_OnDoubleClick;

	[HideInInspector]
	[Token(Token = "0x4001690")]
	[FieldOffset(Offset = "0x98")]
	public List<GameObject> m_ScrollObjects;

	[Token(Token = "0x4001691")]
	[FieldOffset(Offset = "0xA0")]
	private readonly List<int> m_DepthList;

	[Token(Token = "0x4001692")]
	[FieldOffset(Offset = "0xA8")]
	private int m_SelectedIndex;

	[Token(Token = "0x4001693")]
	[FieldOffset(Offset = "0xAC")]
	private int m_TargetIndex;

	[Token(Token = "0x4001694")]
	[FieldOffset(Offset = "0xB0")]
	private int m_TweenStartIndex;

	[Token(Token = "0x4001695")]
	[FieldOffset(Offset = "0xB4")]
	private Vector3 m_OffsetOthers3D;

	[Token(Token = "0x4001696")]
	[FieldOffset(Offset = "0xC0")]
	private Vector3 m_OffsetOneAway3D;

	[Token(Token = "0x4001697")]
	[FieldOffset(Offset = "0xCC")]
	private float m_TimeLeftOnTween;

	[Token(Token = "0x4001698")]
	[FieldOffset(Offset = "0xD0")]
	private bool m_IsTweening;

	[Token(Token = "0x4001699")]
	[FieldOffset(Offset = "0xD8")]
	private IObjectPool<GameObject> m_ObjectPool;

	[Token(Token = "0x6001584")]
	[Address(RVA = "0x6A28D0", Offset = "0x6A16D0", Length = "0x57")]
	private void Awake()
	{
	}

	[Token(Token = "0x6001585")]
	[Address(RVA = "0x6A2930", Offset = "0x6A1730", Length = "0x112")]
	private void Update()
	{
	}

	[Token(Token = "0x6001586")]
	[Address(RVA = "0x6A2A50", Offset = "0x6A1850", Length = "0x6B")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6001587")]
	[Address(RVA = "0x6A2AC0", Offset = "0x6A18C0", Length = "0x8A")]
	public void Next()
	{
	}

	[Token(Token = "0x6001588")]
	[Address(RVA = "0x6A2B50", Offset = "0x6A1950", Length = "0x8A")]
	public void Prev()
	{
	}

	[Token(Token = "0x6001589")]
	[Address(RVA = "0x6A2BE0", Offset = "0x6A19E0", Length = "0x7")]
	public int GetTweenTargetIndex()
	{
		return 0;
	}

	[Token(Token = "0x600158A")]
	[Address(RVA = "0x6A2BF0", Offset = "0x6A19F0", Length = "0x42")]
	public void SetTargetIndex(int index, bool animate = true)
	{
	}

	[Token(Token = "0x600158B")]
	[Address(RVA = "0x6A2C40", Offset = "0x6A1A40", Length = "0x8")]
	public bool IsTweening()
	{
		return false;
	}

	[Token(Token = "0x600158C")]
	[Address(RVA = "0x6A2C50", Offset = "0x6A1A50", Length = "0x388")]
	public void CreateList(int numObjects)
	{
	}

	[Token(Token = "0x600158D")]
	[Address(RVA = "0x6A2FE0", Offset = "0x6A1DE0", Length = "0x20B")]
	private void MaybeInitializePool()
	{
	}

	[Token(Token = "0x600158E")]
	[Address(RVA = "0x6A31F0", Offset = "0x6A1FF0", Length = "0x74")]
	private void RefreshAll()
	{
	}

	[Token(Token = "0x600158F")]
	[Address(RVA = "0x6A3270", Offset = "0x6A2070", Length = "0x274")]
	private void RefreshPositioning()
	{
	}

	[Token(Token = "0x6001590")]
	[Address(RVA = "0x6A34F0", Offset = "0x6A22F0", Length = "0x16E")]
	private void RefreshAlpha()
	{
	}

	[Token(Token = "0x6001591")]
	[Address(RVA = "0x6A3660", Offset = "0x6A2460", Length = "0x2CF")]
	private void RefreshScale()
	{
	}

	[Token(Token = "0x6001592")]
	[Address(RVA = "0x6A3930", Offset = "0x6A2730", Length = "0x31D")]
	private void RefreshVisibility()
	{
	}

	[Token(Token = "0x6001593")]
	[Address(RVA = "0x6A3C50", Offset = "0x6A2A50", Length = "0x91F")]
	private void DoTweens(bool increasedIndex)
	{
	}

	[Token(Token = "0x6001594")]
	[Address(RVA = "0x6A4570", Offset = "0x6A3370", Length = "0x33A")]
	private void SetObjectDepth(int objIndex, int depth)
	{
	}

	[Token(Token = "0x6001595")]
	[Address(RVA = "0x6A48B0", Offset = "0x6A36B0", Length = "0x1A9")]
	private Vector3 GetPositionForIndex(int index)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6001596")]
	[Address(RVA = "0x6A4A60", Offset = "0x6A3860", Length = "0xC9")]
	private float GetAlphaForIndex(int index)
	{
		return 0f;
	}

	[Token(Token = "0x6001597")]
	[Address(RVA = "0x6A4B30", Offset = "0x6A3930", Length = "0xA2")]
	private Vector3 GetOffsetForIndex(int index, bool increasingIndex)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6001598")]
	[Address(RVA = "0x6A4BE0", Offset = "0x6A39E0", Length = "0x1F0")]
	private void DoScaleTween(int index, Vector3 fromVal, Vector3 toVal, float tweenTime)
	{
	}

	[Token(Token = "0x6001599")]
	[Address(RVA = "0x6A4DE0", Offset = "0x6A3BE0", Length = "0x23A")]
	private void UpdateDurationAllTweens()
	{
	}

	[Token(Token = "0x600159A")]
	[Address(RVA = "0x6A28D0", Offset = "0x6A16D0", Length = "0x57")]
	private void CreateOffsetVectors()
	{
	}

	[Token(Token = "0x600159B")]
	[Address(RVA = "0x6A5020", Offset = "0x6A3E20", Length = "0x180")]
	public void CleanUp()
	{
	}

	[Token(Token = "0x600159C")]
	[Address(RVA = "0x6A51B0", Offset = "0x6A3FB0", Length = "0xC21")]
	private GameObject CreateChild()
	{
		return null;
	}

	[Token(Token = "0x600159D")]
	[Address(RVA = "0x6A5DE0", Offset = "0x6A4BE0", Length = "0x325")]
	private void OnGetChild(GameObject obj)
	{
	}

	[Token(Token = "0x600159E")]
	[Address(RVA = "0x6A6110", Offset = "0x6A4F10", Length = "0x24A")]
	private void OnReleaseChild(GameObject obj)
	{
	}

	[Token(Token = "0x600159F")]
	[Address(RVA = "0x6A6360", Offset = "0x6A5160", Length = "0x21B")]
	private void ResetDepths(GameObject obj, int deltaDepth)
	{
	}

	[Token(Token = "0x60015A0")]
	[Address(RVA = "0x6A6580", Offset = "0x6A5380", Length = "0x88")]
	private void OnDestroyChild(GameObject obj)
	{
	}

	[Token(Token = "0x60015A1")]
	[Address(RVA = "0x6A6610", Offset = "0x6A5410", Length = "0x18F")]
	public ScrollList()
	{
	}
}
