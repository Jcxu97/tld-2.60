using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

namespace TLD.Gear;

[Token(Token = "0x200140C")]
public class FoodMaxStatBuffManager : MonoBehaviour
{
	[SerializeField]
	[Token(Token = "0x4009275")]
	[FieldOffset(Offset = "0x20")]
	private Vector2 m_ConditionMinMax;

	[SerializeField]
	[Token(Token = "0x4009276")]
	[FieldOffset(Offset = "0x28")]
	private Vector2 m_StaminaMinMax;

	[Token(Token = "0x4009279")]
	[FieldOffset(Offset = "0x38")]
	private int m_LongestDebuffIndex;

	[Token(Token = "0x400927A")]
	[FieldOffset(Offset = "0x3C")]
	private int m_LongestBuffIndex;

	[Token(Token = "0x17000AE6")]
	[field: Token(Token = "0x4009277")]
	[field: FieldOffset(Offset = "0x30")]
	public List<FoodMaxStatBuffEffect> ActiveEffects
	{
		[Token(Token = "0x6007FBF")]
		[Address(RVA = "0x457420", Offset = "0x456220", Length = "0x5")]
		get;
		[Token(Token = "0x6007FC0")]
		[Address(RVA = "0x4B1CB0", Offset = "0x4B0AB0", Length = "0x52")]
		set;
	}

	[Token(Token = "0x17000AE7")]
	[field: Token(Token = "0x4009278")]
	public static FoodMaxStatBuffManager Instance
	{
		[Token(Token = "0x6007FC1")]
		[Address(RVA = "0x11FCCB0", Offset = "0x11FBAB0", Length = "0x3B")]
		get;
		[Token(Token = "0x6007FC2")]
		[Address(RVA = "0x11FCCF0", Offset = "0x11FBAF0", Length = "0x97")]
		private set;
	}

	[Token(Token = "0x6007FC3")]
	[Address(RVA = "0x11FCD90", Offset = "0x11FBB90", Length = "0x5")]
	private void Awake()
	{
	}

	[Token(Token = "0x6007FC4")]
	[Address(RVA = "0x11FCDA0", Offset = "0x11FBBA0", Length = "0x7")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6007FC5")]
	[Address(RVA = "0x11FCDB0", Offset = "0x11FBBB0", Length = "0xA1")]
	public void Deserialize(List<FoodMaxStatBuffEffect> serializedEffects)
	{
	}

	[Token(Token = "0x6007FC6")]
	[Address(RVA = "0x11FCE60", Offset = "0x11FBC60", Length = "0x37B")]
	public bool AddStatBuff(FoodMaxStatBuff.StatType stat, float buff, float hoursActive, bool canStack = true)
	{
		return false;
	}

	[Token(Token = "0x6007FC7")]
	[Address(RVA = "0x11FD1E0", Offset = "0x11FBFE0", Length = "0x10A")]
	private void AddStatValue(FoodMaxStatBuff.StatType stat, float statValue)
	{
	}

	[Token(Token = "0x6007FC8")]
	[Address(RVA = "0x11FD2F0", Offset = "0x11FC0F0", Length = "0x2CA")]
	public float GetStatBuff(FoodMaxStatBuff.StatType stat)
	{
		return 0f;
	}

	[Token(Token = "0x6007FC9")]
	[Address(RVA = "0x11FD5C0", Offset = "0x11FC3C0", Length = "0x80")]
	private Vector2 GetMinMax(FoodMaxStatBuff.StatType stat)
	{
		return default(Vector2);
	}

	[Token(Token = "0x6007FCA")]
	[Address(RVA = "0x11FD640", Offset = "0x11FC440", Length = "0x8")]
	public bool HasAnyBuff()
	{
		return false;
	}

	[Token(Token = "0x6007FCB")]
	[Address(RVA = "0x11FD650", Offset = "0x11FC450", Length = "0x8")]
	public bool HasAnyDebuff()
	{
		return false;
	}

	[Token(Token = "0x6007FCC")]
	[Address(RVA = "0x11FD660", Offset = "0x11FC460", Length = "0x80")]
	public float GetBuffTimeLeftHours()
	{
		return 0f;
	}

	[Token(Token = "0x6007FCD")]
	[Address(RVA = "0x11FD6F0", Offset = "0x11FC4F0", Length = "0x80")]
	public float GetDebuffTimeLeftHours()
	{
		return 0f;
	}

	[Token(Token = "0x6007FCE")]
	[Address(RVA = "0x11FD780", Offset = "0x11FC580", Length = "0xA7")]
	public float GetNormalizedBuffDuration()
	{
		return 0f;
	}

	[Token(Token = "0x6007FCF")]
	[Address(RVA = "0x11FD830", Offset = "0x11FC630", Length = "0xA7")]
	public float GetNormalizedDebuffDuration()
	{
		return 0f;
	}

	[Token(Token = "0x6007FD0")]
	[Address(RVA = "0x11FD8E0", Offset = "0x11FC6E0", Length = "0x255")]
	private void Update()
	{
	}

	[Token(Token = "0x6007FD1")]
	[Address(RVA = "0x11FDB40", Offset = "0x11FC940", Length = "0x14B")]
	private void UpdateLongestActiveEffects()
	{
	}

	[Token(Token = "0x6007FD2")]
	[Address(RVA = "0x11FDC90", Offset = "0x11FCA90", Length = "0x50")]
	public void ResetFoodMaxStatBuffs()
	{
	}

	[Token(Token = "0x6007FD3")]
	[Address(RVA = "0x11FDCF0", Offset = "0x11FCAF0", Length = "0xEB")]
	public FoodMaxStatBuffManager()
	{
	}
}
