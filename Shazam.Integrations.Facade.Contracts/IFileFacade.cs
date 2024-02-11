using MetaMusic.Integrations.Facade.Contracts.Dtos;

namespace MetaMusic.Integrations.Facade.Contracts;

public interface IFileFacade
{
    string GetSongFileAsBase64String(SongRequiredInfoDto dto);
}