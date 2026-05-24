using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;

[Token(Token = "0x2000A5E")]
public class WebUtils
{
	[Token(Token = "0x2000A5F")]
	public class SteamCloudManager
	{
		[Token(Token = "0x2000A60")]
		public enum BatchType
		{
			[Token(Token = "0x4006787")]
			Parallel,
			[Token(Token = "0x4006788")]
			Sequence
		}

		[Token(Token = "0x2000A61")]
		private class BatchOperation : CommonCloudOperation
		{
			[CompilerGenerated]
			[Token(Token = "0x2000A62")]
			private sealed class _003CBatch_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
			{
				[Token(Token = "0x400678D")]
				[FieldOffset(Offset = "0x10")]
				private int _003C_003E1__state;

				[Token(Token = "0x400678E")]
				[FieldOffset(Offset = "0x18")]
				private object _003C_003E2__current;

				[Token(Token = "0x400678F")]
				[FieldOffset(Offset = "0x20")]
				public BatchOperation _003C_003E4__this;

				[Token(Token = "0x4006790")]
				[FieldOffset(Offset = "0x28")]
				private List<CommonCloudOperation>.Enumerator _003C_003E7__wrap1;

				[Token(Token = "0x4006791")]
				[FieldOffset(Offset = "0x40")]
				private CommonCloudOperation _003Coperation_003E5__3;

				[Token(Token = "0x170003B0")]
				object IEnumerator<object>.Current
				{
					[DebuggerHidden]
					[Token(Token = "0x6005B25")]
					[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
					get
					{
						return null;
					}
				}

				[Token(Token = "0x170003B1")]
				object IEnumerator.Current
				{
					[DebuggerHidden]
					[Token(Token = "0x6005B27")]
					[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
					get
					{
						return null;
					}
				}

				[DebuggerHidden]
				[Token(Token = "0x6005B21")]
				[Address(RVA = "0x4096E0", Offset = "0x4084E0", Length = "0x4")]
				public _003CBatch_003Ed__10(int _003C_003E1__state)
				{
				}

				[DebuggerHidden]
				[Token(Token = "0x6005B22")]
				[Address(RVA = "0xF258B0", Offset = "0xF246B0", Length = "0x88")]
				void IDisposable.Dispose()
				{
				}

				[Token(Token = "0x6005B23")]
				[Address(RVA = "0xF25940", Offset = "0xF24740", Length = "0x56F")]
				private bool MoveNext()
				{
					return false;
				}

				bool IEnumerator.MoveNext()
				{
					//ILSpy generated this explicit interface implementation from .override directive in MoveNext
					return this.MoveNext();
				}

				[Token(Token = "0x6005B24")]
				[Address(RVA = "0xF25EB0", Offset = "0xF24CB0", Length = "0x44")]
				private void _003C_003Em__Finally1()
				{
				}

				[DebuggerHidden]
				[Token(Token = "0x6005B26")]
				[Address(RVA = "0xF25F00", Offset = "0xF24D00", Length = "0x3E")]
				void IEnumerator.Reset()
				{
				}
			}

			[Token(Token = "0x4006789")]
			[FieldOffset(Offset = "0x28")]
			private Action<ICloudOperation> m_OnOperationComplete;

			[Token(Token = "0x400678A")]
			[FieldOffset(Offset = "0x30")]
			private List<CommonCloudOperation> m_OperationList;

			[Token(Token = "0x400678B")]
			[FieldOffset(Offset = "0x38")]
			private bool m_IsExecuting;

			[Token(Token = "0x400678C")]
			[FieldOffset(Offset = "0x3C")]
			private BatchType m_Type;

			[Token(Token = "0x6005B19")]
			[Address(RVA = "0xF25080", Offset = "0xF23E80", Length = "0x129")]
			public BatchOperation(Action<ICloudOperation> onOperationComplete, BatchType type)
			{
			}

			[Token(Token = "0x6005B1A")]
			[Address(RVA = "0xF251B0", Offset = "0xF23FB0", Length = "0x98")]
			public void AddOperation(CommonCloudOperation operation)
			{
			}

			[Token(Token = "0x6005B1B")]
			[Address(RVA = "0xF25250", Offset = "0xF24050", Length = "0x1E1")]
			public override void Execute()
			{
			}

			[Token(Token = "0x6005B1C")]
			[Address(RVA = "0xF25440", Offset = "0xF24240", Length = "0xC6")]
			private void RemoveSuccessfullOperations()
			{
			}

			[Token(Token = "0x6005B1D")]
			[Address(RVA = "0xF25510", Offset = "0xF24310", Length = "0x152")]
			private bool IsBatchCompleted()
			{
				return false;
			}

			[Token(Token = "0x6005B1E")]
			[Address(RVA = "0xF25670", Offset = "0xF24470", Length = "0x152")]
			private bool IsBatchSuccess()
			{
				return false;
			}

			[IteratorStateMachine(typeof(_003CBatch_003Ed__10))]
			[Token(Token = "0x6005B1F")]
			[Address(RVA = "0xF257D0", Offset = "0xF245D0", Length = "0x9A")]
			private IEnumerator Batch()
			{
				return null;
			}

			[Token(Token = "0x6005B20")]
			[Address(RVA = "0xF25870", Offset = "0xF24670", Length = "0x3A")]
			private void BatchDone()
			{
			}
		}

		[Token(Token = "0x2000A63")]
		public struct DeleteRequestResult
		{
			[Token(Token = "0x4006792")]
			[FieldOffset(Offset = "0x0")]
			public string m_Filename;

			[Token(Token = "0x4006793")]
			[FieldOffset(Offset = "0x8")]
			public bool m_Success;

			[Token(Token = "0x4006794")]
			[FieldOffset(Offset = "0x10")]
			public string m_Error;
		}

		[Token(Token = "0x2000A64")]
		private class LocalFileDeleteOperation : CommonCloudOperation
		{
			[Token(Token = "0x4006795")]
			[FieldOffset(Offset = "0x28")]
			private string m_FileName;

			[Token(Token = "0x6005B28")]
			[Address(RVA = "0x4A9DB0", Offset = "0x4A8BB0", Length = "0x52")]
			public LocalFileDeleteOperation(string filename)
			{
			}

			[Token(Token = "0x6005B29")]
			[Address(RVA = "0xF25F40", Offset = "0xF24D40", Length = "0x67")]
			public override void Execute()
			{
			}
		}

		[Token(Token = "0x2000A65")]
		private class DeleteOperation : CommonCloudOperation
		{
			[Token(Token = "0x4006796")]
			[FieldOffset(Offset = "0x28")]
			private string m_Token;

			[Token(Token = "0x4006797")]
			[FieldOffset(Offset = "0x30")]
			private string m_FileName;

			[Token(Token = "0x4006798")]
			[FieldOffset(Offset = "0x38")]
			private Action<bool> m_OnOperationComplete;

			[Token(Token = "0x6005B2A")]
			[Address(RVA = "0xF25FB0", Offset = "0xF24DB0", Length = "0x114")]
			public DeleteOperation(string token, string filename, Action<bool> onOperationComplete)
			{
			}

			[Token(Token = "0x6005B2B")]
			[Address(RVA = "0xF260D0", Offset = "0xF24ED0", Length = "0xB4")]
			public override void Execute()
			{
			}

			[Token(Token = "0x6005B2C")]
			[Address(RVA = "0xF26190", Offset = "0xF24F90", Length = "0x98")]
			public void RequestDeleteData(string token, string filename)
			{
			}

			[Token(Token = "0x6005B2D")]
			[Address(RVA = "0xF26230", Offset = "0xF25030", Length = "0x159")]
			private void RequestDeleteDataCompleted(DeleteRequestResult result)
			{
			}

			[Token(Token = "0x6005B2E")]
			[Address(RVA = "0xF26390", Offset = "0xF25190", Length = "0x366")]
			private IEnumerator WebRequestDeleteData(string token, string filename)
			{
				return null;
			}
		}

		[Token(Token = "0x2000A67")]
		private class DownloadSaveOperation : CommonCloudOperation
		{
			[Token(Token = "0x400679C")]
			[FieldOffset(Offset = "0x28")]
			private string m_FileName;

			[Token(Token = "0x400679D")]
			[FieldOffset(Offset = "0x30")]
			private DateTime m_DateTime;

			[Token(Token = "0x400679E")]
			[FieldOffset(Offset = "0x38")]
			private DownloadOperation m_DownloadOperation;

			[Token(Token = "0x400679F")]
			[FieldOffset(Offset = "0x40")]
			private Action<bool> m_OnOperationComplete;

