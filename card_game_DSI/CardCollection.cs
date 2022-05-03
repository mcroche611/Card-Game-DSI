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
