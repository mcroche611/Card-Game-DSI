using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace card_game_DSI
{
    public class ExchangeList
    {
        public static List<Add> addList = new List<Add>()
        {
            new Add(1, "Kaycee21", "Mazo original completo", 2500),
            new Add(2, "TheExplorer", "Sobre de cartas legendarias", 4000),
            new Add(3, "BubbleYuno", "Me tocó la legendaria de este mes", 1600),
            new Add(4, "JudyVertigo", "NO ME GUSTA ESTE ARMIÑO, LO VENDO GRATIS", 1),
            new Add(5, "RodriguezPaellas", "¡Carta va!", 2000)
        };

        public static IList<Add> GetAddList()
        {
            return addList;
        }

        public static Add GetAddById(int id)
        {
            return addList[id];
        }
    }
}
