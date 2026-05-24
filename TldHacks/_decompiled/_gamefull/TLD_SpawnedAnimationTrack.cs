using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

[Token(Token = "0x20009A2")]
public class TLD_SpawnedAnimationTrack : AnimationTrack, TLD_ITrack, TLD_IDynamicBindableTrack
{
	[Token(Token = "0x20009A3")]
	public enum LightProbeMode
	{
		[Token(Token = "0x40062DC")]
		Default,
		[Token(Token = "0x40062DD")]
		ForceOff,
		[Token(Token = "0x40062DE")]
		ForceOn
	}

	[Token(Token = "0x40062D3")]
	[FieldOffset(Offset = "0x130")]
	public GameObject m_PrefabObject;

	[Token(Token = "0x40062D4")]
	[FieldOffset(Offset = "0x138")]
	public bool m_KeepSpawnedObject;

	[Token(Token = "0x40062D5")]
	[FieldOffset(Offset = "0x140")]
	public string m_ParentId;

	[Token(Token = "0x40062D6")]
	[FieldOffset(Offset = "0x148")]
	public LightProbeMode m_LightProbeMode;

	[Token(Token = "0x40062D7")]
	[FieldOffset(Offset = "0x150")]
	protected GameObject m_RootObject;

	[Token(Token = "0x40062D8")]
	[FieldOffset(Offset = "0x158")]
	protected GameObject m_SpawnedObject;

	[Token(Token = "0x40062D9")]
	[FieldOffset(Offset = "0x160")]
	protected GameObject m_ParentGameObject;

	[Token(Token = "0x40062DA")]
	private static Dictionary<string, GameObject> m_SpawnedObjectMapping;

	[Token(Token = "0x60055D7")]
	[Address(RVA = "0xEA8EC0", Offset = "0xEA7CC0", Length = "0x32")]
	public void Play()
	{
	}

	[Token(Token = "0x60055D8")]
	[Address(RVA = "0xEA8F00", Offset = "0xEA7D00", Length = "0xF3")]
	public virtual void UpdatePlay()
	{
	}

	[Token(Token = "0x60055D9")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public void LateUpdatePlay()
	{
	}

	[Token(Token = "0x60055DA")]
	[Address(RVA = "0xEA9000", Offset = "0xEA7E00", Length = "0xBF")]
	public void Stop()
	{
	}

	[Token(Token = "0x60055DB")]
	[Address(RVA = "0xEA90C0", Offset = "0xEA7EC0", Length = "0x1C4")]
	public void DoDynamicBinding(PlayableDirector director)
	{
	}

	[Token(Token = "0x60055DC")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	protected virtual void PlayInternal()
	{
	}

	[Token(Token = "0x60055DD")]
	[Address(RVA = "0xEA9290", Offset = "0xEA8090", Length = "0x443")]
	protected virtual void UpdateSpawnedObjectRootTransformAndParent()
	{
	}

	[Token(Token = "0x60055DE")]
	[Address(RVA = "0xEA96E0", Offset = "0xEA84E0", Length = "0x58E")]
	public virtual GameObject SpawnObject()
	{
		return null;
	}

	[Token(Token = "0x60055DF")]
	[Address(RVA = "0xEA9C70", Offset = "0xEA8A70", Length = "0x310")]
	public void DeleteSpawnedObject()
	{
	}

	[Token(Token = "0x60055E0")]
	[Address(RVA = "0xEA9F90", Offset = "0xEA8D90", Length = "0xCD")]
	public bool HasSpawned()
	{
		return false;
	}

	[Token(Token = "0x60055E1")]
	[Address(RVA = "0xEAA060", Offset = "0xEA8E60", Length = "0xF7")]
	public void Activate(bool enabled)
	{
	}

	[Token(Token = "0x60055E2")]
	[Address(RVA = "0xEAA160", Offset = "0xEA8F60", Length = "0xF5")]
	public GameObject GetSpawnedObject()
	{
		return null;
	}

	[Token(Token = "0x60055E3")]
	[Address(RVA = "0xEAA260", Offset = "0xEA9060", Length = "0x20B")]
	private void MaybeApplyRendererSettings()
	{
	}

	[Token(Token = "0x60055E4")]
	[Address(RVA = "0xEAA470", Offset = "0xEA9270", Length = "0x4E")]
	public TLD_SpawnedAnimationTrack()
	{
	}
}
