using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terrorforming
{
    class Actions
    {
        string order = "(1) Order Materials\n";
        string plant = "(2) Plant Seeds\n";
        string explore = "(3) Explore\n";
        string radio = "(4) Radio HQ\n";
        string nap = "(5) Take Nap\n";
        string status = "(6) Status\n";
        string exit = "(7) Exit\n";

        public int GameWin { get; set; }

        public void actionChoice()
        {
            while (true)
            {
                Console.WriteLine("\nChoose Action: ");
                Console.WriteLine(order+plant+explore+radio+nap+status+exit);
                var playerChoice = Convert.ToInt32(Console.ReadLine());
                
                Console.WriteLine();
                if (playerChoice == 1)
                {
                    Console.WriteLine("order");
                }
                else if (playerChoice == 2)
                {
                    Console.WriteLine("plant");
                }
                else if (playerChoice == 3)
                {
                    Console.WriteLine("explore");
                }

                else if (playerChoice == 4)
                {
                    Console.WriteLine("radio");
                }
                else if (playerChoice == 5)
                {
                    Nap sleep = new Nap();
                    sleep.takeNap();
                }
                else if (playerChoice == 6)
                {
                    Console.WriteLine("status");
                    Status statCheck = new Status();
                    statCheck.statusCheck();
                }
                else if (playerChoice == 7)
                {
                    break;
                }
            }
        }
    }
}