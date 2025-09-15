using Command.Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Command.AbstractCommand
{
    public abstract class IUnitCommand : ICommand
    {
        public int ActorUnitID;
        public int TagetUnitID;
        public int ActorPlayerID;
        public int TargetPlayerID;

        protected UnitController actorUnit;
        protected UnitController targetUnit;

        public abstract void Execute();

        public abstract bool WillHitTarget();
    }
}
