using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlbumNS;

namespace AlbumTest
{
    [TestClass]
    public class AlbumTests
    {
        [TestMethod]
        public void Constructor_Duration_Test() // должен быть void и без параметров
        {
            Album album = new Album("Pink Floyd", "Wish You Were Here");

            double expected = 0;
            double actual = album.Duration;
            Assert.AreEqual(expected, actual, 0.001, "Duration is not correct");
        }

        [TestMethod]
        public void RemoveTrack_WithValidAmount_UpdatesDuration() // должен быть void и без параметров
        {

            Album album = new Album("Pink Floyd", "Wish You Were Here");

            album.m_tracks.Add(("A", 12.1));
            album.m_tracks.Add(("B", 14.5));
            album.Duration = 12.1 + 14.5;


            double expected = 14.5;
            album.RemoveTrack("A", 12.1);

            double actual = album.Duration;
            Assert.AreEqual(expected, actual, 0.001, "Duration is not correct");
        }

        [TestMethod]
        public void AddTrack_WithValidAmount_UpdatesDuration() // должен быть void и без параметров
        {

            
            Album album = new Album("Pink Floyd", "Wish You Were Here");

            album.AddTrack("A", 12.1);
            album.AddTrack("B", 14.5);

            double expected = 12.1 + 14.5;
            double actual = album.Duration;
            Assert.AreEqual(expected, actual, 0.001, "Duration is not correct");
        }
    }
}
