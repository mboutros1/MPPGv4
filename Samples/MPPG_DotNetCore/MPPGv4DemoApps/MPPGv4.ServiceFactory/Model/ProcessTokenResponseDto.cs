namespace Gaeasoft.Magensa.Processors.Model
{

	public class BaseMagensaProcessResponse
	{
		public int? StatusCode { get; set; }
		public string PageContent { get; set; }
    }
    public class ProcessTokenResponseDto: BaseMagensaProcessResponse
    {
     
    }
    public class ProcessManualEntryResponseDto : BaseMagensaProcessResponse
    { 
    }

    public class ProcessKeyPadEntryResponseDto : BaseMagensaProcessResponse
    { 
    }


    public class ProcessDataResponseDto : BaseMagensaProcessResponse
    { 

    }

    public class ProcessCardSwipeResponseDto : BaseMagensaProcessResponse
    { 
    }
}
