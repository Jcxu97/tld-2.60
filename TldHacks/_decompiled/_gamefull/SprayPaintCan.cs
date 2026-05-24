using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using TLD.IntBackedUnit;
using TLD.UI.Generics;
using UnityEngine;

[Token(Token = "0x20004D9")]
public class SprayPaintCan : MonoBehaviour
{
	[CompilerGenerated]
	[Token(Token = "0x20004DA")]
	private sealed class _003CReduceHealthForPaint_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4002C54")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4002C55")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4002C56")]
		[FieldOffset(Offset = "0x20")]
		public SprayPaintCan _003C_003E4__this;

		[Token(Token = "0x4002C57")]
		[FieldOffset(Offset = "0x28")]
		private float _003CstartingHealthBeforeReduction_003E5__2;

		[Token(Token = "0x4002C58")]
		[FieldOffset(Offset = "0x2C")]
		private float _003CoverallAmountToReduce_003E5__3;

		[Token(Token = "0x4002C59")]
		[FieldOffset(Offset = "0x30")]
		private float _003CelapsedTime_003E5__4;

		[Token(Token = "0x1700024B")]
		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			[Token(Token = "0x60024EF")]
			[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700024C")]
		object IEnumerator.Current
		{
			[DebuggerHidden]
			[Token(Token = "0x60024F1")]
			[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		[Token(Token = "0x60024EC")]
		[Address(RVA = "0x4096E0", Offset = "0x4084E0", Length = "0x4")]
		public _003CReduceHealthForPaint_003Ed__19(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[Token(Token = "0x60024ED")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		void IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60024EE")]
		[Address(RVA = "0x870440", Offset = "0x86F240", Length = "0x32D")]
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
		[Token(Token = "0x60024F0")]
		[Address(RVA = "0x870770", Offset = "0x86F570", Length = "0x3E")]
		void IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4002C4B")]
	[FieldOffset(Offset = "0x20")]
	public DecalColour m_Colour;

	[Token(Token = "0x4002C4C")]
	private static SprayPaintCanItemSaveDataProxy m_SprayPaintCanSaveDataProxy;

	[SerializeField]
	[Token(Token = "0x4002C4D")]
	[FieldOffset(Offset = "0x28")]
	private PanelReference<Panel_SprayPaint> m_SprayPaint;

	[SerializeField]
	[Token(Token = "0x4002C4E")]
	[FieldOffset(Offset = "0x30")]
	private AnimationCurve m_HealthReductionCurve;

	[SerializeField]
	[Token(Token = "0x4002C4F")]
	[FieldOffset(Offset = "0x38")]
	private float m_AnimationLength;

	[SerializeField]
	[Token(Token = "0x4002C50")]
	[FieldOffset(Offset = "0x3C")]
	private float m_HealthRequiredToPaintDecal;

	[SerializeField]
	[Token(Token = "0x4002C51")]
	[FieldOffset(Offset = "0x40")]
	private ItemWeight m_FullCanLiquidWeightKG;

	[Token(Token = "0x4002C52")]
	[FieldOffset(Offset = "0x48")]
	private bool m_CancelHealthReduction;

	[AutoComponent(ComponentRequirement.Required)]
	[SerializeField]
	[HideInInspector]
	[Token(Token = "0x4002C53")]
	[FieldOffset(Offset = "0x50")]
	private GearItem m_GearItem;

	[Token(Token = "0x60024DF")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	private void OnValidate()
	{
	}

	[Token(Token = "0x60024E0")]
	[Address(RVA = "0x86FD80", Offset = "0x86EB80", Length = "0xDF")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x60024E1")]
	[Address(RVA = "0x86FE60", Offset = "0x86EC60", Length = "0x8C")]
	public void Deserialize(string text)
	{
	}

	[Token(Token = "0x60024E2")]
	[Address(RVA = "0x86FEF0", Offset = "0x86ECF0", Length = "0x85")]
	public void OnWield(bool immediate)
	{
	}

	[Token(Token = "0x60024E3")]
	[Address(RVA = "0x86FF80", Offset = "0x86ED80", Length = "0x57")]
	public void UnwieldBegin()
	{
	}

	[Token(Token = "0x60024E4")]
	[Address(RVA = "0x86FFE0", Offset = "0x86EDE0", Length = "0xAF")]
	public void UnwieldEnd()
	{
	}

	[Token(Token = "0x60024E5")]
	[Address(RVA = "0x870090", Offset = "0x86EE90", Length = "0x26")]
	public bool HasEnoughPaintForSprayDecal()
	{
		return false;
	}

	[Token(Token = "0x60024E6")]
	[Address(RVA = "0x8700C0", Offset = "0x86EEC0", Length = "0xA4")]
	public void OnPlacedown()
	{
	}

	[Token(Token = "0x60024E7")]
	[Address(RVA = "0x5C7330", Offset = "0x5C6130", Length = "0x5")]
	public void CancelPlacedown()
	{
	}

	[Token(Token = "0x60024E8")]
	[Address(RVA = "0x870170", Offset = "0x86EF70", Length = "0x8B")]
	public ItemWeight GetLiquidWeightKG()
	{
		return default(ItemWeight);
	}

	[IteratorStateMachine(typeof(_003CReduceHealthForPaint_003Ed__19))]
	[Token(Token = "0x60024E9")]
	[Address(RVA = "0x870200", Offset = "0x86F000", Length = "0x9A")]
	private IEnumerator ReduceHealthForPaint()
	{
		return null;
	}

	[Token(Token = "0x60024EA")]
	[Address(RVA = "0x8702A0", Offset = "0x86F0A0", Length = "0xE2")]
	public SprayPaintCan()
	{
	}
}
