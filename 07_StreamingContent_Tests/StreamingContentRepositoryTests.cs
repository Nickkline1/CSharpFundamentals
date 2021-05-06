﻿using _07_StreamingContent_Repository;
using _07_StreamingContent_Repository.Content;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _07_StreamingContent_Tests
{
    [TestClass]
    public class StreamingContentRepositoryTests
    {
        [TestMethod]
        public void AddToDirectory_ShouldGetCorrectBoolean()
        {
            //AAA
            //Arrange
            StreamingContent content = new StreamingContent();
            StreamingContentRepository repository = new StreamingContentRepository();

            //Act
            bool addResult = repository.AddContentToDirectory(content);

            //Assert
            Assert.IsTrue(addResult);
        }

        [TestMethod]
        public void GetDirectory_ShouldReturnCorrectCollection()
        {
            //Arrange
            StreamingContent content = new StreamingContent();
            StreamingContentRepository repository = new StreamingContentRepository();
            repository.AddContentToDirectory(content);

            //Act
            List<StreamingContent> directory = repository.GetContents();

            //Assert
            bool directoryHasContent = directory.Contains(content);
            Assert.IsTrue(directoryHasContent);
        }

        private StreamingContent _content;
        private StreamingContentRepository _repo;

        [TestInitialize]
        public void Arrange()
        {
            _repo = new StreamingContentRepository();
            _content = new StreamingContent("Back to the Future", "A high school student named Marty gets accidentally sent back in time 30 years.", 4.4, GenreType.SciFi, MaturityRating.PG);
            _repo.AddContentToDirectory(_content);
        }

        [TestMethod]
        public void CheckMovieRunTime()
        {
            //creating a movie type, using full sontructo and inderited base
            Movie joe = new Movie("Joe Dirt", "The story about a mullet and his meteor", 3.2, GenreType.Bromance, MaturityRating.PG_13, 112);
            //creating a list to replicate our repo
            List<StreamingContent> miniRepo = new List<StreamingContent>();
            miniRepo.Add(joe);

            // filtering our repo by movies in our foreach
            foreach (Movie content in miniRepo)
            {
                Console.WriteLine(content.RunTime);
            }

            //searching for streamingcontent makes run time unavailable without casting
            foreach (StreamingContent content in miniRepo)
            {
                //finding movie types
                if (content is Movie)
                {
                    //setting content as movie to access movie exclusive properties
                Console.WriteLine((content as Movie).RunTime);
                }
            }
        }

        [TestMethod]
        public void GetByTitle_ShouldReturnCorrectContent()
        {
            //Arrange
            //done in Arrange() method

            //Act
            StreamingContent searchResult = _repo.GetContentByTitle("Back to the Future");

            //Assert
            Assert.AreEqual(_content, searchResult);
        }

        [TestMethod]
        public void UpdateExistingContent_ShouldReturnUpdatedValue()
        {
            //Arrange
            //already done in arrange() method

            //Act
            _repo.UpdateExistingContent("Back to the Future", new StreamingContent("Back to the Future 2", "Marty goes into the future 30 years", 4.0, GenreType.SciFi, MaturityRating.PG_13));

            //Assert
            Assert.AreEqual(_content.Title, "Back to the Future 2");
        }

        [TestMethod]
        public void DeleteExistingContent_ShouldReturnTrue()
        {
            bool wasDeleted  = _repo.DeleteExistingContent("back to the future");

            Assert.IsTrue(wasDeleted);
        }
    }
}
