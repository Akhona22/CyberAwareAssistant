using System;
using System.Threading;

namespace CyberAwareAssistant
{
    public class ChatBot
    {
        // Create objects from other classes
        private User user;
        private ResponseHandler responder;
        private AudioPlayer audio;

        // Constructor
        public ChatBot()
        {
            user = new User();
            responder = new ResponseHandler();
            audio = new AudioPlayer();
        }

        // Main chatbot method
        public void StartChat()
        {
            // Play voice greeting
            audio.PlayGreeting();

            // Display chatbot logo
            DisplayAsciiArt();

            // Ask for user name
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Enter your name: ");
            user.Name = Console.ReadLine();

            // Validate empty name
            while (string.IsNullOrWhiteSpace(user.Name))
            {
                Console.Write("Name cannot be empty. Please enter your name: ");
                user.Name = Console.ReadLine();
            }

            Console.WriteLine($"\nWelcome, {user.Name}! I am CyberAware Assistant.");
            Console.ResetColor();

            // Chat loop
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("\nAsk me something (type 'exit' to quit): ");

                string input = Console.ReadLine();

                // Validate empty question
                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Please enter a valid question.");
                    continue;
                }

                // Exit chatbot
                if (input.ToLower() == "exit")
                {
                    Console.WriteLine("Stay safe online. Goodbye!");
                    break;
                }

                // Get response from ResponseHandler
                string response = responder.GetResponse(input);

                // Display response with typing effect
                TypeEffect(response);
            }
        }

        // Displays ASCII Art Logo
        private void DisplayAsciiArt()
        {
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine(@"
   ██████╗██╗   ██╗██████╗ ███████╗██████╗ 
  ██╔════╝╚██╗ ██╔╝██╔══██╗██╔════╝██╔══██╗
  ██║      ╚████╔╝ ██████╔╝█████╗  ██████╔╝
  ██║       ╚██╔╝  ██╔══██╗██╔══╝  ██╔══██╗
  ╚██████╗   ██║   ██████╔╝███████╗██║  ██║
   ╚═════╝   ╚═╝   ╚═════╝ ╚══════╝╚═╝  ╚═╝

        CYBERAWARE ASSISTANT
      [ STAY SAFE ONLINE ]
");

            Console.ResetColor();
        }

        // Typing animation effect
        private void TypeEffect(string message)
        {
            foreach (char letter in message)
            {
                Console.Write(letter);
                Thread.Sleep(30);
            }

            Console.WriteLine();
        }
    }
}