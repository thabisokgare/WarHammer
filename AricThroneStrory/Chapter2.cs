using System.Media;
using static System.Console;
using System.Runtime.Versioning;

namespace WarHammer.AricThroneStrory
{
    public class Chapter2
    {
        public void WhisperingWood()
        {
            Clear();
            WriteLine("Chapter II: The Whispering Wood");
            Thread.Sleep(2000);

            WriteLine("With the battle behind him, Aric ventures beyond the gates of Altdorf...");
            Thread.Sleep(1800);
            WriteLine("His destination: a forest whispered of in frightened taverns — said to echo with the voices of the dead.");
            Thread.Sleep(2000);

            WriteLine("\nAs he crosses the old bridge, the trees loom tall and crooked, cloaked in mist.");
            Thread.Sleep(2000);

            WriteLine("The wind howls, carrying with it a faint voice: \"...Aric... help me...\"");
            Thread.Sleep(1800);

            WriteLine("\nWhat does Aric do?");
            WriteLine("1. Follow the voice deeper into the forest.");
            WriteLine("2. Set up camp and wait for daylight.");
            WriteLine("3. Leave and return to Altdorf.");

            int choice = GetUserChoice(3);

            switch (choice)
            {
                case 1:
                    WriteLine("\nAric draws his blade and follows the voice into the whispering dark...");
                    Thread.Sleep(1800);
                    // next branch of the story
                    break;
                case 2:
                    WriteLine("\nAric sets up a small campfire, but sleep evades him as shadows dance around the flames.");
                    Thread.Sleep(1800);
                    break;
                case 3:
                    WriteLine("\nFear gripping his heart, Aric turns back — but the path he came from has vanished...");
                    Thread.Sleep(1800);
                    break;
            }

            ReadKey(true);
        }

        private int GetUserChoice(int maxOption)
        {
            while (true)
            {
                Write("\nYour choice: ");
                var input = ReadLine();
                if (int.TryParse(input, out int result) && result >= 1 && result <= maxOption)
                {
                    return result;
                }
                WriteLine("Please enter a valid option (1 to " + maxOption + ").");
            }
        }
    }
}
