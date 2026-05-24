using System;
using System.Collections.Generic;
using AK.Wwise;
using Cpp2ILInjected;
using TLD.Audio.Migration;
using UnityEngine;

[Token(Token = "0x20007D7")]
public class SceneMusicManager : MonoBehaviour
{
	[Token(Token = "0x4005415")]
	public static SceneMusicManager instance;

	[AudioEventMigratedString("m_SceneEnterMusic")]
	[Token(Token = "0x4005416")]
	[FieldOffset(Offset = "0x20")]
	public AK.Wwise.Event m_SceneEnterMusicEvent;

	[SerializeField]
	[HideInInspector]
	[Obsolete]
	[Token(Token = "0x4005417")]
	[FieldOffset(Offset = "0x28")]
	private string m_SceneEnterMusic;

	[Tooltip("If unchecked, the scene enter music will only play the first time the player discovers that scene")]
	[Token(Token = "0x4005418")]
	[FieldOffset(Offset = "0x30")]
	public bool m_PlaySceneEnterEveryTime;

	[Token(Token = "0x4005419")]
	[FieldOffset(Offset = "0x34")]
	public float m_DelaySecondsSceneEnterMusic;

	[Token(Token = "0x400541A")]
	[FieldOffset(Offset = "0x38")]
	public ExploreMusic[] m_SceneExploreMusic;

	[Token(Token = "0x400541B")]
	[FieldOffset(Offset = "0x40")]
	public float m_MinSecondsBetweenExploreMusic;

	[Token(Token = "0x400541C")]
	[FieldOffset(Offset = "0x44")]
	public float m_MaxSecondsBetweenExploreMusic;

	[Token(Token = "0x400541D")]
	[FieldOffset(Offset = "0x48")]
	private bool m_HasBeenPlayed;

	[Token(Token = "0x400541E")]
	[FieldOffset(Offset = "0x4C")]
	private float m_TimeToPlayNextExploreMusic;

	[Token(Token = "0x400541F")]
	[FieldOffset(Offset = "0x50")]
	private float m_TimeToPlaySceneEnterMusic;

	[Token(Token = "0x4005420")]
	[FieldOffset(Offset = "0x58")]
	private List<AK.Wwise.Event> m_ExploreMusicDay;

	[Token(Token = "0x4005421")]
	[FieldOffset(Offset = "0x60")]
	private List<AK.Wwise.Event> m_ExploreMusicNight;

	[Token(Token = "0x4005422")]
	[FieldOffset(Offset = "0x68")]
	private List<AK.Wwise.Event> m_ExploreMusicAurora;

	[Token(Token = "0x4005423")]
	[FieldOffset(Offset = "0x70")]
	private List<MusicSuppressor> m_MusicSuppressors;

	[Token(Token = "0x4005424")]
	[FieldOffset(Offset = "0x78")]
	private bool m_MusicSuppressorInRange;

	[Token(Token = "0x4005425")]
	[FieldOffset(Offset = "0x79")]
	public bool m_SupressExploreMusic;

	[Token(Token = "0x4005426")]
	private static SceneMusicSaveData m_SceneMusicSaveData;

	[Token(Token = "0x6004A14")]
	[Address(RVA = "0xD2D770", Offset = "0xD2C570", Length = "0x461")]
	private void Awake()
	{
	}

	[Token(Token = "0x6004A15")]
	[Address(RVA = "0xD2DBE0", Offset = "0xD2C9E0", Length = "0xA6")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6004A16")]
	[Address(RVA = "0xD2DC90", Offset = "0xD2CA90", Length = "0x5A4")]
	private void Update()
	{
	}

	[Token(Token = "0x6004A17")]
	[Address(RVA = "0xD2E240", Offset = "0xD2D040", Length = "0x104")]
	public string Serialize()
	{
		return null;
	}

	[Token(Token = "0x6004A18")]
	[Address(RVA = "0xD2E350", Offset = "0xD2D150", Length = "0x94")]
	public void Deserialize(string text)
	{
	}

	[Token(Token = "0x6004A19")]
	[Address(RVA = "0xD2E3F0", Offset = "0xD2D1F0", Length = "0xBF")]
	public void AddMusicSuppressor(MusicSuppressor ms)
	{
	}

	[Token(Token = "0x6004A1A")]
	[Address(RVA = "0xD2E4B0", Offset = "0xD2D2B0", Length = "0xCE")]
	public void PlaySceneEnterMusic()
	{
	}

	[Token(Token = "0x6004A1B")]
	[Address(RVA = "0xD2E580", Offset = "0xD2D380", Length = "0x1D3")]
	public void PlayExploreMusic()
	{
	}

	[Token(Token = "0x6004A1C")]
	[Address(RVA = "0xD2E760", Offset = "0xD2D560", Length = "0x7F")]
	public void RemoveMusicSuppressor(MusicSuppressor ms)
	{
	}

	[Token(Token = "0x6004A1D")]
	[Address(RVA = "0xD2E7E0", Offset = "0xD2D5E0", Length = "0x73")]
	public void ResetExploreMusicTimer()
	{
	}

	[Token(Token = "0x6004A1E")]
	[Address(RVA = "0xD2E860", Offset = "0xD2D660", Length = "0xE3")]
	public SceneMusicManager()
	{
	}
}
