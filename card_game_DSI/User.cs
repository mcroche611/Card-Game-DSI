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

        public User(int identificator, string name) { 
            id = identificator;
            username = name;
            profilePicture = $"Assets\\Profile Pictures\\{id}.jpg";
            status = "Hey there! Wanna battle me?";
        }
    }
}
