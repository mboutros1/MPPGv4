 
using Gaeasoft.Magensa.Processors.Model;

namespace Gaeasoft.Magensa.Processors
{
    public interface IProcessTokenClient
    {
        ProcessTokenResponseDto ProcessToken(ProcessTokenRequestDto processTokenRequestDto);
    }
}
