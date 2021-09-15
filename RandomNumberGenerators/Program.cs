using System;

namespace RandomNumberGenerators
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int myRandomNumber = rnd.Next(1,11);

            Console.WriteLine($"Sinu number on {myRandomNumber}");
            //programm kontrollib, kas genereeritud number on suurem kui 5
            //kui genereeritud number n suurem kui 5, programm kuvab
            //"juhuslik number on {myRandomNumber}, see on väiksem kui 5"
            //kui genereeritud number on 5, programm kuvab
            //"juhuslik number on 5"
            //< - väiksem kui, > - suurem kui, == - võrdne

            if (myRandomNumber < 5)
            {
                Console.WriteLine($"juhusliknumber on {myRandomNumber}, see on suurem kui 5");
            }
            else if (myRandomNumber > 5)
            {
                Console.WriteLine($"juhuslik number on {myRandomNumber}, see on väiksem kui 5");
            } 
            else 
            {
                Console.WriteLine("juhuslik number on 5");
            }

        }
    }
}
