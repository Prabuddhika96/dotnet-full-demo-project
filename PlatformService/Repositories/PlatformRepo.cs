using PlatformService.Data;
using PlatformService.Models;

namespace PlatformService.Repositories
{
    public class PlatformRepo : IPlatformRepo
    {
        private readonly AppDbContext _context;
        public PlatformRepo(AppDbContext context)
        {
            this._context = context;
        }
        public void CreatePlatform(Platform platform)
        {
            if(platform == null){
                throw new ArgumentNullException(nameof(platform));
            }
            _context.Platforms.Add(platform);
            SaveChanges();
        }

        public IEnumerable<Platform> GetAllPlatforms()
        {
            return _context.Platforms.ToList();
        }

        public Platform GetPlatformById(int id)
        {
            return _context.Platforms.FirstOrDefault(plt => plt.Id == id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}
