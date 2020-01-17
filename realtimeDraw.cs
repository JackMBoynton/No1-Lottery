using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace LotteryApplication
{
    class realtimeDraw
    {

        private static Random _rnd = new Random();

        public static String drawNumbers(int numLimit, int numAmount)
        {
            return String.Join(",",
                Enumerable
                    .Range(1, numLimit)
                    .OrderBy(x => _rnd.Next())
                    .Take(numAmount));
        }


    }
}
