 
using Gaeasoft.Magensa.Processors.Model;

namespace Gaeasoft.Magensa.Processors
{
    public interface IProcessManualEntryClient
    {
        ProcessManualEntryResponseDto ProcessManualEntry(ProcessManualEntryRequestDto processManualEntryRequestDto);
    }
}
