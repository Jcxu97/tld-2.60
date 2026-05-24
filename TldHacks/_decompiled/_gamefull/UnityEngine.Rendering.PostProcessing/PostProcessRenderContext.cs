using System.Collections.Generic;
using Cpp2ILInjected;

namespace UnityEngine.Rendering.PostProcessing;

[Token(Token = "0x2000CE8")]
public sealed class PostProcessRenderContext
{
	[Token(Token = "0x2000CE9")]
	public enum StereoRenderingMode
	{
		[Token(Token = "0x4007FF0")]
		MultiPass,
		[Token(Token = "0x4007FF1")]
		SinglePass,
		[Token(Token = "0x4007FF2")]
		SinglePassInstanced,
		[Token(Token = "0x4007FF3")]
		SinglePassMultiview
	}

	[Token(Token = "0x4007FD2")]
	[FieldOffset(Offset = "0x10")]
	private Camera m_Camera;

	[Token(Token = "0x4007FE7")]
	[FieldOffset(Offset = "0xC8")]
	internal PropertySheet uberSheet;

	[Token(Token = "0x4007FE8")]
	[FieldOffset(Offset = "0xD0")]
	internal Texture autoExposureTexture;

	[Token(Token = "0x4007FE9")]
	[FieldOffset(Offset = "0xD8")]
	internal LogHistogram logHistogram;

	[Token(Token = "0x4007FEA")]
	[FieldOffset(Offset = "0xE0")]
	internal Texture logLut;

	[Token(Token = "0x4007FEB")]
	[FieldOffset(Offset = "0xE8")]
	internal AutoExposure autoExposure;

	[Token(Token = "0x4007FEC")]
	[FieldOffset(Offset = "0xF0")]
	internal int bloomBufferNameID;

	[Token(Token = "0x4007FED")]
	[FieldOffset(Offset = "0xF4")]
	internal bool physicalCamera;

	[Token(Token = "0x4007FEE")]
	[FieldOffset(Offset = "0xF8")]
	private RenderTextureDescriptor m_sourceDescriptor;

	[Token(Token = "0x170006D0")]
	public Camera camera
	{
		[Token(Token = "0x6006616")]
		[Address(RVA = "0x49DED0", Offset = "0x49CCD0", Length = "0x5")]
		get
		{
			return null;
		}
		[Token(Token = "0x6006617")]
		[Address(RVA = "0x1024DF0", Offset = "0x1023BF0", Length = "0x1CB")]
		set
		{
		}
	}

