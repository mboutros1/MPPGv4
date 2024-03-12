using System.Collections.Generic;

namespace Gaeasoft.Magensa.Processors
{
	internal class Constants
	{
		public const string MPPGV4SERVICEURL = "MPPGV4SERVICEURL";
		public const string CERTIFICATE_FILENAME = "CERTIFICATE_FILENAME";
		public const string CERTIFICATE_PASSWORD = "CERTIFICATE_PASSWORD";
		public static List<string> DateFormatTypes = new List<string> { "TLV" };
	}

	internal enum MagensaTransactionType
	{
		SALE, AUTHORIZE, CAPTURE, VOID, REFUND, FORCE, REJECT, TOKEN
	}

	internal enum PaymentMode
	{
		EMV, MagStripe
	}
}
