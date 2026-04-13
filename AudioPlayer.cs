using System;
using System.Media;

namespace CyberAwareAssistant
{
    public class AudioPlayer
    {
        // Plays the greeting WAV file
        public void PlayGreeting()
        {
            try
            {
                SoundPlayer player = new SoundPlayer(
                    @"C:\Users\Nosiphephelo kaKheth\Desktop\Akhona\greeting.wav"
                );

                player.PlaySync();
            }
            catch
            {
                Console.WriteLine("Greeting audio file not found.");
            }
        }
    }
}