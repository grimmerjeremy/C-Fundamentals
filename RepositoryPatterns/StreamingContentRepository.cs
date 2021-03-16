using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPatterns
{
    public class StreamingContentRepository
    {
        protected readonly List<StreamingContent> _contentDirectory = new List<StreamingContent>();

        //Create
        public bool AddContentToDirectory(StreamingContent content)
        {
            int startingCount = _contentDirectory.Count;

            _contentDirectory.Add(content);

            bool wasAdded = (_contentDirectory.Count > startingCount) ? true : false;
            return wasAdded;
        }

        public List<StreamingContent> GetContent()
        {
            return _contentDirectory;
        }

        //Read
        public StreamingContent GetContentByTitle(string Title)
        {
            foreach(StreamingContent content in _contentDirectory)
            {
                if(content.Title.ToLower() == Title.ToLower())
                {
                    return content;
                }
            }
            return null;
        }

        public StreamingContent GetContentByGenre(GenreType GenreType)
        {
            foreach (StreamingContent content in _contentDirectory)
            {
                if (content.GenreType == GenreType)
                {
                    return content;
                }
            }
            return null;
        }

        //return a list rather than a single title
        public StreamingContent GetContentByMaturityRating(MaturityRating MaturityRating)
        {
            List<StreamingContent> listOfContent = new List<StreamingContent>();
            foreach (StreamingContent content in _contentDirectory)
            {
                if (content.MaturityRating == MaturityRating)
                {
                    listOfContent.Add(content);
                    return content;
                }
            }
            return null;
        }

        public StreamingContent GetContentByStarRating(double StarRating)
        {
            foreach (StreamingContent content in _contentDirectory)
            {
                if (content.StarRating == StarRating)
                {
                    return content;
                }
            }
            return null;
        }

        //Update
        public bool UpdateExistingContnet(string originalTitle, StreamingContent newContent)
        {
            StreamingContent oldContent = GetContentByTitle(originalTitle);

            if(oldContent != null)
            {
                oldContent.Title = newContent.Title;
                oldContent.Description = newContent.Description;
                oldContent.MaturityRating = newContent.MaturityRating;
                oldContent.GenreType = newContent.GenreType;
                oldContent.StarRating = newContent.StarRating;

                return true;
            }
            else
            {
                return false;
            }
        }

        //Delete
        public bool DeleteExistingContent(StreamingContent existingContent)
        {
            bool deleteResult = _contentDirectory.Remove(existingContent);
            return deleteResult;
        }

        //Get by other parameters
        //Get by Star Rating
        //Get by Family Friendly
        //Get by Genre
    }
}
