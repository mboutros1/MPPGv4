 
using Gaeasoft.Magensa.Processors.Model;

namespace Gaeasoft.Magensa.Processors
{
    public interface IProcessKeyPadEntryClient
    {
        ProcessKeyPadEntryResponseDto ProcessKeyPadEntry(ProcessKeyPadEntryRequestDto processKeyPadEntryRequestDto);
    }
}
