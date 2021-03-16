using RepositoryPatterns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamingContent_Inheritence
{
    //Movie ":" means that it is "inheriting" everything from - StreamingContent
    public class Movie : StreamingContent

    {
        //we get all of our properties from a streaming content b/c a movie "is a"streaming content.
        public double RunTime { get; set; }

        public Movie()
        {

        }

        public Movie(string title, string description, MaturityRating maturityRating,double starRating, GenreType genreType)
                    : base(title, description, maturityRating, starRating, genreType)
        {
            
        }

    }
}
