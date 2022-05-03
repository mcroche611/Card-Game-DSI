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
            new Card("Rey Rata", "Rey Rata"), 
            new Card("Rana Toro", "Rana Toro", "This will be an interesting research"), 
            new Card("Sabueso", "BubbleYuno", "You seem a little dirty, don't ya?"), 
            new Card("Vibora", "JudyVertigo", "Help me!"),
            new Card("Vibora", "JudyVertigo", "Help me!"),
            new Card("Rey Rata", "Kaycee21"),
            new Card("Rana Toro", "Rana Toro", "This will be an interesting research"),
            new Card("Sabueso", "BubbleYuno", "You seem a little dirty, don't ya?"),
            new Card("Vibora", "JudyVertigo", "Help me!"),
            new Card("Vibora", "JudyVertigo", "Help me!"),
            new Card("Zarigueya", "RodriguezPaellas", "Paella va!") 
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
