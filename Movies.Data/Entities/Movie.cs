using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Movies.Data.Entities
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public static List<Movie> GetMovies() 
        {
            string jsonData = File.ReadAllText("../Movies.Data/Movies.json");
            return JsonSerializer.Deserialize<List<Movie>>(jsonData);
        }
    }
}
