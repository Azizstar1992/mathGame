using System;
using System.Threading.Tasks;

class MathGame
{
    private static Random rand = new Random();

    public static async Task InitializeGame()
    {
        Console.Clear();
        int score = 0;
        int lives = 3;
        Console.WriteLine("welcome to math game.\t your main aim is multiply numbers");
        while (lives > 0)
        {
            Console.WriteLine($"You have {lives} remaining");
            int first = rand.Next(1, 10);
            int second = rand.Next(1, 10);
            int solution = first * second;
            Console.WriteLine($"Your current Score is {score}");
            Console.WriteLine($"what is {first} * {second}");
            string input = Console.ReadLine();
            int answer;
            bool success = int.TryParse(input, out answer);

            if (!success || answer != solution)
            {
                lives--;
                Console.WriteLine("You got it wrong!");
            }
            else
            {
                score++;
                Console.WriteLine($"Correct the answer was {solution}");

            }
            await Task.Delay(2000);
            Console.Clear();


        }
        Console.Clear();
        Console.WriteLine($"your final score was {score}");
    }
    
    static async Task Main()
{
    await InitializeGame();
}
}
