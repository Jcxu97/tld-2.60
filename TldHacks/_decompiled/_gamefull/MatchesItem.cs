using AK.Wwise;
using Cpp2ILInjected;
using TLD.UI.Generics;
using UnityEngine;

[Token(Token = "0x20004BE")]
public class MatchesItem : MonoBehaviour
{
	[Token(Token = "0x4002B8B")]
	[FieldOffset(Offset = "0x20")]
	public float m_MinBurnTimeGametimeSeconds;

	[Token(Token = "0x4002B8C")]
	[FieldOffset(Offset = "0x24")]
	public float m_MaxBurnTimeGametimeSeconds;

	[Token(Token = "0x4002B8D")]
	[FieldOffset(Offset = "0x28")]
	public float m_BlowOutWindSpeedMPH;

	[Token(Token = "0x4002B8E")]
	[FieldOffset(Offset = "0x2C")]
	public float m_IgniteDelaySeconds;

	[Token(Token = "0x4002B8F")]
	[FieldOffset(Offset = "0x30")]
	public MatchesType m_MatchesType;

	[Header("Audio")]
	[SerializeField]
	[Token(Token = "0x4002B90")]
	[FieldOffset(Offset = "0x38")]
	private AK.Wwise.Event m_IgniteAudioEvent;

	[SerializeField]
	[Token(Token = "0x4002B91")]
	[FieldOffset(Offset = "0x40")]
	private AK.Wwise.Event m_BurnOutAudioEvent;

	[Header("Panel References")]
	[SerializeField]
	[Token(Token = "0x4002B92")]
	[FieldOffset(Offset = "0x48")]
	private PanelReference<Panel_HUD> m_HUD;

	[SerializeField]
	[Token(Token = "0x4002B93")]
	[FieldOffset(Offset = "0x50")]
	private PanelReference<Panel_FireStart> m_FireStartPanel;

	[Token(Token = "0x4002B94")]
	[FieldOffset(Offset = "0x58")]
	private float m_BurnTimeGametimeSeconds;

	[Token(Token = "0x4002B95")]
	[FieldOffset(Offset = "0x5C")]
	private float m_ElapsedBurnGametimeSeconds;

	[Token(Token = "0x4002B96")]
	[FieldOffset(Offset = "0x60")]
	private bool m_Ignited;

	[Token(Token = "0x4002B97")]
	[FieldOffset(Offset = "0x68")]
	private StackableItem m_StackableItem;

	[Token(Token = "0x4002B98")]
	[FieldOffset(Offset = "0x70")]
	private bool m_IgniteAfterDelay;

	[Token(Token = "0x4002B99")]
	[FieldOffset(Offset = "0x74")]
	private float m_ElapsedIgniteDelaySeconds;

	[Token(Token = "0x4002B9A")]
	[FieldOffset(Offset = "0x78")]
	private Transform m_FXTransform;

	[Token(Token = "0x4002B9B")]
	[FieldOffset(Offset = "0x80")]
	private GearItem m_GearItem;

	[Token(Token = "0x4002B9C")]
	[FieldOffset(Offset = "0x88")]
	private bool m_IsFresh;

	[Token(Token = "0x4002B9D")]
	[FieldOffset(Offset = "0x89")]
	private bool m_DestroyNextFrame;

	[Token(Token = "0x4002B9E")]
	[FieldOffset(Offset = "0x8A")]
	private bool m_TryEquipNext;

	[Token(Token = "0x4002B9F")]
	private static readonly MatchesItemSaveDataProxy m_MatchesItemSaveDataProxy;

	[Token(Token = "0x4002BA0")]
	[FieldOffset(Offset = "0x90")]
	private GearItem m_ClonedStack;

	[Token(Token = "0x6002428")]
	[Address(RVA = "0x862C10", Offset = "0x861A10", Length = "0x12E")]
	private void Awake()
	{
	}

	[Token(Token = "0x6002429")]
	[Address(RVA = "0x862D40", Offset = "0x861B40", Length = "0x8")]
	public void OnEquip()
	{
	}

	[Token(Token = "0x600242A")]
	[Address(RVA = "0x862D50", Offset = "0x861B50", Length = "0x313")]
	public void UpdateWhileInHands()
	{
	}

	[Token(Token = "0x600242B")]
	[Address(RVA = "0x863070", Offset = "0x861E70", Length = "0x144")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x600242C")]
	[Address(RVA = "0x8631C0", Offset = "0x861FC0", Length = "0x121")]
	public void Deserialize(string text)
	{
	}

	[Token(Token = "0x600242D")]
	[Address(RVA = "0x8632F0", Offset = "0x8620F0", Length = "0x2A1")]
	public void IgniteDelayed()
	{
	}

	[Token(Token = "0x600242E")]
	[Address(RVA = "0x8635A0", Offset = "0x8623A0", Length = "0x266")]
	public void IgniteAfterDelay()
	{
	}

	[Token(Token = "0x600242F")]
	[Address(RVA = "0x863810", Offset = "0x862610", Length = "0x338")]
	public void Ignite()
	{
	}

	[Token(Token = "0x6002430")]
	[Address(RVA = "0x863B50", Offset = "0x862950", Length = "0x1AE")]
	public void ClearClonedStack()
	{
	}

	[Token(Token = "0x6002431")]
	[Address(RVA = "0x863D00", Offset = "0x862B00", Length = "0xA8")]
	public void CancelIgnite()
	{
	}

	[Token(Token = "0x6002432")]
	[Address(RVA = "0x863DB0", Offset = "0x862BB0", Length = "0x6B")]
	public void PutoutMatch(bool destroyImmediately, bool tryEquipNext)
	{
	}

	[Token(Token = "0x6002433")]
	[Address(RVA = "0x863E20", Offset = "0x862C20", Length = "0x228")]
	private void PutOut(bool burntOut)
	{
	}

	[Token(Token = "0x6002434")]
	[Address(RVA = "0x864050", Offset = "0x862E50", Length = "0x5")]
	public bool IsBurning()
	{
		return false;
	}

	[Token(Token = "0x6002435")]
	[Address(RVA = "0x502340", Offset = "0x501140", Length = "0x8")]
	public bool IsFresh()
	{
		return false;
	}

	[Token(Token = "0x6002436")]
	[Address(RVA = "0x864060", Offset = "0x862E60", Length = "0x27")]
	public float GetBurnProgress()
	{
		return 0f;
	}

	[Token(Token = "0x6002437")]
	[Address(RVA = "0x864090", Offset = "0x862E90", Length = "0x15F")]
	private void OnIgniteCompleteCallback()
	{
	}

	[Token(Token = "0x6002438")]
	[Address(RVA = "0x8641F0", Offset = "0x862FF0", Length = "0x422")]
	private void UpdateFXTransform(float percentComplete)
	{
	}

	[Token(Token = "0x6002439")]
	[Address(RVA = "0x864620", Offset = "0x863420", Length = "0x1D5")]
	private void DestroyAndUnequip(bool tryEquipNext)
	{
	}

	[Token(Token = "0x600243A")]
	[Address(RVA = "0x7BDEB0", Offset = "0x7BCCB0", Length = "0x4A")]
	public MatchesItem()
	{
	}
}
