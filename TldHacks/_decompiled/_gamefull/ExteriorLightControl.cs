using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20002F8")]
public class ExteriorLightControl : MonoBehaviour
{
	[Token(Token = "0x4001A24")]
	[FieldOffset(Offset = "0x20")]
	public ScaledCurve m_TodCurve;

	[Token(Token = "0x4001A25")]
	[FieldOffset(Offset = "0x28")]
	private Light[] m_Lights;

	[Token(Token = "0x4001A26")]
	[FieldOffset(Offset = "0x30")]
	private float[] m_LightVals;

	[Token(Token = "0x600188A")]
	[Address(RVA = "0x6F09F0", Offset = "0x6EF7F0", Length = "0x269")]
	private void Start()
	{
	}

	[Token(Token = "0x600188B")]
	[Address(RVA = "0x6F0C60", Offset = "0x6EFA60", Length = "0x371")]
	private void Update()
	{
	}

	[Token(Token = "0x600188C")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public ExteriorLightControl()
	{
	}
}
