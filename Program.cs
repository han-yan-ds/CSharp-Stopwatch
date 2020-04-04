using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Stopwatch

{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch myStopwatch = new Stopwatch();
            TimeSpan mySpan;

            for (int i = 0; i < 10; i++)
            {
                myStopwatch.Start();
                System.Threading.Thread.Sleep(1000);
                mySpan = myStopwatch.Stop();
                Console.WriteLine(mySpan);
            }

            Console.Write("Finished! Press ENTER to exit... ");
            Console.Read();
        }
    }
}
