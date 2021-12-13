using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQExercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> videoGames = new List<string>
            {"Dota", "Forza", "Assassin's Creed", "Mirror's Edge" };
        
            videoGames.Sort((a,b) => (a.Length.CompareTo(b.Length)));

            foreach(var game in videoGames)
            {
                Console.WriteLine(game);
            }

        }
    }
}
