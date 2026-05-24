using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Rewired.Utils.Libraries.CLZF2;
using UnityEngine;

namespace Rewired.Data;

[Token(Token = "0x2000C07")]
public class UserDataStore_File : UserDataStore_KeyValue
{
	[Token(Token = "0x2000C08")]
	private sealed class DataStore : IDataStore
	{
		[Token(Token = "0x4007BB0")]
		[FieldOffset(Offset = "0x10")]
		private Dictionary<string, object> _data;

		[Token(Token = "0x4007BB1")]
		[FieldOffset(Offset = "0x18")]
		private readonly string _absFilePath;

		[Token(Token = "0x4007BB2")]
		[FieldOffset(Offset = "0x20")]
		private IDataHandler _dataHandler;

		[Token(Token = "0x60060FB")]
		[Address(RVA = "0xF7D5D0", Offset = "0xF7C3D0", Length = "0x225")]
		public DataStore(string fileName, string absDirectory, IDataHandler dataHandler)
		{
		}

		[Token(Token = "0x60060FC")]
		[Address(RVA = "0xF7D800", Offset = "0xF7C600", Length = "0xC8")]
		public bool TryGetValue(string key, out object value)
		{
			value = null;
			return false;
		}

		[Token(Token = "0x60060FD")]
		[Address(RVA = "0xF7D8D0", Offset = "0xF7C6D0", Length = "0xA2")]
		public bool SetValue(string key, object value)
		{
			return false;
		}

		[Token(Token = "0x60060FE")]
		[Address(RVA = "0xF7D980", Offset = "0xF7C780", Length = "0xAB")]
		public bool Save()
		{
			return false;
		}

		[Token(Token = "0x60060FF")]
		[Address(RVA = "0xF7DA30", Offset = "0xF7C830", Length = "0x1F7")]
		public bool Load()
		{
			return false;
		}

		[Token(Token = "0x6006100")]
		[Address(RVA = "0xF7DC30", Offset = "0xF7CA30", Length = "0xC8")]
		public bool Clear()
		{
			return false;
		}
	}

	[Token(Token = "0x2000C09")]
	private sealed class LocalFileDataHandler : IDataHandler
	{
		[Token(Token = "0x4007BB3")]
		[FieldOffset(Offset = "0x10")]
		private readonly Func<DataFormat> _dataFormatDelegate;

		[Token(Token = "0x4007BB4")]
		[FieldOffset(Offset = "0x18")]
		private readonly Codec _codec;

		[Token(Token = "0x6006101")]
		[Address(RVA = "0xF7DD00", Offset = "0xF7CB00", Length = "0x151")]
		public LocalFileDataHandler(Func<DataFormat> dataFormatDelegate, Codec codec)
		{
		}

		[Token(Token = "0x6006102")]
		[Address(RVA = "0xF7DE60", Offset = "0xF7CC60", Length = "0x1AC")]
		public bool Load(string absoluteFilePath, out string data)
		{
			data = null;
			return false;
		}

		[Token(Token = "0x6006103")]
		[Address(RVA = "0xF7E010", Offset = "0xF7CE10", Length = "0x23C")]
		public bool Save(string absoluteFilePath, string data)
		{
			return false;
		}

		[Token(Token = "0x6006104")]
		[Address(RVA = "0xF7E250", Offset = "0xF7D050", Length = "0x68")]
		public bool Clear(string absoluteFilePath)
		{
			return false;
		}
	}

	[Token(Token = "0x2000C0A")]
	private abstract class Codec
	{
		[Token(Token = "0x6006105")]
		public abstract byte[] Encode(string @string);

		[Token(Token = "0x6006106")]
		public abstract string Decode(byte[] data);

		[Token(Token = "0x6006107")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		protected Codec()
		{
		}
	}

	[Token(Token = "0x2000C0B")]
	private sealed class UTF8Text : Codec
	{
		[Token(Token = "0x6006108")]
		[Address(RVA = "0xF7E2C0", Offset = "0xF7D0C0", Length = "0x39")]
		public override byte[] Encode(string @string)
		{
			return null;
		}

		[Token(Token = "0x6006109")]
		[Address(RVA = "0xF7E300", Offset = "0xF7D100", Length = "0x39")]
		public override string Decode(byte[] data)
		{
			return null;
		}

		[Token(Token = "0x600610A")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public UTF8Text()
		{
		}
	}

	[Token(Token = "0x2000C0C")]
	private sealed class CLZF2 : Codec
	{
		[Token(Token = "0x4007BB5")]
		[FieldOffset(Offset = "0x10")]
		private readonly Rewired.Utils.Libraries.CLZF2.CLZF2 _cLZF2;

		[Token(Token = "0x600610B")]
		[Address(RVA = "0xF7E340", Offset = "0xF7D140", Length = "0x129")]
		public CLZF2()
		{
		}

		[Token(Token = "0x600610C")]
		[Address(RVA = "0xF7E470", Offset = "0xF7D270", Length = "0x131")]
		public override byte[] Encode(string @string)
		{
			return null;
		}

