 
using MPPGv4.ServiceFactory.Model;

namespace MPPGv4.ServiceFactory
{
    public interface IProcessDataClient
    {
        ProcessDataResponseDto ProcessData(ProcessDataRequestDto processDataRequestDto);
    }
}
