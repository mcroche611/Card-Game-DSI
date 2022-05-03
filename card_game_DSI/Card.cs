using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace card_game_DSI
{
    public class Card
    {
        public string id { get; set; }
        public string description { get; set; }
        public string cardPicture { get; set; }
        public int num { get; set; }

        public Card(string identificator, string name,
            string cardDescription = "Descripción", int num = 0)
        {
            id = identificator;
            description = "La carta " + name + " " + cardDescription;
            cardPicture = $"Assets\\Cards\\{id}.jpg";
        }
    }
}

