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
        public string status { get; set; }
        public int points { get; set; }

        public Card(string identificator, string name, int punctuation,
            string statusMessage = "Descripción")
        {
            id = identificator;
            description = identificator;
            cardPicture = $"Assets\\Cards\\{id}.jpg";
            status = statusMessage;
            points = punctuation;
        }
    }
}

