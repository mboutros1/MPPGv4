namespace MPPGv4.ServiceFactory.Model
{
	public class ProcessKeyPadEntryRequestDto : BaseMagensaProcessRequest
    { 
        public string CVV { get; set; }
        public string ZIP { get; set; }
        public string DeviceSN { get; set; }
        public string KSN { get; set; }
        public string MagnePrint { get; set; }
        public string MagnePrintStatus { get; set; }
        public string Track1 { get; set; }
        public string Track2 { get; set; }
        public string Track3 { get; set; } 
        
    }
}
