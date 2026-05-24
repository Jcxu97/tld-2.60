using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

[Token(Token = "0x2000996")]
public class TLD_AnimationTrack : AnimationTrack, TLD_IDynamicBindableTrack, TLD_ITrack
{
	[Token(Token = "0x2000997")]
	private class RigidBodyInfo
	{
		[Token(Token = "0x400628F")]
		[FieldOffset(Offset = "0x10")]
		private GameObject m_GameObjectOwner;

		[Token(Token = "0x4006290")]
		[FieldOffset(Offset = "0x18")]
		private bool m_IsKinematic;

		[Token(Token = "0x4006291")]
		[FieldOffset(Offset = "0x19")]
		private bool m_UseGravity;

		[Token(Token = "0x4006292")]
		[FieldOffset(Offset = "0x1C")]
		private float m_Mass;

		[Token(Token = "0x4006293")]
		[FieldOffset(Offset = "0x20")]
		private float m_Drag;

		[Token(Token = "0x4006294")]
		[FieldOffset(Offset = "0x24")]
		private float m_AngularDrag;

		[Token(Token = "0x4006295")]
		[FieldOffset(Offset = "0x28")]
		private RigidbodyInterpolation m_Interpolation;

		[Token(Token = "0x4006296")]
		[FieldOffset(Offset = "0x2C")]
		private CollisionDetectionMode m_CollisionDetectionMode;

		[Token(Token = "0x60055A1")]
		[Address(RVA = "0xEA04F0", Offset = "0xE9F2F0", Length = "0x3CC")]
		public void CopyFrom(Rigidbody rb)
		{
		}

		[Token(Token = "0x60055A2")]
		[Address(RVA = "0x49DED0", Offset = "0x49CCD0", Length = "0x5")]
		public GameObject GetOwner()
		{
			return null;
		}

		[Token(Token = "0x60055A3")]
		[Address(RVA = "0xEA08C0", Offset = "0xE9F6C0", Length = "0x8E")]
		public void CopyTo(Rigidbody rb)
		{
		}

		[Token(Token = "0x60055A4")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public RigidBodyInfo()
		{
		}
	}

	[Token(Token = "0x4006289")]
	[FieldOffset(Offset = "0x130")]
	public string m_MissionObjectId;

	[Token(Token = "0x400628A")]
	[FieldOffset(Offset = "0x138")]
	public string m_ChildObjectName;

	[Token(Token = "0x400628B")]
	[FieldOffset(Offset = "0x140")]
	public bool m_DisablePhysics;

	[Token(Token = "0x400628C")]
	[FieldOffset(Offset = "0x148")]
	private Collider[] m_SavedColliders;

	[Token(Token = "0x400628D")]
	[FieldOffset(Offset = "0x150")]
	private List<RigidBodyInfo> m_SavedRigidBodyInfoList;

	[Token(Token = "0x400628E")]
	[FieldOffset(Offset = "0x158")]
	private GameObject m_DynamicBinding;

	[Token(Token = "0x6005598")]
	[Address(RVA = "0xE9FA00", Offset = "0xE9E800", Length = "0x1BD")]
	public void DoDynamicBinding(PlayableDirector director)
	{
	}

	[Token(Token = "0x6005599")]
	[Address(RVA = "0xE9FBC0", Offset = "0xE9E9C0", Length = "0x19")]
	public void Play()
	{
	}

	[Token(Token = "0x600559A")]
	[Address(RVA = "0xE9FBE0", Offset = "0xE9E9E0", Length = "0x19")]
	public void Stop()
	{
	}

	[Token(Token = "0x600559B")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public void UpdatePlay()
	{
	}

	[Token(Token = "0x600559C")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public void LateUpdatePlay()
	{
	}

	[Token(Token = "0x600559D")]
	[Address(RVA = "0xE9FC00", Offset = "0xE9EA00", Length = "0x1C8")]
	private void EnableSavedPhysicColliders(GameObject gameObject, bool isEnabled)
	{
	}

	[Token(Token = "0x600559E")]
	[Address(RVA = "0xE9FDD0", Offset = "0xE9EBD0", Length = "0x3D1")]
	private void SaveAndDisablePhysicComponents(GameObject go)
	{
	}

	[Token(Token = "0x600559F")]
	[Address(RVA = "0xEA01B0", Offset = "0xE9EFB0", Length = "0x24D")]
	private void RestorePhysicComponents(GameObject go)
	{
	}

	[Token(Token = "0x60055A0")]
	[Address(RVA = "0xEA0400", Offset = "0xE9F200", Length = "0xEA")]
	public TLD_AnimationTrack()
	{
	}
}
