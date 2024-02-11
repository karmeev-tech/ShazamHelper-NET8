namespace MetaMusic.Integrations.Facade.Contracts.Dtos;

public class DetectSongDto
{
    public TrackDto? TrackDto { get; init; }
}

public class TrackDto
{
    public string? Title { get; init; }
    public string? SubTitle { get; init; }
    public GenresDto? GenresDto { get; init; }
    public List<SectionsDto>? Sections { get; init; }
}

public class GenresDto
{
    public string? Primary { get; init; }
}
public class SectionsDto
{
    public SectionsTypeEnum TypeEnum { get; init; }
    public List<MetaPagesDto>? MetaPagesModel { get; init; }
    public List<MetaDataDto>? Metadata { get; init; }
    public YoutubeUrlDto? YoutubeUrlDto { get; init; }
}
public enum SectionsTypeEnum
{
    SONG, VIDEO, RELATED
}
public class MetaPagesDto
{
    public string? Image { get; init; }
    public string? Caption { get; init; }
}
public class MetaDataDto
{
    public string? Title { get; init; }
    public string? Text { get; init; }
}
public class YoutubeUrlDto
{
    public string? Caption { get; init; }
    public List<ActionsDto>? Actions { get; init; }
    
}
public class ActionsDto
{
    public string? Uri { get; init; }
}