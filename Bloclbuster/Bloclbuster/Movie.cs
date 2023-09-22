using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bloclbuster
{
    public enum Genre
    {
        Action,
        Drama,
        Suspense
    }
    internal class Movie
    {
        string title;
        Genre genre;
        int duration;

        public string Title { get { return title; } }
        public Genre Genre { get { return genre; } }
        public int Duration { get { return duration; } }

        public Movie(string title, Genre genre, int duration)
        {
            this.title = title;
            this.genre = genre;
            this.duration = duration;
        }
    }
}
