using Mapster;
using MetaMusic.Integrations.Facade.Contracts.Dtos;
using MetaMusic.Integrations.Facade.Reponses;

namespace MetaMusic.Integrations.Facade.Mapping;

public static class MapperConfig
{
    public static void Register(this TypeAdapterConfig config)
    {
        config.NewConfig<DetectSongResponse, DetectSongDto>()
            .Map(dest => dest.TrackDto, y => y.Track);
        config.NewConfig<DetectSongDto, DetectSongResponse>()
            .Map(dest => dest.Track, y => y.TrackDto);
        config.NewConfig<Track, TrackDto>()
            .Map(dest => dest.Title, y => y.Title)
            .Map(dest => dest.SubTitle, y => y.SubTitle)
            .Map(dest => dest.GenresDto, y => y.Genres)
            .Map(dest => dest.Sections, y => y.Sections);
        config.NewConfig<Genres, GenresDto>()
            .Map(dest => dest.Primary, y => y.Primary);
        config.NewConfig<Sections, SectionsDto>()
            .Map(dest => dest.TypeEnum, y => y.Type)
            .Map(dest => dest.MetaPagesModel, y => y.MetaPagesModel)
            .Map(dest => dest.Metadata, y => y.Metadata)
            .Map(dest => dest.YoutubeUrlDto, y => y.YoutubeUrl);
        config.NewConfig<SectionsType, SectionsTypeEnum>()
            .Map(dest => dest, y => y);
        config.NewConfig<MetaPages, MetaPagesDto>()
            .Map(dest => dest.Image, y => y.Image)
            .Map(dest => dest.Caption, y => y.Caption);
        config.NewConfig<MetaData, MetaDataDto>()
            .Map(dest => dest.Title, y => y.Title)
            .Map(dest => dest.Text, y => y.Text);
        config.NewConfig<YoutubeUrl, YoutubeUrlDto>()
            .Map(dest => dest.Caption, y => y.Caption)
            .Map(dest => dest.Actions, y => y.Actions);
        config.NewConfig<Actions, ActionsDto>()
            .Map(dest => dest.Uri, y => y.Uri);
    }
}