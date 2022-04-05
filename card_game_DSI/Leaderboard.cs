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
            new User(1, "Kaycee21"), 
            new User(2, "TheExplorer"), 
            new User(3, "BubbleYuno"), 
            new User(4, "JudyVertigo"), 
            new User(5, "RodriguezPaellas") 
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
