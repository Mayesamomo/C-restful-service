using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheMovieDB
{
    class TheMovieDB
    {
    }
    //genre class
    public class Genre
    {
        public int id { get; set; }
        public string name { get; set; }

    }
    
    public class GenreObject
    {
        public List<Genre> Genres { get; set; }
    }

    public class TrendingMovies
    {
        public double popularity { get; set; }
        public int vote_count { get; set; }
        public bool video { get; set; }
        public string poster_path { get; set; }
        public int id { get; set; }
        public bool adult { get; set; }
        public string backdrop_path { get; set; }
        public string original_language { get; set; }
        public string original_title { get; set; }
        public List<int> genre_ids { get; set; }
        public string title { get; set; }
        public double vote_average { get; set; }
        public string overview { get; set; }
        public string release_date { get; set; }
        }

        public class TrendingMoviesObject
    {
        public int page { get; set; }
        public int total_results { get; set; }
        public int total_pages { get; set; }
        public List<TrendingMovies> results { get; set; }
    }

    //discover movies 

    public class Search
    {
        public string Source { get; set; }
        public string Value { get; set; }
    }

    public class SearchObject
    {
        public string Title { get; set; }
        public string Year { get; set; }
        public string Rated { get; set; }
        public string Released { get; set; }
        public string Runtime { get; set; }
        public string Genre { get; set; }
        public string Director { get; set; }
        public string Writer { get; set; }
        public string Actors { get; set; }
        public string Plot { get; set; }
        public string Language { get; set; }
        public string Country { get; set; }
        public string Awards { get; set; }
        public string Poster { get; set; }
        public List<Search> Ratings { get; set; }
        public string Metascore { get; set; }
        public string imdbRating { get; set; }
        public string imdbVotes { get; set; }
        public string imdbID { get; set; }
        public string Type { get; set; }
        public string DVD { get; set; }
        public string BoxOffice { get; set; }
        public string Production { get; set; }
        public string Website { get; set; }
        public string Response { get; set; }
    }
   
}
