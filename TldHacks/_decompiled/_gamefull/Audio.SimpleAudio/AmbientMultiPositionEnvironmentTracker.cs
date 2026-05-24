using Cpp2ILInjected;
using UnityEngine;

namespace Audio.SimpleAudio;

[Token(Token = "0x2001338")]
public class AmbientMultiPositionEnvironmentTracker : MonoBehaviour
{
	[Token(Token = "0x4008DD4")]
	[FieldOffset(Offset = "0x20")]
	private AkGameObjEnvironmentData m_EnvironmentData;

	[Token(Token = "0x4008DD5")]
	[FieldOffset(Offset = "0x28")]
	private Collider m_Collider;

	[Token(Token = "0x6007B2F")]
	[Address(RVA = "0x119DBE0", Offset = "0x119C9E0", Length = "0xBE")]
	private void Awake()
	{
	}

	[Token(Token = "0x6007B30")]
	[Address(RVA = "0xE9C720", Offset = "0xE9B520", Length = "0x52")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6007B31")]
	[Address(RVA = "0x119DCA0", Offset = "0x119CAA0", Length = "0x10A")]
	private void Update()
	{
	}

	[Token(Token = "0x6007B32")]
	[Address(RVA = "0x119DDB0", Offset = "0x119CBB0", Length = "0x25")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6007B33")]
	[Address(RVA = "0x119DDE0", Offset = "0x119CBE0", Length = "0x25")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x6007B34")]
	[Address(RVA = "0x4AF5E0", Offset = "0x4AE3E0", Length = "0x43")]
	public AmbientMultiPositionEnvironmentTracker()
	{
	}
}
