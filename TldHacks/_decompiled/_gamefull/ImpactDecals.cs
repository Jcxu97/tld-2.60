using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[CreateAssetMenu(fileName = "ImpactDecals", menuName = "FX/Impact Decals", order = 10004)]
[Token(Token = "0x20003B9")]
public class ImpactDecals : ScriptableObject
{
	[Token(Token = "0x4002148")]
	[FieldOffset(Offset = "0x18")]
	public List<ProjectileImpactDecal> m_ProjectileImpactDecals;

	[Token(Token = "0x6001D3E")]
	[Address(RVA = "0x798160", Offset = "0x796F60", Length = "0x2E5")]
	private ImpactDecal GetImpactDecal(ProjectileType projectileType, MaterialEffectType impactEffectType)
	{
		return null;
	}

	[Token(Token = "0x6001D3F")]
	[Address(RVA = "0x798450", Offset = "0x797250", Length = "0x60")]
	public static MaterialEffectType MapArrowImpactEffectTypeToMaterialEffectType(ArrowImpactEffectType et)
	{
		return default(MaterialEffectType);
	}

	[Token(Token = "0x6001D40")]
	[Address(RVA = "0x7984E0", Offset = "0x7972E0", Length = "0x50")]
	public static MaterialEffectType MapBulletImpactEffectTypeToMaterialEffectType(BulletImpactEffectType et)
	{
		return default(MaterialEffectType);
	}

	[Token(Token = "0x6001D41")]
	[Address(RVA = "0x7984E0", Offset = "0x7972E0", Length = "0x50")]
	public static MaterialEffectType MapScorchImpactEffectTypeToMaterialEffectType(ScorchImpactEffectType et)
	{
		return default(MaterialEffectType);
	}

	[Token(Token = "0x6001D42")]
	[Address(RVA = "0x7984E0", Offset = "0x7972E0", Length = "0x50")]
	public static MaterialEffectType MapHeavyFootstepEffectTypeToMaterialEffectType(HeavyFootstepEffectType et)
	{
		return default(MaterialEffectType);
	}

	[Token(Token = "0x6001D43")]
	[Address(RVA = "0x798560", Offset = "0x797360", Length = "0x445")]
	public static MaterialEffectType MapSurfaceTagToMaterialEffectType(string tag)
	{
		return default(MaterialEffectType);
	}

	[Token(Token = "0x6001D44")]
	[Address(RVA = "0x7989B0", Offset = "0x7977B0", Length = "0x182")]
	public DecalProjectorInstance AddSprayPaintDecal(ProjectileType shape, MaterialEffectType materialEffectType, Vector3 postion, Vector3 forward)
	{
		return null;
	}

	[Token(Token = "0x6001D45")]
	[Address(RVA = "0x798B40", Offset = "0x797940", Length = "0x288")]
	public DecalProjectorInstance AddImpactDecal(ProjectileType projectileType, MaterialEffectType impactEffectType, DecalProjectorType projectorType, Vector3 postion, Vector3 forward, float yaw)
	{
		return null;
	}

	[Token(Token = "0x6001D46")]
	[Address(RVA = "0x4A22A0", Offset = "0x4A10A0", Length = "0x7")]
	public ImpactDecals()
	{
	}
}
