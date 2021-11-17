using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IplApplication1
{
   public class PlayerBO
    {
        public Player[] SearchBYTeamName(Player[] playerList)
        {
            //Player[] results=null;
            SortByTeamName ascSotbyTeam = new SortByTeamName();
            Array.Sort(playerList, ascSotbyTeam);
            //results = playerList;
            return playerList;
        }
        public Player[] SearchBYBattingStyle(Player[] playerList)
        {
            Player[] results = null;
            SortDesPlayer obj_sort = new SortDesPlayer();
            Array.Sort(playerList, obj_sort);
            Array.Reverse(playerList);
            results = playerList;
            return results;
        }
    }
}
