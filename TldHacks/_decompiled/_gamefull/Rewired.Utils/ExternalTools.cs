using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Rewired.Utils.Interfaces;
using UnityEngine;

namespace Rewired.Utils;

[EditorBrowsable(EditorBrowsableState.Never)]
[Token(Token = "0x2000C06")]
public class ExternalTools : IExternalTools
{
	[Token(Token = "0x4007BA1")]
	private static Func<object> _getPlatformInitializerDelegate;

	[Token(Token = "0x4007BA2")]
	[FieldOffset(Offset = "0x10")]
	private bool _isEditorPaused;

	[Token(Token = "0x4007BA3")]
	[FieldOffset(Offset = "0x18")]
	private Action<bool> _EditorPausedStateChangedEvent;

	[Token(Token = "0x17000631")]
	public static Func<object> getPlatformInitializerDelegate
	{
		[Token(Token = "0x60060CC")]
		[Address(RVA = "0xF7BCB0", Offset = "0xF7AAB0", Length = "0x3B")]
		get
		{
			return null;
		}
		[Token(Token = "0x60060CD")]
		[Address(RVA = "0xF7BCF0", Offset = "0xF7AAF0", Length = "0x97")]
		set
		{
		}
	}

	[Token(Token = "0x17000632")]
	public bool isEditorPaused
	{
		[Token(Token = "0x60060D0")]
		[Address(RVA = "0x504260", Offset = "0x503060", Length = "0x5")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x17000633")]
	public bool UnityInput_IsTouchPressureSupported
	{
		[Token(Token = "0x60060E6")]
		[Address(RVA = "0xF7C910", Offset = "0xF7B710", Length = "0x45")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x1400001C")]
	public event Action<bool> EditorPausedStateChangedEvent
	{
		[Token(Token = "0x60060D1")]
		[Address(RVA = "0xF7BD90", Offset = "0xF7AB90", Length = "0xE6")]
		add
		{
		}
		[Token(Token = "0x60060D2")]
		[Address(RVA = "0xF7BE80", Offset = "0xF7AC80", Length = "0xE6")]
		remove
		{
		}
	}

	[Token(Token = "0x1400001D")]
	public event Action<uint, bool> XboxOneInput_OnGamepadStateChange
	{
		[CompilerGenerated]
		[Token(Token = "0x60060D7")]
		[Address(RVA = "0xF7C030", Offset = "0xF7AE30", Length = "0x166")]
		add
		{
		}
		[CompilerGenerated]
		[Token(Token = "0x60060D8")]
		[Address(RVA = "0xF7C1A0", Offset = "0xF7AFA0", Length = "0x166")]
		remove
		{
		}
	}

	[Token(Token = "0x60060CE")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public ExternalTools()
	{
	}

	[Token(Token = "0x60060CF")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public void Destroy()
	{
	}

	[Token(Token = "0x60060D3")]
	[Address(RVA = "0xF7BF70", Offset = "0xF7AD70", Length = "0xB7")]
	public object GetPlatformInitializer()
	{
		return null;
	}

	[Token(Token = "0x60060D4")]
	[Address(RVA = "0x60B830", Offset = "0x60A630", Length = "0x12")]
	public string GetFocusedEditorWindowTitle()
	{
		return null;
	}

	[Token(Token = "0x60060D5")]
	[Address(RVA = "0x4A2140", Offset = "0x4A0F40", Length = "0x3")]
	public bool IsEditorSceneViewFocused()
	{
		return false;
	}

	[Token(Token = "0x60060D6")]
	[Address(RVA = "0x4A2140", Offset = "0x4A0F40", Length = "0x3")]
	public bool LinuxInput_IsJoystickPreconfigured(string name)
	{
		return false;
	}

	[Token(Token = "0x60060D9")]
	[Address(RVA = "0x4582A0", Offset = "0x4570A0", Length = "0x3")]
	public int XboxOneInput_GetUserIdForGamepad(uint id)
	{
		return 0;
	}

	[Token(Token = "0x60060DA")]
	[Address(RVA = "0x4582A0", Offset = "0x4570A0", Length = "0x3")]
	public ulong XboxOneInput_GetControllerId(uint unityJoystickId)
	{
		return 0uL;
	}

	[Token(Token = "0x60060DB")]
	[Address(RVA = "0x4A2140", Offset = "0x4A0F40", Length = "0x3")]
	public bool XboxOneInput_IsGamepadActive(uint unityJoystickId)
	{
		return false;
	}

	[Token(Token = "0x60060DC")]
	[Address(RVA = "0x60B830", Offset = "0x60A630", Length = "0x12")]
	public string XboxOneInput_GetControllerType(ulong xboxControllerId)
	{
		return null;
	}

	[Token(Token = "0x60060DD")]
	[Address(RVA = "0x4582A0", Offset = "0x4570A0", Length = "0x3")]
	public uint XboxOneInput_GetJoystickId(ulong xboxControllerId)
	{
		return 0u;
	}

	[Token(Token = "0x60060DE")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public void XboxOne_Gamepad_UpdatePlugin()
	{
	}

	[Token(Token = "0x60060DF")]
	[Address(RVA = "0x4A2140", Offset = "0x4A0F40", Length = "0x3")]
	public bool XboxOne_Gamepad_SetGamepadVibration(ulong xboxOneJoystickId, float leftMotor, float rightMotor, float leftTriggerLevel, float rightTriggerLevel)
	{
		return false;
	}

	[Token(Token = "0x60060E0")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public void XboxOne_Gamepad_PulseVibrateMotor(ulong xboxOneJoystickId, int motorInt, float startLevel, float endLevel, ulong durationMS)
	{
	}

	[Token(Token = "0x60060E1")]
	[Address(RVA = "0xF7C310", Offset = "0xF7B110", Length = "0x13E")]
	public void GetDeviceVIDPIDs(out List<int> vids, out List<int> pids)
	{
		vids = null;
		pids = null;
	}

	[Token(Token = "0x60060E2")]
	[Address(RVA = "0xC7D4F0", Offset = "0xC7C2F0", Length = "0x6")]
	public int GetAndroidAPILevel()
	{
		return 0;
	}

	[Token(Token = "0x60060E3")]
	[Address(RVA = "0xF7C450", Offset = "0xF7B250", Length = "0x17C")]
	public void WindowsStandalone_ForwardRawInput(IntPtr rawInputHeaderIndices, IntPtr rawInputDataIndices, uint indicesCount, IntPtr rawInputData, uint rawInputDataSize)
	{
	}

	[Token(Token = "0x60060E4")]
	[Address(RVA = "0xF7C5D0", Offset = "0xF7B3D0", Length = "0x19D")]
	public bool UnityUI_Graphic_GetRaycastTarget(object graphic)
	{
		return false;
	}

	[Token(Token = "0x60060E5")]
	[Address(RVA = "0xF7C770", Offset = "0xF7B570", Length = "0x19A")]
	public void UnityUI_Graphic_SetRaycastTarget(object graphic, bool value)
	{
	}

	[Token(Token = "0x60060E7")]
	[Address(RVA = "0xF7C960", Offset = "0xF7B760", Length = "0x8")]
	public float UnityInput_GetTouchPressure(ref Touch touch)
	{
		return 0f;
	}

	[Token(Token = "0x60060E8")]
	[Address(RVA = "0xF7C970", Offset = "0xF7B770", Length = "0x8")]
	public float UnityInput_GetTouchMaximumPossiblePressure(ref Touch touch)
	{
		return 0f;
	}

	[Token(Token = "0x60060E9")]
	[Address(RVA = "0xF7C980", Offset = "0xF7B780", Length = "0x69")]
	public IControllerTemplate CreateControllerTemplate(Guid typeGuid, object payload)
	{
		return null;
	}

	[Token(Token = "0x60060EA")]
	[Address(RVA = "0xF7C9F0", Offset = "0xF7B7F0", Length = "0x93")]
	public Type[] GetControllerTemplateTypes()
	{
		return null;
	}

	[Token(Token = "0x60060EB")]
	[Address(RVA = "0xF7CA90", Offset = "0xF7B890", Length = "0x94")]
	public Type[] GetControllerTemplateInterfaceTypes()
	{
		return null;
	}
}
