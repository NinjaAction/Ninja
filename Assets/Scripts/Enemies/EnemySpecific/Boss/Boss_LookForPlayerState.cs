using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss_LookForPlayerState : LookForPlayerState
{
    private Boss boss;
    public Boss_LookForPlayerState(Entity etity, FinteStateMachine stateMachine, string animBoolName, D_LookForPlayer stateData, Boss boss) : base(etity, stateMachine, animBoolName, stateData)
    {
        this.boss = boss;
    }

    public override void DoChecks()
    {
        base.DoChecks();
    }

    public override void Enter()
    {
        base.Enter();
    }

    public override void Exit()
    {
        base.Exit();
    }

    public override void LogicUpdate()
    {
        base.LogicUpdate();

        if (isPlayerInMinagroRange)
        {
            stateMachine.ChangeState(boss.playerDetectedState);
        }
        else if (isAllTurnsDone)
        {
            stateMachine.ChangeState(boss.moveState);
        }
    }

    public override void PhysicsUpdate()
    {
        base.PhysicsUpdate();
    }
}
