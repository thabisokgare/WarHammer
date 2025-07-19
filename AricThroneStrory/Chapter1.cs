using System.Media;
using System.Runtime.Versioning;
using static System.Console;

namespace WarHammer.AricThroneStrory
{
    public class Chapter1
    {
      
       

        public void TheRock()
        {
            DisplayBattleArt();
            
        }
        private static void Battle()
        {
            
            string battleArt = @"
  ______   ____  _    _   _   _   _____      _____   ____   _  __  _   _   _   _ 
 |  _ \ \ / /  || |  | | | \ | | |  __ \    |  __ \ / __ \ | |/ / | \ | | | | | |
 | | | \ V /| || |  | | |  \| | | |  | |   | |  | | |  | || ' /  |  \| | | |_| |
 | |_| || | | || |__| | | |\  | | |__| |   | |__| | |__| || . \  | |\  | |  _  |
 |____/ |_| |_(_)____/  |_| \_| |_____/    |_____/ \____/ |_|\_\ |_| \_| |_| |_|

      ~ Where Legends Are Forged in Shadow and Fire ~
";
           
            Clear();

            
            WriteLine(battleArt);
           

            WriteLine("The shadowy figure draws closer, revealing a hooded warrior with a scarred face and a menacing grin.");
            Thread.Sleep(1200);

            WriteLine("Aric grips his sword tightly, ready for a confrontation.");
            Thread.Sleep(1200);

            WriteLine("\nThe warrior speaks, his voice dripping with malice:");
            Thread.Sleep(1000);
            WriteLine("\"You shouldn't have come here, Thorne. The old gods have already judged your bloodline...\"");
            Thread.Sleep(1000);
            WriteLine("Aric steadies his breath, his knuckles whitening around the sword hilt.");
            Thread.Sleep(1000);

            WriteLine("The air crackles with an eerie energy, as though the old gods themselves are watching.");
            Thread.Sleep(1200);

            WriteLine("Aric narrows his eyes. \"Then let them watch as I carve my own fate.\"");
            Thread.Sleep(1000);

            WriteLine("\nThe hooded warrior chuckles, stepping forward, unsheathing a curved dagger.");
            Thread.Sleep(1200);

            WriteLine("\"Bold words, boy. But the gods do not favor the defiant.\"");
            Thread.Sleep(1000);

            WriteLine("Without warning, the warrior lunges—blades clashing in a fierce spark of steel.");
            Thread.Sleep(1200);

            WriteLine("Aric sidesteps, barely dodging the lethal strike. The battle has begun.");
            Thread.Sleep(1000);

            ReadKey(true);
        }


        // Annotate the method to specify platform support
        private static void PlayBattleTheme()
        {
            SoundPlayer chapter1 = new SoundPlayer("The Other Side of The Sea (Anime Version) (Guitar and Piano Solo Part).wav");
            ConsoleKey keyPressed;
            ConsoleKeyInfo KeyInfo = ReadKey(true);
                        
                        keyPressed = KeyInfo.Key;

                        do
                        {
                            
                           if (keyPressed == ConsoleKey.Enter)
                            {
                                chapter1.PlaySync();
                                Battle();
                            }
                            
                        } while(keyPressed != ConsoleKey.Enter);

                         Battle();
            

        }


        private static void DisplayBattleArt()
        {
            string battleArt = @" 

 ________  ___  ___  ________  ________  _________  _______   ________           _____     
|\   ____\|\  \|\  \|\   __  \|\   __  \|\___   ___\\  ___ \ |\   __  \         / __  \    
\ \  \___|\ \  \\\  \ \  \|\  \ \  \|\  \|___ \  \_\ \   __/|\ \  \|\  \       |\/_|\  \   
 \ \  \    \ \   __  \ \   __  \ \   ____\   \ \  \ \ \  \_|/_\ \   _  _\      \|/ \ \  \  
  \ \  \____\ \  \ \  \ \  \ \  \ \  \___|    \ \  \ \ \  \_|\ \ \  \\  \|          \ \  \ 
   \ \_______\ \__\ \__\ \__\ \__\ \__\        \ \__\ \ \_______\ \__\\ _\           \ \__\
    \|_______|\|__|\|__|\|__|\|__|\|__|         \|__|  \|_______|\|__|\|__|           \|__|
                                                                                           
                                                                                           
                                                                                           

";
            
            WriteLine(battleArt);
           
            

        }
    }
}
 