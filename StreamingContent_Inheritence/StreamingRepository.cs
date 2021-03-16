using RepositoryPatterns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamingContent_Inheritence
{
    public class StreamingRepository : StreamingContentRepository
    {
        //we will use the same _contentDirectory from StreamingContnetRepository.cs

        //Read -> Show
        
        public Show GetShowByTitle(string title)
        {
            //to find a specific show
            foreach (StreamingContent content in _contentDirectory)
            {
                if (content.Title.ToLower()==title.ToLower() && content.GetType() == typeof(Show))
                {
                    return (Show)content;
                }

            }
            return null;
        }

        //Read -> Movie

        public Movie GetMovieByTitle(string title)
        {
            foreach (StreamingContent content in _contentDirectory)
            {
                if (content.Title.ToLower()==title.ToLower() && content.GetType() == typeof(Movie))
                {
                    return (Movie)content;
                }
            }
            return null;
        }
        public List<Show> GetAllShows()
        {
            //use this toadd our shows -> this is a "newed-up" version of the list (we will return this list)
            List<Show> allShows = new List<Show>();

            foreach (StreamingContent content in _contentDirectory)
            {
                //if the content we find is of type show...
                if (content is Show)
                {
                    //add the show to the allshows list
                    allShows.Add((Show)content);
                }
            }
            return allShows;
        }

        //Read
        //get all the movies
        public List<Movie> GetAllMovies()
        {
            List<Movie> allMovies = new List<Movie>();
            {
                foreach (StreamingContent content in _contentDirectory)
                {
                    if (content is Movie)
                    {
                        allMovies.Add(content as Movie);
                    }
                }
                return allMovies;
            }
        }

        //Challenges

        //Get by Run Time/ Average Run Time
        //Get by Shows with over x episodes
        //Get by Show/Movie by Rating

    }
}
