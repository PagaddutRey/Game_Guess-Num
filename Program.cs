
// See https://aka.ms/new-console-template for more information

using System.ComponentModel.Design;

// auto gen number
Random random = new Random();
int secretNum = random.Next(1, 100);

string input;
int guessCount = 0;
int maxGuess = 7;

Console.WriteLine("Welcome Player \n" + "Can you Guess the Number in 8 Tries?");
Console.WriteLine("\nI've choosen a Number from 1-100.");
Console.WriteLine("\nYou have 8 tries to get it right goodluck");


while (guessCount < maxGuess)
{
    Console.WriteLine("Enter your Guess: ");
    input = (Console.ReadLine());

    int guess;
    //conversion
    if (int.TryParse(input, out guess))
    {
        //loop
        guessCount++;
        if (guess == secretNum)
        {
            Console.WriteLine($"Congratulations You've guessed the number in {0}", maxGuess - guessCount + " tries");
            break;
        }

        if (guess < secretNum)
        {
            Console.WriteLine("Too Low! you have {0}", maxGuess - guessCount + " tries");
        }
        else
        {
            Console.WriteLine("Too High! you have {0}", maxGuess - guessCount + " tries");
        }

    }

    else
    {
        Console.WriteLine("please input number");
    }
}

if (guessCount == maxGuess)
{
    Console.WriteLine("Sorry you've run out of guesses! \nThe number was {0}", secretNum);
}

Console.WriteLine("\nThank you for Participating");
