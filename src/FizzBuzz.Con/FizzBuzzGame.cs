namespace FizzBuzz.Con;

public static class FizzBuzzGame
{
    public static void Start()
    {
        Console.WriteLine("FizzBuzz!");
        Console.WriteLine("----------");
        Console.WriteLine("The learning exercise we all love but deep, deep down inside we wish we had a better way to show TDD!");
        Console.WriteLine("");
        Console.WriteLine("Here are the rules...");
        Console.WriteLine("Give me a number, any number, and I'll do a little magic.");
        Console.WriteLine("- If the number is divisible by 3, I will return 'Fizz'");
        Console.WriteLine("- If the number is divisible by 5, I will return 'Buzz'");
        Console.WriteLine("- If the number is divisible by 3 and 5, I will return 'FizzBuzz'");
        Console.WriteLine("- If the number is NOT divisible by either 3 or 5, I will return the number provided");
        Console.WriteLine("");
        Console.WriteLine("Easy enough, right? Let's get started.");
        
        Play();
    }

    private static void Play()
    {
        while (true)
        {
            Console.WriteLine("Give me a number, any number");
            var input = Console.ReadLine();
            if (string.IsNullOrEmpty(input) || input.ToLower() == "exit")
            {
                Console.WriteLine("Thanks for playing! Good bye 🦆");
                return;
            }

            if (!int.TryParse(input, out var isNumber))
            {
                Console.WriteLine("You did not input a number, let's give that another try!");
                continue;
            }

            Console.WriteLine("");
            Console.WriteLine("Well, my response to you is " + isNumber);
            Console.WriteLine("-------");
            Console.WriteLine("Let's do that again!");
            Console.WriteLine("");
        }
    }
}