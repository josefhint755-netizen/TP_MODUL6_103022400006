using System;

namespace TP_MODUL6_103022400006
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TestNormal();
            TestTitleNull();
            TestTitleTooLong();
            TestPlayCountExceedsLimit();
            TestOverflow();

            Console.WriteLine("Program selesai. Tekan sembarang tombol untuk keluar.");
            Console.ReadKey();
        }

        static void TestNormal()
        {
            Console.WriteLine("=== TEST NORMAL ===");

            try
            {
                SayaMusicTrack track = new SayaMusicTrack("Hingga Tua Bersama");
                track.PrintTrackDetails();

                track.IncreasePlayCount(5000);
                track.IncreasePlayCount(2500);

                track.PrintTrackDetails();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Terjadi error: " + ex.Message);
            }

            Console.WriteLine();
        }

        static void TestTitleNull()
        {
            Console.WriteLine("=== TEST PRECONDITION: TITLE NULL ===");

            try
            {
                SayaMusicTrack track = new SayaMusicTrack(null);
                track.PrintTrackDetails();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Terjadi error: " + ex.Message);
            }

            Console.WriteLine();
        }

        static void TestTitleTooLong()
        {
            Console.WriteLine("=== TEST PRECONDITION: TITLE > 100 KARAKTER ===");

            try
            {
                string judulPanjang = new string('A', 101);
                SayaMusicTrack track = new SayaMusicTrack(judulPanjang);
                track.PrintTrackDetails();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Terjadi error: " + ex.Message);
            }

            Console.WriteLine();
        }

        static void TestPlayCountExceedsLimit()
        {
            Console.WriteLine("=== TEST PRECONDITION: COUNT > 10.000.000 ===");

            try
            {
                SayaMusicTrack track = new SayaMusicTrack("Track Batas Maksimum");
                track.IncreasePlayCount(10000001);
                track.PrintTrackDetails();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Terjadi error: " + ex.Message);
            }

            Console.WriteLine();
        }

        static void TestOverflow()
        {
            Console.WriteLine("=== TEST EXCEPTION OVERFLOW ===");

            try
            {
                SayaMusicTrack track = new SayaMusicTrack("Track Overflow Test");

                for (int i = 0; i < 300; i++)
                {
                    bool berhasil = track.IncreasePlayCount(10000000);

                    if (!berhasil)
                    {
                        break;
                    }
                }

                track.PrintTrackDetails();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Terjadi error: " + ex.Message);
            }

            Console.WriteLine();
        }
    }
}