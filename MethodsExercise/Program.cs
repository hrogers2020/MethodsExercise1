using System;

namespace MethodsExercise
{
    class Program
    {
   
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();

            Console.WriteLine("How old are you?");
            string age = Console.ReadLine();

            Console.WriteLine("What is your favorite guitar?");
            string userGuitar = Console.ReadLine();

            Console.WriteLine("What is the color of that guitar?");
            string guitarColor = Console.ReadLine();

            Console.WriteLine($"I have a coding buddy named {userName}, he is {age} years old.");
            Console.WriteLine($"He had a favorite guitar: {userGuitar}. His favorite thing about the guitar was its {guitarColor} coloration" );
            Console.WriteLine($"{userName} loved his {userGuitar} but had to sell it bc of layoffs due to the 'Rona :(");


        }
    }
}