	[Token(Token = "0x170006D1")]
	[field: Token(Token = "0x4007FD3")]
	[field: FieldOffset(Offset = "0x18")]
	public CommandBuffer command
	{
		[Token(Token = "0x6006618")]
		[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
		get;
		[Token(Token = "0x6006619")]
		[Address(RVA = "0x49DEE0", Offset = "0x49CCE0", Length = "0x52")]
		set;
	}

	[Token(Token = "0x170006D2")]
	[field: Token(Token = "0x4007FD4")]
	[field: FieldOffset(Offset = "0x20")]
	public RenderTargetIdentifier source
	{
		[Token(Token = "0x600661A")]
		[Address(RVA = "0x1024FC0", Offset = "0x1023DC0", Length = "0x1D")]
		get;
		[Token(Token = "0x600661B")]
		[Address(RVA = "0x1024FE0", Offset = "0x1023DE0", Length = "0x1A")]
		set;
	}

	[Token(Token = "0x170006D3")]
	[field: Token(Token = "0x4007FD5")]
	[field: FieldOffset(Offset = "0x48")]
	public RenderTargetIdentifier destination
	{
		[Token(Token = "0x600661C")]
		[Address(RVA = "0x1025000", Offset = "0x1023E00", Length = "0x1D")]
		get;
		[Token(Token = "0x600661D")]
		[Address(RVA = "0x1025020", Offset = "0x1023E20", Length = "0x1A")]
		set;
	}

	[Token(Token = "0x170006D4")]
	[field: Token(Token = "0x4007FD6")]
	[field: FieldOffset(Offset = "0x70")]
	public RenderTextureFormat sourceFormat
	{
		[Token(Token = "0x600661E")]
		[Address(RVA = "0x658130", Offset = "0x656F30", Length = "0x4")]
		get;
		[Token(Token = "0x600661F")]
		[Address(RVA = "0x802EB0", Offset = "0x801CB0", Length = "0x4")]
		set;
	}

	[Token(Token = "0x170006D5")]
	[field: Token(Token = "0x4007FD7")]
	[field: FieldOffset(Offset = "0x74")]
	public bool flip
	{
		[Token(Token = "0x6006620")]
		[Address(RVA = "0x756030", Offset = "0x754E30", Length = "0x5")]
		get;
		[Token(Token = "0x6006621")]
		[Address(RVA = "0x1025040", Offset = "0x1023E40", Length = "0x4")]
		set;
	}

	[Token(Token = "0x170006D6")]
	[field: Token(Token = "0x4007FD8")]
	[field: FieldOffset(Offset = "0x78")]
	public PostProcessResources resources
	{
		[Token(Token = "0x6006622")]
		[Address(RVA = "0x664E10", Offset = "0x663C10", Length = "0x5")]
		get;
		[Token(Token = "0x6006623")]
		[Address(RVA = "0x6E17D0", Offset = "0x6E05D0", Length = "0x52")]
		internal set;
	}

	[Token(Token = "0x170006D7")]
	[field: Token(Token = "0x4007FD9")]
	[field: FieldOffset(Offset = "0x80")]
	public PropertySheetFactory propertySheets
	{
		[Token(Token = "0x6006624")]
		[Address(RVA = "0x502330", Offset = "0x501130", Length = "0x8")]
		get;
		[Token(Token = "0x6006625")]
		[Address(RVA = "0xB51E90", Offset = "0xB50C90", Length = "0x52")]
		internal set;
	}

	[Token(Token = "0x170006D8")]
	[field: Token(Token = "0x4007FDA")]
	[field: FieldOffset(Offset = "0x88")]
	public Dictionary<string, object> userData
	{
		[Token(Token = "0x6006626")]
		[Address(RVA = "0x4C0240", Offset = "0x4BF040", Length = "0x8")]
		get;
		[Token(Token = "0x6006627")]
		[Address(RVA = "0xB69600", Offset = "0xB68400", Length = "0x52")]
		private set;
	}

	[Token(Token = "0x170006D9")]
	[field: Token(Token = "0x4007FDB")]
	[field: FieldOffset(Offset = "0x90")]
	public PostProcessDebugLayer debugLayer
	{
		[Token(Token = "0x6006628")]
		[Address(RVA = "0x40DA00", Offset = "0x40C800", Length = "0x8")]
		get;
		[Token(Token = "0x6006629")]
		[Address(RVA = "0x40DA10", Offset = "0x40C810", Length = "0x52")]
		internal set;
	}

	[Token(Token = "0x170006DA")]
	[field: Token(Token = "0x4007FDC")]
	[field: FieldOffset(Offset = "0x98")]
	public int width
	{
		[Token(Token = "0x600662A")]
		[Address(RVA = "0x40DA70", Offset = "0x40C870", Length = "0x7")]
		get;
		[Token(Token = "0x600662B")]
		[Address(RVA = "0x40DA80", Offset = "0x40C880", Length = "0x7")]
		private set;
	}

	[Token(Token = "0x170006DB")]
	[field: Token(Token = "0x4007FDD")]
	[field: FieldOffset(Offset = "0x9C")]
	public int height
	{
		[Token(Token = "0x600662C")]
		[Address(RVA = "0x40DA90", Offset = "0x40C890", Length = "0x7")]
		get;
		[Token(Token = "0x600662D")]
		[Address(RVA = "0x40DAA0", Offset = "0x40C8A0", Length = "0x7")]
		private set;
	}

	[Token(Token = "0x170006DC")]
	[field: Token(Token = "0x4007FDE")]
	[field: FieldOffset(Offset = "0xA0")]
	public bool stereoActive
	{
		[Token(Token = "0x600662E")]
		[Address(RVA = "0x657ED0", Offset = "0x656CD0", Length = "0x8")]
		get;
		[Token(Token = "0x600662F")]
		[Address(RVA = "0x1025050", Offset = "0x1023E50", Length = "0x7")]
		private set;
	}

	[Token(Token = "0x170006DD")]
	[field: Token(Token = "0x4007FDF")]
	[field: FieldOffset(Offset = "0xA4")]
	public int xrActiveEye
	{
		[Token(Token = "0x6006630")]
		[Address(RVA = "0x1025060", Offset = "0x1023E60", Length = "0x7")]
		get;
		[Token(Token = "0x6006631")]
		[Address(RVA = "0x8327B0", Offset = "0x8315B0", Length = "0x7")]
		set;
	}

	[Token(Token = "0x170006DE")]
	[field: Token(Token = "0x4007FE0")]
	[field: FieldOffset(Offset = "0xA8")]
	public int numberOfEyes
	{
		[Token(Token = "0x6006632")]
		[Address(RVA = "0x1025070", Offset = "0x1023E70", Length = "0x7")]
		get;
		[Token(Token = "0x6006633")]
		[Address(RVA = "0x1025080", Offset = "0x1023E80", Length = "0x7")]
		private set;
	}

	[Token(Token = "0x170006DF")]
	[field: Token(Token = "0x4007FE1")]
	[field: FieldOffset(Offset = "0xAC")]
	public StereoRenderingMode stereoRenderingMode
	{
		[Token(Token = "0x6006634")]
		[Address(RVA = "0x6A2BE0", Offset = "0x6A19E0", Length = "0x7")]
		get;
		[Token(Token = "0x6006635")]
		[Address(RVA = "0x810C30", Offset = "0x80FA30", Length = "0x7")]
		private set;
	}

	[Token(Token = "0x170006E0")]
	[field: Token(Token = "0x4007FE2")]
	[field: FieldOffset(Offset = "0xB0")]
	public int screenWidth
	{
		[Token(Token = "0x6006636")]
		[Address(RVA = "0x5DEE90", Offset = "0x5DDC90", Length = "0x7")]
		get;
		[Token(Token = "0x6006637")]
		[Address(RVA = "0x10165B0", Offset = "0x10153B0", Length = "0x7")]
		private set;
	}

	[Token(Token = "0x170006E1")]
	[field: Token(Token = "0x4007FE3")]
	[field: FieldOffset(Offset = "0xB4")]
	public int screenHeight
	{
		[Token(Token = "0x6006638")]
		[Address(RVA = "0x5EFD20", Offset = "0x5EEB20", Length = "0x7")]
		get;
		[Token(Token = "0x6006639")]
		[Address(RVA = "0x1025090", Offset = "0x1023E90", Length = "0x7")]
		private set;
	}

	[Token(Token = "0x170006E2")]
	[field: Token(Token = "0x4007FE4")]
	[field: FieldOffset(Offset = "0xB8")]
	public bool isSceneView
	{
		[Token(Token = "0x600663A")]
		[Address(RVA = "0x8352F0", Offset = "0x8340F0", Length = "0x8")]
		get;
		[Token(Token = "0x600663B")]
		[Address(RVA = "0x7A86D0", Offset = "0x7A74D0", Length = "0x7")]
		internal set;
	}

	[Token(Token = "0x170006E3")]
	[field: Token(Token = "0x4007FE5")]
	[field: FieldOffset(Offset = "0xBC")]
	public PostProcessLayer.Antialiasing antialiasing
	{
		[Token(Token = "0x600663C")]
		[Address(RVA = "0xA73F80", Offset = "0xA72D80", Length = "0x7")]
		get;
		[Token(Token = "0x600663D")]
		[Address(RVA = "0x10250A0", Offset = "0x1023EA0", Length = "0x7")]
		internal set;
	}

	[Token(Token = "0x170006E4")]
	[field: Token(Token = "0x4007FE6")]
	[field: FieldOffset(Offset = "0xC0")]
	public TemporalAntialiasing temporalAntialiasing
	{
		[Token(Token = "0x600663E")]
		[Address(RVA = "0x502640", Offset = "0x501440", Length = "0x8")]
		get;
		[Token(Token = "0x600663F")]
		[Address(RVA = "0x10250B0", Offset = "0x1023EB0", Length = "0x52")]
		internal set;
	}

	[Token(Token = "0x6006640")]
	[Address(RVA = "0x1025110", Offset = "0x1023F10", Length = "0x616")]
	public void Reset()
	{
	}

	[Token(Token = "0x6006641")]
	[Address(RVA = "0x1025730", Offset = "0x1024530", Length = "0x39")]
	public bool IsTemporalAntialiasingActive()
	{
		return false;
	}

	[Token(Token = "0x6006642")]
	[Address(RVA = "0x1025770", Offset = "0x1024570", Length = "0x20")]
	public bool IsDebugOverlayEnabled(DebugOverlay overlay)
	{
		return false;
	}

	[Token(Token = "0x6006643")]
	[Address(RVA = "0x10257A0", Offset = "0x10245A0", Length = "0x57")]
	public void PushDebugOverlay(CommandBuffer cmd, RenderTargetIdentifier source, PropertySheet sheet, int pass)
	{
	}

	[Token(Token = "0x6006644")]
	[Address(RVA = "0x1025800", Offset = "0x1024600", Length = "0x195")]
	internal RenderTextureDescriptor GetDescriptor(int depthBufferBits = 0, RenderTextureFormat colorFormat = RenderTextureFormat.Default, RenderTextureReadWrite readWrite = RenderTextureReadWrite.Default)
	{
		return default(RenderTextureDescriptor);
	}

	[Token(Token = "0x6006645")]
	[Address(RVA = "0x10259A0", Offset = "0x10247A0", Length = "0x145")]
	public void GetScreenSpaceTemporaryRT(CommandBuffer cmd, int nameID, int depthBufferBits = 0, RenderTextureFormat colorFormat = RenderTextureFormat.Default, RenderTextureReadWrite readWrite = RenderTextureReadWrite.Default, FilterMode filter = FilterMode.Bilinear, int widthOverride = 0, int heightOverride = 0)
	{
	}

	[Token(Token = "0x6006646")]
	[Address(RVA = "0x1025AF0", Offset = "0x10248F0", Length = "0x8F")]
	public RenderTexture GetScreenSpaceTemporaryRT(int depthBufferBits = 0, RenderTextureFormat colorFormat = RenderTextureFormat.Default, RenderTextureReadWrite readWrite = RenderTextureReadWrite.Default, int widthOverride = 0, int heightOverride = 0)
	{
		return null;
	}

	[Token(Token = "0x6006647")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public void UpdateSinglePassStereoState(bool isTAAEnabled, bool isAOEnabled, bool isSSREnabled)
	{
	}

	[Token(Token = "0x6006648")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public PostProcessRenderContext()
	{
	}
}
