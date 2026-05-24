using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000A25")]
public class Placeholder : MonoBehaviour
{
	[Token(Token = "0x2000A26")]
	private enum VisualizationMode
	{
		[Token(Token = "0x4006661")]
		Box,
		[Token(Token = "0x4006662")]
		Mesh,
		[Token(Token = "0x4006663")]
		LineOnly
	}

	[SerializeField]
	[Token(Token = "0x400664E")]
	[FieldOffset(Offset = "0x20")]
	private string m_Label;

	[SerializeField]
	[Token(Token = "0x400664F")]
	[FieldOffset(Offset = "0x28")]
	private Color m_LabelColor;

	[SerializeField]
	[Token(Token = "0x4006650")]
	[FieldOffset(Offset = "0x38")]
	private Vector3 m_LabelOffset;

	[SerializeField]
	[Token(Token = "0x4006651")]
	[FieldOffset(Offset = "0x44")]
	private VisualizationMode m_VisualizationMode;

	[SerializeField]
	[Token(Token = "0x4006652")]
	[FieldOffset(Offset = "0x48")]
	private Color m_VisualizationColor;

	[SerializeField]
	[Token(Token = "0x4006653")]
	[FieldOffset(Offset = "0x58")]
	private Mesh m_Mesh;

	[Token(Token = "0x4006654")]
	public static bool s_ShouldRender;

	[Token(Token = "0x4006655")]
	[FieldOffset(Offset = "0x60")]
	private GUIStyle m_LabelStyle;

	[Token(Token = "0x4006656")]
	private const int MIN_FONT_SIZE = 2;

	[Token(Token = "0x4006657")]
	private const int MAX_FONT_SIZE = 11;

	[Token(Token = "0x4006658")]
	private const float LABEL_WIDTH = 200f;

	[Token(Token = "0x4006659")]
	private const float MIN_LABEL_HEIGHT = 20f;

	[Token(Token = "0x400665A")]
	private const float MAX_LABEL_HEIGHT = 50f;

	[Token(Token = "0x400665B")]
	private const float MAX_LABEL_DISTANCE = 30f;

	[Token(Token = "0x400665C")]
	private const float MAX_SQR_LABEL_DISTANCE = 900f;

	[Token(Token = "0x400665D")]
	private const string MESH_NAME = "Placeholder Mesh";

	[Token(Token = "0x400665E")]
	private const string MESH_SHADER_NAME = "Shader Forge/TLD_Simple";

	[Token(Token = "0x400665F")]
	private const string LINE_SHADER_NAME = "Hidden/Internal-Colored";

	[Token(Token = "0x60058EB")]
	[Address(RVA = "0xEED700", Offset = "0xEEC500", Length = "0x372")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x60058EC")]
	[Address(RVA = "0xEEDA80", Offset = "0xEEC880", Length = "0x2C2")]
	private GUIStyle GetLabelStyle(Color textColor, float normalizedDistance)
	{
		return null;
	}

	[Token(Token = "0x60058ED")]
	[Address(RVA = "0xEEDD50", Offset = "0xEECB50", Length = "0xA8")]
	public Placeholder()
	{
	}
}
