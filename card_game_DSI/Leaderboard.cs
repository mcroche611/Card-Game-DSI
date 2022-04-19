using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace card_game_DSI
{
    public class Leaderboard
    {
        public static List<User> leaderboard = new List<User>()
        {
            new User(1, "Kaycee21", 6123), 
            new User(2, "TheExplorer", 6120), 
            new User(3, "BubbleYuno", 6114), 
            new User(4, "JudyVertigo", 6111), 
            new User(5, "RodriguezPaellas", 6098) 
        };

        public static IList<User> GetLeaderboard()
        {
            return leaderboard;
        }

        public static User GetDronById(int id)
        {
            return leaderboard[id];
        }
    }
}
