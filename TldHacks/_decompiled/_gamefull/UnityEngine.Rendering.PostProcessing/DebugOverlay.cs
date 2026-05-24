using Cpp2ILInjected;

namespace UnityEngine.Rendering.PostProcessing;

[Token(Token = "0x2000CD1")]
public enum DebugOverlay
{
	[Token(Token = "0x4007F5C")]
	None,
	[Token(Token = "0x4007F5D")]
	Depth,
	[Token(Token = "0x4007F5E")]
	Normals,
	[Token(Token = "0x4007F5F")]
	MotionVectors,
	[Token(Token = "0x4007F60")]
	NANTracker,
	[Token(Token = "0x4007F61")]
	ColorBlindnessSimulation,
	[Token(Token = "0x4007F62")]
	_,
	[Token(Token = "0x4007F63")]
	AmbientOcclusion,
	[Token(Token = "0x4007F64")]
	BloomBuffer,
	[Token(Token = "0x4007F65")]
	BloomThreshold,
	[Token(Token = "0x4007F66")]
	DepthOfField
}
