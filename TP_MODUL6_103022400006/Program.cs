using System;
using TP_MODUL6_103022400006;

namespace TP_MODUL6_103022400006
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SayaMusicTrack track1 = new SayaMusicTrack("Hingga Tua Bersama");

            track1.PrintTrackDetails();

            track1.IncreasePlayCount(5000);
            track1.IncreasePlayCount(2500);

            track1.PrintTrackDetails();

            Console.ReadKey();
        }
    }
}