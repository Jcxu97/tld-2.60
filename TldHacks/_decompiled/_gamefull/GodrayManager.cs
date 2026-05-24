using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20003A8")]
public class GodrayManager : MonoBehaviour
{
	[Token(Token = "0x20003A9")]
	private class GodRayObject
	{
		[Token(Token = "0x40020B5")]
		[FieldOffset(Offset = "0x10")]
		public Transform m_Transform;

		[Token(Token = "0x40020B6")]
		[FieldOffset(Offset = "0x18")]
		public Vector3 m_OriginalPosition;

		[Token(Token = "0x40020B7")]
		[FieldOffset(Offset = "0x24")]
		public float m_Timer;

		[Token(Token = "0x40020B8")]
		[FieldOffset(Offset = "0x28")]
		public float m_TimerMax;

		[Token(Token = "0x40020B9")]
		[FieldOffset(Offset = "0x30")]
		public Renderer m_Renderer;

		[Token(Token = "0x40020BA")]
		[FieldOffset(Offset = "0x38")]
		public GameObject m_GameObject;

		[Token(Token = "0x40020BB")]
		[FieldOffset(Offset = "0x40")]
		private float m_RotationOffset;

		[Token(Token = "0x40020BC")]
		[FieldOffset(Offset = "0x44")]
		private float m_RotationSpeed;

		[Token(Token = "0x6001CFD")]
		[Address(RVA = "0x790DD0", Offset = "0x78FBD0", Length = "0x23B")]
		public GodRayObject(Transform thisTransform, GameObject go)
		{
		}

		[Token(Token = "0x6001CFE")]
		[Address(RVA = "0x791010", Offset = "0x78FE10", Length = "0x41A")]
		private void NewRay(GodrayManager manager)
		{
		}

		[Token(Token = "0x6001CFF")]
		[Address(RVA = "0x791430", Offset = "0x790230", Length = "0x860")]
		public void Update(GodrayManager manager, Quaternion sunRotation, Color rayColor, Vector3 playerPosition)
		{
		}
	}

	[Token(Token = "0x40020A3")]
	[FieldOffset(Offset = "0x20")]
	public bool m_RequireTrigger;

	[SerializeField]
	[Token(Token = "0x40020A4")]
	[FieldOffset(Offset = "0x28")]
	private MinMax m_CycleSpeedSeconds;

	[SerializeField]
	[Token(Token = "0x40020A5")]
	[FieldOffset(Offset = "0x30")]
	private MinMax m_RotationSpeed;

	[SerializeField]
	[Token(Token = "0x40020A6")]
	[FieldOffset(Offset = "0x38")]
	private float m_PositionOffset;

	[SerializeField]
	[Token(Token = "0x40020A7")]
	[FieldOffset(Offset = "0x40")]
	private MinMax m_Width;

	[SerializeField]
	[Token(Token = "0x40020A8")]
	[FieldOffset(Offset = "0x48")]
	private Vector3 m_Scale;

	[SerializeField]
	[Token(Token = "0x40020A9")]
	[FieldOffset(Offset = "0x54")]
	private float m_VerticalPosition;

	[SerializeField]
	[Token(Token = "0x40020AA")]
	[FieldOffset(Offset = "0x58")]
	private Transform[] m_Rays;

	[SerializeField]
	[Token(Token = "0x40020AB")]
	[FieldOffset(Offset = "0x60")]
	private float m_FadeDistance;

	[SerializeField]
	[Token(Token = "0x40020AC")]
	[FieldOffset(Offset = "0x64")]
	private bool m_DebugMode;

	[Token(Token = "0x40020AD")]
	[FieldOffset(Offset = "0x68")]
	private List<GodRayObject> m_RayObjects;

	[Token(Token = "0x40020AE")]
	[FieldOffset(Offset = "0x70")]
	private float m_MasterOpacity;

	[Token(Token = "0x40020AF")]
	[FieldOffset(Offset = "0x74")]
	private int m_TintID;

	[Token(Token = "0x40020B0")]
	[FieldOffset(Offset = "0x78")]
	private bool m_Initialized;

	[Token(Token = "0x40020B1")]
	[FieldOffset(Offset = "0x7C")]
	private float m_TransitionFadeTarget;

	[Token(Token = "0x40020B2")]
	[FieldOffset(Offset = "0x80")]
	private Quaternion m_WorldLightRotation;

	[Token(Token = "0x40020B3")]
	[FieldOffset(Offset = "0x90")]
	private MaterialPropertyBlock m_PropBlock;

	[Token(Token = "0x40020B4")]
	[FieldOffset(Offset = "0x98")]
	private Quaternion m_LightRotationOffset;

	[Token(Token = "0x6001CF8")]
	[Address(RVA = "0x790090", Offset = "0x78EE90", Length = "0x2BD")]
	private void Start()
	{
	}

	[Token(Token = "0x6001CF9")]
	[Address(RVA = "0x790350", Offset = "0x78F150", Length = "0x731")]
	private void Update()
	{
	}

	[Token(Token = "0x6001CFA")]
	[Address(RVA = "0x790A90", Offset = "0x78F890", Length = "0x8")]
	public void StartRays()
	{
	}

	[Token(Token = "0x6001CFB")]
	[Address(RVA = "0x790AA0", Offset = "0x78F8A0", Length = "0x8")]
	public void StopRays()
	{
	}

	[Token(Token = "0x6001CFC")]
	[Address(RVA = "0x790AB0", Offset = "0x78F8B0", Length = "0x315")]
	public GodrayManager()
	{
	}
}
