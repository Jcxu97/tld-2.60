using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20003BA")]
public class InteriorLightingGroup : MonoBehaviour
{
	[Token(Token = "0x4002149")]
	[FieldOffset(Offset = "0x20")]
	public List<GameObject> m_Objects;

	[Token(Token = "0x400214A")]
	[FieldOffset(Offset = "0x28")]
	public ScaledCurve m_GlowOverride;

	[Token(Token = "0x400214B")]
	[FieldOffset(Offset = "0x30")]
	private readonly List<Light> m_Lights;

	[Token(Token = "0x400214C")]
	[FieldOffset(Offset = "0x38")]
	private readonly List<MeshRenderer> m_GlowObjects;

	[Token(Token = "0x400214D")]
	[FieldOffset(Offset = "0x40")]
	private readonly List<ParticleSystem> m_FX;

	[Token(Token = "0x400214E")]
	[FieldOffset(Offset = "0x48")]
	private readonly List<LightShaftGimble> m_LightShafts;

	[Token(Token = "0x400214F")]
	[FieldOffset(Offset = "0x50")]
	private readonly List<float> m_OrgLitValue;

	[Token(Token = "0x4002150")]
	[FieldOffset(Offset = "0x58")]
	private readonly List<Color> m_OrgLitColour;

	[Token(Token = "0x4002151")]
	[FieldOffset(Offset = "0x60")]
	private readonly List<Color> m_OrgFxColour;

	[Token(Token = "0x4002152")]
	[FieldOffset(Offset = "0x68")]
	private readonly List<Material> m_GlowObjectMaterialsToUpdate;

	[Token(Token = "0x4002153")]
	[FieldOffset(Offset = "0x70")]
	private readonly List<Color> m_GlowObjectMaterialsOriginalColor;

	[Token(Token = "0x6001D47")]
	[Address(RVA = "0x798DD0", Offset = "0x797BD0", Length = "0x9E3")]
	private void Start()
	{
	}

	[Token(Token = "0x6001D48")]
	[Address(RVA = "0x7997C0", Offset = "0x7985C0", Length = "0xD7B")]
	public void ScrubUpdate(float intensityMultiplier, Color newColor, float timeOfDay)
	{
	}

	[Token(Token = "0x6001D49")]
	[Address(RVA = "0x79A540", Offset = "0x799340", Length = "0x3BF")]
	private void DetermineObject(List<GameObject> goList)
	{
	}

	[Token(Token = "0x6001D4A")]
	[Address(RVA = "0x457420", Offset = "0x456220", Length = "0x5")]
	public List<Light> GetLights()
	{
		return null;
	}

	[Token(Token = "0x6001D4B")]
	[Address(RVA = "0x4B2FE0", Offset = "0x4B1DE0", Length = "0x5")]
	public List<LightShaftGimble> GetLightShafts()
	{
		return null;
	}

	[Token(Token = "0x6001D4C")]
	[Address(RVA = "0x4A7D60", Offset = "0x4A6B60", Length = "0x5")]
	public List<ParticleSystem> GetParticles()
	{
		return null;
	}

	[Token(Token = "0x6001D4D")]
	[Address(RVA = "0x79A900", Offset = "0x799700", Length = "0x621")]
	public InteriorLightingGroup()
	{
	}
}
