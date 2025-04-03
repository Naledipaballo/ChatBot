using System;
namespace ChatBot
{
    internal class Bot
    {
        private ResponseGenerator _responseGenerator;
        private TypingSimulator _typingSimulator;
        public Bot()
        {
            //Create instance
            _responseGenerator = new ResponseGenerator();
          
            _typingSimulator = new TypingSimulator();
        }
        public void StartChat() { 
        // enter  and will display username
        Console.Write("Enter your name: ");
                string username = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(username))
                {
                    username = "Guest";
                }

    Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"\nWelcome, {username}! How can I help you with cybersecurity today?");
                Console.ResetColor();

                // Chat loop
                while (true)
                {
                    Console.Write("\nYou: ");
                    string userInput = Console.ReadLine()?.Trim().ToLower();

                    if (string.IsNullOrWhiteSpace(userInput))
                    {
                        Console.WriteLine("Bot: Please enter a valid question.");
                        continue;
                    }

if (userInput == "exit" || userInput == "quit")
{
    Console.WriteLine("Bot: See you soon,Goodbye!");
    break;
}
//calls the Getresponse method
string response = _responseGenerator.GetResponse(userInput);
                _typingSimulator.SimulateTyping(response);
                }
            }

       

    }
}
