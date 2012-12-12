using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using MibDatalayer;

namespace Tests
{
    [TestFixture]
    public class DbRepositoryTest
    {
        Dictionary<string, dynamic> Fixtures;

        [TestFixtureSetUp]
        public void Setup()
        {
            this.Fixtures = new Dictionary<string, dynamic>();
            //this.Fixtures.Add("song", new Song() { Title = "Violet Hills" });

            using (var context = new DataBase.TestDbContext())
            {
                context.Database.CreateIfNotExists();
                context.Songs.Add(new Song() { Id = 1, Title = "Violet Hills" });
                context.SaveChanges();
            }
        }

        [TestFixtureTearDown]
        public void TearDown()
        {
            using (var context = new DataBase.TestDbContext())
            {
                //context.Songs.Remove(context.Songs.Find());
                context.Database.Delete();
            }
        }

        [Test]
        public void FindByIdTest()
        {
            DbRepository<Song> repo = new DbRepository<Song>();
            Song song = repo.FindById(1);
            Assert.AreEqual(song.Title, Fixtures["Song"].Title);
        }
    }
}