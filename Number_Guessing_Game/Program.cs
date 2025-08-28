
// data_type variable_name = value
Random r = new Random();

var rando = r.Next(1 , 6); // This generates a random numver between 1-5

Console.WriteLine($"Generated a random number with the value: {rando}");

int guess;
int count = 0;

do
{
    Console.WriteLine("Please guess a number between 1 and 5:");
    string? userInput = Console.ReadLine();
    guess = int.Parse(userInput);
    count++;
    Console.WriteLine($"You guessed: {userInput}");

    //if (rando == guess)
    //{
    //	Console.WriteLine("Congratulations you guess correctly!");
    //}
    //else
    //{
    //	Console.WriteLine("Sorry! you guess incorrectly!");
    //} 
    if (rando != guess)
    {
        if (guess > rando)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Sorry, you guessed too high!");
            Console.ForegroundColor = ConsoleColor.White;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Sorry, you guessed too low!");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
} while (guess != rando);
Console.WriteLine($"Congratulations you guess correctly and it only toke {count} attempts!");

// Console.WriteLine($"Generated a random number with the value: {rando}");




