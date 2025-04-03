using System.Threading;
using System;

namespace ChatBot
{
    internal class TypingSimulator
    {
      public void SimulateTyping(string message)
            {
                Console.Write("Bot: ");
                foreach (char c in message)
                {
                    Console.Write(c);
                    Thread.Sleep(30);
                }
                Console.WriteLine();
            }
        }
    }
    
