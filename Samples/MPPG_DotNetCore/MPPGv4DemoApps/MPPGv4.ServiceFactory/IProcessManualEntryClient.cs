 
using MPPGv4.ServiceFactory.Model;

namespace MPPGv4.ServiceFactory
{
    public interface IProcessManualEntryClient
    {
        ProcessManualEntryResponseDto ProcessManualEntry(ProcessManualEntryRequestDto processManualEntryRequestDto);
    }
}
