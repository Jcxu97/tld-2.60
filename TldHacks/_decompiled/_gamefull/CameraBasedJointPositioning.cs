using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000198")]
public class CameraBasedJointPositioning : MonoBehaviour
{
	[Token(Token = "0x2000199")]
	private struct JointSavedData
	{
		[Token(Token = "0x4000EB7")]
		[FieldOffset(Offset = "0x0")]
		public Vector3 m_PositionToRestore;

		[Token(Token = "0x4000EB8")]
		[FieldOffset(Offset = "0xC")]
		public bool m_HasSetPositionToRestore;

		[Token(Token = "0x4000EB9")]
		[FieldOffset(Offset = "0x10")]
		public Quaternion m_Rotation;
	}

	[Token(Token = "0x4000EA0")]
	[FieldOffset(Offset = "0x20")]
	public GameObject m_Joint;

	[Token(Token = "0x4000EA1")]
	[FieldOffset(Offset = "0x28")]
	public float m_Camera_MaxAngle;

	[Token(Token = "0x4000EA2")]
	[FieldOffset(Offset = "0x2C")]
	public float m_Camera_MinAngle;

	[Token(Token = "0x4000EA3")]
	[FieldOffset(Offset = "0x30")]
	public float m_Camera_CenterAngle;

	[Token(Token = "0x4000EA4")]
	[FieldOffset(Offset = "0x34")]
	public float m_Joint_MaxAngle;

	[Token(Token = "0x4000EA5")]
	[FieldOffset(Offset = "0x38")]
	public float m_Joint_MinAngle;

	[Token(Token = "0x4000EA6")]
	[FieldOffset(Offset = "0x3C")]
	public float m_Joint_CenterAngle;

	[Token(Token = "0x4000EA7")]
	[FieldOffset(Offset = "0x40")]
	public float m_JointAngleMinDifferenceForUpdate;

	[Token(Token = "0x4000EA8")]
	[FieldOffset(Offset = "0x44")]
	public float m_JointRotationMaxDegreesPerSecond;

	[Token(Token = "0x4000EA9")]
	[FieldOffset(Offset = "0x48")]
	public bool m_ApplyCameraMotionToJoint;

	[Token(Token = "0x4000EAA")]
	[FieldOffset(Offset = "0x50")]
	public string m_Layer;

	[Token(Token = "0x4000EAB")]
	[FieldOffset(Offset = "0x58")]
	public float m_LayerWeight;

	[Token(Token = "0x4000EAC")]
	[FieldOffset(Offset = "0x60")]
	public GameObject m_CameraBone;

	[Token(Token = "0x4000EAD")]
	[FieldOffset(Offset = "0x68")]
	private float m_LastAngle;

	[Token(Token = "0x4000EAE")]
	[FieldOffset(Offset = "0x6C")]
	private Vector3 m_JointPositionAtStart;

	[Token(Token = "0x4000EAF")]
	[FieldOffset(Offset = "0x78")]
	private bool m_Enabled;

	[Token(Token = "0x4000EB0")]
	[FieldOffset(Offset = "0x7C")]
	private Vector3 m_StandingPositionOffset;

	[Token(Token = "0x4000EB1")]
	[FieldOffset(Offset = "0x88")]
	private int m_LayerIndex;

	[Token(Token = "0x4000EB2")]
	[FieldOffset(Offset = "0x8C")]
	private Vector3 m_PositionToRestore;

	[Token(Token = "0x4000EB3")]
	[FieldOffset(Offset = "0x98")]
	private bool m_HasSetPositionToRestore;

	[Token(Token = "0x4000EB4")]
	[FieldOffset(Offset = "0x99")]
	private bool m_WasStruggling;

	[Token(Token = "0x4000EB5")]
	private const string STRUGGLE_SAVE_ID = "Strugle";

	[Token(Token = "0x4000EB6")]
	[FieldOffset(Offset = "0xA0")]
	private Dictionary<string, JointSavedData> m_SavedJoints;

	[Token(Token = "0x6000F44")]
	[Address(RVA = "0x60DC10", Offset = "0x60CA10", Length = "0x333")]
	public void Start()
	{
	}

	[Token(Token = "0x6000F45")]
	[Address(RVA = "0x60DF50", Offset = "0x60CD50", Length = "0x15A")]
	private bool CanApplyCameraMotionToJoint()
	{
		return false;
	}

	[Token(Token = "0x6000F46")]
	[Address(RVA = "0x60E0B0", Offset = "0x60CEB0", Length = "0x5AC")]
	public void UpdateJoint()
	{
	}

	[Token(Token = "0x6000F47")]
	[Address(RVA = "0x502700", Offset = "0x501500", Length = "0x5")]
	public bool IsEnabled()
	{
		return false;
	}

	[Token(Token = "0x6000F48")]
	[Address(RVA = "0x60E660", Offset = "0x60D460", Length = "0x343")]
	public void Enable(bool enabled)
	{
	}

	[Token(Token = "0x6000F49")]
	[Address(RVA = "0x60E9B0", Offset = "0x60D7B0", Length = "0xAE")]
	public void Restore()
	{
	}

	[Token(Token = "0x6000F4A")]
	[Address(RVA = "0x60EA60", Offset = "0x60D860", Length = "0x24D")]
	public void Save(string saveName)
	{
	}

	[Token(Token = "0x6000F4B")]
	[Address(RVA = "0x60ECB0", Offset = "0x60DAB0", Length = "0x4CB")]
	public void Load(string saveName)
	{
	}

	[Token(Token = "0x6000F4C")]
	[Address(RVA = "0x60F180", Offset = "0x60DF80", Length = "0x67")]
	private float GetAngleFromPercentageOfAngleRange(float min, float max, float value, float outMin, float outMax)
	{
		return 0f;
	}

	[Token(Token = "0x6000F4D")]
	[Address(RVA = "0x60F1F0", Offset = "0x60DFF0", Length = "0x244")]
	public float GetShoulderRotation()
	{
		return 0f;
	}

	[Token(Token = "0x6000F4E")]
	[Address(RVA = "0x60F440", Offset = "0x60E240", Length = "0x1D6")]
	public void Reset()
	{
	}

	[Token(Token = "0x6000F4F")]
	[Address(RVA = "0x60F620", Offset = "0x60E420", Length = "0x20E")]
	public void FullReset()
	{
	}

	[Token(Token = "0x6000F50")]
	[Address(RVA = "0x60F830", Offset = "0x60E630", Length = "0x52")]
	public void ResetForStruggle()
	{
	}

	[Token(Token = "0x6000F51")]
	[Address(RVA = "0x60F890", Offset = "0x60E690", Length = "0x16A")]
	public CameraBasedJointPositioning()
	{
	}
}
