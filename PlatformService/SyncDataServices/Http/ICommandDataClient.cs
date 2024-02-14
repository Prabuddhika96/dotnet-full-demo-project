using PlatformService.DTOs;

namespace PlatformService.SyncDataSerices.Http
{
    public interface ICommandDataClient
    {
        Task SendPlatformToCommand(PlatformReadDto platform);
    }
}