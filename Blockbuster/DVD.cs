using System;
using System.Collections.Generic;
using System.Text;

namespace Blockbuster
{
    public class DVD : Movie
    {
        public DVD(string Title, Genre Category, int Runtime, List<string> Scenes) 
            : base(Title, Category, Runtime, Scenes)
        {

        }

        public override void Play()
        {
            Console.WriteLine($"Select what scene you'd like to watch: 0 to {Scenes.Count-1}");
            string input = Console.ReadLine();
            int index = int.Parse(input);

            string scene = Scenes[index];
            Console.WriteLine(scene);

        }
    }
}
