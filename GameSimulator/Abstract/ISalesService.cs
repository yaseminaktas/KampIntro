using GameSimulator.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSimulator.Abstract
{
    internal interface ISalesService
    {
        public void Buy(Player player, Game game);
        public void Buy2(Player player, Game game, Campaign campaign);
    }
}
