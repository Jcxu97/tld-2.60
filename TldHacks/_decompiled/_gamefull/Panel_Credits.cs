using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.UI;
using UnityEngine;

[Token(Token = "0x200063B")]
public class Panel_Credits : Panel_AutoReferenced
{
	[Token(Token = "0x200063C")]
	public enum CreditType
	{
		[Token(Token = "0x4003BBA")]
		Undefined,
		[Token(Token = "0x4003BBB")]
		Sprite,
		[Token(Token = "0x4003BBC")]
		Header1,
		[Token(Token = "0x4003BBD")]
		Header2,
		[Token(Token = "0x4003BBE")]
		TitledName,
		[Token(Token = "0x4003BBF")]
		Name,
		[Token(Token = "0x4003BC0")]
		CenteredTitle,
		[Token(Token = "0x4003BC1")]
		CenteredName,
		[Token(Token = "0x4003BC2")]
		CenteredSubName,
		[Token(Token = "0x4003BC3")]
		Message,
		[Token(Token = "0x4003BC4")]
		Space,
		[Token(Token = "0x4003BC5")]
		Texture,
		[Token(Token = "0x4003BC6")]
		Headline
	}

	[Serializable]
	[Token(Token = "0x200063D")]
	private class AtlasReference
	{
		[Token(Token = "0x4003BC7")]
		[FieldOffset(Offset = "0x10")]
		public string m_Id;

		[Token(Token = "0x4003BC8")]
		[FieldOffset(Offset = "0x18")]
		public UIAtlas m_Atlas;

