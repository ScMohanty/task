using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IplApplication1
{
    class SortDesPlayer : IComparer<Player>
    {
        public int Compare(Player x, Player y)
        {
            return x.BattingStyle.CompareTo(y.BattingStyle);
        }
    }
}
