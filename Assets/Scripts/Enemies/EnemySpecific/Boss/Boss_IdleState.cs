using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss_IdleState : IdleState
{
    private Boss boss;
    public Boss_IdleState(Entity etity, FinteStateMachine stateMachine, string animBoolName, D_IdleState stateData, Boss boss) : base(etity, stateMachine, animBoolName, stateData)
    {
        this.boss = boss;
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
        if (isPlayerInMinAgroRange)
        {
            stateMachine.ChangeState(boss.playerDetectedState);
        }
        else if (isIdleTimeOver)
        {
            stateMachine.ChangeState(boss.moveState);
        }
    }

    public override void PhysicsUpdate()
    {
        base.PhysicsUpdate();
    }
}
