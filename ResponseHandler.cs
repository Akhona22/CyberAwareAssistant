namespace CyberAwareAssistant
{
    public class ResponseHandler
    {
        // This method returns a response based on the user's question
        public string GetResponse(string input)
        {
            // Convert input to lowercase for easier comparison
            input = input.ToLower();

            // Respond to greeting question
            if (input.Contains("how are you"))
            {
                return "I am doing great! Ready to help you stay safe online.";
            }

            // Respond to purpose question
            else if (input.Contains("what is your purpose") || input.Contains("purpose"))
            {
                return "My purpose is to educate users about cybersecurity awareness.";
            }

            // Respond to help / available topics
            else if (input.Contains("what can i ask") || input.Contains("help"))
            {
                return "You can ask me about password safety, phishing, and safe browsing.";
            }

            // Respond to password questions
            else if (input.Contains("password"))
            {
                return "Use strong passwords with uppercase, lowercase, numbers, and symbols.";
            }

            // Respond to phishing questions
            else if (input.Contains("phishing"))
            {
                return "Never click suspicious links or emails asking for personal information.";
            }

            // Respond to safe browsing questions
            else if (input.Contains("safe browsing") || input.Contains("browser"))
            {
                return "Always check website URLs before entering personal information.";
            }

            // Default response for unknown questions
            else
            {
                return "I did not understand that. Please ask a cybersecurity-related question.";
            }
        }
    }
}