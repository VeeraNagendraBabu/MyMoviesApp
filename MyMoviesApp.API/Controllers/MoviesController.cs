using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyMoviesApp.API.Models;
using MyMoviesApp.API.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyMoviesApp.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly ILogger<MoviesController> _logger;
        private readonly IMoviesRepository _moviesRepository;
        public MoviesController(ILogger<MoviesController> logger, IMoviesRepository moviesRepository)
        {
            _logger = logger;
            _moviesRepository = moviesRepository;
        }

        [HttpGet]
        [ActionName("Movies")]
        public IEnumerable<Movie> GetMovies()
        {
            return _moviesRepository.GetMovies();
        }
        [HttpGet("{Title}")]
        [ActionName("MovieByTitle")]
        public List<Movie> SearchMoviesBasedOnTitle(String Title)
        {
            return _moviesRepository.SearchMoviesBasedOnTitle(Title);

        }
        [HttpGet("{ImdbID}")]
        [ActionName("MovieByImdbID")]
        public Movie GetMovieBasedOnImdbID(String ImdbID)
        {
            return _moviesRepository.GetMovieBasedOnImdbID(ImdbID);
        }

    }
}
