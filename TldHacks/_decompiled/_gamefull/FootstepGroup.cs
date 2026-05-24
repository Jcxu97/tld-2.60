using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20003A0")]
public class FootstepGroup
{
	[Token(Token = "0x4002069")]
	public const int FOOTSTEP_BLOCK_SIZE_SHIFT = 4;

	[Token(Token = "0x400206A")]
	public const int FOOTSTEP_BLOCK_SIZE = 16;

	[Token(Token = "0x400206B")]
	public const int FOOTSTEP_BLOCK_SIZE_M1 = 15;

	[Token(Token = "0x400206C")]
	public const int MAX_BLOCKS_PER_GROUP = 8;

	[Token(Token = "0x400206D")]
	public const int MAX_FOOTSTEPS = 128;

	[Token(Token = "0x400206E")]
	public const float MAX_SNOW_DEPTH_DIFFERENCE = 0.02f;

	[Token(Token = "0x400206F")]
	[FieldOffset(Offset = "0x10")]
	public Bounds m_Bounds;

	[Token(Token = "0x4002070")]
	[FieldOffset(Offset = "0x28")]
	public bool m_IsOpen;

	[Token(Token = "0x4002071")]
	[FieldOffset(Offset = "0x2C")]
	public int m_NumFootsteps;

	[Token(Token = "0x4002072")]
	[FieldOffset(Offset = "0x30")]
	public int m_LastVisibleImprint;

	[Token(Token = "0x4002073")]
	[FieldOffset(Offset = "0x34")]
	public float m_BaseSnowDepth;

	[Token(Token = "0x4002074")]
	[FieldOffset(Offset = "0x38")]
	public float m_ExpireSnowDepth;

	[Token(Token = "0x4002075")]
	[FieldOffset(Offset = "0x40")]
	private FootstepTrail m_Parent;

	[Token(Token = "0x4002076")]
	[FieldOffset(Offset = "0x48")]
	private int[] m_FootstepBlockBases;

	[Token(Token = "0x4002077")]
	[FieldOffset(Offset = "0x50")]
	public int m_CaptureTick;

	[Token(Token = "0x4002078")]
	[FieldOffset(Offset = "0x58")]
	private HashSet<int> m_ReferencedSnowPatches;

	[Token(Token = "0x6001CB3")]
	[Address(RVA = "0x788130", Offset = "0x786F30", Length = "0x291")]
	public FootstepGroup(FootstepTrail parent, Vector3 pos, Vector3 defaultBoundsSize)
	{
	}

	[Token(Token = "0x6001CB4")]
	[Address(RVA = "0x7883D0", Offset = "0x7871D0", Length = "0x322")]
	public void Destroy()
	{
	}

	[Token(Token = "0x6001CB5")]
	[Address(RVA = "0x788700", Offset = "0x787500", Length = "0xE3")]
	public void Close()
	{
	}

	[Token(Token = "0x6001CB6")]
	[Address(RVA = "0x7887F0", Offset = "0x7875F0", Length = "0x244")]
	public bool MaybeAddFootstep(Vector3 pos, ref SnowImprint footstep, float depth, Vector3 defaultBoundsSize, Vector3 boundsLimit)
	{
		return false;
	}

	[Token(Token = "0x6001CB7")]
	[Address(RVA = "0x788A40", Offset = "0x787840", Length = "0xA4")]
	public void AddFootstep(ref SnowImprint footstep, float depth)
	{
	}

	[Token(Token = "0x6001CB8")]
	[Address(RVA = "0x788AF0", Offset = "0x7878F0", Length = "0x223")]
	public void AddFootstep(ref SnowImprint footstep)
	{
	}

	[Token(Token = "0x6001CB9")]
	[Address(RVA = "0x788D20", Offset = "0x787B20", Length = "0x9C")]
	private void UpdateExpireDepth(float depth)
	{
	}

	[Token(Token = "0x6001CBA")]
	[Address(RVA = "0x788DC0", Offset = "0x787BC0", Length = "0x1ED")]
	public void Show(int captureTick)
	{
	}

	[Token(Token = "0x6001CBB")]
	[Address(RVA = "0x788FB0", Offset = "0x787DB0", Length = "0x24")]
	public void Hide()
	{
	}

	[Token(Token = "0x6001CBC")]
	[Address(RVA = "0x788FE0", Offset = "0x787DE0", Length = "0x34")]
	public int GetFootprintIndexInTrail(int i)
	{
		return 0;
	}

	[Token(Token = "0x6001CBD")]
	[Address(RVA = "0x789020", Offset = "0x787E20", Length = "0xD3")]
	public void SerializeFootsteps(List<uint> list)
	{
	}

	[Token(Token = "0x6001CBE")]
	[Address(RVA = "0x789100", Offset = "0x787F00", Length = "0x24A")]
	public void AdjustSnowDepthRecords(float baseDepth)
	{
	}

	[Token(Token = "0x6001CBF")]
	[Address(RVA = "0x789350", Offset = "0x788150", Length = "0x37A")]
	private void RemovePatchRefs()
	{
	}

	[Token(Token = "0x6001CC0")]
	[Address(RVA = "0x7896D0", Offset = "0x7884D0", Length = "0x24")]
	public bool QualityAllowsShowing()
	{
		return false;
	}
}
