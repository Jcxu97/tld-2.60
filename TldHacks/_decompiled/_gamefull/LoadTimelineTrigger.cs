using Cpp2ILInjected;
using TLD.AddressableAssets;
using UnityEngine;

[Token(Token = "0x20009CC")]
public class LoadTimelineTrigger : MonoBehaviour
{
	[Token(Token = "0x4006399")]
	[FieldOffset(Offset = "0x20")]
	public AssetReferenceTimeline[] m_Timelines;

	[Token(Token = "0x6005696")]
	[Address(RVA = "0xEBB8E0", Offset = "0xEBA6E0", Length = "0xE2")]
	private void OnTriggerEnter(Collider c)
	{
	}

	[Token(Token = "0x6005697")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public LoadTimelineTrigger()
	{
	}
}