			[Token(Token = "0x6005B32")]
			[Address(RVA = "0xF26B20", Offset = "0xF25920", Length = "0x2F4")]
			public DownloadSaveOperation(string filename, DateTime dateTime, string url, string sha1, Action<bool> onOperationComplete)
			{
			}

			[Token(Token = "0x6005B33")]
			[Address(RVA = "0xF26E20", Offset = "0xF25C20", Length = "0x47")]
			public override void Execute()
			{
			}

			[Token(Token = "0x6005B34")]
			[Address(RVA = "0xF26E70", Offset = "0xF25C70", Length = "0xC6")]
			private void DownloadDone(DownloadDataResult result)
			{
			}

			[Token(Token = "0x6005B35")]
			[Address(RVA = "0xF26F40", Offset = "0xF25D40", Length = "0x1E")]
			private void OperationFailed()
			{
			}
		}

		[Token(Token = "0x2000A68")]
		private class DownloadOperation : CommonCloudOperation
		{
			[Token(Token = "0x40067A0")]
			[FieldOffset(Offset = "0x28")]
			private string m_Url;

			[Token(Token = "0x40067A1")]
			[FieldOffset(Offset = "0x30")]
			private string m_FileName;

			[Token(Token = "0x40067A2")]
			[FieldOffset(Offset = "0x38")]
			private string m_Sha1;

			[Token(Token = "0x40067A3")]
			[FieldOffset(Offset = "0x40")]
			private Action<DownloadDataResult> m_OnOperationComplete;

			[Token(Token = "0x6005B36")]
			[Address(RVA = "0xF26F60", Offset = "0xF25D60", Length = "0x179")]
			public DownloadOperation(string filename, string url, string sha1, Action<DownloadDataResult> onOperationComplete)
			{
			}

			[Token(Token = "0x6005B37")]
			[Address(RVA = "0xF270E0", Offset = "0xF25EE0", Length = "0xC6")]
			public override void Execute()
			{
			}

			[Token(Token = "0x6005B38")]
			[Address(RVA = "0xF271B0", Offset = "0xF25FB0", Length = "0x162")]
			private void DownloadDone(DownloadDataResult result)
			{
			}
		}

		[Token(Token = "0x2000A69")]
		public struct EnumerateFilesResult
		{
			[Token(Token = "0x2000A6A")]
			public enum ResultType
			{
				[Token(Token = "0x40067AA")]
				Success,
				[Token(Token = "0x40067AB")]
				Error,
				[Token(Token = "0x40067AC")]
				Empty
			}

			[Token(Token = "0x2000A6B")]
			public struct FileInfo
			{
				[Token(Token = "0x40067AD")]
				[FieldOffset(Offset = "0x0")]
				public readonly string m_Filename;

				[Token(Token = "0x40067AE")]
				[FieldOffset(Offset = "0x8")]
				public readonly DateTime m_DateTime;

				[Token(Token = "0x40067AF")]
				[FieldOffset(Offset = "0x10")]
				public readonly string m_Sha;

				[Token(Token = "0x40067B0")]
				[FieldOffset(Offset = "0x18")]
				public readonly uint m_Filesize;

				[Token(Token = "0x40067B1")]
				[FieldOffset(Offset = "0x20")]
				public readonly string m_Url;

				[Token(Token = "0x6005B3A")]
				[Address(RVA = "0xF27450", Offset = "0xF26250", Length = "0x10F")]
				public FileInfo(string fileName, DateTime dateTime, string sha, uint size, string url)
				{
					m_Filename = null;
					m_DateTime = default(DateTime);
					m_Sha = null;
					m_Filesize = 0u;
					m_Url = null;
				}

				[Token(Token = "0x6005B3B")]
				[Address(RVA = "0xF27560", Offset = "0xF26360", Length = "0x3C")]
				public bool IsContentIdentical(FileInfo other)
				{
					return false;
				}

				[Token(Token = "0x6005B3C")]
				[Address(RVA = "0xF275A0", Offset = "0xF263A0", Length = "0xD2")]
				public override bool Equals(object other)
				{
					return false;
				}

				[Token(Token = "0x6005B3D")]
				[Address(RVA = "0xF27680", Offset = "0xF26480", Length = "0x66")]
				public override int GetHashCode()
				{
					return 0;
				}

				[Token(Token = "0x6005B3E")]
				[Address(RVA = "0xF276F0", Offset = "0xF264F0", Length = "0x1F7")]
				public static bool operator ==(FileInfo a, FileInfo b)
				{
					return false;
				}

				[Token(Token = "0x6005B3F")]
				[Address(RVA = "0xF278F0", Offset = "0xF266F0", Length = "0x216")]
				public static bool operator !=(FileInfo a, FileInfo b)
				{
					return false;
				}
			}

			[Token(Token = "0x40067A4")]
			public static FileInfo INVALID_FILEINFO;

			[Token(Token = "0x40067A5")]
			[FieldOffset(Offset = "0x0")]
			public ResultType m_ResultType;

			[Token(Token = "0x40067A6")]
			[FieldOffset(Offset = "0x8")]
			public string m_Error;

			[Token(Token = "0x40067A7")]
			[FieldOffset(Offset = "0x10")]
			public List<FileInfo> m_Files;

			[Token(Token = "0x40067A8")]
			[FieldOffset(Offset = "0x18")]
			public ICloudOperation m_CloudOperation;
		}

		[Token(Token = "0x2000A6C")]
		private class EnumerateFilesOperation : CommonCloudOperation
		{
			[Token(Token = "0x40067B2")]
			[FieldOffset(Offset = "0x28")]
			private string m_Token;

			[Token(Token = "0x40067B3")]
			[FieldOffset(Offset = "0x30")]
			private Action<EnumerateFilesResult> m_OnOperationComplete;

			[Token(Token = "0x6005B40")]
			[Address(RVA = "0xF27B10", Offset = "0xF26910", Length = "0x242")]
			public EnumerateFilesOperation(string token, Action<EnumerateFilesResult> onOperationComplete1, Action<EnumerateFilesResult> onOperationComplete2)
			{
			}

			[Token(Token = "0x6005B41")]
			[Address(RVA = "0xF27D60", Offset = "0xF26B60", Length = "0xA6")]
			public override void Execute()
			{
			}

			[Token(Token = "0x6005B42")]
			[Address(RVA = "0xF27E10", Offset = "0xF26C10", Length = "0x9A")]
			private void RequestEnumerateFiles(string token, bool extendedDetails)
			{
			}

			[Token(Token = "0x6005B43")]
			[Address(RVA = "0xF27EB0", Offset = "0xF26CB0", Length = "0x3DA")]
			private IEnumerator WebRequestEnumerateFiles(string token, bool extendedDetails)
			{
				return null;
			}

			[Token(Token = "0x6005B44")]
			[Address(RVA = "0xF28290", Offset = "0xF27090", Length = "0x40")]
			private void RequestEnumerateFilesDone(EnumerateFilesResult result)
			{
			}
		}

		[Token(Token = "0x2000A6E")]
		public class Enumerate
		{
			[Token(Token = "0x2000A6F")]
			public class EnumerateUserFiles_v1
			{
				[Token(Token = "0x2000A70")]
				public class ResponseData
				{
					[Token(Token = "0x2000A71")]
					public class FileInfo
					{
						[Token(Token = "0x40067B9")]
						[FieldOffset(Offset = "0x10")]
						public uint file_size;

						[Token(Token = "0x40067BA")]
						[FieldOffset(Offset = "0x18")]
						public ulong timestamp;

						[Token(Token = "0x40067BB")]
						[FieldOffset(Offset = "0x20")]
						public string filename;

						[Token(Token = "0x40067BC")]
						[FieldOffset(Offset = "0x28")]
						public string file_sha;

						[Token(Token = "0x40067BD")]
						[FieldOffset(Offset = "0x30")]
						public string url;

						[Token(Token = "0x6005B4C")]
						[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
						public FileInfo()
						{
						}
					}

					[Token(Token = "0x40067B7")]
					[FieldOffset(Offset = "0x10")]
					public List<FileInfo> files;

					[Token(Token = "0x40067B8")]
					[FieldOffset(Offset = "0x18")]
					public uint total_files;

					[Token(Token = "0x6005B4B")]
					[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
					public ResponseData()
					{
					}
				}

				[Token(Token = "0x40067B6")]
				[FieldOffset(Offset = "0x10")]
				public ResponseData response;

				[Token(Token = "0x6005B4A")]
				[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
				public EnumerateUserFiles_v1()
				{
				}
			}

			[Token(Token = "0x6005B48")]
			[Address(RVA = "0xF28D20", Offset = "0xF27B20", Length = "0x64")]
			public static EnumerateUserFiles_v1 ParseJson(string txt)
			{
				return null;
			}

