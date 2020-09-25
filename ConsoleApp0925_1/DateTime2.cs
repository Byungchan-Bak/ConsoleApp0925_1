using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace ConsoleApp0925_1
{
    class DateTime2
    {
        static void Main()
        {
            System.Timers.Timer timer1 = new System.Timers.Timer(); //멀티스레드 기반 타이머
            timer1.Interval = 1000; //ms
            timer1.Elapsed += Timer1_Elapsed;
            timer1.Start();

            Console.Read();
        }

        private static void Timer1_Elapsed(object sender, ElapsedEventArgs e)
        { 

            Console.WriteLine(DateTime.Now);
        }
    }
}
