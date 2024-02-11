using MetaMusic.Integrations.Facade.Contracts.Dtos;

namespace MetaMusic.Integrations.Facade.Contracts;

public interface IShazamIntegrationFacade
{
    Task<DetectSongDto> DetectSong(SongDto dto);
}