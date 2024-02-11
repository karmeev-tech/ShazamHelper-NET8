using Newtonsoft.Json;

namespace MetaMusic.Integrations.Facade.Reponses;

public class DetectSongResponse
{
    [JsonProperty("track")]
    public Track? Track { get; init; }
}
public class Track
{
    [JsonProperty("title")]
    public string? Title { get; init; }
    [JsonProperty("subtitle")]
    public string? SubTitle { get; init; }
    [JsonProperty("genres")]
    public Genres? Genres { get; init; }
    [JsonProperty("sections")]
    public List<Sections>? Sections { get; init; }
}
public class Genres
{
    [JsonProperty("primary")]
    public string? Primary { get; init; }
}
public class Sections
{
    [JsonProperty("type")]
    public SectionsType Type { get; init; }
    [JsonProperty("metapages")]
    public List<MetaPages>? MetaPagesModel { get; init; }
    [JsonProperty("metadata")]
    public List<MetaData>? Metadata { get; init; }
    [JsonProperty("youtubeurl")]
    public YoutubeUrl? YoutubeUrl { get; init; }
}
public enum SectionsType
{
    SONG, VIDEO, RELATED
}
public class MetaPages
{
    [JsonProperty("image")]
    public string? Image { get; init; }
    [JsonProperty("caption")]
    public string? Caption { get; init; }
}
public class MetaData
{
    [JsonProperty("title")]
    public string? Title { get; init; }
    [JsonProperty("text")]
    public string? Text { get; init; }
}
public class YoutubeUrl
{
    [JsonProperty("caption")]
    public string? Caption { get; init; }
    [JsonProperty("actions")]
    public List<Actions>? Actions { get; init; }
    
}
public class Actions
{
    [JsonProperty("uri")]
    public string? Uri { get; init; }
}