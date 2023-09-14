using AutoMapper;
using ManagementOfWatchedFilms.API.Models.Movie;
using ManagementOfWatchedFilms.Domain.Entity;

namespace ManagementOfWatchedFilms.API.Infrastructure.AutoMapper.Profiles
{
    public class MovieProfile : Profile
    {
        public MovieProfile()
        {
            CreateMap<MovieCreateRequest, Movie>()
                .ReverseMap();

            CreateMap<MovieEditRequest, Movie>()
                .ReverseMap();

            CreateMap<MovieResponse, Movie>()
                .ReverseMap();
        }
    }
}