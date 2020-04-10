using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AIMLbot;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ChatBot.Core.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BotController : ControllerBase
    {
        private readonly ILogger<BotController> _logger;
        Bot AI = new Bot(); // This defines the object "AI" To hold the bot's infomation
        User myUser;// This creates a new User called "Username", using the object "AI"'s information.
        //List<string> chats;
        static List<string> data= new List<string>
                 {
                    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"

                 };
        public BotController(ILogger<BotController> logger, IHostingEnvironment hostingEnvironment)
        {
            ;
            _logger = logger;
          //  Environment.CurrentDirectory = hostingEnvironment.ContentRootPath;

            AI.loadSettings(); // This loads the settings from the config folder

            AI.loadAIMLFromFiles(); // This loads the AIML files from the aiml folder

            AI.isAcceptingUserInput = false; // This swithes off the bot to stop the user entering input while the bot is loading

            myUser = new User("Mostafa", AI); // This creates a new User called "Username", using the object "AI"'s information.

            AI.isAcceptingUserInput = true; // This swithces the user input back on


        }
        // GET: api/Bot
        [HttpGet]
        public List<string> Get()
        {
            return data;
        }


        // POST: api/Bot
        [HttpPost]
        public string Post( string value)
        {
            Request r = new Request(value, myUser, AI); // This generates a request using the Console's ReadLine function to get text from the console, the user and the AI object's.

            Result res = AI.Chat(r);

            return res.Output;
        }


    }
}
