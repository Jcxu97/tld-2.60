using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.UI.Generics;
using UnityEngine;

[Token(Token = "0x2000592")]
public class InteractiveLightsource : MonoBehaviour
{
	[Token(Token = "0x4003354")]
	[FieldOffset(Offset = "0x20")]
	public LightSourceType m_LightType;

	[Token(Token = "0x4003355")]
	[FieldOffset(Offset = "0x28")]
	public LocalizedString m_LightPromptText;

	[Token(Token = "0x4003356")]
	[FieldOffset(Offset = "0x30")]
	public LocalizedString m_ExtinguishPromptText;

	[Token(Token = "0x4003357")]
	[FieldOffset(Offset = "0x38")]
	public LocalizedString m_StartingLightProgress;

	[Token(Token = "0x4003358")]
	[FieldOffset(Offset = "0x40")]
	public LocalizedString m_ExtinguishLightProgress;

	[Token(Token = "0x4003359")]
	[FieldOffset(Offset = "0x48")]
	public float m_StartFireRealTimeSeconds;

	[Token(Token = "0x400335A")]
	[FieldOffset(Offset = "0x4C")]
	public float m_StartFireGameTimeMinutes;

	[Token(Token = "0x400335B")]
	[FieldOffset(Offset = "0x50")]
	public float m_ExtinguishFireRealTimeSeconds;

	[Token(Token = "0x400335C")]
	[FieldOffset(Offset = "0x54")]
	public float m_ExtinguishFireGameTimeMinutes;

	[Token(Token = "0x400335D")]
	[FieldOffset(Offset = "0x58")]
	public List<InteractiveLightsource> m_LightsourceLinks;

	[Header("Panel References")]
	[SerializeField]
	[Token(Token = "0x400335E")]
	[FieldOffset(Offset = "0x60")]
	private PanelReference<Panel_HUD> m_HUD;

	[SerializeField]
	[Token(Token = "0x400335F")]
	[FieldOffset(Offset = "0x68")]
	private PanelReference<Panel_GenericProgressBar> m_ProgressBar;

	[Token(Token = "0x4003360")]
	private static List<InteractiveLightsource> s_LightsourceObjects;

	[Token(Token = "0x4003361")]
	[FieldOffset(Offset = "0x70")]
	public GameObject m_Light;

	[Token(Token = "0x4003362")]
	[FieldOffset(Offset = "0x78")]
	public bool m_IsOn;

	[Token(Token = "0x4003363")]
	[FieldOffset(Offset = "0x80")]
	private MissionIlluminationArea m_MissionIllumination;

	[Token(Token = "0x4003364")]
	[FieldOffset(Offset = "0x88")]
	private float m_MissionIlluminationOnRadius;

	[Token(Token = "0x6002AF6")]
	[Address(RVA = "0x910D00", Offset = "0x90FB00", Length = "0x14D")]
	private void Awake()
	{
	}

	[Token(Token = "0x6002AF7")]
	[Address(RVA = "0x910E50", Offset = "0x90FC50", Length = "0x93")]
	public static void Reset()
	{
	}

	[Token(Token = "0x6002AF8")]
	[Address(RVA = "0x910EF0", Offset = "0x90FCF0", Length = "0x82")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6002AF9")]
	[Address(RVA = "0x910F80", Offset = "0x90FD80", Length = "0x20F")]
	private void Start()
	{
	}

	[Token(Token = "0x6002AFA")]
	[Address(RVA = "0x911190", Offset = "0x90FF90", Length = "0x11F")]
	public void SetState(bool isOn)
	{
	}

	[Token(Token = "0x6002AFB")]
	[Address(RVA = "0x9112B0", Offset = "0x9100B0", Length = "0xD8")]
	public void InitializeInteraction()
	{
	}

	[Token(Token = "0x6002AFC")]
	[Address(RVA = "0x911390", Offset = "0x910190", Length = "0x21C")]
	public void PerformInteraction()
	{
	}

	[Token(Token = "0x6002AFD")]
	[Address(RVA = "0x9115B0", Offset = "0x9103B0", Length = "0x1C8")]
	public void OnInteractComplete(bool success, bool playerCancel, float progress)
	{
	}

	[Token(Token = "0x6002AFE")]
	[Address(RVA = "0x911780", Offset = "0x910580", Length = "0x74")]
	public void HideInteraction()
	{
	}

	[Token(Token = "0x6002AFF")]
	[Address(RVA = "0x911800", Offset = "0x910600", Length = "0x4DB")]
	public static string SerializeAll()
	{
		return null;
	}

	[Token(Token = "0x6002B00")]
	[Address(RVA = "0x911CE0", Offset = "0x910AE0", Length = "0x332")]
	public static void DeserializeAll(string text)
	{
	}

	[Token(Token = "0x6002B01")]
	[Address(RVA = "0x912020", Offset = "0x910E20", Length = "0x125")]
	private string Serialize()
	{
		return null;
	}

	[Token(Token = "0x6002B02")]
	[Address(RVA = "0x912150", Offset = "0x910F50", Length = "0x93")]
	private void Deserialize(string text)
	{
	}

	[Token(Token = "0x6002B03")]
	[Address(RVA = "0x9121F0", Offset = "0x910FF0", Length = "0x12A")]
	private static InteractiveLightsource FindLightsourceByGuid(string guid)
	{
		return null;
	}

	[Token(Token = "0x6002B04")]
	[Address(RVA = "0x912320", Offset = "0x911120", Length = "0x5F")]
	public InteractiveLightsource()
	{
	}
}
