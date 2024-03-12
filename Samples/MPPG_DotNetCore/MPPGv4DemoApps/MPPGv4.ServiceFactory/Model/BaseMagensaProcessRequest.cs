namespace Gaeasoft.Magensa.Processors.Model
{
	public enum MagensaTransactionType
	{
		SALE, AUTHORIZE, CAPTURE, VOID, REFUND, FORCE, REJECT, TOKEN
	}

	public enum PaymentMode
	{
		EMV, MagStripe
	}
	public class BaseMagensaProcessRequest
	{
		public BaseMagensaProcessRequest()
		{
			ProcessorName = "Production";
#if DEBUG
			ProcessorName = "Pilot";
			Username = "MAG906611220";
			Password = "@cy6yeyV@Yv7dN";
			CustomerCode = "TA2393256";
			CustomerTransactionID = "1";
			//(MID) 768618117442
			//MultiPASS UserID: TA2393256
			//Authorization Terminal ID: 76200933
			//DeviceID: 76861811744201 
#endif
		}
		public string CustomerCode { get; set; }
		public string Password { get; set; }
		public string Username { get; set; }
		public string CustomerTransactionID { get; set; }

		public string ProcessorName { get; set; }
		public MagensaTransactionType TransactionType { get; set; }
		public decimal? Amount { get; set; } = 1;

		public string ServiceDescription { get; set; }

		public string RefTransId { get; set; }

		public string RefAuthCode { get; set; }

		public string GetTransactionInput()
		{
			var output = $"<mpp1:TransactionType>{TransactionType.ToString()}</mpp1:TransactionType>";
			if (!string.IsNullOrEmpty(RefAuthCode))
				output += $@"<mpp1:ReferenceAuthCode>{RefAuthCode}</mpp1:ReferenceAuthCode>";
			if (!string.IsNullOrEmpty(RefTransId))
				output += $@"<mpp1:ReferenceTransactionID>{RefTransId}</mpp1:ReferenceTransactionID>";
			return output;
		}

		public string GetAuthSection()
		{
			return $@"<mpp1:Authentication>
			            <mpp1:CustomerCode>{CustomerCode}</mpp1:CustomerCode>
			            <mpp1:Password>{Password}</mpp1:Password>
			            <mpp1:Username>{Username}</mpp1:Username>
					</mpp1:Authentication>";
		}
	}
}