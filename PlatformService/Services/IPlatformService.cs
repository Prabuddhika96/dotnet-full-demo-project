using PlatformService.Models;

namespace PlatformService.Services
{
    public interface IPlatformService
    {
        IEnumerable<Platform> GetAllPlatforms();
        Platform GetPlatformById(int id);
        void CreatePlatform(Platform platform);
    }
}
