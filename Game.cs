using System;

namespace rps_cs
{
    class Game
    {
        public void Start()
        {
            bool running = true;
            var c = new ComputerChoice();

            int wins = 0;
            int losses = 0;
            int ties = 0;
            string result = "";

            Console.WriteLine(@"
Welcome to Rock Paper Scissors
Can you beat the computer?
Type 'rock', 'paper', or 'scissor' and find out...

Type 'q' to quit
");
            while(running)
            {
                string userInput = Console.ReadLine();
                Console.Clear();
                if (userInput == "rock" || userInput == "paper" || userInput == "scissor")
                {
                    string compChoice = c.GetChoice();
                    if(compChoice == userInput) {
                        result = "You Tied";
                        ties++;
                    }
                    else if((userInput == "rock" && compChoice == "scissor") || (userInput == "paper" && compChoice == "rock") || (userInput == "scissor" && compChoice == "paper"))
                    {
                        result = "You Won";
                        wins++;
                    }
                    else {
                        result = "You Lost";
                        losses++;
                    }
                    Console.WriteLine($"Computer's Choice: {compChoice}");
                    Console.WriteLine($"Your Choice: {userInput}");
                    Console.WriteLine(result);
                    Console.WriteLine($"Wins: {wins}     Losses: {losses}    Ties: {ties}");
                }
                else if(userInput == "q")
                {
                    running = false;
                }
                else
                {
                    Console.WriteLine("Please Type 'rock', 'paper', or 'scissor'...");
                }
            }
        }
    }
}