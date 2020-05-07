using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlockbusterLab
{
    abstract class Movie
    {
        public string Title { get; protected set; }
        public Genre Category { get; protected set; }
        public int RunTime { get; protected set; }
        public List<string> Scenes;
        
        public Movie(string title, Genre genre, int runTime, params string[] scenes)
        {
            Title = title;
            Category = genre;
            RunTime = runTime;
            Scenes = scenes.ToList();
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine($"Title: {Title}\n" +
                $"Genre: {Category}\n" +
                $"Run time: {RunTime} mins.");
        }
        public virtual void PrintScenes()
        {
            int i = 0;
            Scenes.ForEach(x => Console.WriteLine($"{++i}. {x}"));
        }
        public abstract void Play();
    }
    public enum Genre
    {
        Drama,
        Comedy,
        Horror,
        Romance,
        Action
    }
}
