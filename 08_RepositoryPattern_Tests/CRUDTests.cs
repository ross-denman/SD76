using _07_RepositoryPattern_Repo;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _08_RepositoryPattern_Tests
{
    [TestClass]
    public class CRUDTests
    {
        /// AAA Testing Pattern
        ///  
        /// </summary>
        StreamingContent_Repo _repo = new StreamingContent_Repo();

        [TestMethod]
        public void AddTest()
        {
            StreamingContent content = new StreamingContent(
                "Galaxy Quest",
                "Sci Fi actors inadvertantly go on a real Sci Fi adventure",
                Maturity.PG13,
                5,
                GenreType.Comedy
                );

            //Act
            bool wasAdded =_repo.AddContentToDirectory(content);

            Console.WriteLine(wasAdded);
            Console.WriteLine(content.Title);

            //Assert
            Assert.IsTrue(wasAdded);
        }

    }
}
