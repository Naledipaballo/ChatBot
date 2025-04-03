using System;

namespace ChatBot
{
    internal class Program
    {


        static void Main()
        {
            //Create instance of each class
            VoiceGreeting voiceGreeting = new VoiceGreeting();
            AsciiArt asciiArt = new AsciiArt();

            // Play voice greeting
            voiceGreeting.Play(@"C:\Users\RC_Student_lab\source\repos\ChatBot\Greeting.wav");

            // Display ASCIIArt logo
            asciiArt.Display();

            Bot bot = new Bot();
            //Start Chat loop
            bot.StartChat();

        }
    }
}
    