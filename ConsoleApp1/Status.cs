using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terrorforming
{
    class Status
    {
        Actions winStat = new Actions();

        public void statusCheck()
        {
            Console.WriteLine(winStat.GameWin);
        }
    }
}