			[Token(Token = "0x6005B49")]
			[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
			public Enumerate()
			{
			}
		}

		[Token(Token = "0x2000A72")]
		private enum CloudSyncStatus
		{
			[Token(Token = "0x40067BF")]
			CloudOnly,
			[Token(Token = "0x40067C0")]
			LocalOnly,
			[Token(Token = "0x40067C1")]
			CloudNewer,
			[Token(Token = "0x40067C2")]
			LocalNewer,
			[Token(Token = "0x40067C3")]
			CloudOlder,
			[Token(Token = "0x40067C4")]
			LocalOlder,
			[Token(Token = "0x40067C5")]
			ContentIdentical
		}

		[Token(Token = "0x2000A73")]
		private enum SyncConflictResult
		{
			[Token(Token = "0x40067C7")]
			AcceptCloud,
			[Token(Token = "0x40067C8")]
			AcceptLocal
		}

		[Token(Token = "0x2000A74")]
		public struct BeginUploadRequestResult
		{
			[Token(Token = "0x40067C9")]
			[FieldOffset(Offset = "0x0")]
			public bool m_Success;

			[Token(Token = "0x40067CA")]
			[FieldOffset(Offset = "0x8")]
			public Upload.BeginHTTPUpload_v1 m_Result;

			[Token(Token = "0x40067CB")]
			[FieldOffset(Offset = "0x10")]
			public string m_Response;

			[Token(Token = "0x40067CC")]
			[FieldOffset(Offset = "0x18")]
			public string m_Filename;

			[Token(Token = "0x40067CD")]
			[FieldOffset(Offset = "0x20")]
			public string m_Error;
		}

		[Token(Token = "0x2000A75")]
		public struct UploadPutRequestResult
		{
			[Token(Token = "0x40067CE")]
			[FieldOffset(Offset = "0x0")]
			public bool m_Success;

			[Token(Token = "0x40067CF")]
			[FieldOffset(Offset = "0x8")]
			public long m_ResponseCode;

			[Token(Token = "0x40067D0")]
			[FieldOffset(Offset = "0x10")]
			public string m_Error;
		}

		[Token(Token = "0x2000A76")]
		public struct UploadCommitRequestResult
		{
			[Token(Token = "0x40067D1")]
			[FieldOffset(Offset = "0x0")]
			public bool m_Success;

			[Token(Token = "0x40067D2")]
			[FieldOffset(Offset = "0x8")]
			public string m_Error;

			[Token(Token = "0x40067D3")]
			[FieldOffset(Offset = "0x10")]
			public bool m_TransferSuccess;
		}

		[Token(Token = "0x2000A77")]
		private class UploadOperation : CommonCloudOperation
		{
			[Token(Token = "0x40067D4")]
			[FieldOffset(Offset = "0x28")]
			private string m_Token;

			[Token(Token = "0x40067D5")]
			[FieldOffset(Offset = "0x30")]
			private string m_FileName;

			[Token(Token = "0x40067D6")]
			[FieldOffset(Offset = "0x38")]
			private byte[] m_Bytes;

			[Token(Token = "0x40067D7")]
			[FieldOffset(Offset = "0x40")]
			private string m_FileSha;

			[Token(Token = "0x40067D8")]
			[FieldOffset(Offset = "0x48")]
			private Action<bool> m_OnOperationComplete;

			[Token(Token = "0x6005B4D")]
			[Address(RVA = "0xF28D90", Offset = "0xF27B90", Length = "0x224")]
			public UploadOperation(string token, string filename, byte[] data, Action<bool> onOperationComplete)
			{
			}

			[Token(Token = "0x6005B4E")]
			[Address(RVA = "0xF28FC0", Offset = "0xF27DC0", Length = "0xE4")]
			public override void Execute()
			{
			}

			[Token(Token = "0x6005B4F")]
			[Address(RVA = "0xF290B0", Offset = "0xF27EB0", Length = "0xBA")]
			public void RequestBeginUploadData(string token, int filesize, string filename, string filesha)
			{
			}

			[Token(Token = "0x6005B50")]
			[Address(RVA = "0xF29170", Offset = "0xF27F70", Length = "0xC4")]
			public void RequestUploadData(string url_host, string url_path, string filename, Dictionary<string, string> httpHeaders, byte[] data)
			{
			}

			[Token(Token = "0x6005B51")]
			[Address(RVA = "0xF29240", Offset = "0xF28040", Length = "0xBC")]
			public void RequestCommitUpload(string token, bool transfer_succeeded, string filename, string filesha)
			{
			}

			[Token(Token = "0x6005B52")]
			[Address(RVA = "0xF29300", Offset = "0xF28100", Length = "0x1E")]
			private void OperationFailed()
			{
			}

			[Token(Token = "0x6005B53")]
			[Address(RVA = "0xF29320", Offset = "0xF28120", Length = "0x5C3")]
			private void RequestUploadData_BeginDone(BeginUploadRequestResult result)
			{
			}

			[Token(Token = "0x6005B54")]
			[Address(RVA = "0xF298F0", Offset = "0xF286F0", Length = "0x143")]
			private void RequestUploadData_PutDone(UploadPutRequestResult result)
			{
			}

			[Token(Token = "0x6005B55")]
			[Address(RVA = "0xF29A40", Offset = "0xF28840", Length = "0x28E")]
			private void RequestUploadData_CommitDone(UploadCommitRequestResult result)
			{
			}

			[Token(Token = "0x6005B56")]
			[Address(RVA = "0xF29CD0", Offset = "0xF28AD0", Length = "0x5A0")]
			private IEnumerator WebRequestBeginUploadData(string token, int filesize, string filename, string filesha)
			{
				return null;
			}

			[Token(Token = "0x6005B57")]
			[Address(RVA = "0xF2A280", Offset = "0xF29080", Length = "0x572")]
			private IEnumerator WebRequestCommitUpload(string token, bool transfer_succeeded, string filename, string filesha)
			{
				return null;
			}

			[Token(Token = "0x6005B58")]
			[Address(RVA = "0xF2A800", Offset = "0xF29600", Length = "0x2E6")]
			private IEnumerator WebRequestUploadData(string url_host, string url_path, string filename, Dictionary<string, string> httpHeaders, byte[] data)
			{
				return null;
			}
		}

		[Token(Token = "0x2000A7B")]
		public class Upload
		{
			[Token(Token = "0x2000A7C")]
			public class BeginHTTPUpload_v1
			{
				[Token(Token = "0x2000A7D")]
				public class ResponseData
				{
					[Token(Token = "0x2000A7E")]
					public class HttpHeader
					{
						[Token(Token = "0x40067E9")]
						[FieldOffset(Offset = "0x10")]
						public string name;

						[Token(Token = "0x40067EA")]
						[FieldOffset(Offset = "0x18")]
						public string value;

						[Token(Token = "0x6005B67")]
						[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
						public HttpHeader()
						{
						}
					}

					[Token(Token = "0x40067E3")]
					[FieldOffset(Offset = "0x10")]
					public ulong ugcid;

					[Token(Token = "0x40067E4")]
					[FieldOffset(Offset = "0x18")]
					public uint timestamp;

					[Token(Token = "0x40067E5")]
					[FieldOffset(Offset = "0x20")]
					public string url_host;

					[Token(Token = "0x40067E6")]
					[FieldOffset(Offset = "0x28")]
					public string url_path;

					[Token(Token = "0x40067E7")]
					[FieldOffset(Offset = "0x30")]
					public bool use_https;

					[Token(Token = "0x40067E8")]
					[FieldOffset(Offset = "0x38")]
					public List<HttpHeader> request_headers;

					[Token(Token = "0x6005B66")]
					[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
					public ResponseData()
					{
					}
				}

				[Token(Token = "0x40067E2")]
				[FieldOffset(Offset = "0x10")]
				public ResponseData response;

				[Token(Token = "0x6005B65")]
				[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
				public BeginHTTPUpload_v1()
				{
				}
			}

			[Token(Token = "0x2000A7F")]
			public class CommitHTTPUpload_v1
			{
				[Token(Token = "0x2000A80")]
				public class ResponseData
				{
					[Token(Token = "0x40067EC")]
					[FieldOffset(Offset = "0x10")]
					public bool file_committed;

					[Token(Token = "0x6005B69")]
					[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
					public ResponseData()
					{
					}
				}

				[Token(Token = "0x40067EB")]
				[FieldOffset(Offset = "0x10")]
				public ResponseData response;

				[Token(Token = "0x6005B68")]
				[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
				public CommitHTTPUpload_v1()
				{
				}
			}

			[Token(Token = "0x6005B62")]
			[Address(RVA = "0xF2BB50", Offset = "0xF2A950", Length = "0x64")]
			public static BeginHTTPUpload_v1 ParseJson(string txt)
			{
				return null;
			}

