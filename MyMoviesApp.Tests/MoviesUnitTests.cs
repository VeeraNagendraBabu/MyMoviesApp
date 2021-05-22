using MyMoviesApp.API.Repository;
using System;
using System.Collections.Generic;
using Xunit;

namespace MyMoviesApp.Tests
{
    public class MoviesUnitTests
    {
        [Fact]
        public void GetAllMovies_shouldReturnCountGreaterThanZero()
        {
            var moviesRepo = new MoviesRepository();

            var countOfMovies = moviesRepo.GetMovies();
            Assert.True(countOfMovies.Count > 0);
        }
        [Fact]
        public void SearchMoviesBasedOnTitle_ValidSearch_ShouldReturnCountGreaterthanZero()
        {
            var moviesRepo = new MoviesRepository();
            String input = "Harry";
            var countOfMovies = moviesRepo.SearchMoviesBasedOnTitle(input);
            Assert.True(countOfMovies.Count > 0);
        }
        [Fact]
        public void SearchMoviesBasedOnTitle_InValidSearch_ShouldReturnCountGreaterthanZero()
        {
            var moviesRepo = new MoviesRepository();
            String input = "asdfdfdas";
            var countOfMovies = moviesRepo.SearchMoviesBasedOnTitle(input);
            Assert.True(countOfMovies.Count == 0);
        }
        [Fact]
        public void SearchMoviesBasedOnImdbID_InValidSearch_ShouldReturnTitleNull()
        {
            var moviesRepo = new MoviesRepository();
            String input = null;
            var movie = moviesRepo.GetMovieBasedOnImdbID(input);
            Assert.Null(movie.Title);
        }
        [Fact]
        public void SearchMoviesBasedOnImdbID_ValidSearch_ShouldReturnTitle()
        {
            var moviesRepo = new MoviesRepository();
            String input = "tt0373889";
            var movie = moviesRepo.GetMovieBasedOnImdbID(input);
            Assert.NotNull(movie.Title);
        }
    }
}
