using Microsoft.AspNetCore.Mvc;
using Movies.Common.DTOs;

namespace Movies.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Produces("application/json")]
    public class MovieController : ControllerBase
    {
        private readonly ILogger<MovieController> _logger;
        private readonly Service.Interfaces.IMovies _movieService;

        public MovieController(ILogger<MovieController> logger, Service.Interfaces.IMovies movieService)
        {
            _logger = logger;
            _movieService = movieService;
        }

        [HttpGet]
        public ActionResult<List<MovieDTO>> GetAll() => 
            Ok(_movieService.GetAll());

    }
}
