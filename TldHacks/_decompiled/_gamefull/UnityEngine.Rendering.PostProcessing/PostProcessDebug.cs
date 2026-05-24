using Cpp2ILInjected;

namespace UnityEngine.Rendering.PostProcessing;

[ExecuteAlways]
[AddComponentMenu("Rendering/Post-process Debug", 1002)]
[Token(Token = "0x2000CD0")]
public sealed class PostProcessDebug : MonoBehaviour
{
	[Token(Token = "0x4007F52")]
	[FieldOffset(Offset = "0x20")]
	public PostProcessLayer postProcessLayer;

	[Token(Token = "0x4007F53")]
	[FieldOffset(Offset = "0x28")]
	private PostProcessLayer m_PreviousPostProcessLayer;

	[Token(Token = "0x4007F54")]
	[FieldOffset(Offset = "0x30")]
	public bool lightMeter;

	[Token(Token = "0x4007F55")]
	[FieldOffset(Offset = "0x31")]
	public bool histogram;

	[Token(Token = "0x4007F56")]
	[FieldOffset(Offset = "0x32")]
	public bool waveform;

	[Token(Token = "0x4007F57")]
	[FieldOffset(Offset = "0x33")]
	public bool vectorscope;

	[Token(Token = "0x4007F58")]
	[FieldOffset(Offset = "0x34")]
	public DebugOverlay debugOverlay;

	[Token(Token = "0x4007F59")]
	[FieldOffset(Offset = "0x38")]
	private Camera m_CurrentCamera;

	[Token(Token = "0x4007F5A")]
	[FieldOffset(Offset = "0x40")]
	private CommandBuffer m_CmdAfterEverything;

	[Token(Token = "0x600657B")]
	[Address(RVA = "0x1012B20", Offset = "0x1011920", Length = "0xF2")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600657C")]
	[Address(RVA = "0x1012C20", Offset = "0x1011A20", Length = "0x19E")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600657D")]
	[Address(RVA = "0x1012DC0", Offset = "0x1011BC0", Length = "0x7")]
	private void Update()
	{
	}

	[Token(Token = "0x600657E")]
	[Address(RVA = "0x1012DD0", Offset = "0x1011BD0", Length = "0x8C")]
	private void Reset()
	{
	}

	[Token(Token = "0x600657F")]
	[Address(RVA = "0x1012E60", Offset = "0x1011C60", Length = "0x551")]
	private void UpdateStates()
	{
	}

	[Token(Token = "0x6006580")]
	[Address(RVA = "0x10133C0", Offset = "0x10121C0", Length = "0x409")]
	private void OnPostRender()
	{
	}

	[Token(Token = "0x6006581")]
	[Address(RVA = "0x10137D0", Offset = "0x10125D0", Length = "0x208")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x6006582")]
	[Address(RVA = "0x10139E0", Offset = "0x10127E0", Length = "0x1E0")]
	private void DrawMonitor(ref Rect rect, Monitor monitor, bool enabled)
	{
	}

	[Token(Token = "0x6006583")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public PostProcessDebug()
	{
	}
}
