using _07_StreamingContent_Repository.Content;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_StreamingContent_Repository
{
    public class StreamingContentRepository
    {
        private readonly List<StreamingContent> _contentDirectory = new List<StreamingContent>();

        //CRUD methods below Create, Read, Update, Delete
        //create
        //content
        public bool AddContentToDirectory(StreamingContent newContent)
        {
            int startingCount = _contentDirectory.Count;

            _contentDirectory.Add(newContent);

            bool wasAdded = (_contentDirectory.Count > startingCount) ? true : false;
            return wasAdded;
        }
        //movie
        public bool AddContentToDirectory(Movie newContent)
        {
            int startingCount = _contentDirectory.Count;

            _contentDirectory.Add(newContent);

            bool wasAdded = (_contentDirectory.Count > startingCount) ? true : false;
            return wasAdded;
        }
        //show

        //episode

        //read all 
        // Content Read all
        public List<StreamingContent> GetContents()
        {
            return _contentDirectory; 
        }

        //movie read all
        public List<Movie> GetMovies()
        {
            //initialize empty list
            List<Movie> allMovies = new List<Movie>();
            //look thru directory
            foreach(StreamingContent content in _contentDirectory)
            {
                //chck if object is a movie class
                if (content is Movie)
                {
                    //load into our list
                    allMovies.Add(content as Movie);
                }
            }
            //return our list
            return allMovies;
        }
        //show read all
        public List<Show> GetShows()
        {
            //Setup our list
            List<Show> allShows = new List<Show>();
            //find our shows
            foreach(StreamingContent content in _contentDirectory)
            {
                //check that it is a show
                if (content.GetType() == typeof(Show))
                {
                    //Yes? Add to the list
                    allShows.Add((Show)content);
                }
            }
            //Give shows back
            return allShows;
        }




        // episode read all

        //get by id
        //content
        public StreamingContent GetContentByTitle(string title)
        {
            foreach (StreamingContent content in _contentDirectory)
            {
                if (content.Title.ToLower() == title.ToLower())
                {
                    return content;
                }
            }
            return null;
        }
        //movie
        public Movie GetMovieByTitle(string title)
        {
            foreach(StreamingContent movie in _contentDirectory)
            {
                                               //using is to make sure movie "is" of class type movie  
                if (movie.Title.ToLower() == title.ToLower() && movie is Movie)
                {
                    //using "as" as a way to cast
                    return movie as Movie;
                }
            }

            return null;
        }
        //show
        //getshowbytitle
        //accessor // return type // name (parameters)
        public Show GetShowByTitle (string title)
        {
            foreach (StreamingContent show in _contentDirectory)
            {
                if (show.Title.ToLower() == title.ToLower() && show.GetType() == typeof(Show))
                {
                    return (Show)show;
                }
            }

            return null;
        }
        //episode
        public bool UpdateExistingContent(string originalTitle, StreamingContent newContentValues)
        {
            StreamingContent oldContent = GetContentByTitle(originalTitle);

            if(oldContent != null)
            {
                oldContent.Title = newContentValues.Title;
                oldContent.Description = newContentValues.Description;
                oldContent.StarRating = newContentValues.StarRating;
                oldContent.TypeOfGenre = newContentValues.TypeOfGenre;
                oldContent.MaturityRating = newContentValues.MaturityRating;


                return true;
            }
            else
            {
                return false;
            }
        }

        public bool DeleteExistingContent(string titleToDelete)
        {
            StreamingContent contentToDelete = GetContentByTitle(titleToDelete);
            if (contentToDelete == null)
            {
                return false;
            }
            else
            {
                _contentDirectory.Remove(contentToDelete);
                return true;
            }
        }
    }
}
