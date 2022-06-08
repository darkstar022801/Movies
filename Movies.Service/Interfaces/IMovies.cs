using Movies.Common.DTOs;

namespace Movies.Service.Interfaces
{
    public interface IMovies
    {
        List<MovieDTO> GetAll();
    }
}
