using Command.Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Commands
{
    public abstract class UnitCommand : ICommand
    {
        public CommandData commandData;

        protected UnitController actorUnit;
        protected UnitController targetUnit;

        public abstract void Execute();

        public abstract bool WillHitTarget();

        public void SetActorUnit(UnitController actorUnit) => this.actorUnit = actorUnit;
        public void SetTargetUnit(UnitController targetUnit) => this.targetUnit = targetUnit;

    }
}
