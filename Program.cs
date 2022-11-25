using System;

namespace Upp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int Carrots = 40;

            int timerEtt = 0;
            int timerTvå = 0;
            int timerReset = 0;

            int TorAmount = 0;
            int MorAmount = 0;
            Console.Write(value: "Hur lång tid tar Tor på sig att äta en morot: ");
            int tidEtt = Convert.ToInt32(value: Console.ReadLine());
            Console.Write(value: "Hur lång tid tar Mor på sig att äta en morot: ");
            int tidTvå = Convert.ToInt32(value: Console.ReadLine());
                while (Carrots != 0) {
                    if (timerEtt == tidEtt && Carrots != 0) {
                        TorAmount++;
                        Carrots--;
                        timerEtt = timerReset;
                    } else if (timerTvå == tidTvå  && Carrots != 0) {
                        MorAmount++;
                        Carrots--;
                        timerTvå = timerReset;
                    } else {
                        timerEtt++; 
                        timerTvå++; 
                    }
                }
            Console.WriteLine(value: "Tor åt: " + TorAmount + " morötter");
            Console.WriteLine(value: "Mor åt: " + MorAmount + " morötter");     
        }
    }
}