			[Token(Token = "0x6005B63")]
			[Address(RVA = "0xF2BBC0", Offset = "0xF2A9C0", Length = "0x7C")]
			public static bool IsCommitHTTPUploadSuccess(string response)
			{
				return false;
			}

			[Token(Token = "0x6005B64")]
			[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
			public Upload()
			{
			}
		}

		[Token(Token = "0x2000A81")]
		private class UploadSaveOperation : CommonCloudOperation
		{
			[Token(Token = "0x40067ED")]
			[FieldOffset(Offset = "0x28")]
			private string m_FileName;

			[Token(Token = "0x40067EE")]
			[FieldOffset(Offset = "0x30")]
			private string m_Token;

			[Token(Token = "0x40067EF")]
			[FieldOffset(Offset = "0x38")]
			private UploadOperation m_UploadOperation;

			[Token(Token = "0x40067F0")]
			[FieldOffset(Offset = "0x40")]
			private Action<bool> m_OnOperationComplete;

			[Token(Token = "0x6005B6A")]
			[Address(RVA = "0xF2BC40", Offset = "0xF2AA40", Length = "0x114")]
			public UploadSaveOperation(string token, string fileName, Action<bool> onOperationComplete)
			{
			}

			[Token(Token = "0x6005B6B")]
			[Address(RVA = "0xF2BD60", Offset = "0xF2AB60", Length = "0x12B")]
			public override void Execute()
			{
			}

			[Token(Token = "0x6005B6C")]
			[Address(RVA = "0xF2BE90", Offset = "0xF2AC90", Length = "0x1D")]
			private void DownloadDone(bool result)
			{
			}

			[Token(Token = "0x6005B6D")]
			[Address(RVA = "0xF26F40", Offset = "0xF25D40", Length = "0x1E")]
			private void OperationFailed()
			{
			}
		}

		[Token(Token = "0x2000A82")]
		private class WaitSaveOperation : CommonCloudOperation
		{
			[CompilerGenerated]
			[Token(Token = "0x2000A83")]
			private sealed class _003CWaitSaveOperationComplete_003Ed__3 : IEnumerator<object>, IEnumerator, IDisposable
			{
				[Token(Token = "0x40067F2")]
				[FieldOffset(Offset = "0x10")]
				private int _003C_003E1__state;

				[Token(Token = "0x40067F3")]
				[FieldOffset(Offset = "0x18")]
				private object _003C_003E2__current;

				[Token(Token = "0x40067F4")]
				[FieldOffset(Offset = "0x20")]
				public WaitSaveOperation _003C_003E4__this;

				[Token(Token = "0x170003B2")]
				object IEnumerator<object>.Current
				{
					[DebuggerHidden]
					[Token(Token = "0x6005B74")]
					[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
					get
					{
						return null;
					}
				}

				[Token(Token = "0x170003B3")]
				object IEnumerator.Current
				{
					[DebuggerHidden]
					[Token(Token = "0x6005B76")]
					[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
					get
					{
						return null;
					}
				}

				[DebuggerHidden]
				[Token(Token = "0x6005B71")]
				[Address(RVA = "0x4096E0", Offset = "0x4084E0", Length = "0x4")]
				public _003CWaitSaveOperationComplete_003Ed__3(int _003C_003E1__state)
				{
				}

				[DebuggerHidden]
				[Token(Token = "0x6005B72")]
				[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
				void IDisposable.Dispose()
				{
				}

				[Token(Token = "0x6005B73")]
				[Address(RVA = "0xF2C060", Offset = "0xF2AE60", Length = "0x2D4")]
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
				[Token(Token = "0x6005B75")]
				[Address(RVA = "0xF2C340", Offset = "0xF2B140", Length = "0x3E")]
				void IEnumerator.Reset()
				{
				}
			}

			[Token(Token = "0x40067F1")]
			[FieldOffset(Offset = "0x28")]
			private Action m_OnOperationComplete;

			[Token(Token = "0x6005B6E")]
			[Address(RVA = "0x4A9DB0", Offset = "0x4A8BB0", Length = "0x52")]
			public WaitSaveOperation(Action onCompleted)
			{
			}

			[Token(Token = "0x6005B6F")]
			[Address(RVA = "0xF2BEB0", Offset = "0xF2ACB0", Length = "0x104")]
			public override void Execute()
			{
			}

			[IteratorStateMachine(typeof(_003CWaitSaveOperationComplete_003Ed__3))]
			[Token(Token = "0x6005B70")]
			[Address(RVA = "0xF2BFC0", Offset = "0xF2ADC0", Length = "0x9A")]
			private IEnumerator WaitSaveOperationComplete()
			{
				return null;
			}
		}

		[Token(Token = "0x2000A84")]
		private class AuthenticateOperation : CommonCloudOperation
		{
			[Token(Token = "0x2000A85")]
			private enum OperationStatus
			{
				[Token(Token = "0x40067F9")]
				Cancel,
				[Token(Token = "0x40067FA")]
				Retry,
				[Token(Token = "0x40067FB")]
				Success,
				[Token(Token = "0x40067FC")]
				ShowingRetryDialog,
				[Token(Token = "0x40067FD")]
				RetrieveToken,
				[Token(Token = "0x40067FE")]
				RetrievingToken,
				[Token(Token = "0x40067FF")]
				VerifyToken,
				[Token(Token = "0x4006800")]
				VerifyingToken
			}

			[CompilerGenerated]
			[Token(Token = "0x2000A86")]
			private sealed class _003CAuthenticate_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
			{
				[Token(Token = "0x4006801")]
				[FieldOffset(Offset = "0x10")]
				private int _003C_003E1__state;

				[Token(Token = "0x4006802")]
				[FieldOffset(Offset = "0x18")]
				private object _003C_003E2__current;

				[Token(Token = "0x4006803")]
				[FieldOffset(Offset = "0x20")]
				public AuthenticateOperation _003C_003E4__this;

				[Token(Token = "0x170003B4")]
				object IEnumerator<object>.Current
				{
					[DebuggerHidden]
					[Token(Token = "0x6005B86")]
					[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
					get
					{
						return null;
					}
				}

				[Token(Token = "0x170003B5")]
				object IEnumerator.Current
				{
					[DebuggerHidden]
					[Token(Token = "0x6005B88")]
					[Address(RVA = "0x4571D0", Offset = "0x455FD0", Length = "0x5")]
					get
					{
						return null;
					}
				}

				[DebuggerHidden]
				[Token(Token = "0x6005B83")]
				[Address(RVA = "0x4096E0", Offset = "0x4084E0", Length = "0x4")]
				public _003CAuthenticate_003Ed__6(int _003C_003E1__state)
				{
				}

				[DebuggerHidden]
				[Token(Token = "0x6005B84")]
				[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
				void IDisposable.Dispose()
				{
				}

				[Token(Token = "0x6005B85")]
				[Address(RVA = "0xF2CF20", Offset = "0xF2BD20", Length = "0x217")]
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
				[Token(Token = "0x6005B87")]
				[Address(RVA = "0xF2D140", Offset = "0xF2BF40", Length = "0x3E")]
				void IEnumerator.Reset()
				{
				}
			}

			[Token(Token = "0x40067F5")]
			[FieldOffset(Offset = "0x28")]
			private string m_Token;

			[Token(Token = "0x40067F6")]
			[FieldOffset(Offset = "0x30")]
			private Action<bool> m_OnOperationComplete;

			[Token(Token = "0x40067F7")]
			[FieldOffset(Offset = "0x38")]
			private OperationStatus m_Status;

			[Token(Token = "0x6005B77")]
			[Address(RVA = "0xF2C380", Offset = "0xF2B180", Length = "0xAA")]
			public AuthenticateOperation(string token, Action<bool> onOperationComplete)
			{
			}

			[Token(Token = "0x6005B78")]
			[Address(RVA = "0xF2C430", Offset = "0xF2B230", Length = "0x104")]
			public override void Execute()
			{
			}

			[IteratorStateMachine(typeof(_003CAuthenticate_003Ed__6))]
			[Token(Token = "0x6005B79")]
			[Address(RVA = "0xF2C540", Offset = "0xF2B340", Length = "0x9A")]
			private IEnumerator Authenticate()
			{
				return null;
			}

			[Token(Token = "0x6005B7A")]
			[Address(RVA = "0xF2C5E0", Offset = "0xF2B3E0", Length = "0x14C")]
			private void Update()
			{
			}

			[Token(Token = "0x6005B7B")]
			[Address(RVA = "0xF2C730", Offset = "0xF2B530", Length = "0xEE")]
			private void AuthenticationComplete()
			{
			}

