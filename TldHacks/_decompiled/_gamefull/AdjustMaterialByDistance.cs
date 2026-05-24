using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000351")]
public class AdjustMaterialByDistance : MonoBehaviour
{
	[SerializeField]
	[Token(Token = "0x4001D4D")]
	[FieldOffset(Offset = "0x20")]
	private bool m_StaticPosition;

	[Header("Distance")]
	[SerializeField]
	[Token(Token = "0x4001D4E")]
	[FieldOffset(Offset = "0x24")]
	private float m_NearDistance;

	[SerializeField]
	[Token(Token = "0x4001D4F")]
	[FieldOffset(Offset = "0x28")]
	private float m_FarDistance;

	[Header("Adjustments")]
	[SerializeField]
	[Token(Token = "0x4001D50")]
	[FieldOffset(Offset = "0x30")]
	private string m_ColorPropertyName;

	[SerializeField]
	[Token(Token = "0x4001D51")]
	[FieldOffset(Offset = "0x38")]
	private Color m_NearColor;

	[Token(Token = "0x4001D52")]
	[FieldOffset(Offset = "0x48")]
	private Color m_FarColor;

	[Token(Token = "0x4001D53")]
	[FieldOffset(Offset = "0x58")]
	private Vector3 m_OriginalPosition;

	[Token(Token = "0x4001D54")]
	[FieldOffset(Offset = "0x64")]
	private float m_DistanceToPlayer;

	[Token(Token = "0x4001D55")]
	[FieldOffset(Offset = "0x68")]
	private float m_TransitionPercentage;

	[Token(Token = "0x4001D56")]
	[FieldOffset(Offset = "0x6C")]
	private float m_NearDistanceSqr;

	[Token(Token = "0x4001D57")]
	[FieldOffset(Offset = "0x70")]
	private float m_FarDistanceSqr;

	[Token(Token = "0x4001D58")]
	[FieldOffset(Offset = "0x74")]
	private int m_ColorID;

	[Token(Token = "0x4001D59")]
	[FieldOffset(Offset = "0x78")]
	private Material m_ThisMaterial;

	[Token(Token = "0x6001B26")]
	[Address(RVA = "0x758B40", Offset = "0x757940", Length = "0x196")]
	private void Start()
	{
	}

	[Token(Token = "0x6001B27")]
	[Address(RVA = "0x758CE0", Offset = "0x757AE0", Length = "0x128")]
	private float DistanceToPlayer(Vector3 fxPos)
	{
		return 0f;
	}

	[Token(Token = "0x6001B28")]
	[Address(RVA = "0x758E10", Offset = "0x757C10", Length = "0x2C3")]
	private void Update()
	{
	}

	[Token(Token = "0x6001B29")]
	[Address(RVA = "0x7590E0", Offset = "0x757EE0", Length = "0xC2")]
	public AdjustMaterialByDistance()
	{
	}
}
