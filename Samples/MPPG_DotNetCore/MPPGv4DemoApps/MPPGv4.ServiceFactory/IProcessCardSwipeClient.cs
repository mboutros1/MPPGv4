 
using MPPGv4.ServiceFactory.Model;

namespace MPPGv4.ServiceFactory
{
    public interface IProcessCardSwipeClient
    {
        ProcessCardSwipeResponseDto ProcessCardSwipe(ProcessCardSwipeRequestDto processCardSwipeRequestDto);
    }
}
