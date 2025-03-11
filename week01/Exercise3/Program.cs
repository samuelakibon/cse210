using System;

class Program
{
    static void Main(string[] args)
    {

        Console.Write("What is the magic number? ");
        String magicNumber = Console.ReadLine();
        int mnumber = int.Parse(magicNumber);

        Random randomGenerator = new Random();
        mnumber = randomGenerator.Next(1, 101);

        int gnumber;

        do
        {


            Console.Write("What is your guess? ");
            String guessNumber = Console.ReadLine();
            gnumber = int.Parse(guessNumber);

            if (mnumber > gnumber)
            {
                Console.WriteLine("Higher");
            }
            else if (mnumber == gnumber)
            {
                Console.WriteLine("You guessed it!");
            }
            else
            {
                Console.WriteLine("Lower");
            }




        } while (gnumber != mnumber);



    }
}