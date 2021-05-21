using MyMoviesApp.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyMoviesApp.API.Repository
{
    public interface IMoviesRepository
    {
        List<Movie> GetMovies();
    }
}
