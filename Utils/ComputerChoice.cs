using System;

namespace rps_cs
{
    class ComputerChoice
    {
        public string GetChoice()
        {
            var r = new Random();
            int choice = r.Next(1, 4);
            if(choice == 1)
            {
                return "rock";
            }
            else if(choice == 2)
            {
                return "paper";
            }
            else 
            {
                return "scissor";
            }
        }
    }
}