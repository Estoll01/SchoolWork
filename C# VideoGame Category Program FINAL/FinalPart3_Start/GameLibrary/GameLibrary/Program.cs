/*
 * Author:Ethan Tolliver
 * Final Part 3 Fall 2025
 * CIS-199-50-4258
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 1. Create 5 VideoGame Objects */
            VideoGame game1 = new VideoGame(1234, "Fallout 3", "Bethesda", "RPG", 134);
            VideoGame game2 = new VideoGame(1526, "Silent Hill 2", "Konami", "Horror", 40);
            VideoGame game3 = new VideoGame(1876, "Final Fantasy 7", "Square", "JRPG", 100);
            VideoGame game4 = new VideoGame(1002, "Super Metroid", "Nintendo", "Metroidvania", 15);
            VideoGame game5 = new VideoGame(2006, "Tekken 3", "Namco", "Fighting Game", 60);

            /* 2. Create VideoGame array */
            VideoGame[] games = { game1, game2, game3, game4, game5 };

            /* 3. Display initial list of games */
            Console.WriteLine("Initial Games:");
            DisplayGames(games);

            /* 4. Modify game properties (Update completion status of two games) */
            game1.MarkCompleted();
            game2.MarkNotCompleted();
            game3.GameID = 4321;
            game4.Genre = "Action-Adventure";
            game5.Title = "Street Fighter III";


            /* 5. Display updated list of games */
            Console.WriteLine("\nUpdated Games:");
            DisplayGames(games);

            Console.ReadLine();

        }

        /* 3. Create DisplayGames method */
        static void DisplayGames(VideoGame[] games)
        {
            foreach (var game in games)
                Console.WriteLine(game.ToString());
        }
    }
}
