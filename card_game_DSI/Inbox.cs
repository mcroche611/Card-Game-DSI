using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace card_game_DSI
{
    public class Inbox
    {
        public static List<Email> inbox = new List<Email>()
        {
            new Email("Inscryption team", "Welcome to Inscryption!"),
            new Email("Inscryption team", "Join the regional tournament!"),
            new Email("Inscryption team", "Earn a free foil!"),
            new Email("Inscryption team", "Controversial streamer raffles 27 legendary foils"),
            new Email("Inscryption team", "Thanks for 1000000 players!")
        };

        public static IList<Email> GetInbox()
        {
            return inbox;
        }

        public static Email GetEmailById(int id)
        {
            return inbox[id];
        }
    }
}
