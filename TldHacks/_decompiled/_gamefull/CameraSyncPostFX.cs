using System.Collections.Generic;
using System.Reflection;
using Cpp2ILInjected;
using UnityEngine;

[RequireComponent(typeof(Camera))]
[Token(Token = "0x2000371")]
public class CameraSyncPostFX : MonoBehaviour
{
	[Token(Token = "0x4001E94")]
	private const BindingFlags m_FieldFlags = BindingFlags.Instance | BindingFlags.Public | BindingFlags.FlattenHierarchy;

	[Token(Token = "0x4001E95")]
	private const BindingFlags m_MethodFlags = BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.FlattenHierarchy;

	[Token(Token = "0x4001E96")]
	[FieldOffset(Offset = "0x20")]
	private Camera m_Camera;

	[Token(Token = "0x4001E97")]
	[FieldOffset(Offset = "0x28")]
	private CameraGlobalRT m_GlobalCamera;

	[Token(Token = "0x4001E98")]
	[FieldOffset(Offset = "0x30")]
	private List<MonoBehaviour> m_SourceImageEffects;

	[Token(Token = "0x4001E99")]
	[FieldOffset(Offset = "0x38")]
	private List<MonoBehaviour> m_SynchronizedImageEffects;

	[Token(Token = "0x4001E9A")]
	[FieldOffset(Offset = "0x40")]
	private bool m_ForceFirstPersonCamera;

	[Token(Token = "0x6001BE6")]
	[Address(RVA = "0x76CA70", Offset = "0x76B870", Length = "0x153")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6001BE7")]
	[Address(RVA = "0x76CBD0", Offset = "0x76B9D0", Length = "0x186")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6001BE8")]
	[Address(RVA = "0x76CD60", Offset = "0x76BB60", Length = "0xE")]
	private void Update()
	{
	}

	[Token(Token = "0x6001BE9")]
	[Address(RVA = "0x76CD70", Offset = "0x76BB70", Length = "0x5D5")]
	public void Initialize()
	{
	}

	[Token(Token = "0x6001BEA")]
	[Address(RVA = "0x76D350", Offset = "0x76C150", Length = "0x5")]
	public void SetFirstPerson()
	{
	}

	[Token(Token = "0x6001BEB")]
	[Address(RVA = "0x76D360", Offset = "0x76C160", Length = "0x59D")]
	private void AddImageEffectsFromCamera(Camera destinationCamera, Camera sourceCamera)
	{
	}

	[Token(Token = "0x6001BEC")]
	[Address(RVA = "0x76D900", Offset = "0x76C700", Length = "0x3B7")]
	private void CopyDataFromSourceImageEffects()
	{
	}

	[Token(Token = "0x6001BED")]
	[Address(RVA = "0x76DCC0", Offset = "0x76CAC0", Length = "0x16F")]
	public CameraSyncPostFX()
	{
	}
}
