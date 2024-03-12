 
using Gaeasoft.Magensa.Processors.Model;

namespace Gaeasoft.Magensa.Processors
{
    public interface IProcessCardSwipeClient
    {
        ProcessCardSwipeResponseDto ProcessCardSwipe(ProcessCardSwipeRequestDto processCardSwipeRequestDto);
    }
}
