using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Santase.Logic.Players
{
    public class Player : BasePlayer
    {
        public Player()
            : base()
        {

        }

        public override PlayerAction GetTurn(PlayerTurnContext context, IPlayerActionValidater actionValidater)
        {
            // TODO: implement method
            return null;
        }
    }
}
