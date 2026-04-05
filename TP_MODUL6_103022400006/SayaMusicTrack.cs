using System;

namespace TP_MODUL6_103022400006
{
    public class SayaMusicTrack
    {
        private static readonly Random random = new Random();

        public int id;
        public int playCount;
        public string title;

        public SayaMusicTrack(string title)
        {
            if (title == null)
            {
                throw new ArgumentNullException(nameof(title), "Judul track tidak boleh null.");
            }

            if (title.Length > 100)
            {
                throw new ArgumentException("Judul track maksimal 100 karakter.");
            }

            id = random.Next(10000, 100000);
            this.title = title;
            playCount = 0;
        }

        public bool IncreasePlayCount(int count)
        {
            if (count < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(count), "Penambahan play count tidak boleh negatif.");
            }

            if (count > 10000000)
            {
                throw new ArgumentOutOfRangeException(nameof(count), "Penambahan play count maksimal 10.000.000.");
            }

            try
            {
                checked
                {
                    playCount += count;
                }

                return true;
            }
            catch (OverflowException)
            {
                Console.WriteLine("Error: Terjadi overflow. Nilai playCount melebihi batas integer.");
                return false;
            }
        }

        public void PrintTrackDetails()
        {
            Console.WriteLine("Detail Track");
            Console.WriteLine($"ID         : {id}");
            Console.WriteLine($"Title      : {title}");
            Console.WriteLine($"Play Count : {playCount}");
            Console.WriteLine();
        }
    }
}