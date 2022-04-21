using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace card_game_DSI
{
    public class BoardCards
    {
        public static List<Card> boardCards = new List<Card>()
        {
            new Card("Rey Rata", "Rey Rata", 6123),
            new Card("Rana Toro", "Rana Toro", 6120, "This will be an interesting research"),
            new Card("Sabueso", "BubbleYuno", 6114, "You seem a little dirty, don't ya?"),
            new Card("Vibora", "JudyVertigo", 6111, "Help me!"),
        };

        public static List<Card> boardCards2 = new List<Card>()
        {
             new Card("Vibora", "JudyVertigo", 6111, "Help me!"),
            new Card("Rey Rata", "Kaycee21", 6123),
        };

        public static List<Card> handCards = new List<Card>()
        {
             new Card("Vibora", "JudyVertigo", 6111, "Help me!", 0),
            new Card("Rey Rata", "Kaycee21", 6123, "hello", 1),
            new Card("Rana Toro", "Rana Toro", 6120, "This will be an interesting research", 2),
            new Card("Sabueso", "BubbleYuno", 6114, "You seem a little dirty, don't ya?", 3),
        };

        public static IList<Card> GetBoardCards()
        {
            return boardCards;
        }

        public static IList<Card> GetBoardCards2()
        {
            return boardCards2;
        }

        public static IList<Card> GetHandCards()
        {
            return handCards;
        }

        public static Card GetBoardCardById(int id)
        {
            return boardCards[id];
        }

        public static Card GetBoardCard2ById(int id)
        {
            return boardCards2[id];
        }

        public static Card GetHandCardById(int id)
        {
            return handCards[id];
        }
    }
}