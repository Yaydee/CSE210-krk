using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 100);
        int guess = 0;

        while (guess != number) {
            Console.Write("What is the magic number? ");
            guess = int.Parse(Console.ReadLine());

            if (guess > number) {
                Console.WriteLine("Lower");
            }
            else if (guess < number) {
                Console.WriteLine("Higher");
            } else {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}