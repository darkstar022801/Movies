using Movies.Common.DTOs;
using Movies.Data.Entities;
using Movies.Service.Interfaces;

namespace Movies.Service.Implementations
{
    public class Movies : IMovies
    {
        private readonly List<Data.Entities.Movie> _movies;

        public Movies()
        {
            _movies = Data.Entities.Movie.GetMovies();
        }

        public List<MovieDTO> GetAll() => MovieDTO.FromList(_movies);
    }
}
