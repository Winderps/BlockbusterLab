using System;
using System.Collections.Generic;
using System.Text;

namespace BlockbusterLab
{
    class VHS : Movie
    {
        public int CurrentTime { get; private set; }

        public VHS(string name, Genre genre, int runTime, params string[] scenes) : base(name, genre, runTime, scenes)
        {
            CurrentTime = 0;
        }
        public override void Play()
        {
            try
            {
                Console.WriteLine(Scenes[CurrentTime]);
                CurrentTime++;
            }
            catch
            {
                Console.WriteLine("You reached the end of this tape already. Please rewind to watch it again.");
            }
        }
        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine("Type: VHS");
        }
        public void Rewind()
        {
            CurrentTime = 0;
        }
    }
}
