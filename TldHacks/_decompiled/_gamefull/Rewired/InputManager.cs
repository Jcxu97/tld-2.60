using System.ComponentModel;
using Cpp2ILInjected;
using Rewired.Utils.Interfaces;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Rewired;

[AddComponentMenu("Rewired/Input Manager")]
[EditorBrowsable(EditorBrowsableState.Never)]
[Token(Token = "0x2000C01")]
public sealed class InputManager : InputManager_Base
{
	[Token(Token = "0x4007B87")]
	[FieldOffset(Offset = "0x58")]
	private bool ignoreRecompile;

	[Token(Token = "0x6006073")]
	[Address(RVA = "0xF79A50", Offset = "0xF78850", Length = "0xA4")]
	protected override void OnInitialized()
	{
	}

	[Token(Token = "0x6006074")]
	[Address(RVA = "0xF79B00", Offset = "0xF78900", Length = "0x7")]
	protected override void OnDeinitialized()
	{
	}

	[Token(Token = "0x6006075")]
	[Address(RVA = "0xF79B10", Offset = "0xF78910", Length = "0x42")]
	protected override void DetectPlatform()
	{
	}

	[Token(Token = "0x6006076")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	protected override void CheckRecompile()
	{
	}

	[Token(Token = "0x6006077")]
	[Address(RVA = "0xF79B60", Offset = "0xF78960", Length = "0x35")]
	protected override IExternalTools GetExternalTools()
	{
		return null;
	}

	[Token(Token = "0x6006078")]
	[Address(RVA = "0xF79BA0", Offset = "0xF789A0", Length = "0xAC")]
	private bool CheckDeviceName(string searchPattern, string deviceName, string deviceModel)
	{
		return false;
	}

	[Token(Token = "0x6006079")]
	[Address(RVA = "0xF79A50", Offset = "0xF78850", Length = "0xA4")]
	private void SubscribeEvents()
	{
	}

	[Token(Token = "0x600607A")]
	[Address(RVA = "0xF79C50", Offset = "0xF78A50", Length = "0x9A")]
	private void UnsubscribeEvents()
	{
	}

	[Token(Token = "0x600607B")]
	[Address(RVA = "0xF79CF0", Offset = "0xF78AF0", Length = "0xA9")]
	private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
	{
	}

	[Token(Token = "0x600607C")]
	[Address(RVA = "0xF79DA0", Offset = "0xF78BA0", Length = "0xE9")]
	public InputManager()
	{
	}
}
