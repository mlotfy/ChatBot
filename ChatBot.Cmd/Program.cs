using AIMLbot;
using System;

namespace ChatBot.Cmd
{
    class Program
    {
        static void Main(string[] args)
        {
            Bot AI = new Bot(); // This defines the object "AI" To hold the bot's infomation

            AI.loadSettings(); // This loads the settings from the config folder

            AI.loadAIMLFromFiles(); // This loads the AIML files from the aiml folder

            AI.isAcceptingUserInput = false; // This swithes off the bot to stop the user entering input while the bot is loading

            User myUser = new User("Mostafa", AI); // This creates a new User called "Username", using the object "AI"'s information.

            AI.isAcceptingUserInput = true; // This swithces the user input back on

            while (true)
            { // This starts a loop forever so the bot will keep replying and accepting input

                Request r = new Request(Console.ReadLine(), myUser, AI); // This generates a request using the Console's ReadLine function to get text from the console, the user and the AI object's.

                Result res = AI.Chat(r); // This sends the request off to the object AI to get a reply back based of the AIML file's.

                Console.WriteLine("Robot: " + res.Output); // This display's the output in the console by retrieving a string from res.Output
            }


        } // This is the end of the loop which would repeat back to the "While (true)" part
    
    }
}
