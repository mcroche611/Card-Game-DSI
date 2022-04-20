using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace card_game_DSI
{
    public class Email
    {
        public string sender { get; set; }
        public string subject { get; set; }
        public bool read { get; set; }

        public Email(string from, string body)
        {
            sender = "from " + from;
            subject = body;
            read = false;
        }

        public void Open()
        {
            read = true;
        }
    }
}
