 
using Gaeasoft.Magensa.Processors.Model;

namespace Gaeasoft.Magensa.Processors
{
    public interface IProcessDataClient
    {
        ProcessDataResponseDto ProcessData(ProcessDataRequestDto processDataRequestDto);
    }
}
