 
using MPPGv4.ServiceFactory.Model;

namespace MPPGv4.ServiceFactory
{
    public interface IProcessTokenClient
    {
        ProcessTokenResponseDto ProcessToken(ProcessTokenRequestDto processTokenRequestDto);
    }
}
