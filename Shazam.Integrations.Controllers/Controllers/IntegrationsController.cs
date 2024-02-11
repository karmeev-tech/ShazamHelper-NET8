using MetaMusic.Integrations.Facade.Contracts;
using MetaMusic.Integrations.Facade.Contracts.Dtos;
using MetaMusic.Integrations.Models;
using Microsoft.AspNetCore.Mvc;

namespace MetaMusic.Integrations.Controllers;

[Route("api/[controller]")]
[ApiController]
public class IntegrationsController : ControllerBase
{
    private readonly IShazamIntegrationFacade _shazamIntegrationFacade;
    private readonly IFileFacade _fileFacade;
    public IntegrationsController(
        IShazamIntegrationFacade shazamIntegrationFacade,
        IFileFacade fileFacade)
    {
        _shazamIntegrationFacade = shazamIntegrationFacade;
        _fileFacade = fileFacade;
    }

    [HttpPost("/GetMetadata")]
    public async Task<IActionResult> GetMusicMetadata([FromQuery] SongModel song)
    {
        try
        {
            //base map
            var dto = new SongRequiredInfoDto { FilePath = song.FilePath };
            //
            var requiredData = _fileFacade.GetSongFileAsBase64String(dto);

            var songDto = new SongDto { FileBase64 = requiredData };

            var result = await _shazamIntegrationFacade.DetectSong(songDto);
            
            return Ok(result);
        }
        catch (Exception ex)
        {
            return BadRequest(ex);
        }
    }
    
    [HttpPost("/base/GetMetadata")]
    public IActionResult GetMusicMetadata([FromQuery] CompleteSongModel song)
    {
        try
        {
            return Ok();
        }
        catch (Exception ex)
        {
            return BadRequest(ex);
        }
    }
}