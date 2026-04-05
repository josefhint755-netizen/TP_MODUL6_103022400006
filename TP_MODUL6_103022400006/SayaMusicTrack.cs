using System;

namespace TP_MODUL6_103022400006
{
    public class SayaMusicTrack
    {
        public int id;
        public int playCount;
        public string title;

        public SayaMusicTrack(string title)
        {
            Random random = new Random();
            id = random.Next(10000, 100000);
            this.title = title;
            playCount = 0;
        }

        public void IncreasePlayCount(int count)
        {
            playCount += count;
        }

        public void PrintTrackDetails()
        {
            Console.WriteLine("Detail Track");
            Console.WriteLine("ID        : " + id);
            Console.WriteLine("Title     : " + title);
            Console.WriteLine("Play Count: " + playCount);
            Console.WriteLine();
        }
    }
}
