using MyMoviesApp.API.Repository;
using System;
using System.Collections.Generic;
using Xunit;

namespace MyMoviesApp.Tests
{
    public class MoviesUnitTests
    {
        [Fact]
        public void GetAllMovies()
        {
            var moviesRepo = new MoviesRepository();

            var countOfMovies = moviesRepo.GetMovies();
            Assert.Null(countOfMovies );
        }
    }
}
