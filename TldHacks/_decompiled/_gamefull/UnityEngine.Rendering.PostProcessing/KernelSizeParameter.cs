using System;
using Cpp2ILInjected;

namespace UnityEngine.Rendering.PostProcessing;

[Serializable]
[Token(Token = "0x2000C98")]
public sealed class KernelSizeParameter : ParameterOverride<KernelSize>
{
	[Token(Token = "0x60064C0")]
	[Address(RVA = "0xFF9880", Offset = "0xFF8680", Length = "0x4C")]
	public KernelSizeParameter()
	{
	}
}
