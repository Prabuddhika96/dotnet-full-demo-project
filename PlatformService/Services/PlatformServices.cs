using PlatformService.Models;
using PlatformService.Repositories;

namespace PlatformService.Services
{
    public class PlatformServices : IPlatformService
    {
        private readonly IPlatformRepo _repo;
        public PlatformServices(IPlatformRepo repo)
        {
            this._repo = repo;
        }
        public void CreatePlatform(Platform platform)
        {
            _repo.CreatePlatform(platform);
        }

        public IEnumerable<Platform> GetAllPlatforms()
        {
            return _repo.GetAllPlatforms();
        }

        public Platform GetPlatformById(int id)
        {
            return _repo.GetPlatformById(id);
        }
    }
}
