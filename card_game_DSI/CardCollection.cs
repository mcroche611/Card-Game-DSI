using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace card_game_DSI
{
    public class CardCollection
    {
        public static List<Card> cards = new List<Card>()
        {
            new Card("Rey Rata", "Rey Rata", 6123), 
            new Card("Rana Toro", "Rana Toro", 6120, "This will be an interesting research"), 
            new Card("Sabueso", "BubbleYuno", 6114, "You seem a little dirty, don't ya?"), 
            new Card("Vibora", "JudyVertigo", 6111, "Help me!"),
            new Card("Vibora", "JudyVertigo", 6111, "Help me!"),
            new Card("Rey Rata", "Kaycee21", 6123),
            new Card("Rana Toro", "Rana Toro", 6120, "This will be an interesting research"),
            new Card("Sabueso", "BubbleYuno", 6114, "You seem a little dirty, don't ya?"),
            new Card("Vibora", "JudyVertigo", 6111, "Help me!"),
            new Card("Vibora", "JudyVertigo", 6111, "Help me!"),
            new Card("Zarigueya", "RodriguezPaellas", 6098, "Paella va!") 
        };

        public static IList<Card> GetCards()
        {
            return cards;
        }

        public static Card GetCardById(int id)
        {
            return cards[id];
        }
    }
}
