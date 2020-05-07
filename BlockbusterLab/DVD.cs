using System;
using System.Collections.Generic;
using System.Text;

namespace BlockbusterLab
{
    class DVD : Movie
    {
        public DVD(string name, Genre genre, int runTime, params string[] scenes) : base(name, genre, runTime, scenes)
        {

        }
        public override void Play()
        {
            int numScene = Utilities.GetIntInputAdjusted($"Please enter the number of the scene you would like to view", Scenes.Count);
            Console.WriteLine(Scenes[numScene]);
        }
        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine("Type: DVD");
        }
    }
}
