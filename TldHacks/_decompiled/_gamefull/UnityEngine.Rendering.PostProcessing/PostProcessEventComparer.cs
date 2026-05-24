using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2ILInjected;

namespace UnityEngine.Rendering.PostProcessing;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[Token(Token = "0x2000CDA")]
internal struct PostProcessEventComparer : IEqualityComparer<PostProcessEvent>
{
	[Token(Token = "0x60065AF")]
	[Address(RVA = "0x5DC750", Offset = "0x5DB550", Length = "0x7")]
	public bool Equals(PostProcessEvent x, PostProcessEvent y)
	{
		return false;
	}

	[Token(Token = "0x60065B0")]
	[Address(RVA = "0x5DC760", Offset = "0x5DB560", Length = "0x3")]
	public int GetHashCode(PostProcessEvent obj)
	{
		return 0;
	}
}