			[Token(Token = "0x6005B7C")]
			[Address(RVA = "0xF2C820", Offset = "0xF2B620", Length = "0x334")]
			private void RetrieveToken()
			{
			}

			[Token(Token = "0x6005B7D")]
			[Address(RVA = "0xF2CB60", Offset = "0xF2B960", Length = "0x224")]
			private void ShowRetryDialog()
			{
			}

			[Token(Token = "0x6005B7E")]
			[Address(RVA = "0xF2CD90", Offset = "0xF2BB90", Length = "0xC")]
			private void CancelAuthentication(bool wasCanceled)
			{
			}

			[Token(Token = "0x6005B7F")]
			[Address(RVA = "0xF2CDA0", Offset = "0xF2BBA0", Length = "0x8")]
			private void RetryAuthentication()
			{
			}

			[Token(Token = "0x6005B80")]
			[Address(RVA = "0xF2CDB0", Offset = "0xF2BBB0", Length = "0x20")]
			private void EnumerateForAuthenticationDone(EnumerateFilesResult result)
			{
			}

			[Token(Token = "0x6005B81")]
			[Address(RVA = "0xF2CDD0", Offset = "0xF2BBD0", Length = "0x14")]
			private void Success()
			{
			}

			[Token(Token = "0x6005B82")]
			[Address(RVA = "0xF2CDF0", Offset = "0xF2BBF0", Length = "0x127")]
			private static void SaveToken(string token)
			{
			}
		}

		[Token(Token = "0x2000A87")]
		public struct AuthenticationResult
		{
			[Token(Token = "0x2000A88")]
			public enum ResultType
			{
				[Token(Token = "0x4006807")]
				Success,
				[Token(Token = "0x4006808")]
				AccessDenied,
				[Token(Token = "0x4006809")]
				MalformedUrlError,
				[Token(Token = "0x400680A")]
				Canceled
			}

			[Token(Token = "0x4006804")]
			[FieldOffset(Offset = "0x0")]
			public ResultType m_Result;

			[Token(Token = "0x4006805")]
			[FieldOffset(Offset = "0x8")]
			public string m_Token;
		}

		[Token(Token = "0x2000A89")]
		public interface ICloudOperation
		{
			[Token(Token = "0x6005B89")]
			bool IsCompleted();

			[Token(Token = "0x6005B8A")]
			bool IsSuccess();

			[Token(Token = "0x6005B8B")]
			bool IsRetryPending();
		}

		[Token(Token = "0x2000A8A")]
		private class CommonCloudOperation : ICloudOperation
		{
			[Token(Token = "0x400680B")]
			[FieldOffset(Offset = "0x10")]
			protected bool m_Completed;

			[Token(Token = "0x400680C")]
			[FieldOffset(Offset = "0x11")]
			protected bool m_Success;

			[Token(Token = "0x400680D")]
			[FieldOffset(Offset = "0x18")]
			protected Action m_OnExecuteStarted;

			[Token(Token = "0x400680E")]
			[FieldOffset(Offset = "0x20")]
			private int m_NumRetries;

			[Token(Token = "0x400680F")]
			[FieldOffset(Offset = "0x24")]
			private int m_RetryCount;

			[Token(Token = "0x6005B8C")]
			[Address(RVA = "0x504260", Offset = "0x503060", Length = "0x5")]
			public bool IsCompleted()
			{
				return false;
			}

			[Token(Token = "0x6005B8D")]
			[Address(RVA = "0x504270", Offset = "0x503070", Length = "0x5")]
			public bool IsSuccess()
			{
				return false;
			}

			[Token(Token = "0x6005B8E")]
			[Address(RVA = "0xF2D180", Offset = "0xF2BF80", Length = "0x19")]
			public bool IsRetryPending()
			{
				return false;
			}

			[Token(Token = "0x6005B8F")]
			[Address(RVA = "0x509350", Offset = "0x508150", Length = "0x4")]
			public void SetNumRetries(int numRetries)
			{
			}

			[Token(Token = "0x6005B90")]
			[Address(RVA = "0xF2D1A0", Offset = "0xF2BFA0", Length = "0x1C")]
			public virtual void Execute()
			{
			}

			[Token(Token = "0x6005B91")]
			[Address(RVA = "0xF2D1C0", Offset = "0xF2BFC0", Length = "0x7")]
			private void Reset()
			{
			}

			[Token(Token = "0x6005B92")]
			[Address(RVA = "0x49DEE0", Offset = "0x49CCE0", Length = "0x52")]
			public void SetOnExecuteStarted(Action onExecuteStarted)
			{
			}

			[Token(Token = "0x6005B93")]
			[Address(RVA = "0xF2D1D0", Offset = "0xF2BFD0", Length = "0x157")]
			public bool Retry()
			{
				return false;
			}

			[Token(Token = "0x6005B94")]
			[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
			public CommonCloudOperation()
			{
			}
		}

		[Token(Token = "0x400675C")]
		public const int MAX_SYNCOPERATION_RETRIES = 3;

		[Token(Token = "0x400675D")]
		[FieldOffset(Offset = "0x10")]
		private Dictionary<CloudSyncStatus, List<EnumerateFilesResult.FileInfo>> m_CloudFilesBySyncStatus;

		[Token(Token = "0x400675E")]
		private static readonly int s_CloudSyncStatusCount;

		[Token(Token = "0x400675F")]
		[FieldOffset(Offset = "0x18")]
		private SyncConflictResult m_SyncConflictResult;

		[Token(Token = "0x4006760")]
		[FieldOffset(Offset = "0x1C")]
		private bool m_SaveFilesSynchronized;

		[Token(Token = "0x4006761")]
		[FieldOffset(Offset = "0x1D")]
		private bool m_SaveFilesSynchronizationStarted;

		[Token(Token = "0x4006762")]
		[FieldOffset(Offset = "0x1E")]
		private bool m_AreCloudFilesNewer;

		[Token(Token = "0x4006763")]
		public const string STEAMCLOUD_SYNCING_LOCID = "STEAMCLOUD_Syncing";

		[Token(Token = "0x4006764")]
		public const string STEAMCLOUD_SYNC_LOCID = "STEAMCLOUD_Sync";

		[Token(Token = "0x4006765")]
		public const string STEAMCLOUD_SYNC_ON_LOCID = "STEAMCLOUD_SyncOn";

		[Token(Token = "0x4006766")]
		public const string STEAMCLOUD_SYNC_OFF_LOCID = "STEAMCLOUD_SyncOff";

		[Token(Token = "0x4006767")]
		public const string STEAMCLOUD_RETRIEVINGFILES_LOCID = "STEAMCLOUD_RetrievingFiles";

		[Token(Token = "0x4006768")]
		public const string STEAMCLOUD_SYNCFAILED_LOCID = "STEAMCLOUD_SynchronizationFailed";

		[Token(Token = "0x4006769")]
		public const string STEAMCLOUD_AUTH_FAILED_LOCID = "STEAMCLOUD_AuthenticationFailed";

		[Token(Token = "0x400676A")]
		public const string STEAMCLOUD_AUTH_RETRY_LOCID = "STEAMCLOUD_RetryAuthentication";

		[Token(Token = "0x400676B")]
		public const string STEAMCLOUD_CONFLICT_TITLE_LOCID = "STEAMCLOUD_ConflictTitle";

		[Token(Token = "0x400676C")]
		public const string STEAMCLOUD_CLOUD_NEWER_LOCID = "STEAMCLOUD_CloudFilesNewerConfirm";

		[Token(Token = "0x400676D")]
		public const string STEAMCLOUD_LOCAL_NEWER_LOCID = "STEAMCLOUD_LocalFilesNewerConfirm";

		[Token(Token = "0x400676E")]
		private const string STEAM_AUTH_URL = "https://steamcommunity.com/oauth/login?response_type=token&state=void&mobileminimal=1";

		[Token(Token = "0x400676F")]
		private const string STEAM_CLIENT_ID = "CEF005FA";

		[Token(Token = "0x4006770")]
		private const string STEAMAUTH_CALLBACKURL = "https://tldnewseditor.com/steamauth";

		[Token(Token = "0x4006771")]
		private const string STEAMAUTH_CALLBACKABLEURL = "https://steamcommunity.com/oauth";

		[Token(Token = "0x4006772")]
		private const string STEAMAUTH_TOKENPARAM = "access_token";

		[Token(Token = "0x4006773")]
		private const string STEAMAUTH_ERRORARAM = "error";

		[Token(Token = "0x4006774")]
		private const string STEAMAUTH_ACCESSDENIED_ERROR = "access_denied";

		[Token(Token = "0x4006775")]
		[FieldOffset(Offset = "0x20")]
		private string m_Token;

