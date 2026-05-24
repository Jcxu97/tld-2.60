using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.Logging;
using TLD.Utility;
using UnityEngine;

namespace TLD.Scenes.ObjectReferences;

[Token(Token = "0x200136A")]
public class SceneObjectReference : ScriptableObject
{
	[Token(Token = "0x200136B")]
	public delegate void SceneObjectReferenceNotificationDelegate(SceneObjectReference sender, GameObject owner);

	[Token(Token = "0x4008ED7")]
	public static readonly LogFilter LogFilter;

	[SerializeField]
	[EditorReadOnly]
	[Token(Token = "0x4008ED8")]
	[FieldOffset(Offset = "0x18")]
	private string m_SceneName;

	[SerializeField]
	[EditorReadOnly]
	[Token(Token = "0x4008ED9")]
	[FieldOffset(Offset = "0x20")]
	private string m_ObjectPath;

	[Token(Token = "0x4008EDA")]
	[FieldOffset(Offset = "0x28")]
	private GameObject m_ownerObject;

	[Token(Token = "0x4008EDB")]
	[FieldOffset(Offset = "0x30")]
	private readonly List<SceneObjectReferenceNotificationDelegate> m_notifyOnAvailable;

	[Token(Token = "0x17000A73")]
	public string SceneName
	{
		[Token(Token = "0x6007C02")]
		[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A74")]
	public string ObjectPath
	{
		[Token(Token = "0x6007C03")]
		[Address(RVA = "0x40E110", Offset = "0x40CF10", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A75")]
	public GameObject Owner
	{
		[Token(Token = "0x6007C06")]
		[Address(RVA = "0x413AB0", Offset = "0x4128B0", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1400003F")]
	public event SceneObjectReferenceNotificationDelegate OnAvailable
	{
		[Token(Token = "0x6007C04")]
		[Address(RVA = "0x11AE880", Offset = "0x11AD680", Length = "0x104")]
		add
		{
		}
		[Token(Token = "0x6007C05")]
		[Address(RVA = "0x11AE990", Offset = "0x11AD790", Length = "0x58")]
		remove
		{
		}
	}

	[Token(Token = "0x6007C07")]
	[Address(RVA = "0x11AE9F0", Offset = "0x11AD7F0", Length = "0x114")]
	public void SetOwner(GameObject gameObject)
	{
	}

	[Token(Token = "0x6007C08")]
	[Address(RVA = "0x11AEB10", Offset = "0x11AD910", Length = "0x64")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6007C09")]
	[Address(RVA = "0x11AEB80", Offset = "0x11AD980", Length = "0xB0")]
	private void NotifyAvailable()
	{
	}

	[Token(Token = "0x6007C0A")]
	[Address(RVA = "0x11AEC40", Offset = "0x11ADA40", Length = "0xB6")]
	public SceneObjectReference()
	{
	}
}
