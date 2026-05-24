using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000893")]
public class FirstPersonWeapon : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000894")]
	public class FXInfo
	{
		[Token(Token = "0x400587A")]
		[FieldOffset(Offset = "0x10")]
		public string m_Name;

		[Token(Token = "0x400587B")]
		[FieldOffset(Offset = "0x18")]
		public GameObject m_GameObject;

		[Token(Token = "0x6004E52")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public FXInfo()
		{
		}
	}

	[Token(Token = "0x4005870")]
	[FieldOffset(Offset = "0x20")]
	public Animator m_Animator;

	[Token(Token = "0x4005871")]
	[FieldOffset(Offset = "0x28")]
	public FirstPersonLightSource m_LightSource;

	[Token(Token = "0x4005872")]
	[FieldOffset(Offset = "0x30")]
	public GameObject m_Renderable;

	[Token(Token = "0x4005873")]
	[FieldOffset(Offset = "0x38")]
	public GameObject m_BulletEmissionPoint;

	[Token(Token = "0x4005874")]
	[FieldOffset(Offset = "0x40")]
	public Transform m_FrontSight;

	[Token(Token = "0x4005875")]
	[FieldOffset(Offset = "0x48")]
	public Transform m_RearSight;

	[Token(Token = "0x4005876")]
	[FieldOffset(Offset = "0x50")]
	public GameObject m_ReloadBulletPrefab;

	[Tooltip("Bullets are hidden and then shown in the order set in this list")]
	[Token(Token = "0x4005877")]
	[FieldOffset(Offset = "0x58")]
	public Renderer[] m_BulletsToReload;

	[Token(Token = "0x4005878")]
	[FieldOffset(Offset = "0x60")]
	public List<FXInfo> m_FXInfos;

	[Token(Token = "0x4005879")]
	[FieldOffset(Offset = "0x68")]
	private GameObject m_ReloadBulletInstance;

	[Token(Token = "0x6004E4A")]
	[Address(RVA = "0xDA2E60", Offset = "0xDA1C60", Length = "0x219")]
	private void ResetFX()
	{
	}

	[Token(Token = "0x6004E4B")]
	[Address(RVA = "0xDA3080", Offset = "0xDA1E80", Length = "0x25B")]
	public void EnableRenderable(bool enabled)
	{
	}

	[Token(Token = "0x6004E4C")]
	[Address(RVA = "0xDA32E0", Offset = "0xDA20E0", Length = "0x4F0")]
	public void SpawnReloadBulletPrefab(Transform parent)
	{
	}

	[Token(Token = "0x6004E4D")]
	[Address(RVA = "0xDA37E0", Offset = "0xDA25E0", Length = "0x216")]
	public bool TryGetFXObject(string name, out GameObject fxGameObject)
	{
		fxGameObject = null;
		return false;
	}

	[Token(Token = "0x6004E4E")]
	[Address(RVA = "0xDA3A00", Offset = "0xDA2800", Length = "0x12B")]
	public void UpdateBulletsForReload(int numToShow)
	{
	}

	[Token(Token = "0x6004E4F")]
	[Address(RVA = "0xDA3B30", Offset = "0xDA2930", Length = "0x13B")]
	public void ShowNextLoadedBullet()
	{
	}

	[Token(Token = "0x6004E50")]
	[Address(RVA = "0xDA3C70", Offset = "0xDA2A70", Length = "0xF1")]
	public void EnableReloadBulletInstance(bool enable)
	{
	}

	[Token(Token = "0x6004E51")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public FirstPersonWeapon()
	{
	}
}
