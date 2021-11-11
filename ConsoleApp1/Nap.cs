using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terrorforming
{
    class Nap
    {
        string napPrompt = "Unanimous board decision was for you to take a nap.";
        string failPrompt = "You couldn't fall asleep";
        int goodRoll = 4; //number to beat in takeNap()
        Random rnd = new Random();
        Actions napCond = new Actions();
        
        public void takeNap()
        {
            int num = rnd.Next(6);
            
            if (num >= goodRoll)
            {
                Console.WriteLine(napPrompt);
                napCond.GameWin += 2; 
            }
            else if (napCond.GameWin !=0 && num < goodRoll)
            {
                Console.WriteLine(failPrompt);
                napCond.GameWin -= 1;
            }
            else
            {
                Console.WriteLine(failPrompt);
            }
        }
    }
}
