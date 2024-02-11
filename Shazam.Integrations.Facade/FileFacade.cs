using MetaMusic.Integrations.Facade.Contracts;
using MetaMusic.Integrations.Facade.Contracts.Dtos;

namespace MetaMusic.Integrations.Facade;

public class FileFacade : IFileFacade
{
    public string GetSongFileAsBase64String(SongRequiredInfoDto dto)
    {
        if (dto.FilePath is "" or null) throw new ArgumentNullException();
        var bytes = File.ReadAllBytes(dto.FilePath);
        var base64 = Convert.ToBase64String(bytes);
        return base64;
    }
}