using System.Reflection.Emit;
using System.Linq;
using System.Collections.Generic;

namespace LINQ
{
    public class Program
    {

        /* INSTRUCTIONS - Create a list of type string.
Populate the list with video game names.
Alternatively, you can choose a different category of items if you prefer. ex. list of baseball teams, list of movie titles, etc.
Order the list of games by the length of the game name.
Remember to use LINQ which involves using a lambda expression.
Use the list of common LINQ methods on the lecture page for help on deciding which method(s) to use:
Linq Methods
Use Method Syntax for this exercise.
Stage, Commit, and Push your work to Github.
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Game Names by Descending Word Length:");
            Console.WriteLine("");

            List<string> gameNames = new List<string> { "Mario Brothers", "Madden 2024", "Pac-Man" };

            IEnumerable<string> orderedGames = from game in gameNames orderby game descending select game;

            foreach (var game in gameNames)
                Console.WriteLine(game);


        }
    }
}
