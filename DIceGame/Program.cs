using System;

namespace DIceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //mängus on kaks mängijat
            //mõlemad mängijad viskavad täringut
            //programm kontrollib, kumb mängija viskas rohkem
            //mängija, kes viskas rohkem ongi võitja
            //programm kuulutab võitjat

            Random rnd = new Random();

            string PlayerOne = "Sina";
            string PlayerTwo = "Arvuti";

            int RandomNumber = rnd.Next(1, 7);
            Console.WriteLine($"{PlayerOne}, veeretasid {RandomNumber}.");
            int Myrandom = rnd.Next(1, 7);
            Console.WriteLine($"{PlayerTwo}, veeretas {Myrandom}.");
            if (RandomNumber > Myrandom)
            {
                Console.WriteLine($"{PlayerOne} Võitsid!");
            }
            else if(RandomNumber < Myrandom)
            {
                Console.WriteLine($"{PlayerTwo} Võitis!");
            }
            else
            {
                Console.WriteLine("Viik, proovige uuesti");
            }
        }
    }
}