		[Token(Token = "0x6003249")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public AtlasReference()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x200063E")]
	private class TextureReference
	{
		[Token(Token = "0x4003BC9")]
		[FieldOffset(Offset = "0x10")]
		public string m_Id;

		[Token(Token = "0x4003BCA")]
		[FieldOffset(Offset = "0x18")]
		public Texture2D m_Texture;

		[Token(Token = "0x600324A")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public TextureReference()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x200063F")]
	private class CreditTypePrefabMap
	{
		[Token(Token = "0x4003BCB")]
		[FieldOffset(Offset = "0x10")]
		public CreditType m_Type;

		[Token(Token = "0x4003BCC")]
		[FieldOffset(Offset = "0x18")]
		public CreditElement m_Prefab;

		[Token(Token = "0x600324B")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public CreditTypePrefabMap()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000640")]
	private class EpisodeDefinition
	{
		[Token(Token = "0x4003BCD")]
		[FieldOffset(Offset = "0x10")]
		public TextAsset m_CreditsSource;

		[Token(Token = "0x4003BCE")]
		[FieldOffset(Offset = "0x18")]
		public string m_MusicID;

		[Token(Token = "0x4003BCF")]
		[FieldOffset(Offset = "0x20")]
		public GameObject m_BackgroundElementGroup;

		[Token(Token = "0x4003BD0")]
		[FieldOffset(Offset = "0x28")]
		public float m_FadeInDuration;

		[Token(Token = "0x4003BD1")]
		[FieldOffset(Offset = "0x2C")]
		public float m_ElementsFadeInDuration;

		[Token(Token = "0x4003BD2")]
		[FieldOffset(Offset = "0x30")]
		public float m_ElementsFadeInDelay;

		[Token(Token = "0x4003BD3")]
		[FieldOffset(Offset = "0x34")]
		public float m_InitialScrollOffset;

		[Token(Token = "0x4003BD4")]
		[FieldOffset(Offset = "0x38")]
		public int m_ScrollSpeed;

		[Token(Token = "0x4003BD5")]
		[FieldOffset(Offset = "0x3C")]
		public float m_ScrollDelay;

		[Token(Token = "0x4003BD6")]
		[FieldOffset(Offset = "0x40")]
		public float m_EndPadding;

		[NonSerialized]
		[Token(Token = "0x4003BD7")]
		[FieldOffset(Offset = "0x48")]
		public List<LineDefinition> m_Lines;

		[NonSerialized]
		[Token(Token = "0x4003BD8")]
		[FieldOffset(Offset = "0x50")]
		public float m_FinalYOffset;

		[Token(Token = "0x4003BD9")]
		private const int MAX_CONTENT_SIZE = 4;

		[Token(Token = "0x600324C")]
		[Address(RVA = "0x9E7670", Offset = "0x9E6470", Length = "0x12")]
		public float GetEndScrollValue()
		{
			return 0f;
		}

		[Token(Token = "0x600324D")]
		[Address(RVA = "0x9E7690", Offset = "0x9E6490", Length = "0x9")]
		public bool HasLines()
		{
			return false;
		}

		[Token(Token = "0x600324E")]
		[Address(RVA = "0x9E76A0", Offset = "0x9E64A0", Length = "0x321")]
		public void BuildLines()
		{
		}

		[Token(Token = "0x600324F")]
		[Address(RVA = "0x9E79D0", Offset = "0x9E67D0", Length = "0x2B")]
		public EpisodeDefinition()
		{
		}
	}

	[Token(Token = "0x2000641")]
	private class LineDefinition
	{
		[Token(Token = "0x4003BDA")]
		[FieldOffset(Offset = "0x10")]
		public CreditType m_CreditType;

		[Token(Token = "0x4003BDB")]
		[FieldOffset(Offset = "0x18")]
		public string[] m_Content;

		[Token(Token = "0x4003BDC")]
		[FieldOffset(Offset = "0x20")]
		private bool m_IsEmpty;

		[Token(Token = "0x6003250")]
		[Address(RVA = "0x9E7A00", Offset = "0x9E6800", Length = "0x186")]
		public LineDefinition(BetterList<string> line, int contentSize)
		{
		}

		[Token(Token = "0x6003251")]
		[Address(RVA = "0x4D3E60", Offset = "0x4D2C60", Length = "0x5")]
		public bool IsEmpty()
		{
			return false;
		}
	}

	[Token(Token = "0x2000642")]
	private enum PanelState
	{
		[Token(Token = "0x4003BDE")]
		FadingInPanel,
		[Token(Token = "0x4003BDF")]
		StartingMusic,
		[Token(Token = "0x4003BE0")]
		FadingInElements,
		[Token(Token = "0x4003BE1")]
		Playing,
		[Token(Token = "0x4003BE2")]
		Ending
	}

	[SerializeField]
	[Token(Token = "0x4003B9D")]
	[FieldOffset(Offset = "0x30")]
	private EpisodeDefinition[] m_EpisodeDefinitions;

	[SerializeField]
	[Token(Token = "0x4003B9E")]
	[FieldOffset(Offset = "0x38")]
	private CreditTypePrefabMap[] m_CreditTypePrefabs;

	[SerializeField]
	[Token(Token = "0x4003B9F")]
	[FieldOffset(Offset = "0x40")]
	private AtlasReference[] m_AtlasReferences;

	[SerializeField]
	[Token(Token = "0x4003BA0")]
	[FieldOffset(Offset = "0x48")]
	private TextureReference[] m_TextureReferences;

	[SerializeField]
	[Token(Token = "0x4003BA1")]
	[FieldOffset(Offset = "0x50")]
	private Transform m_ScrollArea;

	[SerializeField]
	[Token(Token = "0x4003BA2")]
	[FieldOffset(Offset = "0x58")]
	private float m_ScrollSmoothingTime;

	[SerializeField]
	[Token(Token = "0x4003BA3")]
	[FieldOffset(Offset = "0x5C")]
	private float m_FastScrollMultiplier;

	[SerializeField]
	[Token(Token = "0x4003BA4")]
	[FieldOffset(Offset = "0x60")]
	private UIPanel m_MainPanel;

	[SerializeField]
	[Token(Token = "0x4003BA5")]
	[FieldOffset(Offset = "0x68")]
	private UIPanel m_CreditTextPanel;

	[SerializeField]
	[Token(Token = "0x4003BA6")]
	[FieldOffset(Offset = "0x70")]
	private Camera m_BackgroundRenderCamera;

	[SerializeField]
	[Token(Token = "0x4003BA7")]
	[FieldOffset(Offset = "0x78")]
	private UITexture m_BackgroundRenderer;

	[SerializeField]
	[Token(Token = "0x4003BA8")]
	[FieldOffset(Offset = "0x80")]
	private Vector2 m_MaxBackgroundRenderTextureSize;

	[Token(Token = "0x4003BA9")]
	[FieldOffset(Offset = "0x88")]
	private uint m_MusicPlayingID;

	[Token(Token = "0x4003BAA")]
	[FieldOffset(Offset = "0x90")]
	private string m_ForcedMusicID;

	[Token(Token = "0x4003BAB")]
	[FieldOffset(Offset = "0x98")]
	private int m_MusicStartOffsetMs;

	[Token(Token = "0x4003BAC")]
	[FieldOffset(Offset = "0x9C")]
	private PanelState m_PanelState;

	[Token(Token = "0x4003BAD")]
	[FieldOffset(Offset = "0xA0")]
	private float m_ElementsStartTime;

	[Token(Token = "0x4003BAE")]
	[FieldOffset(Offset = "0xA4")]
	private bool m_SkipFadeIn;

	[Token(Token = "0x4003BAF")]
	[FieldOffset(Offset = "0xA8")]
	private float m_FadeInAmount;

	[Token(Token = "0x4003BB0")]
	[FieldOffset(Offset = "0xAC")]
	private float m_ElementsFadeInAmount;

	[Token(Token = "0x4003BB1")]
	[FieldOffset(Offset = "0xB0")]
	private float m_ScrollStartTime;

	[Token(Token = "0x4003BB2")]
	[FieldOffset(Offset = "0xB4")]
	private float m_ScrollVelocity;

	[Token(Token = "0x4003BB3")]
	[FieldOffset(Offset = "0xB8")]
	private float m_CurrentScrollSpeed;

	[Token(Token = "0x4003BB4")]
	[FieldOffset(Offset = "0xBC")]
	private float m_ScrollMultiplier;

	[Token(Token = "0x4003BB5")]
	[FieldOffset(Offset = "0xC0")]
	private EpisodeDefinition m_ActiveEpisode;

	[Token(Token = "0x4003BB6")]
	[FieldOffset(Offset = "0xC8")]
	private Action m_FadedInAction;

	[Token(Token = "0x4003BB7")]
	[FieldOffset(Offset = "0xD0")]
	private Action m_ExitAction;

	[Token(Token = "0x4003BB8")]
	[FieldOffset(Offset = "0xD8")]
	private RenderTexture m_BackgroundRenderTexture;

	[Token(Token = "0x170002EE")]
	public override bool RenderGameCamera
	{
		[Token(Token = "0x6003232")]
		[Address(RVA = "0x9E4D70", Offset = "0x9E3B70", Length = "0x14")]
		get
		{
			return false;
		}
	}

	[Token(Token = "0x6003233")]
	[Address(RVA = "0x9E4D90", Offset = "0x9E3B90", Length = "0x2EF")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6003234")]
	[Address(RVA = "0x9E5080", Offset = "0x9E3E80", Length = "0x281")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6003235")]
	[Address(RVA = "0x9E5310", Offset = "0x9E4110", Length = "0xB1")]
	public void ShowCredits(int episodeIndex, string forcedMusicID, int musicStartOffsetMs, uint musicPlayingID, bool skipFadeIn, Action fadedInAction, Action exitAction)
	{
	}

	[Token(Token = "0x6003236")]
	[Address(RVA = "0x9E53D0", Offset = "0x9E41D0", Length = "0x1C8")]
	public void ShowCredits(int episodeIndex, Action fadedInAction, Action exitAction)
	{
	}

	[Token(Token = "0x6003237")]
	[Address(RVA = "0x9E55A0", Offset = "0x9E43A0", Length = "0x12")]
	public bool IsFullyActive()
	{
		return false;
	}

	[Token(Token = "0x6003238")]
	[Address(RVA = "0x9E55C0", Offset = "0x9E43C0", Length = "0x563")]
	private void Update()
	{
	}

	[Token(Token = "0x6003239")]
	[Address(RVA = "0x9E5B30", Offset = "0x9E4930", Length = "0x67")]
	private void FadeInPanel(float panelFadeInDuration)
	{
	}

	[Token(Token = "0x600323A")]
	[Address(RVA = "0x9E5BA0", Offset = "0x9E49A0", Length = "0x12B")]
	private void FadeInElements()
	{
	}

	[Token(Token = "0x600323B")]
	[Address(RVA = "0x9E5CD0", Offset = "0x9E4AD0", Length = "0x2A4")]
	private void FadeIn(UIPanel panel, PanelState nextState, float startTime, float fadeInDuration, ref float fadeInAmount, ref float nextStateStartTime, Action onComplete)
	{
	}

	[Token(Token = "0x600323C")]
	[Address(RVA = "0x9E5F80", Offset = "0x9E4D80", Length = "0x13B")]
	private void StartMusic()
	{
	}

	[Token(Token = "0x600323D")]
	[Address(RVA = "0x9E60C0", Offset = "0x9E4EC0", Length = "0xFF")]
	private void EnableBackgroundElementsGroup()
	{
	}

	[Token(Token = "0x600323E")]
	[Address(RVA = "0x9E61C0", Offset = "0x9E4FC0", Length = "0x344")]
	private void Play()
	{
	}

	[Token(Token = "0x600323F")]
	[Address(RVA = "0x9E6510", Offset = "0x9E5310", Length = "0xB8")]
	public UIAtlas GetAtlasById(string id)
	{
		return null;
	}

	[Token(Token = "0x6003240")]
	[Address(RVA = "0x9E65D0", Offset = "0x9E53D0", Length = "0xAF")]
	public Texture2D GetTextureById(string id)
	{
		return null;
	}

	[Token(Token = "0x6003241")]
	[Address(RVA = "0x4A2140", Offset = "0x4A0F40", Length = "0x3")]
	private bool IsEditingPrefab()
	{
		return false;
	}

	[Token(Token = "0x6003242")]
	[Address(RVA = "0x9E6680", Offset = "0x9E5480", Length = "0xD2")]
	private void Exit()
	{
	}

	[Token(Token = "0x6003243")]
	[Address(RVA = "0x9E6760", Offset = "0x9E5560", Length = "0x5E")]
	private void StopMusic()
	{
	}

	[Token(Token = "0x6003244")]
	[Address(RVA = "0x9E67C0", Offset = "0x9E55C0", Length = "0x50")]
	private CreditElement GetCreditElementPrefab(CreditType creditType)
	{
		return null;
	}

	[Token(Token = "0x6003245")]
	[Address(RVA = "0x9E6820", Offset = "0x9E5620", Length = "0x9E")]
	private void SetActiveEpisode(EpisodeDefinition episodeDefinition)
	{
	}

	[Token(Token = "0x6003246")]
	[Address(RVA = "0x9E68C0", Offset = "0x9E56C0", Length = "0x7D0")]
	private void Reset()
	{
	}

	[Token(Token = "0x6003247")]
	[Address(RVA = "0x9E70A0", Offset = "0x9E5EA0", Length = "0x559")]
	private void BuildCreditElements(EpisodeDefinition episode)
	{
	}

	[Token(Token = "0x6003248")]
	[Address(RVA = "0x9E7600", Offset = "0x9E6400", Length = "0x6F")]
	public Panel_Credits()
	{
	}
}
