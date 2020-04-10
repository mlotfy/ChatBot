using AIMLbot;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChatBot
{
   
    public partial class _Default : Page
    {
        Bot AI = new Bot(); // This defines the object "AI" To hold the bot's infomation
        User myUser;// This creates a new User called "Username", using the object "AI"'s information.
        List<string> chats;
        protected void Page_Load(object sender, EventArgs e)
        {
            Refresh();
            // string path = Path.Combine(Server.MapPath("~\\"), Path.Combine("config", "Settings.xml"));
            //Server.MapPath("~\\config\\");

            Environment.CurrentDirectory = Server.MapPath("~\\");

            AI.loadSettings(); // This loads the settings from the config folder

            AI.loadAIMLFromFiles(); // This loads the AIML files from the aiml folder

            AI.isAcceptingUserInput = false; // This swithes off the bot to stop the user entering input while the bot is loading

            myUser = new User("Mostafa", AI); // This creates a new User called "Username", using the object "AI"'s information.

            AI.isAcceptingUserInput = true; // This swithces the user input back on




        }

        private void Refresh()
        {
            if (ViewState["Chats"] != null)
            {
                chats = (List<string>)ViewState["Chats"];
                Panel1.Controls.Clear();
                foreach (string s in chats)
                {
                    var lbl = new Label() { ID = Guid.NewGuid().ToString(), Text = s };
                    if (s.StartsWith("Mostafa "))
                    {
                        lbl.ForeColor = Color.Red;
                    }
                    Panel1.Controls.Add(lbl);

                    Panel1.Controls.Add(new LiteralControl("<br/>"));


                }
            }
            TextBox1.Focus();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            if(string.IsNullOrWhiteSpace(TextBox1.Text))
            {
                return;
            }
            Request r = new Request(TextBox1.Text, myUser, AI); // This generates a request using the Console's ReadLine function to get text from the console, the user and the AI object's.

            Result res = AI.Chat(r); // This sends the request off to the object AI to get a reply back based of the AIML file's.

            if (ViewState["Chats"] != null)
            {
                chats = (List<string>)ViewState["Chats"];
            }
            else
            {
                chats = new List<string>();
            }
            chats.Add("Mostafa : " + TextBox1.Text);
            chats.Add("Chatbot : " + res.Output);

            ViewState["Chats"] = chats;
                     //Console.WriteLine("Robot: " + res.Output); // This display's the output in the console by retrieving a string from res.Output
            TextBox1.Text = "";
            Refresh();
        }

      
    }
}