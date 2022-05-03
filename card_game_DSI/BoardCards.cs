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
            new Card("Rey Rata", "Rey Rata"),
            new Card("Rana Toro", "Rana Toro", "This will be an interesting research"),
            new Card("Sabueso", "BubbleYuno", "You seem a little dirty, don't ya?"),
            new Card("Vibora", "JudyVertigo", "Help me!"),
        };

        public static List<Card> boardCards2 = new List<Card>()
        {
             new Card("Vibora", "JudyVertigo", "Help me!"),
            new Card("Rey Rata", "Kaycee21"),
        };

        public static List<Card> handCards = new List<Card>()
        {
             new Card("Vibora", "JudyVertigo", "Help me!", 0),
            new Card("Rey Rata", "Kaycee21", "hello", 1),
            new Card("Rana Toro", "Rana Toro", "This will be an interesting research", 2),
            new Card("Sabueso", "BubbleYuno", "You seem a little dirty, don't ya?", 3),
        };

        public static List<Card> cardBack = new List<Card>()
        {
             new Card("common", "JudyVertigo", "Help me!"),
        };

        public static List<Card> squirrelCard = new List<Card>()
        {
             new Card("squirrel", "JudyVertigo", "Help me!"),
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

        public static IList<Card> GetCardBack()
        {
            return cardBack;
        }

        public static IList<Card> GetSquirrelCard()
        {
            return squirrelCard;
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

        public static Card GetCardBackById(int id)
        {
            return cardBack[id];
        }

        public static Card GetSquirrelCardById(int id)
        {
            return squirrelCard[id];
        }
    }
}