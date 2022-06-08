namespace Movies.Common.DTOs
{
    public class MovieDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public static MovieDTO From(Data.Entities.Movie movie)
        {
            return new MovieDTO
            {
                Id = movie.Id,
                Name = movie.Name
            };
        }

        public static List<MovieDTO> FromList(List<Data.Entities.Movie> movies)
        {
            var list = new List<MovieDTO>();
            movies.ForEach(x => { list.Add(From(x)); });
            return list;
        }
    }
}
