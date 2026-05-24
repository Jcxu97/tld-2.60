using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.AddressableAssets;

[Token(Token = "0x2000795")]
public class PhotoManager : MonoBehaviour
{
	[Token(Token = "0x2000796")]
	public class PhotoInfo
	{
		[Token(Token = "0x4005108")]
		[FieldOffset(Offset = "0x10")]
		public string m_PhotoID;

		[Token(Token = "0x4005109")]
		[FieldOffset(Offset = "0x18")]
		public AssetReference m_FilmPack;

		[Token(Token = "0x400510A")]
		[FieldOffset(Offset = "0x20")]
		public int m_Day;

		[Token(Token = "0x400510B")]
		[FieldOffset(Offset = "0x28")]
		public string m_RegionLocalizationKey;

		[Token(Token = "0x400510C")]
		[FieldOffset(Offset = "0x30")]
		public string m_LocationLocalizationKey;

		[Token(Token = "0x400510D")]
		[FieldOffset(Offset = "0x38")]
		public string m_Annotation;

		[Token(Token = "0x60046E4")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public PhotoInfo()
		{
		}
	}

	[CompilerGenerated]
	[Token(Token = "0x2000798")]
	private sealed class _003CFinishScreenshotCoroutine_003Ed__38 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400510F")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4005110")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4005111")]
		[FieldOffset(Offset = "0x20")]
		public PhotoManager _003C_003E4__this;

