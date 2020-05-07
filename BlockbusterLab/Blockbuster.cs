using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlockbusterLab
{
    class Blockbuster
    {
        public List<Movie> Movies;
        
        public Blockbuster() // You never said the movies had to be real so I made my code create movies for me
        {
            Movies = new List<Movie>();
            Random r = new Random();
            for(int i = 1; i <= 6; i++)
            {
                byte[] titleBuffer = new byte[25];
                r.NextBytes(titleBuffer);
                Genre genre = (Genre)r.Next(0, Enum.GetValues(typeof(Genre)).Length);
                int sceneCount = r.Next(1, 21);
                int runTime = r.Next(90, 200);
                List<string> scenes = new List<string>();
                for (int k = 0; k < sceneCount; k++)
                {
                    byte[] sceneBuffer = new byte[50];
                    r.NextBytes(sceneBuffer);
                    string scene = Utilities.ByteArrayToString(sceneBuffer);
                    scenes.Add(scene);
                }
                string title = Utilities.ByteArrayToString(titleBuffer);
                if (i < 4)
                {
                    Movies.Add(new DVD(title, genre, runTime, scenes.ToArray()));
                }
                else
                {
                    Movies.Add(new VHS(title, genre, runTime, scenes.ToArray()));
                }
            }
        }

        public Blockbuster(params Movie[] movies)
        {
            Movies = movies.ToList();
        }

        public void PrintMovies()
        {
            int i = 0;
            Movies.ForEach(x => Console.WriteLine($"{++i}. {x.Title}"));
        }
        public void CheckOut()
        {
            PrintMovies();
            int selection = Utilities.GetIntInputAdjusted($"Please enter the number of the movie you would like", Movies.Count);
            Console.WriteLine();
            Movies[selection].PrintInfo();
            Console.WriteLine();
            Console.Write("Enter y if you would like to watch the movie: ");
            if (Console.ReadLine().ToLower().StartsWith('y'))
            {
                while(true)
                {
                    Movies[selection].Play();
                    Console.Write("Enter y to watch another scene: ");
                    if(!Console.ReadLine().ToLower().StartsWith('y'))
                    {
                        break;
                    }
                }
            }
        }
    }
}
