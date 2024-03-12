namespace Gaeasoft.Magensa.Processors.Model
{
	public class ProcessManualEntryRequestDto : BaseMagensaProcessRequest
    {
	    public string CVV { get; set; }
        public string State { get; set; }
        public string PAN { get; set; }
        public string NameOnCard { get; set; }
        public string ExpirationDate { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine1 { get; set; } 
    }
}
