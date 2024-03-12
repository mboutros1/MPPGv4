namespace MPPGv4.ServiceFactory.Model
{
	public class ProcessCardSwipeRequestDto : BaseMagensaProcessRequest
	{
		public string DeviceSN { get; set; }
		public string KSN { get; set; }
		public string MagnePrint { get; set; }
		public string MagnePrintStatus { get; set; }
		public string Track1 { get; set; }
		public string Track2 { get; set; }
		public string Track3 { get; set; } 
	}

	public class ProcessDataRequestDto : BaseMagensaProcessRequest
	{
		public string Data { get; set; }
		public string DataFormatType { get; set; }
		public string EncryptionType { get; set; }
		public string KSN { get; set; }
		public int NumberOfPaddedBytes { get; set; }
		public string IsEncrypted { get; set; }
		public string PaymentMode { get; set; }

	}
	public class ProcessTokenRequestDto : BaseMagensaProcessRequest
	{
		public string Token { get; set; }
		public string AdditionalRequestData_Key { get; set; }
		public string AdditionalRequestData_Value { get; set; }
	}
}
