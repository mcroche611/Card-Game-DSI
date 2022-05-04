using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace card_game_DSI
{
    public class Add
    {
        public int id { get; set; }
        public string subject { get; set; }
        public string sender { get; set; }
        public int precio { get; set; }
        public string profilePicture { get; set; }
        public string itemPicture { get; set; }

        public Add(int i, string sub, string send, int pre)
        {
            id = i;
            subject = sub;
            sender = send;
            precio = pre;
            profilePicture = $"Assets\\Profile Pictures\\{id}.png";
            itemPicture = $"Assets\\Item Pictures\\{id}.png";
        }
    }
}
