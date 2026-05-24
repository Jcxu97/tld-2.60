using System.Collections.Generic;
using Cpp2ILInjected;
using TLD.Gameplay;
using UnityEngine;

namespace TLD;

[CreateAssetMenu(fileName = "FaithfulCartographerSO", menuName = "Scriptable Objects/FaithfulCartographer", order = 10003)]
[Token(Token = "0x2001341")]
public class FaithfulCartographerSO : ScriptableObject
{
	[Tooltip("Adjust these totals to match current expectations. These values will be used to verify generated CartographyAchievementsByRegion totals.")]
	[Token(Token = "0x4008E04")]
	[FieldOffset(Offset = "0x18")]
	public List<SceneSetCount> m_CrosscheckAchievementsByRegion;

	[Tooltip("These values are generated totals and will be checked against preset CrosscheckAchievementsByRegion totals.")]
	[Token(Token = "0x4008E05")]
	[FieldOffset(Offset = "0x20")]
	public List<CartographyAchievementRegion> m_CartographyAchievementsByRegion;

	[Token(Token = "0x4008E06")]
	[FieldOffset(Offset = "0x28")]
	public SandboxConfig m_Pilgrim;

	[Token(Token = "0x4008E07")]
	[FieldOffset(Offset = "0x30")]
	public SandboxConfig m_Voyageur;

	[Token(Token = "0x4008E08")]
	[FieldOffset(Offset = "0x38")]
	public SandboxConfig m_Stalker;

	[Token(Token = "0x4008E09")]
	[FieldOffset(Offset = "0x40")]
	public SandboxConfig m_Interloper;

	[Token(Token = "0x6007B59")]
	[Address(RVA = "0x11A0730", Offset = "0x119F530", Length = "0x233")]
	public SceneSetCount FindPresetCartographyAchevementSceneSetCount(string regionName)
	{
		return null;
	}

	[Token(Token = "0x6007B5A")]
	[Address(RVA = "0x4A22A0", Offset = "0x4A10A0", Length = "0x7")]
	public FaithfulCartographerSO()
	{
	}
}
