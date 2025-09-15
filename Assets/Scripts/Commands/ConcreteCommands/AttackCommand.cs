using Command.Actions;
using Command.Command.AbstractCommand;
using Command.Main;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackCommand : UnitCommand
{
    private bool willHitTarget;

    public AttackCommand(CommandData commandData)
    {
        this.commandData = commandData;
        willHitTarget = WillHitTarget();
    }

    public override bool WillHitTarget() => true;

    public override void Execute()
    {
        GameService.Instance.ActionService.GetActionByType(CommandType.Attack).PerformAction(actorUnit, targetUnit, willHitTarget);
    }

}
