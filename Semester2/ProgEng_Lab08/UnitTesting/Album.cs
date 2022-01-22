using System;
using System.Collections.Generic;

namespace AlbumNS
{

    public class Album
    {
        private readonly string m_artist;
        private readonly string m_albName;
        private double m_duration;
        public List<(string, double)> m_tracks;


        public Album(string artist, string albNmae)
        {
            m_artist = artist;
            m_duration = 0;
            m_albName = albNmae;
            m_tracks = new List<(string, double)> { };
        }

        public string ArtistName
        {
            get { return m_artist; }
        }

        public string AlbumName
        {
            get { return m_albName; }
            
        }

        public double Duration
        {
            get { return m_duration; }
            set { m_duration = value; }
        }

        public void RemoveTrack(string name, double track_duration)
        {
            
            if (m_tracks.Contains((name, track_duration)))
            {
                m_duration -= track_duration; // по идее нужно уменьшать продолжительность альбома, если убираем трек
                m_tracks.Remove((name, track_duration));
            }
        }

        public void AddTrack(string name, double track_duration)
        {
            if (!m_tracks.Contains((name, track_duration)))
            {
                m_duration += track_duration; // по идее нужно увеличивать продолжительность альбома, если добавляем трек
                m_tracks.Add((name, track_duration));
            }
        }

        public static void Main()
        {
            Album album = new Album("Pink Floyd", "Wish You Were Here");

            album.AddTrack("A", 10.12);
            album.RemoveTrack("A", 10.12);
            Console.WriteLine("Current duration is {0:0.00}", album.Duration);
        }
    }
}