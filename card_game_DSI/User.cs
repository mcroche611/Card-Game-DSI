using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace card_game_DSI
{
    public class User
    {
        public int id { get; set; }
        public string username { get; set; }
        public string profilePicture { get; set; }
        public string status { get; set; }
        public int points { get; set; }

        public User(int identificator, string name, int punctuation) { 
            id = identificator;
            username = name;
            profilePicture = $"Assets\\Profile Pictures\\{id}.png";
            status = "Hey there! Wanna battle me?";
            points = punctuation;
        }
    }
}