		[Token(Token = "0x4006776")]
		private static SteamCloudManager s_Instance;

		[Token(Token = "0x4006777")]
		[FieldOffset(Offset = "0x28")]
		private CommonCloudOperation m_CurrentCloudOperation;

		[Token(Token = "0x4006778")]
		[FieldOffset(Offset = "0x30")]
		private DateTime m_LastEnumerationTime;

		[Token(Token = "0x4006779")]
		[FieldOffset(Offset = "0x38")]
		private List<EnumerateFilesResult.FileInfo> m_CloudFiles;

		[Token(Token = "0x400677A")]
		[FieldOffset(Offset = "0x40")]
		private List<EnumerateFilesResult.FileInfo> m_LocalFiles;

		[Token(Token = "0x400677B")]
		[FieldOffset(Offset = "0x48")]
		private Queue<CommonCloudOperation> m_OperationsQueue;

		[Token(Token = "0x400677C")]
		[FieldOffset(Offset = "0x50")]
		private string m_CurrentMessageId;

		[Token(Token = "0x400677D")]
		private const string STEAM_URL_ENUMERATE = "https://api.steampowered.com/ICloudService/EnumerateUserFiles/v1/";

		[Token(Token = "0x400677E")]
		private const string STEAM_URL_REQUESTUPLOAD = "https://api.steampowered.com/ICloudService/BeginHTTPUpload/v1";

		[Token(Token = "0x400677F")]
		private const string STEAM_URL_COMMITUPLOAD = "https://api.steampowered.com/ICloudService/CommitHTTPUpload/v1";

		[Token(Token = "0x4006780")]
		private const string STEAM_URL_REQUESTDELETE = "https://api.steampowered.com/ICloudService/Delete/v1";

		[Token(Token = "0x4006781")]
		public const string SAVE_CLOUD_PATH = "%WinAppDataLocal%Hinterland/TheLongDark/";

		[Token(Token = "0x4006782")]
		private const string STEAM_APP_ID = "305620";

		[Token(Token = "0x4006783")]
		private const string PLATFORM_TO_SYNC = "All";

		[Token(Token = "0x4006784")]
		[FieldOffset(Offset = "0x58")]
		private Action<bool> m_OnSyncEnabledChanged;

		[Token(Token = "0x4006785")]
		[FieldOffset(Offset = "0x60")]
		private Action m_OnSyncDone;

		[Token(Token = "0x6005AC3")]
		[Address(RVA = "0xF1D420", Offset = "0xF1C220", Length = "0x64")]
		private void EnumerateLocalFiles()
		{
		}

		[Token(Token = "0x6005AC4")]
		[Address(RVA = "0x4A2140", Offset = "0x4A0F40", Length = "0x3")]
		private static bool WriteDownloadedSaveFile(DownloadDataResult result, string filename, DateTime dateTime)
		{
			return false;
		}

		[Token(Token = "0x6005AC5")]
		[Address(RVA = "0xF1D490", Offset = "0xF1C290", Length = "0x54")]
		private static bool ReadSaveFile(string filename, out byte[] bytes)
		{
			bytes = null;
			return false;
		}

		[Token(Token = "0x6005AC6")]
		[Address(RVA = "0x4A2140", Offset = "0x4A0F40", Length = "0x3")]
		private static bool DeleteSaveFile(string filename)
		{
			return false;
		}

		[Token(Token = "0x6005AC7")]
		[Address(RVA = "0xF1D4F0", Offset = "0xF1C2F0", Length = "0x15B")]
		public static bool CloudFileRequiresSync(string fileName)
		{
			return false;
		}

		[Token(Token = "0x6005AC8")]
		[Address(RVA = "0xF1D650", Offset = "0xF1C450", Length = "0x189")]
		public static DateTime GetDateTimeFromSave(byte[] data)
		{
			return default(DateTime);
		}

		[Token(Token = "0x6005AC9")]
		[Address(RVA = "0xF1D7E0", Offset = "0xF1C5E0", Length = "0x14C")]
		public void ReloadSaves()
		{
		}

		[Token(Token = "0x6005ACA")]
		[Address(RVA = "0x4A2140", Offset = "0x4A0F40", Length = "0x3")]
		public bool IsSyncSavesEnabled()
		{
			return false;
		}

		[Token(Token = "0x6005ACB")]
		[Address(RVA = "0xF1D930", Offset = "0xF1C730", Length = "0xD8")]
		public void RetrieveFilesForSync()
		{
		}

		[Token(Token = "0x6005ACC")]
		[Address(RVA = "0xF1DA10", Offset = "0xF1C810", Length = "0xA4")]
		public void HandleSaveDeleted(string saveFilename)
		{
		}

		[Token(Token = "0x6005ACD")]
		[Address(RVA = "0xF1DAC0", Offset = "0xF1C8C0", Length = "0x5D")]
		private void DeleteSaveStarted()
		{
		}

		[Token(Token = "0x6005ACE")]
		[Address(RVA = "0xF1DB20", Offset = "0xF1C920", Length = "0x66")]
		private void DeleteSaveDone(bool res)
		{
		}

		[Token(Token = "0x6005ACF")]
		[Address(RVA = "0xF1DB90", Offset = "0xF1C990", Length = "0x5")]
		public bool HasSyncStarted()
		{
			return false;
		}

		[Token(Token = "0x6005AD0")]
		[Address(RVA = "0xF1DBA0", Offset = "0xF1C9A0", Length = "0x235")]
		public void Sync()
		{
		}

		[Token(Token = "0x6005AD1")]
		[Address(RVA = "0xF1DDE0", Offset = "0xF1CBE0", Length = "0x4F")]
		public void HandleDataSaved(string filename)
		{
		}

		[Token(Token = "0x6005AD2")]
		[Address(RVA = "0xF1DE30", Offset = "0xF1CC30", Length = "0x153")]
		private void AuthenticateForSyncDone(ICloudOperation operation)
		{
		}

		[Token(Token = "0x6005AD3")]
		[Address(RVA = "0xF1DF90", Offset = "0xF1CD90", Length = "0x139")]
		private void ReplaceCloudSave(string cloudFileName)
		{
		}

		[Token(Token = "0x6005AD4")]
		[Address(RVA = "0xF1E0D0", Offset = "0xF1CED0", Length = "0x5D")]
		private void ReplaceCloudSaveStarted()
		{
		}

		[Token(Token = "0x6005AD5")]
		[Address(RVA = "0xF1E130", Offset = "0xF1CF30", Length = "0x66")]
		private void ReplaceCloudSaveDone(ICloudOperation operation)
		{
		}

		[Token(Token = "0x6005AD6")]
		[Address(RVA = "0xF1E1A0", Offset = "0xF1CFA0", Length = "0x69")]
		private void SyncStarted()
		{
		}

		[Token(Token = "0x6005AD7")]
		[Address(RVA = "0xF1E210", Offset = "0xF1D010", Length = "0x5D")]
		private void RetrieveFilesForSyncSyncStarted()
		{
		}

		[Token(Token = "0x6005AD8")]
		[Address(RVA = "0xF1E270", Offset = "0xF1D070", Length = "0x129")]
		private void SyncInternal()
		{
		}

		[Token(Token = "0x6005AD9")]
		[Address(RVA = "0xF1E3A0", Offset = "0xF1D1A0", Length = "0x33D")]
		private void CloudFilesRetrievedForSync(EnumerateFilesResult res)
		{
		}

		[Token(Token = "0x6005ADA")]
		[Address(RVA = "0xF1E6E0", Offset = "0xF1D4E0", Length = "0x13")]
		private void CloudSyncLocalNewerDeclined(bool wasCancelled)
		{
		}

		[Token(Token = "0x6005ADB")]
		[Address(RVA = "0xF1E700", Offset = "0xF1D500", Length = "0xE")]
		private void CloudSyncLocalNewerAccepted()
		{
		}

		[Token(Token = "0x6005ADC")]
		[Address(RVA = "0xF1E710", Offset = "0xF1D510", Length = "0x13")]
		private void CloudSyncNewerDeclined(bool wasCancelled)
		{
		}

		[Token(Token = "0x6005ADD")]
		[Address(RVA = "0xF1E730", Offset = "0xF1D530", Length = "0xE")]
		private void CloudSyncNewerAccepted()
		{
		}

		[Token(Token = "0x6005ADE")]
		[Address(RVA = "0xF1E740", Offset = "0xF1D540", Length = "0x8A0")]
		private void DoSyncOperation()
		{
		}

		[Token(Token = "0x6005ADF")]
		[Address(RVA = "0xF1EFF0", Offset = "0xF1DDF0", Length = "0x5D")]
		private void SyncingFilesOperationStarted()
		{
		}

