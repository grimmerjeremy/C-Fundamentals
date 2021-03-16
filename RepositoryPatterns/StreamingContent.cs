using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPatterns
{
    //This enum creates a new type to be set by the user below.
    public enum MaturityRating { G, PG, TV_Y, TV_G, TV_PG, TV_14, TV_MA, PG_13, R, NC_17, }
    public enum GenreType { Horror = 1, RomCom, SciFi, Documentary, Bromance, Drama, Action}
    public class StreamingContent
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public double StarRating { get; set; }
        public MaturityRating MaturityRating { get; set; }
        public GenreType GenreType { get; set; }
        public bool IsFamilyFriendly 
        { 
            get
            {
                switch (MaturityRating)
                {
                    case MaturityRating.G:
                    case MaturityRating.PG:
                    case MaturityRating.TV_Y:
                    case MaturityRating.TV_G:
                    case MaturityRating.TV_PG:
                        return true;
                    case MaturityRating.PG_13:
                    case MaturityRating.R:
                    case MaturityRating.NC_17:
                    case MaturityRating.TV_14:
                    case MaturityRating.TV_MA:
                    default:
                        return false;
                        

                }
                /* Turning the bool above into an if / if else statement.
                 * Turns the information in the enum into an int.
                if ((int) MaturityRating > 4)
                {
                    return false;
                }
                else
                {
                    return true;
                }
                */
            }
        }

        //Creating an empty constructor to allow people to fill in the property value.
        //Also it is required!!
        public StreamingContent(string v, string v1) {}

        //Order in this class parenthesis must reflect in the same order as the title defined below.
        public StreamingContent(string title, string description, MaturityRating maturityRating, double starRating, GenreType genreType)
        {
            Title = title;
            Description = description;
            MaturityRating = maturityRating;
            StarRating = starRating;
            GenreType = genreType;

        }
        public StreamingContent()
        {

        }
    }
}
