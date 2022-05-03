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

        public static List<Card> allCards = new List<Card>()
        {
            new Card("Abeja", "Abeja", "tiene una cualidad de vuelo, con 1 de ataque y un coste de 1 punto de sacrificio."),
            new Card("Alce Macho", "Alce Macho", "tiene una cualidad de vuelo, con 1 de ataque y un coste de 1 punto de sacrificio."),
            new Card("Alce", "Alce", "tiene una cualidad de vuelo, con 1 de ataque y un coste de 1 punto de sacrificio."),
            new Card("Alfa", "Alfa", "tiene una cualidad de vuelo, con 1 de ataque y un coste de 1 punto de sacrificio."),
            new Card("Amalgama", "Amalgama", "tiene una cualidad de vuelo, con 1 de ataque y un coste de 1 punto de sacrificio."),
            new Card("Ardilla", "Ardilla", "tiene una cualidad de vuelo, con 1 de ataque y un coste de 1 punto de sacrificio."),
            new Card("Berrendo", "Berrendo", "tiene una cualidad de vuelo, con 1 de ataque y un coste de 1 punto de sacrificio."),
            new Card("Cuervo", "Cuervo", "tiene una cualidad de vuelo, con 1 de ataque y un coste de 1 punto de sacrificio."),
            new Card("Gato", "Gato", "tiene una cualidad de vuelo, con 1 de ataque y un coste de 1 punto de sacrificio."),
            new Card("Grizzly", "Grizzly", "tiene una cualidad de vuelo, con 1 de ataque y un coste de 1 punto de sacrificio."),
            new Card("Mantis", "Mantis", "tiene una cualidad de vuelo, con 1 de ataque y un coste de 1 punto de sacrificio."),
            new Card("Coyote", "Coyote", "tiene una cualidad de vuelo, con 1 de ataque y un coste de 1 punto de sacrificio."),
            new Card("Conejo", "Conejo", "tiene una cualidad de vuelo, con 1 de ataque y un coste de 1 punto de sacrificio."),
            new Card("Geco", "Geco", "tiene una cualidad de vuelo, con 1 de ataque y un coste de 1 punto de sacrificio."),
            new Card("Cabra Negra", "Cabra Negra", "tiene una cualidad de vuelo, con 1 de ataque y un coste de 1 punto de sacrificio."),
            new Card("Hurraca", "Hurraca", "tiene una cualidad de vuelo, con 1 de ataque y un coste de 1 punto de sacrificio."),
            new Card("Rana Toro", "Rana Toro", "tiene una cualidad de vuelo, con 1 de ataque y un coste de 1 punto de sacrificio."),
            new Card("Topo", "Topo", "tiene una cualidad de vuelo, con 1 de ataque y un coste de 1 punto de sacrificio.")
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

        public static IList<Card> GetAllCards()
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

        public static Card GetAllCardById(int id)
        {
            return allCards[id];
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