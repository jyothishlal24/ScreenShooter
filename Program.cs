using System;
using System.Drawing.Imaging;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace ScreenShooter
{
    class Program
    {

        private static int _timespan = 180000;
        static async Task Main(string[] args)
        {

            PrintScreen ps = new PrintScreen();
            var countScreens = 0;
            while (true)
            {
                await ps.StartPrinting(ps);
                Thread.Sleep(_timespan);

                if (countScreens == 20)
                {
                    System.GC.Collect();
                    countScreens = 0;
                }
                countScreens++;
            }


        }
    }
}