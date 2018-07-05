using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            int countdown = 2000;
            Timer timer = new Timer();
            timer.Interval = 1;
            timer.Elapsed += Timer_Elapsed;

            Console.WriteLine(countdown);
            timer.Start();

            Console.ReadKey();

            void Timer_Elapsed(object sender, ElapsedEventArgs e)
            {
                countdown--;
                Console.WriteLine(countdown);

                if (countdown <= 0)
                    timer.Stop();
            }
        }

    }
}
