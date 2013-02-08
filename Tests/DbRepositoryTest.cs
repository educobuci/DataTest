using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using MibDatalayer;
using SampleDatalayer;
using SampleModel;
using System.Data.SqlClient;
namespace Tests
{
    [TestFixture]
    public class DbRepositoryTest
    {
        Dictionary<string, dynamic> Fixtures;

        [TestFixtureSetUp]
        public void Setup()
        {
            var blog = new Blog()
            {
                Title = "My Blog"
            };
            BlogRepository repo = new BlogRepository();
            repo.Save(blog);
        }

        [TestFixtureTearDown]
        public void TearDown()
        {
            
        }

        [Test]
        public void FindByIdTest()
        {


            BlogRepository repo = new BlogRepository();
            Blog blog = repo.FindById(1);
            Assert.AreEqual(blog.Title, "My Blog");
        }
    }
}