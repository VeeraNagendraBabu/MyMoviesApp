using MyMoviesApp.API.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MyMoviesApp.API.Repository
{
    public class MoviesRepository : IMoviesRepository
    {
        private List<Movie> LoadMoviesFromJson()
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            string dataPath = System.IO.Path.Combine(currentDirectory, "Data", "movies.json");
            var json = File.ReadAllText(dataPath);
            var d = JsonConvert.DeserializeObject<Rootobject>(json);
            return d.movies.ToList();
        }
        public List<Movie> GetMovies()
        {
            var data = LoadMoviesFromJson();
            return data;
        }
        public List<Movie> SearchMoviesBasedOnTitle(String Title)
        {
            List<Movie> result = new List<Movie>();
            if (Title != null)
            {
                var data = LoadMoviesFromJson();
                result = data.Where(o => o.Title.Contains(Title)).ToList();
            }
            return result;

        }
        public Movie GetMovieBasedOnImdbID(String ImdbID)
        {
            Movie result = new Movie();
            if (ImdbID != null)
            {
                var data = LoadMoviesFromJson();
                result = data.FirstOrDefault(o => o.imdbID == ImdbID);
            }
            return result;

        }
    }
}