		[Token(Token = "0x6005AE0")]
		[Address(RVA = "0xF1F050", Offset = "0xF1DE50", Length = "0x3AC")]
		private void SyncDone(ICloudOperation cloudOperation)
		{
		}

		[Token(Token = "0x6005AE1")]
		[Address(RVA = "0xF1F400", Offset = "0xF1E200", Length = "0x16")]
		private void NotifySyncDone()
		{
		}

		[Token(Token = "0x6005AE2")]
		[Address(RVA = "0xF1F420", Offset = "0xF1E220", Length = "0x124")]
		private void ReloadSavesReady()
		{
		}

		[Token(Token = "0x6005AE3")]
		[Address(RVA = "0xF1F550", Offset = "0xF1E350", Length = "0x66B")]
		private bool AreCloudFilesNewer()
		{
			return false;
		}

		[Token(Token = "0x6005AE4")]
		[Address(RVA = "0xF1FBC0", Offset = "0xF1E9C0", Length = "0x425")]
		private void RequestUserConfirmation()
		{
		}

		[Token(Token = "0x6005AE5")]
		[Address(RVA = "0xF1FFF0", Offset = "0xF1EDF0", Length = "0x912")]
		private void GatherFilesStatus()
		{
		}

		[Token(Token = "0x6005AE6")]
		[Address(RVA = "0xF20910", Offset = "0xF1F710", Length = "0x22F")]
		private void ClearCloudFilesBySyncStatus()
		{
		}

		[Token(Token = "0x6005AE7")]
		[Address(RVA = "0xF20B40", Offset = "0xF1F940", Length = "0x17D")]
		private void AddToListIfNotFound(EnumerateFilesResult.FileInfo info, List<EnumerateFilesResult.FileInfo> list)
		{
		}

		[Token(Token = "0x6005AE8")]
		[Address(RVA = "0xF20CC0", Offset = "0xF1FAC0", Length = "0x292")]
		private void AddBatchDownloadSave(BatchOperation batchOperation, List<EnumerateFilesResult.FileInfo> list)
		{
		}

		[Token(Token = "0x6005AE9")]
		[Address(RVA = "0xF20F60", Offset = "0xF1FD60", Length = "0x23C")]
		private void AddBatchUploadSave(BatchOperation batchOperation, List<EnumerateFilesResult.FileInfo> list)
		{
		}

		[Token(Token = "0x6005AEA")]
		[Address(RVA = "0xF211A0", Offset = "0xF1FFA0", Length = "0x23C")]
		private void AddBatchDeleteSave(BatchOperation batchOperation, List<EnumerateFilesResult.FileInfo> list)
		{
		}

		[Token(Token = "0x6005AEB")]
		[Address(RVA = "0xF213E0", Offset = "0xF201E0", Length = "0x282")]
		private void AddBatchDeleteLocalSave(BatchOperation batchOperation, List<EnumerateFilesResult.FileInfo> list)
		{
		}

		[Token(Token = "0x6005AEC")]
		[Address(RVA = "0xF21670", Offset = "0xF20470", Length = "0x205")]
		private void AddBatchUploadReplaceSave(BatchOperation batchOperation, List<EnumerateFilesResult.FileInfo> list)
		{
		}

		[Token(Token = "0x6005AED")]
		[Address(RVA = "0xF21880", Offset = "0xF20680", Length = "0x134")]
		private BatchOperation CreateUploadReplaceSaveFileOperation(string cloudFileName, Action<ICloudOperation> onOperationComplete)
		{
			return null;
		}

		[Token(Token = "0x6005AEE")]
		[Address(RVA = "0xF219C0", Offset = "0xF207C0", Length = "0x2E2")]
		private bool AreFilesIdentical(List<EnumerateFilesResult.FileInfo> filesToCompare)
		{
			return false;
		}

		[Token(Token = "0x6005AEF")]
		[Address(RVA = "0xF21CB0", Offset = "0xF20AB0", Length = "0x356")]
		private EnumerateFilesResult.FileInfo FindFile(string filename, List<EnumerateFilesResult.FileInfo> filesToSearch)
		{
			return default(EnumerateFilesResult.FileInfo);
		}

		[Token(Token = "0x6005AF0")]
		[Address(RVA = "0xF22010", Offset = "0xF20E10", Length = "0x112")]
		private bool FileExists(EnumerateFilesResult.FileInfo fileInfo, List<EnumerateFilesResult.FileInfo> comparedToList)
		{
			return false;
		}

		[Token(Token = "0x6005AF1")]
		[Address(RVA = "0xF22130", Offset = "0xF20F30", Length = "0x1DE")]
		private CloudSyncStatus GetCloudFileSyncStatus(EnumerateFilesResult.FileInfo cloudInfo)
		{
			return default(CloudSyncStatus);
		}

		[Token(Token = "0x6005AF2")]
		[Address(RVA = "0xF22310", Offset = "0xF21110", Length = "0x1E1")]
		private CloudSyncStatus GetLocalFileSyncStatus(EnumerateFilesResult.FileInfo localInfo)
		{
			return default(CloudSyncStatus);
		}

		[Token(Token = "0x6005AF3")]
		[Address(RVA = "0xF22500", Offset = "0xF21300", Length = "0x133")]
		private static bool TryExtractTimeStampFromSave(byte[] data, out DateTime timestamp)
		{
			timestamp = default(DateTime);
			return false;
		}

		[Token(Token = "0x6005AF4")]
		[Address(RVA = "0xF22640", Offset = "0xF21440", Length = "0x13B")]
		private static bool IsSaveOperationInProgress()
		{
			return false;
		}

		[Token(Token = "0x6005AF5")]
		[Address(RVA = "0xF22780", Offset = "0xF21580", Length = "0x17A")]
		public static AuthenticationResult RequestAuthenticationToken()
		{
			return default(AuthenticationResult);
		}

		[Token(Token = "0x6005AF6")]
		[Address(RVA = "0xF22900", Offset = "0xF21700", Length = "0x31")]
		public static string GetAuthenticationRequestUrl()
		{
			return null;
		}

		[Token(Token = "0x6005AF7")]
		[Address(RVA = "0xF22940", Offset = "0xF21740", Length = "0x3E1")]
		private SteamCloudManager()
		{
		}

		[Token(Token = "0x6005AF8")]
		[Address(RVA = "0x40E110", Offset = "0x40CF10", Length = "0x5")]
		public string GetToken()
		{
			return null;
		}

		[Token(Token = "0x6005AF9")]
		[Address(RVA = "0xF22D30", Offset = "0xF21B30", Length = "0xF9")]
		public void SetToken(string token)
		{
		}

		[Token(Token = "0x6005AFA")]
		[Address(RVA = "0xF22E30", Offset = "0xF21C30", Length = "0x97")]
		public void Update()
		{
		}

		[Token(Token = "0x6005AFB")]
		[Address(RVA = "0xF22ED0", Offset = "0xF21CD0", Length = "0x2BE")]
		private void UpdateQueue()
		{
		}

		[Token(Token = "0x6005AFC")]
		[Address(RVA = "0xF23190", Offset = "0xF21F90", Length = "0x7A")]
		public void Authenticate()
		{
		}

		[Token(Token = "0x6005AFD")]
		[Address(RVA = "0xF23210", Offset = "0xF22010", Length = "0x12D")]
		public static SteamCloudManager GetInstance()
		{
			return null;
		}

		[Token(Token = "0x6005AFE")]
		[Address(RVA = "0xF23340", Offset = "0xF22140", Length = "0x15")]
		private bool HasSyncMessage()
		{
			return false;
		}

		[Token(Token = "0x6005AFF")]
		[Address(RVA = "0xF23360", Offset = "0xF22160", Length = "0x90")]
		private void UpdateSyncMessage()
		{
		}

		[Token(Token = "0x6005B00")]
		[Address(RVA = "0xF23400", Offset = "0xF22200", Length = "0x58")]
		private void QueueOperation(CommonCloudOperation cloudOperation)
		{
		}

		[Token(Token = "0x6005B01")]
		[Address(RVA = "0xF23460", Offset = "0xF22260", Length = "0x126")]
		private CommonCloudOperation CreateFileEnumerationOperationForSync(Action<EnumerateFilesResult> onActionComplete, Action onOperationStarted)
		{
			return null;
		}

		[Token(Token = "0x6005B02")]
		[Address(RVA = "0xF23590", Offset = "0xF22390", Length = "0x145")]
		public void GetAllFiles(Action<EnumerateFilesResult> onActionComplete, Action onOperationStarted, int numRetries)
		{
		}