		[Token(Token = "0x1700032D")]
		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			[Token(Token = "0x60046EA")]
			[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700032E")]
		object IEnumerator.Current
		{
			[DebuggerHidden]
			[Token(Token = "0x60046EC")]
			[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		[Token(Token = "0x60046E7")]
		[Address(RVA = "0x4096E0", Offset = "0x4084E0", Length = "0x4")]
		public _003CFinishScreenshotCoroutine_003Ed__38(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		[Token(Token = "0x60046E8")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		void IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60046E9")]
		[Address(RVA = "0xD13A90", Offset = "0xD12890", Length = "0x59B")]
		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		[Token(Token = "0x60046EB")]
		[Address(RVA = "0xD14030", Offset = "0xD12E30", Length = "0x3E")]
		void IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40050F9")]
	private const string PHOTO_MATERIAL_FX_NAME = "PhotoMaterial";

	[Token(Token = "0x40050FA")]
	private static readonly int PHOTO_DEVELOP_PROGRESS_ID;

	[SerializeField]
	[Token(Token = "0x40050FB")]
	[FieldOffset(Offset = "0x20")]
	private int m_ResolutionWidth;

	[SerializeField]
	[Token(Token = "0x40050FC")]
	[FieldOffset(Offset = "0x24")]
	private int m_ResolutionHeight;

	[SerializeField]
	[Token(Token = "0x40050FD")]
	[FieldOffset(Offset = "0x28")]
	private float m_FieldOfViewScalar;

	[SerializeField]
	[Token(Token = "0x40050FE")]
	[FieldOffset(Offset = "0x2C")]
	private int m_PhotoMaterialIndex;

	[SerializeField]
	[Token(Token = "0x40050FF")]
	[FieldOffset(Offset = "0x30")]
	private AnimationCurve m_PhotoDevelopProgressCurve;

	[Token(Token = "0x4005100")]
	[FieldOffset(Offset = "0x38")]
	private List<PhotoInfo> m_Photos;

	[Token(Token = "0x4005101")]
	[FieldOffset(Offset = "0x40")]
	private RenderTexture m_RenderTexture;

	[Token(Token = "0x4005102")]
	[FieldOffset(Offset = "0x48")]
	private int m_RenderTextureSizePadding;

	[Token(Token = "0x4005103")]
	[FieldOffset(Offset = "0x4C")]
	private bool m_PhotoCoroutineProcessing;

	[Token(Token = "0x4005104")]
	[FieldOffset(Offset = "0x50")]
	private float m_PhotoDevelopTimeStart;

	[Token(Token = "0x4005105")]
	[FieldOffset(Offset = "0x54")]
	private float m_PreviousDevelopProgress;

	[Token(Token = "0x17000328")]
	public static List<PhotoInfo> Photos
	{
		[Token(Token = "0x60046CC")]
		[Address(RVA = "0xD12160", Offset = "0xD10F60", Length = "0x52")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000329")]
	public int Width
	{
		[Token(Token = "0x60046CD")]
		[Address(RVA = "0x4571E0", Offset = "0x455FE0", Length = "0x4")]
		get
		{
			return 0;
		}
	}

	[Token(Token = "0x1700032A")]
	public int Height
	{
		[Token(Token = "0x60046CE")]
		[Address(RVA = "0x4AA8A0", Offset = "0x4A96A0", Length = "0x4")]
		get
		{
			return 0;
		}
	}

	[Token(Token = "0x1700032B")]
	[field: Token(Token = "0x4005106")]
	[field: FieldOffset(Offset = "0x58")]
	private Texture2D PhotoTexture
	{
		[Token(Token = "0x60046CF")]
		[Address(RVA = "0x6BCD40", Offset = "0x6BBB40", Length = "0x5")]
		get;
		[Token(Token = "0x60046D0")]
		[Address(RVA = "0x95D320", Offset = "0x95C120", Length = "0x52")]
		set;
	}

	[Token(Token = "0x1700032C")]
	[field: Token(Token = "0x4005107")]
	[field: FieldOffset(Offset = "0x60")]
	private Material[] PhotoMaterials
	{
		[Token(Token = "0x60046D1")]
		[Address(RVA = "0x6E2FE0", Offset = "0x6E1DE0", Length = "0x5")]
		get;
		[Token(Token = "0x60046D2")]
		[Address(RVA = "0x8F4D50", Offset = "0x8F3B50", Length = "0x52")]
		set;
	}

	[Token(Token = "0x60046D3")]
	[Address(RVA = "0xD121C0", Offset = "0xD10FC0", Length = "0x5B")]
	public void OnDestroy()
	{
	}

	[Token(Token = "0x60046D4")]
	[Address(RVA = "0xD12220", Offset = "0xD11020", Length = "0x1D5")]
	private void Update()
	{
	}

	[Token(Token = "0x60046D5")]
	[Address(RVA = "0x4A7D50", Offset = "0x4A6B50", Length = "0x5")]
	public List<PhotoInfo> Serialize()
	{
		return null;
	}

	[Token(Token = "0x60046D6")]
	[Address(RVA = "0xD12400", Offset = "0xD11200", Length = "0x52")]
	public void Deserialize(List<PhotoInfo> photos)
	{
	}

	[Token(Token = "0x60046D7")]
	[Address(RVA = "0xD12460", Offset = "0xD11260", Length = "0xEC")]
	public RenderTexture StartScreenshot(Camera camera, int renderTextureSizePadding)
	{
		return null;
	}

	[Token(Token = "0x60046D8")]
	[Address(RVA = "0x5737E0", Offset = "0x5725E0", Length = "0x5")]
	public bool IsFinishingScreenShot()
	{
		return false;
	}

	[Token(Token = "0x60046D9")]
	[Address(RVA = "0xD12550", Offset = "0xD11350", Length = "0xA4")]
	public void FinishScreenshot()
	{
	}

	[Token(Token = "0x60046DA")]
	[Address(RVA = "0xD12600", Offset = "0xD11400", Length = "0x20C")]
	public void DeletePhoto(string photoID)
	{
	}

	[Token(Token = "0x60046DB")]
	[Address(RVA = "0xD12810", Offset = "0xD11610", Length = "0xBC")]
	public Texture CreatePhotoTexture()
	{
		return null;
	}

	[Token(Token = "0x60046DC")]
	[Address(RVA = "0xD128D0", Offset = "0xD116D0", Length = "0x11B")]
	public void DestroyPhotoTexture(Texture photoTexture)
	{
	}

	[IteratorStateMachine(typeof(_003CFinishScreenshotCoroutine_003Ed__38))]
	[Token(Token = "0x60046DD")]
	[Address(RVA = "0xD129F0", Offset = "0xD117F0", Length = "0x9A")]
	private IEnumerator FinishScreenshotCoroutine()
	{
		return null;
	}

	[Token(Token = "0x60046DE")]
	[Address(RVA = "0xD12A90", Offset = "0xD11890", Length = "0x337")]
	private void MaybeCreateTextures(int renderTextureSizePadding)
	{
	}

	[Token(Token = "0x60046DF")]
	[Address(RVA = "0xD12DD0", Offset = "0xD11BD0", Length = "0x182")]
	private void DestroyTextures()
	{
	}

	[Token(Token = "0x60046E0")]
	[Address(RVA = "0xD12F60", Offset = "0xD11D60", Length = "0x484")]
	private static void GetLocationAndRegion(out string location, out string region)
	{
		location = null;
		region = null;
	}

	[Token(Token = "0x60046E1")]
	[Address(RVA = "0xD133F0", Offset = "0xD121F0", Length = "0x4C1")]
	private void SetPhotoTexture(int index)
	{
	}

	[Token(Token = "0x60046E2")]
	[Address(RVA = "0xD138C0", Offset = "0xD126C0", Length = "0x10B")]
	public PhotoManager()
	{
	}
}
