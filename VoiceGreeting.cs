using System.Media;
using System;

namespace ChatBot
{
    internal class VoiceGreeting
    {

        // Dispaly the voice greeting filepath
        public void Play(string filePath)
            {
                try
                {
                    using (SoundPlayer player = new SoundPlayer(filePath))
                    {
                        player.PlaySync();
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Bot: (Audio could not be played. Ensure 'Greeting.wav' exists.)");
                }
            }

        }
    }