		[Token(Token = "0x6005B03")]
		[Address(RVA = "0xF236E0", Offset = "0xF224E0", Length = "0x5C")]
		public bool IsOperationPending()
		{
			return false;
		}

		[Token(Token = "0x6005B04")]
		[Address(RVA = "0x4A2140", Offset = "0x4A0F40", Length = "0x3")]
		public bool IsSyncPending()
		{
			return false;
		}

		[Token(Token = "0x6005B05")]
		[Address(RVA = "0xF23740", Offset = "0xF22540", Length = "0x85")]
		public void DeleteAllCloudFiles()
		{
		}

		[Token(Token = "0x6005B06")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public void EnableSyncSaves(bool enabled)
		{
		}

		[Token(Token = "0x6005B07")]
		[Address(RVA = "0x4A2140", Offset = "0x4A0F40", Length = "0x3")]
		public bool AreSaveFilesSynchronized()
		{
			return false;
		}

		[Token(Token = "0x6005B08")]
		[Address(RVA = "0xF237D0", Offset = "0xF225D0", Length = "0xE6")]
		public void RegisterSyncEnabledChanged(Action<bool> onSyncEnabledChanged)
		{
		}

		[Token(Token = "0x6005B09")]
		[Address(RVA = "0xF238C0", Offset = "0xF226C0", Length = "0xE6")]
		public void UnRegisterSyncEnabledChanged(Action<bool> onSyncEnabledChanged)
		{
		}

		[Token(Token = "0x6005B0A")]
		[Address(RVA = "0xF239B0", Offset = "0xF227B0", Length = "0xE0")]
		public void RegisterSyncDone(Action onSyncDone)
		{
		}

		[Token(Token = "0x6005B0B")]
		[Address(RVA = "0xF23AA0", Offset = "0xF228A0", Length = "0xE0")]
		public void UnRegisterSyncDone(Action onSyncDone)
		{
		}

		[Token(Token = "0x6005B0C")]
		[Address(RVA = "0xF23B90", Offset = "0xF22990", Length = "0x241")]
		public static void DebugLogFiles(EnumerateFilesResult result)
		{
		}

		[Token(Token = "0x6005B0D")]
		[Address(RVA = "0xF23DE0", Offset = "0xF22BE0", Length = "0x256")]
		public static void ShowSyncMessage(string locId)
		{
		}

		[Token(Token = "0x6005B0E")]
		[Address(RVA = "0xF24040", Offset = "0xF22E40", Length = "0x1A9")]
		public static void HideSyncMessage()
		{
		}

		[Token(Token = "0x6005B0F")]
		[Address(RVA = "0xF241F0", Offset = "0xF22FF0", Length = "0xB4")]
		public static string GetCloudSaveFilename(string filename)
		{
			return null;
		}

		[Token(Token = "0x6005B10")]
		[Address(RVA = "0xF242B0", Offset = "0xF230B0", Length = "0x12")]
		private bool IsCurrentOperationPending()
		{
			return false;
		}

		[Token(Token = "0x6005B11")]
		[Address(RVA = "0xF242D0", Offset = "0xF230D0", Length = "0x1B6")]
		private void ProcessOperation(CommonCloudOperation cloudOperation, int numRetries)
		{
		}

		[Token(Token = "0x6005B12")]
		[Address(RVA = "0xF24490", Offset = "0xF23290", Length = "0x15")]
		private bool HasToken()
		{
			return false;
		}

		[Token(Token = "0x6005B13")]
		[Address(RVA = "0xF244B0", Offset = "0xF232B0", Length = "0x371")]
		private void FileEnumerationForSyncComplete(EnumerateFilesResult result)
		{
		}

		[Token(Token = "0x6005B14")]
		[Address(RVA = "0xF24830", Offset = "0xF23630", Length = "0x34D")]
		private void EnumerateForDeleteAllDone(EnumerateFilesResult result)
		{
		}

		[Token(Token = "0x6005B15")]
		[Address(RVA = "0xF24B80", Offset = "0xF23980", Length = "0x272")]
		private static UILabel GetCurrentMessageLabel()
		{
			return null;
		}

		[Token(Token = "0x6005B16")]
		[Address(RVA = "0xF24E00", Offset = "0xF23C00", Length = "0xC6")]
		private static void RefreshCurrentSaveUI()
		{
		}

		[Token(Token = "0x6005B17")]
		[Address(RVA = "0x1A6F8D0", Offset = "0x1A6E6D0", Length = "0xCB")]
		private static void RefreshSaveUI<T>(SaveSlotType saveSlotType) where T : Panel_Base
		{
		}
	}

	[Token(Token = "0x2000A8B")]
	public struct DownloadDataResult
	{
		[Token(Token = "0x4006810")]
		[FieldOffset(Offset = "0x0")]
		public bool m_Success;

		[Token(Token = "0x4006811")]
		[FieldOffset(Offset = "0x8")]
		public byte[] m_Result;

		[Token(Token = "0x4006812")]
		[FieldOffset(Offset = "0x10")]
		public string m_Error;
	}

	[Token(Token = "0x2000A8C")]
	public class SteamCloudManagerPC
	{
		[Token(Token = "0x6005B95")]
		[Address(RVA = "0xF2D330", Offset = "0xF2C130", Length = "0x4DB")]
		public static void EnumerateLocalSaveFiles(List<SteamCloudManager.EnumerateFilesResult.FileInfo> list)
		{
		}

		[Token(Token = "0x6005B96")]
		[Address(RVA = "0xF2D810", Offset = "0xF2C610", Length = "0x190")]
		public static bool ReadSaveFile(string filename, out byte[] bytes)
		{
			bytes = null;
			return false;
		}

		[Token(Token = "0x6005B97")]
		[Address(RVA = "0xF2D9A0", Offset = "0xF2C7A0", Length = "0xD9")]
		public static bool DeleteSaveFile(string filename)
		{
			return false;
		}

		[Token(Token = "0x6005B98")]
		[Address(RVA = "0xF2DA80", Offset = "0xF2C880", Length = "0x37B")]
		public static bool WriteDownloadedSaveFile(byte[] result, string filename, DateTime dateTime)
		{
			return false;
		}

		[Token(Token = "0x6005B99")]
		[Address(RVA = "0xF2DE00", Offset = "0xF2CC00", Length = "0x5B")]
		private static string GetDownloadDirectory()
		{
			return null;
		}

		[Token(Token = "0x6005B9A")]
		[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
		public SteamCloudManagerPC()
		{
		}
	}

	[Token(Token = "0x400675A")]
	private static readonly DateTime EPOCH_TIME;

	[Token(Token = "0x400675B")]
	private static bool s_DebugVerbose;

	[Token(Token = "0x6005AB9")]
	[Address(RVA = "0xF1CC10", Offset = "0xF1BA10", Length = "0x41")]
	public static string ShowWebPage(string requestedUrl, string callbackUrl, string callbackableUrl)
	{
		return null;
	}

	[Token(Token = "0x6005ABA")]
	[Address(RVA = "0xF1CC60", Offset = "0xF1BA60", Length = "0x19A")]
	public static string GetParamFromURI(string uri, char fragmentstart, string param)
	{
		return null;
	}

	[Token(Token = "0x6005ABB")]
	[Address(RVA = "0xF1CE00", Offset = "0xF1BC00", Length = "0xF9")]
	public static DateTime FromUnixTime(ulong unixTime)
	{
		return default(DateTime);
	}

	[Token(Token = "0x6005ABC")]
	[Address(RVA = "0xF1CF00", Offset = "0xF1BD00", Length = "0x194")]
	public static string ComputeSha1Hex(byte[] data)
	{
		return null;
	}

	[Token(Token = "0x6005ABD")]
	[Address(RVA = "0xF1D0A0", Offset = "0xF1BEA0", Length = "0x43")]
	public static void DebugLogVerbose(string txt)
	{
	}

	[Token(Token = "0x6005ABE")]
	[Address(RVA = "0xF1D0F0", Offset = "0xF1BEF0", Length = "0x57")]
	public static void ToggleVerbose()
	{
	}

	[Token(Token = "0x6005ABF")]
	[Address(RVA = "0x4582A0", Offset = "0x4570A0", Length = "0x3")]
	private static string ShowWebPageInternal(string requestedUrl, string callbackUrl, string callbackableUrl)
	{
		return null;
	}

	[Token(Token = "0x6005AC0")]
	[Address(RVA = "0xF1D150", Offset = "0xF1BF50", Length = "0x23A")]
	public static void DownloadData(string url, Action<DownloadDataResult> onCompleted)
	{
	}

	[Token(Token = "0x6005AC1")]
	[Address(RVA = "0x407D80", Offset = "0x406B80", Length = "0x3")]
	public WebUtils()
	{
	}
}
