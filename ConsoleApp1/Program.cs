class Program
{
    static void Main(string[] args)
    {
        string[] choices = { "rock", "paper", "scissors" };
        Random random = new Random();

        Console.WriteLine("Enter your choice: ");
        string userChoice = Console.ReadLine().ToLower();

        if (Array.IndexOf(choices, userChoice) == -1)
        {
            Console.WriteLine("Invalid choice!");
            return;
        }

        int computerIndex = random.Next(choices.Length);
        string computerChoice = choices[computerIndex];

        Console.WriteLine($"Computer chose: {computerChoice}");

        if (userChoice == computerChoice)
        {
            Console.WriteLine("It's a tie!");
        }
        else if ((userChoice == "rock" && computerChoice == "scissors") ||
                 (userChoice == "paper" && computerChoice == "rock") ||
                 (userChoice == "scissors" && computerChoice == "paper"))
        {
            Console.WriteLine("You win!");
        }
        else
        {
            Console.WriteLine("Computer wins!");
            Console.ReadLine();
        }
    }
}