using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terrorforming;

class Program
{
    //public int gameWin; 
    static void Main(string[] args)
    {

        //Introduction 
        Actions menu = new Actions();
        
        Console.WriteLine("Can you terraform the planet in time?");
        //var answer = 3;

        menu.actionChoice();


        /*while (true)
        {
            var guess = Convert.ToInt32(Console.ReadLine());
            if (Convert.ToInt32(guess) < answer)
            {
                Console.WriteLine("Guess higher.");
            }
            else if (Convert.ToInt32(guess) > answer)
            {
                Console.WriteLine("Guess lower.");
            }
            else
            {
                Console.WriteLine("Mindreader!");
                break;
            }
        }*/
    }
}
