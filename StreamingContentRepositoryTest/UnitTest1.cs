using Microsoft.VisualStudio.TestTools.UnitTesting;
using RepositoryPatterns;
using System;
using System.Collections.Generic;

namespace StreamingContentRepositoryTest
{
    [TestClass]
    public class UnitTest1
    {
        //test add method in repo
        [TestMethod]
        public void AddToDirectory_ShouldGetCorrectBooleen()
        {
            //AAA -> Arrange, Act Assert

            //Arrange - overall setup
            StreamingContent content = new StreamingContent();
            StreamingContentRepository repository = new StreamingContentRepository();

            //Act - Get/Run the code to test
            bool addResult = repository.AddContentToDirectory(content);

            //Assert - used to get the expected outcome of a test
            Assert.IsTrue(addResult);
        }
        //testing the read method
        [TestMethod]
        public void GetDirectory_ShouldReturnCorrectCollection()
        {
            //AAArules apply

            //Arrange -> initial setup
            //ceating contnet
            StreamingContent content = new StreamingContent();
            //creating the repo
            StreamingContentRepository repo = new StreamingContentRepository();
            //adding to the repo
            repo.AddContentToDirectory(content);

            //Act
            //store the list of streaming content within a variable
            List<StreamingContent> ListOfMovies = repo.GetContent();

            bool directoryHasContent = ListOfMovies.Contains(content);

            //Assert
            Assert.IsTrue(directoryHasContent);

        }

        //we will start with private fields
        private StreamingContentRepository _repo;
        private StreamingContent _content;

        [TestInitialize]
        public void Arrange()
        {

            //Make the repo
            _repo = new StreamingContentRepository();
            _content = new StreamingContent("Rubber", "A car tire comes to life with the power to make people explode",
                                            MaturityRating.R, 5.8d, GenreType.Drama);
            
            //now the movie is in our database / list
            _repo.AddContentToDirectory(_content);

        }

        //retrieve content by title
        [TestMethod]
        public void GetByTitle_ShouldReturnCorrectContent()
        {
            //Arrange...Already done above.

            //Act
            StreamingContent searchResult = _repo.GetContentByTitle("Rubber");

            //Assert - 
            Assert.AreEqual(_content, searchResult);
            
        }

        //Test the update Method
        [TestMethod]
        public void UpdateExistingContent_ShouldReturnTrue()
        {
            //Arrange -> Updated version of our movie
            StreamingContent newContent = new StreamingContent("Rubber part 2", "A car tire comes to life with the power to make people explode",
                                            MaturityRating.R, 9.8d, GenreType.Drama);
            //Act
            bool updateResult = _repo.UpdateExistingContnet("Rubber", newContent);

            //Assert
            Assert.IsTrue(updateResult);

        }

        //Test Delete Method

        [TestMethod]
        public void DeleteExistingContent_ShouldReturnTrue()
        {
            //Arrange -> get content by title
            StreamingContent content = _repo.GetContentByTitle("Rubber");

            //Act -> removing the movie
            bool removeResult = _repo.DeleteExistingContent(content);

            //Assert -> confirms the movie has been deleted
            Assert.IsTrue(removeResult);


        }

    }

}
