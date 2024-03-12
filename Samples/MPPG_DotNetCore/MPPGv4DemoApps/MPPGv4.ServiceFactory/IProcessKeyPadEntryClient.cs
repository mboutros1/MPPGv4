 
using MPPGv4.ServiceFactory.Model;

namespace MPPGv4.ServiceFactory
{
    public interface IProcessKeyPadEntryClient
    {
        ProcessKeyPadEntryResponseDto ProcessKeyPadEntry(ProcessKeyPadEntryRequestDto processKeyPadEntryRequestDto);
    }
}
