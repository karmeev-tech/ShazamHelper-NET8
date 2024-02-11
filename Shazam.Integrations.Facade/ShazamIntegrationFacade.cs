
using MapsterMapper;
using MetaMusic.Integrations.Facade.Client;
using MetaMusic.Integrations.Facade.Contracts;
using MetaMusic.Integrations.Facade.Contracts.Dtos;
using MetaMusic.Integrations.Facade.Reponses;

namespace MetaMusic.Integrations.Facade;

public class ShazamIntegrationFacade : IShazamIntegrationFacade
{
    private readonly IMapper _mapper;

    public ShazamIntegrationFacade(IMapper mapper)
    {
        _mapper = mapper;
    }

    public async Task<DetectSongDto> DetectSong(SongDto dto)
    {
        if (dto.FileBase64 is "" or null) throw new ArgumentNullException();
        var model = await ShazamClient.MakeRequest<DetectSongResponse>(dto.FileBase64);
        var result = _mapper.Map<DetectSongDto>(model);
        return result;
    }
}