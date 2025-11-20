using System.Runtime.InteropServices;

Console.WriteLine("Welcome to my math game!");

MainMenu();



void MainMenu()
{
    Console.WriteLine("Please choose a gamemode:");
    Console.WriteLine("1: Addition");
    Console.WriteLine("2: Subtraction");
    Console.WriteLine("3: Multiplication");
    Console.WriteLine("4: Division");
    Console.WriteLine("5: Random");
    Console.WriteLine("6: Hard");
    Console.WriteLine("7. Exit Game");

    int gameSelect = Convert.ToInt32(Console.ReadLine());


    if (gameSelect == 1)
    {
        Addition();
    }
}

//Methods for gameplay

void Addition()
{
    Console.WriteLine("You chose addition! Welcome to the game.");
    Console.WriteLine("We will ask you 5 math questions. Please input your answer when prompted.");
    int points = 0;
    Random rand = new Random();
    int a = rand.Next(0, 10);
    int b = rand.Next(0, 10);

    for (int i = 0; i < 5; ++i)
    {
        a = rand.Next(0,10);
        b = rand.Next(0, 10);
        int solution = a + b;
        Console.WriteLine($"Please give the soltion to: {a} + {b} = ?");
        int userInput = Convert.ToInt32(Console.ReadLine());
        if (userInput == solution)
        {
            Console.WriteLine("Correct!");

            points += 1;
        }
        else
        {
            Console.WriteLine("Incorrect");
        }

    }
    Console.WriteLine($"You have completed the math game with a score of {points} / 5");
    Console.WriteLine("Do you want to play again? Y/N");
    string playAgain = Console.ReadLine().Trim().ToLower();
    if (playAgain == "y")
    {
        Console.Clear();
        MainMenu();
    }
    else
    {
        Console.WriteLine("Thanks for playing. See you next time! o7");
        Environment.Exit(0);
    }

}

int getNextNumbers()
{
    
}