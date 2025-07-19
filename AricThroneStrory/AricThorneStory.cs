using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace WarHammer.AricThroneStrory
{
    class AricThorneStory
    {
        public void Display() {

            Chapter1 chapter1 = new Chapter1();
            chapter1.TheRock();
            ReadKey(true);
            Loadingstage();
            



            /* Chapter2 chapter2 = new Chapter2();
             chapter2.WhisperingWood();
             */
        }

        private void Loadingstage()
        {

            for (int i = 1; i <= 10; i++)
            {
                WriteLine($" loading.. {i}%");
            }
           
        }
        
        
}
}
