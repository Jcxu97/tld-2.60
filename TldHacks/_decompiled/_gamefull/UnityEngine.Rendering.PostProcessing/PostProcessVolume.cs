using System.Collections.Generic;
using Cpp2ILInjected;

namespace UnityEngine.Rendering.PostProcessing;

[ExecuteAlways]
[AddComponentMenu("Rendering/Post-process Volume", 1001)]
[Token(Token = "0x2000CEE")]
public sealed class PostProcessVolume : MonoBehaviour
{
	[Token(Token = "0x400801F")]
	[FieldOffset(Offset = "0x20")]
	public PostProcessProfile sharedProfile;

	[Tooltip("Check this box to mark this volume as global. This volume's Profile will be applied to the whole Scene.")]
	[Token(Token = "0x4008020")]
	[FieldOffset(Offset = "0x28")]
	public bool isGlobal;

	[Min(0f)]
	[Tooltip("The distance (from the attached Collider) to start blending from. A value of 0 means there will be no blending and the Volume overrides will be applied immediatly upon entry to the attached Collider.")]
	[Token(Token = "0x4008021")]
	[FieldOffset(Offset = "0x2C")]
	public float blendDistance;

	[Range(0f, 1f)]
	[Tooltip("The total weight of this Volume in the Scene. A value of 0 signifies that it will have no effect, 1 signifies full effect.")]
	[Token(Token = "0x4008022")]
	[FieldOffset(Offset = "0x30")]
	public float weight;

	[Tooltip("The volume priority in the stack. A higher value means higher priority. Negative values are supported.")]
	[Token(Token = "0x4008023")]
	[FieldOffset(Offset = "0x34")]
	public float priority;

	[Token(Token = "0x4008024")]
	[FieldOffset(Offset = "0x38")]
	private int m_PreviousLayer;

	[Token(Token = "0x4008025")]
	[FieldOffset(Offset = "0x3C")]
	private float m_PreviousPriority;

	[Token(Token = "0x4008026")]
	[FieldOffset(Offset = "0x40")]
	private List<Collider> m_TempColliders;

	[Token(Token = "0x4008027")]
	[FieldOffset(Offset = "0x48")]
	private PostProcessProfile m_InternalProfile;

	[Token(Token = "0x170006E5")]
	public PostProcessProfile profile
	{
		[Token(Token = "0x600664F")]
		[Address(RVA = "0x1025C40", Offset = "0x1024A40", Length = "0x400")]
		get
		{
			return null;
		}
		[Token(Token = "0x6006650")]
		[Address(RVA = "0x4D0B60", Offset = "0x4CF960", Length = "0x52")]
		set
		{
		}
	}

	[Token(Token = "0x170006E6")]
	internal PostProcessProfile profileRef
	{
		[Token(Token = "0x6006651")]
		[Address(RVA = "0x1026050", Offset = "0x1024E50", Length = "0xDD")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170006E7")]
	internal int previousLayer
	{
		[Token(Token = "0x6006653")]
		[Address(RVA = "0x502760", Offset = "0x501560", Length = "0x4")]
		get
		{
			return 0;
		}
	}

	[Token(Token = "0x6006652")]
	[Address(RVA = "0x1026130", Offset = "0x1024F30", Length = "0xCA")]
	public bool HasInstantiatedProfile()
	{
		return false;
	}

	[Token(Token = "0x6006654")]
	[Address(RVA = "0x1026200", Offset = "0x1025000", Length = "0x24F")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6006655")]
	[Address(RVA = "0x1026450", Offset = "0x1025250", Length = "0x12C")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6006656")]
	[Address(RVA = "0x1026580", Offset = "0x1025380", Length = "0x182")]
	private void Update()
	{
	}

	[Token(Token = "0x6006657")]
	[Address(RVA = "0x1026710", Offset = "0x1025510", Length = "0x12B6")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x6006658")]
	[Address(RVA = "0x4BB120", Offset = "0x4B9F20", Length = "0x4A")]
	public PostProcessVolume()
	{
	}
}