		[Token(Token = "0x600610D")]
		[Address(RVA = "0xF7E5B0", Offset = "0xF7D3B0", Length = "0x152")]
		public override string Decode(byte[] data)
		{
			return null;
		}
	}

	[Token(Token = "0x2000C0D")]
	public interface IDataHandler
	{
		[Token(Token = "0x600610E")]
		bool Load(string absoluteFilePath, out string data);

		[Token(Token = "0x600610F")]
		bool Save(string absoluteFilePath, string data);

		[Token(Token = "0x6006110")]
		bool Clear(string absoluteFilePath);
	}

	[Token(Token = "0x2000C0E")]
	public enum DataFormat
	{
		[Token(Token = "0x4007BB7")]
		Text,
		[Token(Token = "0x4007BB8")]
		Binary
	}

	[Token(Token = "0x4007BA5")]
	private static readonly string thisScriptName;

	[Token(Token = "0x4007BA6")]
	private const string logPrefix = "Rewired: ";

	[Token(Token = "0x4007BA7")]
	private const string defaultExtensionText = ".json";

	[Token(Token = "0x4007BA8")]
	private const string defaultExtensionBinary = ".bin";

	[Token(Token = "0x4007BA9")]
	private const string defaultFileName = "RewiredSaveData.json";

	[Tooltip("The data file name. Changing this will make saved data already stored with the old file name no longer accessible.")]
	[SerializeField]
	[Token(Token = "0x4007BAA")]
	[FieldOffset(Offset = "0x58")]
	private string _fileName;

	[Tooltip("Determines if the file should be stored as binary or text. Changing this will make saved data already stored no longer accessible.")]
	[SerializeField]
	[Token(Token = "0x4007BAB")]
	[FieldOffset(Offset = "0x60")]
	private DataFormat _dataFormat;

	[NonSerialized]
	[Token(Token = "0x4007BAC")]
	[FieldOffset(Offset = "0x68")]
	private string __directory;

	[NonSerialized]
	[Token(Token = "0x4007BAD")]
	[FieldOffset(Offset = "0x70")]
	private DataStore _dataStore;

	[NonSerialized]
	[Token(Token = "0x4007BAE")]
	[FieldOffset(Offset = "0x78")]
	private IDataHandler __dataHandler;

	[NonSerialized]
	[Token(Token = "0x4007BAF")]
	[FieldOffset(Offset = "0x80")]
	private bool _initialized;

	[Token(Token = "0x17000634")]
	public string directory
	{
		[Token(Token = "0x60060EC")]
		[Address(RVA = "0xF7CB30", Offset = "0xF7B930", Length = "0xAA")]
		get
		{
			return null;
		}
		[Token(Token = "0x60060ED")]
		[Address(RVA = "0xF7CBE0", Offset = "0xF7B9E0", Length = "0x66")]
		set
		{
		}
	}

	[Token(Token = "0x17000635")]
	public string fileName
	{
		[Token(Token = "0x60060EE")]
		[Address(RVA = "0x6BCD40", Offset = "0x6BBB40", Length = "0x5")]
		get
		{
			return null;
		}
		[Token(Token = "0x60060EF")]
		[Address(RVA = "0xF7CC50", Offset = "0xF7BA50", Length = "0x66")]
		set
		{
		}
	}

	[Token(Token = "0x17000636")]
	public DataFormat dataFormat
	{
		[Token(Token = "0x60060F0")]
		[Address(RVA = "0x8AE8C0", Offset = "0x8AD6C0", Length = "0x4")]
		get
		{
			return default(DataFormat);
		}
		[Token(Token = "0x60060F1")]
		[Address(RVA = "0xF7CCC0", Offset = "0xF7BAC0", Length = "0x14")]
		set
		{
		}
	}

	[Token(Token = "0x17000637")]
	protected IDataHandler dataHandler
	{
		[Token(Token = "0x60060F2")]
		[Address(RVA = "0xF7CCE0", Offset = "0xF7BAE0", Length = "0x34A")]
		get
		{
			return null;
		}
		[Token(Token = "0x60060F3")]
		[Address(RVA = "0xF7D030", Offset = "0xF7BE30", Length = "0x66")]
		set
		{
		}
	}

	[Token(Token = "0x17000638")]
	protected override IDataStore dataStore
	{
		[Token(Token = "0x60060F4")]
		[Address(RVA = "0x502690", Offset = "0x501490", Length = "0x5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60060F5")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	protected virtual void SetInitialValues()
	{
	}

	[Token(Token = "0x60060F6")]
	[Address(RVA = "0xF7D0A0", Offset = "0xF7BEA0", Length = "0xC3")]
	protected override void OnInitialize()
	{
	}

	[Token(Token = "0x60060F7")]
	[Address(RVA = "0xF7D170", Offset = "0xF7BF70", Length = "0x1A2")]
	private void OnDataSourceChanged()
	{
	}

	[Token(Token = "0x60060F8")]
	[Address(RVA = "0xF7D320", Offset = "0xF7C120", Length = "0x19F")]
	public UserDataStore_File()
	{
	}
}
